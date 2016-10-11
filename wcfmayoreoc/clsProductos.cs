using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace wcfmayoreoc
{
    public class clsProductos
    {
        public string AgregarProducto(string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                                      string imagen1, string imagen2, string imagen3, string imagen4,
                                      string nuevo, string precio, string categoriaPrecio, string agotado,
                                      string idcatalogo, string idcategoria, string idsubcategoria) {

            using(var db = new mayoreocEntities())
            {
                try
                {
                    productos p = new productos();
                    p.codigoInterno = codigoInterno;
                    p.codigoProveedor = codigoProveedor;
                    p.peso = int.Parse(peso);
                    p.descripcion = descripcion;
                    p.existencia = int.Parse(existencia);
                    p.imagen1 = imagen1;
                    p.imagen2 = imagen2;
                    p.imagen3 = imagen3;
                    p.imagen4 = imagen4;
                    p.nuevo = bool.Parse(nuevo);
                    p.precio = decimal.Parse(precio);
                    p.categoriaPrecio = categoriaPrecio;
                    p.agotado = bool.Parse(agotado);
                    p.catalogos_idcatalogo = int.Parse(idcatalogo);
                    p.categorias_idcategoria = int.Parse(idcategoria);
                    p.subcategorias_idsubcategorias = int.Parse(idsubcategoria);
                    db.productos.Add(p);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else {
                        return "Error al agregar producto";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }

        }

        public string ModificarProducto(string idproducto, string codigoInterno, string codigoProveedor, string peso, string descripcion, string existencia,
                                      string imagen1, string imagen2, string imagen3, string imagen4,
                                      string nuevo, string precio, string categoriaPrecio, string agotado,
                                      string idcatalogo, string idcategoria, string idsubcategoria){
            using (var db = new mayoreocEntities()) {
                try
                {
                    var p = db.productos.Find(idproducto);
                    if (p != null)
                    {
                        p.codigoInterno = codigoInterno;
                        p.codigoProveedor = codigoProveedor;
                        p.peso = int.Parse(peso);
                        p.descripcion = descripcion;
                        p.existencia = int.Parse(existencia);
                        p.imagen1 = imagen1;
                        p.imagen2 = imagen2;
                        p.imagen3 = imagen3;
                        p.imagen4 = imagen4;
                        p.nuevo = bool.Parse(nuevo);
                        p.precio = decimal.Parse(precio);
                        p.categoriaPrecio = categoriaPrecio;
                        p.agotado = bool.Parse(agotado);
                        p.catalogos_idcatalogo = int.Parse(idcatalogo);
                        p.categorias_idcategoria = int.Parse(idcategoria);
                        p.subcategorias_idsubcategorias = int.Parse(idsubcategoria);
                        db.Entry(p).State = EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al modificar producto";
                        }
                    }
                    else {
                        return "no se encuentra el producto";
                    }
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }

        public string EliminarProducto(string idproducto) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    var p = db.productos.Find(idproducto);
                    if (p != null)
                    {
                        db.productos.Remove(p);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else {
                            return "Error al borrar el producto";
                        }
                    }
                    else
                    {
                        return "no se encuentra el producto";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }
    }
}