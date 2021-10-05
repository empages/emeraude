using Definux.Emeraude.ClientBuilder.Shared;

namespace Definux.Emeraude.ClientBuilder.DataTransferObjects
{
    /// <summary>
    /// Request for module generation.
    /// </summary>
    public class ScaffoldGenerateByInstanceTypeRequest
    {
        /// <summary>
        /// Target instance type.
        /// </summary>
        public InstanceType InstanceType { get; set; }
    }
}
