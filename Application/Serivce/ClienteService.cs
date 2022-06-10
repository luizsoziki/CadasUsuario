using Application.Interface;
using Domain.Entidades;
using Infra.InfraRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serivce
{
    public class ClienteService : IClienteRepository
    {
        private readonly ICadastroCliente _CadastroCliente;

        public ClienteService(ICadastroCliente cadastrocliente)
        {
            _CadastroCliente = cadastrocliente;

        }

        public async Task<Cliente> GetCliente(string cpf)
        {
           return await  _CadastroCliente.Get(cpf);
        }

        public void PostCliente(Cliente cliente)
        {
            _CadastroCliente.Post(cliente);
        }
    }
}
