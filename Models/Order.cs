using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _MVC_ClothShop.Models
{
  
        public enum Comfirmation
        {
            Available, Out_of_Stock
        }

        public class Order   // order class 
        {
            public int ID { get; set; }
        [Required]
            public int CustomerID { get; set; }
            public int CategoryID { get; set; }
            public int BrandID { get; set; }
            public Comfirmation? Comfirmation { get; set; }

            public Customer Customer { get; set; }   /// <summary>
                                                     ///  cutonmer link as a foriegn key with order class 
                                                     /// </summary>
            public Category Category { get; set; }
            public Brand Brand { get; set; }
        }
    }


