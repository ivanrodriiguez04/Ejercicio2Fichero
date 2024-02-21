using Ejercicio2Fichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que crea un nuevo cliente
        /// irodhan -> 20/02/2024
        /// </summary>
        /// <param name="listaClientes"></param>
        public void nuevoCliente(List<ClienteDto> listaClientes);

        /// <summary>
        /// Metodo que  crea el contenido de la empresa
        /// irodhan -> 20/02/2024
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public string crearContenido(ClienteDto cliente);
    }
}
