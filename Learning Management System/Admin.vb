Imports System.IO

Public Class Admin
    Dim lines() As String
    Dim Vals() As String
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Hide()
        Student_Details.Show()
        If DataGridView1.SelectedCells = "Gilchrist" Then
            Me.Hide()
            Student_Details.Show()
            FileOpen(1, "gilchrist.txt", OpenMode.Input)
            Student.txtFirstName.Text = LineInput(1)
            Student.txtLastName.Text = LineInput(1)
            Student.txtStudentId.Text = LineInput(1)
            Student.txtSemester.Text = LineInput(1)
            Student.txtYear.Text = LineInput(1)
            lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\gilchrist_courses.txt")
            For i As Integer = 0 To lines.Length - 1 Step +1
                Vals = lines(i).ToString().Split(CChar("|"))
                Dim row(Vals.Length - 1) As String

                For j As Integer = 0 To Vals.Length - 1 Step +1
                    row(j) = Vals(j).Trim()
                Next j

                Student.DataGridView1.Rows.Add(row)
            Next
            FileClose(1)
        End If

    End Sub

    Private Sub btnDropStudent_Click(sender As Object, e As EventArgs) Handles btnDropStudent.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class