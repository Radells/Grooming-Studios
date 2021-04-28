using System;

namespace Grooming_Studios
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBreeds listBreeds = new ListBreeds();
            listBreeds.AddBreed(EnumBreed.toyterrier, 1, Genus.dog);
            listBreeds.AddBreed(EnumBreed.siamese, 1, Genus.cat);
            listBreeds.AddBreed(EnumBreed.shepherd, 4, Genus.dog);
            Client[] client = new Client[]
            {
                new Client("Николаев Данил", "89020200056"),
                new Client("Просеков Алексей", "89084205042")
            };
            client[0].AddAnimal("барсик", EnumBreed.siamese);
            client[0].AddAnimal("бар", EnumBreed.toyterrier);
            Order order = new Order();
            
            order.CostCalculation(client[0], listBreeds);
            order.PlaceOrder(client[0], client[0].animals);
            //order[1].CostCalculation(client[1], listBreeds);
            //order[1].PlaceOrder(client[1], client[1].animals);
            //order[0].PrintOrders(order);
        }
    }
}
