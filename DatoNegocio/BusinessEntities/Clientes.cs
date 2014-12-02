using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Clientes
    {
        private int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        private string nombre_cliente;

        public string Nombre_cliente
        {
            get { return nombre_cliente; }
            set { nombre_cliente = value; }
        }
        private string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private int telefono_cliente;

        public int Telefono_cliente
        {
            get { return telefono_cliente; }
            set { telefono_cliente = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        private string direccion_cliente;

        public string Direccion_cliente
        {
            get { return direccion_cliente; }
            set { direccion_cliente = value; }
        }

    }
}
