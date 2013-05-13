Public Class MenuScreen
    Inherits Scene

    Public Sub New()
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Memory.BILDER("menu")
        Me.Controls.Add(getMenu)
    End Sub

    Private Function getMenu() As Panel
        Dim x As New Panel
        x.Size = New Size(250, 400)
        x.BackColor = Color.Transparent
        x.Location = New Point(10, 10)
        Dim cmdBeenden As New Button
        Dim cmdStartGame As New Button
        cmdBeenden.AutoSize = True
        cmdStartGame.AutoSize = True
        cmdBeenden.Text = "Beenden"
        cmdStartGame.Text = "Neues Spiel"
        cmdBeenden.Location = New Point(10, 40)
        cmdStartGame.Location = New Point(10, 10)
        AddHandler cmdBeenden.Click, AddressOf beenden
        AddHandler cmdStartGame.Click, AddressOf starteGame
        x.Controls.Add(cmdStartGame)
        x.Controls.Add(cmdBeenden)
        Return x
    End Function

    Private Sub starteGame()
        MsgBox("Starte Game xD")
        Engine.switchScene("test", True)
    End Sub

    Private Sub beenden()
        Try
            Memory.FRAME.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

End Class
