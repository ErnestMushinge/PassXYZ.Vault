

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
    }

}