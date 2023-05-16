﻿Imports MySql.Data.MySqlClient

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


End Module

