using Concessionaria.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concessionaria.Repository.Interfaces
{
    public interface ICarService
    {
        List<Car> listarCarrosPorAno(int _ano);
        List<Car> listarCarrosPorMarca(string _marca);
    }
}
