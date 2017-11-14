using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List EmployeeNames = new List();
            EmployeeNames.Add("Megha");
            EmployeeNames.Add("Shubham");
            EmployeeNames.Add("abc");
            EmployeeNames.Add("xyz");
            EmployeeNames.Print();

            Console.WriteLine("Available at " + EmployeeNames.Search("Megha") + " index");
            Console.WriteLine(EmployeeNames.Remove("abc"));
            EmployeeNames.Print();


            Console.ReadKey();
        }
    }
}
