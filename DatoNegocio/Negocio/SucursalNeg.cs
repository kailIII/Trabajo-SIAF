using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;
using BusinessEntities;

namespace Negocio
{
    public class SucursalNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }

        public SucursalNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Sucursal
        public int AgregarSucursal()
        {
            Sucursal s = new Sucursal();
            SUCURSAL ss = new SUCURSAL();

            ss.DIRECCION_SUCURSAL = s.Direccion_sucursal;
            ss.TELEFONO_SUCURSAL = s.Telefono_sucursal;

            ModeloEntidades.AddToSUCURSAL(ss);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Sucursal By ID
        public int ModificarSucursalByID(int id, string direccion, int telefono)
        {
            int resultado = 0;
            SUCURSAL sucursal = new SUCURSAL();
            Sucursal s = new Sucursal();
            s.Id_sucursal = id;
            s.Direccion_sucursal = direccion;
            s.Telefono_sucursal = telefono;

            sucursal.ID_SUCURSAL = s.Id_sucursal;
            sucursal.DIRECCION_SUCURSAL = s.Direccion_sucursal;
            sucursal.TELEFONO_SUCURSAL = s.Telefono_sucursal;

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
        public List<Sucursal> MostrarAllSucursal()
        {
            var sucursal = ModeloEntidades.SUCURSAL;
            List<Sucursal> lsu = new List<Sucursal>();
            foreach (SUCURSAL ss in sucursal)
            {
                Sucursal s = new Sucursal();
                s.Id_sucursal = ss.ID_SUCURSAL;
                s.Direccion_sucursal = ss.DIRECCION_SUCURSAL;
                s.Telefono_sucursal = Convert.ToInt32(ss.TELEFONO_SUCURSAL);
                lsu.Add(s);
            }
            return lsu;
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
