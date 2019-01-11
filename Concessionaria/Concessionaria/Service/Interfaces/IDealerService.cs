using Concessionaria.Model;
using System.Collections.Generic;

namespace Concessionaria.Repository.Interfaces
{
    public interface IDealerService
    {
        List<Dealer> ListarConcessionariaPorMontadora(string montadora); 
    }
}
