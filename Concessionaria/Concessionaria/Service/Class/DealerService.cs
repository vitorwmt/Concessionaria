using Concessionaria.Model;
using Concessionaria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Concessionaria.Service.Class
{
    public class DealerService : IDealerService
    {
        public List<Dealer> ListarConcessionariaPorMontadora(string montadora)
        {
            var lstDealer = AddDealer();

            return lstDealer.Where(x => x.Brand == montadora).ToList();
        }

        public List<Dealer> AddDealer()
        {
            var objDealer = new List<Dealer>();

            Dealer dealer1 = new Dealer
            {
                Id = Guid.NewGuid(),
                Name = "Jhon",
                Brand = "BMW"             
            };
            objDealer.Add(dealer1);

            Dealer dealer2 = new Dealer
            {
                Id = Guid.NewGuid(),
                Name = "Victor",
                Brand = "Lamborghini"
            };
            objDealer.Add(dealer2);

            Dealer dealer3 = new Dealer
            {
                Id = Guid.NewGuid(),
                Name = "Thiago",
                Brand = "Ferrari"
            };
            objDealer.Add(dealer3);

            return objDealer;
        }
    }
}
