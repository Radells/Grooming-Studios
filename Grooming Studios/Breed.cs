using System;
using System.Collections.Generic;
using System.Text;

namespace Grooming_Studios
{
    public class Breed
    {
        public EnumBreed BreedAnimal { get; }
        public int Ratio { get; }
        public Genus Genus { get; }

        public Breed(EnumBreed breed, int ratio, Genus genus )
        {
            BreedAnimal = breed;
            Ratio = ratio;
            Genus = genus;
        }
    }
}
