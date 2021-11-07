using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace Definux.Emeraude.Application.Exceptions
{
    /// <summary>
    /// Custom exception thrown on invalid fluent validation.
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        public ValidationException()
            : base("One or more validation failures have occurred.")
        {
            this.Failures = new Dictionary<string, string[]>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="failures"></param>
        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            var failureGroups = failures.GroupBy(x => x.PropertyName, x => x.ErrorMessage);

            foreach (var failureGroup in failureGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                this.Failures.Add(propertyName, propertyFailures);
            }
        }

        /// <summary>
        /// Dictionary with all failures of fluent validation.
        /// </summary>
        public IDictionary<string, string[]> Failures { get; }
    }
}
