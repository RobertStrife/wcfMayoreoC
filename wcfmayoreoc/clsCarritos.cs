using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace wcfmayoreoc
{
    public class clsCarritos
    {
        public string AgregarCarrito(string cantidad, string total, string caducidad, string idCliente, string idProducto) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    carritos c = new carritos();
                    c.cantidad = int.Parse(cantidad);
                    c.total = decimal.Parse(total);
                    c.caducidad = Convert.ToDateTime(caducidad);
                    c.clientes_idcliente = int.Parse(idCliente);
                    c.productos_idproducto = int.Parse(idProducto);
                    c.fechaCreacion = DateTime.Now;
                    db.carritos.Add(c);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else {
                        return "Error al agregar carrito";
                    }

                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string ModificarCarrito(string idcarrito, string cantidad, string total, string caducidad, string idCliente, string idProducto) {

            using (var db = new mayoreocEntities()) {

                try
                {
                    var c = db.carritos.Find(int.Parse(idcarrito));
                    if (c != null)
                    {
                        c.cantidad = int.Parse(cantidad);
                        c.total = decimal.Parse(total);
                        c.caducidad = Convert.ToDateTime(caducidad);
                        c.clientes_idcliente = int.Parse(idCliente);
                        c.productos_idproducto = int.Parse(idProducto);
                        db.Entry(c).State = EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar carrito";
                        }

                    }
                    else {
                        return "Carrito no encontrado";    
                    }
                }
                catch (Exception ex) {
                   return ex.ToString();
                }
            }
        }


        public string EliminarCarrito(string idcarrito)
        {

            using (var db = new mayoreocEntities())
            {

                try
                {
                    var c = db.carritos.Find(int.Parse(idcarrito));
                    if (c != null)
                    {
                        db.carritos.Remove(c);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar carrito";
                        }

                    }
                    else
                    {
                        return "Carrito no encontrado";
                    }
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }


    }
}

