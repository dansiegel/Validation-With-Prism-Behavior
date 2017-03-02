using System;
using Prism.Mvvm;

namespace Validation.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {
        }

        private bool isValid;
        public bool IsValid
        {
            get { return isValid; }
            set
            {
                SetProperty( ref isValid, value );
                System.Diagnostics.Debug.WriteLine( $"IsValid being set to: {value} in the ViewModel" );
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { SetProperty( ref email, value ); }
        }
    }
}
