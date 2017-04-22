using System;

namespace nutshellpra
{
    class StringPra
    {
        public void StringIndex(string name, out string firstName, out string midName, out string lastName)
        {
            int i = name.IndexOf(' ');
            int j = name.LastIndexOf(' ');
            firstName = name.Substring(0, i);
            midName = name.Substring(i + 1, 3);
            lastName = name.Substring(j + 1);
        }

        public void Split(string name)
        {
            string[] splitName = name.Split(' ');
            Console.WriteLine($"First Name: {splitName[0]}");
            Console.WriteLine($"Mid Name: {splitName[1]}");
            Console.WriteLine($"Last Name: {splitName[2]}");
        }
    }
}
