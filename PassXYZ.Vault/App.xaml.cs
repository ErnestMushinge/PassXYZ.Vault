

using System.Diagnostics;

namespace PassXYZ.Vault
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Instatieted MainPage
           // MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new PxWindow(new MainPage());
        }

        protected override void OnStart()
        { //(1)
            Debug.WriteLine("PassXYZ.Vault.App: OnStart");
        }
        protected override void OnSleep()
        { //(2)
            Debug.WriteLine("PassXYZ.Vault.App: OnSleep");
        }
        protected override void OnResume()
        { //(3)
            Debug.WriteLine("PassXYZ.Vault.App: OnResume");
        }
    }

}