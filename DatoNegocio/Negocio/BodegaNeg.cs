using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

namespace Negocio
{
    public class BodegaNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public BodegaNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Bodega
        public int AgregarBodega(string COD_BODEGA, int ID_USUARIO)
        {
            Bodega b = new Bodega();
            BODEGA bb = new BODEGA();
            b.Cod_bodega = COD_BODEGA;
            b.Id_usuario = ID_USUARIO;
            bb.COD_BODEGA = b.Cod_bodega;
            bb.ID_USUARIO = b.Id_usuario;
            ModeloEntidades.AddToBODEGA(bb);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Bodega By ID
        public int ModificarBodegaByID(string cod_bodega, int id_usuario)
        {
            int resultado = 0;
            BODEGA bodega = new BODEGA();
            Bodega b = new Bodega();
            b.Cod_bodega = cod_bodega;
            b.Id_usuario = id_usuario;
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
        public List<Bodega> MostrarAllBodega()
        {
            var bodega = ModeloEntidades.BODEGA;
            List<Bodega> b = new List<Bodega>();
            foreach (BODEGA bb in bodega)
            {
                Bodega bode = new Bodega();
                bode.Cod_bodega = bb.COD_BODEGA;
                bode.Id_usuario = int.Parse(bb.ID_USUARIO.ToString());                
                b.Add(bode);
            }
            return b;
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
