using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

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
        public int AgregarProductosOt()
        {
            Productos_ot prot = new Productos_ot();
            PRODUCTOS_OT prott = new PRODUCTOS_OT();

            prott.ID_PRODUCTO_OT = prot.Id_producto_ot;
            prott.PRODUCTO_COD = prot.Producto_cod;
            prott.ID_OT = prot.Id_ot;

            ModeloEntidades.AddToPRODUCTOS_OT(prott);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Producto By ID
        public int ModificarProductoOTByID(int ID_PRODUCTO_OT,string PRODUCTO_COD, int ID_OT)
        {
            int resultado = 0;
            PRODUCTOS_OT proOT = new PRODUCTOS_OT();
            Productos_ot pr = new Productos_ot();
            pr.Id_producto_ot = ID_PRODUCTO_OT;
            pr.Producto_cod = PRODUCTO_COD;
            pr.Id_ot = ID_OT;
            proOT.ID_PRODUCTO_OT = pr.Id_producto_ot;
            proOT.PRODUCTO_COD = pr.Producto_cod;
            proOT.ID_OT = pr.Id_ot;

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
        public List<Productos_ot> MostrarAllProductoOT()
        {
            var productoOt = ModeloEntidades.PRODUCTOS_OT;
            List<Productos_ot> lproot = new List<Productos_ot>();
            foreach (PRODUCTOS_OT proot in productoOt)
            {
                Productos_ot pr = new Productos_ot();
                pr.Id_ot = Convert.ToInt32( proot.ID_OT);
                pr.Id_producto_ot = proot.ID_PRODUCTO_OT;
                pr.Producto_cod = proot.PRODUCTO_COD;
                lproot.Add(pr);
            }


            return lproot;
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
