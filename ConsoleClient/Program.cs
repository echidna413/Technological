using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("http://localhost:64449");
            GetAll(client);

            Console.WriteLine();

            GetById(client, 2);

            Console.WriteLine();

            AddNewCar(client);
            GetAll(client);
        }

        private static void AddNewCar(RestClient client)
        {
            var request = new RestRequest("api/cars");
            var newCar = new
            {
                Name = "Opel",
                Owner = "Zafira, Олег, все же Zafira"
            };

            request.AddJsonBody(newCar);
            client.Post<Car>(request);
        }

        private static void GetById(RestClient client, int id)
        {
            var request = new RestRequest($"api/cars/{id}");
            var resultCar = client.Get<Car>(request).Data;
            Console.WriteLine("{0}. {1} - {2}", resultCar.Id, resultCar.Name, resultCar.Owner);
        }

        private static void GetAll(RestClient client)
        {
            var request = new RestRequest("api/cars");
            var result = client.Get<List<Car>>(request).Data;

            foreach (var car in result)
            {
                Console.WriteLine("{0}. {1} - {2}", car.Id, car.Name, car.Owner);
            }
        }
    }

    class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
    }
}
