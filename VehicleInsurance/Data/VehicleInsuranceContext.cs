using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleInsurance.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VehicleInsurance.Data
{
    public class VehicleInsuranceContext : IdentityDbContext<AppUser>
    {
        public VehicleInsuranceContext (DbContextOptions<VehicleInsuranceContext> options) : base(options)
        {
        }

        public DbSet<VehicleInsurance.Models.Customer> Customer { get; set; } = default!;
        public DbSet<VehicleInsurance.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<VehicleInsurance.Models.btn> btn { get; set; } = default!;
    }
}
