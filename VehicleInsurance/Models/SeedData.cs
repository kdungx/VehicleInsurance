using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using VehicleInsurance.Data;
using VehicleInsurance.Models;

namespace VehicleInsurance.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehicleInsuranceContext(
                serviceProvider.GetRequiredService<DbContextOptions<VehicleInsuranceContext>>()))
            {
                // Check if customers exist
                if (context.Customer.Any())
                {
                    return; // DB has been seeded
                }

                // Seed customers
                context.Customer.AddRange(
                    new Customer
                    {
                        Name = "When",
                        Address = "123 gi do",
                        PhoneNumber = "555-1234"
                    },
                    new Customer
                    {
                        Name = "You",
                        Address = "12345 gi do",
                        PhoneNumber = "555-123456"
                    },
                    new Customer
                    {
                        Name = "Find",
                        Address = "1234567 gi do",
                        PhoneNumber = "555-12345"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

