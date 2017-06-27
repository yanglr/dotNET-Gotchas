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
    Friend WithEvents DelegateButton As System.Windows.Forms.Button
    Friend WithEvents TimersTimerButton As System.Windows.Forms.Button
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents ExecutingThreadLabel As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents MainThreadLabel As System.Windows.Forms.Label
    Friend WithEvents TimerButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DelegateButton = New System.Windows.Forms.Button
        Me.TimersTimerButton = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.ExecutingThreadLabel = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.MainThreadLabel = New System.Windows.Forms.Label
        Me.TimerButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DelegateButton
        '
        Me.DelegateButton.Location = New System.Drawing.Point(200, 96)
        Me.DelegateButton.Name = "DelegateButton"
        Me.DelegateButton.Size = New System.Drawing.Size(80, 23)
        Me.DelegateButton.TabIndex = 13
        Me.DelegateButton.Text = "Delegate"
        '
        'TimersTimerButton
        '
        Me.TimersTimerButton.Location = New System.Drawing.Point(104, 96)
        Me.TimersTimerButton.Name = "TimersTimerButton"
        Me.TimersTimerButton.Size = New System.Drawing.Size(80, 23)
        Me.TimersTimerButton.TabIndex = 12
        Me.TimersTimerButton.Text = "Timers Timer"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(96, 23)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Executing Thread"
        '
        'ExecutingThreadLabel
        '
        Me.ExecutingThreadLabel.Location = New System.Drawing.Point(112, 56)
        Me.ExecutingThreadLabel.Name = "ExecutingThreadLabel"
        Me.ExecutingThreadLabel.Size = New System.Drawing.Size(160, 23)
        Me.ExecutingThreadLabel.TabIndex = 10
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 23)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Main Thread"
        '
        'MainThreadLabel
        '
        Me.MainThreadLabel.Location = New System.Drawing.Point(112, 16)
        Me.MainThreadLabel.Name = "MainThreadLabel"
        Me.MainThreadLabel.TabIndex = 8
        '
        'TimerButton
        '
        Me.TimerButton.Location = New System.Drawing.Point(16, 96)
        Me.TimerButton.Name = "TimerButton"
        Me.TimerButton.TabIndex = 7
        Me.TimerButton.Text = "Timer"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 133)
        Me.Controls.Add(Me.DelegateButton)
        Me.Controls.Add(Me.TimersTimerButton)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ExecutingThreadLabel)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.MainThreadLabel)
        Me.Controls.Add(Me.TimerButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        MainThreadLabel.Text _
            = AppDomain.GetCurrentThreadId().ToString()
    End Sub

    Private Delegate Sub SetLabelDelegate(ByVal message As String)

    Private Sub SetExecutingThreadLabel(ByVal message As String)
        If ExecutingThreadLabel.InvokeRequired Then
            'MessageBox.Show("Jumping thread to display " & message)
            Invoke(New SetLabelDelegate( _
                    AddressOf SetExecutingThreadLabel), _
                    New Object() {message})
        Else
            ExecutingThreadLabel.Text = message
        End If
    End Sub

    Private Sub TimerButton_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) _
        Handles TimerButton.Click
        Dim theTimer As Timer = New Timer
        theTimer.Interval = 1000
        AddHandler theTimer.Tick, _
            New EventHandler(AddressOf Timer_Tick)
        theTimer.Start()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, _
        ByVal e As EventArgs)
        CType(sender, Timer).Stop()

        SetExecutingThreadLabel( _
          "Timer : " _
          & AppDomain.GetCurrentThreadId() & ": " _
          & InvokeRequired)
    End Sub

    Private Sub TimersTimerButton_Click( _
        ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles TimersTimerButton.Click
        Dim theTimer As System.Timers.Timer = _
            New System.Timers.Timer(1000)

        AddHandler theTimer.Elapsed, _
            New System.Timers.ElapsedEventHandler( _
                AddressOf Timer_Elapsed)

        theTimer.Start()
    End Sub

    Private Sub Timer_Elapsed( _
    ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        CType(sender, System.Timers.Timer).Stop()

        SetExecutingThreadLabel( _
          "Timers.Timer : " _
          & AppDomain.GetCurrentThreadId() & ": " _
          & InvokeRequired)

    End Sub

    Private Delegate Sub AsynchDelegate()

    Private Sub DelegateButton_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles DelegateButton.Click
        Dim dlg As AsynchDelegate _
            = New AsynchDelegate(AddressOf AsynchExecuted)
        dlg.BeginInvoke(Nothing, Nothing)
    End Sub

    Private Sub AsynchExecuted()
        SetExecutingThreadLabel( _
          "Delegate : " _
          & AppDomain.GetCurrentThreadId() & ": " _
          & InvokeRequired)
    End Sub

End Class
