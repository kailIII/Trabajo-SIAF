using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    class TipoNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public TipoNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Tipo
        public int AgregarTipo(TIPO tipo)
        {
            ModeloEntidades.AddToTIPO(tipo);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Tipo By ID
        public int ModificarTipoByID(int id, string nombre)
        {
            int resultado = 0;
            TIPO tipo = new TIPO();
            tipo.ID_TIPO = id;
            tipo.NOMBRE_TIPO = nombre;
            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.TIPO", tipo);
            Object ActualizaTipo; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaTipo))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, tipo);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Tipo
        public List<TIPO> MostrarAllTipo()
        {
            var tipo = ModeloEntidades.TIPO;
            return tipo.ToList();
        }
        #endregion

        #region Mostrar Tipo By ID
        public TIPO MostrarTipoByID(int id)
        {
            var tipo = ModeloEntidades.TIPO.Where(t => t.ID_TIPO == id).FirstOrDefault();
            return tipo;
        }
        #endregion
    }
}
