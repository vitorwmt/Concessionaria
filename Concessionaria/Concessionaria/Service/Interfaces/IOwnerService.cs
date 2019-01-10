using Concessionaria.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concessionaria.Repository.Interfaces
{
    public interface IOwnerService
    {
        List<Owner> listarPessoasPorNome(string _nome);
    }
}
