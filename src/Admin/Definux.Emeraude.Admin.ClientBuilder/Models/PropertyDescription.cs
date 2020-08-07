namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class PropertyDescription
    {
        public string Name { get; set; }

        public bool ReadOnly { get; set; }

        public TypeDescription Type { get; set; }

        public string DefaultValue { get; set; }
    }
}
