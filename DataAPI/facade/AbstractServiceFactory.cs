using BancoApp.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.servicios
{
    internal abstract class AbstractServiceFactory
    {
        public abstract IClienteService crearClienteService();





    }
}
