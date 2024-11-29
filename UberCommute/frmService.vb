' Program Name: Uber, Bus, Or Subway Commute
' Date: November 27, 2024
' Author: K Bola
' Purpose: This application computes the yearly cost of commuting to work via Uber car service, subway or bus
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Imaging
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Transactions

Public Class frmService
    Private Sub cboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMode.SelectedIndexChanged
        ' Checking the mode of travel chosen
        Dim intSelectMode As Integer
        intSelectMode = cboMode.SelectedIndex
        Select Case intSelectMode
            Case 0
                ' Making items visible and Setting the labels
                lblQuestions.Visible = True
                lblQuestions.Text = "Round trip cost:"
                lblDaysWorked.Visible = True
                lblDaysWorked.Text = "Days worked per month:"
                txtCosts.Visible = True
                txtCosts.Focus()
                txtDays.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True
                lblModeHeading.Visible = True
                lblMode.Visible = True
                lblMode.Text = ""
                lblCostHeading.Visible = True
                lblCost.Visible = True
                lblCost.Text = ""
            Case 1
                ' Making items visible and Setting the labels
                lblQuestions.Visible = True
                lblQuestions.Text = "Round trip transit fare:"
                lblDaysWorked.Visible = True
                lblDaysWorked.Text = "Days worked per month:"
                txtCosts.Visible = True
                txtCosts.Focus()
                txtDays.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True
                lblModeHeading.Visible = True
                lblMode.Visible = True
                lblMode.Text = ""
                lblCostHeading.Visible = True
                lblCost.Visible = True
                lblCost.Text = ""
            Case 2
                ' Making items visible and Setting the labels
                lblQuestions.Visible = True
                lblQuestions.Text = "Round trip transit fare:"
                lblDaysWorked.Visible = True
                lblDaysWorked.Text = "Days worked per month:"
                txtCosts.Visible = True
                txtCosts.Focus()
                txtDays.Visible = True
                btnCost.Visible = True
                btnClear.Visible = True
                lblModeHeading.Visible = True
                lblMode.Visible = True
                lblMode.Text = ""
                lblCostHeading.Visible = True
                lblCost.Visible = True
                lblCost.Text = ""
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboMode.Text = "Mode of Travel:"
        ' Making items invisible and Setting the labels
        lblQuestions.Visible = False
        lblDaysWorked.Visible = False
        txtCosts.Visible = False
        txtCosts.Clear()
        txtDays.Clear()
        txtDays.Visible = False
        btnCost.Visible = False
        btnClear.Visible = False
        lblModeHeading.Visible = False
        lblMode.Visible = False
        lblCostHeading.Visible = False
        lblCost.Visible = False
    End Sub

    Private Sub frmService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' Declaring Variables
        Dim decCost As Decimal
        Dim intSelectedMode As Integer
        Dim intDaysWorked As Integer
        Dim decTotalCost As Decimal
        Try
            decCost = Convert.ToDecimal(txtCosts.Text)
            intDaysWorked = Convert.ToInt32(txtDays.Text)
            If (decCost > 0 And intDaysWorked > 0) Then
                intSelectedMode = cboMode.SelectedIndex
                Select Case intSelectedMode
                    Case 0
                        decTotalCost = UberCost(decCost, intDaysWorked, decTotalCost)
                    Case 1
                        decTotalCost = SubwayCost(decCost, intDaysWorked, decTotalCost)
                    Case 2
                        decTotalCost = BusCost(decCost, intDaysWorked, decTotalCost)
                End Select
            Else
                MsgBox("Enter a Valid Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
                txtCosts.Clear()
                txtDays.Clear()
                txtCosts.Focus()
                txtDays.Focus()
            End If
        Catch ex As Exception
            MsgBox("Enter a Valid Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
            txtCosts.Clear()
            txtDays.Clear()
            txtCosts.Focus()
            txtDays.Focus()
        End Try
        MsgBox("NB: Cost displayed is calculated for one year", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Info")
    End Sub
    Private Function UberCost(decCost As Decimal, intDaysWorked As Integer, decTotalCost As Decimal) As Decimal
        Const _cdecSurgePricing As Decimal = 0.2D
        Dim decIncentive As Decimal
        Dim intSelectedMode As Integer = cboMode.SelectedIndex
        decCost = Convert.ToDecimal(txtCosts.Text)
        intDaysWorked = Convert.ToInt32(txtDays.Text)
        If (intSelectedMode = 0) Then
            decTotalCost = decCost * intDaysWorked
            decIncentive = decTotalCost * _cdecSurgePricing * 12
            lblMode.Text = cboMode.SelectedItem.ToString()
            lblCost.Text = decIncentive.ToString("C")
        End If
        Return decIncentive
    End Function
    Private Function SubwayCost(decCost As Decimal, intDaysWorked As Integer, decTotalCost As Decimal)
        Dim intSelectedMode = cboMode.SelectedIndex
        decCost = Convert.ToDecimal(txtCosts.Text)
        intDaysWorked = Convert.ToInt32(txtDays.Text)
        If (intSelectedMode = 1) Then
            decTotalCost = decCost * intDaysWorked * 12
            lblMode.Text = cboMode.SelectedItem.ToString()
            lblCost.Text = decTotalCost.ToString("C")
        End If
        Return decTotalCost
    End Function
    Private Function BusCost(decCost As Decimal, intDaysWorked As Integer, decTotalCost As Decimal) As Decimal
        Dim intSelectedMode As Integer = cboMode.SelectedIndex
        decCost = Convert.ToDecimal(txtCosts.Text)
        intDaysWorked = Convert.ToInt32(txtDays.Text)
        If (intSelectedMode = 2) Then
            decTotalCost = decCost * intDaysWorked * 12
            lblMode.Text = cboMode.SelectedItem.ToString()
            lblCost.Text = decTotalCost.ToString("C")
        End If
        Return decTotalCost
    End Function
End Class
