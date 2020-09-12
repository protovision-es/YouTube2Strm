Imports System.Net
Imports System.IO
Imports System.Text

Imports System.Threading

Public Class Form1

    Private ReportUseThread As Thread

    Dim UrlStream As String

    Dim UrlOrigen As String

    Dim Title As String

    Dim Thumb As Image

    Dim TextoClipboard As String


    Private Sub ReportUse()


        Dim WebClient As New System.Net.WebClient

        Dim htmldata() As Byte

        Dim vars As String = ""

        vars = vars & "NombreSoft=" & NombreSoft & "&"
        vars = vars & "VersSoft=" & VersSoft & "&"
        vars = vars & "VersNotif=" & VersNotif

        Dim URL As String = "http://protovision.es/update/" & NombreSoft & "/exec.php?" & vars
        Try
            htmldata = WebClient.DownloadData(URL)
        Catch ex As Exception
        End Try



    End Sub






    Public Function RefreshForm()
        LBLTitle.Text = Title
        LBLUrl.Text = UrlOrigen
        If AutoSave Then
            INDAuto.BackColor = Color.Green
        Else
            INDAuto.BackColor = Color.Red
        End If


        If System.IO.File.Exists(DirectorioSalida & "\" & Title & ".strm") Then

            Me.PBXStateIcon.Image = Global.YouTube2Strm.My.Resources.Resources.saved
        ElseIf Title <> "" Then
            Me.PBXStateIcon.Image = Global.YouTube2Strm.My.Resources.Resources.nosaved
        Else
            PBXStateIcon.Image = New Bitmap(1, 1)

        End If

        CBXClipboardDetect.Checked = AutoClipboard

        If Title = "" Then
            LBLThumInfo.Text = "Drag here YouTube Videos from browser or copy a Stream URL"
        Else
            LBLThumInfo.Text = "Drag here an image to change thumb"
        End If

        TBXDirectorioSal.Text = DirectorioSalida

    End Function

    Public Function ObtenerYoutubeVideoID(ByVal URL As String) As String

        Dim ID As String

        Dim StartID As Integer = URL.IndexOf("v=")

        ID = URL.Substring(StartID + 2)

        Dim EndIP As Integer = ID.IndexOf("&")


        If EndIP > 0 Then
            Dim RestoID As String = ID.Substring(EndIP)
            ID = ID.Replace(RestoID, "")
        End If

        Return ID


    End Function

    Private Sub CreaFichSTRM(ByVal Video As String)

        ValidaNombreFich()

        If System.IO.Directory.Exists(DirectorioSalida) Then
            Dim sw As New System.IO.StreamWriter(DirectorioSalida & "\" & Title & ".strm")
            sw.WriteLine(Video)
            sw.Close()
            Thumb.Save(DirectorioSalida & "\" & Title & ".tbn")
        Else
            MessageBox.Show("Directory Not Found!")
        End If


    End Sub

    Private Function ObtenerYouTubeThumb(ByVal VideoID As String) As Image

        Dim WebClient As New System.Net.WebClient

        Dim ImageInBytes() As Byte



        If CheckURL("http://i1.ytimg.com/vi/" & VideoID & "/default.jpg") Then
            ImageInBytes = WebClient.DownloadData("http://i1.ytimg.com/vi/" & VideoID & "/mqdefault.jpg")
        ElseIf CheckURL("http://i1.ytimg.com/vi/" & VideoID & "/mqdefault.jpg") Then
            ImageInBytes = WebClient.DownloadData("https://i1.ytimg.com/vi/" & VideoID & "/default.jpg")
        Else
            Return New Bitmap(200, 100)
        End If


        Dim ImageStream As New IO.MemoryStream(ImageInBytes)

        Dim Imagen As New System.Drawing.Bitmap(ImageStream)

        Return Imagen

    End Function

    Public Function CheckURL(ByVal URL As String) As Boolean
        Dim WebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte
        Try
            ImageInBytes = WebClient.DownloadData(URL)
            Return True
        Catch ex As Exception
            Return False
        End Try

        Return False

    End Function

    Private Function ObtenerTituloURL(ByVal URL As String) As String
        Dim WebClient As New System.Net.WebClient

        Dim htmldata() As Byte

        htmldata = WebClient.DownloadData(URL)
        Dim enc As UTF8Encoding = New UTF8Encoding()

        Dim html As String = enc.GetString(htmldata)

        Dim StartTitle As Integer = html.IndexOf("<title>") + 7
        Dim EndTitle As Integer = html.IndexOf("</title>")

        Return html.Substring(StartTitle, EndTitle - (StartTitle + 10))

    End Function

    Private Function ProcesaYoutube(ByVal URL As String)

        Dim VideoID As String = ObtenerYoutubeVideoID(URL)
        Title = ObtenerTituloURL(URL)
        Thumb = ObtenerYouTubeThumb(VideoID)
        PBXThumbVideo.Image = Thumb
        UrlStream = "plugin://plugin.video.youtube/?path=/root/video&action=play_video&hd=1&videoid=" & VideoID
        UrlOrigen = URL

    End Function

    Private Function ProcesaStream(ByVal URL As String)

        Title = URL
        UrlStream = URL
        UrlOrigen = URL

        Thumb = Global.YouTube2Strm.My.Resources.Resources.streamdefault

        PBXThumbVideo.Image = Thumb

        ValidaNombreFich()

    End Function



    Private Sub BTTCrearSTRM_Click(sender As Object, e As EventArgs) Handles BTTCrearSTRM.Click

        AccionSalvar()

        RefreshForm()
    End Sub

    Private Sub ValidaNombreFich()

        Title = Title.Replace("<", " ")
        Title = Title.Replace(">", " ")
        Title = Title.Replace(":", " ")
        Title = Title.Replace("""", " ")
        Title = Title.Replace("\", " ")
        Title = Title.Replace("'", "")
        Title = Title.Replace("/", " ")
        Title = Title.Replace("|", " ")
        Title = Title.Replace("*", " ")
        Title = Title.Replace("?", " ")
        Title = Title.Replace("¿", " ")
        Title = Title.Replace("&quot;", " ")

        Title = Title.Replace("  ", " ")
        Title = Title.Replace("  ", " ")

        Title = Title.Trim()


    End Sub

 

    Private Sub BTTAutosave_Click(sender As Object, e As EventArgs) Handles BTTAutosave.Click

        If AutoSave Then
            AutoSave = False

        Else
            AutoSave = True

        End If
        RefreshForm()

    End Sub

    Private Function DeterminaURL(ByVal URL As String)

        If URL.Contains("v=") And URL.Contains("youtube") Then
            ProcesaYoutube(URL)
        ElseIf URL.Contains("://") Then
            ProcesaStream(URL)
        Else
            Return False
        End If

        If AutoSave Then
            AccionSalvar()
        End If


        RefreshForm()

    End Function




    Private Function AccionSalvar()

        If Title = "" Then Return False

        Try
            CreaFichSTRM(UrlStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return True
    End Function

    Private Sub PBXThumbVideo_DragDrop(sender As Object, e As DragEventArgs) Handles PBXThumbVideo.DragDrop

        If e.Data.GetDataPresent(DataFormats.Text) Then
            DeterminaURL(e.Data.GetData(DataFormats.StringFormat).ToString())
        ElseIf e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Try
                Thumb = Image.FromFile(files(0))
                PBXThumbVideo.Image = Thumb
            Catch ex As Exception
                Return
            End Try


        End If



    End Sub

    Private Sub PBXThumbVideo_DragEnter(sender As Object, e As DragEventArgs) Handles PBXThumbVideo.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Or e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent("UniformResourceLocator") Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub BTTDirectorioSal_Click(sender As Object, e As EventArgs) Handles BTTDirectorioSal.Click
        FolderBrowserDialog1.SelectedPath = TBXDirectorioSal.Text

        If FolderBrowserDialog1.ShowDialog() Then

            DirectorioSalida = FolderBrowserDialog1.SelectedPath

        End If

        RefreshForm()
    End Sub

    Private Sub BTTDelete_Click(sender As Object, e As EventArgs) Handles BTTDelete.Click

        If Title = "" Then Return

        Try
            ValidaNombreFich()

            If System.IO.File.Exists(DirectorioSalida & "\" & Title & ".strm") Then System.IO.File.Delete(DirectorioSalida & "\" & Title & ".strm")
            If System.IO.File.Exists(DirectorioSalida & "\" & Title & ".tbn") Then System.IO.File.Delete(DirectorioSalida & "\" & Title & ".tbn")


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        RefreshForm()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Clipboard.ContainsText() = True And TextoClipboard <> My.Computer.Clipboard.GetText Then
            TextoClipboard = My.Computer.Clipboard.GetText
            DeterminaURL(TextoClipboard)

        End If
    End Sub

    Private Sub CBXClipboardDetect_CheckedChanged(sender As Object, e As EventArgs) Handles CBXClipboardDetect.CheckedChanged
        If CBXClipboardDetect.Checked Then
            Timer1.Enabled = True
            AutoClipboard = True
        Else
            Timer1.Enabled = False
            AutoClipboard = False
        End If

        CBXClipboardDetect.Checked = AutoClipboard
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GrabaConfig()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PBXThumbVideo.AllowDrop = True

        PBXStateIcon.Parent = PBXThumbVideo
        LBLThumInfo.Parent = PBXThumbVideo


        CargaConfig()


        ReportUseThread = New Thread(AddressOf ReportUse)
        ReportUseThread.IsBackground = True
        ReportUseThread.Start()


        Dim WebClient As New System.Net.WebClient

        Dim htmldata() As Byte
        Dim enc As UTF8Encoding = New UTF8Encoding()

        Dim html As String


        Try
            htmldata = WebClient.DownloadData("http://protovision.es/update/" & NombreSoft & "/notif")
            html = enc.GetString(htmldata)
            If (html <> VersNotif) Then
                ContenidoUpdateWindowURL = "http://protovision.es/update/" & NombreSoft & "/nlog/" & html & ".php"

                My.Forms.update.ShowDialog()
                VersNotif = html
                GrabaConfig()
            End If

        Catch ex As Exception
        End Try

        If CheckUpdate Then
            Try
                htmldata = WebClient.DownloadData("http://protovision.es/update/" & NombreSoft & "/version")
                html = enc.GetString(htmldata)

                If (html <> VersSoft) Then
                    ContenidoUpdateWindowURL = "http://protovision.es/update/" & NombreSoft & "/vlog/" & html & ".php"

                    My.Forms.update.ShowDialog()
                End If
            Catch ex As Exception
            End Try
        End If

        RefreshForm()
    End Sub


    Function GetMeta(Html As String, Caracteristica As String) As Integer

        Dim posicionini As Integer = 0
        Dim posicionfin As Integer = 1
        Dim frasemeta As String = ""

        Dim Resultado As String = ""

        Do


            posicionini = Html.IndexOf("<meta", posicionini + 1)
            posicionfin = Html.IndexOf(">", posicionini + 1)

            If posicionini = -1 Then
                Exit Do
            End If


            frasemeta = Html.Substring(posicionini, posicionfin - posicionini + 1)


            If frasemeta.ToLower.Contains(Caracteristica) Then

                For i = 0 To frasemeta.Length - 1
                    If IsNumeric(frasemeta(i)) Then
                        Resultado = Resultado & frasemeta(i)
                    End If
                Next
            End If

        Loop


        Return CInt(Resultado)

    End Function


    Private Sub BTTOptions_Click(sender As Object, e As EventArgs) Handles BTTOptions.Click
        My.Forms.options.ShowDialog()
    End Sub
End Class
