using System;
using System.Collections.Generic;
using AutoMapper;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Application
{
    /// <summary>
    /// Options for application architectural part of the Emeraude.
    /// </summary>
    public class EmApplicationsOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmApplicationsOptions"/> class.
        /// </summary>
        public EmApplicationsOptions()
        {
            this.MappingAssemblies = new List<string>();
            this.MappingProfiles = new List<Type>();
        }

        /// <summary>
        /// List of all assemblies that contains mappings.
        /// </summary>
        public List<string> MappingAssemblies { get; }

        /// <summary>
        /// List of all mapping profiles types used for AutoMapper configuration.
        /// </summary>
        public List<Type> MappingProfiles { get; }

        /// <summary>
        /// Add new mapping profile type to the mapping profile. The method is prefered than the <see cref="MappingProfiles"/> property.
        /// </summary>
        /// <typeparam name="TProfile">AutoMapper profile type.</typeparam>
        public void AddMappingProfile<TProfile>()
            where TProfile : Profile
        {
            this.MappingProfiles.Add(typeof(TProfile));
        }
    }
}