'Test.vb
Imports NUnit.Framework

<TestFixture()> _
Public Class Test
    Private calc As Calculator

    <SetUp()> _
    Public Sub Setup()
        calc = New Calculator
    End Sub

    <Test()> _
    Public Sub TestSimpleDivide()
        Assert.AreEqual(2, calc.Divide(4, 2))
    End Sub
    <Test(), ExpectedException(GetType(DivideByZeroException))> _
  Public Sub TestDivisionByZero()
        calc.Divide(4, 0)
    End Sub
End Class
