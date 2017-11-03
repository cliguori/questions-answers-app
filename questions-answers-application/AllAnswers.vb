Public Class AllAnswers
    Dim db As New db()

    Private Sub dgvAllAnswers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAllAnswers.CellContentClick

    End Sub

    Private Sub AllAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllAnswers()
    End Sub
    Private Sub LoadAllAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(dgvAllAnswers)
    End Sub
End Class