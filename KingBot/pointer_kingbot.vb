Module pointer_kingbot

    Dim Count As Integer = 0

    Public Function analyzer()
        On Error Resume Next
        Dim Macro_Part1 As String = main.macro_yolu & ".pointer"
        Dim Macro_Part2 As String = main.macro_yolu & "cs2.pointer"
        Dim Macro_Part3 As String = main.macro_yolu & "xS0.pointer"

        Dim File(2) As Boolean
        main.RichTextBox1.Text = ""
        If main.macro_yolu = "" Then

        Else
            If IO.File.Exists(Macro_Part1) Then
                File(0) = True
                main.RichTextBox1.Text += "Macro Adı: " & Macro_Part1 & vbCrLf
            Else
                File(0) = False
            End If

            If IO.File.Exists(Macro_Part2) Then
                File(1) = True
                Count = Count + 1
                main.RichTextBox1.Text += "{" & vbCrLf & Macro_Part2 & vbCrLf
            Else
                main.RichTextBox1.Text += "{" & vbCrLf
                File(1) = False
            End If

            If IO.File.Exists(Macro_Part3) Then
                File(2) = True
                Count = Count + 1
                main.RichTextBox1.Text += Macro_Part3 & vbCrLf & "}" & vbCrLf
            Else
                main.RichTextBox1.Text += "}" & vbCrLf
                File(2) = False
            End If

            main.RichTextBox1.Text += "X değeri dosyası: " & File(0) & vbCrLf & "Y değeri dosyası: " & File(1) & vbCrLf & "Macro ayar dosyası: " & File(2) & vbCrLf
            main.RichTextBox1.Text += "X satırları: " & FileLen(Macro_Part1) & vbCrLf & "Y satırları: " & FileLen(Macro_Part2) & vbCrLf
            main.RichTextBox1.Text += "Genişletilmiş Dosyalar: " & Count & vbCrLf & vbCrLf
            main.RichTextBox1.Text += "****************" & vbCrLf
            main.RichTextBox1.Text += "*Pointer - KingBot*" & vbCrLf
            main.RichTextBox1.Text += "****************"

            If Count < 2 Or File(0) = False Or File(1) = False Or File(2) = False Then
                MsgBox("Esksik dosya bulunmaktadır. Lütfen macro yeniden kaydedin.", MsgBoxStyle.Critical)
            End If
        End If
        Count = 0
    End Function
End Module
