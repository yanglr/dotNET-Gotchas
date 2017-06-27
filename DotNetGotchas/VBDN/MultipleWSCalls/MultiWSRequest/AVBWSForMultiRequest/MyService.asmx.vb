'MyService.asmx.vb part of AVBWSForMultiRequest.dll (Web Service)
Imports System.Web.Services

<System.Web.Services.WebService(Namespace:= _
    "http://tempuri.org/AVBWSForMultiRequest/MyService")> _
Public Class MyService
    Inherits System.Web.Services.WebService

#Region " Web Services Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Web Services Designer.
        InitializeComponent()

        'Add your own initialization code after the 
        'InitializeComponent() call

    End Sub

    'Required by the Web Services Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the 
    'Web Services Designer
    'It can be modified using the Web Services Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

    Protected Overloads Overrides Sub Dispose( _
        ByVal disposing As Boolean)
        'CODEGEN: This procedure is required by the 
        'Web Services Designer
        'Do not modify it using the code editor.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    '<WebMethod(True)> _
    <WebMethod()> _
    Public Function Method1(ByVal val As Integer) As String
        System.Threading.Thread.Sleep(5000)
        Return val.ToString()
    End Function
End Class
