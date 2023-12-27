using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _telefono;
        private List<Mascota> _listaMascotas = new List<Mascota>();


        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _domicilio = domicilio;
            _telefono = telefono;
        }


        public string Nombre 
        {  
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Apellido 
        {  
            get { return _apellido; } 
            set { _apellido = value; }
        }


        public string Domicilio 
        { 
            get {  return _domicilio; }
            set { _domicilio = value; }
        }


        public string Telefono 
        {  
            get { return _telefono; } 
            set { _telefono = value; }
        }


        public List<Mascota> ListaMascotas
        {  
            get { return _listaMascotas; }
        }


        // Método llamado dentro del método CrearObjetoMascota()
        private void IngresarDatosDelAnimal(out string especie, out string nombre, out string fechaNacimiento)
        {
            Console.Write("Ingresar especie animal: ");
            especie = Console.ReadLine();
            Console.Write("Ingresar nombre del animal: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresar fecha de nacimiento del animal (formato dd/MM/yyyy): ");
            fechaNacimiento = Console.ReadLine();
        }


        public Mascota CrearObjetoMascota()
        {
            string especie;
            string nombre;
            string fechaNacimiento;
            IngresarDatosDelAnimal(out especie, out nombre, out fechaNacimiento);

            Mascota mascota = new Mascota(especie, nombre, fechaNacimiento);
            return mascota;
        }


        public void AgregarMascotaALista(Mascota mascota)
        {
            _listaMascotas.Add(mascota);
        }


        
    }
}
