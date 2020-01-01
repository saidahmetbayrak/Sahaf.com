using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sahaf.UI.MVC.Tools
{
    public class MyCart
    {
        //basket=sepet
        private Dictionary<int, CartItem> _basket = new Dictionary<int, CartItem>();

        public List<CartItem> GetAllCartItem { get { return _basket.Values.ToList(); } } // property tanımlandı.

        public void Add(CartItem cartItem)
        {
            if (_basket.ContainsKey(cartItem.ID))
            {
                _basket[cartItem.ID].Quantity += cartItem.Quantity;
                return;
            }
            _basket.Add(cartItem.ID, cartItem);
        }
        public void Update(int id, short quantity)
        {
            if (_basket.ContainsKey(id))
            {
                _basket[id].Quantity = quantity;
            }
            
        }
        public void Delete(int id)
        {
            if (_basket.ContainsKey(id))
            {
                _basket.Remove(id);
            }
        }

        public int TotalAmount { get { return _basket.Values.Sum(x => x.Quantity); } }

    }
}