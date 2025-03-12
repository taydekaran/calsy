Public Class Form1

    Dim no1 As Double
    Dim op As Char

    Private Sub Btn0_Click_1(sender As Object, e As EventArgs) Handles Btn0.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click

        TextBox1.Text &= sender.text

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click, btnAdd.Click, btnSub.Click, btnMod.Click, btnMult.Click
        no1 = TextBox1.Text
        TextBox1.Clear()
        op = sender.text

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        If op = "+" Then
            TextBox1.Text = no1 + Val(TextBox1.Text)
        ElseIf op = "-" Then
            TextBox1.Text = no1 - Val(TextBox1.Text)
        ElseIf op = "*" Then
            TextBox1.Text = no1 * Val(TextBox1.Text)
        ElseIf op = "/" Then
            TextBox1.Text = no1 / Val(TextBox1.Text)
        ElseIf op = "%" Then
            TextBox1.Text = no1 Mod Val(TextBox1.Text)


        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
    End Sub
End Class
