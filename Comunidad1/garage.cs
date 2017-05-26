using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class garage:propiedades
    {
        char abierta;
        char cerrada;
        char s;
        char n;

        public char Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public char Cerrada
        {
            get
            {
                return cerrada;
            }

            set
            {
                cerrada = value;
            }
        }

        public char S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public char N
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }
    }
}