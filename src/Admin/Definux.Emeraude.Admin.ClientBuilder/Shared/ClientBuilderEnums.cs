namespace Definux.Emeraude.Admin.ClientBuilder.Shared
{
    /// <summary>
    /// Type of the application instance.
    /// </summary>
    public enum InstanceType
    {
        Undefined = 0,
        WebModule = 1,
        MobileModule = 2,
    }

    /// <summary>
    /// Type of generation result.
    /// </summary>
    public enum ScaffoldModulesProcessResult
    {
        Error = -1,
        Success = 1,
        SuccessWithErrors = 2,
        Unsuccess = 3,
    }
}
