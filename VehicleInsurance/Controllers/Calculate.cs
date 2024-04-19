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
        public IActionResult TinhToan(btn model)
        {
            if (ModelState.IsValid)
            {

                // Xử lý tính phí bảo hiểm dựa trên thông tin nhập vào
                double phiBaoHiem = TinhPhiBaoHiem(model);

                // Truyền kết quả tính phí vào ViewBag để hiển thị trong view
                ViewBag.PhiBaoHiem = phiBaoHiem.ToString("C");

                // Trả về view hiển thị thông tin và kết quả tính phí
                return View(model);
            }

            // Nếu ModelState không hợp lệ, trả về view với model để hiển thị các thông báo lỗi
            return View(model);
        }
        private double TinhPhiBaoHiem(btn model)
        {
            double phiBaoHiem = 0;

            // Xử lý tính phí bảo hiểm dựa trên thông tin nhập vào
            if (model.LoaiXe == "ô tô chở người không KDVT")
            {
                int soChoNgoi = model.SoChoNgoi ?? 0;

                if (soChoNgoi < 6)
                {
                    phiBaoHiem = 480700;
                }
                else if (soChoNgoi >= 6 && soChoNgoi <= 11)
                {
                    phiBaoHiem = 873400;
                }
                else if (soChoNgoi >= 12 && soChoNgoi <= 24)
                {
                    phiBaoHiem = 1397000;
                }
                else if (soChoNgoi >= 25 && soChoNgoi <= 56)
                {
                    phiBaoHiem = 2007500;
                }
            }
            else if (model.LoaiXe == "ô tô chở hàng")
            {
                // Xử lý tính phí cho loại ô tô chở hàng
            }

            return phiBaoHiem;
        }
    }

   /* [HttpPost]
        public IActionResult TinhToan(btn modle)
        {
            if (ModelState.IsValid)
            {
                db.Add(modle);
                db.SaveChanges();


            }
            return View(modle);

        }

    }*/
}
