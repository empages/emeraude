namespace Definux.Emeraude.Configuration.Authorization
{
    public class ApplicationPermission
    {
        public ApplicationPermission()
        { }

        public ApplicationPermission(string name)
        {
            Name = name;
            Value = name.Replace(' ', '.').ToLower();
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(ApplicationPermission permission)
        {
            return permission.Value;
        }
    }
}
