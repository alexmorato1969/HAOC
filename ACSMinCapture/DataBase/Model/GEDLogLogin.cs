//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ACSMinCapture.DataBase.Model
{
    public partial class GEDLogLogin
    {
        #region Primitive Properties
    
        public virtual int LLG_idLogLogin
        {
            get;
            set;
        }
    
        public virtual Nullable<int> LLG_idUsuario
        {
            get;
            set;
        }
    
        public virtual string LLG_ipEstacao
        {
            get;
            set;
        }
    
        public virtual Nullable<int> LLG_idUnidade
        {
            get;
            set;
        }
    
        public virtual Nullable<int> LLG_flagLogin
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LLG_dataHoraLogin
        {
            get;
            set;
        }
    
        public virtual Nullable<int> LLG_flagLogout
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> LLG_dataHoraLogout
        {
            get;
            set;
        }
    
        public virtual string LLG_observacao
        {
            get;
            set;
        }
    
        public virtual string LLG_token
        {
            get;
            set;
        }

        #endregion

    }
}