using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class pisos : propiedades
    {
        char vh;
        char vn;
        int No_dormitorios;

        public char Vh
        {
            get
            {
                return vh;
            }

            set
            {
                vh = value;
            }
        }

        public char Vn
        {
            get
            {
                return vn;
            }

            set
            {
                vn = value;
            }
        }

        public int No_dormitorios1
        {
            get
            {
                return No_dormitorios;
            }

            set
            {
                No_dormitorios = value;
            }
        }
    }
}