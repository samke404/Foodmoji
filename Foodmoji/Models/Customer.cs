using System;

namespace Foodmoji.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string cellphoneNo { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public Customer()
        {

        }
    }
}
