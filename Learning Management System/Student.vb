﻿Public Class Student
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        Login.Show()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
    End Sub


End Class