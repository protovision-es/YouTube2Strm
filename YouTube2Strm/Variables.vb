Module Variables

    Public NombreSoft As String = "2Strm"
    Public VersSoft As String = "1.3"
    Public VersNotif As String = ""
    Public PathAplicacion As String = Application.StartupPath

    Public AutoSave As Boolean = True
    Public CheckUpdate As Boolean = True
    Public AutoClipboard As Boolean = False
    Public DirectorioSalida As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Public ContenidoUpdateWindowURL As String


    Public Function CargaConfig()
        If GetSetting(NombreSoft, "General", "Version") = "" Or GetSetting(NombreSoft, "General", "Version") <> VersSoft Then
            GrabaConfig()
        End If

        VersNotif = GetSetting(NombreSoft, "General", "VersNotif")
        AutoSave = GetSetting(NombreSoft, "General", "AutoSave")
        CheckUpdate = GetSetting(NombreSoft, "General", "CheckUpdate")
        AutoClipboard = GetSetting(NombreSoft, "General", "AutoClipboard")
        DirectorioSalida = GetSetting(NombreSoft, "General", "DirectorioSalida")

    End Function

    Public Function GrabaConfig()

        SaveSetting(NombreSoft, "General", "VersNotif", VersNotif)
        SaveSetting(NombreSoft, "General", "Version", VersSoft)
        SaveSetting(NombreSoft, "General", "AutoSave", AutoSave)
        SaveSetting(NombreSoft, "General", "CheckUpdate", CheckUpdate)
        SaveSetting(NombreSoft, "General", "AutoClipboard", AutoClipboard)
        SaveSetting(NombreSoft, "General", "DirectorioSalida", DirectorioSalida)

    End Function

End Module
