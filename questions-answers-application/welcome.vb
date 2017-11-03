
Public Class welcome
    Protected db As New db
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(dgvQuestions)
    End Sub
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LoadQuestions()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuestions()
    End Sub

    Private Sub CreateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateQuestionToolStripMenuItem.Click
        CreateQuestion.ShowDialog()
        LoadQuestions()
    End Sub

    Private Sub UpdateQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateQuestionToolStripMenuItem.Click
        Dim updateQuestionForm As New UpdateQuestion(getQuestionId())
        updateQuestionForm.ShowDialog()
        LoadQuestions()
    End Sub

    Public Function getQuestionId() As Integer
        Return getQuestionValue("id")
    End Function

    Public Function getQuestionValue(ByVal column As String)
        Return dgvQuestions.Item(column, dgvQuestions.CurrentRow.Index).Value
    End Function

    Private Sub DeleteQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteQuestionToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this", "Delete", MessageBoxButtons.YesNoCancel)

        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM questions WHERE id = @question_id"
            db.bind("@question_id", getQuestionId())
            db.execute()
            LoadQuestions()

        End If

    End Sub

    Private Sub ShowAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAnswersToolStripMenuItem.Click
        Dim questionId As Integer
        questionId = getQuestionId()
        Dim question As String
        question = getQuestionValue("question").ToString()
        Dim showAnswers As New AnswersForm(questionId, question)
        showAnswers.ShowDialog()
    End Sub

    Private Sub LoadRecentAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadRecentAnswersToolStripMenuItem.Click
        Dim allAnswers As New AllAnswers()
        allAnswers.ShowDialog()

    End Sub

    Private Sub LoadToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click

    End Sub
End Class
