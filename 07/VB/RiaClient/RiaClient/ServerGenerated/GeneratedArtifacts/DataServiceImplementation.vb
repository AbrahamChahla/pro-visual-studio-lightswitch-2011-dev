'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication.Implementation
    
    <Global.System.ServiceModel.DomainServices.Hosting.EnableClientAccess()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataDomainService
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New()
            MyBase.New()
        End Sub
    
    #Region "Public methods"
    
    #Region "Person"
    
        Public Sub InsertPerson(ByVal entity As Global.ApplicationData.Implementation.Person)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.People.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdatePerson(ByVal currentEntity As Global.ApplicationData.Implementation.Person)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.People, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeletePerson(ByVal entity As Global.ApplicationData.Implementation.Person)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.People.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Gender"
    
        Public Sub InsertGender(ByVal entity As Global.ApplicationData.Implementation.Gender)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.Genders.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdateGender(ByVal currentEntity As Global.ApplicationData.Implementation.Gender)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.Genders, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeleteGender(ByVal entity As Global.ApplicationData.Implementation.Gender)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.Genders.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Queries"
        Public Function People_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Person)("People_Single", frameworkOperators, Id)
        End Function
    
        Public Function People_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Person)("People_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function People_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Person)("People_All", frameworkOperators)
        End Function
    
        Public Function Genders_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Gender)("Genders_Single", frameworkOperators, Id)
        End Function
    
        Public Function Genders_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Gender)("Genders_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function Genders_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Gender)("Genders_All", frameworkOperators)
        End Function
    
    #End Region
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __GetEntitySetCanInformation(ByVal entitySetName as String) As Integer
            Return MyBase.GetEntitySetCanInformation(entitySetName)
        End Function
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __CanExecuteOperation(ByVal operationName as String) As Boolean
            Return MyBase.CanExecuteOperation(operationName)
        End Function
    
    #End Region
    
        Protected Overrides Function CreateDataService() As Global.Microsoft.LightSwitch.IDataService
            Return New Global.LightSwitchApplication.DataWorkspace().ApplicationData
        End Function
    
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataServiceImplementation
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New(ByVal dataService As Global.Microsoft.LightSwitch.IDataService)
            MyBase.New(dataService)
        End Sub
    
    #Region "Queries"
        Public Function People_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Person)("People_All"), _
                Function(p) (Id.HasValue AndAlso CBool((p.Id = Id))))
            Return query
        End Function
    
        Public Function People_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Person)("People_All"), _
                Function(p) (Id.HasValue AndAlso CBool((p.Id = Id))))
            Return query
        End Function
    
        Public Function People_All() As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Person)
            query = MyBase.CreateQuery(Of Global.ApplicationData.Implementation.Person)("[People]").AsQueryable()
            Return query
        End Function
    
        Public Function Genders_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Gender)("Genders_All"), _
                Function(g) (Id.HasValue AndAlso CBool((g.Id = Id))))
            Return query
        End Function
    
        Public Function Genders_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Gender)("Genders_All"), _
                Function(g) (Id.HasValue AndAlso CBool((g.Id = Id))))
            Return query
        End Function
    
        Public Function Genders_All() As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Gender)
            query = MyBase.CreateQuery(Of Global.ApplicationData.Implementation.Gender)("[Genders]").AsQueryable()
            Return query
        End Function
    
    #End Region

    #Region "Protected methods"
        Protected Overrides Function CreateObject(ByVal type As Global.System.Type) As Object
            If (type Is GetType(Global.ApplicationData.Implementation.Person)) Then
                Return New Global.ApplicationData.Implementation.Person
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.Gender)) Then
                Return New Global.ApplicationData.Implementation.Gender
            End If
    
            Return MyBase.CreateObject(type)
        End Function
    
        Protected Overrides Function CreateObjectContext() As Global.ApplicationData.Implementation.ApplicationDataObjectContext
            Return New Global.ApplicationData.Implementation.ApplicationDataObjectContext(MyBase.GetEntityConnectionString( _
                "_IntrinsicData", _
                "res://*/ApplicationData.csdl|res://*/ApplicationData.ssdl|res://*/ApplicationData.msl", _
                "System.Data.SqlClient"))
        End Function
    
        Protected Overrides Function CreateEntityImplementation(Of T As Global.Microsoft.LightSwitch.IEntityObject)() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Person)) Then
                Return New Global.ApplicationData.Implementation.Person()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Gender)) Then
                Return New Global.ApplicationData.Implementation.Gender()
            End If
            Return Nothing
        End Function
    
    #End Region
    
    End Class
    
    <Global.System.ServiceModel.DomainServices.Hosting.EnableClientAccess()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ReportDataServiceVBDataDomainService
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService(Of Global.ReportDataServiceVBData.Implementation.ReportDataServiceVBDataObjectContext)
    
        Public Sub New()
            MyBase.New()
        End Sub
    
    #Region "Public methods"
    
    #Region "ReportDataClass"
    
        Public Sub InsertReportDataClass(ByVal entity As Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.ReportDataClasses.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdateReportDataClass(ByVal currentEntity As Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.ReportDataClasses, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeleteReportDataClass(ByVal entity As Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ReportDataClasses.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Queries"
        Public Function ReportDataClasses_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Return Me.GetQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("ReportDataClasses_Single", frameworkOperators, Id)
        End Function
    
        Public Function ReportDataClasses_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Return Me.GetQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("ReportDataClasses_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function ReportDataClasses_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Return Me.GetQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("ReportDataClasses_All", frameworkOperators)
        End Function
    
    #End Region
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __GetEntitySetCanInformation(ByVal entitySetName as String) As Integer
            Return MyBase.GetEntitySetCanInformation(entitySetName)
        End Function
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __CanExecuteOperation(ByVal operationName as String) As Boolean
            Return MyBase.CanExecuteOperation(operationName)
        End Function
    
    #End Region
    
        Protected Overrides Function CreateDataService() As Global.Microsoft.LightSwitch.IDataService
            Return New Global.LightSwitchApplication.DataWorkspace().ReportDataServiceVBData
        End Function
    
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ReportDataServiceVBDataServiceImplementation
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.RiaDataServiceImplementation(Of Global.ReportDataServiceVBData.Implementation.ReportDataServiceVBDataObjectContext, Global.Central.Data.Services.ReportDataServiceVB)
    
        Public Sub New(ByVal dataService As Global.Microsoft.LightSwitch.IDataService)
            MyBase.New(dataService)
        End Sub
    
    #Region "Queries"
        Public Function ReportDataClasses_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Dim query As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("ReportDataClasses_All"), _
                Function(r) (Id.HasValue AndAlso CBool((r.Id = Id))))
            Return query
        End Function
    
        Public Function ReportDataClasses_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Dim query As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("ReportDataClasses_All"), _
                Function(r) (Id.HasValue AndAlso CBool((r.Id = Id))))
            Return query
        End Function
    
        Public Function ReportDataClasses_All() As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Dim query As Global.System.Linq.IQueryable(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            query = MyBase.CreateQuery(Of Global.ReportDataServiceVBData.Implementation.ReportDataClass)("GenderCount").AsQueryable()
            Return query
        End Function
    
    #End Region

    #Region "Protected methods"
        Protected Overrides Function CreateObject(ByVal type As Global.System.Type) As Object
            If (type Is GetType(Global.ReportDataServiceVBData.Implementation.ReportDataClass)) Then
                Return New Global.ReportDataServiceVBData.Implementation.ReportDataClass
            End If
    
            Return MyBase.CreateObject(type)
        End Function
    
        Protected Overrides Function CreateObjectContext() As Global.ReportDataServiceVBData.Implementation.ReportDataServiceVBDataObjectContext
            Return New Global.ReportDataServiceVBData.Implementation.ReportDataServiceVBDataObjectContext(MyBase.GetEntityConnectionString( _
                "ReportDataServiceVBData", _
                "res://*/ReportDataServiceVBData.csdl|res://*/ReportDataServiceVBData.ssdl|res://*/ReportDataServiceVBData.msl", _
                "System.Data.SqlClient"))
        End Function
    
        Protected Overrides Function CreateEntityImplementation(Of T As Global.Microsoft.LightSwitch.IEntityObject)() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.ReportDataClass)) Then
                Return New Global.ReportDataServiceVBData.Implementation.ReportDataClass()
            End If
            Return Nothing
        End Function
        Protected Overrides Function ConvertType(ByVal outerType As Global.System.Type) As Global.System.Type
            If (outerType Is GetType(Global.ReportDataServiceVBData.Implementation.ReportDataClass)) Then
                Return GetType(Global.Central.Data.Services.ReportDataClass)
            End If
            Return MyBase.ConvertType(outerType)
        End Function
    
        Protected Overrides Function ConvertEntity(ByVal outerEntity As Object) As Object
            Dim reportDataClass As Global.ReportDataServiceVBData.Implementation.ReportDataClass = TryCast(outerEntity, Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            If (Not reportDataClass Is Nothing) Then
                Dim result As New Global.Central.Data.Services.ReportDataClass
                result.Id = reportDataClass.Id
                result.Name = reportDataClass.Name
                result.Total = reportDataClass.Total
                Return result
            End If
            Return Nothing
        End Function
       
    
        Protected Overrides Sub UpdateResult(ByVal outerEntity As Object, ByVal innerResult As Object)
            Dim outerReportDataClass As Global.ReportDataServiceVBData.Implementation.ReportDataClass = TryCast(outerEntity, Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            Dim innerReportDataClass As Global.Central.Data.Services.ReportDataClass = TryCast(innerResult, Global.Central.Data.Services.ReportDataClass)
            If ((outerReportDataClass IsNot Nothing) AndAlso (innerReportDataClass IsNot Nothing)) Then
                outerReportDataClass.Id = innerReportDataClass.Id
                outerReportDataClass.Name = innerReportDataClass.Name
                outerReportDataClass.Total = innerReportDataClass.Total
                Return
            End If
        End Sub
    
    #End Region
    
    End Class
    
    #Region "DataServiceImplementationFactory"
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.IDataServiceFactory))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class DataServiceFactory
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    
        Protected Overrides Function CreateDataService(ByVal dataServiceType As Global.System.Type) As Global.Microsoft.LightSwitch.IDataService
            If dataServiceType.Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.ApplicationDataService()
            End If
            If dataServiceType.Equals(GetType(Global.LightSwitchApplication.ReportDataServiceVBData)) Then
                Return New Global.LightSwitchApplication.ReportDataServiceVBDataService()
            End If
            Return MyBase.CreateDataService(dataServiceType)
        End Function
    
        Protected Overrides Function CreateDataServiceImplementation(Of TDataService As Global.Microsoft.LightSwitch.IDataService)(ByVal dataService As TDataService) As Global.Microsoft.LightSwitch.Internal.IDataServiceImplementation
            If GetType(TDataService).Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService)
            End If
            If GetType(TDataService).Equals(GetType(Global.LightSwitchApplication.ReportDataServiceVBData)) Then
                Return New Global.LightSwitchApplication.Implementation.ReportDataServiceVBDataServiceImplementation(dataService)
            End If
            Return MyBase.CreateDataServiceImplementation(dataService)
        End Function
    End Class
    #End Region
    
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class __TypeMapping
        Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider
        Private Function GetImplementationType(ByVal definitionType As Global.System.Type) As Global.System.Type Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType
            If GetType(Global.LightSwitchApplication.Person).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Person)
            End If
            If GetType(Global.LightSwitchApplication.Gender).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Gender)
            End If
            If GetType(Global.LightSwitchApplication.ReportDataClass).Equals(definitionType)
                Return GetType(Global.ReportDataServiceVBData.Implementation.ReportDataClass)
            End If
            Return Nothing
        End Function
    End Class
