using System.Collections.Generic;
using System.Linq;

namespace ECommerce
{
    class Cart
    {
        private readonly List<CartItem> _items = new List<CartItem>();
        
        public void Add(CartItem item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _items.Add(item);
            }
        }

        public void Remove(string productName)
        {
            _items.RemoveAll(i => i.Name == productName);
        }
        
        public void Update(string productName, int newQuantity)
        {
            var item = _items.FirstOrDefault(i => i.Name == productName);
            if (item != null)
            {
                item.Quantity = newQuantity;
            }
        }

        public List<CartItem> GetAll() => _items;
    }
}