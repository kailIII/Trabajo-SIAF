using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class Usuario
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        private int id_sucursal;

        public int Id_sucursal
        {
            get { return id_sucursal; }
            set { id_sucursal = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string perfil;

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }
        private string apellido_usuario;

        public string Apellido_usuario
        {
            get { return apellido_usuario; }
            set { apellido_usuario = value; }
        }
        private string usuario1;

        public string Usuario1
        {
            get { return usuario1; }
            set { usuario1 = value; }
        }
    }
}
