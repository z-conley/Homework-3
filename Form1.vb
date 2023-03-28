' Program: Catering
' Date: 3/28/2023
' Name: Zachary Conley
' Purpose: This app is used to choose catering options while displaying the discounted price per loyalty points


Option Strict On
Option Explicit On
Public Class Frmcatering
    Private Sub Btncalc_Click(sender As Object, e As EventArgs) Handles Btncalc.Click
        Dim decCost As Decimal
        Dim decFin As Decimal
        Dim cdecdiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPayment As String = ""
        Dim strPoints As String = ""
        Dim intpoints As Integer

        If IsNumeric(Txtpoints.Text) Then
            intpoints = Convert.ToInt32(Txtpoints.Text)
            strPoints = " after discount of " & intpoints.ToString() & " loyalty points."

            If Radcheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf Radwraps.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf Radsausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage"
            ElseIf Radveggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf Radfruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If Radpre.Checked Then
                strPayment = " using Pre-Pay"
            ElseIf Radpickup.Checked Then
                strPayment = " with Pay Upon Pickup"
            End If

            intpoints = Convert.ToInt32(intpoints / 10I)

            decPoints = (intpoints * cdecdiscount) / 100
            'MsgBox(decPoints)

            If decPoints > 1 Then
                decPoints = 1
            End If

            MsgBox(decPoints)

            decFin = decCost * (1 - decPoints)
            MsgBox(decFin)

            Lblplzpay.Text = "Your order " & strOrder & " platter costs " & decFin.ToString("C") & strPayment & strPoints
        Else
            MsgBox("Please enter a valid amount of points.", , "Input error")
            Me.Btnclear.PerformClick()

        End If
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtpoints.Text = ""
        Txtpoints.Focus()
        Lblplzpay.Text = ""
        Radcheese.Checked = True
        Radfruit.Checked = False
        Radsausage.Checked = False
        Radveggie.Checked = False
        Radwraps.Checked = False
        Radpre.Checked = True
        Radpickup.Checked = False

    End Sub

    Private Sub Frmcatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtpoints.Text = ""
        Txtpoints.Focus()
        Lblplzpay.Text = ""
        Radcheese.Checked = True
        Radfruit.Checked = False
        Radsausage.Checked = False
        Radveggie.Checked = False
        Radwraps.Checked = False
        Radpre.Checked = True
        Radpickup.Checked = False

    End Sub
End Class
