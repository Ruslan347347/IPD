Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim j As MsgBoxResult
        j = MsgBox("Хотите выйти из программы?", MsgBoxStyle.YesNo, "Выход")
        If j = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i As String
        i = "Программа калькулятор"
        TextBox1.Text = i
        TextBox1.Text = TextBox1.Text & vbNewLine & "Программа создана для различных вычислений."
        TextBox1.Text = TextBox1.Text & vbNewLine & "В данной программе содержаться функции для вычесления в таких областях как математика, физика, геометрия и химия, а также другие прочии функции."
        TextBox1.Text = TextBox1.Text & vbNewLine & "Эти функции и области вычесления расположены слева от того текста что вы читаете"
        TextBox1.Text = TextBox1.Text & vbNewLine & "После нажатия на одну из функциий вам откроется калькулятор той или иной области"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form6.Show()
        Me.Hide()
        TextBox1.Clear()
    End Sub
End Class
