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
    
    public partial class GEDPADROESCERTIFICADO1
    {
        public GEDPADROESCERTIFICADO1()
        {
            this.GEDCONTROLECERTIFICADO = new HashSet<GEDCONTROLECERTIFICADO1>();
        }
    
        public decimal PDC_IDPADROESCERTIFICADO { get; set; }
        public string PDC_NOME { get; set; }
        public Nullable<decimal> PCD_FLAGATIVO { get; set; }
    
        public virtual ICollection<GEDCONTROLECERTIFICADO1> GEDCONTROLECERTIFICADO { get; set; }
    }
}
