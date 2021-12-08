Public Class Stage2
    Dim y As Single = 0
    Dim gravity As Single = 2
    Dim bird1(1) As PictureBox
    Dim bird2(1) As PictureBox
    Dim pipe(1) As PictureBox
    Dim tPipe(1) As PictureBox
    Dim gaBetweenPipes As Integer = 490
    Dim pipeSpeed As Single = 3
    Dim birdSpeed As Single = 5
    Dim frameCount As Integer = 1
    Dim enemyFrame As Integer = 1
    Dim dieCount As Integer = 1
    Dim time As Integer = 0
    Dim birdloc As Integer
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_air.Parent = PictureBox1
        pb_bird.Parent = PictureBox1
        pb_ground.Parent = PictureBox1
        lb_objective.Parent = PictureBox1
        lb_score.Parent = PictureBox1
        lb_score2.Parent = PictureBox1
        lb_start.Parent = PictureBox1
        score = 0
        Randomize()
        CreatePipes(1)
        CreateTopPipes(1)
        CreateEnemy1(1)
        CreateEnemy2(1)
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Timer1.Enabled = False And e.KeyCode = Keys.Space Then  
            Timer1.Enabled = False
        End If
        If e.KeyCode = Keys.Space And Timer2.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background)
            y = -11
        End If
        If e.KeyCode = Keys.Enter Then
            Timer1.Enabled = True
            tm_gravity.Enabled = True
            Label2.Visible = True
            lb_start.Visible = False
            lb_objective.Visible = False
            Label1.Visible = True
        End If
        If e.KeyCode = Keys.Right Then
            My.Computer.Audio.Play(My.Resources.Flame_Arrow_SoundBible_com_618067908, AudioPlayMode.Background)
            Timer3.Start()
            tm_gravity.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        birdloc = pb_bird.Left
        PictureBox1.SendToBack()
        If Timer3.Enabled = False Then
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
        End If
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            tPipe(i).Left -= pipeSpeed
            If imageCollide(pipe(i), pb_bird) = True Or imageCollide(tPipe(i), pb_bird) = True Or
                imageCollide(pb_ground, pb_bird) = True Then
                My.Computer.Audio.Play(My.Resources.sonicboom, AudioPlayMode.Background)
                Timer1.Stop()
                tm_gravity.Stop()
                Timer3.Stop()
                Timer2.Start()
            End If
            If imageCollide(pb_bird, pb_air) = True Then
                pb_bird.Top = 25
            End If
            If pipe(i).Left < -10 Then
                pipe(i).Left += 400
                tPipe(i).Left += 400
                pipe(i).Top = 50 + 290 * Rnd()
                tPipe(i).Top = pipe(i).Top - gaBetweenPipes
            End If
        Next
        Label1.Text = score
        If score = 20 Then
            SQLquery("UPDATE `tblplayer` SET `Level` = '3' WHERE `pname` = '" & pname & "'")
            Timer1.Stop()
            tm_gravity.Stop()
            congrats.Show()
            Me.Close()
        End If
        For i = 0 To 1
            bird1(i).Left -= birdSpeed
            bird2(i).Left -= birdSpeed
            If imageCollide(bird1(i), pb_bird) = True And pb_bird.Left > 31 Then
                My.Computer.Audio.Play(My.Resources.fire_bow_sound_mike_koenig, AudioPlayMode.Background)
                score += 1
                bird1(i).Left += 400
                bird1(i).Top = 50 + 290 * Rnd()
            End If
            If imageCollide(bird2(i), pb_bird) = True And pb_bird.Left > 31 Then
                My.Computer.Audio.Play(My.Resources.fire_bow_sound_mike_koenig, AudioPlayMode.Background)
                score += 1
                bird2(i).Left += 400
                bird2(i).Top = 150 + 390 * Rnd()
            ElseIf imageCollide(bird1(i), pb_bird) = True Or imageCollide(bird2(i), pb_bird) = True Or
            imageCollide(pb_ground, pb_bird) = True And Timer3.Enabled = False Then
                My.Computer.Audio.Play(My.Resources.sonicboom, AudioPlayMode.Background)
                Timer1.Stop()
                Timer2.Start()
                tm_gravity.Stop()
            End If

            If imageCollide(pb_bird, pb_air) = True Then
                pb_bird.Top = 25
            End If
            If bird1(i).Left < -30 Then
                bird1(i).Left += 400
                bird1(i).Top = 50 + 290 * Rnd()
            End If
            If bird2(i).Left < -30 Then
                bird2(i).Left += 400
                bird2(i).Top = bird1(i).Top - gaBetweenPipes + 20 * Rnd()
            End If
        Next
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            temp.Parent = PictureBox1
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.pipe1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 380
            pipe(i) = temp
            pipe(i).Visible = True
        Next
    End Sub

    Private Sub CreateTopPipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            temp.Parent = PictureBox1
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.pipe2
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = pipe(i).Top - gaBetweenPipes
            temp.Left = (i * 200) + 380
            tPipe(i) = temp
            tPipe(i).Visible = True
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pb_bird.BringToFront()
        Timer3.Stop()
        pb_bird.SizeMode = PictureBoxSizeMode.CenterImage
        pb_bird.Width = 100
        pb_bird.Height = 100
        Select Case dieCount
            Case 1
                pb_bird.Top -= 44
                pb_bird.Left -= 44
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

    Private Sub CreateEnemy1(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.SendToBack()
            temp.Parent = PictureBox1
            temp.Width = 30
            temp.Height = 30
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.enemy_bat
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 100 + 290 * Rnd()
            temp.Left = (i * 200) + 380
            bird1(i) = temp
            bird1(i).Visible = True
        Next
    End Sub

    Private Sub CreateEnemy2(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Parent = PictureBox1
            temp.SendToBack()
            temp.Width = 30
            temp.Height = 30
            temp.BackColor = Color.FromArgb(0, 0, 0, 0)
            temp.Image = My.Resources.enemy_bat
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 30 + 150 * Rnd()
            temp.Left = (i * 200) + 270
            bird2(i) = temp
            bird2(i).Visible = True
        Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pb_bird.BringToFront()
        pb_bird.Left += 4
        If pb_bird.Left >= 82 Then
            pb_bird.Left -= 4
            pb_bird.Left = 31
            Timer3.Stop()
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

    Private Sub tm_gravity_Tick(sender As Object, e As EventArgs) Handles tm_gravity.Tick
        y += gravity
        pb_bird.Top += y
    End Sub

End Class
