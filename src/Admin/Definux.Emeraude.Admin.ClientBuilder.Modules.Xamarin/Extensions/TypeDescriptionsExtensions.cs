using Definux.Emeraude.Admin.ClientBuilder.Models;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions
{
    /// <summary>
    /// Extensions for <see cref="TypeDescription"/>.
    /// </summary>
    public static class TypeDescriptionsExtensions
    {
        /// <summary>
        /// Gets bindable type of the current type description.
        /// </summary>
        /// <param name="typeDescription"></param>
        /// <returns></returns>
        public static string GetBindableBuildTypeName(this TypeDescription typeDescription)
        {
            string typeName = typeDescription.Name + (typeDescription.IsComplex ? "Bindable" : string.Empty);
            if (typeDescription.IsEnum)
            {
                typeName = typeDescription.Name + "Enum";
            }

            typeName = $"{typeName}{((typeDescription.IsNullable && !typeDescription.IsComplex && typeDescription.Name != "string") ? "?" : string.Empty)}";

            if (typeDescription.IsCollection)
            {
                typeName = $"ObservableCollection<{typeName}>";
            }

            return typeName;
        }
    }
}
