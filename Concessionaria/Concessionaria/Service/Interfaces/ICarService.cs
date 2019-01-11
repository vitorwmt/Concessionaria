using Concessionaria.Model;
using System.Collections.Generic;

namespace Concessionaria.Repository.Interfaces
{
    public interface ICarService
    {
        List<Car> ListarCarrosPorAno(int ano);
        List<Car> ListarCarrosPorMarca(string marca);
    }
}
