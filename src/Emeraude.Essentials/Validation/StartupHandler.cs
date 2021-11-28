namespace Emeraude.Essentials.Validation
{
    /// <summary>
    /// Startup handler of the validation chain.
    /// </summary>
    /// <typeparam name="T">Type of the model for validation.</typeparam>
    public class StartupHandler<T> : Handler<T>
    {
        /// <inheritdoc/>
        protected override string HandleProcessAction()
        {
            string resultMessage = string.Empty;
            if (this.RequestObject == null)
            {
                resultMessage = "Requested object for validation is null. ";
            }

            return resultMessage;
        }
    }
}