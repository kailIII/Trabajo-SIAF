using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Negocio
{
    class SucursalNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public SucursalNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Sucursal
        public int AgregarSucursal(SUCURSAL sucursal)
        {
            ModeloEntidades.AddToSUCURSAL(sucursal);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Sucursal By ID
        public int ModificarSucursalByID(int id, string direccion, int telefono)
        {
            int resultado = 0;
            SUCURSAL sucursal = new SUCURSAL();
            sucursal.ID_SUCURSAL = id;
            sucursal.DIRECCION_SUCURSAL = direccion;
            sucursal.TELEFONO_SUCURSAL = telefono;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.SUCURSAL", sucursal);
            Object ActualizaSucursal; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaSucursal))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, sucursal);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Sucursales
        public List<SUCURSAL> MostrarAllSucursal()
        {
            var sucursal = ModeloEntidades.SUCURSAL;
            return sucursal.ToList();
        }
        #endregion

        #region Mostrar Sucursal By ID
        public SUCURSAL MostrarSucursalByID(int id)
        {
            var sucursal = ModeloEntidades.SUCURSAL.Where(s => s.ID_SUCURSAL == id).FirstOrDefault();
            return sucursal;
        }
        #endregion
    }
}
