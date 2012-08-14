<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.generate = New System.Windows.Forms.Button()
        Me.labelKeyBeginTime = New System.Windows.Forms.Label()
        Me.timeKeyBeginTime = New System.Windows.Forms.DateTimePicker()
        Me.labelKeyStopTime = New System.Windows.Forms.Label()
        Me.timeKeyStopTime = New System.Windows.Forms.DateTimePicker()
        Me.labelDevenvPath = New System.Windows.Forms.Label()
        Me.textDevenvPath = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.fileDevenvPath = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'generate
        '
        Me.generate.Location = New System.Drawing.Point(63, 145)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(75, 23)
        Me.generate.TabIndex = 0
        Me.generate.Text = "生成"
        Me.generate.UseVisualStyleBackColor = True
        '
        'labelKeyBeginTime
        '
        Me.labelKeyBeginTime.AutoSize = True
        Me.labelKeyBeginTime.Font = New System.Drawing.Font("宋体-PUA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelKeyBeginTime.Location = New System.Drawing.Point(12, 29)
        Me.labelKeyBeginTime.Name = "labelKeyBeginTime"
        Me.labelKeyBeginTime.Size = New System.Drawing.Size(113, 16)
        Me.labelKeyBeginTime.TabIndex = 1
        Me.labelKeyBeginTime.Text = "密钥生效时间："
        '
        'timeKeyBeginTime
        '
        Me.timeKeyBeginTime.Location = New System.Drawing.Point(131, 24)
        Me.timeKeyBeginTime.Name = "timeKeyBeginTime"
        Me.timeKeyBeginTime.Size = New System.Drawing.Size(152, 21)
        Me.timeKeyBeginTime.TabIndex = 2
        '
        'labelKeyStopTime
        '
        Me.labelKeyStopTime.AutoSize = True
        Me.labelKeyStopTime.Font = New System.Drawing.Font("宋体-PUA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelKeyStopTime.Location = New System.Drawing.Point(12, 66)
        Me.labelKeyStopTime.Name = "labelKeyStopTime"
        Me.labelKeyStopTime.Size = New System.Drawing.Size(113, 16)
        Me.labelKeyStopTime.TabIndex = 3
        Me.labelKeyStopTime.Text = "密钥失效时间："
        '
        'timeKeyStopTime
        '
        Me.timeKeyStopTime.Location = New System.Drawing.Point(131, 61)
        Me.timeKeyStopTime.Name = "timeKeyStopTime"
        Me.timeKeyStopTime.Size = New System.Drawing.Size(152, 21)
        Me.timeKeyStopTime.TabIndex = 4
        '
        'labelDevenvPath
        '
        Me.labelDevenvPath.AutoSize = True
        Me.labelDevenvPath.Font = New System.Drawing.Font("宋体-PUA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labelDevenvPath.Location = New System.Drawing.Point(12, 100)
        Me.labelDevenvPath.Name = "labelDevenvPath"
        Me.labelDevenvPath.Size = New System.Drawing.Size(114, 16)
        Me.labelDevenvPath.TabIndex = 5
        Me.labelDevenvPath.Text = "devenv.exe路径："
        '
        'textDevenvPath
        '
        Me.textDevenvPath.Location = New System.Drawing.Point(131, 95)
        Me.textDevenvPath.Name = "textDevenvPath"
        Me.textDevenvPath.Size = New System.Drawing.Size(152, 21)
        Me.textDevenvPath.TabIndex = 6
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(158, 145)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 7
        Me.cancel.Text = "关闭"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'fileDevenvPath
        '
        Me.fileDevenvPath.FileName = "devenv.exe"
        Me.fileDevenvPath.Filter = "(devenv.exe)|devenv.exe"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 194)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.textDevenvPath)
        Me.Controls.Add(Me.labelDevenvPath)
        Me.Controls.Add(Me.timeKeyStopTime)
        Me.Controls.Add(Me.labelKeyStopTime)
        Me.Controls.Add(Me.timeKeyBeginTime)
        Me.Controls.Add(Me.labelKeyBeginTime)
        Me.Controls.Add(Me.generate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "密钥生成器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generate As System.Windows.Forms.Button
    Friend WithEvents labelKeyBeginTime As System.Windows.Forms.Label
    Friend WithEvents timeKeyBeginTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelKeyStopTime As System.Windows.Forms.Label
    Friend WithEvents timeKeyStopTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelDevenvPath As System.Windows.Forms.Label
    Friend WithEvents textDevenvPath As System.Windows.Forms.TextBox
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents fileDevenvPath As System.Windows.Forms.OpenFileDialog

End Class
