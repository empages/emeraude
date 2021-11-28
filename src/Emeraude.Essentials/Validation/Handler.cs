using System;

namespace Emeraude.Essentials.Validation
{
    /// <inheritdoc cref="IHandler{T}"/>
    public abstract class Handler<T> : IHandler<T>
    {
        private IHandler<T> nextHandler;

        /// <summary>
        /// Object which is used for processing and validation.
        /// </summary>
        protected T RequestObject { get; set; }

        /// <inheritdoc/>
        public virtual T Handle(T requestObject, out string validationResultMessage)
        {
            this.RequestObject = requestObject;
            validationResultMessage = this.HandleProcessAction();

            T returnObject = this.RequestObject;
            if (returnObject != null && this.nextHandler != null)
            {
                returnObject = this.nextHandler.Handle(requestObject, out var newResultMessage);

                validationResultMessage += newResultMessage;
            }

            return returnObject;
        }

        /// <inheritdoc/>
        public IHandler<T> SetNext(IHandler<T> handler)
        {
            this.nextHandler = handler;

            return handler;
        }

        /// <summary>
        /// Method that contains the validation logic for current handler. If validation pass successfully return empty string as a message, if not - return validation message and set handler object to null.
        /// </summary>
        /// <returns></returns>
        protected virtual string HandleProcessAction()
        {
            throw new NotImplementedException("Handler has no process action implementation.");
        }
    }
}
