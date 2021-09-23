namespace Definux.Emeraude.Admin.UI.Utilities
{
    /// <summary>
    /// HTML utilities.
    /// </summary>
    public static class HtmlUtilities
    {
        /// <summary>
        /// Get current breadcrumb class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderMax"></param>
        /// <returns></returns>
        public static string BreadcrumbOrderMaxClass(int order, int orderMax)
        {
            return order == orderMax ? "current-breadcrumb" : string.Empty;
        }
    }
}