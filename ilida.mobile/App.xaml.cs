﻿using Xamarin.Forms;

namespace ilida.mobile
{
	public partial class App : Application
	{
		INavigationService _navigationService;
		NavigationPage _navigationPage;
		Page _root;

		public App()
		{
			InitializeComponent();
			_root = new LoginView();
			_navigationPage = new NavPage(_root);
			_navigationService = new NavigationService(_navigationPage.Navigation);
			_navigationService.Register(new LoginViewModel(_navigationService), _root);
			_navigationService.Register(new AccidentListViewModel(_navigationService), new AccidentListView());
			_navigationService.Register(new SubmitAccidentViewModel(_navigationService), new SubmitAccidentView());
			_navigationService.Register(new AccidentViewModel(_navigationService), new AccidentView());

			//MainPage = _navigationService.GetView<LoginViewModel>();
			MainPage = _navigationPage;
		}

		INavigation FormsNavigation
		{
			get
			{
				var tabController = Application.Current.MainPage as TabbedPage;
				var masterController = Application.Current.MainPage as MasterDetailPage;

				// First check to see if we're on a tabbed page, then master detail, finally go to overall fallback
				return tabController?.CurrentPage?.Navigation ??
									 (masterController?.Detail as TabbedPage)?.CurrentPage?.Navigation ?? // special consideration for a tabbed page inside master/detail
									 masterController?.Detail?.Navigation ??
									 Application.Current.MainPage.Navigation;
			}
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
