using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos;
using Negocio;
using BusinessEntities;

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
    public int AgregarUsuario(int ID_SUCURSAL, string PASSWORD, string PERFIL, string NOMBRE_USUARIO, string APELLIDO_USUARIO, string USUARIO1)
    {
        UsuarioNeg cargaUsuario = new UsuarioNeg();
        return cargaUsuario.AgregarUsuario(ID_SUCURSAL,PASSWORD,PERFIL,NOMBRE_USUARIO,APELLIDO_USUARIO,USUARIO1);
    }
    #endregion //fin agregar usuario

    #region Modificar Usuario por ID
    [WebMethod(Description = "Modifica Usuario por ID, con parametros de entrada")]
    public int ModificarUsuario(int ID_USUARIO,int ID_SUCURSAL, string PASSWORD, string PERFIL, string NOMBRE_USUARIO, string APELLIDO_USUARIO, string USUARIO1)
    {
        UsuarioNeg modificaUsuario = new UsuarioNeg();
        return modificaUsuario.ModificarUsuarioByID(ID_USUARIO, ID_SUCURSAL, PASSWORD, PERFIL, NOMBRE_USUARIO, APELLIDO_USUARIO, USUARIO1);
    }
    #endregion //fin modificar usuario

    #region Listar Todos los usuarios
    [WebMethod(Description = "Muestra todos los usuarios ingresados")]
    public List<Usuario> MotrarAllUsuarios()
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

    #region Buscar usuario password y usuario
    [WebMethod(Description = "buscar usuario por password y usuario")]
    public USUARIO BuscarUsuarioByPasswordAndUsuario(string password, string usuario1)
    {
        UsuarioNeg listaUsuario = new UsuarioNeg();
        return listaUsuario.buscaUsuario(password,usuario1);
    }
    #endregion //fin buscar usuario

    #endregion //fin region usuarios

    #region TIPO

    #region Agregar Tipo
    [WebMethod(Description = "Agregar Tipo")]
    public int AgregarTipo(string NOMBRE_TIPO)
    {
        TipoNeg tn = new TipoNeg();
        return tn.AgregarTipo(NOMBRE_TIPO);
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
    public List<Tipo> MotrarAllTipo()
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
    public int AgregarProducto(string PRODUCTO_COD, int ID_TIPO, string COD_BODEGA, string NOMBRE_PRODUCTO, string COD_BARRA)
    {
        ProductoNeg pneg = new ProductoNeg();
        return pneg.AgregarProducto(PRODUCTO_COD,ID_TIPO,COD_BODEGA,NOMBRE_PRODUCTO,COD_BARRA);
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
    public List<Producto> MotrarAllProducto()
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
        DetalleNeg dneg = new DetalleNeg();

        return dneg.AgregarDetalle(PRODUCTO_COD_DETALLE,PRODUCTO_COD,CANTIDAD_MINIMA,CANTIDAD_ACTUAL,VALOR);
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
    public List<Detalle> MotrarAllDetalle()
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

    #region PRODUCTOS OT

    #region Agregar PRODUCTOS OT
    [WebMethod(Description = "Agregar producto ot")]
    public int AgregarProductoOt(string PRODUCTO_COD, int ID_OT)
    {
        Productos_ot pot = new Productos_ot();
        pot.Producto_cod = PRODUCTO_COD;
        pot.Id_ot = ID_OT;
        Productos_otNeg potneg = new Productos_otNeg();

        return potneg.AgregarProductosOt();
    }
    #endregion //fin agregar productos ot

    #region Modificar producto ot por ID
    [WebMethod(Description = "Modifica producto ot por ID, con parametros de entrada")]
    public int ModificarProductoOTbyID(int ID_PRODUCTO_OT, string PRODUCTO_COD, int ID_OT)
    {
        Productos_otNeg potneg = new Productos_otNeg();
        return potneg.ModificarProductoOTByID(ID_PRODUCTO_OT,PRODUCTO_COD,ID_OT);
    }
    #endregion //fin modificar producto ot

    #region Listar Todos los productos ot
    [WebMethod(Description = "Muestra todos los productos ot ingresados")]
    public List<Productos_ot> MotrarAllProductosOt()
    {
        Productos_otNeg potneg = new Productos_otNeg();
        var lista = potneg.MostrarAllProductoOT() ;
        return lista.ToList();
    }
    #endregion //fin listar todos los productos ot

    #region listar productos ot por ID
    [WebMethod(Description = "Muestra productos ot, recibe parametro ID")]
    public PRODUCTOS_OT MostrarProductosOtByID(int ID_PRODUCTO_OT)
    {
        Productos_otNeg potneg = new Productos_otNeg();
        return potneg.MostrarProductoOTByID(ID_PRODUCTO_OT);
    }
    #endregion //fin muestra productos ot por id

    #endregion //fin region productos ot

    #region BODEGA

    #region Agregar BODEGA
    [WebMethod(Description = "Agregar BODEGA")]
    public int AgregarBodega(string COD_BODEGA, int ID_USUARIO)
    {
        BodegaNeg bneg = new BodegaNeg();
        return bneg.AgregarBodega(COD_BODEGA, ID_USUARIO);
    }
    #endregion //fin agregar bodega

    #region Modificar bodega por ID
    [WebMethod(Description = "Modifica bodega por ID, con parametros de entrada")]
    public int ModificarBodegabyID(string COD_BODEGA, int ID_USUARIO)
    {
        BodegaNeg bneg = new BodegaNeg();
        return bneg.ModificarBodegaByID(COD_BODEGA, ID_USUARIO);
    }
    #endregion //fin modificar bodega

    #region Listar Todos las bodegas
    [WebMethod(Description = "Muestra todos las bodegas ingresados")]
    public List<Bodega> MotrarAllBodega()
    {
        BodegaNeg bneg = new BodegaNeg();
        var lista = bneg.MostrarAllBodega();
        return lista.ToList();
    }
    #endregion //fin listar todos las bodegas

    #region listar bodega por ID
    [WebMethod(Description = "Muestra bodega, recibe parametro ID")]
    public BODEGA MostrarBodegaByID(string COD_BODEGA)
    {
        BodegaNeg bneg = new BodegaNeg();
        return bneg.MostrarBodegaByID(COD_BODEGA);
    }
    #endregion //fin muestra bodega por id

    #endregion //fin region bodega

    #region CLIENTE

    #region Agregar CLIENTE
    [WebMethod(Description = "Agregar cliente")]
    public int AgregarCliente(string NOMBRE_CLIENTE, string RUT, int TELEFONO_CLIENTE, string MAIL, string DIRECCION_CLIENTE)
    {
        ClienteNeg cneg = new ClienteNeg();

        return cneg.AgregarCliente(NOMBRE_CLIENTE,RUT,TELEFONO_CLIENTE,MAIL,DIRECCION_CLIENTE);
    }
    #endregion //fin agregar cliente

    #region Modificar Cliente por ID
    [WebMethod(Description = "Modifica cliente por ID, con parametros de entrada")]
    public int ModificarClientebyID(int ID_CLIENTE, string NOMBRE_CLIENTE, string RUT, int TELEFONO_CLIENTE, string MAIL, string DIRECCION_CLIENTE)
    {
        ClienteNeg cneg = new ClienteNeg();
        return cneg.ModificarClienteByID(ID_CLIENTE,NOMBRE_CLIENTE,RUT,TELEFONO_CLIENTE,MAIL,DIRECCION_CLIENTE);
    }
    #endregion //fin modificar cliente

    #region Listar Todos los clientes
    [WebMethod(Description = "Muestra todos los clientes ingresados")]
    public List<Clientes> MotrarAllCliente()
    {
        ClienteNeg cneg = new ClienteNeg();
        var lista = cneg.MostrarAllCliente();
        return lista.ToList();
    }
    #endregion //fin listar todos las cliente

    #region listar Cliente por ID
    [WebMethod(Description = "Muestra Cliente, recibe parametro ID")]
    public CLIENTES MostrarClienteByID(int id_cliente)
    {
        ClienteNeg cneg = new ClienteNeg();
        return cneg.MostrarClientesByID(id_cliente);
    }
    #endregion //fin muestra cliente por id

    #endregion //fin region cliente

    #region OT

    #region Agregar ot
    [WebMethod(Description = "Agregar ot")]
    public int AgregarOt(int ID_SUCURSAL, int ID_CLIENTE, int NETO_OT, DateTime FECHA_OT, string ESTADO)
    {
        OTNeg oneg = new OTNeg();

        return oneg.AgregarOT(ID_SUCURSAL,ID_CLIENTE,NETO_OT,FECHA_OT,ESTADO);
    }
    #endregion //fin agregar cliente

    #region Modificar ot por ID
    [WebMethod(Description = "Modifica cliente por ID, con parametros de entrada")]
    public int ModificarOtbyID(int ID_OT, int ID_SUCURSAL, int ID_CLIENTE, int NETO_OT, DateTime FECHA_OT, string ESTADO)
    {
        OTNeg oneg = new OTNeg();
        return oneg.ModificarOTByID(ID_OT,ID_SUCURSAL,ID_CLIENTE,NETO_OT,FECHA_OT,ESTADO);
    }
    #endregion //fin modificar cliente

    #region Listar Todas las ot
    [WebMethod(Description = "Muestra todas las ot ingresados")]
    public List<Ot> MotrarAllOt()
    {
        OTNeg oneg = new OTNeg();
        var lista = oneg.MostrarAllOT();
        return lista.ToList();
    }
    #endregion //fin listar todos las ot

    #region listar ot por ID
    [WebMethod(Description = "Muestra ot, recibe parametro ID")]
    public OT MostrarOTaByID(int ID_OT)
    {
        OTNeg oneg = new OTNeg();
        return oneg.MostrarOTByID(ID_OT);
    }
    #endregion //fin muestra ot por id

    #endregion //fin region ot

    #region FACTURA

    #region Agregar factura
    [WebMethod(Description = "Agregar factura")]
    public int AgregarFactura(int ID_CLIENTE, int NUM_FAC, int NETO_FAC, int IVA_FAC, int TOTAL_FAC,DateTime FECHA_FAC)
    {
        Factura f = new Factura();
        f.Id_cliente = ID_CLIENTE;
        f.Num_fac = NUM_FAC;
        f.Neto_fac = NETO_FAC;
        f.Iva_fac = IVA_FAC;
        f.Total_fac = TOTAL_FAC;
        f.Fecha_fac = FECHA_FAC;

        FacturaNeg fneg = new FacturaNeg();

        return fneg.AgregarFactura();
    }
    #endregion //fin agregar factura

    #region Modificar Factura por ID
    [WebMethod(Description = "Modifica factura por ID, con parametros de entrada")]
    public int ModificarFacturabyID(int ID_fACTURA,int ID_CLIENTE, int NUM_FAC, int NETO_FAC, int IVA_FAC, int TOTAL_FAC, DateTime FECHA_FAC)
    {
        FacturaNeg fneg = new FacturaNeg();
        return fneg.ModificarFacturaByID(ID_fACTURA, ID_CLIENTE, NUM_FAC, NETO_FAC, IVA_FAC, TOTAL_FAC,FECHA_FAC);
    }
    #endregion //fin modificar factura

    #region Listar Todas las facturas
    [WebMethod(Description = "Muestra todas las facturas ingresados")]
    public List<Factura> MotrarAllFacturas()
    {
        FacturaNeg fneg = new FacturaNeg();
        var lista = fneg.MostrarAllFactura();
        return lista.ToList();
    }
    #endregion //fin listar todos las factura

    #region listar Factura por ID
    [WebMethod(Description = "Muestra factura, recibe parametro ID")]
    public FACTURA MostrarFacturaByID(int ID_FACTURA)
    {
        FacturaNeg fneg = new FacturaNeg();
        return fneg.MostrarFacturaByID(ID_FACTURA);
    }
    #endregion //fin muestra factura por id

    #endregion //fin region factura

    #region DETALLE FACTURA

    #region Agregar detalle factura
    [WebMethod(Description = "Agregar detalle factura")]
    public int AgregarDetalleFactura(int ID_OT, int ID_FACTURA)
    {
        Detalle_factura df = new Detalle_factura();
        df.Id_ot = ID_OT;
        df.Id_factura = ID_FACTURA;

        Detalle_facturaNeg dfneg = new Detalle_facturaNeg();

        return dfneg.AgregarDetalleFactura();
    }
    #endregion //fin agregar detalle factura

    #region Modificar Detalle Factura por ID
    [WebMethod(Description = "Modifica detalle factura por ID, con parametros de entrada")]
    public int ModificarDetalleFacturabyID(int ID_DETALLE_FAC, int ID_OT, int ID_FACTURA)
    {
        Detalle_facturaNeg dfneg = new Detalle_facturaNeg();
        return dfneg.ModificarDetalleFacturaByID(ID_DETALLE_FAC,ID_OT,ID_FACTURA);
    }
    #endregion //fin modificar detalle factura

    #region Listar Todo detalle factura
    [WebMethod(Description = "Muestra todas los detalle factura ingresados")]
    public List<Detalle_factura> MotrarAllDetalleFactura()
    {
        Detalle_facturaNeg dfneg = new Detalle_facturaNeg();
        var lista = dfneg.MostrarAllDetalleFactura();
        return lista.ToList();
    }
    #endregion //fin listar todos las factura

    #region listar detalle Factura por ID
    [WebMethod(Description = "Muestra detalle factura, recibe parametro ID")]
    public DETALLE_FACTURA MostrarDetalleFacturaByID(int ID_DETALLE_FAC)
    {
        Detalle_facturaNeg dfneg = new Detalle_facturaNeg();
        return dfneg.MostrarDetalleFacturaByID(ID_DETALLE_FAC);
    }
    #endregion //fin muestra detalle factura por id

    #endregion //fin region detalle factura

    #region SUCURSAL

    #region Agregar sucursal
    [WebMethod(Description = "Agregar sucursal")]
    public int AgregarSucursal(string DIRECCION_SUCURSAL, int TELEFONO_SUCURSAL)
    {
        Sucursal s = new Sucursal();
        s.Direccion_sucursal = DIRECCION_SUCURSAL;
        s.Telefono_sucursal = TELEFONO_SUCURSAL;

        SucursalNeg sneg = new SucursalNeg();

        return sneg.AgregarSucursal();
    }
    #endregion //fin agregar sucursal

    #region Modificar sucursal por ID
    [WebMethod(Description = "Modifica sucursal por ID, con parametros de entrada")]
    public int ModificarSucursalbyID(int ID_SUCURSAL, string DIRECCION_SUCURSAL, int TELEFONO_SUCURSAL)
    {
        SucursalNeg sneg = new SucursalNeg();
        return sneg.ModificarSucursalByID(ID_SUCURSAL,DIRECCION_SUCURSAL,TELEFONO_SUCURSAL);
    }
    #endregion //fin modificar sucursal

    #region Listar Todo sucursal
    [WebMethod(Description = "Muestra todas los sucursal ingresados")]
    public List<Sucursal> MotrarAllSucursal()
    {
        SucursalNeg sneg = new SucursalNeg();
        var lista = sneg.MostrarAllSucursal();
        return lista.ToList();
    }
    #endregion //fin listar todo sucursal

    #region listar sucursal por ID
    [WebMethod(Description = "Muestra sucursal, recibe parametro ID")]
    public SUCURSAL MostrarSucursalByID(int ID_SUCURSAL)
    {
        SucursalNeg sneg = new SucursalNeg();
        return sneg.MostrarSucursalByID(ID_SUCURSAL);
    }
    #endregion //fin muestra sucursal por id

    #endregion //fin region detalle factura
}