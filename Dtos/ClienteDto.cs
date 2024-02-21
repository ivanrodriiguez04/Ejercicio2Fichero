using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Dtos
{
    internal class ClienteDto
    {
        //Atributos
        long referenciaOrden;
        string nombreDeudor = "aaaaa";
        string direccionDeudor = "aaaaa";
        string cpDeudor = "aaaaa";
        string ibanDeudor = "aaaaa";
        string swiftBancoDeudor = "aaaaa";
        DateTime fchAdeudo=DateTime.Today;
        char tipoPago = 'a';
        //Getters & Setters
        public long ReferenciaOrden { get => referenciaOrden; set => referenciaOrden = value; }
        public string NombreDeudor { get => nombreDeudor; set => nombreDeudor = value; }
        public string DireccionDeudor { get => direccionDeudor; set => direccionDeudor = value; }
        public string CpDeudor { get => cpDeudor; set => cpDeudor = value; }
        public string IbanDeudor { get => ibanDeudor; set => ibanDeudor = value; }
        public string SwiftBancoDeudor { get => swiftBancoDeudor; set => swiftBancoDeudor = value; }
        public DateTime FchAdeudo { get => fchAdeudo; set => fchAdeudo = value; }
        public char TipoPago { get => tipoPago; set => tipoPago = value; }


    }   
}
