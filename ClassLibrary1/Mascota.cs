using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mascota
    {
        private string _especie;
        private string _nombre;
        private string _fechaNacimiento;
        private List<string> _historialVacunacion = new List<string>();


        public Mascota(string especie, string nombre, string fechaNacimiento)
        {
            _especie = especie;
            _nombre = nombre;
            _fechaNacimiento = fechaNacimiento;
        }


        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string FechaNacimiento
        {
            get { return _fechaNacimiento;}
            set { _fechaNacimiento = value; }
        }


        public List<string> HistorialVacunacion
        {
            get { return _historialVacunacion; }
        }


        public void AgregarVacunaALista()
        {
            bool flag = true;
            string respuesta;
            while (flag)
            {
                Console.Write("Ingresar vacuna: ");
                string vacuna = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(vacuna))
                {
                    flag = false;
                }
                else
                {
                    _historialVacunacion.Add(vacuna);
                    flag = Validador.ContinuarCargaDeDatos("Desea ingresar otra vacuna? (s/n): ", flag);
                }
            }
        }

    }
}
