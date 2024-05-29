using gas_station;
using Microsoft.AspNetCore.Mvc;

public class FuelController : Controller
{
    private readonly FuelTypeRepository _fuelTypeRepository;

    public FuelController(FuelTypeRepository fuelTypeRepository)
    {
        _fuelTypeRepository = fuelTypeRepository;
    }

    public IActionResult Success()
    {
        string connectionString = "Data Source=gas_station_db.db";
        FuelTypeRepository fuelTypeRepository = new FuelTypeRepository(connectionString);
        List<FuelType> fuelTypes = fuelTypeRepository.GetAllFuelTypes();

        return View(fuelTypes);
    }
}
