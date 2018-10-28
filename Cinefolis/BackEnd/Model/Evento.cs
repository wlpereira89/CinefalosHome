using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Evento {
        public static bool cadastrarEvento(EVENTO evento) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.EVENTO.Add(evento);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarEvento(int idLocal, int idMovie, string descricao) {
            try {
                AcessoEntities db = new AcessoEntities();
                EVENTO evento = new EVENTO {
                    ID_LOCAL = idLocal,
                    ID_MOVIE = idMovie,
                    DESCRICAO = descricao
                };
                db.EVENTO.Add(evento);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
    }
}
