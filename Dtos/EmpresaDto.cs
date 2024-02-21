using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Fichero.Dtos
{
    internal class EmpresaDto
    {
        //Atributos
        string nifEmpresa = "123456678A";
        string nombreEmpresa = "S.A CSI1";
        string domicilioEmpresa = "Calle Barbero de Sevilla 1º";
        string cpEmpresa = "41006";
        string provinciaEmpresa = "Sevilla";
        string paisEmpresa = "España";
        //Getters & Setters
        public string NifEmpresa { get => nifEmpresa; set => nifEmpresa = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string DomicilioEmpresa { get => domicilioEmpresa; set => domicilioEmpresa = value; }
        public string CpEmpresa { get => cpEmpresa; set => cpEmpresa = value; }
        public string ProvinciaEmpresa { get => provinciaEmpresa; set => provinciaEmpresa = value; }
        public string PaisEmpresa { get => paisEmpresa; set => paisEmpresa = value; }

    }
}
