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
        private string nombreMateria;

        //propiedades 
        public float _p1 {
            get { return p1; }
            set { _p1 = value; }
        }
        public float _p2 {
            get { return p2; }
            set { p2 = value; }
        }
        public float _p3 {
            get { return p3; }
            set { p3 = value; }
        }

        //metodo
        public float calPromedio() {
            float prom = 0;
            prom = (p1 + p2 + p3) / 3;
            return prom;
        }
    }
}
