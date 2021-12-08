Public Class splash
    Dim time As Integer = 0
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Stage1.Close()
        score = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        If time >= 100 Then
            Stage1.Show()
            Me.Close()
        End If
    End Sub


    Private Sub splash_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class