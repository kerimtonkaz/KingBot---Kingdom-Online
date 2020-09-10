Public Class main

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer


    Dim pot(1) As Integer
    Dim king_send As New AutoItX3Lib.AutoItX3
    Dim skill(11) As String
    Dim login, guncel_indir, paypal As String
    Dim login2 As Boolean = False
    Dim web_refresh As Boolean = False
    Public macro_yolu As String


    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Dim CTRL_Key As Boolean
    Dim Shift_Key As Boolean
    Dim R_Key As Boolean
    Dim S_Key As Boolean
    Dim P_Key As Boolean
    Dim E_Key As Boolean
    Dim X_Key As Boolean
    Dim Z_Key As Boolean
    Dim T_Key As Boolean
    Dim O_Key As Boolean
    Dim C_Key As Boolean
    Dim sil As Boolean
    Dim Mouse_LeftClick As Boolean
    Dim Mouse_RightClick As Boolean
    Dim Mouse_MiddleClick As Boolean
    Dim Val0 As Integer = 0
    Dim Val1 As Integer = 0

#Region "tasarim_1"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.Checked = True Then
            CheckBox1.ForeColor = Color.OliveDrab
        Else
            CheckBox1.ForeColor = Color.SandyBrown
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox2.Checked = True Then
            CheckBox2.ForeColor = Color.OliveDrab
        Else
            CheckBox2.ForeColor = Color.Brown
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox3.Checked = True Then
            CheckBox3.ForeColor = Color.OliveDrab
        Else
            CheckBox3.ForeColor = Color.RosyBrown
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        If Button2.Text = "Başlat" Then
            Button2.BackColor = Color.DarkRed
            Button2.Text = "Durdur"
            otoSS.Start()
        Else
            Button2.BackColor = Color.ForestGreen
            Button2.Text = "Başlat"
            otoSS.Stop()
            bilgi.Text = "Bot bekleniyor.."
        End If
        SendMessage(FindWindow(Nothing, "Kingdom Online"), &HC, Nothing, "PointeR - King Bot")
    End Sub
#End Region

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 0 Then
            Me.Height = 429
        ElseIf TabControl1.SelectedIndex = 1 Then
            Me.Height = 308
        ElseIf TabControl1.SelectedIndex = 2 Then
            Me.Height = 240
        ElseIf TabControl1.SelectedIndex = 3 Then
            Me.Height = 481
        ElseIf TabControl1.SelectedIndex = 4 Then
            Me.Height = 383
        End If
        RichTextBox1.Visible = False
    End Sub

#Region "tasarim_2"
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.ForeColor = Color.YellowGreen
            otoZ.Start()
        Else
            CheckBox1.ForeColor = Color.SandyBrown
            otoZ.Stop()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            otoPOT.Start()
            CheckBox2.ForeColor = Color.YellowGreen
        Else
            otoPOT.Stop()
            Label18.Text = ""
            CheckBox2.ForeColor = Color.Brown
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            otoKUTU.Start()
            CheckBox3.ForeColor = Color.YellowGreen
        Else
            otoKUTU.Start()
            CheckBox3.ForeColor = Color.RosyBrown
        End If
    End Sub
#End Region

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        If FileIO.FileSystem.FileExists("C:\AutoItX3.dll") = False Then
            FileIO.FileSystem.CopyFile("AutoItX3.dll", "C:\AutoItX3.dll.dll", True)
        End If
        Shell("regsvr32 C:\AutoItX3.dll.dll /s")
        ComboBox1.SelectedIndex = 1
        For i = 0 To 11
            skill(i) = "0000"
        Next
        SendMessage(FindWindow(Nothing, "Kingdom Online"), &HC, Nothing, "PointeR - King Bot")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CheckBox1.Text = "Oto Z (" & ComboBox1.SelectedItem & ")"
    End Sub

