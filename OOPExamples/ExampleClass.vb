Public Class ExampleClass
    ''' <summary>
    ''' Takes two integers arguments and returns the sum
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns></returns>
    Shared Function sumOf(firstNumber As Integer, secondNumber As Integer) As Integer

        Return firstNumber + secondNumber
    End Function

    Public Sub DoSomthing()
        MsgBox("Hello")
    End Sub
End Class
