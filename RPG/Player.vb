Public Class Player
    Inherits Panel

    Private speed As Integer = 2
    Private moved As Boolean = False
    Public Sub New()
        Me.Size = New Size(50, 50)
        Me.Location = New Point(10, 10)
    End Sub

    Public Overloads ReadOnly Property CanFocus() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Brown, 0, 0, 50, 50)
        MyBase.OnPaint(e)
    End Sub



    Private Sub bewegenEnde(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        moved = False
    End Sub

    Private Sub bewegen(e As Keys)

        Select Case e
            Case Keys.Up
                Me.Location = New Point(Me.Location.X, Me.Location.Y - (speed))
            Case Keys.Left
                Me.Location = New Point(Me.Location.X - (speed), Me.Location.Y)
            Case Keys.Right
                Me.Location = New Point(Me.Location.X + (speed), Me.Location.Y)
            Case Keys.Down
                Me.Location = New Point(Me.Location.X, Me.Location.Y + (speed))
        End Select



    End Sub


    Private Sub bewegeStart(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        bewegen(e.KeyCode)
        e.Handled = True

    End Sub

End Class
