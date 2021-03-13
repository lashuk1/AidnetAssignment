using Application.Interfaces;
using Domain.Entities;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Application.Implementation.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Delete(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> Get()
        {
            return _carRepository.GetAllCar();
        }

        public Car GetById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public void Post(Car car, string currencyApi)
        {
            var currencyExchange = ExchangeRate(currencyApi);

            car.GelPrice = car.Price * currencyExchange;

            _carRepository.AddCar(car);
        }

        public void Put(int id, Car car, string currencyApi)
        {
            var currencyExchange = ExchangeRate(currencyApi);

            car.GelPrice = car.Price * currencyExchange;

            _carRepository.EditCar(id, car);
        }


        public double ExchangeRate(string url)
        {
            // Sending Http Request To Api
            var jsonString = GetResponse(url);
            //Parsing it from Json to Double
            return JObject.Parse(jsonString).First.First["val"].ToObject<double>();
        }

        private string GetResponse(string url)
        {
            string jsonString;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())

            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }
    }
}
