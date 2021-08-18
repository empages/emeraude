using System;

namespace Definux.Emeraude.Interfaces.Models
{
    /// <summary>
    /// Simplified date model for request/response purposes.
    /// </summary>
    public interface IDateModel
    {
        /// <summary>
        /// Year of the date.
        /// </summary>
        int Year { get; set; }

        /// <summary>
        /// Month of the date.
        /// </summary>
        int Month { get; set; }

        /// <summary>
        /// Day of the date.
        /// </summary>
        int Day { get; set; }

        /// <summary>
        /// Gets whether the model is valid or not.
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Converts current model to <see cref="DateTime"/>.
        /// </summary>
        /// <returns></returns>
        DateTime ToDateTime();
    }
}