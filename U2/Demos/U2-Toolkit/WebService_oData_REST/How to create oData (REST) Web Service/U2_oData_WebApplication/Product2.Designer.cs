﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

//[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("XDEMOModel", "PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(U2_oData_WebApplication.PRODUCT2), "PRODUCTS_AWARD_INFO", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(U2_oData_WebApplication.PRODUCTS_AWARD_INFO), true)]

#endregion

namespace U2_oData_WebApplication
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class XDEMOEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new XDEMOEntities object using the connection string found in the 'XDEMOEntities' section of the application configuration file.
        /// </summary>
        public XDEMOEntities() : base("name=XDEMOEntities", "XDEMOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new XDEMOEntities object.
        /// </summary>
        public XDEMOEntities(string connectionString) : base(connectionString, "XDEMOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new XDEMOEntities object.
        /// </summary>
        public XDEMOEntities(EntityConnection connection) : base(connection, "XDEMOEntities")
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
        public ObjectSet<PRODUCT2> PRODUCT2S
        {
            get
            {
                if ((_PRODUCT2S == null))
                {
                    _PRODUCT2S = base.CreateObjectSet<PRODUCT2>("PRODUCT2S");
                }
                return _PRODUCT2S;
            }
        }
        private ObjectSet<PRODUCT2> _PRODUCT2S;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PRODUCTS_AWARD_INFO> PRODUCTS_AWARD_INFO
        {
            get
            {
                if ((_PRODUCTS_AWARD_INFO == null))
                {
                    _PRODUCTS_AWARD_INFO = base.CreateObjectSet<PRODUCTS_AWARD_INFO>("PRODUCTS_AWARD_INFO");
                }
                return _PRODUCTS_AWARD_INFO;
            }
        }
        private ObjectSet<PRODUCTS_AWARD_INFO> _PRODUCTS_AWARD_INFO;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PRODUCT2S EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPRODUCT2S(PRODUCT2 pRODUCT2)
        {
            base.AddObject("PRODUCT2S", pRODUCT2);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PRODUCTS_AWARD_INFO EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPRODUCTS_AWARD_INFO(PRODUCTS_AWARD_INFO pRODUCTS_AWARD_INFO)
        {
            base.AddObject("PRODUCTS_AWARD_INFO", pRODUCTS_AWARD_INFO);
        }

        #endregion
        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectResult<PRODUCT2> f_XDEMO_GETPRODUCTS()
        {
            return base.ExecuteFunction<PRODUCT2>("f_XDEMO_GETPRODUCTS");
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        public ObjectResult<PRODUCT2> f_XDEMO_GETPRODUCTS(MergeOption mergeOption)
        {
            return base.ExecuteFunction<PRODUCT2>("f_XDEMO_GETPRODUCTS", mergeOption);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XDEMOModel", Name="PRODUCT2")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PRODUCT2 : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PRODUCT2 object.
        /// </summary>
        /// <param name="pRODUCT_ID">Initial value of the PRODUCT_ID property.</param>
        /// <param name="l_UPC">Initial value of the L_UPC property.</param>
        /// <param name="lOCATION">Initial value of the LOCATION property.</param>
        public static PRODUCT2 CreatePRODUCT2(global::System.Decimal pRODUCT_ID, global::System.String l_UPC, global::System.String lOCATION)
        {
            PRODUCT2 pRODUCT2 = new PRODUCT2();
            pRODUCT2.PRODUCT_ID = pRODUCT_ID;
            pRODUCT2.L_UPC = l_UPC;
            pRODUCT2.LOCATION = lOCATION;
            return pRODUCT2;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal PRODUCT_ID
        {
            get
            {
                return _PRODUCT_ID;
            }
            set
            {
                if (_PRODUCT_ID != value)
                {
                    OnPRODUCT_IDChanging(value);
                    ReportPropertyChanging("PRODUCT_ID");
                    _PRODUCT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PRODUCT_ID");
                    OnPRODUCT_IDChanged();
                }
            }
        }
        private global::System.Decimal _PRODUCT_ID;
        partial void OnPRODUCT_IDChanging(global::System.Decimal value);
        partial void OnPRODUCT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                OnISBNChanging(value);
                ReportPropertyChanging("ISBN");
                _ISBN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ISBN");
                OnISBNChanged();
            }
        }
        private global::System.String _ISBN;
        partial void OnISBNChanging(global::System.String value);
        partial void OnISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TITLE
        {
            get
            {
                return _TITLE;
            }
            set
            {
                OnTITLEChanging(value);
                ReportPropertyChanging("TITLE");
                _TITLE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TITLE");
                OnTITLEChanged();
            }
        }
        private global::System.String _TITLE;
        partial void OnTITLEChanging(global::System.String value);
        partial void OnTITLEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> DISKS
        {
            get
            {
                return _DISKS;
            }
            set
            {
                OnDISKSChanging(value);
                ReportPropertyChanging("DISKS");
                _DISKS = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DISKS");
                OnDISKSChanged();
            }
        }
        private Nullable<global::System.Int32> _DISKS;
        partial void OnDISKSChanging(Nullable<global::System.Int32> value);
        partial void OnDISKSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RATING
        {
            get
            {
                return _RATING;
            }
            set
            {
                OnRATINGChanging(value);
                ReportPropertyChanging("RATING");
                _RATING = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RATING");
                OnRATINGChanged();
            }
        }
        private global::System.String _RATING;
        partial void OnRATINGChanging(global::System.String value);
        partial void OnRATINGChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> ASPECT
        {
            get
            {
                return _ASPECT;
            }
            set
            {
                OnASPECTChanging(value);
                ReportPropertyChanging("ASPECT");
                _ASPECT = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ASPECT");
                OnASPECTChanged();
            }
        }
        private Nullable<global::System.Decimal> _ASPECT;
        partial void OnASPECTChanging(Nullable<global::System.Decimal> value);
        partial void OnASPECTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GENRE
        {
            get
            {
                return _GENRE;
            }
            set
            {
                OnGENREChanging(value);
                ReportPropertyChanging("GENRE");
                _GENRE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GENRE");
                OnGENREChanged();
            }
        }
        private global::System.String _GENRE;
        partial void OnGENREChanging(global::System.String value);
        partial void OnGENREChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> NOEPISODES
        {
            get
            {
                return _NOEPISODES;
            }
            set
            {
                OnNOEPISODESChanging(value);
                ReportPropertyChanging("NOEPISODES");
                _NOEPISODES = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NOEPISODES");
                OnNOEPISODESChanged();
            }
        }
        private Nullable<global::System.Int32> _NOEPISODES;
        partial void OnNOEPISODESChanging(Nullable<global::System.Int32> value);
        partial void OnNOEPISODESChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LOCATION_CODE
        {
            get
            {
                return _LOCATION_CODE;
            }
            set
            {
                OnLOCATION_CODEChanging(value);
                ReportPropertyChanging("LOCATION_CODE");
                _LOCATION_CODE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LOCATION_CODE");
                OnLOCATION_CODEChanged();
            }
        }
        private global::System.String _LOCATION_CODE;
        partial void OnLOCATION_CODEChanging(global::System.String value);
        partial void OnLOCATION_CODEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> THEATERDATE
        {
            get
            {
                return _THEATERDATE;
            }
            set
            {
                OnTHEATERDATEChanging(value);
                ReportPropertyChanging("THEATERDATE");
                _THEATERDATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("THEATERDATE");
                OnTHEATERDATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _THEATERDATE;
        partial void OnTHEATERDATEChanging(Nullable<global::System.DateTime> value);
        partial void OnTHEATERDATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MPN
        {
            get
            {
                return _MPN;
            }
            set
            {
                OnMPNChanging(value);
                ReportPropertyChanging("MPN");
                _MPN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MPN");
                OnMPNChanged();
            }
        }
        private global::System.String _MPN;
        partial void OnMPNChanging(global::System.String value);
        partial void OnMPNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String STUDIO
        {
            get
            {
                return _STUDIO;
            }
            set
            {
                OnSTUDIOChanging(value);
                ReportPropertyChanging("STUDIO");
                _STUDIO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("STUDIO");
                OnSTUDIOChanged();
            }
        }
        private global::System.String _STUDIO;
        partial void OnSTUDIOChanging(global::System.String value);
        partial void OnSTUDIOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DVDRELDATE
        {
            get
            {
                return _DVDRELDATE;
            }
            set
            {
                OnDVDRELDATEChanging(value);
                ReportPropertyChanging("DVDRELDATE");
                _DVDRELDATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DVDRELDATE");
                OnDVDRELDATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _DVDRELDATE;
        partial void OnDVDRELDATEChanging(Nullable<global::System.DateTime> value);
        partial void OnDVDRELDATEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String L_UPC
        {
            get
            {
                return _L_UPC;
            }
            set
            {
                OnL_UPCChanging(value);
                ReportPropertyChanging("L_UPC");
                _L_UPC = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("L_UPC");
                OnL_UPCChanged();
            }
        }
        private global::System.String _L_UPC;
        partial void OnL_UPCChanging(global::System.String value);
        partial void OnL_UPCChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LOCATION
        {
            get
            {
                return _LOCATION;
            }
            set
            {
                OnLOCATIONChanging(value);
                ReportPropertyChanging("LOCATION");
                _LOCATION = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LOCATION");
                OnLOCATIONChanged();
            }
        }
        private global::System.String _LOCATION;
        partial void OnLOCATIONChanging(global::System.String value);
        partial void OnLOCATIONChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MOVIE_IMAGE
        {
            get
            {
                return _MOVIE_IMAGE;
            }
            set
            {
                OnMOVIE_IMAGEChanging(value);
                ReportPropertyChanging("MOVIE_IMAGE");
                _MOVIE_IMAGE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MOVIE_IMAGE");
                OnMOVIE_IMAGEChanged();
            }
        }
        private global::System.String _MOVIE_IMAGE;
        partial void OnMOVIE_IMAGEChanging(global::System.String value);
        partial void OnMOVIE_IMAGEChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("XDEMOModel", "PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS_AWARD_INFO")]
        public EntityCollection<PRODUCTS_AWARD_INFO> PRODUCTS_AWARD_INFO
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PRODUCTS_AWARD_INFO>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS_AWARD_INFO");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PRODUCTS_AWARD_INFO>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS_AWARD_INFO", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="XDEMOModel", Name="PRODUCTS_AWARD_INFO")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PRODUCTS_AWARD_INFO : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PRODUCTS_AWARD_INFO object.
        /// </summary>
        /// <param name="pRODUCT_ID">Initial value of the PRODUCT_ID property.</param>
        /// <param name="c_ASSOC_ROW">Initial value of the C_ASSOC_ROW property.</param>
        public static PRODUCTS_AWARD_INFO CreatePRODUCTS_AWARD_INFO(global::System.Decimal pRODUCT_ID, global::System.Decimal c_ASSOC_ROW)
        {
            PRODUCTS_AWARD_INFO pRODUCTS_AWARD_INFO = new PRODUCTS_AWARD_INFO();
            pRODUCTS_AWARD_INFO.PRODUCT_ID = pRODUCT_ID;
            pRODUCTS_AWARD_INFO.C_ASSOC_ROW = c_ASSOC_ROW;
            return pRODUCTS_AWARD_INFO;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal PRODUCT_ID
        {
            get
            {
                return _PRODUCT_ID;
            }
            set
            {
                if (_PRODUCT_ID != value)
                {
                    OnPRODUCT_IDChanging(value);
                    ReportPropertyChanging("PRODUCT_ID");
                    _PRODUCT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PRODUCT_ID");
                    OnPRODUCT_IDChanged();
                }
            }
        }
        private global::System.Decimal _PRODUCT_ID;
        partial void OnPRODUCT_IDChanging(global::System.Decimal value);
        partial void OnPRODUCT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AWARD_TYPE
        {
            get
            {
                return _AWARD_TYPE;
            }
            set
            {
                OnAWARD_TYPEChanging(value);
                ReportPropertyChanging("AWARD_TYPE");
                _AWARD_TYPE = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AWARD_TYPE");
                OnAWARD_TYPEChanged();
            }
        }
        private global::System.String _AWARD_TYPE;
        partial void OnAWARD_TYPEChanging(global::System.String value);
        partial void OnAWARD_TYPEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AWARD_NAME
        {
            get
            {
                return _AWARD_NAME;
            }
            set
            {
                OnAWARD_NAMEChanging(value);
                ReportPropertyChanging("AWARD_NAME");
                _AWARD_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AWARD_NAME");
                OnAWARD_NAMEChanged();
            }
        }
        private global::System.String _AWARD_NAME;
        partial void OnAWARD_NAMEChanging(global::System.String value);
        partial void OnAWARD_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AWARD_RECIPIENT
        {
            get
            {
                return _AWARD_RECIPIENT;
            }
            set
            {
                OnAWARD_RECIPIENTChanging(value);
                ReportPropertyChanging("AWARD_RECIPIENT");
                _AWARD_RECIPIENT = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AWARD_RECIPIENT");
                OnAWARD_RECIPIENTChanged();
            }
        }
        private global::System.String _AWARD_RECIPIENT;
        partial void OnAWARD_RECIPIENTChanging(global::System.String value);
        partial void OnAWARD_RECIPIENTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal C_ASSOC_ROW
        {
            get
            {
                return _C_ASSOC_ROW;
            }
            set
            {
                if (_C_ASSOC_ROW != value)
                {
                    OnC_ASSOC_ROWChanging(value);
                    ReportPropertyChanging("C_ASSOC_ROW");
                    _C_ASSOC_ROW = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("C_ASSOC_ROW");
                    OnC_ASSOC_ROWChanged();
                }
            }
        }
        private global::System.Decimal _C_ASSOC_ROW;
        partial void OnC_ASSOC_ROWChanging(global::System.Decimal value);
        partial void OnC_ASSOC_ROWChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("XDEMOModel", "PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS")]
        public PRODUCT2 PRODUCT
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PRODUCT2>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PRODUCT2>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<PRODUCT2> PRODUCTReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<PRODUCT2>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<PRODUCT2>("XDEMOModel.PRODUCTS_PRODUCTS_AWARD_INFO", "PRODUCTS", value);
                }
            }
        }

        #endregion
    }

    #endregion
    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="XDEMOModel", Name="ProductComplexType")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class ProductComplexType : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProductComplexType object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="movieImage">Initial value of the MovieImage property.</param>
        public static ProductComplexType CreateProductComplexType(global::System.Decimal id, global::System.Single title, global::System.String movieImage)
        {
            ProductComplexType productComplexType = new ProductComplexType();
            productComplexType.Id = id;
            productComplexType.Title = title;
            productComplexType.MovieImage = movieImage;
            return productComplexType;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Id
        {
            get
            {
                return _Id;
            }
            set
            {
                OnIdChanging(value);
                ReportPropertyChanging("Id");
                _Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Id");
                OnIdChanged();
            }
        }
        private global::System.Decimal _Id;
        partial void OnIdChanging(global::System.Decimal value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Single Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.Single _Title;
        partial void OnTitleChanging(global::System.Single value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MovieImage
        {
            get
            {
                return _MovieImage;
            }
            set
            {
                OnMovieImageChanging(value);
                ReportPropertyChanging("MovieImage");
                _MovieImage = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MovieImage");
                OnMovieImageChanged();
            }
        }
        private global::System.String _MovieImage;
        partial void OnMovieImageChanging(global::System.String value);
        partial void OnMovieImageChanged();

        #endregion
    }

    #endregion
    
}
