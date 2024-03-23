using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_bt230324
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            Employees = new List<Employee>();
        }

    }
}
