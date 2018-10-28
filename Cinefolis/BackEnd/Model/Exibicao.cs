using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Exibicao {
        public static bool cadastrarExibicao(EXIBICAO exibicao) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.EXIBICAO.Add(exibicao);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarExibicao(int idEvento, DateTime horario) {
            try {
                AcessoEntities db = new AcessoEntities();
                EXIBICAO exibicao = new EXIBICAO {
                    ID_EVENTO = idEvento,
                    HORARIO = horario
                };
                db.EXIBICAO.Add(exibicao);
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarExibicaoRangeDatas(int idEvento, TimeSpan horario, DateTime dataIni, DateTime dataFim) {
            try {
                if(dataIni > dataFim) {
                    return false;
                }
                AcessoEntities db = new AcessoEntities();
                DateTime dataHora;                 
                
                for (dataHora = new DateTime (dataIni.Year, dataIni.Month, dataIni.Day, horario.Hours, horario.Minutes, 0); dataHora.Date <= dataFim.Date; dataHora.AddDays(1)) {
                    EXIBICAO exibicao = new EXIBICAO {
                        ID_EVENTO = idEvento,
                        HORARIO = dataHora
                    };
                    db.EXIBICAO.Add(exibicao);
                }                    
                db.SaveChanges();
            } catch {
                throw;
            }
            return true;
        }
    }
}