#Region "oto"
    Private Sub otoPOT_Tick(sender As Object, e As EventArgs) Handles otoPOT.Tick
        If CheckBox2.Checked = True And Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
            If pot(0) >= TextBox1.Text And king_send.WinGetState("PointeR - King Bot") = 15 Then
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                king_send.Send("{F2}")
                pot(0) = 0
            Else
                pot(0) += 1
            End If

            If pot(1) >= TextBox3.Text And king_send.WinGetState("PointeR - King Bot") = 15 Then
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                king_send.Send("{F3}")
                pot(1) = 0
            Else
                pot(1) += 1
            End If
            Label18.Text = pot(0) & " - " & pot(1)
        End If
    End Sub

    Private Sub otoZ_Tick(sender As Object, e As EventArgs) Handles otoZ.Tick
        On Error Resume Next
        If Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
            If CheckBox1.Checked = True Then
                king_send.Send(ComboBox1.SelectedItem)
                king_send.Send(ComboBox1.SelectedItem)
            End If
        End If
    End Sub

    Private Sub otoKUTU_Tick(sender As Object, e As EventArgs) Handles otoKUTU.Tick
        On Error Resume Next
        If Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
            If CheckBox3.Checked = True Then
                king_send.Send("{F1}")
            End If
        End If
    End Sub

    Private Sub otoMADEN_Tick(sender As Object, e As EventArgs) Handles otoMADEN.Tick
        On Error Resume Next
        If Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
                king_send.Send("f")
        End If
    End Sub

    Private Sub otoSS_Tick(sender As Object, e As EventArgs) Handles otoSS.Tick
        If Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
            If skill1.Checked = True Then
                king_send.Send("1")
            End If

            If skill2.Checked = True Then
                king_send.Send("2")
            End If

            If skill3.Checked = True Then
                king_send.Send("3")
            End If

            If skill4.Checked = True Then
                king_send.Send("4")
            End If

            If skill5.Checked = True Then
                king_send.Send("5")
            End If

            If skill6.Checked = True Then
                king_send.Send("6")
            End If

            If skill7.Checked = True Then
                king_send.Send("7")
            End If

            If skill8.Checked = True Then
                king_send.Send("8")
            End If

            If skill9.Checked = True Then
                king_send.Send("9")
            End If

            If skill0.Checked = True Then
                king_send.Send("0")
            End If

            If skilly.Checked = True Then
                king_send.Send("*")
            End If

            If skillt.Checked = True Then
                king_send.Send("-")
            End If

            If F4.Checked = True Then
                king_send.Send("{F4}")
            End If

            If F5.Checked = True Then
                king_send.Send("{F5}")
            End If

            If F6.Checked = True Then
                king_send.Send("{F6}")
            End If

            If F7.Checked = True Then
                king_send.Send("{F7}")
            End If

            If F8.Checked = True Then
                king_send.Send("{F8}")
            End If

            If F9.Checked = True Then
                king_send.Send("{F9}")
            End If

            If F10.Checked = True Then
                king_send.Send("{F10}")
            End If

            If F11.Checked = True Then
                king_send.Send("{F11}")
            End If

            If F12.Checked = True Then
                king_send.Send("{F12}")
            End If

            bilgi.Text = "Tuş Gönderiliyor"
        Else
            bilgi.Text = "Oyun Bekleniyor.."
        End If

    End Sub

    Private Sub otoR_Tick(sender As Object, e As EventArgs) Handles otoR.Tick
        If CheckBox5.Checked = True Or CheckBox6.Checked = True Or CheckBox7.Checked = True Or CheckBox8.Checked = True Then
            If Button2.Text = "Durdur" And king_send.WinGetState("PointeR - King Bot") = 15 Then
                king_send.Send("r")
                bilgi.Text = "Tuş Gönderiliyor"
            Else
                bilgi.Text = "Oyun Bekleniyor.."
            End If
        End If
    End Sub
