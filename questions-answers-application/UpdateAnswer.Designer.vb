<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswer
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
        Me.txtUdateAnswer = New System.Windows.Forms.TextBox()
        Me.btnUpdateAnswer = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUdateAnswer
        '
        Me.txtUdateAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUdateAnswer.Location = New System.Drawing.Point(12, 85)
        Me.txtUdateAnswer.Multiline = True
        Me.txtUdateAnswer.Name = "txtUdateAnswer"
        Me.txtUdateAnswer.Size = New System.Drawing.Size(339, 77)
        Me.txtUdateAnswer.TabIndex = 0
        '
        'btnUpdateAnswer
        '
        Me.btnUpdateAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAnswer.Location = New System.Drawing.Point(12, 194)
        Me.btnUpdateAnswer.Name = "btnUpdateAnswer"
        Me.btnUpdateAnswer.Size = New System.Drawing.Size(339, 50)
        Me.btnUpdateAnswer.TabIndex = 1
        Me.btnUpdateAnswer.Text = "Update Answer"
        Me.btnUpdateAnswer.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 26)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(339, 47)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "Label1"
        '
        'UpdateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 261)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnUpdateAnswer)
        Me.Controls.Add(Me.txtUdateAnswer)
        Me.Name = "UpdateAnswer"
        Me.Text = "UpdateAmswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUdateAnswer As TextBox
    Friend WithEvents btnUpdateAnswer As Button
    Friend WithEvents lblQuestion As Label
End Class
