Imports System.Threading

Public Class Test
    Public Sub Run()
        Dim object1 As MySingleton = MySingleton.GetInstance()

        Console.WriteLine("Object created at {0}", _
         object1.creationTime.ToLongTimeString())

        Thread.Sleep(1000)

        Dim object2 As MySingleton = MySingleton.GetInstance()
        Console.WriteLine("Object created at {0}", _
         object1.creationTime.ToLongTimeString())
    End Sub

    Public Shared Sub Main()
        Dim anObject As Test = New Test

        anObject.Run()
        Thread.Sleep(1000)

        Dim domain As AppDomain = _
           AppDomain.CreateDomain("MyDomain")

        Dim proxy As Test = _
          CType( _
              domain.CreateInstance( _
                System.Reflection. _
                Assembly.GetExecutingAssembly().FullName, _
                GetType(Test).FullName).Unwrap(), Test)

        proxy.Run()

        Thread.Sleep(1000)
        anObject.Run()
    End Sub
End Class
