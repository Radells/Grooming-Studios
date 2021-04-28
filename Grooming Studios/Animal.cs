using System;
using System.Collections.Generic;
using System.Text;

namespace Grooming_Studios
{
    public class Animal
    {
        public string Name { get; }
        public EnumBreed Breed { get; }

        public Animal(string name, EnumBreed bread)
        {
            Name = name;
            Breed = bread;
        }
    }
}
