using Microsoft.AspNetCore.Mvc;
using VehicleInsurance.Data;

namespace VehicleInsurance.Controllers
{
	public class Calculate : Controller
	{
		private readonly VehicleInsuranceContext db;

		public Calculate(VehicleInsuranceContext context)
		{
			db = context;
		}
		[HttpGet]
		public IActionResult TinhToan()
		{
			return View();
		}
	}
}
