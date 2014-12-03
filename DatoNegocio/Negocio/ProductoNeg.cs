using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

namespace Negocio
{
    public class ProductoNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public ProductoNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Producto
        public int AgregarProducto(string PRODUCTO_COD, int ID_TIPO, string COD_BODEGA, string NOMBRE_PRODUCTO, string COD_BARRA)
        {
            Producto p = new Producto();
            PRODUCTO pp = new PRODUCTO();
            p.Producto_cod = PRODUCTO_COD;
            p.Id_tipo = ID_TIPO;
            p.Cod_bodega = COD_BODEGA;
            p.Nombre_producto = NOMBRE_PRODUCTO;
            p.Cod_barra = COD_BARRA;

            pp.PRODUCTO_COD = p.Producto_cod;
            pp.ID_TIPO = p.Id_tipo;
            pp.COD_BODEGA = p.Cod_bodega;
            pp.NOMBRE_PRODUCTO = p.Nombre_producto;
            pp.COD_BARRA = p.Cod_barra;

            ModeloEntidades.AddToPRODUCTO(pp);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Producto By ID
        public int ModificarProductoByID(string producto_cod, int id_tipo, string cod_bodega, string nombre, string cod_barra)
        {
            int resultado = 0;
            PRODUCTO producto = new PRODUCTO();
            Producto p = new Producto();
            p.Producto_cod = producto_cod;
            p.Id_tipo = id_tipo;
            p.Cod_bodega = cod_bodega;
            p.Nombre_producto = nombre;
            p.Cod_barra = cod_barra;

            producto.PRODUCTO_COD = p.Producto_cod;
            producto.ID_TIPO = p.Id_tipo;
            producto.COD_BODEGA = p.Cod_bodega;
            producto.NOMBRE_PRODUCTO = p.Nombre_producto;
            producto.COD_BARRA = p.Cod_barra;
            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.PRODUCTO", producto);
            Object ActualizaProducto; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaProducto))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, producto);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Producto
        public List<Producto> MostrarAllProducto()
        {
            var producto = ModeloEntidades.PRODUCTO;
            List<Producto> lpro = new List<Producto>();
            foreach (PRODUCTO p in producto)
            {
                Producto pp = new Producto();
                pp.Producto_cod = p.PRODUCTO_COD;
                pp.Id_tipo = p.ID_TIPO;
                pp.Cod_bodega = p.COD_BODEGA;
                pp.Nombre_producto = p.NOMBRE_PRODUCTO;
                pp.Cod_barra = p.COD_BARRA;
                lpro.Add(pp);
            }
            return lpro;
        }
        #endregion

        #region Mostrar Producto By ID
        public PRODUCTO MostrarProductoByID(string producto_cod)
        {
            var producto = ModeloEntidades.PRODUCTO.Where(p => p.PRODUCTO_COD == producto_cod).FirstOrDefault();
            return producto;
        }
        #endregion
    }
}
