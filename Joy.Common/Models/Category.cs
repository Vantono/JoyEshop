using JoyCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCore.Models
{
    public class Category : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public List<Product> Products { get; set; }

    }
}
