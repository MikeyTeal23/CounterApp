namespace CounterApp.Models
{
    public class Apple : ICountable
    {
        public Colour Colour;

        public Apple(Colour appleColour)
        {
            Colour = appleColour;
        }

        public int Count()
        {
            return 1;
        }
    }
}