Public Class Stage1
    Dim y As Single = 0
    Dim gravity As Single = 2
    Dim pipe(1) As PictureBox
    Dim tPipe(1) As PictureBox
    Dim gaBetweenPipes As Integer = 430
    Dim pipeSpeed As Single = 3
    Dim frameCount As Integer = 1
    Dim dieCount As Integer = 1
    Dim time As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadtoGrid("SELECT playerName,level FROM tblplayer WHERE `playerName` = '" & pname & "'", DTGKO)
        lb_pname.Text = pname
        DTGKO.Enabled = False
        Randomize()
        CreatePipes(1)
        CreateTopPipes(1)
        pb_bird.Parent = pb_bg
        lb_start.Parent = pb_bg
        lb_enter.Parent = pb_bg
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Timer1.Enabled = False And e.KeyCode = Keys.Space Then
            Timer1.Enabled = False
        End If
        If e.KeyCode = Keys.Space And Timer2.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background)
            y = -11
        End If
        If e.KeyCode = Keys.Enter Then
            Timer1.Enabled = True
            lb_score.Visible = True
            lb_start.Visible = False
            lb_enter.Visible = False
            lb_score2.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
        lb_score2.Text = score
        y += gravity
        pb_bird.Top += y
        If score = 12 Then
            Timer1.Stop()
            congrats.Show()
            Me.Close()
        End If
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            tPipe(i).Left -= pipeSpeed
            If imageCollide(pipe(i), pb_bird) = True Or imageCollide(tPipe(i), pb_bird) Or
                imageCollide(pb_ground, pb_bird) Then
                My.Computer.Audio.Play(My.Resources.sonicboom, AudioPlayMode.Background)
                SQLquery("UPDATE `tblplayer` SET `Level` = '2' WHERE `pname` = '" & pname & "'")
                Timer1.Stop()
                Timer2.Start()
            End If
            If imageCollide(pb_bird, pb_air) = True Then
                pb_bird.Top = 25
            End If
            If pipe(i).Left < -10 Then
                score += 1
                pipe(i).Left += 400
                tPipe(i).Left += 400
                pipe(i).Top = 50 + 290 * Rnd()
                tPipe(i).Top = pipe(i).Top - gaBetweenPipes
            End If
        Next
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.BringToFront()
            temp.Parent = pb_bg
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.Transparent
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
            temp.Parent = pb_bg
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.Transparent
            temp.Image = My.Resources.pipe2
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = pipe(i).Top - gaBetweenPipes
            temp.Left = (i * 200) + 380
            tPipe(i) = temp
            tPipe(i).Visible = True
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pb_bird.SizeMode = PictureBoxSizeMode.CenterImage
        pb_bird.Width = 200
        pb_bird.Height = 200
        Select Case dieCount
            Case 1
                pb_bird.Top -= 88
                pb_bird.Left -= 88
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
        If time >= 5 Then
            gameover.Show()
            Me.Close()
        End If
    End Sub

End Class
