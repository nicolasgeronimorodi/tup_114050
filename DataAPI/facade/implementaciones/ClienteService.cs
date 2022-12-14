using BancoApp.datos.implementaciones;
using BancoApp.datos.interfaces;
using BancoApp.dominio;
using BancoApp.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.servicios.implementaciones
{
    public class ClienteService:IClienteService
    {
        private IClienteDAO clienteDAO;

        public ClienteService()
        {
            clienteDAO = new ClienteDAO();
        }



        public List<Cliente> getClientes()
        { 
        return clienteDAO.getClientes();
        }


        public int insertCliente(Cliente cliente)
        {
            return clienteDAO.insertCliente(cliente);
        }

        public bool logicDeleteCliente(Cliente cliente)
        {
            return clienteDAO.logicDeleteCliente(cliente);
        }


        public bool confirmarAsociacion(ResumenCliente resumenCliente)
        {
            return clienteDAO.confirmarAsociacion(resumenCliente);
        }

    }
}
