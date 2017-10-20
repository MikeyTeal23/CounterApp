using System.Collections.Generic;

namespace CounterApp.Models
{
    public interface ICounter
    {
        List<T> List<T>();
    }

    public class Counter<T> where T : ICountable
    {
        List<T> List = new List<T>();

        public void Add(T item)
        {
            List.Add(item);
        }

        public int Count()
        {
            int total = 0;
            foreach (var item in List)
            {
                total += item.Count();
            }
            return total;
        }
    }
}