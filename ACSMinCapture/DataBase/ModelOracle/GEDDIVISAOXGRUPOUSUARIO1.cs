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
    
    public partial class GEDDIVISAOXGRUPOUSUARIO1
    {
        public decimal DVG_IDDIVISAOXGRUPOUSUARIO { get; set; }
        public Nullable<decimal> DVG_IDGRUPOUSUARIO { get; set; }
        public Nullable<decimal> DVG_IDDIVISAO { get; set; }
        public Nullable<decimal> DVG_FLAGATIVO { get; set; }
    
        public virtual GEDDIVISOES1 GEDDIVISOES { get; set; }
        public virtual GEDGRUPOSUSUARIOS1 GEDGRUPOSUSUARIOS { get; set; }
    }
}
