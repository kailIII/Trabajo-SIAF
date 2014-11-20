using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    class BodegaNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public BodegaNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Bodega
        public int AgregarBodega(BODEGA bodega)
        {
            ModeloEntidades.AddToBODEGA(bodega);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Bodega By ID
        public int ModificarBodegaByID(string cod_bodega, int id_usuario)
        {
            int resultado = 0;
            BODEGA bodega = new BODEGA();
            bodega.COD_BODEGA = cod_bodega;
            bodega.ID_USUARIO = id_usuario;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.BODEGA", bodega);
            Object ActualizaBodega; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaBodega))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, bodega);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Bodega
        public List<BODEGA> MostrarAllBodega()
        {
            var bodega = ModeloEntidades.BODEGA;
            return bodega.ToList();
        }
        #endregion

        #region Mostrar Bodega By ID
        public BODEGA MostrarBodegaByID(string cod_bodega)
        {
            var bodega = ModeloEntidades.BODEGA.Where(b => b.COD_BODEGA == cod_bodega).FirstOrDefault();
            return bodega;
        }
        #endregion
    }
}
