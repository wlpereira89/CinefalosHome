﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Acesso;

namespace BackEnd.Model
{
    public static class Usuario
    {
        public static bool cadastrarUsuario(USUARIO user)
        {
            try {
                AcessoEntities db = new AcessoEntities();
                db.USUARIO.Add(user);
                db.SaveChanges();
            }
            catch {
                throw;
            }
            return false;
        }
        public static bool cadastrarUsuario(string nome, string sobrenome, string endereco, string foto, string detalhes, string senha)
        {
            try
            {
                AcessoEntities db = new AcessoEntities();
                USUARIO user = new USUARIO {
                    NOME = nome,
                    SOBRENOME = sobrenome,
                    ENDERECO = endereco,
                    LINK_FOTO = foto,
                    DETALHES = detalhes,
                    SENHA = senha
                };
                db.USUARIO.Add(user);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
            return false;
        }
    }
}
