Public Class Engine

    Public Shared Sub switchScene(ByVal sceneKey As String, Optional test As Boolean = False)
        Memory.FRAME.Controls.Clear()
        Memory.FRAME.Controls.Add(Memory.SCENES(sceneKey))
        If (test) Then
            Memory.SCENES(sceneKey).createElements()
        End If
    End Sub

    Public Shared Sub switchWorld(ByVal worldKey As String)
        Memory.FRAME.Controls.Clear()
        Memory.FRAME.Controls.Add(Memory.WORLDS(worldKey))
    End Sub

End Class
