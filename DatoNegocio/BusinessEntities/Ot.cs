using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Ot
    {
        private int id_ot;

        public int Id_ot
        {
            get { return id_ot; }
            set { id_ot = value; }
        }
        private int id_sucursal;

        public int Id_sucursal
        {
            get { return id_sucursal; }
            set { id_sucursal = value; }
        }
        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        private int neto_ot;

        public int Neto_ot
        {
            get { return neto_ot; }
            set { neto_ot = value; }
        }
        private DateTime fecha_ot;

        public DateTime Fecha_ot
        {
            get { return fecha_ot; }
            set { fecha_ot = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
