using System.Collections.Generic;
using System.Linq;

namespace ECommerce  
{
    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            items.Add(item);
        }

        public void UpdateItem(string name, int quantity)
        {
            var item = items.FirstOrDefault(i => i.Name == name);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(string name)
        {
            items.RemoveAll(i => i.Name == name);
        }

        public decimal GetTotalWithoutDiscount()
        {
            return items.Sum(i => i.GetTotalPrice());
        }

        public List<CartItem> GetItems()
        {
            return items;
        }
    }
}