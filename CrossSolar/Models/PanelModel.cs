using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Models
{
    public class PanelModel
    {
        public int Id { get; set; }

        [Required]
        [Range(-90.000000, 90.000000)]
        // Others Culuture for NumberDecimalSeparator 
        [RegularExpression(@"^-?\d+((\.|\,)\d{1,6})?$", ErrorMessage = "The field {0} must match the pattern -00.000000 or 00.000000")]
        public double Latitude { get; set; }

        [Required]
        [Range(-180.000000, 180.000000)]
        // Others Culuture for NumberDecimalSeparator 
        [RegularExpression(@"^-?\d+((\.|\,)\d{1,6})?$", ErrorMessage = "The field {0} must match the pattern -000.000000 or 000.000000")]
        public double Longitude { get; set; }

        [Required]
        [StringLength(16)]
        public string Serial { get; set; }

        public string Brand { get; set; }
    }
}