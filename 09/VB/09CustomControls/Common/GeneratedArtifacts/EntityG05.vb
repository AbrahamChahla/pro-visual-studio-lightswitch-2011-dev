
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

Imports __Order = LightSwitchApplication.Order

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    Public NotInheritable Partial Class Order
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Order, __Order.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Order entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Order))
            MyBase.New(entitySet)
            
            __Order.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Order_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Order_AllowSaveWithErrors(ByRef result As Boolean)
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
                Return __Order.DetailsClass.GetValue(Me, __Order.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __Order.DetailsClass.SetValue(Me, __Order.DetailsClass.PropertySetProperties.Id, Value)
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
        Public Property OrderDesc As String
            Get
                Return __Order.DetailsClass.GetValue(Me, __Order.DetailsClass.PropertySetProperties.OrderDesc)
            End Get
            Set
                __Order.DetailsClass.SetValue(Me, __Order.DetailsClass.PropertySetProperties.OrderDesc, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDesc_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDesc_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDesc_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property OrderDate As Date
            Get
                Return __Order.DetailsClass.GetValue(Me, __Order.DetailsClass.PropertySetProperties.OrderDate)
            End Get
            Set
                __Order.DetailsClass.SetValue(Me, __Order.DetailsClass.PropertySetProperties.OrderDate, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDate_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDate_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OrderDate_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Customer As Global.LightSwitchApplication.Customer
            Get
                Return __Order.DetailsClass.GetValue(Me, __Order.DetailsClass.PropertySetProperties.Customer)
            End Get
            Set
                __Order.DetailsClass.SetValue(Me, __Order.DetailsClass.PropertySetProperties.Customer, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Customer_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Customer_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Customer_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Order, _
                __Order.DetailsClass, _
                __Order.DetailsClass.IImplementation, _
                __Order.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Order, __Order.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Order, __Order.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Order.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __OrderEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Order, __Order.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Order, __Order.DetailsClass).Entry( _
                    AddressOf __Order.DetailsClass.__Order_CreateNew, _
                    AddressOf __Order.DetailsClass.__Order_Created, _
                    AddressOf __Order.DetailsClass.__Order_AllowSaveWithErrors)
            Private Shared Function __Order_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Order)) As __Order
                Return New __Order(es)
            End Function
            Private Shared Sub __Order_Created(e As __Order)
                e.Order_Created()
            End Sub
            Private Shared Function __Order_AllowSaveWithErrors(e As __Order) As Boolean
                Dim result As Boolean = False
                e.Order_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Order, __Order.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Order, __Order.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Order.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Order, __Order.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Order.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property OrderDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Order.DetailsClass.PropertySetProperties.OrderDesc),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property OrderDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Order.DetailsClass.PropertySetProperties.OrderDate),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date))
                    End Get
                End Property
                
                Public ReadOnly Property Customer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Order.DetailsClass.PropertySetProperties.Customer),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property OrderDesc As String
                Shadows Property OrderDate As Date
                Shadows Property Customer As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Order.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer).Data), d As __Order.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __Order) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __Order, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __Order.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __Order.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __Order)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly OrderDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String).Entry( _
                        "OrderDesc", _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_Stub, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_ComputeIsReadOnly, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_Validate, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_GetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_SetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDesc_OnValueChanged)
                Private Shared Sub _OrderDesc_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Order.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String).Data), d As __Order.DetailsClass, sf As Object)
                    c(d, d._OrderDesc, sf)
                End Sub
                Private Shared Function _OrderDesc_ComputeIsReadOnly(e As __Order) As Boolean
                    Dim result As Boolean = False
                    e.OrderDesc_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _OrderDesc_Validate(e As __Order, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.OrderDesc_Validate(r)
                End Sub
                Private Shared Function _OrderDesc_GetImplementationValue(d As __Order.DetailsClass) As String
                    Return d.ImplementationEntity.OrderDesc
                End Function
                Private Shared Sub _OrderDesc_SetImplementationValue(d As __Order.DetailsClass, v As String)
                    d.ImplementationEntity.OrderDesc = v
                End Sub
                Private Shared Sub _OrderDesc_OnValueChanged(e As __Order)
                    e.OrderDesc_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly OrderDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date).Entry( _
                        "OrderDate", _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_Stub, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_ComputeIsReadOnly, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_Validate, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_GetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_SetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._OrderDate_OnValueChanged)
                Private Shared Sub _OrderDate_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Order.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date).Data), d As __Order.DetailsClass, sf As Object)
                    c(d, d._OrderDate, sf)
                End Sub
                Private Shared Function _OrderDate_ComputeIsReadOnly(e As __Order) As Boolean
                    Dim result As Boolean = False
                    e.OrderDate_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _OrderDate_Validate(e As __Order, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.OrderDate_Validate(r)
                End Sub
                Private Shared Function _OrderDate_GetImplementationValue(d As __Order.DetailsClass) As Date
                    Return d.ImplementationEntity.OrderDate
                End Function
                Private Shared Sub _OrderDate_SetImplementationValue(d As __Order.DetailsClass, v As Date)
                    d.ImplementationEntity.OrderDate = __Order.DetailsClass.ClearDateTimeKind(v)
                End Sub
                Private Shared Sub _OrderDate_OnValueChanged(e As __Order)
                    e.OrderDate_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Customer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer).Entry( _
                        "Customer", _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_Stub, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_ComputeIsReadOnly, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_Validate, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_GetCoreImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_GetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_SetImplementationValue, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_Refresh, _
                        AddressOf __Order.DetailsClass.PropertySetProperties._Customer_OnValueChanged)
                Private Shared Sub _Customer_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Order.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer).Data), d As __Order.DetailsClass, sf As Object)
                    c(d, d._Customer, sf)
                End Sub
                Private Shared Function _Customer_ComputeIsReadOnly(e As __Order) As Boolean
                    Dim result As Boolean = False
                    e.Customer_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Customer_Validate(e As __Order, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Customer_Validate(r)
                End Sub
                Private Shared Function _Customer_GetCoreImplementationValue(d as __Order.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Customer
                End Function
                Private Shared Function _Customer_GetImplementationValue(d as __Order.DetailsClass) As Global.LightSwitchApplication.Customer
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Customer, Global.LightSwitchApplication.Customer.DetailsClass)(__Order.DetailsClass.PropertySetProperties.Customer, d._Customer)
                End Function
                Private Shared Sub _Customer_SetImplementationValue(d As __Order.DetailsClass, v As Global.LightSwitchApplication.Customer)
                    d.SetImplementationValue(__Order.DetailsClass.PropertySetProperties.Customer, d._Customer, Sub(i, ev) i.Customer = ev, v)
                End Sub
                Private Shared Sub _Customer_Refresh(d As __Order.DetailsClass)
                    d.RefreshNavigationProperty(__Order.DetailsClass.PropertySetProperties.Customer, d._Customer)
                End Sub
                Private Shared Sub _Customer_OnValueChanged(e As __Order)
                    e.Customer_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _OrderDesc As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _OrderDate As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Order, __Order.DetailsClass, Date).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Customer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Order, __Order.DetailsClass, Global.LightSwitchApplication.Customer).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace