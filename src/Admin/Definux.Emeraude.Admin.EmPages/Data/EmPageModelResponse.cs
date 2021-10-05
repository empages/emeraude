using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.EmPages.Schema;

namespace Definux.Emeraude.Admin.EmPages.Data
{
    /// <summary>
    /// Definition for entity in table view format.
    /// </summary>
    public class EmPageModelResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageModelResponse"/> class.
        /// </summary>
        /// <param name="model"></param>
        public EmPageModelResponse(IEmPageModel model)
        {
            this.Identifier = model.Id;
            this.Fields = model
                .GetType()
                .GetProperties()
                .Select(x => new EmPageModelResponseField
                {
                    Property = x.Name,
                    Value = x.GetValue(model),
                });
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageModelResponse"/> class.
        /// </summary>
        public EmPageModelResponse()
        {
        }

        /// <summary>
        /// Model identifier.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Collection of all fields of the current entity.
        /// </summary>
        public IEnumerable<EmPageModelResponseField> Fields { get; set; }
    }
}