

namespace PassXYZ.Vault
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);
            window.Created += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 1. Created event");
            };
            window.Activated += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 2. Activated event");
            };
            window.Deactivated += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 3. Deactivated event");
            };
            window.Stopped += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 4. Stopped event");
            };
            window.Resumed += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 5. Resumed event");
            };
            window.Destroying += (s, e) => {
                Console.WriteLine("PassXYZ.Vault.App: 6. Destroying event");
            };
            return new Window(new AppShell());
        }
    }

}