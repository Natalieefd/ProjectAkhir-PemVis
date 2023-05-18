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

            ElseIf control.GetType Is GetType(GroupBox) Then
                For Each control2 In control.Controls
                    If control2.Text = Nothing Then
                        Return control2
                    End If
                Next
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

End Module
