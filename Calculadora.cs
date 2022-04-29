using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_Inscripcion
{
    internal class Calculadora
    {
        //tipoDato identificador (nombreVariable);
        //string | bool | int | double | float 1.f
        int sumaNumeroUno = 5;
        int sumaNumeroDos = 10;

        //Miembro de tipo Propiedad
        //public tipoDato nombrePropiedad {}
        public int SumaNumeroUno
        {
            get
            {
                return sumaNumeroUno;
            }
            set
            {
                sumaNumeroUno = value;
            }
            //get(obtener | lectura)   set(poner | escritura)
        }

        public int NumeroDosLectura
        {
            //leer
            get { return sumaNumeroDos; }
        }
        public int NumeroDosEscritura
        {
            //escribir
            set { sumaNumeroDos = value; }
        }



    }
}
    

