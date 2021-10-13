using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class Nodo
    {
        private int informacion;

        public int Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }

        private Nodo enlace;

        public Nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }

    }
}
