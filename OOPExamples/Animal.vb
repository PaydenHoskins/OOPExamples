Public Class Animal

    Dim movement As String

    Sub New()
        Me.movement = "Animals can move.. except sponges..."
    End Sub

    Sub move()
        Console.WriteLine(Me.movement)
    End Sub

End Class
