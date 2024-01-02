using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Card
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public AnimalType? Type { get; set; }
        public string Description { get; set; }

        public Card(string name, string latinName, string description)
        {
            Name = name;
            LatinName = latinName;
            Description = description;
            Type = null;
        }
    }
}
