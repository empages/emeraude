using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.Exceptions;
using Definux.Emeraude.Essentials.Extensions;
using Definux.Emeraude.Essentials.Helpers;
using Microsoft.AspNetCore.Components;

namespace Definux.Emeraude.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// Configuration builder for feature component based on EmPage.
    /// </summary>
    /// <typeparam name="TBaseModel">Base EmPage model.</typeparam>
    /// <typeparam name="TTargetModel">Target EmPage model.</typeparam>
    /// <typeparam name="TComponent">Component type.</typeparam>
    public class EmPageBasedFeatureConfigurationBuilder<TBaseModel, TTargetModel, TComponent>
        where TBaseModel : class, IEmPageModel, new()
        where TTargetModel : class, IEmPageModel, new()
        where TComponent : UI.Components.Views.DetailsView.EmPageFeature, new()
    {
        private readonly IDictionary<PropertyInfo, PropertyInfo> modelToComponentMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageBasedFeatureConfigurationBuilder{TBaseModel, TTargetModel, TComponent}"/> class.
        /// </summary>
        public EmPageBasedFeatureConfigurationBuilder()
        {
            this.modelToComponentMap = new Dictionary<PropertyInfo, PropertyInfo>();
        }

        /// <summary>
        /// EmPage model to component map.
        /// </summary>
        public IReadOnlyDictionary<PropertyInfo, PropertyInfo> EmPageModelToParameterMap => new ReadOnlyDictionary<PropertyInfo, PropertyInfo>(this.modelToComponentMap);

        /// <summary>
        /// Base EmPage model property info.
        /// </summary>
        public PropertyInfo BaseModelPropertyInfo { get; private set; }

        /// <summary>
        /// Target EmPage model property info.
        /// </summary>
        public PropertyInfo TargetModelPropertyInfo { get; private set; }

        /// <summary>
        /// Links two EmPage models.
        /// </summary>
        /// <param name="baseModelProperty"></param>
        /// <param name="targetModelProperty"></param>
        public void LinkEmPageModels(
            Expression<Func<TBaseModel, object>> baseModelProperty,
            Expression<Func<TTargetModel, object>> targetModelProperty)
        {
            if (baseModelProperty == null)
            {
                throw new ArgumentNullException(nameof(baseModelProperty));
            }

            if (targetModelProperty == null)
            {
                throw new ArgumentNullException(nameof(targetModelProperty));
            }

            var baseModelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(baseModelProperty) as PropertyInfo;
            if (baseModelPropertyInfo == null)
            {
                throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {baseModelProperty.Name}");
            }

            var targetModelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(targetModelProperty) as PropertyInfo;
            if (targetModelPropertyInfo == null)
            {
                throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {targetModelProperty.Name}");
            }

            this.BaseModelPropertyInfo = baseModelPropertyInfo;
            this.TargetModelPropertyInfo = targetModelPropertyInfo;
        }

        /// <summary>
        /// Map specified EmPage model property to a parameter of the feature component.
        /// </summary>
        /// <param name="modelProperty"></param>
        /// <param name="componentProperty"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="EmPageInvalidSchemaDefinitionException"></exception>
        public void MapModelPropertyToParameter(
            Expression<Func<TTargetModel, object>> modelProperty,
            Expression<Func<TComponent, object>> componentProperty)
        {
            if (modelProperty == null)
            {
                throw new ArgumentNullException(nameof(modelProperty));
            }

            if (componentProperty == null)
            {
                throw new ArgumentNullException(nameof(componentProperty));
            }

            var modelPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(modelProperty) as PropertyInfo;
            if (modelPropertyInfo == null)
            {
                throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {modelProperty.Name}");
            }

            var componentPropertyInfo = ReflectionHelpers.GetCorrectPropertyMember(componentProperty) as PropertyInfo;
            if (componentPropertyInfo == null)
            {
                throw new EmPageInvalidSchemaDefinitionException($"Cannot be extracted property information from {componentProperty.Name}");
            }

            if (!componentPropertyInfo.HasAttribute<ParameterAttribute>())
            {
                throw new EmPageInvalidSchemaDefinitionException($"{componentPropertyInfo.Name} does not have ParameterAttribute so model property assignment is not possible");
            }

            this.modelToComponentMap[modelPropertyInfo] = componentPropertyInfo;
        }
    }
}