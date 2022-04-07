Public Class frmCalculator

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear button clears input from the user

        txtnum1.Clear()
        txtnum2.Clear()

        'Clear button clears output 

        txtAnswer.Clear()


    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click

        'variables

        Dim n1, n2, answer As Double

        'input

        n1 = CDbl(txtnum1.Text)
        n2 = CDbl(txtnum2.Text)

        'process

        If rdbAdd.Checked = True Then
            answer = n1 + n2
        ElseIf rdbSubtract.Checked = True Then
            answer = n1 - n2
        ElseIf rdbMultiply.Checked = True Then
            answer = n1 * n2
        ElseIf rdbDivide.Checked = True Then
            answer = n1 / n2
        ElseIf rdbExponent.Checked = True Then
            answer = n1 ^ n2
        End If

        'output

        txtAnswer.Text = Str(answer)


    End Sub

    Private Sub rdbExponent_CheckedChanged(sender As Object, e As EventArgs) Handles rdbExponent.CheckedChanged

        'when the radio button is clicked on, the sign changes

        LabelSign.Text = "^"

    End Sub

    Private Sub rdbDivide_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDivide.CheckedChanged

        'when the radio button is clicked on, the sign changes

        LabelSign.Text = "/"

    End Sub

    Private Sub rdbMultiply_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMultiply.CheckedChanged

        'when the radio button is clicked on, the sign changes

        LabelSign.Text = "x"

    End Sub

    Private Sub rdbSubtract_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSubtract.CheckedChanged

        'when the radio button is clicked on, the sign changes

        LabelSign.Text = "-"

    End Sub

    Private Sub rdbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdd.CheckedChanged

        'when the radio button is clicked on, the sign changes

        LabelSign.Text = "+"

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        'closes the program when the button is clicked ! 

        Me.Close()

    End Sub
End Class
