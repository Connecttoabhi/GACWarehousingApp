using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models
{
    public class SalesOrder
    {

        [Column("SalesID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int SalesID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [StringLength(100)]
        public string ProductList { get; set; }

        [StringLength(100)]
        public string ProductQuantity { get; set; }

        [Required]
        public int ProductID { get; set; }
    }
}
