Imports System.Text

Public NotInheritable Class update

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WebClient As New System.Net.WebClient

        Dim htmldata() As Byte

        Dim enc As UTF8Encoding = New UTF8Encoding()

        Dim html As String


        Try
            htmldata = WebClient.DownloadData(ContenidoUpdateWindowURL)
            html = enc.GetString(htmldata)
            WebBrowser1.DocumentText = html
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub


End Class
