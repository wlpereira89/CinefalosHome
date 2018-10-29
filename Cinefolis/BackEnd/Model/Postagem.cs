using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Postagem {
        public static bool cadastrarPostagem(POSTAGEM post) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.POSTAGEM.Add(post);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarPostagem(USUARIO user, string texto, int idLocal, string localizacao, int idMovie, int idPostagem) {
            try {
                AcessoEntities db = new AcessoEntities();
                POSTAGEM post = new POSTAGEM {
                    USUARIO = user,
                    DATA_HORA = DateTime.Now,
                    TEXTO = texto,
                    ID_LOCAL = idLocal,
                    LOCALIZACAO = localizacao,
                    MOVIE = Movie.procurarMovie(idMovie),
                    ID_POSTAGEM = idPostagem
                };
                db.POSTAGEM.Add(post);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static POSTAGEM procurarPostagem(int idPostagem) {
            try {
                AcessoEntities db = new AcessoEntities();                
                return db.POSTAGEM.Find(idPostagem);
            } catch {
                throw;
            }            
        }
        public static List<POSTAGEM> procurarPostagensPorLocal(LOCAL local) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.POSTAGEM.Where(p => p.LOCAL.Equals(local)).ToList();
            } catch {
                throw;
            }
        }

        public static List<POSTAGEM> procurarPostagensPorUsuario(USUARIO user) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.POSTAGEM.Where(p => p.USUARIO.Equals(user)).ToList();
            } catch {
                throw;
            }
        }

        public static List<POSTAGEM> procurarPostagensPorTexto(string texto) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.POSTAGEM.Where(p => p.TEXTO.Contains(texto)).ToList();
            } catch {
                throw;
            }
        }
    }
}
