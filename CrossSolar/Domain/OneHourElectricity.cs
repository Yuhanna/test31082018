using System;
using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Domain
{//
    public class OneHourElectricity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string PanelId { get; set; }

        [Required]
        [Range(0, 9999999.999)]
        public double KiloWatt { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}