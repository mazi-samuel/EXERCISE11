Public Class Form1
    Private Sub lblCalculate_Click(sender As Object, e As EventArgs) Handles lblCalculate.Click

        'Declearation of Variables

        Dim decA, decR, decRr, decP, dect As Decimal

        Const n As Integer = 1


        decP = txtInitialAmount.Text
        decR = txtInterestRate.Text

        'Check that the time involved is greater than 5
        If txtTimeInvolved.Text < 5 Then
            MsgBox("Please Enter A Time Period not less than 5")
        Else
            dect = txtTimeInvolved.Text
            decRr = decR / 100

            decA = decP * ((1 + (decRr / n)) ^ (n * dect))
            txtAmountExpected.Text = decA
        End If

    End Sub

    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        'Clear all Text Boxes for new inputs

        txtInitialAmount.Text = ""
        txtInterestRate.Text = ""
        txtTimeInvolved.Text = ""
        txtAmountExpected.Text = ""
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub
End Class