#End Region

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            otoR.Start()
        Else
            otoR.Stop()
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            otoR.Start()
        Else
            otoR.Stop()
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            otoR.Start()
        Else
            otoR.Stop()
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            otoR.Start()
        Else
            otoR.Stop()
        End If
    End Sub

#Region "version"
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        For Each i As HtmlElement In WebBrowser1.Document.All
            login = i.InnerText
        Next
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        For Each i As HtmlElement In WebBrowser2.Document.All
            version_yeni.Text = i.InnerHtml
            kontrol.Start()
        Next
    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted
        For Each i As HtmlElement In WebBrowser3.Document.All
            guncel_indir = i.InnerHtml
        Next
    End Sub

    Private Sub WebBrowser4_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser4.DocumentCompleted
        For Each i As HtmlElement In WebBrowser4.Document.All
            paypal = i.InnerHtml
        Next
    End Sub

    Private Sub kontrol_Tick(sender As Object, e As EventArgs) Handles kontrol.Tick
        kontrol.Stop()
        If web_refresh = True Then
            If version_yeni.Text > version_eski.Text And login = "1" Then
                MsgBox("Eski version kullanıyorsunuz.Yeni Version: " & version_yeni.Text, MsgBoxStyle.Exclamation, "PointeR - KingBot")
                Button1.Visible = True
            ElseIf version_yeni.Text > version_eski.Text And login = "0" Then
                If MsgBox("Eski version kullanıyorsunuz.Yeni Version: " & version_yeni.Text & vbCrLf & "Bot kapatılıyor!" & vbCrLf & vbCrLf & "Güncel versionu indirmek ister misiniz ?", MsgBoxStyle.YesNo, "PointeR - KingBot") = MsgBoxResult.Yes Then
                    Process.Start(guncel_indir)
                    Application.Exit()
                Else
                    Application.Exit()
                End If
            End If
        End If
        If web_refresh = False Then
            WebBrowser1.Refresh()
            WebBrowser1.Navigate("https://raw.githubusercontent.com/lPointeRl/KingBot/master/login.git")
            WebBrowser2.Refresh()
            WebBrowser2.Navigate("https://raw.githubusercontent.com/lPointeRl/KingBot/master/version.git")
            WebBrowser3.Refresh()
            WebBrowser3.Navigate("https://raw.githubusercontent.com/lPointeRl/KingBot/master/download.git")
            WebBrowser4.Refresh()
            WebBrowser4.Navigate("https://raw.githubusercontent.com/lPointeRl/KingBot/master/paypal.git")
            web_refresh = True
        End If
    End Sub

    Private Function version_bul()
        login = True
    End Function

    Private Function giris_kontrol()
        For Each i As HtmlElement In WebBrowser1.Document.All
            If i.InnerHtml = "1" Then
                MsgBox("kapanıyor")
            End If
        Next
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        paypal = paypal.Replace("amp;", "")
        If paypal.Length > 0 Then
            Process.Start(paypal)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(guncel_indir)
    End Sub
