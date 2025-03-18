Module MainModule

    Sub Main()
        'doSomethingInMainModule()
        'doSomethingInSecondModule()
        'MsgBox($"{ExampleClass.sumOf(4, 3)}")

        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim nemo As New Fish

        pepe.movement = "shiver"
        pepe.skinType = "hairless rat"
        pepe.vocalization = "yip yip yip"
        pepe.move()
        pepe.Speak()

        lucky.move()

        jimmy.move()
        Console.WriteLine(jimmy.skinType)

        bob.move()

    End Sub

    ''' <summary>
    ''' Show a message box from within the main module.
    ''' </summary>
    Sub doSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub
End Module
