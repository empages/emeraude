using Prism.Mvvm;

namespace Definux.Emeraude.MobileSdk.FormModels.Abstractions
{
    public abstract class FormModel : BindableBase
    {
        public abstract bool IsValid();
    }
}
