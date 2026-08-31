using appUsandoTabbedPage_45732167.Views;
using Microsoft.Extensions.DependencyInjection;

namespace appUsandoTabbedPage_45732167
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Principal());
        }
    }
}