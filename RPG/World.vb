Imports System.IO
Public Class World
    Inherits Panel

    Dim tileset As TileSet
    Dim dataPfad As String
    Dim _layer0(0, 0) As Integer
    Dim _layer1(0, 0) As Integer
    Dim _layer2(0, 0) As Integer
    Dim _eventlayer(0, 0) As String
    Dim groesse2 As Point


    Public Sub New(worldData As String)
        Me.Size = New Size(Memory.SYSTEM("width"), Memory.SYSTEM("height"))
        Me.dataPfad = worldData
        loadData()
    End Sub

    Private Sub loadData()
        Dim fs As New FileStream(dataPfad, FileMode.Open)
        Dim sr As New StreamReader(fs)
        tileset = Memory.TILESET(sr.ReadLine)
        Dim groesse As String = sr.ReadLine
        Dim data() As String = groesse.Split(";")
        Dim groess As Point = New Point(Integer.Parse(data(0)) - 1, Integer.Parse(data(1)) - 1)
        groesse2 = groess


        Dim layer0(groess.X, groess.Y) As Integer
        _layer0 = layer0
        _layer1 = layer0
        _layer2 = layer0
        Dim eventl(groess.X, groess.Y) As String
        _eventlayer = eventl

        Dim zeile As String = sr.ReadLine
        Dim i As Integer = 0

        'Layer 0
        While Not zeile = "" And Not zeile = "|"
            data = zeile.Split(";")
            For j As Integer = 0 To data.Length - 1
                _layer0(i, j) = Integer.Parse(data(j))
            Next
            i += 1
            zeile = sr.ReadLine
        End While

        ''Layer 1
        'i = 0
        'zeile = sr.ReadLine
        'While Not zeile = "" Or zeile = "|"
        '    data = zeile.Split(";")
        '    For j As Integer = 0 To data.Length
        '        _layer1(i, j) = Integer.Parse(data(j))
        '    Next
        '    i += 1
        '    zeile = sr.ReadLine
        'End While

        ''Layer 2
        'i = 0
        'zeile = sr.ReadLine
        'While Not zeile = "" Or zeile = "|"
        '    data = zeile.Split(";")
        '    For j As Integer = 0 To data.Length
        '        _layer2(i, j) = Integer.Parse(data(j))
        '    Next
        '    i += 1
        '    zeile = sr.ReadLine
        'End While

        ''EventLayer
        'i = 0
        'zeile = sr.ReadLine
        'While Not zeile = "" Or zeile = "|"
        '    data = zeile.Split(";")
        '    For j As Integer = 0 To data.Length
        '        eventl(i, j) = data(j)
        '    Next
        '    i += 1
        '    zeile = sr.ReadLine
        'End While

        Me.create()
      
    End Sub

    Private Sub create()
        Me.Controls.Clear()
        For i As Integer = 0 To groesse2.X
            For j As Integer = 0 To groesse2.Y
                Dim x As New Panel
                x.Size = New Size(Me.Size.Width / groesse2.X, Me.Size.Height / groesse2.Y)
                x.Location = New Point(i * x.Size.Width, j * x.Size.Height)
                x.BackgroundImageLayout = ImageLayout.Stretch
                x.BackgroundImage = tileset.getClip(_layer0(i, j))
                Me.Controls.Add(x)
            Next
        Next
    End Sub

End Class
