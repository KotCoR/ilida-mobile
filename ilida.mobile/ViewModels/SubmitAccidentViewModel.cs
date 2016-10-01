using System;
using System.Collections.Generic;

namespace ilida.mobile
{
	public class SubmitAccidentViewModel : BaseViewModel
	{
		INavigationService _nav;

		public SubmitAccidentViewModel(INavigationService nav)
		{
			_nav = nav;
			_vehicles = new List<Vehicle>()
			{
				new Vehicle(){VehicleId=1}
			};
		}

		private ICollection<Vehicle> _vehicles;
		public ICollection<Vehicle> Vehicles
		{
			get
			{
				return _vehicles;
			}
			set
			{
				_vehicles = value;
				OnPropertyChanged(nameof(Vehicles));
			}
		}
	}
}
