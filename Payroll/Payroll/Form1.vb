Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtSSN.Clear()
        txtPayRate.Clear()
        txtHoursWorked.Clear()
        lblGrossPay.Text = ""
        lblFedTax.Text = ""
        lblStateTax.Text = ""
        lblNetPay.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim grossPay, fedTax, stateTax, netPay As Double

        grossPay = CDbl(txtPayRate.Text) * CDbl(txtHoursWorked.Text)
        'Display the result.
        lblGrossPay.Text = CStr(grossPay)

        fedTax = CDbl(grossPay) * 0.15
        lblFedTax.Text = CStr(fedTax)

        stateTax = CDbl(grossPay) * 0.05
        lblStateTax.Text = CStr(stateTax)

        netPay = CDbl(grossPay) - (fedTax + stateTax)
        lblNetPay.Text = CStr(netPay)
    End Sub
End Class
