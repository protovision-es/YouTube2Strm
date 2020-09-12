Public Class options

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBXUpdates.Checked = CheckUpdate
    End Sub


    Private Sub options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CheckUpdate = CBXUpdates.Checked
    End Sub
End Class