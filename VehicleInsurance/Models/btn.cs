using Microsoft.AspNetCore.Mvc;

namespace VehicleInsurance.Models
{
    public class btn
    {
        public int Id { get; set; }
        public string LoaiXe { get; set; }
        public string MucDichSuDung { get; set; }
        public int SoChoNgoi { get; set; }
        public string ThoiGianBaoHiem { get; set; }
        public DateTime NgayBatDau { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public TimeSpan GioKetThuc { get; set; }
        public string MaGioiThieu { get; set; }
        public bool DongY { get; set; }


    }
}
