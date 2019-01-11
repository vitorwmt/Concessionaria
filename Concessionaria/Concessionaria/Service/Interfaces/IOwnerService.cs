using Concessionaria.Model;
using System.Collections.Generic;

namespace Concessionaria.Repository.Interfaces
{
    public interface IOwnerService
    {
        List<Owner> ListarPessoasPorNome(string nome);
    }
}
