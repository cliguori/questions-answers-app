Public Class AnswersForm
    'Instantiate the class called "db"
    Protected db As New db
    Dim _questionId As Integer
    Dim _question As String
    Public Sub New(questionId As Integer, question As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _questionId = questionId
        _question = question
    End Sub

    'As soon as the form opens, load the grid with the answers
    Private Sub Answers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub
    'It opens the query in sql
    Protected Sub LoadAnswers()
        db.sql = String.Format("SELECT * FROM answers where Question_Id = {0} ORDER BY created_at DESC;", _questionId)
        db.fill(dgvAnswers)
    End Sub

    Private Sub LoadResentAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadResentAnswersToolStripMenuItem.Click
        LoadAnswers()
    End Sub

    Private Sub UpdateAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAnswerToolStripMenuItem.Click
        Dim answer As String
        Dim answerId As Integer
        answerId = getAnswerId()
        answer = getAnswerValue("answer").ToString()

        Dim updateAnswer As New UpdateAnswer(answerId, answer, _question)
        updateAnswer.ShowDialog()
        LoadAnswers()
    End Sub

    Public Function getAnswerId() As Integer
        Return getAnswerValue("id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return dgvAnswers.Item(column, dgvAnswers.CurrentRow.Index).Value
    End Function

    Private Sub AnswerQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnswerQuestionToolStripMenuItem.Click
        Dim answerQuestion As New AnswerQuestion(_questionId)
        answerQuestion.ShowDialog()
        LoadAnswers()
    End Sub

    Private Sub DeleteAnswerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnswerToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@answer_id", getAnswerId())
            db.execute()
            LoadAnswers()

        End If
    End Sub

    Private Sub QAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QAToolStripMenuItem.Click
        Dim qaform As New QAForm()
        qaform.ShowDialog()
    End Sub
End Class