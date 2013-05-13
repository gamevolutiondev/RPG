Public Class TitleScreen
    Inherits Scene

    Dim WithEvents x As New Timer

    Public Sub New()
        BackgroundImageLayout = ImageLayout.Stretch
        BackgroundImage = Memory.BILDER("title-image")

        Dim lblText As New Label
        lblText.AutoSize = True
        lblText.Text = "TestTitel-Splashscreen"
        lblText.Font = New Font("Comic Sans MS", 20)
        lblText.Location = New Point(15, 15)
        Me.Controls.Add(lblText)
        x.Interval = 2000
        x.Start()
    End Sub

    

    Private Sub tauscheScene() Handles x.Tick
        Engine.switchScene("menu")
        x.Stop()
    End Sub

End Class
