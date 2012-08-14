<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class key
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.display = New System.Windows.Forms.Button()
        Me.code = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.Maroon
        Me.display.ForeColor = System.Drawing.Color.Maroon
        Me.display.Location = New System.Drawing.Point(271, 6)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(77, 77)
        Me.display.TabIndex = 1
        Me.display.UseVisualStyleBackColor = False
        '
        'code
        '
        Me.code.AutoSize = True
        Me.code.Font = New System.Drawing.Font("Tahoma", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(12, 0)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(0, 81)
        Me.code.TabIndex = 2
        '
        'key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 89)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.display)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "key"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents display As System.Windows.Forms.Button
    Friend WithEvents code As System.Windows.Forms.Label

End Class
