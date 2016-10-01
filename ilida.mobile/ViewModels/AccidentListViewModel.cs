using System;
namespace ilida.mobile
{
	public class AccidentListViewModel : BaseViewModel
	{
		INavigationService _nav;

		public AccidentListViewModel(INavigationService nav)
		{
			_nav = nav;
		}
	}
}
