'Program Name: Payroll Calculator
' Developer: Maria Jackson
' Date: Feb 19, 2023
' Purpose: This program calculates FICA, Federal, & State tax from Gross biweekly income
''          User may enter gross biweekly pay, and program will caluclate taxes &
''          deduct the taxes from gross pay to display Net Income

Option Strict On
Public Class frmPayrollCalc

    Private Sub frmPayrollCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets focus on txtGrossPay
        txtGrossPay.Focus()

    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        'Declares necessary variables for FICA, Fed, & State tax
        'Computes taxes & deducts taxes from gross pay
        'Displays net income

        'Declare constants: FICA, Federal, and State tax rates:
        Const cdecFICA As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        Dim strIncome As String 'gross pay as string from input
        Dim decIncome As Decimal 'gross pay converted to dec
        Dim decFICA As Decimal 'calculated FICA tax
        Dim decFederal As Decimal 'calculated federal tax
        Dim decState As Decimal 'calculated state tax
        Dim decNet As Decimal 'calculated net income

        'get gross pay from input & convert to int
        strIncome = txtGrossPay.Text

        Try
            decIncome = Convert.ToDecimal(strIncome)

            'calc taxes:
            decFICA = decIncome * cdecFICA
            decFederal = decIncome * cdecFed
            decState = decIncome * cdecState

            'subtract taxes from gross pay
            decNet = decIncome - decFICA - decFederal - decState

            'display taxes and net income
            lblFICA.Text = "FICA Tax: " & decFICA.ToString("C2")
            lblFed.Text = "Federal Tax: " & decFederal.ToString("C2")
            lblState.Text = "State Tax: " & decState.ToString("C2")
            lblNetIncome.Text = "Net Paycheck Income: " & decNet.ToString("C2")
        Catch badFormat As FormatException
            txtGrossPay.Clear()
            txtGrossPay.Focus()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears gross pay input & sets focus on txtGrossPay
        ' clears tax and net income text

        txtGrossPay.Clear()
        txtGrossPay.Focus()

        lblFICA.Text = "FICA Tax: "
        lblFed.Text = "Federal Tax: "
        lblState.Text = "State Tax: "
        lblNetIncome.Text = "Net Paycheck Income: "

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' closes window, ends program
        Close()
    End Sub

End Class
