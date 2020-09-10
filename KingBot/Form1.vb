Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.ForeColor = Color.OliveDrab
        Else
            CheckBox1.ForeColor = Color.SandyBrown
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.ForeColor = Color.OliveDrab
        Else
            CheckBox2.ForeColor = Color.Brown
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.ForeColor = Color.OliveDrab
        Else
            CheckBox3.ForeColor = Color.RosyBrown
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("İstediğiniz butonları işaretleyip 'Başlat' butonuna basın" & vbCrLf & "Not: Arka Planda Çalışmaz" & vbCrLf & "" & vbCrLf & "King Bot")
        '  MsgBox("1-sadfsd" & vbCrLf & "2-dfs")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
