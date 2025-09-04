using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB15_KTP
{
    internal class Employee
    {
        // Приватні поля
        private string name;
        private double salary;
        // Властивість Name з гетером/сетером
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ім'я не може бути порожнім.");
                name = value;
            }
        }
        // Властивість Salary з гетером/сетером і валідацією
        public double Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Зарплата не може бути від'ємною.");
                salary = value;
            }
        }
        public string Position { get; set; } 
        // Базовий бонус: 10% від зарплати
        public double CalculateBonus()
        {
            const double defaultRate = 0.10;
            return salary * defaultRate;
        }
        // Перевантажений метод: бонус залежно від посади
        public double CalculateBonus(string position)
        {
            double rate;
            switch (position)
            {
                case "Manager":
                    rate = 0.20; // 20% для менеджерів
                    break;
                case "Developer":
                    rate = 0.15; // 15% для розробників
                    break;
                default:
                    rate = 0.10; // 10% за замовчуванням
                    break;
            }
            return salary * rate;
        }
    }
}

    
        
    
