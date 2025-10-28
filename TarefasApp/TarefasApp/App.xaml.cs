// CBTPRDM TP02 - Luan dos Santos Sales Pinheiro
namespace TarefasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
