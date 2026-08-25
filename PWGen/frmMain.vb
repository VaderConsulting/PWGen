Imports System.Text
Imports Password
Imports Password.Functions

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudLength.Value = 8
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim SpeltOut As String = ""
        Dim ThePassword As String = ""
        Dim sb As StringBuilder = New StringBuilder()

        lblStatus.Text = "Working..."
        lblStatus.Refresh()

        txtPasswords.Text = ""

        For I As Integer = 1 To nudPasswordCount.Value
            ThePassword = Password.Functions.GeneratePassword(nudLength.Value, SpeltOut, chkSymbols.Checked)
            sb.Append(ThePassword + " " + SpeltOut & vbCrLf)
        Next

        txtPasswords.Text = sb.ToString()

        lblStatus.Text = "Idle"
        lblStatus.Refresh()

        Copy()

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Copy()
    End Sub

    Private Sub Copy()
        Clipboard.SetText(txtPasswords.Text)

        lblStatus.Text = "Copied to clipboard"
        lblStatus.Refresh()
    End Sub

End Class
