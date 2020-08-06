using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Definux.Emeraude.Controllers.Api
{
    [Route("/api/enums/")]
    [ApiEndpointsController]
    public class EnumApiController : ApiController
    {
        [Route("{enumTypeName}")]
        [HttpGet]
        [Endpoint(typeof(IEnumerable<EnumValueItem>))]
        public IActionResult GetEnumValueList(string enumTypeName)
        {
            var valueList = EnumFunctions.GetEnumValueItems(enumTypeName);
            if (valueList != null)
            {
                return Ok(valueList);
            }

            return BadRequest();
        }

        [Route("{enumTypeName}/{value}")]
        [HttpGet]
        [Endpoint(typeof(EnumValueItem))]
        public IActionResult GetEnumValue(string enumTypeName, int value)
        {
            var result = EnumFunctions.GetEnumItemFromTypeByValue(value, enumTypeName);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
