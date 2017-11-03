<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateQuestion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TbQuestion = New System.Windows.Forms.TextBox()
        Me.BtnQuestionSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbQuestion
        '
        Me.TbQuestion.Location = New System.Drawing.Point(51, 29)
        Me.TbQuestion.Multiline = True
        Me.TbQuestion.Name = "TbQuestion"
        Me.TbQuestion.Size = New System.Drawing.Size(289, 103)
        Me.TbQuestion.TabIndex = 0
        '
        'BtnQuestionSubmit
        '
        Me.BtnQuestionSubmit.Location = New System.Drawing.Point(51, 165)
        Me.BtnQuestionSubmit.Name = "BtnQuestionSubmit"
        Me.BtnQuestionSubmit.Size = New System.Drawing.Size(289, 56)
        Me.BtnQuestionSubmit.TabIndex = 1
        Me.BtnQuestionSubmit.Text = "Submit"
        Me.BtnQuestionSubmit.UseVisualStyleBackColor = True
        '
        'CreateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 261)
        Me.Controls.Add(Me.BtnQuestionSubmit)
        Me.Controls.Add(Me.TbQuestion)
        Me.Name = "CreateQuestion"
        Me.Text = "CreateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbQuestion As TextBox
    Friend WithEvents BtnQuestionSubmit As Button
End Class
