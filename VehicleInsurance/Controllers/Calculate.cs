using Microsoft.AspNetCore.Mvc;
using VehicleInsurance.Data;
using VehicleInsurance.Models;

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
		[HttpPost]
		public IActionResult TinhToan( btn modle)
		{
			if (ModelState.IsValid) {
                db.Add(modle);
                db.SaveChanges();
               
            }
            return View(modle);

        }
	}
}
