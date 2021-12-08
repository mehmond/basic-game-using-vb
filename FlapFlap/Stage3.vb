Public Class Stage3
    Dim y As Integer = 0
    Dim gravity As Single = 2
    Dim bossHp As Integer = 150
    Dim frameCount As Integer = 1
    Dim fireCountAir As Integer = 1
    Dim fireCount As Integer = 1
    Dim bossCount As Integer = 1
    Dim dieCount As Integer = 1
    Dim time As Integer = 0
    Dim fb1(1) As PictureBox
    Dim fb2(1) As PictureBox
    Dim fb3(1) As PictureBox
    Dim fb4(1) As PictureBox
    Dim gapBetweenPipes As Integer = 630

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pb_ground.BringToFront()
        If bossHp <= 0 Then
            SQLquery("UPDATE `tblplayer` SET `Level` = '0' WHERE `pname` = '" & pname & "'")
            congrats.Show()
            Me.Close()
        End If
        If imageCollide(pb_bird, pb_air) = True Then
            pb_bird.Top = 25
        End If
        If imageCollide(pb_bird, pb_ground) = True Then
            My.Computer.Audio.Play(My.Resources.sonicboom, AudioPlayMode.Background)
            Timer1.Stop()
            tm_gravity.Stop()
            tm_die.Start()
        End If
        If imageCollide(pb_bird, pb_boss) = True And tm_attack.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.fire_bow_sound_mike_koenig, AudioPlayMode.Background)
            bossHp -= 3
        End If
        For i = 0 To 1
            fb1(i).Left -= 10
            fb2(i).Left -= 7
            Select Case frameCount
                Case 1
                    fb1(i).Image = My.Resources.fb1
                    frameCount += 1
                Case 2
                    fb1(i).Image = My.Resources.fb2
                    frameCount += 1
                Case 3
                    fb1(i).Image = My.Resources.fb3
                    frameCount += 1
                Case 4
                    fb1(i).Image = My.Resources.fb4
                    frameCount = 1
            End Select
            Select Case frameCount
                Case 1
                    fb2(i).Image = My.Resources.fb1
                    frameCount += 1
                Case 2
                    fb2(i).Image = My.Resources.fb2
                    frameCount += 1
                Case 3
                    fb2(i).Image = My.Resources.fb3
                    frameCount += 1
                Case 4
                    fb2(i).Image = My.Resources.fb4
                    frameCount = 1
            End Select
            If imageCollide(pb_bird, fb1(i)) = True Or imageCollide(pb_bird, fb2(i)) = True Then
                My.Computer.Audio.Play(My.Resources.sonicboom, AudioPlayMode.Background)
                Timer1.Stop()
                tm_gravity.Stop()
                tm_die.Start()
            End If
            If fb1(i).Left < -30 Then
                fb1(i).Left += 400 + 20 * Rnd()
                fb1(i).Top = 50 - 150 * Rnd()
            End If
            If fb2(i).Left < -30 Then
                fb2(i).Left += 500 + 50 * Rnd()
                fb2(i).Top = 50 + 390 * Rnd()
            End If
        Next
        'For i = 0 To 1
        '    fb3(i).Left -= 3
        '    fb4(i).Left -= 3
        '    If fb3(i).Left < -130 Then
        '        fb3(i).Left += 1000
        '    End If
        '    If fb4(i).Left < -50 Then
        '        fb4(i).Left += 678
        '        fb4(i).Top = 50 + 290 * Rnd()
        '        fb4(i).Top = fb3(i).Top - gapBetweenPipes
        '    End If
        'Next
    End Sub

    Private Sub Stage3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space And tm_die.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background)
            y = -11
        End If
        If e.KeyCode = Keys.Right And tm_die.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Flame_Arrow_SoundBible_com_618067908, AudioPlayMode.Background)
            tm_attack.Start()
            tm_gravity.Stop()
        End If
        If e.KeyCode = Keys.Enter Then
            lb_objectives.Visible = False
            lb_start.Visible = False
            Timer1.Start()
            tm_gravity.Start()
            Timer2.Start()
        End If
    End Sub

    Private Sub Stage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        'pb_bird.Parent = PictureBox1
        'pb_boss.Parent = PictureBox1
        'pb_air.Parent = PictureBox1
        'pb_ground.Parent = PictureBox1
        CreateFireBall1(1)
        CreateFireball2(1)
        'CreateFireball3(1)
        'CreateFireball4(1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case fireCount
            Case 1
                pb_ground.Image = My.Resources.firewall1
                fireCount += 1
            Case 2
                pb_ground.Image = My.Resources.firewall2
                fireCount = 1
        End Select
        'Select Case fireCountAir
        '    Case 1
        '        pb_air.Image = My.Resources.firewall3
        '        fireCountAir += 1
        '    Case 2
        '        pb_air.Image = My.Resources.firewall4
        '        fireCountAir = 1
        'End Select
        pb_boss.Top += 10
        If pb_boss.Top > 330 Then
            Timer2.Stop()
            Timer3.Start()
        End If
        If pb_boss.Top < 4 * 50 + 450 * Rnd() And Timer5.Enabled = False Then
            Timer4.Start()
        ElseIf pb_boss.Top > 50 + 450 * Rnd() And Timer5.Enabled = False Then
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Select Case fireCount
            Case 1
                pb_ground.Image = My.Resources.firewall1
                fireCount += 1
            Case 2
                pb_ground.Image = My.Resources.firewall2
                fireCount = 1
        End Select
        'Select Case fireCountAir
        '    Case 1
        '        pb_air.Image = My.Resources.firewall3
        '        fireCountAir += 1
        '    Case 2
        '        pb_air.Image = My.Resources.firewall4
        '        fireCountAir = 1
        'End Select
        pb_boss.Top -= 10
        If pb_boss.Top < 25 Then
            Timer3.Stop()
            Timer2.Start()
        End If
        If pb_boss.Top < 3 * 150 + 350 * Rnd() And Timer5.Enabled = False Then
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pb_boss.Left -= 15
        If pb_boss.Left <= 60 Then
            Timer4.Stop()
            Timer5.Start()
        End If
        
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        pb_boss.Left += 15
        If pb_boss.Left >= 315 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub CreateFireBall1(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            'temp.Parent = PictureBox1
            temp.Width = 100
            temp.Height = 15
            temp.BackColor = Color.Transparent
            temp.Image = My.Resources.fb1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 700
            fb1(i) = temp
            fb1(i).Visible = True
        Next
    End Sub

    Private Sub CreateFireball2(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            'temp.Parent = PictureBox1
            temp.Width = 100
            temp.Height = 15
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.fb1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = fb1(i).Top - 150 * Rnd()
            temp.Left = (i * 200) + 700
            fb2(i) = temp
            fb2(i).Visible = True
        Next
    End Sub

    Private Sub CreateFireball3(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            'temp.Parent = PictureBox1
            temp.Width = 30
            temp.Height = 300
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.fw1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 600
            fb3(i) = temp
            fb3(i).Visible = False
        Next
    End Sub

    Private Sub CreateFireball4(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            'temp.Parent = PictureBox1
            temp.Width = 30
            temp.Height = 300
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.fw1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = fb3(i).Top - gapBetweenPipes
            temp.Left = (i * 200) + 600
            fb4(i) = temp
            fb4(i).Visible = True
        Next
    End Sub

    Private Sub tm_gravity_Tick(sender As Object, e As EventArgs) Handles tm_gravity.Tick
        y += gravity
        pb_bird.Top += y
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
    End Sub

    Private Sub tm_attack_Tick(sender As Object, e As EventArgs) Handles tm_attack.Tick
        If tm_die.Enabled = True Then
            tm_attack.Stop()
        End If
        pb_bird.BringToFront()
        pb_bird.Left += 4
        If pb_bird.Left >= 82 Then
            pb_bird.Left -= 4
            pb_bird.Left = 31
            tm_attack.Stop()
            tm_gravity.Start()
        End If
        Select Case frameCount
            Case 1
                pb_bird.Image = My.Resources.att1
                frameCount += 1
            Case 2
                pb_bird.Image = My.Resources.att2
                frameCount += 1
            Case 3
                pb_bird.Image = My.Resources.att3
                frameCount += 1
            Case 4
                pb_bird.Image = My.Resources.att4
                frameCount = 1
        End Select
    End Sub

    Private Sub tm_die_Tick(sender As Object, e As EventArgs) Handles tm_die.Tick
        tm_attack.Stop()
        pb_bird.SizeMode = PictureBoxSizeMode.CenterImage
        pb_bird.Width = 50
        pb_bird.Height = 50
        Select Case dieCount
            Case 1
                pb_bird.Image = My.Resources.die1
                dieCount += 1
            Case 2
                pb_bird.Image = My.Resources.die2
                dieCount += 1
            Case 3
                pb_bird.Image = My.Resources.die3
                dieCount += 1
            Case 3
                pb_bird.Image = My.Resources.die4
                dieCount += 1
            Case 5
                pb_bird.Image = My.Resources.die5
                dieCount += 1
            Case 6
                pb_bird.Image = My.Resources.die6
        End Select
        time += 1
        If time >= 10 Then
            gameover.Show()
            Me.Close()
        End If
    End Sub
End Class