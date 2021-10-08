namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Indicates whether the view item be shown on both form EmPages or not.
    /// </summary>
    public enum FormViewItemType
    {
        CreateEdit = 0,
        CreateOnly = 1,
        EditOnly = 2,
    }

    /// <summary>
    /// Provides types of built-in mutational request types of the EmPages.
    /// </summary>
    public enum EmPageMutationalRequestType
    {
        Create = 1,
        Edit = 2,
    }
}