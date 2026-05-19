using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias.ejemplo1
{
    public class Materia
    {

        private float p1;
        private float p2;
        private float p3;
        public string nombreMateria;

        //propiedades 
        public float _p1 {
            get { return p1; }
            set 
            { 
                if (value >= 0 && value <= 10)
                {
                    p1 = value;
                }
                else {
                    p1 = -1;
                }
            }
        }
        public float _p2 {
            get { return p2; }
            set {
                if (value >= 0 && value <= 10)
                {
                    p2 = value;
                }
                else {
                    p2 = -1;
                }
            }
        }
        public float _p3 {
            get { return p3; }
            set {
                if (value >= 0 && value <= 10)
                {
                    p3 = value;
                }
                else {
                    p3 = -1;
                }
            }
        }

        /*public string _nombreMateria {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }*/

        //agregar constructor

        public Materia() {
            p1 = 0;
            p2 = 0;
            p3 = 0;
            nombreMateria = "";
        }

        //constructores parametrizado
        public Materia(string nombreMateria, float p1, float p2, float p3) {
            this.nombreMateria = nombreMateria;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        //metodo
        public float calPromedio() {
            float prom = 0;
            prom = (p1 + p2 + p3) / 3;
            return prom;
        }

        public string Impresion() {
            return "Esta es la materia: " + nombreMateria + " y sus calificaciones son: \n" +
                "Parcial 1: " + p1 +"\n"+ "Parcial 2: "+ p2 + "\n" + "Parcial 3: " + p3+"\n";
        }
    }
}
