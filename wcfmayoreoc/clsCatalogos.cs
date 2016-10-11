using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsCatalogos
    {
        public string AgregarCatalogo(string nombreCatalogo) {
            using (var db = new mayoreocEntities()) {
                catalogos c = new catalogos();
                c.nombreCatalogo = nombreCatalogo;
                try
                {
                    db.catalogos.Add(c);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else {
                        return "Error al agregar catalogo";
                    }
                }
                catch (Exception ex) {
                   return ex.ToString();
                }
            }
        }

        public string ModificarCatalogo(string idcatalogo, string nombreCatalogo) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    var c = db.catalogos.Find(int.Parse(idcatalogo));
                    if (c != null)
                    {
                        c.nombreCatalogo = nombreCatalogo;
                        db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar catalogo";
                        }

                    }
                    else
                    {
                        return "Catalogo no encontrado";
                    }
                }
                catch(Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string EliminarCatalogo(string idcatalogo)
        {
            using (var db = new mayoreocEntities())
            {
                try
                {
                    var c = db.catalogos.Find(int.Parse(idcatalogo));
                    if (c != null)
                    {
                        db.catalogos.Remove(c);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar catalogo";
                        }

                    }
                    else
                    {
                        return "Catalogo no encontrado";
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