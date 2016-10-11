using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsCorteCaja
    {
        public string AgregarCorteCaja(string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja) {
            using (var db = new mayoreocEntities()) {
                cortecaja c = new cortecaja();
                c.fecha = DateTime.Now;
                c.encargado = encargado;
                c.fondoInicial = decimal.Parse(fondoInicial);
                c.ingresoTotal = decimal.Parse(ingresoTotal);
                c.efectivoCaja = decimal.Parse(efectivoCaja);
                try
                {
                    db.cortecaja.Add(c);
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

        public string ModificarCorteCaja(string idcorteCaja, string encargado, string fondoInicial, string ingresoTotal, string efectivoCaja) {
            using (var db = new mayoreocEntities()) {
                cortecaja c = db.cortecaja.Find(idcorteCaja);
                try
                {
                    if (c != null) {
                        c.encargado = encargado;
                        c.fondoInicial = decimal.Parse(fondoInicial);
                        c.ingresoTotal = decimal.Parse(ingresoTotal);
                        c.efectivoCaja = decimal.Parse(efectivoCaja);
                        db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar corte de caja";
                        }

                    }
                    else{
                        return "Corte de caja no encontrado";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }


        public string EliminarCorteCaja(string idcorteCaja) {
            using (var db = new mayoreocEntities())
            {
                cortecaja c = db.cortecaja.Find(idcorteCaja);
                try
                {
                    if (c != null)
                    {
                        db.cortecaja.Remove(c);
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
                        return "Corte de caja no encontrado";
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