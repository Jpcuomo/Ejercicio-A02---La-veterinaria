using ClassLibrary1;

namespace Ejercicio_A02___La_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Juan", "Cuomo", "Madrid 251", "22/10/1985");
            Cliente cliente2 = new Cliente("Tomas", "Gomez", "España 251", "20/11/1985");
            //Mascota mascota1 = Cliente.CrearMascota();

            Mascota mascota1 = cliente1.CrearObjetoMascota();
            cliente1.AgregarMascotaALista(mascota1);
            mascota1.AgregarVacunaALista();


            foreach (Mascota mascota in cliente1.ListaMascotas)
            {
                Console.WriteLine(mascota.Nombre);
            }

            foreach(string vacuna in mascota1.HistorialVacunacion)
            {
                Console.WriteLine(vacuna);
            }

            foreach (Mascota mascota in cliente2.ListaMascotas)
            {
                Console.WriteLine(mascota.Nombre);
            }
        }
    }
}
