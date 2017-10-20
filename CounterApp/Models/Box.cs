using System.Collections.Generic;

namespace CounterApp.Models
{
    public class Box<TCountable> : ICountable where TCountable : ICountable
    {
        public List<TCountable> ItemsInBox = new List<TCountable>();

        public int Count()
        {
            int total = 0;

            foreach (var item in ItemsInBox)
            {
                total += item.Count();
            }

            return total;
        }
    }
}