using InformaBH_Eventos.View;

namespace InformaBH_Eventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new AbaPage());
        }
    }
}
