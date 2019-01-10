using Concessionaria.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concessionaria.Repository.Interfaces
{
    public interface IDealerService
    {
        List<Dealer> listarConcessionariaPorMontadora(string _montadora); 
    }
}
