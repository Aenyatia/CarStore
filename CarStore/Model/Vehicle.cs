using System.ComponentModel.DataAnnotations;

namespace CarStore.Model
{
	public class Vehicle
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Brand { get; set; }

		[Required]
		[StringLength(255)]
		public string Model { get; set; }

		[Required]
		[Range(1, 6)]
		public int Seats { get; set; }
	}
}
