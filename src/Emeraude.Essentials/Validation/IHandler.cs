namespace Emeraude.Essentials.Validation
{
    /// <summary>
    /// Validation handler that implement the current chain validation logic for the chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="T">Type of the model for validation.</typeparam>
    public interface IHandler<T>
    {
        /// <summary>
        /// Set the next handler in the validation chain.
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        IHandler<T> SetNext(IHandler<T> handler);

        /// <summary>
        /// Method that execute the validation logic for current handler.
        /// </summary>
        /// <param name="requestObject"></param>
        /// <param name="validationResultMessage"></param>
        /// <returns></returns>
        T Handle(T requestObject, out string validationResultMessage);
    }
}
