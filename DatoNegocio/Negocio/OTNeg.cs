using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    public class OTNeg
    {

        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public OTNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar OT
        public int AgregarOT(PRODUCTOS_OT producto_ot)
        {
            ModeloEntidades.AddToPRODUCTOS_OT(producto_ot);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar OT By ID
        public int ModificarOTByID(int ID_OT, int ID_SUCURSAL, int ID_CLIENTE,int NETO_OT, DateTime FECHA_OT, string ESTADO)
        {
            int resultado = 0;
            OT ot = new OT();
            ot.ID_OT = ID_OT;
            ot.ID_SUCURSAL = ID_SUCURSAL;
            ot.ID_CLIENTE = ID_CLIENTE;
            ot.NETO_OT = NETO_OT;
            ot.FECHA_OT = FECHA_OT;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.OT", ot);
            Object ActualizaOT; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaOT))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, ot);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All OT
        public List<OT> MostrarAllOT()
        {
            var ot = ModeloEntidades.OT;
            return ot.ToList();
        }
        #endregion

        #region Mostrar OT By ID
        public OT MostrarOTByID(int ID_OT)
        {
            var OT = ModeloEntidades.OT.Where(o => o.ID_OT == ID_OT).FirstOrDefault();
            return OT;
        }
        #endregion
    }
}
