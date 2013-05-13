Public Class Scene
    Inherits Panel

    Public Sub New()
        Me.Size = New Size(Memory.SYSTEM("width"), Memory.SYSTEM("height"))
        Me.Location = New Point(0, 0)
    End Sub

    Public Overridable Sub createElements()

    End Sub

End Class
