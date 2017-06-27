'Employee.vb

Public Class Employee
    Public Sub New()
        Console.WriteLine("Employee's constructor called")

        Work()
    End Sub

    Public Overridable Sub Work()
        Console.WriteLine("Employee is working")
    End Sub
End Class
