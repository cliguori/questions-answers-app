
Public Class AnswerQuestion
    Dim db As New db()
    Dim _questionId As Integer
    Public Sub New(questionId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _questionId = questionId
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        db.sql = "INSERT INTO answers (answer, question_Id) VALUES (@answer, @questionId)"
        db.bind("@answer", txtAnswerQuestion.Text)
        db.bind("@questionId", _questionId)
        db.execute()
        Me.Dispose()


    End Sub
End Class