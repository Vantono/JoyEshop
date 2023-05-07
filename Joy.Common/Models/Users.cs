
using JoyCore.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCore.Models
{
    public class Users : IdentityUser, IEntity<string>
    {
        [Display(Name ="Shopping Cart")]
        public List<ShoppingCartItem> ShoppingCart { get; set; } = new List<ShoppingCartItem>();
    }
}
