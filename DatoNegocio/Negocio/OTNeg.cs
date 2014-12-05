using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

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
        public int AgregarOT(int ID_SUCURSAL, int ID_CLIENTE, int NETO_OT, DateTime FECHA_OT, string ESTADO)
        {
            Ot o = new Ot();
            OT oo = new OT();
            o.Id_sucursal = ID_SUCURSAL;
            o.Id_cliente = ID_CLIENTE;
            o.Neto_ot = NETO_OT;
            o.Fecha_ot = FECHA_OT;
            o.Estado = ESTADO;

            oo.ID_SUCURSAL = o.Id_sucursal;
            oo.ID_CLIENTE = o.Id_cliente;
            oo.NETO_OT = o.Neto_ot;
            oo.FECHA_OT = o.Fecha_ot;
            oo.ESTADO = o.Estado;

            ModeloEntidades.AddToOT(oo);
            ModeloEntidades.SaveChanges();
            int res = oo.ID_OT;

            return res;
        }
        #endregion

        #region Modificar OT By ID
        public int ModificarOTByID(int ID_OT, int ID_SUCURSAL, int ID_CLIENTE,int NETO_OT, DateTime FECHA_OT, string ESTADO)
        {
            int resultado = 0;
            Ot o = new Ot();
            OT ot = new OT();
            o.Id_ot = ID_OT;
            o.Id_sucursal = ID_SUCURSAL;
            o.Id_cliente = ID_CLIENTE;
            o.Neto_ot = NETO_OT;
            o.Fecha_ot = FECHA_OT;
            o.Estado = ESTADO;

            ot.ID_OT = o.Id_ot;
            ot.ID_SUCURSAL = o.Id_sucursal;
            ot.ID_CLIENTE = o.Id_cliente;
            ot.NETO_OT = o.Neto_ot;
            ot.FECHA_OT = o.Fecha_ot;
            ot.ESTADO = o.Estado;

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
        public List<Ot> MostrarAllOT()
        {
            List<Ot> lot = new List<Ot>();
            var ot = ModeloEntidades.OT;
            foreach (OT o in ot)
            {
                Ot oo = new Ot();
                oo.Id_ot = o.ID_OT;
                oo.Id_sucursal = o.ID_SUCURSAL;
                oo.Id_cliente = o.ID_CLIENTE;
                oo.Neto_ot = Convert.ToInt32(o.NETO_OT);
                oo.Fecha_ot = Convert.ToDateTime(o.FECHA_OT);
                oo.Estado = o.ESTADO;
                lot.Add(oo);
            }
            return lot;
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
