﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Likes {
        public static bool likeGenero(int idUsuario, int idGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                LIKE_GENERO like = new LIKE_GENERO {
                    ID_GENERO = idGenero,
                    ID_USUARIO = idUsuario
                };
                db.LIKE_GENERO.Add(like);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static int quantidadeLikesGenero (int idGenero) {
            try {
                AcessoEntities db = new AcessoEntities();
                
                return db.LIKE_GENERO.Where(like => like.ID_GENERO.Equals(idGenero)).Count();
            } catch {
                throw;
            }
        }
        public static bool likeLocal(int idUsuario, int idLocal) {
            try {
                AcessoEntities db = new AcessoEntities();
                LIKE_LOCAL like = new LIKE_LOCAL {
                    ID_LOCAL = idLocal,
                    ID_USUARIO = idUsuario
                };
                db.LIKE_LOCAL.Add(like);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static int quantidadeLikesLocal(int idLocal) {
            try {
                AcessoEntities db = new AcessoEntities();

                return db.LIKE_LOCAL.Where(like => like.ID_LOCAL.Equals(idLocal)).Count();
            } catch {
                throw;
            }
        }
        public static bool likeMovie(int idUsuario, int idMovie) {
            try {
                AcessoEntities db = new AcessoEntities();
                LIKE_MOVIES like = new LIKE_MOVIES {
                    ID_MOVIE = idMovie,
                    ID_USUARIO = idUsuario
                };
                db.LIKE_MOVIES.Add(like);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static int quantidadeLikesMovie(int idMovie) {
            try {
                AcessoEntities db = new AcessoEntities();

                return db.LIKE_MOVIES.Where(like => like.ID_MOVIE.Equals(idMovie)).Count();
            } catch {
                throw;
            }
        }
    }
}
