using JoyCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCore.Models
{
    public class Order : IEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public Users User { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
