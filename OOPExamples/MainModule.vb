Module MainModule

    Sub Main()
        'doSomethingInMainModule()
        'doSomethingInSecondModule()

        MsgBox($"{ExampleClass.sumOf(4, 3)}")

    End Sub

    ''' <summary>
    ''' Show a message box from within the main module.
    ''' </summary>
    Sub doSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub
End Module
