namespace Emeraude.Application.Admin.EmPages.Shared
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

    /// <summary>
    /// Provides types of EmPage forms.
    /// </summary>
    public enum EmPageFormType
    {
        CreateForm = 1,
        EditForm = 2,
    }

    /// <summary>
    /// Type of the EmPage routes.
    /// </summary>
    public enum EmPageRouteType
    {
        Table = 1,
        Details = 2,
        Create = 3,
        Edit = 4,
    }

    /// <summary>
    /// Direction of the reference of EmPage feature.
    /// </summary>
    public enum EmPageFeatureReferenceDirection
    {
        /// <summary>
        /// This direction is when the source model contains the reference to the parent (Example: Target.ParentId -> Parent.Id)
        /// </summary>
        FromSourceToParent = 0,

        /// <summary>
        /// This direction is when the parent model contains the reference to the source (Example: Parent.TargetId -> Target.Id)
        /// </summary>
        FromParentToSource = 1,
    }

    /// <summary>
    /// Type of component based on the working data level.
    /// </summary>
    public enum EmPageComponentType
    {
        Renderer = 1,
        Mutator = 2,
    }
}