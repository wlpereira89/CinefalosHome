using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Movie {
        public static bool cadastrarMovie(MOVIE movie) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.MOVIE.Add(movie);
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
                MOVIE movie = new MOVIE {
                    USUARIO = usuario,
                    TITULO = titulo,
                    TIPO = 2,
                    TEMPORADAS = temporadas,
                    EPISODIOS = eposodios,
                    LINK_FOTO_CAPA = capa

                };
                db.MOVIE.Add(movie);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarFilme(USUARIO usuario, string titulo, TimeSpan duracao, string capa) {
            try {
                AcessoEntities db = new AcessoEntities();
                MOVIE movie = new MOVIE {
                    USUARIO = usuario,
                    TITULO = titulo,
                    TIPO = 1,
                    DURACAO = duracao,
                    LINK_FOTO_CAPA = capa
                };
                db.MOVIE.Add(movie);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool incluirGeneroMovie(int idMovie, int idGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                MOVIE_GENERO lg = new MOVIE_GENERO {
                    ID_MOVIE = idMovie,
                    ID_GENERO = idGenero
                };
                db.MOVIE_GENERO.Add(lg);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool incluirGenerosMovie(int idMovie, int[] idsGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                foreach(int idGenero in idsGenero) {
                    MOVIE_GENERO lg = new MOVIE_GENERO {
                        ID_MOVIE = idMovie,
                        ID_GENERO = idGenero
                    };
                    db.MOVIE_GENERO.Add(lg);
                }
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }

        public static MOVIE procurarMovie(int idMovie) {
            try {
                AcessoEntities db = new AcessoEntities();                
                return db.MOVIE.Find(idMovie);
            } catch {
                throw;
            }
        }
    }
}
