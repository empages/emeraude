namespace Definux.Emeraude.Admin.ClientBuilder.Models
{
    public class BusinessContext : ClientBuilderEntity
    {
        public string Name { get; set; }

        public string RoutePrefix { get; set; }

        public bool Authorized { get; set; }
    }
}
