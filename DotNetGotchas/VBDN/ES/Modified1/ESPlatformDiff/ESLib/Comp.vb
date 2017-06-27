' Comp.vb part of ESLib.dll
Imports System.EnterpriseServices

<Transaction(TransactionOption.Required), JustInTimeActivation()> _
Public Class Comp
    Inherits ServicedComponent

    Private theKey As Integer
    Private theVal As Integer

    Private theTXNCoordinator As ITransactionCoordinator

    Friend Property TheTransactionCoordinator() _
        As ITransactionCoordinator
        Get
            Return theTXNCoordinator
        End Get
        Set(ByVal Value As ITransactionCoordinator)
            theTXNCoordinator = Value
        End Set
    End Property

    Friend Sub init(ByVal key As Integer)
        ContextUtil.MyTransactionVote = TransactionVote.Abort

        theKey = key
        theVal = key * 10

        ContextUtil.MyTransactionVote = TransactionVote.Commit
    End Sub


    Public Function GetValue() As Integer
        Return theVal
    End Function

    Public Sub SetValue(ByVal val As Integer)
        ContextUtil.MyTransactionVote = TransactionVote.Abort

        theVal = val

        If val < 0 Then
            ContextUtil.DeactivateOnReturn = True

            If Not theTXNCoordinator Is Nothing Then
                theTXNCoordinator.SetVoteToAbort()
            End If

            Throw New ApplicationException("Invalid value")
        End If

        ContextUtil.MyTransactionVote = TransactionVote.Commit
    End Sub
End Class
