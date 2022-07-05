using System;

namespace Market.Web.Models
{
    public class Seller : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Address { get; set; }
    }
}