End Namespace

Namespace ApplicationData.Implementation

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    <Global.System.ComponentModel.DataAnnotations.MetadataType(GetType(Global.ApplicationData.Implementation.Person.Metadata))> _
    Partial Public Class Person
        Implements Global.LightSwitchApplication.Person.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Person.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _NameImplementation() As String Implements Global.LightSwitchApplication.Person.DetailsClass.IImplementation.Name
            Get
                Return Me.Name
            End Get
            Set(ByVal value As String)
                Me.Name = value
            End Set
        End Property
        
        Private Property _GenderImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Person.DetailsClass.IImplementation.Gender
            Get
                Return Me.Gender
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Gender = DirectCast(value, Global.ApplicationData.Implementation.Gender)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Gender")
                End If
            End Set
        End Property
        
        Private Sub OnGender_PersonChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Gender")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
        
        Friend Class Metadata
        
            <Global.System.ServiceModel.DomainServices.Server.Include> _
            Public Property Gender As Global.ApplicationData.Implementation.Gender
        
        End Class
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Gender
        Implements Global.LightSwitchApplication.Gender.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Gender.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _GenderNameImplementation() As String Implements Global.LightSwitchApplication.Gender.DetailsClass.IImplementation.GenderName
            Get
                Return Me.GenderName
            End Get
            Set(ByVal value As String)
                Me.GenderName = value
            End Set
        End Property
        
        Private ReadOnly Property _PersonImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Gender.DetailsClass.IImplementation.Person
            Get
                Return Me.Person
            End Get
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
End Namespace

Namespace ReportDataServiceVBData.Implementation

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class ReportDataClass
        Implements Global.LightSwitchApplication.ReportDataClass.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.ReportDataClass.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _NameImplementation() As String Implements Global.LightSwitchApplication.ReportDataClass.DetailsClass.IImplementation.Name
            Get
                Return Me.Name
            End Get
            Set(ByVal value As String)
                Me.Name = value
            End Set
        End Property
        
        Private Property _TotalImplementation() As Decimal Implements Global.LightSwitchApplication.ReportDataClass.DetailsClass.IImplementation.Total
            Get
                Return Me.Total
            End Get
            Set(ByVal value As Decimal)
                Me.Total = value
            End Set
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
End Namespace

