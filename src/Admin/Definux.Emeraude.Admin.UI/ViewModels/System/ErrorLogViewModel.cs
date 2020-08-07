using System;

namespace Definux.Emeraude.Admin.UI.ViewModels.System
{
    public class ErrorLogViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public ErrorLogUser InvolvedUser { get; set; }

        public string StackTrace { get; set; }

        public string Source { get; set; }

        public string Message { get; set; }

        public string Method { get; set; }

        public string Class { get; set; }
    }

    public class ErrorLogUser
    {
        public string Email { get; set; }

        public string Name { get; set; }
    }
}
