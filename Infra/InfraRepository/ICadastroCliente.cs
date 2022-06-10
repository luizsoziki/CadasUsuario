﻿using Datas.datas;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.InfraRepository
{
    public interface ICadastroCliente
    {
        void Post(Cliente cliente);


        Task<Cliente> Get(string cpf);
    }
}
