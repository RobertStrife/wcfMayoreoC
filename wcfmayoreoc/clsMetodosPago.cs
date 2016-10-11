using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsMetodosPago
    {
        public string AgregarMetodoPago(string metodo) {
            using (var db = new mayoreocEntities()) {
                metodospago m = new metodospago();
                try
                {
                    m.metodo = metodo;
                    db.metodospago.Add(m);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al agregar metodo de pago";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string ModificarMetodoPago(string idmetodo, string metodo) {
            try
            {
                using (var db = new mayoreocEntities())
                {
                    metodospago m = db.metodospago.Find(idmetodo);
                    if (m != null)
                    {
                        m.metodo = metodo;
                        db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar metodo de pago";
                        }
                    }
                    else
                    {
                        return "metodo de pago no encontrado";
                    }
                }
            }
            catch (Exception ex) {
                return ex.ToString();
            }
        }

        public string EliminarMetodoPago(string idmetodo) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    metodospago m = db.metodospago.Find(idmetodo);
                    if (m != null)
                    {
                        db.metodospago.Remove(m);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar metodo de pago";
                        }
                    }
                    else {
                        return "Metodo de pago no encontrado";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

    }
}