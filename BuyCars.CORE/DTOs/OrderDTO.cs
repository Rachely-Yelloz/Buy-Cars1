using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime dateOfOrder { get; set; }
        public int Castomer { get; set; }
        public int Car { get; set; }
    }
}

