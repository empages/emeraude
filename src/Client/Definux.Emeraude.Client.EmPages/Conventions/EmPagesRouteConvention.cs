using Definux.Emeraude.Client.EmPages.Abstractions;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Emeraude.Locales.Attributes;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Linq;

namespace Definux.Emeraude.Client.EmPages.Conventions
{
    public class EmPagesRouteConvention : IApplicationModelConvention
    {
        public void Apply(ApplicationModel application)
        {
            var emPages = application.Controllers.Where(x => x.ControllerType.GetInterfaces().Contains(typeof(IEmPage)));

            foreach (var emPage in emPages)
            {
                var matchedSelectors = emPage.Selectors.Where(x => x.AttributeRouteModel != null).ToList();
                var emRouteAttributeObject = matchedSelectors
                    .Where(x => x.EndpointMetadata
                        .Any(y => y.GetType() == typeof(EmRouteAttribute)))
                    .Select(x => x.EndpointMetadata
                        .Where(y => y.GetType() == typeof(EmRouteAttribute))
                        .FirstOrDefault())
                    .FirstOrDefault();

                if (emRouteAttributeObject != null)
                {
                    EmRouteAttribute emRouteAttribute = (EmRouteAttribute)emRouteAttributeObject;
                    var languageRouteAttribute = new LanguageRouteAttribute(emRouteAttribute.Template);

                    if (matchedSelectors.Any())
                    {
                        foreach (var selectorModel in matchedSelectors)
                        {
                            var emRouteLanguageAttribute = selectorModel.EndpointMetadata.Where(x => x.GetType() == typeof(EmLanguageRouteAttribute)).FirstOrDefault();
                            if (emRouteLanguageAttribute != null)
                            {
                                var currentLanguageAttributeModel = new AttributeRouteModel(languageRouteAttribute);
                                selectorModel.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(selectorModel.AttributeRouteModel, currentLanguageAttributeModel);
                            }
                        }
                    }
                }
            }
        }
    }
}
