using Definux.Emeraude.MobileSdk.Configuration;
using System;
using Xamarin.Auth;

namespace Definux.Emeraude.MobileSdk.OAuth
{
    public static class OAuth2AuthenticatorHelper
    {
        public static OAuth2Authenticator CreateFacebookOAuth2Authenticator(IEmConfiguration configuration)
        {
            AuthenticationState = new OAuth2Authenticator(
                clientId: configuration.FacebookAppId,
                scope: "email",
                authorizeUrl: new Uri("https://www.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri(configuration.FacebookRedirectUrl),
                getUsernameAsync: null,
                isUsingNativeUI: true)
            { 
                AllowCancel = true,
                ShowErrors = false
                
            };

            return AuthenticationState;
        }

        public static OAuth2Authenticator CreateGoogleOAuth2Authenticator(IEmConfiguration configuration)
        {
            AuthenticationState = new OAuth2Authenticator(
                clientId: configuration.GoogleClientId,
                clientSecret: string.Empty,
                scope: "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile",
                authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/v2/auth"),
                redirectUrl: new Uri(configuration.GoogleRedirectUrl),
                accessTokenUrl: new Uri("https://www.googleapis.com/oauth2/v4/token"),
                isUsingNativeUI: true)
            {
                AllowCancel = true,
                ShowErrors = false
            };

            return AuthenticationState;
        }

        public static OAuth2Authenticator AuthenticationState { get; private set; }
    }
}
