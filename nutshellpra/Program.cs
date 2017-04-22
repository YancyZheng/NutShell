using System;

namespace nutshellpra
{
    class Program
    {
        static void Main(string[] args)
        {
            //RefTransfer();
            //ValueTransfer();
            //ValueAndRefParameters();
            StringPra();
        }

        static void StringPra()
        {
            StringPra stringPra = new StringPra();
            string a, b, c;
            stringPra.StringIndex("Stevie Ray Vaughan", out a, out b, out c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            stringPra.Split("Stevie Ray Vaughan");
        }

        static void RefTransfer()
        {
            PointRef point1 = new PointRef();
            point1.x = 10;

            PointRef point2 = point1;

            Console.WriteLine("Ref***************");
            Console.WriteLine($"point1 x: {point1.x}, point2 x: {point2.x}");

            point1.x = 11;

            Console.WriteLine($"point1 x: {point1.x}, point2 x: {point2.x}");
        }

        static void ValueTransfer()
        {
            PointValue point1 = new PointValue();
            point1.x = 10;

            PointValue point2 = point1;

            Console.WriteLine("Value***************");
            Console.WriteLine($"point1 x: {point1.x}, point2 x: {point2.x}");

            point1.x = 11;

            Console.WriteLine($"point1 x: {point1.x}, point2 x: {point2.x}");
        }

        static void ValueAndRefParameters()
        {
            int x = 8;
            ValueAndRefParameters valueAndRefParameters = new ValueAndRefParameters();

            valueAndRefParameters.Value(x);
            Console.WriteLine($"After Value: x = {x}");

            valueAndRefParameters.Ref(ref x);
            Console.WriteLine($"After Ref: x = {x}");
            
            valueAndRefParameters.OutRef(out x);
            Console.WriteLine($"After Out Ref: x = {x}");
        }
    }
}
