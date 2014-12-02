using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Sucursal
    {
        private int id_sucursal;

        public int Id_sucursal
        {
            get { return id_sucursal; }
            set { id_sucursal = value; }
        }
        private string direccion_sucursal;

        public string Direccion_sucursal
        {
            get { return direccion_sucursal; }
            set { direccion_sucursal = value; }
        }
        private int telefono_sucursal;

        public int Telefono_sucursal
        {
            get { return telefono_sucursal; }
            set { telefono_sucursal = value; }
        }
    }
}
