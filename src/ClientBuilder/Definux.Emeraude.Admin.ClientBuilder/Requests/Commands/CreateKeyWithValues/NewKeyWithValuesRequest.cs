using System.Collections.Generic;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateKeyWithValues
{
    public class NewKeyWithValuesRequest
    {
        public string Key { get; set; }

        public IEnumerable<NewKeyTranslationValue> Values { get; set; }
    }

    public class NewKeyTranslationValue
    {
        public int LanguageId { get; set; }

        public string Value { get; set; }
    }
}
