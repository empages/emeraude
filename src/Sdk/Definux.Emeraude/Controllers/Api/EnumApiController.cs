using System.Collections.Generic;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Controllers.Api
{
    /// <summary>
    /// Enumeration API controller that provide access to enumeration types and their values.
    /// </summary>
    [Route("/api/enums/")]
    [ApiEndpointsController]
    public sealed class EnumApiController : ApiController
    {
        /// <summary>
        /// Get all enumerations with their values.
        /// </summary>
        /// <param name="enumTypeName"></param>
        /// <returns></returns>
        [Route("{enumTypeName}")]
        [HttpGet]
        [Endpoint(typeof(IEnumerable<EnumValueItem>))]
        public IActionResult GetEnumValueList(string enumTypeName)
        {
            var valueList = EnumFunctions.GetEnumValueItems(enumTypeName);
            if (valueList != null)
            {
                return this.Ok(valueList);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Get a specified enumeration by the enumeration type and value.
        /// </summary>
        /// <param name="enumTypeName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("{enumTypeName}/{value}")]
        [HttpGet]
        [Endpoint(typeof(EnumValueItem))]
        public IActionResult GetEnumValue(string enumTypeName, int value)
        {
            var result = EnumFunctions.GetEnumItemFromTypeByValue(value, enumTypeName);
            if (result != null)
            {
                return this.Ok(result);
            }

            return this.BadRequest();
        }
    }
}