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
    Friend WithEvents CallGetTypeButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CallGetTypeButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CallGetTypeButton
        '
        Me.CallGetTypeButton.Location = New System.Drawing.Point(72, 16)
        Me.CallGetTypeButton.Name = "CallGetTypeButton"
        Me.CallGetTypeButton.TabIndex = 0
        Me.CallGetTypeButton.Text = " Get Type"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 53)
        Me.Controls.Add(Me.CallGetTypeButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CallGetTypeButton_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
        Handles CallGetTypeButton.Click
        Try
            Dim theType As Type

            theType = Type.GetType( _
             "CallingGetType.Form1", True)
            MessageBox.Show("First type is " _
             & theType.FullName)

            theType = Type.GetType( _
            "System.Collections.Queue", True)
            MessageBox.Show("Second type is " _
             & theType.FullName)

            theType = Type.GetType( _
             "System.Windows.Forms.Form, " & _
                "System.Windows.Forms, " & _
                "Version=1.0.5000.0, " & _
                "Culture=neutral, " & _
                "PublicKeyToken=b77a5c561934e089", _
             True)

            MessageBox.Show("Third type is " _
             & theType.FullName)

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
