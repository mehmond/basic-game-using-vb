Public Class gameover

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
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
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub gameover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = score
    End Sub
End Class