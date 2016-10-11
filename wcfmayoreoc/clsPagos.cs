using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsPagos
    {
        public string AgregarPago(string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago) {
            using (var db = new mayoreocEntities()) {
                pagos p = new pagos();
                p.concepto = concepto;
                p.monto =  decimal.Parse(monto);
                p.notas = notas;
                p.clientes_idcliente = int.Parse(idcliente);
                p.ordencompra_idordenCompra = int.Parse(idordenCompra);
                p.cuentasbancarias_idcuentaBancaria = int.Parse(idcuentaBancaria);
                p.metodospago_idmetodoPago = int.Parse(idmetodoPago);

                try {
                    db.pagos.Add(p);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al agregar pago";
                    }

                } catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string ModificarPago(string idpago, string concepto, string monto, string notas, string idcliente, string idordenCompra, string idcuentaBancaria, string idmetodoPago) {
            using (var db = new mayoreocEntities()) {

                try {

                    pagos p = db.pagos.Find(int.Parse(idpago));
                    if (p != null)
                    {
                        p.concepto = concepto;
                        p.monto = decimal.Parse(monto);
                        p.notas = notas;
                        p.clientes_idcliente = int.Parse(idcliente);
                        p.ordencompra_idordenCompra = int.Parse(idordenCompra);
                        p.cuentasbancarias_idcuentaBancaria = int.Parse(idcuentaBancaria);
                        p.metodospago_idmetodoPago = int.Parse(idmetodoPago);
                        db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al agregar pago";
                        }
                    }
                    else
                    {
                        return "pago no encontrado";
                    }


                } catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

    }
}