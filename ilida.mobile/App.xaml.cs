using Xamarin.Forms;

namespace ilida.mobile
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var loginview = new LoginView();
			loginview.BindingContext = new LoginViewModel();
			MainPage = loginview;
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
