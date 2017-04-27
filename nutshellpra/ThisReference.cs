using System;

namespace nutshellpra
{
    class ThisReference
    {
        public ThisReference ThisRef;

        public void Foo(ThisReference thisRef)
        {
            ThisRef = thisRef;
            thisRef.ThisRef = this;
        }
    }

    class Employee
    {
        private string name;
        private int age;
        private decimal salary = 3000.00m;

        public Employee(string employeeName, int employeeAge)
        {
            name = employeeName;
            age = employeeAge;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{name}: {age}");
            // Passing the object using this:
            Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
        }

        public decimal Salary
        {
            get { return salary; }
        }
    }

    class Tax
    {
        public static decimal CalcTax(Employee E)
        {
            return 0.08m * E.Salary;
        }
    }
}
