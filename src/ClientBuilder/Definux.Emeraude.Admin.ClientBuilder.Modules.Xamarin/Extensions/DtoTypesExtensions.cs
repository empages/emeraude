using Definux.Emeraude.Admin.ClientBuilder.Models;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions
{
    public static class DtoTypesExtensions
    {
        public static string GetBindableBuildTypeName(this TypeDescription typeDescription)
        {
            string typeName = typeDescription.Name + (typeDescription.IsComplexType ? "Bindable" : string.Empty);
            if (typeDescription.IsEnum)
            {
                typeName = typeDescription.Name + "Enum";
            }
            typeName = $"{typeName}{((typeDescription.IsNullable && !typeDescription.IsComplexType && typeDescription.Name != "string") ? "?" : string.Empty)}";
            if (typeDescription.IsEnum)
            {

            }
            if (typeDescription.IsCollection)
            {
                typeName = $"ObservableCollection<{typeName}>";
            }

            return typeName;
        }
    }
}
