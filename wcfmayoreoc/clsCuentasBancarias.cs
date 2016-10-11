using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsCuentasBancarias
    {
        public string AgregarCuentasBancarias(string numeroCuenta, string sucursal, string titular, string clabe, string banco) {
            using (var db = new mayoreocEntities()) {
                cuentasbancarias cu = new cuentasbancarias();
                cu.numeroCuenta = int.Parse(numeroCuenta);
                cu.sucursal = sucursal;
                cu.titular = titular;
                cu.clabe = int.Parse(clabe);
                cu.banco = banco;
                try
                {
                    db.cuentasbancarias.Add(cu);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al agregar corte de caja";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string ModificarCuentaBancaria(string idCuentaBancaria,string numeroCuenta, string sucursal, string titular, string clabe, string banco) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    cuentasbancarias cu = db.cuentasbancarias.Find(int.Parse(idCuentaBancaria));
                    if (cu != null)
                    {
                        cu.numeroCuenta = int.Parse(numeroCuenta);
                        cu.sucursal = sucursal;
                        cu.titular = titular;
                        cu.clabe = int.Parse(clabe);
                        cu.banco = banco;
                        db.Entry(cu).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar corte de caja";
                        }

                    }
                    else {
                       return "Corte de caja no encontrado";
                    }

                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string EliminarCuentaBancaria(string idCuentaBancaria) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    cuentasbancarias cu = db.cuentasbancarias.Find(int.Parse(idCuentaBancaria));
                    if (cu != null)
                    {
                        db.cuentasbancarias.Remove(cu);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar corte de caja";
                        }
                    }
                    else
                    {
                        return "Cuenta Bancaria no encontrada";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

    }
}