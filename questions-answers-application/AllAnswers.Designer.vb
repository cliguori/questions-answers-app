<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllAnswers
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
        Me.dgvAllAnswers = New System.Windows.Forms.DataGridView()
        CType(Me.dgvAllAnswers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAllAnswers
        '
        Me.dgvAllAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllAnswers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAllAnswers.Location = New System.Drawing.Point(0, 0)
        Me.dgvAllAnswers.Name = "dgvAllAnswers"
        Me.dgvAllAnswers.Size = New System.Drawing.Size(776, 496)
        Me.dgvAllAnswers.TabIndex = 0
        '
        'AllAnswers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 496)
        Me.Controls.Add(Me.dgvAllAnswers)
        Me.Name = "AllAnswers"
        Me.Text = "AllAnswers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAllAnswers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAllAnswers As DataGridView
End Class
