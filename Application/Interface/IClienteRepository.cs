using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IClienteRepository
    {
        void PostCliente(Cliente cliente);

        Task<Cliente> GetCliente(string cpf);

    }
}
