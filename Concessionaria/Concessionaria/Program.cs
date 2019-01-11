using Concessionaria.Service.Class;
using System;

namespace Concessionaria
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var objCar = new CarService();
            var lst = objCar.ListarCarrosPorAno(2015);
            var lstMarca = objCar.ListarCarrosPorMarca("Lamborghini");

            Console.WriteLine("------ Listando carro por ano ------");
            foreach (var item in lst)
            {
                Console.WriteLine($"Id: {item.Id}, Modelo: {item.Model}, Marca: {item.Brand}, Ano: {item.Year} \n");
            }

            Console.WriteLine("------ Listando carro por Marca ------");
            foreach (var item in lstMarca)
            {
                Console.WriteLine($"Id: {item.Id}, Modelo: {item.Model}, Marca: {item.Brand}, Ano: {item.Year} \n");
            }

            var objOwner = new OwnerService();
            var lstOwner = objOwner.ListarPessoasPorNome("Victor");

            Console.WriteLine("------ Listando Dono por Nome ------");
            foreach (var item in lstOwner)
            {
                Console.WriteLine($"Id: {item.Id}, Nome: {item.Name}, Telefone: {item.Phone} \n");
            }

            var objDealer = new DealerService();
            var lstDealer = objDealer.ListarConcessionariaPorMontadora("Ferrari");

            Console.WriteLine("------ Listando Concessionaria por Montadora ------");
            foreach (var item in lstDealer)
            {
                Console.WriteLine($"Id: {item.Id}, Nome: {item.Name}, Montadora: {item.Brand} \n");
            }

            Console.ReadLine();
        }
    }
}