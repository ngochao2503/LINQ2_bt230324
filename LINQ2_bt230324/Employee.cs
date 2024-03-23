using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_bt230324
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }

        public Employee(int id, string name, int age, Position position, Department department)
        {
            Id = id;
            Name = name;
            Age = age;
            Position = position;
            Department = department;
        }

    }
}
