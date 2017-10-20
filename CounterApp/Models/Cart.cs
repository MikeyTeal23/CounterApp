using System.Collections.Generic;

namespace CounterApp.Models
{
    public class Cart : ICountable
    {
        public List<Box<ICountable>> ItemsInCart = new List<Box<ICountable>>();

        public void Add(Box<ICountable> item)
        {
            ItemsInCart.Add(item);
        }

        public int Count()
        {
            int total = 0;

            foreach (var item in ItemsInCart)
            {
                total += item.Count();
            }

            return total;
        }
    }
}