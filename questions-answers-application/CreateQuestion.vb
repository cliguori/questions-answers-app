Public Class CreateQuestion
    'Protected means the Class Is Not visible outside the form
    Protected db As db = New db
    Private Sub BtnQuestionSubmit_Click(sender As Object, e As EventArgs) Handles BtnQuestionSubmit.Click
        db.sql = "INSERT INTO questions (question) VALUES (@question)"
        db.bind("@question", TbQuestion.Text)
        db.execute()
        Me.Dispose()

    End Sub
End Class
