Module Utility

    Public ActiveID As Integer
    Public ActiveUsername As String

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
        If Not sender.ActiveControl Is btnExit Then
            End
        End If
    End Sub

    Function Integering(Sender As TextBox, eChar As Char) As Boolean

        'Anti titik di awal
        If Asc(eChar) = 46 And String.IsNullOrEmpty(Sender.Text) Then
            Return True

            'Anti titik lebih dari 1
        ElseIf Asc(eChar) = 46 And Val(Sender.Text) - Int(Val(Sender.Text)) <> 0 Then
            Return True

            'Anti titik double
        ElseIf String.IsNullOrEmpty(Sender.Text) = False And Asc(eChar) = 46 Then
            If (Sender.Text).Last() = "." Then
                Return True
            End If

            'Numeric Only
        ElseIf Asc(eChar) <> 8 Then
            If Asc(eChar) < 48 Or Asc(eChar) > 57 Then
                Return True

                'unZero Di Awal kecuali solo
            ElseIf Sender.Text = "0" Then
                Sender.Text = ""
            End If
        End If
        Return False
    End Function


End Module
