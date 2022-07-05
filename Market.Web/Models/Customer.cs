using System;

namespace Market.Web.Models
{
    public class Customer : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public double Credit { get; set; }
    }
}
