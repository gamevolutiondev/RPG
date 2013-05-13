Public Class TileSet

    Private images As New List(Of Image)
    Private pfad As String


    Public Sub New(pfad As String)
        Me.pfad = pfad
        cutImages()
    End Sub


    Private Sub cutImages()
        Dim x As Bitmap = Bitmap.FromFile(pfad)
        For i As Integer = 0 To 256 Step 16
            For j As Integer = 0 To 1120 Step 16
                images.Add(GetImageRectangle(x, i, j, 16, 16))
            Next
        Next
    End Sub

    Private Function GetImageRectangle(ByVal Bitmap As Bitmap, ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer) As Bitmap
        Dim bmp As New Bitmap(Width, Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(Bitmap, -X, -Y)
        End Using
        Return bmp
    End Function

    Public Function getClip(i As Integer) As Image
        Return images(i)
    End Function
End Class
