using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_12
{
    internal class Employee
    {
        internal static int Id { get; set; } = 0;
        internal int _id { get; set; } = 0;
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal double Salary { get; set; }
        internal long WorkDuration { get; set; }
        internal double PricePerSecond { get; set; }

        public Employee(string name, string surname ,double pricePerSecond)
        {
            Id++;
            _id = Id;
            Name = name;
            Surname = surname;
            PricePerSecond = pricePerSecond;
        }

        internal double GetDailyPrice(int second)
        {
            Salary = second * PricePerSecond;
            return Salary;
        }
    }
}
