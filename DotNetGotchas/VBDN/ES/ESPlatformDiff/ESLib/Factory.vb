' Factory.vb part of ESLib.dll
Imports System.EnterpriseServices

<Transaction(TransactionOption.Required), JustInTimeActivation()> _
Public Class Factory
    Inherits ServicedComponent
    Public Function CreateComp(ByVal key As Integer) As Comp
        ContextUtil.MyTransactionVote = TransactionVote.Abort

        Dim theComp As New Comp

        theComp.init(key)

        ContextUtil.MyTransactionVote = TransactionVote.Commit

        Return theCOmp
    End Function
    Protected Overloads Overrides Sub Dispose( _
        ByVal disposing As Boolean)
        If disposing Then
            ContextUtil.DeactivateOnReturn = True
        End If

        MyBase.Dispose(disposing)
    End Sub
End Class
