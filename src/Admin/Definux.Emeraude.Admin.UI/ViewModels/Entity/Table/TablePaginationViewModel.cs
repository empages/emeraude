namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Table
{
    public class TablePaginationViewModel
    {
        public TablePaginationViewModel(int currentPage, int pagesCount)
        {
            CurrentPage = currentPage;

            if (CurrentPage != 1)
            {
                PreviousPage = CurrentPage - 1;
            }

            if (CurrentPage != pagesCount)
            {
                NextPage = CurrentPage + 1;
            }

            for (int i = 1; i <= 2; i++)
            {
                if (CurrentPage - i >= 1)
                {
                    PreviousPagesCount++;
                }
                if (CurrentPage + i <= pagesCount)
                {
                    NextPagesCount++;
                }
            }
        }

        public int CurrentPage { get; private set; }

        public int? NextPage { get; private set; }

        public int? PreviousPage { get; private set; }

        public int NextPagesCount { get; private set; }

        public int PreviousPagesCount { get; private set; }
    }
}
