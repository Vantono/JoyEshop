using JoyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCore.Interfaces;



public interface IUserService : IRepository<Users, string>
    {
        public List<ShoppingCartItem> GetUserShoppingCart(string id);

        public void AddItemToUserCart(Product product, string userId);

        public void RemoveItemFromUserCart(Product product, string userId);

        public void ClearUserShoppingCart(string userId);

        public decimal GetShoppingCartTotal(string userId);

        public int GetShoppingCartItemCount(string userId);
    }


