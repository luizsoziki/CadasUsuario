using Application.Interface;
using Domain.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadasUsuario.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        public CadastroController(IClienteRepository clienterepository)
        {
            _clienteRepository = clienterepository;
        }

        [HttpPost]
        public ActionResult PostCliente([FromBody] Cliente cliente)
        {
             _clienteRepository.PostCliente(cliente);
            return Ok("ok");
        }

        [HttpGet("{cpf}")]

        public async Task<ActionResult> Get (string cpf)
        {
            Cliente Usuarios = await _clienteRepository.GetCliente(cpf);

            if (Usuarios is null)
                return NotFound();

            return Ok(Usuarios);
        }


    }
}
