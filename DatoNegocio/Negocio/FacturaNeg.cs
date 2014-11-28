using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class FacturaNeg
    {

        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public FacturaNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Factura
        public int AgregarFactura(FACTURA facutra)
        {
            ModeloEntidades.AddToFACTURA(facutra);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Factura By ID
        public int ModificarFacturaByID(int ID_FACTURA, int ID_CLIENTE, int NUM_FAC, int NETO_FAC, int IVA_FAC, int TOTAL_FAC, DateTime FECHA_FAC)
        {
            int resultado = 0;
            FACTURA factura = new FACTURA();
            factura.ID_FACTURA = ID_FACTURA;
            factura.ID_CLIENTE = ID_CLIENTE;
            factura.NUM_FAC = NUM_FAC;
            factura.NETO_FAC = NETO_FAC;
            factura.IVA_FAC = IVA_FAC;
            factura.TOTAL_FAC = TOTAL_FAC;
            factura.FECHA_FAC = FECHA_FAC;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.OT", factura);
            Object ActualizaFactura; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaFactura))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, factura);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Factura
        public List<FACTURA> MostrarAllFactura()
        {
            var factura = ModeloEntidades.FACTURA;
            return factura.ToList();
        }
        #endregion

        #region Mostrar Factura By ID
        public FACTURA MostrarFacturaByID(int ID_FACTURA)
        {
            var factura = ModeloEntidades.FACTURA.Where(f => f.ID_FACTURA == ID_FACTURA).FirstOrDefault();
            return factura;
        }
        #endregion
    }
}
