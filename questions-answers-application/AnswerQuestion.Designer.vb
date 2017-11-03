<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnswerQuestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtAnswerQuestion = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAnswerQuestion
        '
        Me.txtAnswerQuestion.Location = New System.Drawing.Point(12, 63)
        Me.txtAnswerQuestion.Multiline = True
        Me.txtAnswerQuestion.Name = "txtAnswerQuestion"
        Me.txtAnswerQuestion.Size = New System.Drawing.Size(260, 67)
        Me.txtAnswerQuestion.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 177)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(260, 41)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'AnswerQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtAnswerQuestion)
        Me.Name = "AnswerQuestion"
        Me.Text = "AnswerQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnswerQuestion As TextBox
    Friend WithEvents btnSubmit As Button
End Class
