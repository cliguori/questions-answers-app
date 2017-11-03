<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnswersForm
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
        Me.dgvAnswers = New System.Windows.Forms.DataGridView()
        Me.mnuAnswers = New System.Windows.Forms.MenuStrip()
        Me.LoadResentAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnswerQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAnswers.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAnswers
        '
        Me.dgvAnswers.AllowUserToAddRows = False
        Me.dgvAnswers.AllowUserToDeleteRows = False
        Me.dgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAnswers.Location = New System.Drawing.Point(0, 24)
        Me.dgvAnswers.Name = "dgvAnswers"
        Me.dgvAnswers.Size = New System.Drawing.Size(896, 310)
        Me.dgvAnswers.TabIndex = 0
        '
        'mnuAnswers
        '
        Me.mnuAnswers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadResentAnswersToolStripMenuItem, Me.AnswerQuestionToolStripMenuItem, Me.UpdateAnswerToolStripMenuItem, Me.DeleteAnswerToolStripMenuItem, Me.QAToolStripMenuItem})
        Me.mnuAnswers.Location = New System.Drawing.Point(0, 0)
        Me.mnuAnswers.Name = "mnuAnswers"
        Me.mnuAnswers.Size = New System.Drawing.Size(896, 24)
        Me.mnuAnswers.TabIndex = 1
        Me.mnuAnswers.Text = "MenuStrip1"
        '
        'LoadResentAnswersToolStripMenuItem
        '
        Me.LoadResentAnswersToolStripMenuItem.Name = "LoadResentAnswersToolStripMenuItem"
        Me.LoadResentAnswersToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.LoadResentAnswersToolStripMenuItem.Text = "Load Recent Answers"
        '
        'AnswerQuestionToolStripMenuItem
        '
        Me.AnswerQuestionToolStripMenuItem.Name = "AnswerQuestionToolStripMenuItem"
        Me.AnswerQuestionToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.AnswerQuestionToolStripMenuItem.Text = "Answer Question"
        '
        'UpdateAnswerToolStripMenuItem
        '
        Me.UpdateAnswerToolStripMenuItem.Name = "UpdateAnswerToolStripMenuItem"
        Me.UpdateAnswerToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.UpdateAnswerToolStripMenuItem.Text = "Update Answer"
        '
        'DeleteAnswerToolStripMenuItem
        '
        Me.DeleteAnswerToolStripMenuItem.Name = "DeleteAnswerToolStripMenuItem"
        Me.DeleteAnswerToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.DeleteAnswerToolStripMenuItem.Text = "Delete Answer"
        '
        'QAToolStripMenuItem
        '
        Me.QAToolStripMenuItem.Name = "QAToolStripMenuItem"
        Me.QAToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QAToolStripMenuItem.Text = "Q & A"
        '
        'AnswersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 334)
        Me.Controls.Add(Me.dgvAnswers)
        Me.Controls.Add(Me.mnuAnswers)
        Me.MainMenuStrip = Me.mnuAnswers
        Me.Name = "AnswersForm"
        Me.Text = "Answers"
        CType(Me.dgvAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAnswers.ResumeLayout(False)
        Me.mnuAnswers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAnswers As DataGridView
    Friend WithEvents mnuAnswers As MenuStrip
    Friend WithEvents LoadResentAnswersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnswerQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QAToolStripMenuItem As ToolStripMenuItem
End Class
