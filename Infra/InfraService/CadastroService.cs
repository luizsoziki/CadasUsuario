using AutoMapper;
using Datas;
using Datas.datas;
using Domain.Entidades;
using Infra.Data;
using Infra.InfraRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.InfraService
{
    public class CadastroService : BaseRepository<DadosCliente> , ICadastroCliente
    {
        private readonly IMapper _mapper;
        public CadastroService(CadastroContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<Cliente> Get(string cpf)
        {
            var document =  Context.DadosClientes.Where(x => x.cpf == cpf).FirstOrDefault();

            return Mapper<Cliente>(document);
        }

        public void Post(Cliente cliente)
        {
            DadosCliente dados = new();



            var cpfreplace = cliente.CPF.Replace(".", "").Replace("-","");

            dados.cpf = cpfreplace;
            dados.Nome = cliente.Nome;
            dados.telefone = cliente.telefone;

            Context.DadosClientes.Add(dados);
            Context.SaveChanges();

        }

        protected T Mapper<T>(Object data)
        {
            return _mapper.Map<T>(data);
        }
    }
}
