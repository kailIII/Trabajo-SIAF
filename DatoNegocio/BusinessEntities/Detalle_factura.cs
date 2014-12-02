using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Detalle_factura
    {
        private int id_detalle_fac;

        public int Id_detalle_fac
        {
            get { return id_detalle_fac; }
            set { id_detalle_fac = value; }
        }
        private int id_ot;

        public int Id_ot
        {
            get { return id_ot; }
            set { id_ot = value; }
        }
        private int id_factura;

        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }
    }
}
