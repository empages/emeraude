namespace Definux.Emeraude.Admin.ClientBuilder.Shared
{
    public enum InstanceType
    {
        Undefined = 0,
        WebModule = 1,
        MobileModule = 2,
    }

    public enum ScaffoldModulesProcessResult
    {
        Error = -1,
        Success = 1,
        SuccessWithErrors = 2,
        Unsuccess = 3
    }
}
