using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace wcfmayoreoc
{
    public class clsClientes
    {
        public string AgregarCliente(string nombre, string apellidos, string correo, string telefono1, string telefono2,
                                     string password, string calle, string numExterior, string numInterior, string colonia,
                                     string codigoPostal, string municipio, string estado, string fechaAlta) {
            using (var db = new mayoreocEntities()) {
                clientes c = new clientes();
                c.nombre = nombre;
                c.apellidos = apellidos;
                c.correo = correo;
                c.telefono1 = telefono1;
                c.telefono2 = telefono2;
                c.password = password;
                c.calle = calle;
                c.numExterior = numExterior;
                c.numInterior = numInterior;
                c.colonia = colonia;
                c.codigoPostal = int.Parse(codigoPostal);
                c.municipio = municipio;
                c.estado = estado;
                c.fechaAlta = DateTime.Now;

                try
                {
                    db.clientes.Add(c);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else {
                        return "Error al agregar cliente";
                    }
                }
                catch (Exception ex) {

                    return ex.ToString();
                }

            }
        }

        public string ModificarCliente(string idCliente, string nombre, string apellidos, string correo, string telefono1, string telefono2,
                                     string password, string calle, string numExterior, string numInterior, string colonia,
                                     string codigoPostal, string municipio, string estado, string fechaAlta){

            using (var db = new mayoreocEntities()) {
                try
                {
                    var c = db.clientes.Find(int.Parse(idCliente));
                    if (c != null) {
                        c.nombre = nombre;
                        c.apellidos = apellidos;
                        c.correo = correo;
                        c.telefono1 = telefono1;
                        c.telefono2 = telefono2;
                        c.password = password;
                        c.calle = calle;
                        c.numExterior = numExterior;
                        c.numInterior = numInterior;
                        c.colonia = colonia;
                        c.codigoPostal = int.Parse(codigoPostal);
                        c.municipio = municipio;
                        c.estado = estado;
                        c.fechaAlta = DateTime.Now;
                        db.Entry(c).State = EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else {
                            return "Error al modificar cliente";
                        }
                    }else
                    {
                        return "no se encuentra el cliente";
                    }
                }
                catch(Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string EliminarCliente(string idCliente)
        {

            using (var db = new mayoreocEntities())
            {
                try
                {
                    var c = db.clientes.Find(int.Parse(idCliente));
                    if (c != null)
                    {
                        db.clientes.Remove(c);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar cliente";
                        }
                    }
                    else
                    {
                        return "no se encuentra el cliente";
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