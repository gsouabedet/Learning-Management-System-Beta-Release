Imports System.IO

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim lines() As String
        Dim Vals() As String

        Select Case txtUsername.Text
            Case "gilchrist1", "Gilchrist1", "GILCHRIST1"
                If txtPassword.Text = "gilchrist123" Then
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

                    Student.txtGpa.Text = "3.8"
                Else
                    statusBar.Text = "Wrong Password"
                End If

            Case "anh1", "Anh1", "ANH1"
                If txtPassword.Text = "anh123" Then
                    Me.Hide()
                    Student.Show()
                    FileOpen(1, "anh.txt", OpenMode.Input)
                    Student.txtFirstName.Text = LineInput(1)
                    Student.txtLastName.Text = LineInput(1)
                    Student.txtStudentId.Text = LineInput(1)
                    Student.txtSemester.Text = LineInput(1)
                    Student.txtYear.Text = LineInput(1)
                    lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\anh_courses.txt")
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

                    Student.txtGpa.Text = "3.9"
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case "admin", "Admin", "ADMIN"
                If txtPassword.Text = "admin123" Then
                    Me.Hide()
                    Admin.Show()
                    lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\list.txt")
                    For i As Integer = 0 To lines.Length - 1 Step +1
                            Vals = lines(i).ToString().Split(CChar("|"))
                            Dim row(Vals.Length - 1) As String

                            For j As Integer = 0 To Vals.Length - 1 Step +1
                                row(j) = Vals(j).Trim()
                            Next j

                            Admin.DataGridView1.Rows.Add(row)
                        Next
                        FileClose(1)
                    Else
                        statusBar.Text = "Wrong Password"
                End If
            Case Else
                statusBar.Text = "Please enter a username"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
