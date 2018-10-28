using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Local {
        public static bool cadastrarLocal(LOCAL local) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.LOCAL.Add(local);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarSerie(USUARIO usuario, string titulo, int temporadas, int eposodios, string capa) {
            try {
                AcessoEntities db = new AcessoEntities();
                LOCAL local = new LOCAL {
                    USUARIO = usuario,
                    

                };
                db.LOCAL.Add(local);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool incluirGeneroLocal(int idLocal, int idGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                LOCAL_GENERO lg = new LOCAL_GENERO {
                    ID_LOCAL = idLocal,
                    ID_GENERO = idGenero
                };
                db.LOCAL_GENERO.Add(lg);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool incluirGenerosLocal(int idLocal, int[] idsGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                foreach (int idGenero in idsGenero) {
                    LOCAL_GENERO lg = new LOCAL_GENERO {
                        ID_LOCAL = idLocal,
                        ID_GENERO = idGenero
                    };
                    db.LOCAL_GENERO.Add(lg);
                }
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static LOCAL procurarLocal(int idLocal) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.LOCAL.Find(idLocal); 
            } catch {
                throw;
            }
        }
    }
}
