﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Datas.datas
{
  
    public partial class DadosCliente
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
    }
}