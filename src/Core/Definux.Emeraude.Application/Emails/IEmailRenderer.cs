using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Emails
{
    /// <summary>
    /// Service that provides renderer that use Razor for generate email body.
    /// </summary>
    public interface IEmailRenderer
    {
        /// <summary>
        /// Render email HTML body via provided template name and Email model.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<string> RenderToStringAsync(string templateName, EmailModel model);
    }
}