using CarStore.Model;
using CarStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VehiclesController : ControllerBase
	{
		private readonly VehicleService _vehicleService;

		public VehiclesController(VehicleService vehicleService)
		{
			_vehicleService = vehicleService;
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var vehicle = _vehicleService.GetVehicleById(id);

			if (vehicle == null)
				return NotFound();

			return Ok(vehicle);
		}

		[HttpGet]
		public IActionResult Get()
		{
			var vehicle = _vehicleService.GetVehicles();

			if (vehicle == null)
				return NotFound();

			return Ok(vehicle);
		}

		[HttpPost]
		public IActionResult Post([FromBody]Vehicle vehicle)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			_vehicleService.CreateVehicle(vehicle);

			return Created($"api/vehicles/{vehicle.Id}", null);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var vehicle = _vehicleService.GetVehicleById(id);

			if (vehicle == null)
				return BadRequest($"Vehicle with 'id = {id}' was not found.");

			_vehicleService.RemoveVehicle(vehicle);

			return NoContent();
		}
	}
}
