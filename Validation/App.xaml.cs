using Xamarin.Forms;
using Prism.Unity;
using Validation.Views;

namespace Validation
{
    public partial class App : PrismApplication
    {
        public App( IPlatformInitializer initializer = null )
            : base( initializer )
        {
            InitializeComponent();
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync( "MainPage" );
        }
    }
}
