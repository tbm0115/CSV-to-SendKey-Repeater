﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CSV_to_SendKey_Repeater.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE HTML&gt;
        '''&lt;!-- saved from url=(0090)https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys.send(v=vs.110).aspx --&gt;
        '''&lt;!DOCTYPE html PUBLIC &quot;&quot; &quot;&quot;&gt;&lt;HTML lang=&quot;en&quot; dir=&quot;ltr&quot; xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;&lt;HEAD&gt;&lt;META 
        '''content=&quot;IE=11.0000&quot; http-equiv=&quot;X-UA-Compatible&quot;&gt;
        '''&lt;META http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=utf-8&quot;&gt;
        '''&lt;STYLE&gt;
        '''table{border-collapse:collapse;}
        '''td{border:1px solid black;padding: 5px;}
        '''&lt;/STYLE&gt;
        '''&lt;/HEAD&gt;
        '''&lt;BODY&gt;
        '''&lt;TABLE responsive=&quot;true&quot;&gt;
        '''&lt;P&gt;To sp [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Send_Keys() As String
            Get
                Return ResourceManager.GetString("Send_Keys", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
