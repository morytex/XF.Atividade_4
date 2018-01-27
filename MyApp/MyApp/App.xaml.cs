using MyApp.Model;
using MyApp.ViewModel;
using Xamarin.Forms;

namespace MyApp
{
    public partial class App : Application
    {
        #region ViewModels
        public static ProfessorViewModel ProfessorVM { get; set; }
        #endregion

        public App()
        {
            InitializeComponent();
            InitializeApplication();

            MainPage = new NavigationPage(new View.ProfessorView() { BindingContext = App.ProfessorVM });
        }

        private void InitializeApplication()
        {
            if (ProfessorVM == null) ProfessorVM = new ProfessorViewModel();
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
