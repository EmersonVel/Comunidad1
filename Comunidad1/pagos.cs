using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class pagos
    {
        private string id_pago;
        private string descripcion;
        private string importe;
        private char tip_rep;

        public string Id_pago
        {
            get
            {
                return id_pago;
            }

            set
            {
                id_pago = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public char Tip_rep
        {
            get
            {
                return tip_rep;
            }

            set
            {
                tip_rep = value;
            }
        }
    }
}