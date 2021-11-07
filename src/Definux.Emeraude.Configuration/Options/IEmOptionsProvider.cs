namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Options manager for access and modify specified Emeraude options.
    /// </summary>
    public interface IEmOptionsProvider
    {
        /// <summary>
        /// Gets the instance of specified options type.
        /// </summary>
        /// <typeparam name="TOptions">Type of requested options.</typeparam>
        /// <returns></returns>
        TOptions GetOptions<TOptions>()
            where TOptions : class, IEmOptions;

        /// <summary>
        /// Gets option value by option address.
        /// </summary>
        /// <param name="optionAddress"></param>
        /// <typeparam name="TValue">Return type of the value.</typeparam>
        /// <returns></returns>
        TValue GetOptionValue<TValue>(string optionAddress);
    }
}