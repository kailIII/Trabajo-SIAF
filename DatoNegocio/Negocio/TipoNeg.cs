using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

namespace Negocio
{
    public class TipoNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public TipoNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Tipo
        public int AgregarTipo(string nombre_t)
        {
            Tipo t = new Tipo();
            TIPO tt = new TIPO();
            t.Nombre_tipo = nombre_t;
            tt.NOMBRE_TIPO = t.Nombre_tipo;
            ModeloEntidades.AddToTIPO(tt);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Tipo By ID
        public int ModificarTipoByID(int id, string nombre)
        {
            int resultado = 0;
            TIPO tipo = new TIPO();
            Tipo t = new Tipo();

            t.Id_tipo = id;
            t.Nombre_tipo = nombre;

            tipo.ID_TIPO = t.Id_tipo;
            tipo.NOMBRE_TIPO = t.Nombre_tipo;
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
        public List<Tipo> MostrarAllTipo()
        {
            var tipo = ModeloEntidades.TIPO;
            List<Tipo> lt = new List<Tipo>();
            foreach (TIPO tt in tipo)
            { 
                Tipo t = new Tipo();
                t.Id_tipo = tt.ID_TIPO;
                t.Nombre_tipo = tt.NOMBRE_TIPO;
                lt.Add(t);
            }
            return lt;
        }
        #endregion

        #region Mostrar Tipo By ID
        public TIPO MostrarTipoByID(int id)
        {
            var tipo = ModeloEntidades.TIPO.Where(t => t.ID_TIPO == id).FirstOrDefault();
            return tipo;
        }
        #endregion

        #region informe tipo por id tipo
        public List<spInformeTipo> spInformeTipo(int ID_TIPO)
        {
            var list = ModeloEntidades.spInformeTipo(ID_TIPO);
            return list.ToList();
        }
        #endregion
    }
}
