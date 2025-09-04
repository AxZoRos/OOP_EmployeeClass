using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB15_KTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Employee emp = new Employee
            {
                Name = "Коновалов Євгеній",
                Salary = 30000,
                Position = ""
            }; 

            double bonus = emp.CalculateBonus(emp.Position); 
            Console.WriteLine($"Працівник: {emp.Name}");
            Console.WriteLine($"Посада: {emp.Position}");
            Console.WriteLine($"Місячна зарплата: {emp.Salary} грн");
            Console.WriteLine($"Бонус для позиції: {emp.Position}: {bonus:F2} грн");
            Console.WriteLine($"Загальна сума з бонусом: {emp.Salary + bonus:F2} грн");

            Console.ReadLine();

        }
    }
}
