using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Producto
    {
        private string producto_cod;

        public string Producto_cod
        {
            get { return producto_cod; }
            set { producto_cod = value; }
        }
        private int id_tipo;

        public int Id_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
        }
        private string cod_bodega;

        public string Cod_bodega
        {
            get { return cod_bodega; }
            set { cod_bodega = value; }
        }
        private string nombre_producto;

        public string Nombre_producto
        {
            get { return nombre_producto; }
            set { nombre_producto = value; }
        }
        private string cod_barra;

        public string Cod_barra
        {
            get { return cod_barra; }
            set { cod_barra = value; }
        }
    }
}
