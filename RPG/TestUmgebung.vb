Public Class TestUmgebung
    Inherits Scene

    Public Sub New()
        Me.Visible = True
        Me.Enabled = True
       
    End Sub
    Public Overrides Sub createElements()
        Me.Controls.Clear()
        Me.Controls.Add(Memory.PLAYER)
        Memory.PLAYER.Focus()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        
        MyBase.OnPaint(e)
    End Sub
End Class
