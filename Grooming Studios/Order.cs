using System;
using System.Collections.Generic;
using System.Text;

namespace Grooming_Studios
{
    class Order
    {
        private int _servicePrice;
        private DateTime _orderTime;
        private Client _client;
        private Animal [] _animal;
        private int _pricePerService;

        public Order()
        {
            _animal = new Animal[1];
        }
        public void CostCalculation(Client client, ListBreeds listBreeds )
        {
            var j = 0;
            for (var i = 0; i < client.animals.Length; i++)
            {
                j = 0;
                for (; j < listBreeds.breeds.Length; j++)
                {
                    if (listBreeds.breeds[j].BreedAnimal == client.animals[i].Breed && listBreeds.breeds[j].Genus == Genus.dog)
                    {
                        _servicePrice += 150 + 70 * listBreeds.breeds[j].Ratio;
                        _pricePerService = 150 + 70 * listBreeds.breeds[j].Ratio;
                        Console.WriteLine($"Цена за стрижку {client.animals[i].Breed} составляет: {_pricePerService}");
                        break;
                    }
                    if (listBreeds.breeds[j].BreedAnimal == client.animals[i].Breed && listBreeds.breeds[j].Genus == Genus.cat)
                    {
                        _servicePrice += 100 + 50 * listBreeds.breeds[j].Ratio;
                        _pricePerService = 100 + 50 * listBreeds.breeds[j].Ratio;
                        Console.WriteLine($"Цена за стрижку {client.animals[i].Breed} составляет: {_pricePerService}");
                        break;
                    }
                }
            }
            Console.WriteLine($"Стоимость услуг {_servicePrice}");
        }
        public void PlaceOrder(Client clinet, Animal animal) 
        {
            _client = clinet;
            _animal[0] = animal;
            _orderTime = DateTime.UtcNow;
        }
        public void PlaceOrder(Client clinet, Animal [] animal)
        {
            _client = clinet;
            _animal = animal;
            _orderTime = DateTime.UtcNow;
        }
        public void PrintOrders(Order[] orders)
        {
            for(var i = 0; i < orders.Length; i++)
            {
                Console.WriteLine($"Клиент {orders[i]._client.Name}");
                Console.WriteLine("Животное(ые):");
                for(var j = 0; j < orders[i]._client.animals.Length; j++)
                {
                    Console.WriteLine(orders[i]._client.animals[j].Name);
                }
                Console.WriteLine($"Дата и время заказа {orders[i]._orderTime}");
                Console.WriteLine($"Стоимость услуг {orders[i]._servicePrice}");
            }
        }
    }
}
