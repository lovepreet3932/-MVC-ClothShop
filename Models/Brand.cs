using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _MVC_ClothShop.Models
{
    public class Brand
    {
        
        public int BrandID { get; set; }  // brand id
        [Required]
        public string Title { get; set; } // brand name


       
    }
}
