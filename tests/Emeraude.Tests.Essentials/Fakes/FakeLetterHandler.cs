using System.Linq;
using Emeraude.Essentials.Validation;

namespace Emeraude.Tests.Essentials.Fakes;

public class FakeLetterHandler : Handler<string>
{
    public const string ErrorMessage = "String must have at least one letter";
        
    protected override string HandleProcessAction()
    {
        var resultMessage = string.Empty;
        var objectChars = RequestObject.ToCharArray();
        if (!objectChars.Any(char.IsLetter))
        {
            resultMessage = ErrorMessage;
            this.RequestObject = null;
        }

        return resultMessage;
    }
}