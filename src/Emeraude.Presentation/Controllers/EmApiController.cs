using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Abstract class for creating API controllers.
    /// </summary>
    [ApiController]
    public abstract class EmApiController : EmController
    {
        /// <summary>
        /// Get HTTP default OK or Bad request response based on the passed flag.
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        protected IActionResult GetSuccessResponse(bool success)
        {
            if (success)
            {
                return this.Ok();
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Get HTTP OK response with <see cref="SimpleResult"/>.
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        protected IActionResult GetSimpleResponse(bool success)
        {
            return this.Ok(new SimpleResult(success));
        }
    }
}
