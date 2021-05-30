using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Definux.Emeraude.Tests.Base
{
    public static class Utilities
    {
        public static async Task<AntiForgeryTokenMeta> GetAntiForgeryTokenMetaFromPageAsync(string relativeUrl, HttpClient httpClient)
        {
            var result = new AntiForgeryTokenMeta();
            
            var initResponse = await httpClient.GetAsync(relativeUrl);
            initResponse.Headers.TryGetValues("Set-Cookie", out var cookies);

            var antiForgeryTokenKeyValue = cookies
                .First(x => x.StartsWith(".AspNetCore.Antiforgery."))
                .Split(";")
                .First()
                .Split("=");

            result.CookieName = antiForgeryTokenKeyValue.First();
            result.CookieValue = antiForgeryTokenKeyValue.Last();

            result.InputName = "__RequestVerificationToken";
            var responseHtml = await initResponse.Content.ReadAsStringAsync();

            HtmlDocument loginPageDocument = new HtmlDocument();
            loginPageDocument.LoadHtml(responseHtml);
            result.InputValue = loginPageDocument
                .DocumentNode
                .SelectSingleNode($"//input[@name='{result.InputName}']")
                .Attributes["value"]
                .Value;

            return result;
        }
    }
}