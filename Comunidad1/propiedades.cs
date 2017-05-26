using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class propiedades
    {
        private string  cod_identif;
        private string mt2;
        private string nit_prop;
       private List<string> gastos;

        public string Cod_identif
        {
            get
            {
                return cod_identif;
            }

            set
            {
                cod_identif = value;
            }
        }

        public string Mt2
        {
            get
            {
                return mt2;
            }

            set
            {
                mt2 = value;
            }
        }

        public string Nit_prop
        {
            get
            {
                return nit_prop;
            }

            set
            {
                nit_prop = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }

    }
}