﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace NORTHWNDModel
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class NORTHWNDEntities : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект NORTHWNDEntities, используя строку соединения из раздела "NORTHWNDEntities" файла конфигурации приложения.
        /// </summary>
        public NORTHWNDEntities() : base("name=NORTHWNDEntities", "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта NORTHWNDEntities.
        /// </summary>
        public NORTHWNDEntities(string connectionString) : base(connectionString, "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта NORTHWNDEntities.
        /// </summary>
        public NORTHWNDEntities(EntityConnection connection) : base(connection, "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Customers> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customers>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customers> _Customers;

        #endregion
        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Customers. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToCustomers(Customers customers)
        {
            base.AddObject("Customers", customers);
        }

        #endregion
    }
    

    #endregion
    
    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NORTHWNDModel", Name="Customers")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customers : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Customers.
        /// </summary>
        /// <param name="customerID">Исходное значение свойства CustomerID.</param>
        /// <param name="companyName">Исходное значение свойства CompanyName.</param>
        public static Customers CreateCustomers(global::System.String customerID, global::System.String companyName)
        {
            Customers customers = new Customers();
            customers.CustomerID = customerID;
            customers.CompanyName = companyName;
            return customers;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.String _CustomerID;
        partial void OnCustomerIDChanging(global::System.String value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactName
        {
            get
            {
                return _ContactName;
            }
            set
            {
                OnContactNameChanging(value);
                ReportPropertyChanging("ContactName");
                _ContactName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactName");
                OnContactNameChanged();
            }
        }
        private global::System.String _ContactName;
        partial void OnContactNameChanging(global::System.String value);
        partial void OnContactNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactTitle
        {
            get
            {
                return _ContactTitle;
            }
            set
            {
                OnContactTitleChanging(value);
                ReportPropertyChanging("ContactTitle");
                _ContactTitle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactTitle");
                OnContactTitleChanged();
            }
        }
        private global::System.String _ContactTitle;
        partial void OnContactTitleChanging(global::System.String value);
        partial void OnContactTitleChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Region
        {
            get
            {
                return _Region;
            }
            set
            {
                OnRegionChanging(value);
                ReportPropertyChanging("Region");
                _Region = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Region");
                OnRegionChanged();
            }
        }
        private global::System.String _Region;
        partial void OnRegionChanging(global::System.String value);
        partial void OnRegionChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                OnFaxChanging(value);
                ReportPropertyChanging("Fax");
                _Fax = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Fax");
                OnFaxChanged();
            }
        }
        private global::System.String _Fax;
        partial void OnFaxChanging(global::System.String value);
        partial void OnFaxChanged();

        #endregion
    
    }

    #endregion
    
}