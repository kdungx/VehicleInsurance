using System;
using System.ComponentModel.DataAnnotations;

namespace VehicleInsurance.Models
{
    public class btn
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Loại xe là trường bắt buộc.")]
        public string LoaiXe { get; set; } = "";
         
        public string ? MucDichSuDung { get; set; }

        [Required(ErrorMessage = "Số chỗ ngồi là trường bắt buộc.")]
        [Range(1, int.MaxValue, ErrorMessage = "Số chỗ ngồi phải lớn hơn 0.")]
        public int ? SoChoNgoi { get; set; }

        
        public string ThoiGianBaoHiem { get; set; } = "";

        [Required(ErrorMessage = "Ngày bắt đầu là trường bắt buộc.")]
        public DateTime ? NgayBatDau { get; set; }

        [Required(ErrorMessage = "Giờ bắt đầu là trường bắt buộc.")]
        public TimeSpan ? GioBatDau { get; set; }

        [Required(ErrorMessage = "Ngày kết thúc là trường bắt buộc.")]
        public DateTime ? NgayKetThuc { get; set; }

        [Required(ErrorMessage = "Giờ kết thúc là trường bắt buộc.")]
        public TimeSpan ? GioKetThuc { get; set; }

        public string ? MaGioiThieu { get; set; }

        [Required(ErrorMessage = "Bạn phải đồng ý với các điều khoản.")]
        public bool  DongY { get; set; }
    }
}
