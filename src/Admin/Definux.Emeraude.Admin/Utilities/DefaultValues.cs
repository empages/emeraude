using System;

namespace Definux.Emeraude.Admin.Utilities
{
    /// <summary>
    /// Default values for the context of administration.
    /// </summary>
    public static class DefaultValues
    {
        /// <summary>
        /// Order types of properties.
        /// </summary>
        public static readonly Type[] OrderTypes = new Type[]
        {
            typeof(Guid),
            typeof(Guid?),
            typeof(DateTime),
            typeof(DateTime?),
            typeof(TimeSpan),
            typeof(TimeSpan?),
            typeof(bool),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(string),
        };
    }
}