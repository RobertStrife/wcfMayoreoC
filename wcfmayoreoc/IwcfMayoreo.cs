using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcfmayoreoc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwcfMayoreo" in both code and config file together.
    [ServiceContract]
    public interface IwcfMayoreo
    {

        #region Carritos
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCarrito/{cantidad}/{total}/{caducidad}/{idCliente}/{idProducto}")]
        string AgregarCarrito(string cantidad, string total, string caducidad, string idCliente, string idProducto);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCarrito/{idcarrito}/{cantidad}/{total}/{caducidad}/{idCliente}/{idProducto}")]
        string ModificarCarrito(string idcarrito, string cantidad, string total, string caducidad, string idCliente, string idProducto);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCarrito/{idcarrito}")]
        string EliminarCarrito(string idcarrito);


        #endregion

        #region Catalogos
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCatalogo/{nombreCatalogo}")]
        string AgregarCatalogo(string nombreCatalogo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCatalogo/{idcatalogo}/{nombreCatalogo}")]
        string ModificarCatalogo(string idcatalogo, string nombreCatalogo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCatalogo/{idcatalogo}")]
        string EliminarCatalogo(string idcatalogo);
        #endregion

        #region Categorias
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCategoria/{nombreCategoria}/{idcatalogo}")]
        string AgregarCategoria(string nombreCategoria, string idcatalogo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCategoria/{idcategoria}/{nombreCategoria}/{idcatalogo}")]
        string ModificarCategoria(string idcategoria, string nombreCategoria, string idcatalogo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCategoria/{idcategoria}")]
        string EliminarCategoria(string idcategoria);


        #endregion

        #region Clientes
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCliente/{nombre}/{apellidos}/{correo}/{telefono1}/{telefono2}/{password}/{calle}/{numExterior}/{numInterior}/{colonia}/{codigoPostal}/{municipio}/{estado}/{fechaAlta}")]
        string AgregarCliente(string nombre, string apellidos, string correo, string telefono1, string telefono2,
                            string password, string calle, string numExterior, string numInterior, string colonia,
                            string codigoPostal, string municipio, string estado, string fechaAlta);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCliente/{idCliente}/{nombre}/{apellidos}/{correo}/{telefono1}/{telefono2}/{password}/{calle}/{numExterior}/{numInterior}/{colonia}/{codigoPostal}/{municipio}/{estado}/{fechaAlta}")]
        string ModificarCliente(string idCliente, string nombre, string apellidos, string correo, string telefono1, string telefono2,
                                    string password, string calle, string numExterior, string numInterior, string colonia,
                                    string codigoPostal, string municipio, string estado, string fechaAlta);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCliente/{idCliente}")]
        string EliminarCliente(string idCliente);

        #endregion

        #region CorteCaja
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCorteCaja/{encargado}/{fondoInicial}/{ingresoTotal}/{efectivoCaja}")]
        string AgregarCorteCaja(string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCorteCaja/{idCorteCaja}/{encargado}/{fondoInicial}/{ingresoTotal}/{efectivoCaja}")]
        string ModificarCorteCaja(string idcorteCaja, string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCorteCaja/{idcorteCaja}")]
        string EliminarCorteCaja(string idcorteCaja);

        #endregion

        #region CuentasBancarias
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarCuentasBancarias/{numeroCuenta}/{sucursal}/{titular}/{clabe}/{banco}")]
        string AgregarCuentasBancarias(string numeroCuenta, string sucursal, string titular, string clabe, string banco);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarCuentaBancaria/{idCuentaBancaria}/{numeroCuenta}/{sucursal}/{titular}/{clabe}/{banco}")]
        string ModificarCuentaBancaria(string idCuentaBancaria, string numeroCuenta, string sucursal, string titular, string clabe, string banco);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarCuentaBancaria/{idCuentaBancaria}")]
        string EliminarCuentaBancaria(string idCuentaBancaria);

        #endregion

        #region Envio
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarEnvio/{paqueteria}/{costo}/{fechaEnvio}/{fechaLlegada}/{referenciaDomicilio}/{domicilioEntrega}/{telefono}/{numeroGuia}/{idordenCompra}")]
        string AgregarEnvio(string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                           string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarEnvio/{idenvio}/{paqueteria}/{costo}/{fechaEnvio}/{fechaLlegada}/{referenciaDomicilio}/{domicilioEntrega}/{telefono}/{numeroGuia}/{idordenCompra}")]
        string ModificarEnvio(string idenvio, string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                                    string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarEnvio/{idenvio}")]
        string EliminarEnvio(string idenvio);

        #endregion

        #region Metodos de Pago
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarMetodoPago/{metodo}")]
        string AgregarMetodoPago(string metodo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarMetodoPago/{idmetodo}/{metodo}")]
        string ModificarMetodoPago(string idmetodo, string metodo);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarMetodoPago/{idmetodo}")]
        string EliminarMetodoPago(string idmetodo);


        #endregion

        #region OrdenCompra
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarOrdenCompra/{domicilioentrega}/{cantidad}/{total}/{pesototal}/{pagado}/{paqueteria}/{idcliente}/{idproducto}/{idcuentabancaria}")]
        string AgregarOrdenCompra(string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarOrdenCompra/{idordencompra}/{domicilioEntrega}/{cantidad}/{total}/{pesototal}/{pagado}/{paqueteria}/{idcliente}/{idproducto}/{idcuentaBancaria}")]
        string ModificarOrdenCompra(string idordenCompra, string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarOrdenCompra/{idordenCompra}")]
        string EliminarOrdenCompra(string idordenCompra);


        #endregion

        #region Pagos
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarOrdenCompra/{concepto}/{monto}/{notas}/{idcliente}/{idordencompra}/{idcuentabancaria}/{idmetodoPago}")]
        string AgregarPago(string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarPago/{idpago}/{concepto}/{monto}/{notas}/{idcliente}/{idordencompra}/{idcuentabancaria}/{idmetodoPago}")]
        string ModificarPago(string idpago, string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago);

        #endregion

        #region Productos
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarProducto/{codigointerno}/{codigoproveedor}/{peso}/{descripcion}/{existencia}/{imagen1}/{imagen2}/{imagen3}/{imagen4}/{nuevo}/{precio}/{categoriaprecio}/{agotado}/{idcatalogo}/{idcategoria}/{idsubcategoria}")]
        string AgregarProducto(string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                              string imagen1, string imagen2, string imagen3, string imagen4,
                              string nuevo, string precio, string categoriaPrecio, string agotado,
                              string idcatalogo, string idcategoria, string idsubcategoria);


        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarProducto/{idproducto}/{codigointerno}/{codigoproveedor}/{peso}/{descripcion}/{existencia}/{imagen1}/{imagen2}/{imagen3}/{imagen4}/{nuevo}/{precio}/{categoriaprecio}/{agotado}/{idcatalogo}/{idcategoria}/{idsubcategoria}")]
        string ModificarProducto(string idproducto, string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                                      string imagen1, string imagen2, string imagen3, string imagen4,
                                      string nuevo, string precio, string categoriaPrecio, string agotado,
                                      string idcatalogo, string idcategoria, string idsubcategoria);

        [OperationContract]
        string EliminarProducto(string idproducto);


        #endregion

        #region Usuarios
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "Login/{username}/{password}")]
        retUsuario Login(string username, string password);
    
        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "AgregarUsuario/{usuario}/{password}")]
        string AgregarUsuario(string usuario, string password);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "ModificarUsuario/{idusuario}/{usuario}/{password}")]
        string ModificarUsuario(string idusuario, string usuario, string password);

        [OperationContract]
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "EliminarUsuario/{idusuario}")]
        string EliminarUsuario(string idusuario);

        #endregion

    }
}
