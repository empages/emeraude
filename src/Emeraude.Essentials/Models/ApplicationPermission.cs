namespace Emeraude.Essentials.Models
{
    /// <summary>
    /// Class that represent application permission used for policy based authorization.
    /// </summary>
    public class ApplicationPermission
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPermission"/> class.
        /// </summary>
        public ApplicationPermission()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPermission"/> class.
        /// </summary>
        /// <param name="name"></param>
        public ApplicationPermission(string name)
        {
            this.Name = name;
            this.Value = name.Replace(' ', '.').ToLower();
        }

        /// <summary>
        /// Name of the application permission.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the application permission.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Implicit string conversion.
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public static implicit operator string(ApplicationPermission permission)
        {
            return permission.Value;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Value;
        }
    }
}
