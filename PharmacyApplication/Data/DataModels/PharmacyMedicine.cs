using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PharmacyApplication.Data.DataModels
{
    [PrimaryKey(nameof(PharmacyId), nameof(MedicineId))]
    public class PharmacyMedicine
    {
        [Required]
        public int PharmacyId { get; set; }

        [ForeignKey(nameof(PharmacyId))]
        public Pharmacy Pharmacy { get; set; } = null!;

        [Required]
        public int MedicineId { get; set; }

        [ForeignKey(nameof(MedicineId))]
        public Medicine Medicine { get; set; } = null!;
    }
}
