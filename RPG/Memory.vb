Public Class Memory

    Private Shared _bilder As New Dictionary(Of String, Image)
    Private Shared _sounds As New Dictionary(Of String, Byte())
    Private Shared _scenes As New Dictionary(Of String, Scene)
    Private Shared _system As New Dictionary(Of String, String)
    Private Shared _player As New Player
    Private Shared _frame As Form
    Private Shared _worlds As New Dictionary(Of String, World)
    Private Shared _tilesets As New Dictionary(Of String, TileSet)



    Public Shared Property FRAME As Form
        Get
            Return _frame
        End Get
        Set(value As Form)
            _frame = value
        End Set
    End Property

    Public Shared ReadOnly Property TILESET(key As String) As TileSet
        Get
            Return _tilesets(key)
        End Get
    End Property

    Public Shared ReadOnly Property WORLDS(key As String) As World
        Get
            Return _worlds(key)
        End Get
    End Property

    Public Shared ReadOnly Property SYSTEM(ByVal key As String) As String
        Get
            Return _system(key)
        End Get
    End Property

    Public Shared ReadOnly Property BILDER(key As String) As Image
        Get
            Return _bilder(key)
        End Get
    End Property

    Public Shared Property PLAYER As Player
        Get
            Return _player
        End Get
        Set(value As Player)
            _player = value
        End Set
    End Property

    Public Shared ReadOnly Property SOUNDS(key As String) As Byte()
        Get
            Return _sounds(key)
        End Get
    End Property

    Public Shared ReadOnly Property SCENES(key As String) As Scene
        Get
            Return _scenes(key)
        End Get
    End Property

    Public Shared Sub init()
        initSystem()
        initBilder()
        initScenes()
        initTileSets()
        initWorlds()

    End Sub

    Private Shared Sub initSystem()
        _system.Add("width", "800")
        _system.Add("height", "600")
        _system.Add("tilesets-pfad", ".\res\tilesets")
        _system.Add("worlds-pfad", ".\res\worlddata")
    End Sub

    Private Shared Sub initBilder()
        _bilder.Add("title-image", Image.FromFile(".\res\title.jpg"))
        _bilder.Add("menu", Image.FromFile(".\res\menu.jpg"))
    End Sub

    Private Shared Sub initTileSets()
        Dim dInfo As New IO.DirectoryInfo(Memory.SYSTEM("tilesets-pfad"))
        For Each e As IO.FileInfo In dInfo.GetFiles
            Try
                Dim x As Bitmap = Bitmap.FromFile(e.FullName)
                Dim str As String = ""
                For i As Integer = 0 To e.Name.Length - 5
                    str &= e.Name.ToCharArray()(i)
                Next
                _tilesets.Add(str, New TileSet(e.FullName))

            Catch ex As Exception

            End Try
        Next

    End Sub

    Private Shared Sub initWorlds()
        Dim dInfo As New IO.DirectoryInfo(Memory.SYSTEM("worlds-pfad"))
        For Each e As IO.FileInfo In dInfo.GetFiles
            Try
                If (e.Extension = ".data") Then
                    Dim str As String = ""
                    For i As Integer = 0 To e.Name.Length - 6
                        str &= e.Name.ToCharArray()(i)
                    Next
                    _worlds.Add(str, New World(e.FullName))
                    Console.WriteLine(str)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Shared Sub initScenes()
        _scenes.Add("titel", New TitleScreen)
        _scenes.Add("menu", New MenuScreen)
        _scenes.Add("test", New TestUmgebung)
    End Sub






End Class
