//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Acesso
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOCAL()
        {
            this.EVENTO = new HashSet<EVENTO>();
            this.LOCAL_GENERO = new HashSet<LOCAL_GENERO>();
            this.POSTAGEM = new HashSet<POSTAGEM>();
            this.LIKE_LOCAL = new HashSet<LIKE_LOCAL>();
        }
    
        public int ID { get; set; }
        public int ID_CRIADOR_PAGINA { get; set; }
        public string ENDERECO { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string LINK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTO> EVENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOCAL_GENERO> LOCAL_GENERO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSTAGEM> POSTAGEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIKE_LOCAL> LIKE_LOCAL { get; set; }
    }
}
