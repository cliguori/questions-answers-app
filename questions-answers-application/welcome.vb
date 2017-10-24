Imports System.Data.SqlClient

Public Class welcome
    Protected db As New DB
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub
End Class
