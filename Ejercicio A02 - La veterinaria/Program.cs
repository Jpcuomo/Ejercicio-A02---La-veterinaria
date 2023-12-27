using ClassLibrary1;

namespace Ejercicio_A02___La_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Cargar datos del cliente: ");
                Cliente cliente = Acciones.CrearCliente();
                Acciones.AgregarClienteALista(cliente);
                Console.WriteLine();

                Console.WriteLine("Cargar datos de la mascota: ");
                bool flag2 = true;
                while (flag2)
                {
                    Mascota mascota = cliente.CrearObjetoMascota();
                    cliente.AgregarMascotaALista(mascota);
                    mascota.AgregarVacunaALista();
                    Console.WriteLine();

                    flag2 = Validador.ContinuarCargaDeDatos("Desea cargar otra mascota? (s/n): ", flag2);
                }

                flag = Validador.ContinuarCargaDeDatos("Desea cargar otro cliente? (s/n): ", flag);
            }

            Console.Clear();
            foreach (Cliente cliente in Acciones.listaClientes)
            {
                Console.WriteLine(Acciones.MostrarInfoDelClienteYMascotas(cliente));
            }
        }
    }
}
