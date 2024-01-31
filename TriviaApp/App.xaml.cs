using TriviaApp.Views;

namespace TriviaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
