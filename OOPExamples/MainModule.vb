Module MainModule

    Sub Main()
        'doSomethingInMainModule()
        'doSomethingInSecondModule()

        MsgBox($"{ExampleClass.sumOf(4, 3)}")

    End Sub

    Sub doSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub
End Module
