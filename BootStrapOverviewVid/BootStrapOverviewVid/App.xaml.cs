using System;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace BootStrapOverviewVid
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = e => { return null; };
        }

        public override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            return Task.CompletedTask;
        }
        //public override Task OnPrelaunchAsync(IActivatedEventArgs args, out bool runOnStartAsync)
        //{
        //    runOnStartAsync = false;
        //    return Task.CompletedTask;
        //}
        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            //if (startKind==StartKind.Activate)
            //var e = args as ProtocolActivatedEventArgs;
            NavigationService.Navigate(typeof(Views.MainPage));
            return Task.CompletedTask;
        }
    }
}

