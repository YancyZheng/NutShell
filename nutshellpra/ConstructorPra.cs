using System;

namespace nutshellpra
{
    class ConstructorPra
    {
        // executes first 
        public ConstructorPra(int price)
        {
            Console.WriteLine($"Price: {price}");
        }

        public ConstructorPra(int price, int quantity) : this(price)
        {
            Console.WriteLine($"{quantity} apples is {price}");
        }
    }
}
