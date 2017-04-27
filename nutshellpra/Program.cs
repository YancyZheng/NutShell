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
            //StringPra();
            //ParametersPra();
            //ConstructorPra();
            ThisReference();
        }

        static void ThisReference()
        {
            ThisReference thisRef = new ThisReference();
            thisRef.Foo(thisRef);

            Employee employee = new Employee("Tom", 35);
            employee.PrintEmployeeInfo();
        }

        static void ConstructorPra()
        {
            //ConstructorPra constructorPra1 = new ConstructorPra(1);
            ConstructorPra constructorPra2 = new ConstructorPra(2, 2);
        }

        static void ParametersPra()
        {
            ParametersPra parametersPra = new ParametersPra();
            Console.WriteLine($"Sum: {parametersPra.Sum(1, 2, 3, 4)}"); // Same as parametersPra.Sum(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(parametersPra.Sentence("My ", "name ", "is ", "Yancy ", "Zheng"));

            parametersPra.OptionalParameters("Yancy");
            parametersPra.OptionalParameters("Karen", 2, false);

            // same as (1, y:2), (y:2, x:1)
            // (x: 1, 2) error
            parametersPra.NamedArguments(x: 1, y: 2); 
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
