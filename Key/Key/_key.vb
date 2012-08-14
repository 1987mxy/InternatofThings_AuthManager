Public Class key
    Private beginTime As Long = 0
    Private keyLib() As Integer =
        {}

    Private Sub display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles display.Click
        Dim timeKey As Long = (Now.Ticks \ 600000000) - beginTime
        If timeKey < keyLib.Length Then
            code.Text = keyLib(timeKey).ToString.PadLeft(6, "0")
        Else
            code.Text = ""
            MessageBox.Show("密钥已过期！")
        End If
    End Sub

    Private Sub theEnd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles display.KeyDown, code.KeyDown, Me.KeyDown
        If e.KeyValue = 27 Then
            Me.Close()
        End If
    End Sub
End Class
