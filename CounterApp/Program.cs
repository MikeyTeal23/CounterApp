using System;
using System.Runtime.InteropServices;
using CounterApp.Models;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter<Box<Apple>> appleCounter= new Counter<Box<Apple>>();
            Counter<Cart> cartCounter = new Counter<Cart>();
            Counter<ICountable> everythingCounter = new Counter<ICountable>();

            Cart cart = new Cart();
            Box<Apple> appleBox = new Box<Apple>();
            Box<Banana> bananaBox = new Box<Banana>();
            Box<ICountable> fruitBox = new Box<ICountable>();

            for (int i = 0; i < 3; i++)
            {
                appleBox.ItemsInBox.Add(new Apple());
                bananaBox.ItemsInBox.Add(new Banana());
            }

            appleCounter.Add(appleBox);

            fruitBox.ItemsInBox.Add(appleBox);
            fruitBox.ItemsInBox.Add(bananaBox);
            cart.Add(fruitBox);
            cartCounter.Add(cart);

            Cart anotherCart = new Cart();
            anotherCart.Add(fruitBox);
            everythingCounter.Add(cart);
            everythingCounter.Add(anotherCart);
            everythingCounter.Add(appleBox);

            Console.WriteLine("Number of apples");
            Console.WriteLine(appleCounter.Count());

            Console.WriteLine("Number of things in one cart");
            Console.WriteLine(cartCounter.Count());

            Console.WriteLine("Number of all things");
            Console.WriteLine(everythingCounter.Count());
        }
    }
}
