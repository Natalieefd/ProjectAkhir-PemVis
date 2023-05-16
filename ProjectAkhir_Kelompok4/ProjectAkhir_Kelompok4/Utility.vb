Module Utility

    Function EmptyTB(Optional sender As Object = Nothing) As Boolean
        'Misal gamau form, maunya groupbox gitu OwO
        'Isi parameternya pakai nama groupbox

        If sender Is Nothing Then
            sender = Form.ActiveForm
        End If

        For Each control In sender.Controls

            If control.GetType Is GetType(TextBox) Then
                If control.Text = Nothing Then
                    Return True
                End If

            ElseIf control.GetType Is GetType(GroupBox) Then
                For Each control2 In control.Controls
                    If control2.Text = Nothing Then
                        Return True
                    End If
                Next
            End If

        Next

        Return False
    End Function

    Sub CloseForm(sender As Object, btnExit As Button)
        If Not sender.ActiveControl Is btnExit Then
            End
        End If
    End Sub

End Module
