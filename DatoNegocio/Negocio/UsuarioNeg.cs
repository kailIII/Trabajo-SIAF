using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //necesario para usar EntityKey 
using Datos;

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
        public int AgregarUsuario(USUARIO usuario)
        {
            ModeloEntidades.AddToUSUARIO(usuario);
            return ModeloEntidades.SaveChanges();
        }
        #endregion

        #region Modificar Usuario By ID
        public int ModificarUsuarioByID(int id,int id_sucursal, String password, String perfil, String nombre, String apellido)
        {
            int resultado = 0;
            USUARIO usuario = new USUARIO();
            usuario.ID_USUARIO = id;
            usuario.ID_SUCURSAL = id_sucursal;
            usuario.PASSWORD = password;
            usuario.PERFIL = perfil;
            usuario.NOMBRE_USUARIO = nombre;
            usuario.APELLIDO_USUARIO = apellido;
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
        public List<USUARIO> MostrarAllUsuario()
        {
            var usuarios = ModeloEntidades.USUARIO;
            return usuarios.ToList();
        }
        #endregion

        #region Mostrar Usuario By ID
        public USUARIO MostrarUsuarioByID(int id)
        {
            var usuarios = ModeloEntidades.USUARIO.Where(u => u.ID_USUARIO == id).FirstOrDefault();
            return usuarios;
        }
        #endregion
    }
}
