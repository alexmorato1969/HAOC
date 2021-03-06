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
    public partial class GEDUsuarios
    {
        #region Primitive Properties
    
        public virtual int USR_idUsuario
        {
            get;
            set;
        }
    
        public virtual Nullable<int> USR_idGrupoUsuario
        {
            get;
            set;
        }
    
        public virtual Nullable<int> USR_idPessoa
        {
            get { return _uSR_idPessoa; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_uSR_idPessoa != value)
                    {
                        if (GEDPessoas != null && GEDPessoas.PES_idPessoa != value)
                        {
                            GEDPessoas = null;
                        }
                        _uSR_idPessoa = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<int> _uSR_idPessoa;
    
        public virtual string USR_login
        {
            get;
            set;
        }
    
        public virtual string USR_senha
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> USR_flagAtivo
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> USR_firstAccess
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> USR_dataHoraCadastro
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> USR_dataHoraLastLogin
        {
            get;
            set;
        }
    
        public virtual string USR_observacao
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> usr_flagdigitalizacao
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> usr_flagimportacao
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> USR_flagImprimir
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> USR_flagAssina
        {
            get;
            set;
        }
    
        public virtual Nullable<int> USR_NivelAssina
        {
            get;
            set;
        }
    
        public virtual string USR_SerialNumberCert
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> usr_flagAdmACS
        {
            get;
            set;
        }
    
        public virtual Nullable<bool> USR_FLAGPROCESSAMENTO
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<GEDLotesXUsuarios> GEDLotesXUsuarios
        {
            get
            {
                if (_gEDLotesXUsuarios == null)
                {
                    var newCollection = new FixupCollection<GEDLotesXUsuarios>();
                    newCollection.CollectionChanged += FixupGEDLotesXUsuarios;
                    _gEDLotesXUsuarios = newCollection;
                }
                return _gEDLotesXUsuarios;
            }
            set
            {
                if (!ReferenceEquals(_gEDLotesXUsuarios, value))
                {
                    var previousValue = _gEDLotesXUsuarios as FixupCollection<GEDLotesXUsuarios>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupGEDLotesXUsuarios;
                    }
                    _gEDLotesXUsuarios = value;
                    var newValue = value as FixupCollection<GEDLotesXUsuarios>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupGEDLotesXUsuarios;
                    }
                }
            }
        }
        private ICollection<GEDLotesXUsuarios> _gEDLotesXUsuarios;
    
        public virtual GEDPessoas GEDPessoas
        {
            get { return _gEDPessoas; }
            set
            {
                if (!ReferenceEquals(_gEDPessoas, value))
                {
                    var previousValue = _gEDPessoas;
                    _gEDPessoas = value;
                    FixupGEDPessoas(previousValue);
                }
            }
        }
        private GEDPessoas _gEDPessoas;

        #endregion

        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupGEDPessoas(GEDPessoas previousValue)
        {
            if (previousValue != null && previousValue.GEDUsuarios.Contains(this))
            {
                previousValue.GEDUsuarios.Remove(this);
            }
    
            if (GEDPessoas != null)
            {
                if (!GEDPessoas.GEDUsuarios.Contains(this))
                {
                    GEDPessoas.GEDUsuarios.Add(this);
                }
                if (USR_idPessoa != GEDPessoas.PES_idPessoa)
                {
                    USR_idPessoa = GEDPessoas.PES_idPessoa;
                }
            }
            else if (!_settingFK)
            {
                USR_idPessoa = null;
            }
        }
    
        private void FixupGEDLotesXUsuarios(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (GEDLotesXUsuarios item in e.NewItems)
                {
                    item.GEDUsuarios = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (GEDLotesXUsuarios item in e.OldItems)
                {
                    if (ReferenceEquals(item.GEDUsuarios, this))
                    {
                        item.GEDUsuarios = null;
                    }
                }
            }
        }

        #endregion

    }
}
