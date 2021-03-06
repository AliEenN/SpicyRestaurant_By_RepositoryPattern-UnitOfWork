using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyRestaurant.BLL.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        [MaxLength(100), MinLength(2), Display(Name = "Sub Category Name")]
        public string Name { get; set; }

        [Display(Name = "Category Name")]
        public byte CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
