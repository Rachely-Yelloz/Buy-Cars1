using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.Models
{
    public class Car
    {
      
       [Key] public int Id { get;  set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public bool status { get; set; }
        
    }
}
