using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void OutRef(out int x)
        {
            x = 1;
            Console.WriteLine($"Before out Ref: x = {x}");
        }
    }
}
