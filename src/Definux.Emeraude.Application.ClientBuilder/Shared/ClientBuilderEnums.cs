namespace Definux.Emeraude.Application.ClientBuilder.Shared
{
    /// <summary>
    /// Type of the application instance.
    /// </summary>
    public enum InstanceType
    {
        /// <summary>
        /// Undefined type of module.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Web module instance.
        /// </summary>
        Web = 1,

        /// <summary>
        /// Mobile module instance.
        /// </summary>
        Mobile = 2,

        /// <summary>
        /// Desktop module instance.
        /// </summary>
        Desktop = 3,
    }

    /// <summary>
    /// Type of generation result.
    /// </summary>
    public enum ScaffoldModulesProcessResult
    {
        /// <summary>
        /// Error.
        /// </summary>
        Error = -1,

        /// <summary>
        /// Success.
        /// </summary>
        Success = 1,

        /// <summary>
        /// Success with errors.
        /// </summary>
        SuccessWithErrors = 2,

        /// <summary>
        /// Unsuccessful.
        /// </summary>
        Unsuccessful = 3,
    }
}
