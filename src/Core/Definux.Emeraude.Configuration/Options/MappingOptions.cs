using AutoMapper;
using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Configuration.Options
{
    public class MappingOptions
    {
        public MappingOptions()
        {
            MappingAssemblies = new List<string>();
            MappingProfiles = new List<Type>();
        }

        public List<string> MappingAssemblies { get; set; }

        public List<Type> MappingProfiles { get; set; }

        public void AddProfile<TProfile>()
            where TProfile : Profile
        {
            MappingProfiles.Add(typeof(TProfile));
        }
    }
}
