using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

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
        public int AgregarDetalleFactura()
        {
            Detalle_factura df = new Detalle_factura();
            DETALLE_FACTURA dff = new DETALLE_FACTURA();
            dff.ID_OT = df.Id_ot;
            dff.ID_FACTURA = df.Id_factura;
            ModeloEntidades.AddToDETALLE_FACTURA(dff);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Detalle Factura By ID
        public int ModificarDetalleFacturaByID(int ID_DETALLE_FAC, int ID_OT, int ID_FACTURA)
        {
            int resultado = 0;
            DETALLE_FACTURA detalle_fac = new DETALLE_FACTURA();
            Detalle_factura df = new Detalle_factura();
            df.Id_detalle_fac = ID_DETALLE_FAC;
            df.Id_ot = ID_OT;
            df.Id_factura = ID_FACTURA;
            detalle_fac.ID_DETALLE_FAC = df.Id_detalle_fac;
            detalle_fac.ID_OT = df.Id_ot;
            detalle_fac.ID_FACTURA = df.Id_factura;

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
        public List<Detalle_factura> MostrarAllDetalleFactura()
        {

            var detalle_factura = ModeloEntidades.DETALLE_FACTURA;
            List<Detalle_factura> listdf = new List<Detalle_factura>();
            foreach (DETALLE_FACTURA df in detalle_factura)
            {
                Detalle_factura dff = new Detalle_factura();
                dff.Id_detalle_fac = df.ID_DETALLE_FAC;
                dff.Id_ot = int.Parse(df.ID_OT.ToString());
                dff.Id_factura = df.ID_FACTURA;
                listdf.Add(dff);
            }
            return listdf;
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
