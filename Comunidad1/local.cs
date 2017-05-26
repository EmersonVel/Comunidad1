using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class local: propiedades
    {
        char nombre_com;
        char actividad_com;

        public char Nombre_com
        {
            get
            {
                return nombre_com;
            }

            set
            {
                nombre_com = value;
            }
        }

        public char Actividad_com
        {
            get
            {
                return actividad_com;
            }

            set
            {
                actividad_com = value;
            }
        }
    }
}