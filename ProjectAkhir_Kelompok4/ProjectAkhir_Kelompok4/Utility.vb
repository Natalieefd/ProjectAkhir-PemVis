Imports System.Data.SqlTypes

Module Utility

    Public ActiveID As Integer
    Public ActiveUsername As String

    Function EmptyTB(Optional sender As Object = Nothing) As Control
        'Misal gamau form, maunya groupbox gitu OwO
        'Isi parameternya pakai nama groupbox

        If sender Is Nothing Then
            sender = Form.ActiveForm
        End If

        For Each control In sender.Controls

            If control.GetType Is GetType(TextBox) Then
                If control.Text = Nothing Then
                    Return control
                End If

            ElseIf control.GetType Is GetType(ComboBox) Then
                If control.Text = Nothing Then
                    Return control
                End If

            ElseIf control.GetType Is GetType(GroupBox) Then
                Dim control2 = EmptyTB(control)
                If control2 IsNot Nothing Then
                    Return control2
                End If

            End If
        Next

        Return Nothing
    End Function

    Sub CloseForm(sender As Object, btnExit() As Object)

        Dim Force = True

        For Each button In btnExit
            If sender.ActiveControl Is button Then
                Force = False
                Exit For
            End If
        Next

        If Force Then
            End
        End If

    End Sub

    Sub CloseForm(sender As Object, btnExit As Object)
        If sender.ActiveControl IsNot btnExit Then
            End
        End If
    End Sub

    Function Numbering(e As KeyPressEventArgs) As Boolean
        Dim eChar As Char = e.KeyChar

        If Asc(eChar) <> 8 And Not eChar Like "[0-9]" Then
            Return True
        End If

        Return False

    End Function

    Function CheckNum(TextControl As TextBox) As Boolean
        For Each c As Char In TextControl.Text
            If Not c Like "[0-9]" Then
                Return False
            End If
        Next

        Return True
    End Function

    Sub AturGrid(Grids As DataGridView, ColumnWidth() As Integer,
                 Optional AutoSizeLast As Boolean = True,
                 Optional HeaderBackColor As Color = Nothing,
                 Optional HeaderForeColor As Color = Nothing)
        Grids.EnableHeadersVisualStyles = False
        Grids.RowHeadersVisible = False
        Grids.ReadOnly = True
        Grids.AllowUserToAddRows = False
        Grids.AllowUserToDeleteRows = False
        Grids.AllowUserToResizeRows = False
        Grids.AllowUserToResizeColumns = False

        HeaderBackColor = If(HeaderBackColor = Nothing, Color.DarkCyan, HeaderBackColor)
        HeaderForeColor = If(HeaderForeColor = Nothing, Color.White, HeaderForeColor)

        Dim i As Integer

        For i = 0 To Grids.ColumnCount - 1 Step 1
            If ColumnWidth(i) <> 0 Then
                Grids.Columns(i).Width = ColumnWidth(i)
                Grids.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                Grids.Columns(i).HeaderCell.Style.BackColor = HeaderBackColor
                Grids.Columns(i).HeaderCell.Style.ForeColor = HeaderForeColor
            Else
                Grids.Columns(i).Visible = False
            End If


        Next

        If AutoSizeLast Then
            Grids.Columns(Grids.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Function DGVValue(Dg As DataGridView, CellNum As Integer) As Object
        Return Dg.Rows(Dg.CurrentCell.RowIndex).Cells(CellNum).Value
    End Function

End Module
