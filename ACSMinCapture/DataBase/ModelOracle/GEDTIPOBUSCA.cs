//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACSMinCapture.DataBase.ModelOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class GEDTIPOBUSCA
    {
        public decimal TIB_IDTIPOBUSCA { get; set; }
        public decimal TIB_IDTIPOCLIENTE { get; set; }
        public string TIB_DESCRICAO { get; set; }
        public string TIB_CAMPOBUSCAINI { get; set; }
        public string TIB_CAMPOBUSCAFIM { get; set; }
        public string TIB_CAMPOBUSCAINIORA { get; set; }
        public string TIB_CAMPOBUSCAFIMORA { get; set; }
        public Nullable<decimal> TIB_FLAGATIVO { get; set; }
    
        public virtual GEDTIPOCLIENTE GEDTIPOCLIENTE { get; set; }
    }
}
