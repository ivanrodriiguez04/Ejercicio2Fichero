using Ejercicio2Fichero.Dtos;
using Ejercicio2Fichero.Servicios;

namespace Ejercicio2Fichero.Controladores
{
    /// <summary>
    /// Clase princicpal de la aplicacion
    /// irodhan -> 19/02/2024
    /// </summary>
    class Program
    {
        static List<ClienteDto> listaClientes = new List<ClienteDto>();
        static string rutaFichero = "C:\\Users\\csi22-irodhan\\Desktop";
        /// <summary>
        /// Método princicpal de la aplicacion
        /// irodhan -> 19/02/2024
        /// </summary>
        /// <param name="args"></param>
        public void Main(string[] args)
        {
            OperativaInterfaz oI = new OperativaImplementacion();
            string entrada;
            //Se le pregunta al usuario si quiere añadir otro cliente
            do {
                oI.nuevoCliente(listaClientes);
                Console.WriteLine("Quiere añadir otro cliente? (s/n)");
                entrada = Console.ReadLine();
            } while (entrada.Equals("s"));

            foreach (ClienteDto cliente in listaClientes)
            {
                //Se guarda el nombre del desagregado en un array
                string[] nombreDesagregado=cliente.NombreDeudor.Split(" ");
                //Se crea el nombre del fichero
                string nombreFichero = nombreDesagregado[0] + nombreDesagregado[1] + ".txt";
                //Se crea la ruta fianl del fichero juntando la ruta del fichero junto al nombre anteriormente guardado
                string rutaCompletaFichero = rutaFichero + nombreFichero;

                using (StreamWriter ficheroAdeudo = new StreamWriter(rutaCompletaFichero)) 
                {
                    ficheroAdeudo.Write(oI.crearContenido(cliente));
                }
            }
        }
    }
}
