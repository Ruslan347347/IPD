Public Class Form2
    Dim Func As String
    Dim A, B As Double
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = TextBox2.Text + CStr(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = TextBox2.Text + CStr(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = TextBox2.Text + CStr(4)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = TextBox2.Text + CStr(5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text = TextBox2.Text + CStr(6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = TextBox2.Text + CStr(7)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text = TextBox2.Text + CStr(8)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text = TextBox2.Text + CStr(9)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = TextBox2.Text + CStr(0)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (InStr(TextBox2.Text, ",") = 0) And (Len(TextBox2.Text) > 0) Then
            TextBox2.Text = TextBox2.Text + ","
        End If
    End Sub

    Private Sub Functia(str As String, str2 As String)
        If TextBox2.Text = "" Then
            A = CDbl(0)
        Else
            A = CDbl(TextBox2.Text)
        End If
        Func = str
        TextBox1.Clear()
        TextBox1.Text = CStr(A) + " " + str2
        TextBox2.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Functia("+", "+")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Func = "") And (TextBox2.Text = "") Then
            TextBox2.Text = TextBox2.Text + "-"
        Else
            Functia("-", "-")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Functia("/", "/")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Functia("*", "*")
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Ans As String
        Ans = 1
        If (TextBox2.Text <> "") And (Func <> "") Then
            B = CDbl(TextBox2.Text)
            TextBox1.Text = TextBox1.Text + " " + TextBox2.Text
            If Func = "+" Then
                TextBox3.Text = CStr(A + B)
            End If
            If Func = "-" Then
                TextBox3.Text = CStr(A - B)
            End If
            If Func = "*" Then
                TextBox3.Text = CStr(A * B)
            End If
            If Func = "/" Then
                TextBox3.Text = CStr(A / B)
            End If
            If Func = "Stepen" Then
                For i As Integer = 1 To B
                    Ans = Ans * A
                Next
                TextBox3.Text = CStr(Ans)
            End If
            If Func = "Proporsia" Then
                TextBox3.Text = CStr(A * B / 100)
            End If
            TextBox1.Text = TextBox1.Text + " = " + TextBox3.Text
            Func = ""
            TextBox2.Clear()
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox3.Text = CStr(Math.Sin(CInt(TextBox2.Text)))
        TextBox1.Text = "Sin(" + TextBox2.Text + ") = " + TextBox3.Text
        TextBox2.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox3.Text = CStr(Math.Cos(CInt(TextBox2.Text)))
        TextBox1.Text = "Cos(" + TextBox2.Text + ") = " + TextBox3.Text
        TextBox2.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Functia("Stepen", "^ числа")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Functia("Proporsia", "% от числа")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox3.Text = CStr(Math.Sqrt(CInt(TextBox2.Text)))
        TextBox1.Text = "Sqrt(" + TextBox2.Text + ") = " + TextBox3.Text
        TextBox2.Text = ""
    End Sub

    Private Sub Button24_Click_1(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox3.Text = CStr(Math.Tan(CInt(TextBox2.Text)))
        TextBox1.Text = "Tg(" + TextBox2.Text + ") = " + TextBox3.Text
        TextBox2.Text = ""
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim p As Long
        A = CDbl(TextBox2.Text)
        p = 1
        For i = 1 To A
            p = p * i
        Next i
        TextBox3.Text = CStr(p)
        TextBox1.Text = "" + TextBox2.Text + "! = " + TextBox3.Text
        TextBox2.Text = ""
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = TextBox2.Text + CStr(1)
    End Sub
End Class