#End Region

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            ' CheckBox10.Enabled = True
            CheckBox9.ForeColor = Color.YellowGreen
            topmost.Start()
        Else
            '  CheckBox10.Enabled = False
            CheckBox10.Checked = False
            CheckBox9.ForeColor = Color.SandyBrown
            king_send.WinSetOnTop("King Bot", "", 0)
            topmost.Stop()
        End If
    End Sub

    Private Sub topmost_Tick(sender As Object, e As EventArgs) Handles topmost.Tick
        If king_send.WinGetState("PointeR - King Bot") = 15 Then
            king_send.WinSetOnTop("King Bot", "", 1)
            king_send.WinSetState("King Bot", "", 1)
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox10.ForeColor = Color.YellowGreen
        Else
            CheckBox10.ForeColor = Color.Peru
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button7.Text = "Durdur" Then
            MsgBox("Lütfen önce macro'yu durdurun!", MsgBoxStyle.Critical)
        Else
            If Button8.Text = "Kayıt" Then
                Button8.BackColor = Color.DarkRed
                Button8.Text = "Durdur"
                macro_kayit.Interval = NumericUpDown1.Value
                macro_kayit.Start()
            Else
                Button8.BackColor = Color.ForestGreen
                Button8.Text = "Kayıt"
                macro_kayit.Stop()
                ListBox1.Items.RemoveAt(0)
                ListBox1.Items.RemoveAt(0)
                ListBox2.Items.RemoveAt(0)
                ListBox2.Items.RemoveAt(0)
                ListBox1.SelectedIndex = 0
                ListBox2.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button8.Text = "Durdur" Then
            MsgBox("Lütfen önce kaydı durdurun!", MsgBoxStyle.Critical)
        Else
            If Button7.Text = "Başlat" Then
                Button7.BackColor = Color.DarkRed
                Button7.Text = "Durdur"
                Try
                    macro_baslat.Interval = NumericUpDown2.Value
                    ListBox1.SelectedIndex = 0
                    ListBox2.SelectedIndex = 0
                    Val1 = 0
                    Val0 = 0
                    macro_baslat.Start()
                Catch ex As Exception
                End Try

            Else
                Button7.BackColor = Color.ForestGreen
                Button7.Text = "Başlat"
                macro_baslat.Stop()
            End If
        End If
    End Sub

    Private Sub macro_baslat_Tick(sender As Object, e As EventArgs) Handles macro_baslat.Tick
        If Not Val1 = Val(NumericUpDown3.Value) Then
            Play()
        Else
            Button7.PerformClick()
            macro_baslat.Stop()
        End If
    End Sub
    Private Sub macro_kayit_Tick(sender As Object, e As EventArgs) Handles macro_kayit.Tick
        Record(MousePosition.X, MousePosition.Y)
    End Sub

    Public Sub Record(ByVal PosX As String, ByVal PosY As String)
        PosX = MousePosition.X
        PosY = MousePosition.Y
        ListBox1.Items.Add(PosX)
        ListBox2.Items.Add(PosY)

        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        ListBox2.SelectedIndex = ListBox2.Items.Count - 1

        Mouse_LeftClick = GetAsyncKeyState(Keys.LButton)
        If Mouse_LeftClick Then
            ListBox1.Items.Add("KingBot_0")
            ListBox2.Items.Add("KingBot_0")
        End If

        Mouse_RightClick = GetAsyncKeyState(Keys.RButton)
        If Mouse_RightClick Then
            ListBox1.Items.Add("KingBot_1")
            ListBox2.Items.Add("KingBot_1")
        End If

        Mouse_MiddleClick = GetAsyncKeyState(Keys.MButton)
        If Mouse_MiddleClick Then
            ListBox1.Items.Add("KingBot_2")
            ListBox2.Items.Add("KingBot_2")
        End If
    End Sub
    Private Sub Play()
        Try
            Dim Location As New Point(ListBox1.Text, ListBox2.Text)
            Cursor.Position = Location
        Catch Ex As Exception

        End Try

        Try
            If ListBox1.Text = ("KingBot_0") Then
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, New IntPtr)
            End If

            If ListBox1.Text = ("KingBot_1") Then
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, New IntPtr)
            End If

            If ListBox1.Text = ("KingBot_2") Then
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, New IntPtr)
            End If
        Catch Ex As Exception
        End Try

        Try
            If Val0 = ListBox1.Items.Count - 1 Then
                Val0 = 0
                ListBox1.SetSelected(0, True)
                ListBox2.SetSelected(0, True)
                Val1 = Val1 + 1
                Label36.Text = Val1
            Else
                ListBox1.SetSelected(Val0, True)
                ListBox2.SetSelected(Val0, True)
                Val0 = Val0 + 1
            End If
        Catch Ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Silmek istediğinizden emin misiniz ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        SaveFileDialog1.Title = "PointeR - Macro Kaydet"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            macro_yolu = SaveFileDialog1.FileName
            Dim Macro_Part1 As String = macro_yolu & ".pointer"
            Dim Macro_Part2 As String = macro_yolu & "cs2.pointer"
            Dim Macro_Part3 As String = macro_yolu & "xS0.pointer"
            Try
                Dim Saveval As Integer = 1
                Saveval = Saveval - 1
                For i = 0 To ListBox1.Items.Count - 1
                    ListBox1.SetSelected(i, True)
                    Dim Listwrite1 As System.IO.StreamWriter
                    Listwrite1 = My.Computer.FileSystem. _
                    OpenTextFileWriter(Macro_Part1, True)
                    Listwrite1.WriteLine(ListBox1.Items(i))
                    Listwrite1.Close()
                Next


                For i = 0 To ListBox2.Items.Count - 1
                    ListBox2.SetSelected(i, True)
                    Dim Listwrite1 As System.IO.StreamWriter
                    Listwrite1 = My.Computer.FileSystem. _
                    OpenTextFileWriter(Macro_Part2, True)
                    Listwrite1.WriteLine(ListBox2.Items(i))
                    Listwrite1.Close()
                Next

                Dim SW As System.IO.StreamWriter
                SW = My.Computer.FileSystem. _
                OpenTextFileWriter(Macro_Part3, True)
                SW.WriteLine("$OPTION SET {Allow_Change} ; RETURN {Allow_Change}, (FALSE);")
                SW.WriteLine(NumericUpDown1.Value)
                SW.WriteLine(NumericUpDown2.Value)
                SW.WriteLine(NumericUpDown3.Value)
                SW.WriteLine("*******************")
                SW.WriteLine("*Pointer - KingBot*")
                SW.WriteLine("*******************")
                SW.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenFileDialog1.FileName = ".pointer"
        OpenFileDialog1.Title = "Lütfen macroyu seçin"
        OpenFileDialog1.Filter = "pointer dosyaları (*.  pointer) |*.pointer"
        OpenFileDialog1.ShowDialog()
        macro_yolu = OpenFileDialog1.FileName
        Label34.Text = macro_yolu
        macro_yolu = macro_yolu.Replace(".pointer", "")
        Dim Macro_Part1 As String = macro_yolu & ".pointer"
        Dim Macro_Part2 As String = macro_yolu & "cs2.pointer"
        Dim Macro_Part3 As String = macro_yolu & "xS0.pointer"

        Try
            Dim FileLine As Short
            Dim StringData As String
            FileLine = FreeFile()
            FileOpen(FileLine, Macro_Part1, OpenMode.Input)
            ListBox1.Items.Clear()
            While Not EOF(FileLine)
                StringData = LineInput(FileLine)
                StringData = StringData.Replace("ï»¿", "")
                ListBox1.Items.Add((StringData))
            End While
            FileClose(FileLine)
        Catch Ex As Exception
        End Try

        Try
            Dim FileLine1 As Short
            Dim StringData1 As String
            FileLine1 = FreeFile()

            FileOpen(FileLine1, Macro_Part2, OpenMode.Input)
            ListBox2.Items.Clear()
            While Not EOF(FileLine1)
                StringData1 = LineInput(FileLine1)
                StringData1 = StringData1.Replace("ï»¿", "")
                ListBox2.Items.Add((StringData1))
            End While
            FileClose(FileLine1)
        Catch Ex As Exception
        End Try

        Try
            Dim FileLine2 As Short
            Dim StringData2 As String
            FileLine2 = FreeFile()
            FileOpen(FileLine2, Macro_Part3, OpenMode.Input)
            ListBox3.Items.Clear()
            While Not EOF(FileLine2)
                StringData2 = LineInput(FileLine2)
                StringData2 = StringData2.Replace("ï»¿", "")
                ListBox3.Items.Add((StringData2))
            End While
            FileClose(FileLine2)
        Catch ex As Exception
        End Try

        Try
            NumericUpDown1.Value = ListBox3.Items.Item(1)
            NumericUpDown2.Value = ListBox3.Items.Item(2)
            NumericUpDown3.Value = ListBox3.Items.Item(3)
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If macro_yolu = "" Then
            MsgBox("Lütfen 'Macro Aç' bölümüne kayıtlı macro yolunu gösterin", MsgBoxStyle.Information)
        Else
            RichTextBox1.Visible = True
            Me.Height = 485
            analyzer()
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        RichTextBox1.Visible = False
        Me.Height = 308
    End Sub

    Private Sub macro_genel_Tick(sender As Object, e As EventArgs) Handles macro_genel.Tick
        Global_Hotkey()
        ToolStripStatusLabel2.Text = ListBox1.Items.Count
        ToolStripStatusLabel4.Text = ListBox2.Items.Count
    End Sub



    Private Sub Global_Hotkey()
        On Error Resume Next
        CTRL_Key = GetAsyncKeyState(Keys.ControlKey)
        Shift_Key = GetAsyncKeyState(Keys.ShiftKey)
        R_Key = GetAsyncKeyState(Keys.R)
        S_Key = GetAsyncKeyState(Keys.S)
        P_Key = GetAsyncKeyState(Keys.P)
        E_Key = GetAsyncKeyState(Keys.E)
        X_Key = GetAsyncKeyState(Keys.X)
        Z_Key = GetAsyncKeyState(Keys.Z)
        T_Key = GetAsyncKeyState(Keys.T)
        O_Key = GetAsyncKeyState(Keys.O)

        If CTRL_Key And Shift_Key And R_Key Then
            macro_kayit.Interval = NumericUpDown1.Value
            macro_kayit.Start()
            Button8.BackColor = Color.DarkRed
            Button8.Text = "Durdur"
            sil = True
        End If

        If CTRL_Key And Shift_Key And S_Key Then
            macro_kayit.Stop()
            Button8.BackColor = Color.ForestGreen
            Button8.Text = "Kayıt"
            If sil = True Then
                sil = False
                ListBox1.Items.RemoveAt(0)
                ListBox1.Items.RemoveAt(0)
                ListBox2.Items.RemoveAt(0)
                ListBox2.Items.RemoveAt(0)
                ListBox1.SelectedIndex = 0
                ListBox2.SelectedIndex = 0
            End If
        End If

        If CTRL_Key And Shift_Key And P_Key Then
            macro_baslat.Interval = NumericUpDown2.Value
            ListBox1.SelectedIndex = 0
            ListBox2.SelectedIndex = 0
            Val1 = 0
            Val0 = 0
            Button7.BackColor = Color.DarkRed
            Button7.Text = "Durdur"
            macro_baslat.Start()
        End If

        If CTRL_Key And Shift_Key And Z_Key Then
            macro_baslat.Stop()
            Button7.BackColor = Color.ForestGreen
            Button7.Text = "Başlat"
        End If

        If CTRL_Key And E_Key Then
            Me.Close()
        End If

        If CTRL_Key And Shift_Key And X_Key Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
        End If

        If CTRL_Key And Shift_Key And O_Key Then
            For i = 0 To 1
                Play()
            Next
        End If


        If CTRL_Key And Shift_Key And T_Key Then
            For a = 0 To ListBox1.Items.Count - 1
                For b = 0 To Val(NumericUpDown3.Value)
                    Play()
                Next
            Next
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Clipboard.SetText(ListBox3.SelectedItem)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        TabControl1.SelectedIndex = 1
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox11.ForeColor = Color.YellowGreen
            otoMADEN.Start()
        Else
            CheckBox11.ForeColor = Color.SandyBrown
            otoMADEN.Start()
        End If
    End Sub

    Private Sub bot_baslat_durdur_Tick(sender As Object, e As EventArgs) Handles bot_baslat_durdur.Tick
        C_Key = GetAsyncKeyState(Keys.C)

        If Shift_Key And C_Key Then
            Button2.PerformClick()
        End If
    End Sub
End Class
