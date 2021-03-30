using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _MVC_ClothShop.Models
{
    public class Customer
    {
        // customer details 
        public string ID { get; set; }
        [Required]
        public string Customer_Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        

    }
}
