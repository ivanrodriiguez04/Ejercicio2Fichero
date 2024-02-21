using Ejercicio2Fichero.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public string crearContenido(ClienteDto cliente)
        {
            EmpresaDto empresa = new EmpresaDto();

            string contenido =
                "Diseñar lo de arriba\n" +
                $"Referencia de la orden de domiciliacion:{cliente.ReferenciaOrden}" +
                $"Identificador del acreedor:{empresa.NifEmpresa}" +
                "Diseñar lo de abajo\n";
            return contenido;
        }

        public void nuevoCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Nombre deudor:");
            cliente.NombreDeudor = Console.ReadLine();
            Console.WriteLine("Direccion deudor:");
            cliente.DireccionDeudor = Console.ReadLine();
            Console.WriteLine("CP deudor:");
            cliente.CpDeudor = Console.ReadLine();
            Console.WriteLine("IBAN deudor:");
            cliente.IbanDeudor = Console.ReadLine();
            Console.WriteLine("Swift deudor");
            cliente.SwiftBancoDeudor = Console.ReadLine();
            Console.WriteLine("Tipo de pago:");
            cliente.TipoPago=Convert.ToChar(Console.ReadLine());
            cliente.ReferenciaOrden = siguienteReferencia(listaClientes);
            
            listaClientes.Add(cliente);
        }
        private long siguienteReferencia(List<ClienteDto> listaClientes) 
        {
            int tamanyoLista = listaClientes.Count;
            long nuevaReferencia;
            if (tamanyoLista > 0)
            {
                nuevaReferencia = listaClientes[tamanyoLista - 1].ReferenciaOrden + 1;
            }
            else 
            {
                nuevaReferencia = 1;
            }
            return nuevaReferencia;
        }
    }
}
