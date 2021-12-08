Imports MySql.Data.MySqlClient

Module Module1
    Public score As Integer = 0
    Public pname As String
    Public level As Integer
    Public Function imageCollide(ByVal object1 As Object, object2 As Object) As Boolean
        Dim imageCollided As Boolean = False
        If object1.Top + object1.Height >= object2.Top And
            object2.Top + object2.Height >= object1.Top And
            object1.Left + object1.Width >= object2.Left And
            object2.Left + object2.Width >= object1.Left And
            object1.Visible = True And object2.Visible = True Then
            imageCollided = True
        End If
        Return imageCollided
    End Function
    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=127.0.0.1 ;user id=root; password= ;database=fpdb")
    End Function


    Public strcon As MySqlConnection = strstrconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable


    Public Sub SQLquery(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                'EXECUTE THE DATA
                result = cmd.ExecuteNonQuery
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub


    Public Sub LoadtoGrid(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
        da.Dispose()
    End Sub


End Module
