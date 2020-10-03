using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;

namespace Definux.Emeraude.MobileSdk.FormModels.Abstractions
{
    /// <summary>
    /// Abstraction for wrapping form with validations in ViewModel.
    /// </summary>
    public abstract class FormModel : BindableBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormModel"/> class.
        /// </summary>
        public FormModel()
        {
            this.Errors = new ObservableCollection<FormModelError>();
            this.Errors.CollectionChanged += this.ErrorsCollectionChanged;
        }

        /// <summary>
        /// Flag that indicates the existance of model errors.
        /// </summary>
        public bool HasErrors => this.Errors.Any();

        /// <summary>
        /// Dictionary that contains errors of model.
        /// </summary>
        public ObservableCollection<FormModelError> Errors { get; set; }

        /// <summary>
        /// Method that trigger the model validation.
        /// </summary>
        /// <returns></returns>
        public abstract bool IsValid();

        /// <summary>
        /// Add error to model state errors.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="error"></param>
        protected void AddError(string propertyName, string error)
        {
            if (this.Errors.Any(x => x.Key == propertyName))
            {
                this.Errors.FirstOrDefault(x => x.Key == propertyName).Error = error;
            }
            else
            {
                this.Errors.Add(new FormModelError
                {
                    Key = propertyName,
                    Error = error,
                });
            }
        }

        private void ErrorsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.RaisePropertyChanged(nameof(this.HasErrors));
        }
    }
}
