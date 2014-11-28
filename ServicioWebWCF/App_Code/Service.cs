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

    #region Agregar Usuario
    [WebMethod(Description = "Agregar Usuario")]
    public int AgregarUsuario(int id_sucursal, string password, string perfil, string nombre, string apellido, string usuario1)
    {
        USUARIO usuario = new USUARIO();
        usuario.ID_SUCURSAL = id_sucursal;
        usuario.PASSWORD = password;
        usuario.PERFIL = perfil;
        usuario.NOMBRE_USUARIO = nombre;
        usuario.APELLIDO_USUARIO = apellido;
        usuario.USUARIO1 = usuario1;

        UsuarioNeg cargaUsuario = new UsuarioNeg();
        return cargaUsuario.AgregarUsuario(usuario);
    }
    #endregion //fin agregar usuario

    #region Modificar Usuario por ID
    [WebMethod(Description = "Modifica Usuario por ID, con parametros de entrada")]
    public int ModificarUsuario(int id,int id_sucursal, string password, string perfil, string nombre, string apellido, string usuario1)
    {
        UsuarioNeg modificaUsuario = new UsuarioNeg();
        return modificaUsuario.ModificarUsuarioByID(id, id_sucursal, password, perfil, nombre, apellido, usuario1);
    }
    #endregion //fin modificar usuario

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

    #region TIPO

    #region Agregar Tipo
    [WebMethod(Description = "Agregar Tipo")]
    public int AgregarTipo(string NOMBRE_TIPO)
    {
        TIPO tipo = new TIPO();
        tipo.NOMBRE_TIPO=NOMBRE_TIPO;
        TipoNeg tneg = new TipoNeg();
        return tneg.AgregarTipo(tipo);
    }
    #endregion //fin agregar tipo

    #region Modificar Tipo por ID
    [WebMethod(Description = "Modifica Tipo por ID, con parametros de entrada")]
    public int ModificarTipo(int ID_TIPO, string NOMBRE_TIPO)
    {
        TipoNeg tneg = new TipoNeg();
        return tneg.ModificarTipoByID(ID_TIPO,NOMBRE_TIPO);
    }
    #endregion //fin modificar tipo

    #region Listar Todos los tipos
    [WebMethod(Description = "Muestra todos los tipos ingresados")]
    public List<TIPO> MotrarAllTipo()
    {
        TipoNeg listatipo = new TipoNeg();
        var lista = listatipo.MostrarAllTipo();
        return lista.ToList();
    }
    #endregion //fin listar todos los tipo

    #region listar tipo por ID
    [WebMethod(Description = "Muestra tipo, recibe parametro ID")]
    public TIPO MostrarTipoByID(int ID_TIPO)
    {
        TipoNeg tneg = new TipoNeg();
        return tneg.MostrarTipoByID(ID_TIPO);
    }
    #endregion //fin muestra tipo por id

    #endregion //fin region tipo

    #region PRODUCTO

    #region Agregar Producto
    [WebMethod(Description = "Agregar Producto")]
    public int AgregarProducto(int ID_TIPO, string COD_BODEGA, string NOMBRE_PRODUCTO, string COD_BARRA)
    {
        PRODUCTO pro = new PRODUCTO();
        pro.ID_TIPO = ID_TIPO;
        pro.COD_BODEGA = COD_BODEGA;
        pro.NOMBRE_PRODUCTO = NOMBRE_PRODUCTO;
        pro.COD_BARRA = COD_BARRA;
        ProductoNeg pneg = new ProductoNeg();
        return pneg.AgregarProducto(pro);
    }
    #endregion //fin agregar producto

    #region Modificar Producto por ID
    [WebMethod(Description = "Modifica Producto por ID, con parametros de entrada")]
    public int ModificarProducto(string PRODUCTO_COD, int ID_TIPO, string COD_BODEGA, string NOMBRE_PRODUCTO, string COD_BARRA)
    {
        ProductoNeg pneg = new ProductoNeg();
        return pneg.ModificarProductoByID(PRODUCTO_COD,ID_TIPO,COD_BODEGA,NOMBRE_PRODUCTO,COD_BARRA);
    }
    #endregion //fin modificar producto

    #region Listar Todos los productos
    [WebMethod(Description = "Muestra todos los productos ingresados")]
    public List<PRODUCTO> MotrarAllProducto()
    {
        ProductoNeg pneg = new ProductoNeg();
        var lista = pneg.MostrarAllProducto();
        return lista.ToList();
    }
    #endregion //fin listar todos los producto

    #region listar producto por ID
    [WebMethod(Description = "Muestra producto, recibe parametro ID")]
    public PRODUCTO MostrarProductoByID(string PRODUCTO_COD)
    {
        ProductoNeg pneg = new ProductoNeg();
        return pneg.MostrarProductoByID(PRODUCTO_COD);
    }
    #endregion //fin muestra producto por id

    #endregion //fin region producto

    #region DETALLE

    #region Agregar DETALLE
    [WebMethod(Description = "Agregar Detalle")]
    public int AgregarDetalle(string PRODUCTO_COD_DETALLE, string PRODUCTO_COD, int CANTIDAD_MINIMA, int CANTIDAD_ACTUAL, int VALOR)
    {
        DETALLE detalle = new DETALLE();
        detalle.PRODUCTO_COD_DETALLE = PRODUCTO_COD_DETALLE;
        detalle.PRODUCTO_COD = PRODUCTO_COD;
        detalle.CANTIDAD_MINIMA = CANTIDAD_MINIMA;
        detalle.CANTIDAD_ACTUAL = CANTIDAD_ACTUAL;
        detalle.VALOR = VALOR;
        DetalleNeg dneg = new DetalleNeg();

        return dneg.AgregarDetalle(detalle);
    }
    #endregion //fin agregar detalle

    #region Modificar Detalle por ID
    [WebMethod(Description = "Modifica detalle por ID, con parametros de entrada")]
    public int ModificarDetalle(string PRODUCTO_COD_DETALLE, string PRODUCTO_COD, int CANTIDAD_MINIMA, int CANTIDAD_ACTUAL, int VALOR)
    {
        DetalleNeg dneg = new DetalleNeg();
        return dneg.ModificarDetalleByID(PRODUCTO_COD_DETALLE,PRODUCTO_COD, CANTIDAD_MINIMA,CANTIDAD_ACTUAL,VALOR);
    }
    #endregion //fin modificar DETALLE

    #region Listar Todos los DETALLES
    [WebMethod(Description = "Muestra todos los detalles ingresados")]
    public List<DETALLE> MotrarAllDetalle()
    {
        DetalleNeg dneg = new DetalleNeg();
        var lista = dneg.MostrarAllDetalle();
        return lista.ToList();
    }
    #endregion //fin listar todos los producto

    #region listar detalle por ID
    [WebMethod(Description = "Muestra detalle, recibe parametro ID")]
    public DETALLE MostrarDetalleByID(string PRODUCTO_COD_DETALLE)
    {
        DetalleNeg dneg = new DetalleNeg();
        return dneg.MostrarDetalleByID(PRODUCTO_COD_DETALLE);
    }
    #endregion //fin muestra detalle por id

    #endregion //fin region detalle


}