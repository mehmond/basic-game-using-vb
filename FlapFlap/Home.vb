Public Class Home
    Dim frameCount As Integer = 1
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If DTGKO.Visible = False Then
            MsgBox("Search Player's Name First!")
        Else
            If level = 1 Then
                Stage1.Show()
                Me.Close()
            ElseIf level = 2 Then
                Stage2.Show()
                Me.Close()
            ElseIf level = 3 Then
                Stage3.Show()
                Me.Close()
            ElseIf level = 0 Then
                SQLquery("UPDATE `tblplayer` SET `Level` = '1' WHERE `pname` = '" & pname & "'")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pb_bird.SendToBack()
        Select Case frameCount
            Case 1
                pb_bird.Image = My.Resources.bird1
                frameCount += 1
            Case 2
                pb_bird.Image = My.Resources.bird2
                frameCount += 1
            Case 3
                pb_bird.Image = My.Resources.bird3
                frameCount += 1
            Case 4
                pb_bird.Image = My.Resources.bird4
                frameCount = 1
        End Select
        pb_bird.Left += 1
        If pb_bird.Left > 450 Then
            pb_bird.Left = -30
            pb_bird.Top = 50 + 290 * Rnd()
        End If
    End Sub

    Private Sub btn_score_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE `playerName` = '" & tb_search.Text & "'", DTGKO)
        DTGKO.Visible = True
        If tb_search.Text = vbNullString Then
            MsgBox("Input Player's Name")
        ElseIf DTGKO.CurrentCell Is Nothing Then
            DTGKO.Visible = True
            MsgBox("Player's Name Do not Exist!")
        Else
            MsgBox("Player Selected")
            LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE `playerName` = '" & tb_search.Text & "'", DTGKO)
            pname = DTGKO.CurrentRow.Cells(0).Value
            level = DTGKO.CurrentRow.Cells(1).Value
        End If
        tb_search.Clear()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE playerName = '" & tb_pname.Text & "'", DTGKO)
        DTGKO.Visible = True
        If tb_pname.Text = vbNullString Then
            MsgBox("Player Name Required!")
            LoadtoGrid("SELECT playerName,level FROM tblplayer", DTGKO)
        ElseIf DTGKO.CurrentCell Is Nothing Then           
            SQLquery("INSERT INTO tblplayer (`playerName`,`level`,`endlessRunScore`) VALUES ('" & tb_pname.Text & "','1','')")
            LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE playerName = '" & tb_pname.Text & "'", DTGKO)
            DTGKO.Visible = True
            MsgBox("Player Registered!")
            pname = DTGKO.CurrentRow.Cells(0).Value
            level = DTGKO.CurrentRow.Cells(1).Value
        Else
            LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE playerName = '" & tb_pname.Text & "'", DTGKO)
            MsgBox("Player Name Already Exist!")
        End If
        tb_pname.Clear()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bgmusic, AudioPlayMode.BackgroundLoop)
        DTGKO.Enabled = False
        Randomize()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.SendToBack()
        PictureBox1.Left -= 2
        Label2.Text = pname
        Label1.Text = DTGKO.ColumnCount
        If PictureBox1.Left < -20 Then
            PictureBox1.Left = 460
            PictureBox1.Top = 50 + 290 * Rnd()
        End If
        PictureBox2.SendToBack()
        PictureBox2.Left -= 1
        If PictureBox2.Left < -20 Then
            PictureBox2.Left = 460
            PictureBox2.Top = 50 + 290 * Rnd()
        End If
        PictureBox3.SendToBack()
        PictureBox3.Left -= 1
        If PictureBox3.Left < -20 Then
            PictureBox3.Left = 460
            PictureBox3.Top = 50 + 290 * Rnd()
        End If
    End Sub
End Class