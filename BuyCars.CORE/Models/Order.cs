using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Models
{
    public class Order
    {
     [Key]   public int Id { get;  set; }
        public DateTime dateOfOrder { get; set; }
        public Castomer Castomer { get; set; }
        public Car Car { get; set; }
    }
}
