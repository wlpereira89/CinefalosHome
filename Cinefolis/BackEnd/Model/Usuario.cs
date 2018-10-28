using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model {
    public static class Usuario {
        public static bool cadastrarUsuario(USUARIO user) {
            try {
                AcessoEntities db = new AcessoEntities();
                db.USUARIO.Add(user);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static bool cadastrarUsuario(string nome, string sobrenome, string endereco, string foto, string detalhes, string login, string senha) {
            try {
                AcessoEntities db = new AcessoEntities();
                USUARIO user = new USUARIO {
                    NOME = nome,
                    SOBRENOME = sobrenome,
                    ENDERECO = endereco,
                    LINK_FOTO = foto,
                    DETALHES = detalhes,
                    LOGIN = login,
                    SENHA = GerarHashMd5(senha)
                };
                db.USUARIO.Add(user);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return true;
        }
        public static USUARIO procurarUsuario(int idUsuario) {
            try {
                AcessoEntities db = new AcessoEntities();                
                return db.USUARIO.Find(idUsuario);
            } catch {
                throw;
            }            
        }
        public static USUARIO procurarUsuario(string login) {
            try {
                AcessoEntities db = new AcessoEntities();
                return db.USUARIO.Where(u => u.LOGIN == login).First();
            } catch {
                throw;
            }
        }
        public static bool realizarLogin (string login, string senha) {
            USUARIO u = procurarUsuario(login);
            if (GerarHashMd5(u.SENHA).Equals(GerarHashMd5(senha))) {
                return true;
            }
            return false;
        }
        public static string GerarHashMd5(string input) {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for(int i = 0; i < data.Length; i++) {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
