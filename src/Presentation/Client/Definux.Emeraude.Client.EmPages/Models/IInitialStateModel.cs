namespace Definux.Emeraude.Client.EmPages.Models
{
    public interface IInitialStateModel<TData> : IInitialState
        where TData : class, IInitialStateModelData, new()
    {
        string RouteName { get; }

        InitialStateUserModel User { get; }

        string LanguageCode { get; set; }

        int LanguageId { get; set; }

        string StateString { get; }

        TData Data { get; set; }
    }
}
