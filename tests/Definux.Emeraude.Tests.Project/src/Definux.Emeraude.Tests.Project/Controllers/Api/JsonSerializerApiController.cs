using Emeraude.Tests.Project.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Tests.Project.Controllers.Api
{
    [Route("/api/json-serializer/")]
    public class JsonSerializerApiController : ControllerBase
    {
        [HttpPost("date-model")]
        public IActionResult DateModelCheck([FromBody] DateModelTestModel model)
        {
            return this.Ok(model.Date.ToString());
        }
        
        [HttpPost("date-model-nullable")]
        public IActionResult DateModelNullableCheck([FromBody] DateModelNullableTestModel model)
        {
            return this.Ok(model.Date?.ToString());
        }
    }
}