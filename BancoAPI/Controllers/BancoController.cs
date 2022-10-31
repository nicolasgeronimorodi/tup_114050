using Microsoft.AspNetCore.Mvc;
using BancoApp.servicios.interfaces;
using BancoApp.servicios.implementaciones;
using BancoApp.dominio;
using System.Security.Cryptography.X509Certificates;

namespace BancoAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        private IClienteService clienteAPI;

        public BancoController()
        {
            clienteAPI = new ClienteService();
        }

        [HttpGet("/clientes")]

        public IActionResult GetClientes()
        {
            List<Cliente> lst = null;
            try
            {
                lst = clienteAPI.getClientes();
                return Ok(lst);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/cliente")]

           public IActionResult PostCliente (Cliente cliente)
            {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Datos de cliente incorrectos!");
                }

                return Ok(clienteAPI.insertCliente(cliente));
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }


            }










        
    }
}
