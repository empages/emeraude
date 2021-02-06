using System;
using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Domain
{
    public class SimpleEntity : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DayOfWeek Day { get; set; }
    }
}