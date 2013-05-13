
Public Class Form1

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        CheckForIllegalCrossThreadCalls = False

        Me.Visible = True
        Memory.init()
        Memory.FRAME = Me
        Me.Size = New Size(Memory.SYSTEM("width"), Memory.SYSTEM("height"))

        Engine.switchScene("titel")



    End Sub
   

End Class
