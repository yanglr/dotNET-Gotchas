Imports System.Threading
Imports ALibrary

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
    Friend WithEvents RunButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RunButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'RunButton
        '
        Me.RunButton.Location = New System.Drawing.Point(80, 16)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.TabIndex = 1
        Me.RunButton.Text = "Run"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 61)
        Me.Controls.Add(Me.RunButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared Sub Main()
        'AddHandler Application.ThreadException, _
        '    New ThreadExceptionEventHandler( _
        '    AddressOf Application_ThreadException)

        Application.Run(New Form1)
    End Sub

    Private Sub RunButton_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
        Handles RunButton.Click
        MessageBox.Show(New Utility().Operate(1, 0).ToString())
    End Sub

    Private Shared Sub Application_ThreadException( _
    ByVal sender As Object, _
    ByVal e As System.Threading.ThreadExceptionEventArgs)
        MessageBox.Show( _
         "Send the following to support: " & _
         e.Exception.ToString())
    End Sub
End Class
