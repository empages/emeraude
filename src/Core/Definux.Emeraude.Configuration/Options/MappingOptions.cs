using System;
using System.Collections.Generic;
using AutoMapper;

namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Configuration class that contains mapping assemblies and profiles for proper AutoMapper set up.
    /// </summary>
    public class MappingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingOptions"/> class.
        /// </summary>
        public MappingOptions()
        {
            this.MappingAssemblies = new List<string>();
            this.MappingProfiles = new List<Type>();
        }

        /// <summary>
        /// List of all assemblies that contains mappings.
        /// </summary>
        public List<string> MappingAssemblies { get; set; }

        /// <summary>
        /// List of all mapping profiles types used for AutoMapper configuration.
        /// </summary>
        public List<Type> MappingProfiles { get; set; }

        /// <summary>
        /// Add new mapping profile type to the mapping profile. The method is prefered than the <see cref="MappingProfiles"/> property.
        /// </summary>
        /// <typeparam name="TProfile">AutoMapper profile type.</typeparam>
        public void AddProfile<TProfile>()
            where TProfile : Profile
        {
            this.MappingProfiles.Add(typeof(TProfile));
        }
    }
}
