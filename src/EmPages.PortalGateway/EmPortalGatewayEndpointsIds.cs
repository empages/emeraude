using System.Diagnostics.CodeAnalysis;

namespace EmPages.PortalGateway;

#pragma warning disable SA1600
internal static class EmPortalGatewayEndpointsIds
{
    internal const string IdentityAuthLogin = "identity.auth.login";
    internal const string IdentityAuthLoginMfa = "identity.auth.login_mfa";
    internal const string IdentityManageChangePassword = "identity.manage.change_password";
    internal const string IdentityManageChangeEmail = "identity.manage.change_email";
    internal const string IdentityManageMfaDescription = "identity.manage.mfa_description";
    internal const string IdentityManageMfaReset = "identity.manage.mfa_reset";
    internal const string IdentityManageMfaActivate = "identity.manage.mfa_activate";
    internal const string PageRetrieve = "page.retrieve";
    internal const string PageCommand = "page.command";
}

#pragma warning restore SA1600