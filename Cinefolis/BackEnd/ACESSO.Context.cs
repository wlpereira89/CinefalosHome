﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities1 : DbContext
    {
        public DBEntities1()
            : base("name=DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<CONTATO> CONTATO { get; set; }
        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<EXIBICAO> EXIBICAO { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<LIKE_GENERO> LIKE_GENERO { get; set; }
        public virtual DbSet<LIKE_LOCAL> LIKE_LOCAL { get; set; }
        public virtual DbSet<LIKE_MOVIES> LIKE_MOVIES { get; set; }
        public virtual DbSet<LOCAL> LOCAL { get; set; }
        public virtual DbSet<LOCAL_GENERO> LOCAL_GENERO { get; set; }
        public virtual DbSet<MOVIE> MOVIE { get; set; }
        public virtual DbSet<MOVIE_GENERO> MOVIE_GENERO { get; set; }
        public virtual DbSet<POSTAGEM> POSTAGEM { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}