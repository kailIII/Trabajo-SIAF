using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Factura
    {
        private int id_factura;

        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }
        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        private int num_fac;

        public int Num_fac
        {
            get { return num_fac; }
            set { num_fac = value; }
        }
        private int neto_fac;

        public int Neto_fac
        {
            get { return neto_fac; }
            set { neto_fac = value; }
        }
        private int iva_fac;

        public int Iva_fac
        {
            get { return iva_fac; }
            set { iva_fac = value; }
        }
        private int total_fac;

        public int Total_fac
        {
            get { return total_fac; }
            set { total_fac = value; }
        }
        private DateTime fecha_fac;

        public DateTime Fecha_fac
        {
            get { return fecha_fac; }
            set { fecha_fac = value; }
        }
    }
}
