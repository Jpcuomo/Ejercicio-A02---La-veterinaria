using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Funciones
    {
        public static List<Cliente> listaClientes = new List<Cliente>();

        private static void CargarDatosCliente(out string nombre, out string apellido, out string direccion, out string telefono)
        {
            Console.Write("Nombre del cliente: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido del cliente: ");
            apellido = Console.ReadLine();
            Console.Write("Direccion del cliente: ");
            direccion = Console.ReadLine();
            Console.Write("Telefono del cliente: ");
            telefono = Console.ReadLine();
        }

        public static Cliente CrearCliente()
        {
            string nombre;
            string apellido;
            string direccion;
            string telefono;
            CargarDatosCliente(out nombre, out apellido, out direccion, out telefono);

            Cliente cliente = new Cliente(nombre, apellido, direccion, telefono);
            return cliente;
        }

        public static void AgregarClienteALista(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public static string MostrarInfoDelClienteYMascotas(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------------------------");
            sb.AppendLine("DATOS DEL CLIENTE:");
            sb.AppendLine($"Nombre y apellido: {cliente.Nombre} {cliente.Apellido}");
            sb.AppendLine($"Domicilio: {cliente.Domicilio}");
            sb.AppendLine($"Telefono: {cliente.Telefono}");
            sb.AppendLine();
            sb.AppendLine("MASCOTA/S:");
            foreach(Mascota mascota in cliente.ListaMascotas)
            {
                sb.AppendLine($"Especie: {mascota.Especie}");
                sb.AppendLine($"Nombre: {mascota.Nombre}");
                sb.AppendLine($"Fecha de nacimiento: {mascota.FechaNacimiento}");
                sb.AppendLine($"Historial de vacunación: ");
                if(mascota.HistorialVacunacion.Count > 0)
                {
                    foreach(string vacuna in mascota.HistorialVacunacion)
                    {
                        sb.Append($"   - {vacuna}");
                    }
                }
                else
                {
                    sb.AppendLine("   - Sin vacunas");
                }
                sb.AppendLine();
            }
            sb.AppendLine("------------------------------------------------------------------");

            return sb.ToString();
        }
    }
}
