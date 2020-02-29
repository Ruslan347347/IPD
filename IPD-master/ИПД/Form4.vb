Public Class Form4
    Dim P As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim i As String
        i = "Описание:"
        TextBox1.Text = i
        TextBox1.Text = TextBox1.Text & vbNewLine & "Данный раздела калькулятора создан для вычисления массы вещества,объем вещества и его количества."
        TextBox1.Text = TextBox1.Text & vbNewLine & "Cейчас я, внутриний голос этого калькулятора расскажу как ей пользоваться."
        TextBox1.Text = TextBox1.Text & vbNewLine & "Вам необходимо ввести нужные вам данные для вычесления"
        TextBox1.Text = TextBox1.Text & vbNewLine & "После чего нужно выбрать нужную вам функцию и нажать на нее"
        TextBox1.Text = TextBox1.Text & vbNewLine & "И ура, ваш ответ готов"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "1"
            Case 2
                TextBox2.Text = TextBox2.Text + "1"
            Case 3
                TextBox4.Text = TextBox4.Text + "1"
        End Select
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "2"
            Case 2
                TextBox2.Text = TextBox2.Text + "2"
            Case 3
                TextBox4.Text = TextBox4.Text + "2"
        End Select
    End Sub

    Private Sub TextBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.Click
        P = 1
    End Sub

    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        P = 2
    End Sub
    Private Sub TextBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Click
        P = 3
    End Sub

    Private Sub TextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        P = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "3"
            Case 2
                TextBox2.Text = TextBox2.Text + "3"
            Case 3
                TextBox4.Text = TextBox4.Text + "3"
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "4"
            Case 2
                TextBox2.Text = TextBox2.Text + "4"
            Case 3
                TextBox4.Text = TextBox4.Text + "4"
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "5"
            Case 2
                TextBox2.Text = TextBox2.Text + "5"
            Case 3
                TextBox4.Text = TextBox4.Text + "5"
        End Select
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "6"
            Case 2
                TextBox2.Text = TextBox2.Text + "6"
            Case 3
                TextBox4.Text = TextBox4.Text + "6"
        End Select
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "7"
            Case 2
                TextBox2.Text = TextBox2.Text + "7"
            Case 3
                TextBox4.Text = TextBox4.Text + "7"
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "8"
            Case 2
                TextBox2.Text = TextBox2.Text + "8"
            Case 3
                TextBox4.Text = TextBox4.Text + "8"
        End Select
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "9"
            Case 2
                TextBox2.Text = TextBox2.Text + "9"
            Case 3
                TextBox4.Text = TextBox4.Text + "9"
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "0"
            Case 2
                TextBox2.Text = TextBox2.Text + "0"
            Case 3
                TextBox4.Text = TextBox4.Text + "0"
        End Select
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Select Case P
            Case 1
                If (InStr(TextBox5.Text, ",") = 0) And (Len(TextBox5.Text) > 0) Then
                    TextBox5.Text = TextBox5.Text + ","
                End If
            Case 2
                If (InStr(TextBox2.Text, ",") = 0) And (Len(TextBox2.Text) > 0) Then
                    TextBox2.Text = TextBox2.Text + ","
                End If
            Case 3
                If (InStr(TextBox4.Text, ",") = 0) And (Len(TextBox4.Text) > 0) Then
                    TextBox4.Text = TextBox4.Text + ","
                End If
        End Select
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Select Case P
            Case 1
                TextBox5.Clear()
            Case 2
                TextBox2.Clear()
            Case 3
                TextBox4.Clear()
            Case 0
                TextBox3.Clear()
        End Select
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (TextBox4.Text <> "") And (TextBox2.Text <> "") Then
            TextBox3.Text = "Количество вещества= " + CStr(Math.Round(CDbl(TextBox2.Text) / CDbl(TextBox4.Text), 3)) + " (моль)"
            TextBox5.Clear()
            TextBox2.Clear()
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (TextBox5.Text <> "") And (TextBox4.Text <> "") Then
            TextBox3.Text = "Масса вещества= " + CStr(Math.Round(CDbl(TextBox5.Text) * CDbl(TextBox4.Text), 2)) + " (гр)"
            TextBox5.Clear()
            TextBox2.Clear()
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (TextBox5.Text <> "") And (TextBox4.Text <> "") Then
            TextBox3.Text = "Объем вещества= " + CStr(Math.Round(CDbl(TextBox5.Text) * 22.4)) + " (л)"
            TextBox5.Clear()
            TextBox2.Clear()
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Select Case P
            Case 1
                TextBox5.Text = TextBox5.Text + "-"
            Case 2
                TextBox2.Text = TextBox2.Text + "-"
            Case 3
                TextBox4.Text = TextBox4.Text + "-"
            Case 0
                TextBox3.Text = TextBox3.Text + "-"
        End Select
    End Sub
End Class
