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

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Friend Module Application

        Public ReadOnly Property Current As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return TryCast(Global.Microsoft.LightSwitch.Framework.Base.ApplicationProvider.Current,
                    Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace))
            End Get
        End Property

    End Module

End Namespace
