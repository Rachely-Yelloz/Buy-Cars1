using BuyCars.CORE.Models;

namespace BuyCars.API.Models
{
    public class OrdersPostModel
    {
        public DateTime dateOfOrder { get; set; }
        public int Castomer { get; set; }
        public int Car { get; set; }
    }
}
