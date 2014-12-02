using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

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
        public int AgregarFactura()
        {
            FACTURA f = new FACTURA();
            Factura ff = new Factura();
            f.ID_CLIENTE = ff.Id_cliente;
            f.NUM_FAC = ff.Num_fac;
            f.NETO_FAC = ff.Neto_fac;
            f.IVA_FAC = ff.Iva_fac;
            f.TOTAL_FAC = ff.Total_fac;
            f.FECHA_FAC = ff.Fecha_fac;
            ModeloEntidades.AddToFACTURA(f);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Factura By ID
        public int ModificarFacturaByID(int ID_FACTURA, int ID_CLIENTE, int NUM_FAC, int NETO_FAC, int IVA_FAC, int TOTAL_FAC, DateTime FECHA_FAC)
        {
            int resultado = 0;
            Factura ff = new Factura();
            FACTURA factura = new FACTURA();
            ff.Id_factura = ID_FACTURA;
            ff.Id_cliente = ID_CLIENTE;
            ff.Num_fac = NUM_FAC;
            ff.Neto_fac = NETO_FAC;
            ff.Iva_fac = IVA_FAC;
            ff.Total_fac = TOTAL_FAC;
            ff.Fecha_fac = FECHA_FAC;

            factura.ID_FACTURA = ff.Id_factura;
            factura.ID_CLIENTE = ff.Id_cliente;
            factura.NUM_FAC = ff.Num_fac;
            factura.NETO_FAC = ff.Neto_fac;
            factura.IVA_FAC = ff.Iva_fac;
            factura.TOTAL_FAC = ff.Total_fac;
            factura.FECHA_FAC = ff.Fecha_fac;

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
        public List<Factura> MostrarAllFactura()
        {
            var factura = ModeloEntidades.FACTURA;
            List<Factura> lfac = new List<Factura>();
            foreach (FACTURA ff in factura)
            {
                Factura f = new Factura();
                f.Id_factura = ff.ID_FACTURA;
                f.Id_cliente = ff.ID_CLIENTE;
                f.Num_fac = Convert.ToInt32(ff.NUM_FAC);
                f.Neto_fac = Convert.ToInt32(ff.NETO_FAC);
                f.Iva_fac = Convert.ToInt32(ff.IVA_FAC);
                f.Total_fac = Convert.ToInt32(ff.TOTAL_FAC);
                f.Fecha_fac = Convert.ToDateTime( ff.FECHA_FAC);
                lfac.Add(f);
            }
            return lfac;
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
