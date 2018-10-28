using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Genero {
        public static bool cadastrarGenero(GENERO genero) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.GENERO.Add(genero);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarGenero(string descricao, string nome) {
            try {
                AcessoEntities db = new AcessoEntities();
                GENERO genero = new GENERO {
                    DESCRICAO = descricao,
                    NOME = nome
                    
                };
                db.GENERO.Add(genero);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static GENERO procurarGenero(int idGenero) {
            try {
                AcessoEntities db = new AcessoEntities();                
                return db.GENERO.Find(idGenero);
            } catch {
                throw;
            }            
        }
    }
}
