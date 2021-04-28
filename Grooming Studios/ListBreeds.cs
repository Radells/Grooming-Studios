using System;

namespace Grooming_Studios
{
    public class ListBreeds
    {
        public Breed[] breeds;

        public void AddBreed(EnumBreed breed, int ratio, Genus genus)
        {
            Breed newBreed = new Breed(breed, ratio, genus);
            if (breeds == null)
            {
                breeds = new Breed[1];
                breeds[0] = newBreed;
            }
            else
            {
                Array.Resize(ref breeds, breeds.Length + 1);
                breeds[breeds.Length - 1] = newBreed;
            }
        }
    }
}
