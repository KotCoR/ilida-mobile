using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;

namespace ilida.mobile
{
	public class SubmitAccidentViewModel : BaseViewModel
	{
		INavigationService _nav;

		public SubmitAccidentViewModel(INavigationService nav)
		{
			_nav = nav;
			_vehicles = new ObservableCollection<Vehicle>()
			{
				new Vehicle(){VehicleId=1}
			};
			AddVehicleCommand = new Command(() => AddVehicle());
		}

		public ICommand AddVehicleCommand { get; set; }

		private ObservableCollection<Vehicle> _vehicles;
		public ObservableCollection<Vehicle> Vehicles
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

		public void AddVehicle()
		{
			var id = _vehicles.Last().VehicleId + 1;
			var vehicle = new Vehicle()
			{
				VehicleId = id
			};
			_vehicles.Add(vehicle);
		}
	}
}
