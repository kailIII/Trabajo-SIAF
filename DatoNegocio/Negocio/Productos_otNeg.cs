using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class Productos_otNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public Productos_otNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Producto a la ot
        public int AgregarProductosOt(PRODUCTOS_OT producto_ot)
        {
            ModeloEntidades.AddToPRODUCTOS_OT(producto_ot);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Producto By ID
        public int ModificarProductoOTByID(int ID_PRODUCTO_OT,string PRODUCTO_COD, int ID_OT)
        {
            int resultado = 0;
            PRODUCTOS_OT proOT = new PRODUCTOS_OT();
            proOT.ID_PRODUCTO_OT = ID_PRODUCTO_OT;
            proOT.PRODUCTO_COD = PRODUCTO_COD;
            proOT.ID_OT = ID_OT;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.PRODUCTO_OT", proOT);
            Object ActualizaProductoOt; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaProductoOt))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, proOT);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Productos OT
        public List<PRODUCTOS_OT> MostrarAllProductoOT()
        {
            var productoOt = ModeloEntidades.PRODUCTOS_OT;
            return productoOt.ToList();
        }
        #endregion

        #region Mostrar ProductoOT By ID
        public PRODUCTOS_OT MostrarProductoOTByID(int ID_PRODUCTO_OT)
        {
            var productoOT = ModeloEntidades.PRODUCTOS_OT.Where(po => po.ID_PRODUCTO_OT == ID_PRODUCTO_OT).FirstOrDefault();
            return productoOT;
        }
        #endregion
    }
}
