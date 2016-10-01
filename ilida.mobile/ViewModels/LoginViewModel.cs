using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ilida.mobile
{
	public class LoginViewModel : BaseViewModel
	{
		public LoginViewModel()
		{
			this.Login = new Command(() => DoLogin());
		}

		private string _username;
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}

		public string Password { get; set; }

		private bool _rememberMe;
		public bool RememberMe
		{
			get
			{
				return _rememberMe;
			}
			set
			{
				_rememberMe = value;
				OnPropertyChanged(nameof(RememberMe));

			}
		}

		public ICommand Login { get; set; }

		public void DoLogin()
		{

		}
	}
}
