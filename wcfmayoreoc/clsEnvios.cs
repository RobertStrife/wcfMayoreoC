using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsEnvios
    {
        public string AgregarEnvio(string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                                    string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra)
        {
            using (var db = new mayoreocEntities()) {
                envios e = new envios();
                e.paqueteria = paqueteria;
                e.costo = decimal.Parse(costo);
                e.fechaEnvio = Convert.ToDateTime(fechaEnvio);
                e.fechaLlegada = Convert.ToDateTime(fechaLlegada);
                e.referenciaDomicilio = referenciaDomicilio;
                e.domicilioEntrega = domicilioEntrega;
                e.telefono = telefono;
                e.numeroGuia = numeroGuia;
                e.ordenCompra_idordenCompra = int.Parse(idordenCompra);
                try
                {
                    db.envios.Add(e);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al abregar envio";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }

            }
        }


        public string ModificarEnvio(string idenvio,string paqueteria, string costo, string fechaEnvio, string fechaLlegada, string referenciaDomicilio,
                                    string domicilioEntrega, string telefono, string numeroGuia, string idordenCompra)
        {
            try
            {
                using (var db = new mayoreocEntities())
                {
                    envios e = db.envios.Find(int.Parse(idenvio));
                    if (e != null)
                    {
                        e.paqueteria = paqueteria;
                        e.costo = decimal.Parse(costo);
                        e.fechaEnvio = Convert.ToDateTime(fechaEnvio);
                        e.fechaLlegada = Convert.ToDateTime(fechaLlegada);
                        e.referenciaDomicilio = referenciaDomicilio;
                        e.domicilioEntrega = domicilioEntrega;
                        e.telefono = telefono;
                        e.numeroGuia = numeroGuia;
                        e.ordenCompra_idordenCompra = int.Parse(idordenCompra);
                        db.Entry(e).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al agregar envio";
                        }
                    }
                    else
                    {
                        return "envio no encontrado";
                    }

                }
            }
            catch (Exception ex) {
              return ex.ToString();
            }

        }

        public string EliminarEnvio(string idenvio) {
            using (var db = new mayoreocEntities()) {
                envios e = db.envios.Find(int.Parse(idenvio));
                if (e != null)
                {
                    db.envios.Remove(e);
                    try
                    {
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al agregar envio";
                        }

                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
                else {
                    return "Envio no encontrado";
                }

            }
        }

    }
}