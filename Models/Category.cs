using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _MVC_ClothShop.Models
{
    public class Category
    {
          // ctaegory clas 
    
       
        public int CategoryID { get; set; }   // category id 
        [Required]
        public string Title { get; set; } // category title   


        

    }
}
