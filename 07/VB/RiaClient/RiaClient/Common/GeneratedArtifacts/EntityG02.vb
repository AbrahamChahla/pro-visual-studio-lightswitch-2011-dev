
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

Imports __Gender = LightSwitchApplication.Gender

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    Public NotInheritable Partial Class Gender
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Gender, __Gender.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Gender entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Gender))
            MyBase.New(entitySet)
            
            __Gender.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Gender_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Gender_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __Gender.DetailsClass.GetValue(Me, __Gender.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __Gender.DetailsClass.SetValue(Me, __Gender.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property GenderName As String
            Get
                Return __Gender.DetailsClass.GetValue(Me, __Gender.DetailsClass.PropertySetProperties.GenderName)
            End Get
            Set
                __Gender.DetailsClass.SetValue(Me, __Gender.DetailsClass.PropertySetProperties.GenderName, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub GenderName_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub GenderName_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub GenderName_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property Person As Global.Microsoft.LightSwitch.Framework.EntityCollection(Of Global.LightSwitchApplication.Person)
            Get
                Return __Gender.DetailsClass.GetValue(Me, __Gender.DetailsClass.PropertySetProperties.Person)
            End Get
        End Property
        
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public ReadOnly Property PersonQuery As Microsoft.LightSwitch.IDataServiceQueryable(Of Global.LightSwitchApplication.Person)
            Get
                Return __Gender.DetailsClass.GetQuery(Me, __Gender.DetailsClass.PropertySetProperties.Person)
            End Get
        End Property

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Gender, _
                __Gender.DetailsClass, _
                __Gender.DetailsClass.IImplementation, _
                __Gender.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Gender, __Gender.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Gender, __Gender.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Gender.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __GenderEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Gender, __Gender.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Gender, __Gender.DetailsClass).Entry( _
                    AddressOf __Gender.DetailsClass.__Gender_CreateNew, _
                    AddressOf __Gender.DetailsClass.__Gender_Created, _
                    AddressOf __Gender.DetailsClass.__Gender_AllowSaveWithErrors)
            Private Shared Function __Gender_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Gender)) As __Gender
                Return New __Gender(es)
            End Function
            Private Shared Sub __Gender_Created(e As __Gender)
                e.Gender_Created()
            End Sub
            Private Shared Function __Gender_AllowSaveWithErrors(e As __Gender) As Boolean
                Dim result As Boolean = False
                e.Gender_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Gender, __Gender.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Gender, __Gender.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Gender.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Gender, __Gender.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Gender.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property GenderName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Gender.DetailsClass.PropertySetProperties.GenderName),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Person As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Gender.DetailsClass.PropertySetProperties.Person),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property GenderName As String
                Shadows ReadOnly Property Person As Global.System.Collections.IEnumerable
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Gender.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer).Data), d As __Gender.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __Gender) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __Gender, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __Gender.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __Gender.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __Gender)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly GenderName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String).Entry( _
                        "GenderName", _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_Stub, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_ComputeIsReadOnly, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_Validate, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_GetImplementationValue, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_SetImplementationValue, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._GenderName_OnValueChanged)
                Private Shared Sub _GenderName_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Gender.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String).Data), d As __Gender.DetailsClass, sf As Object)
                    c(d, d._GenderName, sf)
                End Sub
                Private Shared Function _GenderName_ComputeIsReadOnly(e As __Gender) As Boolean
                    Dim result As Boolean = False
                    e.GenderName_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _GenderName_Validate(e As __Gender, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.GenderName_Validate(r)
                End Sub
                Private Shared Function _GenderName_GetImplementationValue(d As __Gender.DetailsClass) As String
                    Return d.ImplementationEntity.GenderName
                End Function
                Private Shared Sub _GenderName_SetImplementationValue(d As __Gender.DetailsClass, v As String)
                    d.ImplementationEntity.GenderName = v
                End Sub
                Private Shared Sub _GenderName_OnValueChanged(e As __Gender)
                    e.GenderName_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Person As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person).Entry( _
                        "Person", _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Person_Stub, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Person_GetReferencedEntities, _
                        AddressOf __Gender.DetailsClass.PropertySetProperties._Person_GetEntityCollection)
                Private Shared Sub _Person_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Gender.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person).Data), d As __Gender.DetailsClass, sf As Object)
                    c(d, d._Person, sf)
                End Sub
                Private Shared Function _Person_GetReferencedEntities(d As __Gender.DetailsClass) As Global.System.Collections.Generic.IEnumerable(Of Global.LightSwitchApplication.Person)
                    Return d.GetReferencedEntities(Of Global.LightSwitchApplication.Person, Global.LightSwitchApplication.Person.DetailsClass)(__Gender.DetailsClass.PropertySetProperties.Person, d._Person)
                End Function
                Private Shared Function _Person_GetEntityCollection(d As __Gender.DetailsClass) As Global.System.Collections.IEnumerable
                    Return d.ImplementationEntity.Person
                End Function
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _GenderName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Gender, __Gender.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Person As Global.Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty(Of __Gender, __Gender.DetailsClass, Global.LightSwitchApplication.Person).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
