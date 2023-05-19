Imports MySql.Data.MySqlClient

Module Database
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As DataSet

    Sub koneksi()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=dbkpopstore"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub dbq(query As String)
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader
        RD.Read()
    End Sub

    Sub AkunSeqID(mode As String)
        Dim tabel = If(mode = "customer", "cust", "staff")

        dbq("Select * from tb" & mode & " where id_" & tabel & "='" & ActiveID & "'")
    End Sub

    Sub dbdsq(query As String)
        DA = New MySqlDataAdapter(query, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb")
    End Sub

End Module

