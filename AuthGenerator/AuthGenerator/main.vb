Public Class main
    Private CurrentPath As String = Environment.CurrentDirectory
    Private _KeyProgramFileName As String = CurrentPath + "\Key\Key\_key.vb"
    Private KeyProgramFileName As String = CurrentPath + "\Key\Key\key.vb"
    'Private _KeyProgramFileName As String = "C:\InternatofThings\InternatofThings_AuthManager\Key\Key\_key.vb"
    'Private KeyProgramFileName As String = "C:\InternatofThings\InternatofThings_AuthManager\Key\Key\key.vb"

    Private Sub generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate.Click
        If chkDevenv(textDevenvPath.Text) = False Then
            textDevenvPath.Text = ""
            MessageBox.Show("请选择正确的devenv.exe文件")
            Exit Sub
        End If
        FileOpen(1, _KeyProgramFileName, OpenMode.Input)
        Dim KeyProgram As String = ""
        Dim KeyLineProgram As String = ""
        Dim NowSecond As Long = Now.Ticks \ 10000000

        Dim KeyTime As Integer = (timeKeyStopTime.Value - timeKeyBeginTime.Value).TotalMinutes

        Dim KeyStr As String = ""
        Dim KeyBin(KeyTime * 3 - 1) As Byte

        While Not EOF(1)
            KeyLineProgram = LineInput(1)
            If Trim(KeyLineProgram) = "{}" Then
                gencode(KeyTime, KeyStr, KeyBin)
                KeyProgram += "{" + KeyStr + "}" + Chr(13)
            ElseIf Trim(KeyLineProgram) = "Private beginTime As Long = 0" Then
                KeyProgram += "Private beginTime As Long = " + (NowSecond \ 60).ToString + Chr(13)
            Else
                KeyProgram += KeyLineProgram + Chr(13)
            End If
        End While
        FileClose(1)

        If Dir(KeyProgramFileName) <> "" Then Kill(KeyProgramFileName)
        FileOpen(2, KeyProgramFileName, OpenMode.Binary)
        FilePut(2, KeyProgram)
        FileClose(2)

        Dim SecureKeyPath As String = CurrentPath + "\export\" + NowSecond.ToString
        If Dir(SecureKeyPath, vbDirectory) = "" Then MkDir(SecureKeyPath)

        Dim KeyExeFileName As String = CurrentPath + "\Key\Key\bin\Release\Key.exe"
        If Dir(KeyExeFileName) <> "" Then Kill(KeyExeFileName)
        Call Shell("""" + textDevenvPath.Text + """ """ + CurrentPath + "\Key\Key.sln"" /build")
        While Dir(KeyExeFileName) = ""
            Threading.Thread.Sleep(1000)
        End While
        FileCopy(KeyExeFileName, SecureKeyPath + "\Key.exe")

        Dim SecureKeyFileName As String = SecureKeyPath + "\Key"
        If Dir(SecureKeyFileName) <> "" Then Kill(SecureKeyFileName)
        FileOpen(3, SecureKeyFileName, OpenMode.Binary)
        FilePut(3, BitConverter.GetBytes(NowSecond - 62135625600))    '1970-01-01的总秒数 + 8小时秒数 = 62135625600
        FilePut(3, KeyBin)
        FileClose(3)

        Dim LogFileName As String = SecureKeyPath + "\Generate.log"
        If Dir(LogFileName) <> "" Then Kill(LogFileName)
        FileOpen(4, LogFileName, OpenMode.Binary)
        FilePut(4, "create time:" + Now.ToString + Chr(13) + "key begin time:" + timeKeyBeginTime.Value.ToString + Chr(13) + "key stop time:" + timeKeyStopTime.Value.ToString)
        FileClose(4)

        MessageBox.Show("生成完毕！")
        Call Shell("explorer.exe " + SecureKeyPath)
        Me.Close()
    End Sub

    Private Function chkDevenv(ByRef devenvPath As String) As Boolean
        If textDevenvPath.Text = "" Or Dir(textDevenvPath.Text) = "" Then Return False
        If Len(textDevenvPath.Text) > 8 And Mid(textDevenvPath.Text, Len(textDevenvPath.Text) - 9) <> "devenv.exe" Then Return False
        Return True
    End Function

    '调试key工程时使用
    'Private Function _genCode(ByVal unitNum As Integer) As String
    '    Dim lineUnitNum As Integer = 9361   '(65535 - 2) \ 7
    '    Dim lineNum As Integer = Math.Ceiling(unitNum / lineUnitNum)
    '    Dim codeLib(lineNum - 1) As String
    '    Dim codeLineLib(9360) As String     '9361-1

    '    Dim myRnd As Random = New Random
    '    Randomize(Now.Ticks)

    '    Dim j As Integer = 0
    '    For i As Integer = 0 To unitNum Step 1
    '        codeLineLib((i Mod lineUnitNum)) = (myRnd.Next() Mod 1000000).ToString
    '        If (i Mod lineUnitNum) = (lineUnitNum - 1) Then
    '            codeLib(j) = Join(codeLineLib, ",") + " _" + Chr(13)
    '            ReDim codeLineLib(lineUnitNum - 1)
    '            j += 1
    '        ElseIf i = unitNum Then
    '            Dim endCodeLine As String = ""
    '            For Each theCode As String In codeLineLib
    '                If theCode = "" Then
    '                    Exit For
    '                End If
    '                endCodeLine += "," + theCode
    '            Next
    '            codeLib(j) = Mid(endCodeLine, 2)
    '        End If
    '    Next
    '    Return Join(codeLib, ",")
    'End Function

    Private Sub gencode(ByVal KeyTime As Integer, ByRef KeyStr As String, ByRef KeyBin() As Byte)
        Dim KeylibStr(KeyTime - 1) As String
        Dim KeylibBin = New List(Of Byte)
        Dim tempKey As Integer

        Dim myrnd As Random = New Random
        Randomize(Now.Ticks)

        For i As Integer = 0 To KeyTime - 1 Step 1
            tempKey = myrnd.Next() Mod 1000000
            KeylibStr(i) = tempKey.ToString
            KeylibBin.AddRange(BitConverter.GetBytes(tempKey))
        Next

        KeyStr = Join(KeylibStr, ",")
        KeyBin = KeylibBin.ToArray
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With timeKeyBeginTime
            .MinDate = Today
            .Value = Today
        End With
        With timeKeyStopTime
            .MinDate = Today.AddDays(1)
            .MaxDate = Today.AddYears(5)
            .Value = Today.AddDays(1)
        End With
    End Sub

    Private Sub timeKeyBeginTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeKeyBeginTime.ValueChanged
        With timeKeyStopTime
            .MinDate = timeKeyBeginTime.Value.AddDays(1)
            .MaxDate = timeKeyBeginTime.Value.AddYears(5)
        End With
        If timeKeyBeginTime.Value > timeKeyStopTime.Value Then
            timeKeyStopTime.Value = timeKeyBeginTime.Value.AddDays(1)
        End If
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub textDevenvPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textDevenvPath.Click
        If fileDevenvPath.ShowDialog() = Windows.Forms.DialogResult.OK Then
            textDevenvPath.Text = fileDevenvPath.FileName
        End If
    End Sub
End Class
