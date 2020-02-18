using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace LLIB.Models
{
   public class BookGenre
    {
        public static string Text { get; internal set; }
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
      
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
      
        public string Author { get; set; }

        [Required]
        
        public string Genre { get; set; }
        public int Price { get; set; }
        public List<Order> Orders { get; set; }

    }
}
