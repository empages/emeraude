namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Provider of database used for main context.
    /// </summary>
    public enum DatabaseContextProvider
    {
        /// <summary>
        /// To be used only for test purposes.
        /// </summary>
        InMemoryDatabase = -1,
        MicrosoftSqlServer = 0,
        PostgreSql = 1,
    }
}
