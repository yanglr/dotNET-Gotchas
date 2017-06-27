'Test.vb part of AClient.exe
Imports AClient.AVSWSForMultiRequest

Module Test

    Sub Main()
        Dim service As New MyService
        'service.CookieContainer = _
        ' New System.Net.CookieContainer

        service.Credentials = _
         System.Net.CredentialCache.DefaultCredentials

        Console.WriteLine( _
           "Making synchronous request at {0}", _
           DateTime.Now.ToLongTimeString())

        Console.WriteLine("Recevied {0} at {1}", _
         service.Method1(0), _
         DateTime.Now.ToLongTimeString())

        Console.WriteLine("Making two requests at {0}", _
         DateTime.Now.ToLongTimeString())

        service.BeginMethod1(1, _
            New AsyncCallback(AddressOf display), _
         service)

        service.BeginMethod1(2, _
            New AsyncCallback(AddressOf display), _
         service)

        Console.ReadLine()
    End Sub

    Private Sub display(ByVal handle As IAsyncResult)
        Dim theService As MyService = _
         CType(handle.AsyncState, MyService)

        Dim result As String = theService.EndMethod1(handle)

        Console.WriteLine("Result {0} received {1}", _
         result, DateTime.Now.ToLongTimeString())
    End Sub

End Module
