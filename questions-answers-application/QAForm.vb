Public Class QAForm
    Protected db As New db
    Private Sub QAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQA()
    End Sub

    Protected Sub LoadQA()
        db.sql = "  Select questions.id, questions.user_login as CreatedBy, questions.question, questions.created_at,
  
  answers.user_login as CreatedBy, answers.answer, answers.created_at  
From questions left outer join answers 
on questions.id = answers.question_id"
        db.fill(dgvQA)
    End Sub
End Class