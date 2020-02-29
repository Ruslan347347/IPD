Public Class Form6
    Dim p As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
        TextBox13.Clear()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        p = 1
    End Sub
    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        p = 2
    End Sub
    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        p = 3
    End Sub
    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        p = 4
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        p = 5
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        p = 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "1"
            Case 2
                TextBox10.Text = TextBox10.Text + "1"
            Case 3
                TextBox8.Text = TextBox8.Text + "1"
            Case 4
                TextBox7.Text = TextBox7.Text + "1"
            Case 5
                TextBox4.Text = TextBox4.Text + "1"
            Case 6
                TextBox2.Text = TextBox2.Text + "1"
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "2"
            Case 2
                TextBox10.Text = TextBox10.Text + "2"
            Case 3
                TextBox8.Text = TextBox8.Text + "2"
            Case 4
                TextBox7.Text = TextBox7.Text + "2"
            Case 5
                TextBox4.Text = TextBox4.Text + "2"
            Case 6
                TextBox2.Text = TextBox2.Text + "2"
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "3"
            Case 2
                TextBox10.Text = TextBox10.Text + "3"
            Case 3
                TextBox8.Text = TextBox8.Text + "3"
            Case 4
                TextBox7.Text = TextBox7.Text + "3"
            Case 5
                TextBox4.Text = TextBox4.Text + "3"
            Case 6
                TextBox2.Text = TextBox2.Text + "3"
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "4"
            Case 2
                TextBox10.Text = TextBox10.Text + "4"
            Case 3
                TextBox8.Text = TextBox8.Text + "4"
            Case 4
                TextBox7.Text = TextBox7.Text + "4"
            Case 5
                TextBox4.Text = TextBox4.Text + "4"
            Case 6
                TextBox2.Text = TextBox2.Text + "4"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "5"
            Case 2
                TextBox10.Text = TextBox10.Text + "5"
            Case 3
                TextBox8.Text = TextBox8.Text + "5"
            Case 4
                TextBox7.Text = TextBox7.Text + "5"
            Case 5
                TextBox4.Text = TextBox4.Text + "5"
            Case 6
                TextBox2.Text = TextBox2.Text + "5"
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "6"
            Case 2
                TextBox10.Text = TextBox10.Text + "6"
            Case 3
                TextBox8.Text = TextBox8.Text + "6"
            Case 4
                TextBox7.Text = TextBox7.Text + "6"
            Case 5
                TextBox4.Text = TextBox4.Text + "6"
            Case 6
                TextBox2.Text = TextBox2.Text + "6"
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "7"
            Case 2
                TextBox10.Text = TextBox10.Text + ""
            Case 3
                TextBox8.Text = TextBox8.Text + "7"
            Case 4
                TextBox7.Text = TextBox7.Text + "7"
            Case 5
                TextBox4.Text = TextBox4.Text + "7"
            Case 6
                TextBox2.Text = TextBox2.Text + "7"
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "8"
            Case 2
                TextBox10.Text = TextBox10.Text + "8"
            Case 3
                TextBox8.Text = TextBox8.Text + "8"
            Case 4
                TextBox7.Text = TextBox7.Text + "8"
            Case 5
                TextBox4.Text = TextBox4.Text + "8"
            Case 6
                TextBox2.Text = TextBox2.Text + "8"
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "9"
            Case 2
                TextBox10.Text = TextBox10.Text + "9"
            Case 3
                TextBox8.Text = TextBox8.Text + "9"
            Case 4
                TextBox7.Text = TextBox7.Text + "9"
            Case 5
                TextBox4.Text = TextBox4.Text + "9"
            Case 6
                TextBox2.Text = TextBox2.Text + "9"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case p
            Case 1
                TextBox1.Text = TextBox1.Text + "0"
            Case 2
                TextBox10.Text = TextBox10.Text + "0"
            Case 3
                TextBox8.Text = TextBox8.Text + "0"
            Case 4
                TextBox7.Text = TextBox7.Text + "0"
            Case 5
                TextBox4.Text = TextBox4.Text + "0"
            Case 6
                TextBox2.Text = TextBox2.Text + "0"
        End Select
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim i As String
        i = "Описание:"
        TextBox13.Text = i
        TextBox13.Text = TextBox13.Text & vbNewLine & "Данный раздела калькулятора создан для перевода велечин "
        TextBox13.Text = TextBox13.Text & vbNewLine & "Cейчас я, внутриний голос этого калькулятора расскажу как ей пользоваться."
        TextBox13.Text = TextBox13.Text & vbNewLine & "Вам необходимо ввести нужные вам данные для вычесления"
        TextBox13.Text = TextBox13.Text & vbNewLine & "После чего нужно нажать на кнопку перевести"
        TextBox13.Text = TextBox13.Text & vbNewLine & "И ура, ваш ответ готов"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Select Case p
            Case 1
                TextBox1.Clear()
            Case 2
                TextBox10.Clear()
            Case 3
                TextBox8.Clear()
            Case 4
                TextBox7.Clear()
            Case 5
                TextBox4.Clear()
            Case 6
                TextBox2.Clear()
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Select Case p
            Case 1
                If (InStr(TextBox1.Text, ",") = 0) And (Len(TextBox1.Text) > 0) Then
                    TextBox1.Text = TextBox1.Text + ","
                End If
            Case 2
                If (InStr(TextBox10.Text, ",") = 0) And (Len(TextBox10.Text) > 0) Then
                    TextBox10.Text = TextBox10.Text + ","
                End If
            Case 3
                If (InStr(TextBox8.Text, ",") = 0) And (Len(TextBox8.Text) > 0) Then
                    TextBox8.Text = TextBox8.Text + ","
                End If
            Case 4
                If (InStr(TextBox7.Text, ",") = 0) And (Len(TextBox7.Text) > 0) Then
                    TextBox7.Text = TextBox7.Text + ","
                End If
            Case 5
                If (InStr(TextBox4.Text, ",") = 0) And (Len(TextBox4.Text) > 0) Then
                    TextBox4.Text = TextBox4.Text + ","
                End If
            Case 6
                If (InStr(TextBox2.Text, ",") = 0) And (Len(TextBox2.Text) > 0) Then
                    TextBox2.Text = TextBox2.Text + ","
                End If
        End Select
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox11.Text = CStr(CDbl(TextBox1.Text) * 1000) + "(мегабайт)"
        TextBox1.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox9.Text = CStr(CDbl(TextBox10.Text) * 100000) + "(см)"
        TextBox10.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox6.Text = CStr(CDbl(TextBox8.Text) * 60) + "(минут)"
        TextBox8.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox5.Text = CStr(CDbl(TextBox7.Text) * 1.609) + "(км)"
        TextBox7.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox3.Text = CStr(CDbl(TextBox4.Text) * 1.01325) + "(бар)"
        TextBox4.Clear()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox12.Text = CStr(Math.Round(CDbl((TextBox2.Text) - 32) * 5 / 9, 3)) + "(по цельс.)"
        TextBox2.Clear()
    End Sub
End Class
