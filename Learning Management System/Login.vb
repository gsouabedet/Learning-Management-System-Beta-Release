Imports System.IO

Public Class Login
    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click
        Dim lines() As String
        Dim Vals() As String

        Select Case txtUsername.Text
            Case "gilchrist1", "Gilchrist1", "GILCHRIST1", "anh1", "Anh1", "ANH1"
                If txtPassword.Text = "gilchrist123" Or txtPassword.Text = "anh123" Then
                    Me.Hide()
                    Student.Show()
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
                    Console.ReadLine()
                    Dim sum As Integer = 0
                    Dim gpa As Integer
                    For i As Integer = 0 To Student.DataGridView1.Rows.Count() - 1 Step +1
                        Select Case Student.DataGridView1.Rows(i).Cells(5)
                            Case "A"
                                sum += 100
                            Case "B"
                                sum += 90
                            Case "C"
                                sum += 80
                            Case "D"
                                sum += 70
                            Case "F"
                                sum += 60
                        End Select

                    Next
                    Student.txtGpa.Text = gpa.ToString()
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case Else
                statusBar.Text = "Please enter a username"
        End Select
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Select Case txtUsername.Text
            Case "admin", "Admin", "ADMIN"
                If txtPassword.Text = "admin123" Then
                    Me.Hide()
                    Admin.Show()
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case "gilchrist1", "Gilchrist1", "GILCHRIST!", "anh1", "Anh1", "ANH1"
                statusBar.Text = "The username entered is a Student Username"
            Case Else
                statusBar.Text = "Wrong Username or Password"
        End Select
    End Sub
End Class
