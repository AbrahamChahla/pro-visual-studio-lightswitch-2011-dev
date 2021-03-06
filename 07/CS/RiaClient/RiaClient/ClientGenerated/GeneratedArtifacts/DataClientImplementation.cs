//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Person
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class Person :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.Person.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private int _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.RaiseDataMemberChanging("Name");
                    this.ValidateProperty("Name", value);
                    this._Name = value;
                    this.RaiseDataMemberChanged("Name");
                }
            }
        }
        private string _Name;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public int Person_Gender
        {
            get
            {
                return this._Person_Gender;
            }
            set
            {
                if (this._Person_Gender != value)
                {
                    this.RaiseDataMemberChanging("Person_Gender");
                    this.ValidateProperty("Person_Gender", value);
                    this._Person_Gender = value;
                    this.RaiseDataMemberChanged("Person_Gender");
                }
            }
        }
        private int _Person_Gender;
        
        [global::System.ComponentModel.DataAnnotations.Association("Person_Gender", "Person_Gender", "Id", IsForeignKey = true)]
        [global::System.Xml.Serialization.XmlIgnore()]
        public global::LightSwitchApplication.Implementation.Gender Gender
        {
            get
            {
                if (this._Gender == null)
                {
                    this._Gender = new global::System.ServiceModel.DomainServices.Client.EntityRef<global::LightSwitchApplication.Implementation.Gender>(this, "Gender", this.FilterGender);
                }
                return this._Gender.Entity;
            }
            set
            {
                Gender previous = this.Gender;
                if (previous != value)
                {
                    this.ValidateProperty("Gender", value);
                    if (previous != null)
                    {
                        this._Gender.Entity = null;
                        previous.People.Remove(this);
                    }
                    if (value != null)
                    {
                        this.Person_Gender = value.Id;
                    }
                    else
                    {
                        this.Person_Gender = default(int);
                    }
                    this._Gender.Entity = value;
                    if (value != null)
                    {
                        value.People.Add(this);
                    }
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        private global::System.ServiceModel.DomainServices.Client.EntityRef<global::LightSwitchApplication.Implementation.Gender> _Gender;
        private bool FilterGender(global::LightSwitchApplication.Implementation.Gender entity)
        {
            return global::System.Object.Equals(entity.Id, this.Person_Gender);
        }
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Person.DetailsClass.IImplementation.Gender
        {
            get
            {
                return this.Gender;
            }
            set
            {
                this.Gender = (global::LightSwitchApplication.Implementation.Gender)value;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region Gender
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class Gender :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.Gender.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private int _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string GenderName
        {
            get
            {
                return this._GenderName;
            }
            set
            {
                if (this._GenderName != value)
                {
                    this.RaiseDataMemberChanging("GenderName");
                    this.ValidateProperty("GenderName", value);
                    this._GenderName = value;
                    this.RaiseDataMemberChanged("GenderName");
                }
            }
        }
        private string _GenderName;
        
        [global::System.ComponentModel.DataAnnotations.Association("Person_Gender", "Id", "Person_Gender")]
        [global::System.Xml.Serialization.XmlIgnore()]
        public global::System.ServiceModel.DomainServices.Client.EntityCollection<Person> People
        {
            get
            {
                if (this._People == null)
                {
                    this._People = new global::System.ServiceModel.DomainServices.Client.EntityCollection<global::LightSwitchApplication.Implementation.Person>(this, "People", this.FilterPeople, this.AttachPeople, this.DetachPeople);
                }
                return this._People;
            }
        }
        private global::System.ServiceModel.DomainServices.Client.EntityCollection<global::LightSwitchApplication.Implementation.Person> _People;
        private void AttachPeople(global::LightSwitchApplication.Implementation.Person entity)
        {
            entity.Gender = this;
        }
        private void DetachPeople(global::LightSwitchApplication.Implementation.Person entity)
        {
            entity.Gender = null;
        }
        private bool FilterPeople(global::LightSwitchApplication.Implementation.Person entity)
        {
            return global::System.Object.Equals(entity.Person_Gender, this.Id);
        }
        global::System.Collections.IEnumerable global::LightSwitchApplication.Gender.DetailsClass.IImplementation.People
        {
            get
            {
                return this.People;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region ReportDataClass
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ReportDataService2Data.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class ReportDataClass :
        global::System.ServiceModel.DomainServices.Client.Entity,
        global::LightSwitchApplication.ReportDataClass.DetailsClass.IImplementation
    {
        public override object GetIdentity()
        {
            if (this.__host != null && this.__host.IsNewlyAdded)
            {
                return null;
            }
    
            return this._Id;
        }
        [global::System.ComponentModel.DataAnnotations.Key()]
        [global::System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.ValidateProperty("Id", value);
                    this._Id = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        private int _Id;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.RaiseDataMemberChanging("Name");
                    this.ValidateProperty("Name", value);
                    this._Name = value;
                    this.RaiseDataMemberChanged("Name");
                }
            }
        }
        private string _Name;
        
        [global::System.Runtime.Serialization.DataMember()]
        [global::System.ComponentModel.DataAnnotations.RoundtripOriginal()]
        public decimal Total
        {
            get
            {
                return this._Total;
            }
            set
            {
                if (this._Total != value)
                {
                    this.RaiseDataMemberChanging("Total");
                    this.ValidateProperty("Total", value);
                    this._Total = value;
                    this.RaiseDataMemberChanged("Total");
                }
            }
        }
        private decimal _Total;
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(e.PropertyName);
            }
        }
        #endregion
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationData
        : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext
    {
        public ApplicationData(global::Microsoft.LightSwitch.IDataService dataService)
            : base(dataService, global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext.CreateWcfDomainClient<IApplicationDataContract>(new global::System.Uri("LightSwitchApplication-Implementation-ApplicationDataDomainService.svc", global::System.UriKind.Relative)))
        {
        }
    
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.Person> PersonEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.Person>();
            }
        }
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.Gender> GenderEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.Gender>();
            }
        }
        protected override global::System.ServiceModel.DomainServices.Client.EntityContainer CreateEntityContainer()
        {
            return new ApplicationDataEntityContainer();
        }
    
        internal sealed class ApplicationDataEntityContainer : global::System.ServiceModel.DomainServices.Client.EntityContainer
        {
            public ApplicationDataEntityContainer()
            {
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.Person>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.Gender>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
            }
        }
    
        #region Service Contract Interface
    
        [global::System.ServiceModel.ServiceContract]
        public interface IApplicationDataContract
        {
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/People_Single", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/People_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/People_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginPeople_Single(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Person> EndPeople_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/People_SingleOrDefault", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/People_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/People_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginPeople_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Person> EndPeople_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/People_All", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/People_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/People_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginPeople_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Person> EndPeople_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Genders_Single", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Genders_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Genders_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginGenders_Single(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Gender> EndGenders_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Genders_SingleOrDefault", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Genders_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Genders_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginGenders_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Gender> EndGenders_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/Genders_All", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/Genders_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/Genders_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginGenders_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.Gender> EndGenders_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/SubmitChanges", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/SubmitChangesResponse"),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/SubmitChangesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginSubmitChanges(global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> changeSet, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> EndSubmitChanges(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformation", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/__GetEntitySetCanInformationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__GetEntitySetCanInformation(string entitySetName, global::System.AsyncCallback callback, global::System.Object asyncState);
            int End__GetEntitySetCanInformation(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperation", ReplyAction = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ApplicationDataDomainService/__CanExecuteOperationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__CanExecuteOperation(string operationName, global::System.AsyncCallback callback, global::System.Object asyncState);
            bool End__CanExecuteOperation(global::System.IAsyncResult result);
            
        }
    
        #endregion
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Person))
            {
                return new global::LightSwitchApplication.Implementation.Person();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Gender))
            {
                return new global::LightSwitchApplication.Implementation.Gender();
            }
            return null;
        }
    }
    #endregion
    
    #region ReportDataService2Data
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ReportDataService2Data
        : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext
    {
        public ReportDataService2Data(global::Microsoft.LightSwitch.IDataService dataService)
            : base(dataService, global::Microsoft.LightSwitch.ClientGenerated.Implementation.DomainContext.CreateWcfDomainClient<IReportDataService2DataContract>(new global::System.Uri("LightSwitchApplication-Implementation-ReportDataService2DataDomainService.svc", global::System.UriKind.Relative)))
        {
        }
    
        public global::System.ServiceModel.DomainServices.Client.EntitySet<global::LightSwitchApplication.Implementation.ReportDataClass> ReportDataClassEntityList
        {
            get
            {
                return base.EntityContainer.GetEntitySet<global::LightSwitchApplication.Implementation.ReportDataClass>();
            }
        }
        protected override global::System.ServiceModel.DomainServices.Client.EntityContainer CreateEntityContainer()
        {
            return new ReportDataService2DataEntityContainer();
        }
    
        internal sealed class ReportDataService2DataEntityContainer : global::System.ServiceModel.DomainServices.Client.EntityContainer
        {
            public ReportDataService2DataEntityContainer()
            {
                this.CreateEntitySet<global::LightSwitchApplication.Implementation.ReportDataClass>(global::System.ServiceModel.DomainServices.Client.EntitySetOperations.All);
            }
        }
    
        #region Service Contract Interface
    
        [global::System.ServiceModel.ServiceContract]
        public interface IReportDataService2DataContract
        {
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_Single", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_SingleResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_SingleDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginReportDataClasses_Single(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.ReportDataClass> EndReportDataClasses_Single(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_SingleOrDefault", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_SingleOrDefaultResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_SingleOrDefaultDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginReportDataClasses_SingleOrDefault(string frameworkOperators, global::System.Nullable<int> Id, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.ReportDataClass> EndReportDataClasses_SingleOrDefault(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_All", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_AllResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/ReportDataClasses_AllDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginReportDataClasses_All(string frameworkOperators, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.ServiceModel.DomainServices.Client.QueryResult<global::LightSwitchApplication.Implementation.ReportDataClass> EndReportDataClasses_All(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/SubmitChanges", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/SubmitChangesResponse"),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/SubmitChangesDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult BeginSubmitChanges(global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> changeSet, global::System.AsyncCallback callback, global::System.Object asyncState);
            global::System.Collections.Generic.IEnumerable<global::System.ServiceModel.DomainServices.Client.ChangeSetEntry> EndSubmitChanges(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/__GetEntitySetCanInformation", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/__GetEntitySetCanInformationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/__GetEntitySetCanInformationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__GetEntitySetCanInformation(string entitySetName, global::System.AsyncCallback callback, global::System.Object asyncState);
            int End__GetEntitySetCanInformation(global::System.IAsyncResult result);
            
            [global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ReportDataService2DataDomainService/__CanExecuteOperation", ReplyAction = "http://tempuri.org/ReportDataService2DataDomainService/__CanExecuteOperationResponse"),
             global::System.ServiceModel.Web.WebGet(),
             global::System.ServiceModel.FaultContract(typeof(global::System.ServiceModel.DomainServices.Client.DomainServiceFault), Action = "http://tempuri.org/ReportDataService2DataDomainService/__CanExecuteOperationDomainServiceFault", Name = "DomainServiceFault", Namespace = "DomainServices")]
            global::System.IAsyncResult Begin__CanExecuteOperation(string operationName, global::System.AsyncCallback callback, global::System.Object asyncState);
            bool End__CanExecuteOperation(global::System.IAsyncResult result);
            
        }
    
        #endregion
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.ReportDataClass))
            {
                return new global::LightSwitchApplication.Implementation.ReportDataClass();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            if (dataServiceType == typeof(global::LightSwitchApplication.ReportDataService2Data))
            {
                return new global::LightSwitchApplication.ReportDataService2Data();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(dataService);
            }
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ReportDataService2Data))
            {
                return new global::LightSwitchApplication.Implementation.ReportDataService2Data(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Person) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Person);
            }
            if (typeof(global::LightSwitchApplication.Gender) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Gender);
            }
            if (typeof(global::LightSwitchApplication.ReportDataClass) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.ReportDataClass);
            }
            return null;
        }
    }
}
