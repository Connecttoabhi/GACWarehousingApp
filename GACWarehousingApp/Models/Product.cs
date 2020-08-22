using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models
{
    public class Product
    {
        [Column("ProductID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductID { get; set; }

        [Column("ProductCode")]
        [Required]
        public string ProductCode { get; set; }

        [Required]
        public string  ProductName { get; set; }

        [Required]
        public string ProductDimensions { get; set; }

        [Required]
        public int CustomerID { get; set; }
    }
}
