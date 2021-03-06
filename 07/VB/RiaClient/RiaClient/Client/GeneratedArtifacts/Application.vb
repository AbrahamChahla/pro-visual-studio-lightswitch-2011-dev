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

Namespace LightSwitchApplication

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    Partial Public NotInheritable Class Application
        Inherits Global.Microsoft.LightSwitch.Framework.Client.ClientApplication(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass, Global.LightSwitchApplication.DataWorkspace)

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(ByVal applicationDefinition As Global.Microsoft.LightSwitch.Model.IApplicationDefinition)
            MyBase.New(applicationDefinition)

            Global.LightSwitchApplication.Application.DetailsClass.Initialize(Me)
        End Sub

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Partial Private Sub Application_Initialize()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Application_LoggedIn()
        End Sub
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Shared Shadows ReadOnly Property Current As Global.LightSwitchApplication.Application
            Get
                Return DirectCast(Global.Microsoft.LightSwitch.Framework.Client.ClientApplication(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Current, Global.LightSwitchApplication.Application)
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EditableGendersGrid_CanRun(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EditableGendersGrid_Run(ByRef handled As Boolean)
        End Sub
    
        ''' <summary>
        ''' Opens the ShowEditableGendersGrid screen.  If the screen is already opened, it is activated and shown.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub ShowEditableGendersGrid()
            DirectCast(Me.Details, Global.Microsoft.LightSwitch.Details.Client.IClientApplicationDetails).InvokeMethod(Me.Details.Methods.ShowEditableGendersGrid)
        End Sub
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EditablePeopleGrid_CanRun(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EditablePeopleGrid_Run(ByRef handled As Boolean)
        End Sub
    
        ''' <summary>
        ''' Opens the ShowEditablePeopleGrid screen.  If the screen is already opened, it is activated and shown.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub ShowEditablePeopleGrid()
            DirectCast(Me.Details, Global.Microsoft.LightSwitch.Details.Client.IClientApplicationDetails).InvokeMethod(Me.Details.Methods.ShowEditablePeopleGrid)
        End Sub
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RIAAggregationExample_CanRun(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RIAAggregationExample_Run(ByRef handled As Boolean)
        End Sub
    
        ''' <summary>
        ''' Opens the ShowRIAAggregationExample screen.  If the screen is already opened, it is activated and shown.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub ShowRIAAggregationExample()
            DirectCast(Me.Details, Global.Microsoft.LightSwitch.Details.Client.IClientApplicationDetails).InvokeMethod(Me.Details.Methods.ShowRIAAggregationExample)
        End Sub
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass, Global.LightSwitchApplication.Application.DetailsClass.PropertySet, Global.LightSwitchApplication.Application.DetailsClass.CommandSet, Global.LightSwitchApplication.Application.DetailsClass.MethodSet)

            Shared Sub New()
                Dim initializeCommandEntry = Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowEditableGendersGrid
                Dim initializeMethodEntry = Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowEditableGendersGrid
            End Sub

            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __ApplicationEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationDetails(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.__Application_Initialized, _
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.__Application_LoggedIn)
            Private Shared Sub __Application_Initialized(a As Global.LightSwitchApplication.Application)
                a.Application_Initialize()
            End Sub
            Private Shared Sub __Application_LoggedIn(a As Global.LightSwitchApplication.Application)
                a.Application_LoggedIn()
            End Sub

            Public Sub New()
                MyBase.New()
            End Sub

            Public Shadows ReadOnly Property Properties As Global.LightSwitchApplication.Application.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property

            Public Shadows ReadOnly Property Commands As Global.LightSwitchApplication.Application.DetailsClass.CommandSet
                Get
                    Return MyBase.Commands
                End Get
            End Property

            Public Shadows ReadOnly Property Methods As Global.LightSwitchApplication.Application.DetailsClass.MethodSet
                Get
                    Return MyBase.Methods
                End Get
            End Property

            Protected Overrides Function CreateScreen(ByVal screenName As String, ByVal ParamArray args() As Object) As Global.Microsoft.LightSwitch.Client.IScreenObject
                Select Case screenName
                    Case "EditableGendersGrid"
                        Return Global.LightSwitchApplication.EditableGendersGrid.CreateInstance()
                    Case "EditablePeopleGrid"
                        Return Global.LightSwitchApplication.EditablePeopleGrid.CreateInstance()
                    Case "RIAAggregationExample"
                        Return Global.LightSwitchApplication.RIAAggregationExample.CreateInstance()
                End Select
            
                Return MyBase.CreateScreen(screenName, args)
            End Function
            
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationPropertySet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class CommandSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationCommandSet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

                Public ReadOnly Property ShowEditableGendersGrid As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowEditableGendersGrid), Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

                Public ReadOnly Property ShowEditablePeopleGrid As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowEditablePeopleGrid), Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

                Public ReadOnly Property ShowRIAAggregationExample As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties.ShowRIAAggregationExample), Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class MethodSet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Client.ClientApplicationMethodSet(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)

                Public ReadOnly Property ShowEditableGendersGrid As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowEditableGendersGrid), Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

                Public ReadOnly Property ShowEditablePeopleGrid As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowEditablePeopleGrid), Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

                Public ReadOnly Property ShowRIAAggregationExample As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass)
                    Get
                        Return DirectCast(MyBase.GetItem(Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties.ShowRIAAggregationExample), Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass))
                    End Get
                End Property

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class PropertySetProperties

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class CommandSetProperties

                Public Shared ReadOnly ShowEditableGendersGrid As New Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowEditableGendersGrid",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowEditableGendersGrid_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowEditableGendersGrid_CreateExecutableObject)
                Private Shared Sub _ShowEditableGendersGrid_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowEditableGendersGridCommand, sf)
                End Sub
                Private Shared Function _ShowEditableGendersGrid_CreateExecutableObject(d As Global.LightSwitchApplication.Application.DetailsClass) As Global.Microsoft.LightSwitch.IExecutable
                    Return DirectCast(d, Global.LightSwitchApplication.Application.DetailsClass).Methods.ShowEditableGendersGrid.CreateInvocation(New Object(0 - 1) { })
                End Function

                Public Shared ReadOnly ShowEditablePeopleGrid As New Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowEditablePeopleGrid",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowEditablePeopleGrid_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowEditablePeopleGrid_CreateExecutableObject)
                Private Shared Sub _ShowEditablePeopleGrid_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowEditablePeopleGridCommand, sf)
                End Sub
                Private Shared Function _ShowEditablePeopleGrid_CreateExecutableObject(d As Global.LightSwitchApplication.Application.DetailsClass) As Global.Microsoft.LightSwitch.IExecutable
                    Return DirectCast(d, Global.LightSwitchApplication.Application.DetailsClass).Methods.ShowEditablePeopleGrid.CreateInvocation(New Object(0 - 1) { })
                End Function

                Public Shared ReadOnly ShowRIAAggregationExample As New Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowRIAAggregationExample",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowRIAAggregationExample_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.CommandSetProperties._ShowRIAAggregationExample_CreateExecutableObject)
                Private Shared Sub _ShowRIAAggregationExample_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowRIAAggregationExampleCommand, sf)
                End Sub
                Private Shared Function _ShowRIAAggregationExample_CreateExecutableObject(d As Global.LightSwitchApplication.Application.DetailsClass) As Global.Microsoft.LightSwitch.IExecutable
                    Return DirectCast(d, Global.LightSwitchApplication.Application.DetailsClass).Methods.ShowRIAAggregationExample.CreateInvocation(New Object(0 - 1) { })
                End Function

            End Class

            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend NotInheritable Class MethodSetProperties

                Public Shared ReadOnly ShowEditableGendersGrid As New Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowEditableGendersGrid",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditableGendersGrid_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditableGendersGrid_CanInvoke,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditableGendersGrid_InvokeMethod)
                Private Shared Sub _ShowEditableGendersGrid_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowEditableGendersGridMethod, sf)
                End Sub
                Private Shared Function _ShowEditableGendersGrid_CanInvoke(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object), ex As Global.System.Exception) As Global.System.Exception
                    Dim result As Boolean = True
                    d.Application.EditableGendersGrid_CanRun(result)
                    Return If(result, Nothing, ex)
                End Function
                Private Shared Sub _ShowEditableGendersGrid_InvokeMethod(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object))
                    Dim handled As Boolean = False
                    d.Application.EditableGendersGrid_Run(handled)
                    If Not handled Then
                        d.ShowScreen("LightSwitchApplication:EditableGendersGrid", Function() Global.LightSwitchApplication.EditableGendersGrid.CreateInstance(), args)
                    End If
                End Sub
 
                Public Shared ReadOnly ShowEditablePeopleGrid As New Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowEditablePeopleGrid",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditablePeopleGrid_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditablePeopleGrid_CanInvoke,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowEditablePeopleGrid_InvokeMethod)
                Private Shared Sub _ShowEditablePeopleGrid_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowEditablePeopleGridMethod, sf)
                End Sub
                Private Shared Function _ShowEditablePeopleGrid_CanInvoke(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object), ex As Global.System.Exception) As Global.System.Exception
                    Dim result As Boolean = True
                    d.Application.EditablePeopleGrid_CanRun(result)
                    Return If(result, Nothing, ex)
                End Function
                Private Shared Sub _ShowEditablePeopleGrid_InvokeMethod(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object))
                    Dim handled As Boolean = False
                    d.Application.EditablePeopleGrid_Run(handled)
                    If Not handled Then
                        d.ShowScreen("LightSwitchApplication:EditablePeopleGrid", Function() Global.LightSwitchApplication.EditablePeopleGrid.CreateInstance(), args)
                    End If
                End Sub
 
                Public Shared ReadOnly ShowRIAAggregationExample As New Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Entry( _
                    "ShowRIAAggregationExample",
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowRIAAggregationExample_Stub,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowRIAAggregationExample_CanInvoke,
                    AddressOf Global.LightSwitchApplication.Application.DetailsClass.MethodSetProperties._ShowRIAAggregationExample_InvokeMethod)
                Private Shared Sub _ShowRIAAggregationExample_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of Global.LightSwitchApplication.Application.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data), d As Global.LightSwitchApplication.Application.DetailsClass, sf As Object)
                    c(d, d._ShowRIAAggregationExampleMethod, sf)
                End Sub
                Private Shared Function _ShowRIAAggregationExample_CanInvoke(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object), ex As Global.System.Exception) As Global.System.Exception
                    Dim result As Boolean = True
                    d.Application.RIAAggregationExample_CanRun(result)
                    Return If(result, Nothing, ex)
                End Function
                Private Shared Sub _ShowRIAAggregationExample_InvokeMethod(d As Global.LightSwitchApplication.Application.DetailsClass, args As Global.System.Collections.ObjectModel.ReadOnlyCollection(Of Object))
                    Dim handled As Boolean = False
                    d.Application.RIAAggregationExample_Run(handled)
                    If Not handled Then
                        d.ShowScreen("LightSwitchApplication:RIAAggregationExample", Function() Global.LightSwitchApplication.RIAAggregationExample.CreateInstance(), args)
                    End If
                End Sub
 
            End Class

            Private _ShowEditableGendersGridMethod As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

            Private _ShowEditablePeopleGridMethod As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

            Private _ShowRIAAggregationExampleMethod As Global.Microsoft.LightSwitch.Details.Framework.ApplicationMethod(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

            Private _ShowEditableGendersGridCommand As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

            Private _ShowEditablePeopleGridCommand As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

            Private _ShowRIAAggregationExampleCommand As Global.Microsoft.LightSwitch.Details.Framework.Base.ApplicationCommand(Of Global.LightSwitchApplication.Application, Global.LightSwitchApplication.Application.DetailsClass).Data

        End Class

    End Class

End Namespace
