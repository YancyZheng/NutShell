using System;
using System.Text;

namespace nutshellpra
{
    class ParametersPra
    {
        // The params modifier
        public int Sum(params int[] ints)
        {
            int sum = 0;

            for(int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            return sum;
        }

        // The params modifier
        public string Sentence(params string[] name)
        {
            StringBuilder completeName = new StringBuilder();

            for(int i = 0; i < name.Length; i++)
            {
                completeName.Append(name[i]);
            }

            return completeName.ToString();
        }

        // Optional parameters:
        // Optional parameters cannot be marked with ref or out.
        // Mandatory parameters must occur before optional parameters in both the method declaration and the method call.
        public void OptionalParameters(string name, int i = 1, bool status = true)
        {
            Console.WriteLine($"{name} is {i}, this is {status}");
        }

        // Named arguments
        public void NamedArguments(int x, int y)
        {
            Console.WriteLine(x + ", " + y);
        }
    }
}
