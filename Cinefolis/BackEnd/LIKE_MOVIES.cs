//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LIKE_MOVIES
    {
        public int ID { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_MOVIE { get; set; }
        public string COMENTARIO { get; set; }
    
        public virtual MOVIE MOVIE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
