using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsCategorias
    {
        public string AgregarCategoria(string nombreCategoria, string idcatalogo) {
            using (var db = new mayoreocEntities()) {
                categorias c = new categorias();
                c.nombreCategoria = nombreCategoria;
                c.idcategoria = int.Parse(idcatalogo);
                try
                {
                    db.categorias.Add(c);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "Error al agregar categoria";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }

        }

        public string ModificarCategoria(string idcategoria, string nombreCategoria, string idcatalogo) {

            try
            {
                using (var db = new mayoreocEntities())
                {
                    categorias c = db.categorias.Find(idcategoria);
                    if (c != null)
                    {
                        c.nombreCategoria = nombreCategoria;
                        c.catalogos_idcatalogo = int.Parse(idcatalogo);
                        db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar categoria";
                        }
                    }
                    else
                    {
                        return "Categoria no encontrada";
                    }
                }
            }
            catch (Exception ex) {

                return ex.ToString();
            }
        }

        public string EliminarCategoria(string idcategoria) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    categorias c = db.categorias.Find(idcategoria);
                    if (c != null)
                    {
                        db.categorias.Remove(c);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar categoria";
                        }

                    }
                    else {
                        return "Categoria no encontrada";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }


        }


    }
}