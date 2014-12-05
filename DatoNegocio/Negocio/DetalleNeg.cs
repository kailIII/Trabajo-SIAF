using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

namespace Negocio
{
    public class DetalleNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public DetalleNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Detalle
        public int AgregarDetalle(string PRODUCTO_COD_DETALLE,string PRODUCTO_COD,int CANTIDAD_MINIMA,int CANTIDAD_ACTUAL,int VALOR)
        {
            Detalle d = new Detalle();
            DETALLE dd = new DETALLE();
            d.Producto_cod_detalle = PRODUCTO_COD_DETALLE;
            d.Producto_cod = PRODUCTO_COD;
            d.Cantidad_minima = CANTIDAD_MINIMA;
            d.Cantidad_actual = CANTIDAD_ACTUAL;
            d.Valor = VALOR;

            dd.PRODUCTO_COD_DETALLE = d.Producto_cod_detalle;
            dd.PRODUCTO_COD = d.Producto_cod;
            dd.CANTIDAD_MINIMA = d.Cantidad_actual;
            dd.CANTIDAD_ACTUAL = d.Cantidad_actual;
            dd.VALOR = d.Valor;

            ModeloEntidades.AddToDETALLE(dd);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Detalle By ID
        public int ModificarDetalleByID(string producto_cod_detalle, string producto_cod, int cant_min, int cant_actual, int valor)
        {
            int resultado = 0;
            DETALLE detalle = new DETALLE();
            Detalle d = new Detalle();
            d.Producto_cod_detalle = producto_cod_detalle;
            d.Producto_cod = producto_cod;
            d.Cantidad_minima = cant_min;
            d.Cantidad_actual = cant_actual;
            d.Valor = valor;
            detalle.PRODUCTO_COD_DETALLE = d.Producto_cod_detalle;
            detalle.PRODUCTO_COD = d.Producto_cod;
            detalle.CANTIDAD_MINIMA = d.Cantidad_minima;
            detalle.CANTIDAD_ACTUAL = d.Cantidad_actual;
            detalle.VALOR = valor;
            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.DETALLE", detalle);
            Object ActualizaDetalle; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaDetalle))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, detalle);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Detalle
        public List<Detalle> MostrarAllDetalle()
        {
            List<Detalle> lDetalle = new List<Detalle>();
            var detalle = ModeloEntidades.DETALLE;
            foreach (DETALLE de in detalle)
            {
                Detalle dd = new Detalle();
                dd.Producto_cod_detalle = de.PRODUCTO_COD_DETALLE;
                dd.Producto_cod = de.PRODUCTO_COD;
                dd.Cantidad_minima = Convert.ToInt32(de.CANTIDAD_MINIMA);
                dd.Cantidad_actual = Convert.ToInt32(de.CANTIDAD_ACTUAL);
                dd.Valor = Convert.ToInt32(de.VALOR);
                lDetalle.Add(dd);
            }
            return lDetalle;
        }
        #endregion

        #region Mostrar Detalle By ID
        public DETALLE MostrarDetalleByID(string pro_cod_detalle)
        {
            var detalle = ModeloEntidades.DETALLE.Where(d => d.PRODUCTO_COD_DETALLE == pro_cod_detalle).FirstOrDefault();
            return detalle;
        }
        #endregion
    }
}
