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

        public delegate int ProcessItem(int total, T item);

        public int Count(ProcessItem processItem)
        {
            var total = 0;
            foreach (var item in List)
            {
                total = processItem(total, item);
            }
            return total;
        }
    }
}