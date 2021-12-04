using System.Linq;
using Emeraude.Essentials.Validation;

namespace Emeraude.Tests.Essentials.Fakes;

public class FakeDigitHandler : Handler<string>
{
    public const string ErrorMessage = "String must have at least one digit";
        
    protected override string HandleProcessAction()
    {
        var resultMessage = string.Empty;
        var objectChars = RequestObject.ToCharArray();
        if (!objectChars.Any(char.IsNumber))
        {
            resultMessage = ErrorMessage;
            this.RequestObject = null;
        }

        return resultMessage;
    }
}