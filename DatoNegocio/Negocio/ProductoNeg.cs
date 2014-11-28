using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

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
        public int AgregarProducto(PRODUCTO producto)
        {
            ModeloEntidades.AddToPRODUCTO(producto);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Producto By ID
        public int ModificarProductoByID(string producto_cod, int id_tipo, string cod_bodega, string nombre, string cod_barra)
        {
            int resultado = 0;
            PRODUCTO producto = new PRODUCTO();
            producto.PRODUCTO_COD = producto_cod;
            producto.ID_TIPO = id_tipo;
            producto.COD_BODEGA = cod_bodega;
            producto.NOMBRE_PRODUCTO = nombre;
            producto.COD_BARRA = cod_barra;
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
        public List<PRODUCTO> MostrarAllProducto()
        {
            var producto = ModeloEntidades.PRODUCTO;
            return producto.ToList();
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
