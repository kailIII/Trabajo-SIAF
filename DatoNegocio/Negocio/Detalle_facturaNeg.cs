using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class Detalle_facturaNeg
    {

        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public Detalle_facturaNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar detalle Factura
        public int AgregarDetalleFactura(DETALLE_FACTURA detalle_factura)
        {
            ModeloEntidades.AddToDETALLE_FACTURA(detalle_factura);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Detalle Factura By ID
        public int ModificarDetalleFacturaByID(int ID_DETALLE_FAC, int ID_OT, int ID_FACTURA)
        {
            int resultado = 0;
            DETALLE_FACTURA detalle_fac = new DETALLE_FACTURA();
            detalle_fac.ID_DETALLE_FAC = ID_DETALLE_FAC;
            detalle_fac.ID_OT = ID_OT;
            detalle_fac.ID_FACTURA = ID_FACTURA;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.DETALLE_FACTURA", detalle_fac);
            Object ActualizaDetalleFactura; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaDetalleFactura))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, detalle_fac);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Detalle Factura
        public List<DETALLE_FACTURA> MostrarAllDetalleFactura()
        {
            var detalle_factura = ModeloEntidades.DETALLE_FACTURA;
            return detalle_factura.ToList();
        }
        #endregion

        #region Mostrar Detalle Factura By ID
        public DETALLE_FACTURA MostrarDetalleFacturaByID(int ID_DETALLE_FAC)
        {
            var detalle_factura = ModeloEntidades.DETALLE_FACTURA.Where(df => df.ID_DETALLE_FAC == ID_DETALLE_FAC).FirstOrDefault();
            return detalle_factura;
        }
        #endregion
    }
}
