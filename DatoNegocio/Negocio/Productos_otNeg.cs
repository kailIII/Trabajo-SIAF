using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;
using Negocio;

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
        public int AgregarProductosOt(string PRODUCTO_COD, int ID_OT, int CANTIDAD, int VALOR_TOTAL)
        {
            Productos_ot prot = new Productos_ot();
            PRODUCTOS_OT prott = new PRODUCTOS_OT();
            OT ot = new OT();
            OTNeg otneg = new OTNeg();
            DETALLE detalle = new DETALLE();
            DetalleNeg detneg = new DetalleNeg();

            ot = otneg.MostrarOTByID(ID_OT);

            int NETO_ANTIGUO = int.Parse(ot.NETO_OT.ToString());
            int NETO_NUEVO = VALOR_TOTAL + NETO_ANTIGUO;
            int ID_SUCURSAL = int.Parse(ot.ID_SUCURSAL.ToString());
            int ID_CLIENTE = int.Parse(ot.ID_CLIENTE.ToString());
            DateTime FECHA_OT = DateTime.Parse(ot.FECHA_OT.ToString());
            string ESTADO = ot.ESTADO;

            otneg.ModificarOTByID(ID_OT, ID_SUCURSAL, ID_CLIENTE, NETO_NUEVO, FECHA_OT, ESTADO);
            detalle = detneg.MostrarDetalleByIDProducto(PRODUCTO_COD);
            int CANTIDAD_ANTIGUA = int.Parse(detalle.CANTIDAD_ACTUAL.ToString());
            int CANTIDAD_NUEVA = CANTIDAD_ANTIGUA - CANTIDAD;
            string PRODUCTO_COD_DETALLE = detalle.PRODUCTO_COD_DETALLE;
            int CANTIDAD_MINIMA = int.Parse(detalle.CANTIDAD_MINIMA.ToString());
            int VALOR = int.Parse(detalle.VALOR.ToString());

            detneg.ModificarDetalleByID(PRODUCTO_COD_DETALLE, PRODUCTO_COD, CANTIDAD_MINIMA, CANTIDAD_NUEVA, VALOR);

            prot.Producto_cod = PRODUCTO_COD;
            prot.Id_ot = ID_OT;
            prot.Cantidad = CANTIDAD;
            prot.Valor_total = VALOR_TOTAL;

            prott.PRODUCTO_COD = prot.Producto_cod;
            prott.ID_OT = prot.Id_ot;
            prott.CANTIDAD = prot.Cantidad;
            prott.VALOR_TOTAL = prot.Valor_total;

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
                pr.Id_ot = Convert.ToInt32(proot.ID_OT);
                pr.Cantidad = Convert.ToInt32(proot.CANTIDAD);
                pr.Valor_total = Convert.ToInt32(proot.VALOR_TOTAL);
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

        #region Mostrar ProductoOT By ID PRODUCTO
        public PRODUCTOS_OT MostrarProductoOTByIDProducto(string PRODUCTO_COD)
        {
            var productoOT = ModeloEntidades.PRODUCTOS_OT.Where(po => po.PRODUCTO_COD == PRODUCTO_COD).FirstOrDefault();
            return productoOT;
        }
        #endregion

        #region Mostrar ProductoOT By ID OT
        public List<spSeleccionarTodoByIdOt> MostrarProductoOTByIDOT(int ID_OT)
        {
            var lista = ModeloEntidades.spSeleccionarTodoByIdOt(ID_OT);
            return lista.ToList();
        }
        #endregion

        #region borrar producto ot por id producto ot
        public int BorrarProductoOT(int ID_PRODUCTO_OT)
        {
            PRODUCTOS_OT proot = new PRODUCTOS_OT();
            proot = MostrarProductoOTByID(ID_PRODUCTO_OT);
            int ID_OT = int.Parse(proot.ID_OT.ToString());
            string PRODUCTO_COD = proot.PRODUCTO_COD;
            int CANTIDAD = int.Parse(proot.CANTIDAD.ToString());
            int VALOR_TOTAL = int.Parse(proot.VALOR_TOTAL.ToString());
            DetalleNeg detalle = new DetalleNeg();
            DETALLE newDetalle = new DETALLE();
            newDetalle = detalle.MostrarDetalleByIDProducto(PRODUCTO_COD);
            int CANTIDAD_ACTUAL = int.Parse(newDetalle.CANTIDAD_ACTUAL.ToString());
            string PRODUCTO_COD_DETALLE = newDetalle.PRODUCTO_COD_DETALLE;
            int CANTIDAD_MINIMA = int.Parse(newDetalle.CANTIDAD_MINIMA.ToString());
            int VALOR = int.Parse(newDetalle.VALOR.ToString());
            int CANTIDAD_NUEVA = CANTIDAD_ACTUAL + CANTIDAD;
            OTNeg otneg = new OTNeg();
            OT newOT = new OT();
            newOT = otneg.MostrarOTByID(ID_OT);
            int NETO_OT = int.Parse(newOT.NETO_OT.ToString());
            int NETO_OT_NEW = NETO_OT - VALOR_TOTAL;
            int ID_SUCURSAL = int.Parse(newOT.ID_SUCURSAL.ToString());
            int ID_CLIENTE = int.Parse(newOT.ID_CLIENTE.ToString());
            DateTime FECHA_OT = DateTime.Parse(newOT.FECHA_OT.ToString());
            string ESTADO = newOT.ESTADO;

            detalle.ModificarDetalleByID(PRODUCTO_COD_DETALLE,PRODUCTO_COD,CANTIDAD_MINIMA,CANTIDAD_NUEVA,VALOR);

            otneg.ModificarOTByID(ID_OT,ID_SUCURSAL,ID_CLIENTE,NETO_OT_NEW,FECHA_OT,ESTADO);

            return ModeloEntidades.spBorrarProductoOT(ID_PRODUCTO_OT);
        }
        #endregion
    }
}
