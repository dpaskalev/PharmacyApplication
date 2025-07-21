using PharmacyApplication.Common;
using System.ComponentModel.DataAnnotations;

namespace PharmacyApplication.Data.DataModels
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MedicineNameMaxLenght)]
        public string MedicineName { get; set; } = null!;

        [Required]
        public DateTime ExperationDate { get; set; }

        [Required]
        [Range(ValidationConstants.MedicinePriceMinValue, ValidationConstants.MedicinePriceMaxValue)]
        public double Price { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MedicineDescriptionMaxValue)]
        public string Description { get; set; } = null!;

        public string? ImageURL { get; set; }

        public ICollection<PharmacyMedicine> PharmaciesMedicines { get; set; } = new List<PharmacyMedicine>();

        public ICollection<UserMedicine> UsersMedicines { get; set; } = new List<UserMedicine>();
    }
}
