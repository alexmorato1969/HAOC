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
    
    public partial class GEDLOGOCORRENCIA1
    {
        public decimal LGO_IDLOGOCORRENCIA { get; set; }
        public decimal LGO_IDOCORRENCIA { get; set; }
        public decimal LGO_IDSTATUSOCORRENCIA { get; set; }
        public Nullable<System.DateTime> LGO_DATAHORA { get; set; }
        public string LGO_OBSERVACAOCONCLUSAO { get; set; }
    
        public virtual GEDOCORRENCIAS1 GEDOCORRENCIAS { get; set; }
        public virtual GEDSTATUSOCORRENCIA1 GEDSTATUSOCORRENCIA { get; set; }
    }
}
