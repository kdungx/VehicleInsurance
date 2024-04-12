﻿namespace VehicleInsurance.Data
{
    public class Banbe
    {
        public int MaBb { get; set; }

        public string? MaKh { get; set; }

        public int MaHh { get; set; }

        public string? HoTen { get; set; }

        public string Email { get; set; } = null!;

        public DateTime NgayGui { get; set; }

        public string? GhiChu { get; set; }


        public virtual KhachHang? MaKhNavigation { get; set; }
    }
}
