using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace wcfmayoreoc
{
    public class clsUsuarios
    {

        public retUsuario Login(string username, string password)
        {
            using (var db = new mayoreocEntities())
            {

                var usuario = db.usuarios.FirstOrDefault(u => u.usuario == username && u.password == password);
                if (usuario != null)
                {
                    retUsuario rU = new retUsuario();
                    rU.idusuario = usuario.idusuarios;
                    rU.usuario = usuario.usuario;
                    rU.permisos = usuario.perfil;
                    return rU;
                }
                else
                {
                    return null;
                }
            }

        }


        public string AgregarUsuario(string usuario, string password) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    usuarios u = new usuarios();
                    u.usuario = usuario;
                    u.password = password;
                    db.usuarios.Add(u);
                    if (db.SaveChanges() == 1)
                    {
                        return "OK";
                    }
                    else {
                        return "no se puedo grabar usuario";
                    }
                }
                catch (Exception ex) {
                    return ex.ToString();
                }
            }
        }

        public string ModificarUsuario(string idusuario, string usuario, string password) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    usuarios u = db.usuarios.Find(int.Parse(idusuario));
                    if (u != null)
                    {
                        u.usuario = usuario;
                        u.password = password;
                        db.Entry(u).State = EntityState.Modified;
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else {
                            return "Error al modificar usuario";
                        }
                    }
                    else {
                        return "usuario no encontrado";
                    }
                }
                catch (Exception ex) {
                   return ex.ToString();
                }
            }
        }

        public string EliminarUsuario(string idusuario) {
            using (var db = new mayoreocEntities()) {
                try
                {
                    usuarios u = db.usuarios.Find(int.Parse(idusuario));
                    if (u != null)
                    {
                        db.usuarios.Remove(u);
                        if (db.SaveChanges() == 1)
                        {
                            return "OK";
                        }
                        else
                        {
                            return "Error al eliminar usuario";
                        }
                    }
                    else
                    {
                        return "usuario no encontrado";
                    }
                }
                catch (Exception ex) {
                    return  ex.ToString();
                }

            }
        }
    }
}