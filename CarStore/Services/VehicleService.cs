using CarStore.Model;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Services
{
	public class VehicleService
	{
		private static int _identityNumber = 4;
		private static readonly ISet<Vehicle> Vehicles = new HashSet<Vehicle>
		{
			new Vehicle
			{
				Id = 1,
				Brand = "BWM",
				Model = "e46",
				Seats = 4
			},
			new Vehicle
			{
				Id = 2,
				Brand = "Audi",
				Model = "A6",
				Seats = 2
			},
			new Vehicle
			{
				Id = 3,
				Brand = "Fiat",
				Model = "126p",
				Seats = 4
			}
		};

		public Vehicle GetVehicleById(int id)
		{
			return Vehicles.SingleOrDefault(v => v.Id == id);
		}

		public IEnumerable<Vehicle> GetVehicles()
		{
			return Vehicles;
		}

		public void CreateVehicle(Vehicle vehicle)
		{
			vehicle.Id = _identityNumber++;
			Vehicles.Add(vehicle);
		}

		public void RemoveVehicle(Vehicle vehicle)
		{
			Vehicles.Remove(vehicle);
		}
	}
}
