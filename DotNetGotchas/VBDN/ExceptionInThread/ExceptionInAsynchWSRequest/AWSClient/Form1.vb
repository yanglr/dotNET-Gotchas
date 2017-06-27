'Form1.vb part of AWSClient

Imports System.Threading
Imports AWSClient.AVBWebService

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents InvokeButton As System.Windows.Forms.Button
    Friend WithEvents AsynchCheckBox As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.InvokeButton = New System.Windows.Forms.Button
        Me.AsynchCheckBox = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'InvokeButton
        '
        Me.InvokeButton.Location = New System.Drawing.Point(176, 24)
        Me.InvokeButton.Name = "InvokeButton"
        Me.InvokeButton.TabIndex = 4
        Me.InvokeButton.Text = "Invoke"
        '
        'AsynchCheckBox
        '
        Me.AsynchCheckBox.Location = New System.Drawing.Point(24, 24)
        Me.AsynchCheckBox.Name = "AsynchCheckBox"
        Me.AsynchCheckBox.Size = New System.Drawing.Size(128, 24)
        Me.AsynchCheckBox.TabIndex = 3
        Me.AsynchCheckBox.Text = "Call Asynchronously"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 77)
        Me.Controls.Add(Me.InvokeButton)
        Me.Controls.Add(Me.AsynchCheckBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Shared service As MyService

    Private Sub InvokeButton_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles InvokeButton.Click

        service = New MyService
        service.Credentials = _
         System.Net.CredentialCache.DefaultCredentials

        If AsynchCheckBox.Checked Then
            CallAsynch()
        Else
            CallSynch()
        End If

    End Sub

    Private Shared Sub CallSynch()
        Dim result As Integer = service.Method1(1)
        MessageBox.Show("Result received: " & result)

        result = service.Method1(0)
        MessageBox.Show("Result received: " & result)
    End Sub

    Private Shared Sub CallAsynch()
        service.BeginMethod1(1, _
         New AsyncCallback(AddressOf response), service)

        Thread.Sleep(1000)

        service.BeginMethod1(0, _
         New AsyncCallback(AddressOf response), service)

        Thread.Sleep(1000)
    End Sub

    Private Shared Sub response(ByVal handle As IAsyncResult)
        Dim theService As MyService = _
            CType(handle.AsyncState, MyService)

        Try
            Dim result As Integer = theService.EndMethod1(handle)
            MessageBox.Show("Result received asynchronously " & _
                result)
        Catch ex As System.Web.Services.Protocols.SoapException
            MessageBox.Show("Now I got " & ex.ToString())
        End Try
    End Sub

End Class
