using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidad1
{
    public class gastos
    {
        private string id_gasto;
        private string nombre_gasto;
        private string tipo_reparto;

        public string Id_gasto
        {
            get
            {
                return id_gasto;
            }

            set
            {
                id_gasto = value;
            }
        }

        public string Nombre_gasto
        {
            get
            {
                return nombre_gasto;
            }

            set
            {
                nombre_gasto = value;
            }
        }

        public string Tipo_reparto
        {
            get
            {
                return tipo_reparto;
            }

            set
            {
                tipo_reparto = value;
            }
        }


    }
}