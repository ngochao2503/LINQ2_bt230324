using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2_bt230324
{
    internal class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Position(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
