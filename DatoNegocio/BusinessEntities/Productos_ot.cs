using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Productos_ot
    {
        private int id_producto_ot;

        public int Id_producto_ot
        {
            get { return id_producto_ot; }
            set { id_producto_ot = value; }
        }
        private string producto_cod;

        public string Producto_cod
        {
            get { return producto_cod; }
            set { producto_cod = value; }
        }
        private int id_ot;

        public int Id_ot
        {
            get { return id_ot; }
            set { id_ot = value; }
        }
    }
}
