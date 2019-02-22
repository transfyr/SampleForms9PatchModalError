using Xamarin.Forms;

namespace SampleForms9Patch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SampleForms9PatchPage();
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
