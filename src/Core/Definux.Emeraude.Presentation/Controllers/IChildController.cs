namespace Definux.Emeraude.Presentation.Controllers
{
    /// <summary>
    /// Definition for controller that must be tolerated as a child one for another controller.
    /// </summary>
    public interface IChildController
    {
        /// <summary>
        /// Parent controller of the current one.
        /// </summary>
        string ParentController { get; }
    }
}
