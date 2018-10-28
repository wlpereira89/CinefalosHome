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
        public static bool cadastrarLocalFisico(USUARIO usuario, string endereco, string nome, string descricao, string site) {
            try {
                AcessoEntities db = new AcessoEntities();
                LOCAL local = new LOCAL {
                    USUARIO = usuario,
                    ENDERECO = endereco,
                    NOME = nome,
                    DESCRICAO = descricao,
                    LINK = site

                };
                db.LOCAL.Add(local);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarLocalVirtal(USUARIO usuario, string endereco, string nome, string descricao, string link) {
            try {
                AcessoEntities db = new AcessoEntities();
                LOCAL local = new LOCAL {
                    USUARIO = usuario,
                    NOME = nome,
                    DESCRICAO = descricao,
                    LINK = link
                };
                db.LOCAL.Add(local);
                db.SaveChanges();
            } catch {
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
        public static bool incluirFilmeLocal(int idLocal, int idFilme) {
            try {
                AcessoEntities db = new AcessoEntities();
                m lg = new LOCAL_GENERO {
                    ID_LOCAL = idLocal,
                    ID_GENERO = idFilme
                };
                db.LOCAL_GENERO.Add(lg);
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
        public static List<LOCAL> listarLocais() {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.LOCAL.ToList();
            } catch {
                throw;
            }
        }
        public static List<LOCAL> listarLocaisPorNome(string nome) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.LOCAL.Where(l => l.NOME.Equals(nome)).ToList();
            } catch {
                throw;
            }
        }
    }
}
