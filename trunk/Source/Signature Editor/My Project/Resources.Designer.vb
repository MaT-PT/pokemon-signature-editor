Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Signature_Editor.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = Value
            End Set
        End Property

        Friend ReadOnly Property Pause() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Pause", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property Pause_Pressed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Pause_Pressed", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property Play() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Play", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property Play_Pressed() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Play_Pressed", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_0s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_0s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_0s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_0s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_1s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_1s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_1s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_1s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_2s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_2s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_2s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_2s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_3s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_3s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_3s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_3s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_4s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_4s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_4s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_4s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_5s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_5s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_Black_5s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_Black_5s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_0s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_0s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_1s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_1s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_2s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_2s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_3s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_3s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_4s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_4s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_DPPt_5s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_DPPt_5s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_0s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_0s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_1s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_1s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_2s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_2s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_3s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_3s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_4s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_4s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_HGSS_5s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_HGSS_5s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_0s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_0s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_0s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_0s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_1s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_1s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_1s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_1s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_2s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_2s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_2s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_2s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_3s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_3s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_3s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_3s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_4s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_4s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_4s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_4s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_5s() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_5s", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property TC_White_5s_half() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("TC_White_5s_half", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        Friend ReadOnly Property Zuruggu_Anim() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Zuruggu_Anim", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
