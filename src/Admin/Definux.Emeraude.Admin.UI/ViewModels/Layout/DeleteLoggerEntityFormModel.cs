namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    /// <summary>
    /// Helper class for delete logger entity form.
    /// </summary>
    public class DeleteLoggerEntityFormModel
    {
        /// <summary>
        /// Entity ID.
        /// </summary>
        public int EntityId { get; set; }

        /// <summary>
        /// Logger entity type.
        /// </summary>
        public string LoggerEntityType { get; set; }

        /// <summary>
        /// Form classes.
        /// </summary>
        public string FormClasses { get; set; }

        /// <summary>
        /// Button classes.
        /// </summary>
        public string ButtonClasses { get; set; }

        /// <summary>
        /// Button icon.
        /// </summary>
        public string ButtonIconClasses { get; set; }

        /// <summary>
        /// Button text.
        /// </summary>
        public string ButtonText { get; set; }
    }
}