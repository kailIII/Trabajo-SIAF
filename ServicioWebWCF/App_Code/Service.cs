using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos;
using Negocio;

[WebService(Namespace = "http://localhost/", Name="WCFTrans", Description="Trabajo practico taller y clase de Ingenieria de software modelo 3 capas con servidor web")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que este servicio Web se llame desde un script, mediante ASP.NET AJAX, quite el comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    #region USUARIOS

    #region Modificar Usuario por ID
    [WebMethod(Description = "Modifica usuarios obteniendo paramatros password, perfil, nombre, apellido")]
    public int ModificarUsuario(int id, string password, string perfil, string nombre, string apellido)
    {
        UsuarioNeg modificaUsuario = new UsuarioNeg();
        return modificaUsuario.ModificarUsuarioByID(id, password, perfil, nombre, apellido);
    }
    #endregion //fin modificar usuario

    #region Agregar Usuario
    [WebMethod(Description = "Agregar Usuario Recibiendo Parametros")]
    public int AgregarUsuario(string password, string perfil, string nombre, string apellido)
    {
        USUARIO usuario = new USUARIO();
        usuario.PASSWORD = password;
        usuario.PERFIL = perfil;
        usuario.NOMBRE_USUARIO = nombre;
        usuario.APELLIDO_USUARIO = apellido;

        UsuarioNeg cargaUsuario = new UsuarioNeg();
        return cargaUsuario.AgregarUsuario(usuario);
    }
    #endregion //fin agregar usuario

    #region Listar Todos los usuarios
    [WebMethod(Description = "Muestra todos los usuarios ingresados")]
    public List<USUARIO> MotrarAllUsuarios()
    {
        UsuarioNeg listaUsuarios = new UsuarioNeg();
        var usuarios = listaUsuarios.MostrarAllUsuario();
        return usuarios.ToList();
    }
    #endregion //fin listar todos los usuarios

    #region listar usuario por ID
    [WebMethod(Description = "Muestra usuario, recibe parametro ID")]
    public USUARIO MostrarUsuarioByID(int id)
    {
        UsuarioNeg listaUsuario = new UsuarioNeg();
        return listaUsuario.MostrarUsuarioByID(id);
    }
    #endregion //fin muestra usuario por id

    #endregion //fin region usuarios


}