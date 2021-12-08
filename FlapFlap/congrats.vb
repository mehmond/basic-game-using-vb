Public Class congrats
    Dim pipe(1) As PictureBox
    Dim tPipe(1) As PictureBox
    Dim gaBetweenPipes As Integer = 450
    Dim pipeSpeed As Single = 3
    Dim frameCount As Integer = 1
    Dim time As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreatePipes(1)
        CreateTopPipes(1)
        pb_bird.Parent = PictureBox1
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        If time >= 100 Then
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
                Home.Show()
                Me.Close()
            End If
        End If

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
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            tPipe(i).Left -= pipeSpeed
            If pipe(i).Left < -10 Then
                score += 1
                pipe(i).Left += 400
                tPipe(i).Left += 400
                pipe(i).Top = 240
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
            temp.Parent = PictureBox1
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.Transparent
            temp.Image = My.Resources.pipe1
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = 70 + 290
            temp.Left = (i * 200) + 300
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
            temp.BackColor = Color.Transparent
            temp.Image = My.Resources.pipe2
            temp.SizeMode = PictureBoxSizeMode.StretchImage
            temp.Top = pipe(i).Top - gaBetweenPipes
            temp.Left = (i * 200) + 300
            tPipe(i) = temp
            tPipe(i).Visible = True
        Next
    End Sub

End Class

