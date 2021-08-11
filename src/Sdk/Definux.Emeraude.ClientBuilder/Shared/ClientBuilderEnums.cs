namespace Definux.Emeraude.ClientBuilder.Shared
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
        /// Web module.
        /// </summary>
        WebModule = 1,

        /// <summary>
        /// Mobile module.
        /// </summary>
        MobileModule = 2,
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
        /// Unsuccess.
        /// </summary>
        Unsuccess = 3,
    }
}
