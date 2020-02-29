Public Class Form3
    Dim P As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        P = 1
    End Sub
    Private Sub TextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        P = 2
    End Sub
    Private Sub TextBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.Click
        P = 3
    End Sub
    Private Sub TextBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Click
        P = 4
    End Sub
    Private Sub TextBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Click
        P = 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "1"
            Case 2
                TextBox3.Text = TextBox3.Text + "1"
            Case 3
                TextBox6.Text = TextBox6.Text + "1"
            Case 4
                TextBox7.Text = TextBox7.Text + "1"
            Case 5
                TextBox4.Text = TextBox4.Text + "1"
        End Select
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "2"
            Case 2
                TextBox3.Text = TextBox3.Text + "2"
            Case 3
                TextBox6.Text = TextBox6.Text + "2"
            Case 4
                TextBox7.Text = TextBox7.Text + "2"
            Case 5
                TextBox4.Text = TextBox4.Text + "2"
        End Select
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "3"
            Case 2
                TextBox3.Text = TextBox3.Text + "3"
            Case 3
                TextBox6.Text = TextBox6.Text + "3"
            Case 4
                TextBox7.Text = TextBox7.Text + "3"
            Case 5
                TextBox4.Text = TextBox4.Text + "3"
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "4"
            Case 2
                TextBox3.Text = TextBox3.Text + "4"
            Case 3
                TextBox6.Text = TextBox6.Text + "4"
            Case 4
                TextBox7.Text = TextBox7.Text + "4"
            Case 5
                TextBox4.Text = TextBox4.Text + "4"
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "5"
            Case 2
                TextBox3.Text = TextBox3.Text + "5"
            Case 3
                TextBox6.Text = TextBox6.Text + "5"
            Case 4
                TextBox7.Text = TextBox7.Text + "5"
            Case 5
                TextBox4.Text = TextBox4.Text + "5"
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "6"
            Case 2
                TextBox3.Text = TextBox3.Text + "6"
            Case 3
                TextBox6.Text = TextBox6.Text + "6"
            Case 4
                TextBox7.Text = TextBox7.Text + "6"
            Case 5
                TextBox4.Text = TextBox4.Text + "6"
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "7"
            Case 2
                TextBox3.Text = TextBox3.Text + "7"
            Case 3
                TextBox6.Text = TextBox6.Text + "7"
            Case 4
                TextBox7.Text = TextBox7.Text + "7"
            Case 5
                TextBox4.Text = TextBox4.Text + "7"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "8"
            Case 2
                TextBox3.Text = TextBox3.Text + "8"
            Case 3
                TextBox6.Text = TextBox6.Text + "8"
            Case 4
                TextBox7.Text = TextBox7.Text + "8"
            Case 5
                TextBox4.Text = TextBox4.Text + "8"
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "9"
            Case 2
                TextBox3.Text = TextBox3.Text + "9"
            Case 3
                TextBox6.Text = TextBox6.Text + "9"
            Case 4
                TextBox7.Text = TextBox7.Text + "9"
            Case 5
                TextBox4.Text = TextBox4.Text + "9"
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "0"
            Case 2
                TextBox3.Text = TextBox3.Text + "0"
            Case 3
                TextBox6.Text = TextBox6.Text + "0"
            Case 4
                TextBox7.Text = TextBox7.Text + "0"
            Case 5
                TextBox4.Text = TextBox4.Text + "0"
        End Select
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Select Case P
            Case 1
                TextBox2.Clear()
            Case 2
                TextBox3.Clear()
            Case 3
                TextBox6.Clear()
            Case 4
                TextBox7.Clear()
            Case 5
                TextBox4.Clear()
        End Select
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Select Case P
            Case 1
                If (InStr(TextBox2.Text, ",") = 0) And (Len(TextBox2.Text) > 0) Then
                    TextBox2.Text = TextBox2.Text + ","
                End If
            Case 2
                If (InStr(TextBox3.Text, ",") = 0) And (Len(TextBox3.Text) > 0) Then
                    TextBox3.Text = TextBox3.Text + ","
                End If
            Case 3
                If (InStr(TextBox6.Text, ",") = 0) And (Len(TextBox6.Text) > 0) Then
                    TextBox6.Text = TextBox6.Text + ","
                End If
            Case 4
                If (InStr(TextBox7.Text, ",") = 0) And (Len(TextBox7.Text) > 0) Then
                    TextBox7.Text = TextBox7.Text + ","
                End If
            Case 5
                If (InStr(TextBox4.Text, ",") = 0) And (Len(TextBox4.Text) > 0) Then
                    TextBox4.Text = TextBox4.Text + ","
                End If
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As String
        i = "Описание:"
        TextBox1.Text = i
        TextBox1.Text = TextBox1.Text & vbNewLine & "Данный раздела калькулятора создан для вычисления силы тока ,сопративления и напряжения тока."
        TextBox1.Text = TextBox1.Text & vbNewLine & "Cейчас я, внутриний голос этого калькулятора расскажу как ей пользоваться."
        TextBox1.Text = TextBox1.Text & vbNewLine & "Вам необходимо ввести нужные вам данные для вычесления"
        TextBox1.Text = TextBox1.Text & vbNewLine & "После чего нужно выбрать нужную вам функцию и нажать на нее"
        TextBox1.Text = TextBox1.Text & vbNewLine & "И ура, ваш ответ готов"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox5.Text = "Cила тока = " + CStr(CDbl(TextBox3.Text) / (CDbl(TextBox7.Text))) + "(ампер)"
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = "Напряжение = " + CStr(CDbl(TextBox2.Text) / (CDbl(TextBox7.Text))) + "(вольт)"
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox5.Text = "Сопративление = " + CStr(CDbl(TextBox6.Text) / (CDbl(TextBox4.Text))) + "(ом)"
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox7.Clear()
        TextBox6.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Select Case P
            Case 1
                TextBox2.Text = TextBox2.Text + "-"
            Case 2
                TextBox3.Text = TextBox3.Text + "-"
            Case 3
                TextBox6.Text = TextBox6.Text + "-"
            Case 4
                TextBox7.Text = TextBox7.Text + "-"
            Case 5
                TextBox4.Text = TextBox4.Text + "-"
        End Select
    End Sub
End Class

