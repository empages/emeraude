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

        /// <summary>
        /// Microsoft SQL Server.
        /// </summary>
        MicrosoftSqlServer = 0,

        /// <summary>
        /// PostgreSQL
        /// </summary>
        PostgreSql = 1,
    }
}
