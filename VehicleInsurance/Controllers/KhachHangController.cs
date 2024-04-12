using Microsoft.AspNetCore.Mvc;
using VehicleInsurance.Data;
using VehicleInsurance.Models;

namespace VehicleInsurance.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly VehicleInsuranceContext db;

        public KhachHangController(VehicleInsuranceContext context)
        {
            db=context;
        }
        [HttpGet]
        public IActionResult DangKy()
        {
            return View();
        }
        
    }
}
