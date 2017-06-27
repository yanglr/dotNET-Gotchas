Option Strict Off

Module Program

    Sub Main()
        Dim theComType As Type = _
            Type.GetTypeFromProgID("eBank.Account")

        Dim theComponent As Object = _
            Activator.CreateInstance(theComType)

        Console.WriteLine("Balance = {0}", _
            theComponent.balance)

        Console.WriteLine("Depositing $100")
        theComponent.deposit("deposit", 100)

        Console.WriteLine("Balance = {0}", _
            theComponent.balance)

    End Sub

End Module
