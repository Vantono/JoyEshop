using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoyCore.Interfaces;

namespace JoyCore.Models;

public class OrderItem : IEntity<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
    public int ProductId { get; set; }
    [ForeignKey("productId")]
    public Product product { get; set; }
    public int OrderId { get ; set; }
    [ForeignKey("orderId")]
    public Order order { get; set; }
}
