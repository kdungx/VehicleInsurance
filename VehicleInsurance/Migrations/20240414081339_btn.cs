using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleInsurance.Migrations
{
    /// <inheritdoc />
    public partial class btn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "btn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucDichSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoChoNgoi = table.Column<int>(type: "int", nullable: false),
                    ThoiGianBaoHiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioBatDau = table.Column<TimeSpan>(type: "time", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioKetThuc = table.Column<TimeSpan>(type: "time", nullable: false),
                    MaGioiThieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DongY = table.Column<bool>(type: "bit", nullable: true),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_btn", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "btn");
        }
    }
}
