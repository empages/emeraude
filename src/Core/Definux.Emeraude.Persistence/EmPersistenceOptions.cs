using System;
using System.Collections.Generic;
using Definux.Emeraude.Configuration.Exceptions;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Persistence
{
    /// <summary>
    /// Options for persistence infrastructure of Emeraude.
    /// </summary>
    public class EmPersistenceOptions : IEmOptions
    {
        private readonly List<Type> databaseInitializers = new List<Type>();

        /// <summary>
        /// Provider of database storage for the application.
        /// </summary>
        public DatabaseContextProvider ContextProvider { get; set; }

        /// <summary>
        /// Collection of all database initializers.
        /// </summary>
        public Type[] DatabaseInitializers => this.databaseInitializers.ToArray();

        /// <summary>
        /// Register a database initializer into the database initializer manager. The order of adding is the order of calling.
        /// </summary>
        /// <typeparam name="TDatabaseInitializer">Interface type of the database initializer.</typeparam>
        public void AddDatabaseInitializer<TDatabaseInitializer>()
        {
            this.databaseInitializers.Add(typeof(TDatabaseInitializer));
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public void Validate()
        {
        }
    }
}