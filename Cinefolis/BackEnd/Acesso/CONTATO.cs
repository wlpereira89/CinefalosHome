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
    
    public partial class CONTATO
    {
        public int ID { get; set; }
        public int ID_USUARIO1 { get; set; }
        public int ID_USUARIO2 { get; set; }
        public int STATUS { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual USUARIO USUARIO1 { get; set; }
    }
}
