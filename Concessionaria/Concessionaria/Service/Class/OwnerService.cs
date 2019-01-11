using Concessionaria.Model;
using Concessionaria.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Concessionaria.Service.Class
{
    public class OwnerService : IOwnerService
    {
        public List<Owner> ListarPessoasPorNome(string nome)
        {
            var lstOwner = AddOwner();

            return lstOwner.Where(x => x.Name == nome).ToList();
        }

        public List<Owner> AddOwner()
        {
            var objOwner = new List<Owner>();

            Owner owner1 = new Owner
            {
                Id = Guid.NewGuid(),
                Name = "Jhon",
                Phone = "13 5555-5555"
            };
            objOwner.Add(owner1);

            Owner owner2 = new Owner
            {
                Id = Guid.NewGuid(),
                Name = "Victor",
                Phone = "13 7777-7777"
            };
            objOwner.Add(owner2);

            Owner owner3 = new Owner
            {
                Id = Guid.NewGuid(),
                Name = "Thiago",
                Phone = "13 0000-0000"
            };
            objOwner.Add(owner3);

            return objOwner;
        }      
    }
}
