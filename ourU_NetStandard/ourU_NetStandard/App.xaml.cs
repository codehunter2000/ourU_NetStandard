using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using ourU_NetStandard.Services;
using ourU_NetStandard.Views;
using Microsoft.Identity.Client;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ourU_NetStandard
{
    public partial class App : Application
    {

        public interface IAuthenticate
        {
            Task<bool> Authenticate();
        }

        public static IAuthenticate Authenticator { get; private set; }
        public static IAuthenticate AuthenticationProvider { get; private set; }
        public static string AzureBackendUrl = "https://ouru.azurewebsites.net";    
        public static MobileServiceClient MobileService = new MobileServiceClient(AzureBackendUrl);


        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            InitializeComponent();
            MainPage = new LogInPage();
        }

        protected override void OnActivated(IActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.Protocol)
            {
                ProtocolActivatedEventArgs protocolArgs = args as ProtocolActivatedEventArgs;
                Frame content = Window.Current.Content as Frame;
                if (content.Content.GetType() == typeof(MainPage))
                {
                    content.Navigate(typeof(MainPage), protocolArgs.Uri);
                }
            }
            Window.Current.Activate();
            base.OnActivated(args);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
