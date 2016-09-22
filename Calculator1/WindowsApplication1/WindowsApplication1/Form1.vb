Public Class frmTutorialTwo

    'Variable Declarations
    Dim firstNum As Decimal
    Dim secondNum As Decimal
    Dim result As Decimal

    'Multiplies the numbers in each textbox together
    'Outputs the result in a MessageBox
    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        firstNum = Decimal.Parse(txtFirstNumber.Text)
        secondNum = CDec(txtSecondNumber.Text)
        result = firstNum * secondNum
        MessageBox.Show("The result of " & firstNum.ToString() & " times " _
                        & secondNum.ToString() & " is: " & result.ToString(), "Multiplication")

    End Sub
    'Divides the number in the first box by the number in the second
    'Outputs the result in a Message box
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstNum = Decimal.Parse(txtFirstNumber.Text)
        secondNum = CDec(txtSecondNumber.Text)
        result = firstNum / secondNum
        MessageBox.Show("The result of " & firstNum.ToString() & " divided by " & secondNum.ToString() _
                        & " is " & result.ToString(), "Division")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstNum = Decimal.Parse(txtFirstNumber.Text)
        secondNum = CDec(txtSecondNumber.Text)
        result = firstNum + secondNum
        MessageBox.Show("The result of " & firstNum.ToString() & " added to " & secondNum.ToString() _
                        & " is " & result.ToString(), "Addition")
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        firstNum = Decimal.Parse(txtFirstNumber.Text)
        secondNum = CDec(txtSecondNumber.Text)
        result = firstNum - secondNum
        MessageBox.Show("The result of " & firstNum.ToString() & " minus " & secondNum.ToString() _
                        & " is " & result.ToString(), "Subtraction")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstNumber.Text = ""
        txtSecondNumber.Text = ""
    End Sub
End Class
