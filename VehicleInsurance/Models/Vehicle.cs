using System.ComponentModel.DataAnnotations;

namespace VehicleInsurance.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Rate { get; set; }

        [Required]
        public string BodyNumber { get; set; }

        [Required]
        public string EngineNumber { get; set; }

        [Required]
        public string VehicleNumber { get; set; }

    }
}
