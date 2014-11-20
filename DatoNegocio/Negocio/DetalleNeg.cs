using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    class DetalleNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public DetalleNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Detalle
        public int AgregarDetalle(DETALLE detalle)
        {
            ModeloEntidades.AddToDETALLE(detalle);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Detalle By ID
        public int ModificarDetalleByID(string producto_cod_detalle, string producto_cod, int cant_min, int cant_actual, int valor)
        {
            int resultado = 0;
            DETALLE detalle = new DETALLE();
            detalle.PRODUCTO_COD_DETALLE = producto_cod_detalle;
            detalle.PRODUCTO_COD = producto_cod;
            detalle.CANTIDAD_MINIMA = cant_min;
            detalle.CANTIDAD_ACTUAL = cant_actual;
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
        public List<DETALLE> MostrarAllDetalle()
        {
            var detalle = ModeloEntidades.DETALLE;
            return detalle.ToList();
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
