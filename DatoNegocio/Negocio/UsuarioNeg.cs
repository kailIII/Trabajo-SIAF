using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //necesario para usar EntityKey 
using Datos;
using BusinessEntities;


namespace Negocio
{
    public class UsuarioNeg
    {
        /*NOTAS:
         * - Es necesario iniciar un objeto de SIAFEntities con los atributos del
         * get and set que se generan en atravez del entity ADO, sino tendriamos
         * que realizar un partial en la clase.
         * - Todas las Clases del negiocio biene por defecto privadas, anteponer 
         * public adelante de class.
         * - Todas las hojas del tipo clase se llamaran como la entidad y finalizan
         * con Neg representativo de Negocio ej: UsuarioNeg.
         */
        #region constructorEntidades
        SIAFEntities ModeloEntidades { get; set; }
       
        public UsuarioNeg()
        {
            ModeloEntidades = new SIAFEntities();
        }
        #endregion

        #region Agregar Usuario
        public int AgregarUsuario(int ID_SUCURSAL, string PASSWORD, string PERFIL, string NOMBRE_USUARIO, string APELLIDO_USUARIO, string USUARIO1)
        {
            Usuario us = new Usuario();
            USUARIO uss = new USUARIO();
            us.Id_sucursal = ID_SUCURSAL;
            us.Password = PASSWORD;
            us.Perfil = PERFIL;
            us.Nombre_usuario = NOMBRE_USUARIO;
            us.Apellido_usuario = APELLIDO_USUARIO;
            us.Usuario1 = USUARIO1;

            uss.ID_SUCURSAL = us.Id_sucursal;
            uss.PASSWORD = us.Password;
            uss.PERFIL = us.Perfil;
            uss.NOMBRE_USUARIO = us.Nombre_usuario;
            uss.APELLIDO_USUARIO = us.Apellido_usuario;
            uss.USUARIO1 = us.Usuario1;
            ModeloEntidades.AddToUSUARIO(uss);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Usuario By ID
        public int ModificarUsuarioByID(int ID_USUARIO,int ID_SUCURSAL, String PASSWORD, String PERFIL, String NOMBRE_USUARIO, String APELLIDO_USUARIO, string USUARIO1)
        {
            int resultado = 0;
            USUARIO usuario = new USUARIO();
            Usuario us = new Usuario();

            us.Id_usuario = ID_USUARIO;
            us.Id_sucursal = ID_SUCURSAL;
            us.Password = PASSWORD;
            us.Perfil = PERFIL;
            us.Nombre_usuario = NOMBRE_USUARIO;
            us.Apellido_usuario = APELLIDO_USUARIO;
            us.Usuario1 = USUARIO1;

            usuario.ID_USUARIO = us.Id_usuario;
            usuario.ID_SUCURSAL = us.Id_sucursal;
            usuario.PASSWORD = us.Password;
            usuario.PERFIL = us.Perfil;
            usuario.USUARIO1 = us.Usuario1;
            usuario.NOMBRE_USUARIO = us.Nombre_usuario;
            usuario.APELLIDO_USUARIO = us.Apellido_usuario;



            EntityKey key = ModeloEntidades.CreateEntityKey("SIAFEntities.USUARIO", usuario);
            Object ActualizaUsuario; // se crea esta variable segun actualizacion, ahora es usuario, luego puede ser ActualizaProducto
            if (ModeloEntidades.TryGetObjectByKey(key, out ActualizaUsuario))
            {
                ModeloEntidades.ApplyCurrentValues(key.EntitySetName, usuario);
                resultado = ModeloEntidades.SaveChanges();
            }
            return resultado;
        }
        #endregion

        #region Mostrar All Usuario
        public List<Usuario> MostrarAllUsuario()
        {
            var usuarios = ModeloEntidades.USUARIO;
            List<Usuario> lus = new List<Usuario>();
            foreach (USUARIO us in usuarios)
            {
                Usuario uss = new Usuario();
                uss.Id_usuario = us.ID_USUARIO;
                uss.Id_sucursal = Convert.ToInt32(us.ID_SUCURSAL);
                uss.Nombre_usuario = us.NOMBRE_USUARIO;
                uss.Apellido_usuario = us.APELLIDO_USUARIO;
                uss.Password = us.PASSWORD;
                uss.Perfil = us.PERFIL;
                uss.Usuario1 = us.USUARIO1;
                lus.Add(uss);
            }
            return lus;
        }
        #endregion

        #region Mostrar Usuario By ID
        public USUARIO MostrarUsuarioByID(int id)
        {
            var usuarios = ModeloEntidades.USUARIO.Where(u => u.ID_USUARIO == id).FirstOrDefault();
            return usuarios;
        }
        #endregion

        #region Buscar Usuario by usuario and password
        public USUARIO buscaUsuario(string password, string usuario1)
        {
            var usuarios = ModeloEntidades.USUARIO.Where(u => u.PASSWORD == password && u.USUARIO1 == usuario1 ).FirstOrDefault();
            return usuarios;
        }
        #endregion
    }
}
