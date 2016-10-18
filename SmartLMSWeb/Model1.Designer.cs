﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SmartLMSWeb
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NewINTECHEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NewINTECHEntities object using the connection string found in the 'NewINTECHEntities' section of the application configuration file.
        /// </summary>
        public NewINTECHEntities() : base("name=NewINTECHEntities", "NewINTECHEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewINTECHEntities object.
        /// </summary>
        public NewINTECHEntities(string connectionString) : base(connectionString, "NewINTECHEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewINTECHEntities object.
        /// </summary>
        public NewINTECHEntities(EntityConnection connection) : base(connection, "NewINTECHEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<TBL_USER> TBL_USER
        {
            get
            {
                if ((_TBL_USER == null))
                {
                    _TBL_USER = base.CreateObjectSet<TBL_USER>("TBL_USER");
                }
                return _TBL_USER;
            }
        }
        private ObjectSet<TBL_USER> _TBL_USER;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TBL_USER EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTBL_USER(TBL_USER tBL_USER)
        {
            base.AddObject("TBL_USER", tBL_USER);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewINTECHModel", Name="TBL_USER")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TBL_USER : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TBL_USER object.
        /// </summary>
        /// <param name="uSER_NAME">Initial value of the USER_NAME property.</param>
        public static TBL_USER CreateTBL_USER(global::System.String uSER_NAME)
        {
            TBL_USER tBL_USER = new TBL_USER();
            tBL_USER.USER_NAME = uSER_NAME;
            return tBL_USER;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String USER_NAME
        {
            get
            {
                return _USER_NAME;
            }
            set
            {
                if (_USER_NAME != value)
                {
                    OnUSER_NAMEChanging(value);
                    ReportPropertyChanging("USER_NAME");
                    _USER_NAME = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("USER_NAME");
                    OnUSER_NAMEChanged();
                }
            }
        }
        private global::System.String _USER_NAME;
        partial void OnUSER_NAMEChanging(global::System.String value);
        partial void OnUSER_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ROLE_ID
        {
            get
            {
                return _ROLE_ID;
            }
            set
            {
                OnROLE_IDChanging(value);
                ReportPropertyChanging("ROLE_ID");
                _ROLE_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ROLE_ID");
                OnROLE_IDChanged();
            }
        }
        private Nullable<global::System.Int32> _ROLE_ID;
        partial void OnROLE_IDChanging(Nullable<global::System.Int32> value);
        partial void OnROLE_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ROLE_NAME
        {
            get
            {
                return _ROLE_NAME;
            }
            set
            {
                OnROLE_NAMEChanging(value);
                ReportPropertyChanging("ROLE_NAME");
                _ROLE_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ROLE_NAME");
                OnROLE_NAMEChanged();
            }
        }
        private global::System.String _ROLE_NAME;
        partial void OnROLE_NAMEChanging(global::System.String value);
        partial void OnROLE_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PASSWORD
        {
            get
            {
                return _PASSWORD;
            }
            set
            {
                OnPASSWORDChanging(value);
                ReportPropertyChanging("PASSWORD");
                _PASSWORD = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PASSWORD");
                OnPASSWORDChanged();
            }
        }
        private global::System.String _PASSWORD;
        partial void OnPASSWORDChanging(global::System.String value);
        partial void OnPASSWORDChanged();

        #endregion

    
    }

    #endregion

    
}
