using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [ForeignKey("CustomerID")]
        public virtual List<Product> Products { get; set; }

        [ForeignKey("ProductID")]
        public  virtual List<Manufacturer> Manufacturers { get; set; }

        [ForeignKey("ProductID")]
        public virtual List<SalesOrder> SalesOrders { get; set; }
    }
}
