using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //necesario para usar EntityKey 
using Datos;
using Negocio;

namespace Negocio
{
    class ClienteNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }
       
        public ClienteNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Cliente
        public int AgregarUsuario(CLIENTES cliente)
        {
            ModeloEntidades.AddToCLIENTES(cliente);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Cliente By ID
        public int ModificarClienteByID(int id, String nombre, String rut, int telefono, String mail, string direccion)
        {
            int resultado = 0;
            CLIENTES clientes = new CLIENTES();
            clientes.NOMBRE_CLIENTE = nombre;
            clientes.RUT = rut;
            clientes.TELEFONO_CLIENTE = telefono;
            clientes.MAIL = mail;
            clientes.DIRECCION_CLIENTE = direccion;

            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.CLIENTES", clientes);
            Object ActualizaCliente; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaCliente))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, clientes);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Cliente
        public List<CLIENTES> MostrarAllCliente()
        {
            var clientes = ModeloEntidades.CLIENTES;
            return clientes.ToList();
        }
        #endregion

        #region Mostrar Clientes By ID
        public CLIENTES MostrarClientesByID(int id)
        {
            var clientes = ModeloEntidades.CLIENTES.Where(i => i.ID_CLIENTE == id).FirstOrDefault();
            return clientes;
        }
        #endregion
    }
}
