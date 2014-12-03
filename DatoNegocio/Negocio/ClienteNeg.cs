using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //necesario para usar EntityKey 
using Datos;
using Negocio;
using BusinessEntities;

namespace Negocio
{
    public class ClienteNeg
    {
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }
       
        public ClienteNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Cliente
        public int AgregarCliente(string NOMBRE_CLIENTE, string RUT, int TELEFONO_CLIENTE, string MAIL, string DIRECCION_CLIENTE)
        {
            Clientes c = new Clientes();
            CLIENTES cc = new CLIENTES();
            c.Nombre_cliente = NOMBRE_CLIENTE;
            c.Rut = RUT;
            c.Telefono_cliente = TELEFONO_CLIENTE;
            c.Mail = MAIL;
            c.Direccion_cliente = DIRECCION_CLIENTE;

            cc.NOMBRE_CLIENTE = c.Nombre_cliente;
            cc.DIRECCION_CLIENTE = c.Direccion_cliente;
            cc.RUT = c.Rut;
            cc.MAIL = c.Mail;
            cc.TELEFONO_CLIENTE = c.Telefono_cliente;
            ModeloEntidades.AddToCLIENTES(cc);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Cliente By ID
        public int ModificarClienteByID(int id, String nombre, String rut, int telefono, String mail, string direccion)
        {
            int resultado = 0;
            Clientes c = new Clientes();
            CLIENTES clientes = new CLIENTES();
            c.Id_cliente = id;
            c.Nombre_cliente = nombre;
            c.Rut = rut;
            c.Telefono_cliente = telefono;
            c.Mail = mail;
            c.Direccion_cliente = direccion;
            clientes.ID_CLIENTE = c.Id_cliente;
            clientes.NOMBRE_CLIENTE = c.Nombre_cliente;
            clientes.RUT = c.Rut;
            clientes.TELEFONO_CLIENTE = c.Telefono_cliente;
            clientes.MAIL = c.Mail;
            clientes.DIRECCION_CLIENTE = c.Direccion_cliente;

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
        public List<Clientes> MostrarAllCliente()
        {
            var clientes = ModeloEntidades.CLIENTES;
            List<Clientes> lClie = new List<Clientes>();
            foreach (CLIENTES cc in clientes)
            {
                Clientes cli = new Clientes();
                cli.Id_cliente = cc.ID_CLIENTE;
                cli.Nombre_cliente = cc.NOMBRE_CLIENTE;
                cli.Direccion_cliente = cc.DIRECCION_CLIENTE;
                cli.Rut = cc.RUT;
                cli.Telefono_cliente = int.Parse(cc.TELEFONO_CLIENTE.ToString());
                cli.Mail = cc.MAIL;
                lClie.Add(cli);
            }
            return lClie;
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
