using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee("Elon", "Mask");
            e.Position = Position.Senior;
            e.Experience = 20;

            Console.WriteLine("Name: {0}\nSurname: {1}\nPosition: {2}", e.Name, e.Surname, e.Position);
            e.CalculateSalary();

            Console.ReadLine();
        }
    }
}
