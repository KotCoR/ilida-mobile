using System;
using System.Collections.Generic;

namespace ilida.mobile
{
	public class AccidentListViewModel : BaseViewModel
	{
		INavigationService _nav;

		public AccidentListViewModel(INavigationService nav)
		{
			_nav = nav;
			_accidents = new List<Accident>()
			{
				new Accident(){ AccidentId="891291", Date="11/09/2016 14:30", Status="Προς Διακανονισμο"},
				new Accident(){ AccidentId="732291", Date="12/03/2015 11:00", Status="Ολοκληρώθηκε"}
			};
		}

		private ICollection<Accident> _accidents;
		public ICollection<Accident> Accidents
		{
			get
			{
				return _accidents;
			}
			set
			{
				_accidents = value;
				OnPropertyChanged(nameof(Accidents));
			}
		}
	}
}
