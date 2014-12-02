using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Detalle
    {
        private string producto_cod_detalle;

        public string Producto_cod_detalle
        {
            get { return producto_cod_detalle; }
            set { producto_cod_detalle = value; }
        }
        private string producto_cod;

        public string Producto_cod
        {
            get { return producto_cod; }
            set { producto_cod = value; }
        }
        private int cantidad_minima;

        public int Cantidad_minima
        {
            get { return cantidad_minima; }
            set { cantidad_minima = value; }
        }
        private int cantidad_actual;

        public int Cantidad_actual
        {
            get { return cantidad_actual; }
            set { cantidad_actual = value; }
        }
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
