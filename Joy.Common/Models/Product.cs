using JoyCore.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoyCore.Models;

public class Product : IEntity<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(50)]
    [Required(ErrorMessage = "Product Name Required")]
    [Display(Name ="Product Name")]
    public  string Name { get; set; }
    [StringLength(250)]
    [Display(Name ="Product Description")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Product Price Required")]
    [Display(Name = "Product Price")]
    [Range(0.5, 500.0, ErrorMessage = "Price must be at between 0.50 and 500.0.")]
    public decimal Price { get; set; }
    [Range(0.5, 500.0)]
    [Required]
    [Display(Name = "Quantity Required")]
    public int Quantity { get; set; }

}