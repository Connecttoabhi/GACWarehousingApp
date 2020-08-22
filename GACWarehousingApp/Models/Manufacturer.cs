using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models
{
    public class Manufacturer
    {
        [Column("ManufacturerID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ManufacturerID { get; set; }

        [StringLength(100)]
        public string ManufacturerCode { get; set; }

        [StringLength(100)]
        public string ManufacturerAddress { get; set; }

        [StringLength(100)]
        public string ManufacturerRating { get; set; }

        [Required]
        public int ProductID { get; set; }
    }
}
