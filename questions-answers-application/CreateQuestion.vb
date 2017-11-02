Public Class CreateQuestion
    Protected db As db = New db

    Private Sub btnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnQuestionSubmit.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", tbQuestion.Text)
        db.execute()
        Me.Dispose()
    End Sub

    Private Sub CreateQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
