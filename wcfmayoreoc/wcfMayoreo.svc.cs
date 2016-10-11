using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfmayoreoc
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcfMayoreo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcfMayoreo.svc or wcfMayoreo.svc.cs at the Solution Explorer and start debugging.
    public class wcfMayoreo : IwcfMayoreo
    {
        #region Carritos
        public string AgregarCarrito(string cantidad, string total, string caducidad, string idCliente, string idProducto) {
            clsCarritos c = new clsCarritos();
            return c.AgregarCarrito(cantidad, total, caducidad, idCliente, idProducto);
        }

        public string ModificarCarrito(string idcarrito, string cantidad, string total, string caducidad, string idCliente, string idProducto) {
            clsCarritos c = new clsCarritos();
            return c.ModificarCarrito(idcarrito, cantidad, total, caducidad, idCliente, idProducto);
        }

        public string EliminarCarrito(string idcarrito) {
            clsCarritos c = new clsCarritos();
            return c.EliminarCarrito(idcarrito);
        }

        #endregion

        #region Catalogos
        public string AgregarCatalogo(string nombreCatalogo) {
            clsCatalogos c = new clsCatalogos();
            return c.AgregarCatalogo(nombreCatalogo);
        }
        public string ModificarCatalogo(string idcatalogo, string nombreCatalogo) {
            clsCatalogos c = new clsCatalogos();
            return c.ModificarCatalogo(idcatalogo, nombreCatalogo);
        }
        public string EliminarCatalogo(string idcatalogo) {
            clsCatalogos c = new clsCatalogos();
            return c.EliminarCatalogo(idcatalogo);
        }
        #endregion

        #region Categorias
        public string AgregarCategoria(string nombreCategoria, string idcatalogo) {
            clsCategorias c = new clsCategorias();
            return c.AgregarCategoria(nombreCategoria, idcatalogo);
        }

        public string ModificarCategoria(string idcategoria, string nombreCategoria, string idcatalogo) {
            clsCategorias c = new clsCategorias();
            return c.ModificarCategoria(idcategoria, nombreCategoria, idcatalogo);
        }

        public string EliminarCategoria(string idcategoria) {
            clsCategorias c = new clsCategorias();
            return c.EliminarCategoria(idcategoria);
        }

        #endregion

        #region Clientes
        public string AgregarCliente(string nombre, string apellidos, string correo, string telefono1, string telefono2,
                             string password, string calle, string numExterior, string numInterior, string colonia,
                             string codigoPostal, string municipio, string estado, string fechaAlta)
        {
            clsClientes c = new clsClientes();
            return c.AgregarCliente(nombre, apellidos, correo, telefono1, telefono2, password, calle, numExterior, numInterior, colonia, codigoPostal, municipio, estado, fechaAlta);
        }

        public string ModificarCliente(string idCliente, string nombre, string apellidos, string correo, string telefono1, string telefono2,
                                     string password, string calle, string numExterior, string numInterior, string colonia,
                                     string codigoPostal, string municipio, string estado, string fechaAlta)
        {
            clsClientes c = new clsClientes();
            return c.ModificarCliente(idCliente, nombre, apellidos, correo, telefono1, telefono2,
                                      password, calle, numExterior, numInterior, colonia,
                                      codigoPostal, municipio, estado, fechaAlta);
        }



        public string EliminarCliente(string idCliente) {
            clsClientes c = new clsClientes();
            return c.EliminarCliente(idCliente);
        }

        #endregion

        #region CorteCaja
        public string AgregarCorteCaja(string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja)
        {
            clsCorteCaja c = new clsCorteCaja();
            return c.AgregarCorteCaja(encargado, fondoInicial, ingresoTotal, efectivoCaja);
        }

        public string ModificarCorteCaja(string idcorteCaja, string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja)
        {
            clsCorteCaja c = new clsCorteCaja();
            return c.ModificarCorteCaja(idcorteCaja, encargado, fondoInicial, ingresoTotal, efectivoCaja);
        }


        public string EliminarCorteCaja(string idcorteCaja) {
            clsCorteCaja c = new clsCorteCaja();
            return c.EliminarCorteCaja(idcorteCaja);
        }

        #endregion

        #region CuentasBancarias
        public string AgregarCuentasBancarias(string numeroCuenta, string sucursal, string titular, string clabe, string banco)
        {
            clsCuentasBancarias c = new clsCuentasBancarias();
            return c.AgregarCuentasBancarias(numeroCuenta, sucursal, titular, clabe, banco);
        }
        public string ModificarCuentaBancaria(string idCuentaBancaria, string numeroCuenta, string sucursal, string titular, string clabe, string banco)
        {
            clsCuentasBancarias c = new clsCuentasBancarias();
            return c.ModificarCuentaBancaria(idCuentaBancaria, numeroCuenta, sucursal, titular, clabe, banco);
        }

        public string EliminarCuentaBancaria(string idCuentaBancaria) {
            clsCuentasBancarias c = new clsCuentasBancarias();
            return c.EliminarCuentaBancaria(idCuentaBancaria);
        }

        #endregion

        #region
        public string AgregarEnvio(string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                            string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra)
        {
            clsEnvios e = new clsEnvios();
            return e.AgregarEnvio(paqueteria, costo, fechaEnvio, fechaLlegada, referenciaDomicilio, domicilioEntrega, telefono, numeroGuia, idordenCompra);
        }


        public string ModificarEnvio(string idenvio, string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                                    string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra)
        {
            clsEnvios e = new clsEnvios();
            return e.ModificarEnvio(idenvio, paqueteria, costo, fechaEnvio, fechaLlegada, referenciaDomicilio, domicilioEntrega, telefono, numeroGuia, idordenCompra);

        }

        public string EliminarEnvio(string idenvio) {
            clsEnvios e = new clsEnvios();
            return e.EliminarEnvio(idenvio);
        }
        #endregion

        #region Metodos de Pago
        public string AgregarMetodoPago(string metodo)
        {
            clsMetodosPago m = new clsMetodosPago();
            return m.AgregarMetodoPago(metodo);
        }

        public string ModificarMetodoPago(string idmetodo, string metodo)
        {
            clsMetodosPago m = new clsMetodosPago();
            return m.ModificarMetodoPago(idmetodo, metodo);
        }

        public string EliminarMetodoPago(string idmetodo) {
            clsMetodosPago m = new clsMetodosPago();
            return m.EliminarMetodoPago(idmetodo);
        }

        #endregion

        #region OrdenCompra
        public string AgregarOrdenCompra(string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria)
        {
            clsOrdenCompra o = new clsOrdenCompra();
            return o.AgregarOrdenCompra(domicilioEntrega, cantidad, total, pesototal, pagado, paqueteria, idcliente, idproducto, idcuentaBancaria);
        }

        public string ModificarOrdenCompra(string idordenCompra, string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria)
        {
            clsOrdenCompra o = new clsOrdenCompra();
            return o.ModificarOrdenCompra(idordenCompra, domicilioEntrega, cantidad, total, pesototal, pagado, paqueteria, idcliente, idproducto, idcuentaBancaria);
        }


        public string EliminarOrdenCompra(string idordenCompra)
        {
            clsOrdenCompra o = new clsOrdenCompra();
            return o.EliminarOrdenCompra(idordenCompra);
        }

        #endregion

        #region Pagos
        public string AgregarPago(string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago)
        {
            clsPagos p = new clsPagos();
            return p.AgregarPago(concepto, monto, notas, idcliente, idordenCompra, idcuentaBancaria, idmetodoPago);
        }

        public string ModificarPago(string idpago, string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago) {
            clsPagos p = new clsPagos();
            return p.ModificarPago(idpago, concepto, monto, notas, idcliente, idordenCompra, idcuentaBancaria, idmetodoPago);
        }
        #endregion

        #region Productos
        public string AgregarProducto(string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                              string imagen1, string imagen2, string imagen3, string imagen4,
                              string nuevo, string precio, string categoriaPrecio, string agotado,
                              string idcatalogo, string idcategoria, string idsubcategoria)
        {
            clsProductos p = new clsProductos();
            return p.AgregarProducto(codigoInterno, codigoProveedor, peso, descripcion, existencia, imagen1, imagen2, imagen3, imagen4, nuevo, precio, 
                                    categoriaPrecio, agotado, idcatalogo, idcategoria, idsubcategoria);

        }

        public string ModificarProducto(string idproducto, string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                                      string imagen1, string imagen2, string imagen3, string imagen4,
                                      string nuevo, string precio, string categoriaPrecio, string agotado,
                                      string idcatalogo, string idcategoria, string idsubcategoria)
        {
            clsProductos p = new clsProductos();
            return p.ModificarProducto(idproducto, codigoInterno, codigoProveedor, peso, descripcion, existencia, imagen1, imagen2, imagen3, imagen4, nuevo, 
                                       precio, categoriaPrecio, agotado, idcatalogo, idcategoria, idsubcategoria);
        }

        public string EliminarProducto(string idproducto) {
            clsProductos p = new clsProductos();
            return p.EliminarProducto(idproducto);
        }

        #endregion

        #region Usuarios

        public retUsuario Login(string username, string password) {
            clsUsuarios u = new clsUsuarios();
            return u.Login(username, password);
        }

        public string AgregarUsuario(string usuario, string password)
        {
            clsUsuarios u = new clsUsuarios();
            return u.AgregarUsuario(usuario, password);
        }

        public string ModificarUsuario(string idusuario, string usuario, string password)
        {
            clsUsuarios u = new clsUsuarios();
            return u.ModificarUsuario(idusuario, usuario, password);
        }

        public string EliminarUsuario(string idusuario) {
            clsUsuarios u = new clsUsuarios();
            return u.EliminarUsuario(idusuario);
        }


        #endregion
    }
}
