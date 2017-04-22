using System;

namespace nutshellpra
{
    class ValueAndRefParameters
    {
        public void Value(int x)
        {
            x += 1;
            Console.WriteLine($"Before Value: x = {x}");
        }

        public void Ref(ref int x)
        {
            x += 1;
            Console.WriteLine($"Before Ref: x = {x}");
        }

        //• Need not be assigned before going into the function
        //• Must be assigned before it comes out of the function
        public void OutRef(out int x)
        {
            x = 1;
            Console.WriteLine($"Before out Ref: x = {x}");
        }
    }
}
