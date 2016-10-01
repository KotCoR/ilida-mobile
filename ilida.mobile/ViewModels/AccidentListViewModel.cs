using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

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
			SubmitCommand = new Command(async () => await Submit());
		}

		public ICommand SubmitCommand { get; set; }

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

		public async Task Submit()
		{
			await _nav.PushAsync<SubmitAccidentViewModel>();
		}

	}
}
