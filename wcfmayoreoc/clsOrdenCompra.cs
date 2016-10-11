using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsOrdenCompra
    {
        public string AgregarOrdenCompra(string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria) {
            using (var db = new mayoreocEntities()) {
                ordencompra o = new ordencompra();
                o.domicilioEntrega = domicilioEntrega;
                o.fecha = DateTime.Now;
                o.cantidad = cantidad;
                o.total = total;
                o.pesototal = pesototal;
                o.pagado = pagado;
                o.paqueteria = paqueteria;
                o.clientes_idcliente = int.Parse(idcliente);
                o.productos_idproducto = int.Parse(idproducto);
                o.cuentasbancarias_idcuentaBancaria = int.Parse(idcuentaBancaria);
                
                try {
                    db.ordencompra.Add(o);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al agregar orden de compra";
                    }
                }
                catch(Exception ex)
                {
                    return ex.ToString();
                }

            }
        }

        public string ModificarOrdenCompra(string idordenCompra, string domicilioEntrega, string cantidad, string total, string pesototal, string pagado, string paqueteria, string idcliente, string idproducto, string idcuentaBancaria) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    ordencompra o = db.ordencompra.Find(idordenCompra);
                    if (o != null)
                    {
                        o.domicilioEntrega = domicilioEntrega;
                        o.fecha = DateTime.Now;
                        o.cantidad = cantidad;
                        o.total = total;
                        o.pesototal = pesototal;
                        o.pagado = pagado;
                        o.paqueteria = paqueteria;
                        o.clientes_idcliente = int.Parse(idcliente);
                        o.productos_idproducto = int.Parse(idproducto);
                        o.cuentasbancarias_idcuentaBancaria = int.Parse(idcuentaBancaria);
                        db.Entry(o).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar Orden de compra";
                        }
                    }
                    else {
                        return "Orden de compra no encontrada";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }


        public string EliminarOrdenCompra(string idordenCompra) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    ordencompra o = db.ordencompra.Find(idordenCompra);
                    if (o != null)
                    {
                        db.ordencompra.Remove(o);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar Orden de compra";
                        }
                    }
                    else {
                        return "orden de compra no encontrada";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

    }
}