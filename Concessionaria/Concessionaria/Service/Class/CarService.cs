using Concessionaria.Model;
using Concessionaria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Concessionaria.Service.Class
{
    public class CarService : ICarService
    {
        public List<Car> ListarCarrosPorAno(int ano)
        {
            var lstCar = AddCar();

            return lstCar.Where(x => x.Year == ano).ToList();
        }

        public List<Car> ListarCarrosPorMarca(string marca)
        {
            var lstCar = AddCar();

            return lstCar.Where(x => x.Brand == marca).ToList();
        }

        public List<Car> AddCar()
        {
            var objCar = new List<Car>();

            Car car1 = new Car
            {
                Id = Guid.NewGuid(),
                Brand = "BMW",
                Model = "BMW X1",
                Year = 2017
            };
            objCar.Add(car1);

            Car car2 = new Car
            {
                Id = Guid.NewGuid(),
                Brand = "Ferrari",
                Model = "Ferrari 488",
                Year = 2015
            };
            objCar.Add(car2);

            Car car3 = new Car
            {
                Id = Guid.NewGuid(),
                Brand = "Lamborghini",
                Model = "Lamborghini Huracan",
                Year = 2017
            };
            objCar.Add(car3);

            return objCar;
        }
    }
}