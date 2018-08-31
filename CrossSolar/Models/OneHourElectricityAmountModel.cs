using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrossSolar.Models
{
    public class OneHourElectricityAmountModel
    {
        public int Id { get; set; }

        [Required]
        [Range(0, 9999999.999)]
        public double Amount { get; set; }

        public DateTime DateTime { get; set; }

        // Default value = UnitTypeWatt.KiloWatt
        public UnitTypeWatt TypeWatt { get; set; } = UnitTypeWatt.KiloWatt;
    }
}
