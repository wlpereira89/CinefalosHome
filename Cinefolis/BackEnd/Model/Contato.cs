using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Contato {
        public static bool Solicitacao (int idSolicitante, int idContato) {
            try {
                AcessoEntities db = new AcessoEntities();
                CONTATO contato = new CONTATO {
                    ID_USUARIO1 = idSolicitante,
                    ID_USUARIO2 = idContato,
                    STATUS = 1
                };
                db.CONTATO.Add(contato);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool Aprovacao(int idSolicitacao) {
            try {
                AcessoEntities db = new AcessoEntities();
                CONTATO contato = db.CONTATO.Find(idSolicitacao);
                contato.STATUS = 2;
                db.SaveChanges();

            } catch {
                throw;                
            }
            return true;
        }
        public static bool Reprovacao(int idSolicitacao) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.CONTATO.Remove(db.CONTATO.Find(idSolicitacao));                
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
    }
}
