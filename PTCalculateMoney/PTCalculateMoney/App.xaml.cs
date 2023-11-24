using PTCalculateMoney.Views;

namespace PTCalculateMoney
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}