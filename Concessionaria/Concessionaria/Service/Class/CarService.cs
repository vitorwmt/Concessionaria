using Concessionaria.Model;
using Concessionaria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concessionaria.Service.Class
{
    public class CarService : ICarService
    {
        List<Car> objCar = new List<Car>();

        public List<Car> listarCarrosPorAno(int _ano)
        {
             
            foreach (var item in objCar)
            {
              //  return item.Id;
            }
            throw new NotImplementedException();
        }

        public List<Car> listarCarrosPorMarca(string _marca)
        {
            throw new NotImplementedException();
        }

        public void AddCar()
        {
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
        }
    }
}
