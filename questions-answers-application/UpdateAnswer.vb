Public Class UpdateAnswer
    Dim db As New db()
    Dim _answerId As Integer
    Public Sub New(answerId As Integer, answer As String, question As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _answerId = answerId
        txtUdateAnswer.Text = answer
        lblQuestion.Text = String.Format("Question: {0} ", question)
    End Sub


    Private Sub btnUpdateAnswer_Click(sender As Object, e As EventArgs) Handles btnUpdateAnswer.Click
        db.sql = "UPDATE answers SET answer = @answer WHERE id = @answer_id"
        db.bind("@answer_id", _answerId)
        db.bind("@answer", txtUdateAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub


End Class