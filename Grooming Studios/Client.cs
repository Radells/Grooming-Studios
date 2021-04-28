using System;
using System.Collections.Generic;
using System.Text;

namespace Grooming_Studios
{
    public class Client
    {
        public string Name { get; private set; }
        public string Telephone { get; private set; }
        public Animal [] animals;

        public Client(string name, string telephone)
        {
            Name = name;
            Telephone = telephone;
        }
        public void AddAnimal(string name, EnumBreed breed)
        {
            Animal animal = new Animal(name, breed);
            if(animals == null)
            {
                animals = new Animal[1];
                animals[0] = animal;
            }
            else
            {
                Array.Resize(ref animals, animals.Length + 1);
                animals[animals.Length-1] = animal;
            }
        }
        //public void delAnimal(string name, EnumBreed breed, Genus genus)
    }
}
