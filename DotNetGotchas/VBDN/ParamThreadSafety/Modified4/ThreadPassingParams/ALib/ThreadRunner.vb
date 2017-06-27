'ThreadRunner.vb

Imports System.Reflection
Imports System.Threading

Public Class ThreadRunnerException
    Inherits ApplicationException

    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class ThreadRunner
    Private toRunDelegate As System.Delegate

    Private toRunParameters() As Object

    Private theThread As Thread

    Public Property IsBackground() As Boolean
        Get
            Return theThread.IsBackground
        End Get
        Set(ByVal Value As Boolean)
            theThread.IsBackground = Value
        End Set
    End Property

    Public Sub New( _
        ByVal theDelegate As System.Delegate, _
        ByVal ParamArray theParameters() As Object)

        Dim theMethod As MethodInfo = theDelegate.Method

        Dim theParameterInfo() As ParameterInfo _
        = theMethod.GetParameters()

        If theParameterInfo.Length <> theParameters.Length Then
            Dim message As String = String.Format( _
                    "Invalid number of parameters - ")

            message &= String.Format( _
                        "expected {0} received {1}", _
                        theParameterInfo.Length, _
                        theParameters.Length)
        End If

        For i As Integer = 0 To theParameterInfo.Length - 1
            If Not _
            theParameterInfo(i).ParameterType.IsInstanceOfType( _
                        theParameters(i)) Then
                Dim message As String = String.Format( _
                             "Parameter {0} type mismatch - ", i)

                message &= String.Format( _
                        "Expected {0} received {1}", _
                        theParameterInfo(i).ParameterType.FullName, _
                        theParameters(i).GetType().FullName)

                Throw New ThreadRunnerException(message)
            End If

        Next

        toRunDelegate = theDelegate
        toRunParameters = theParameters

        theThread = New Thread(AddressOf Run)
    End Sub

    Public Sub Start()
        theThread.Start()
    End Sub

    Private Sub Run()
        toRunDelegate.DynamicInvoke(toRunParameters)
    End Sub
End Class
