using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PharmacyApplication.Data.DataModels;

namespace PharmacyApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineType> MedicineTypes { get; set; }

        public DbSet<Pharmacy> Pharmacies { get; set; }

        public DbSet<PharmacyMedicine> PharmaciesMedicines { get; set; }

        public DbSet<UserMedicine> UsersMedicines { get; set; }
    }
}
