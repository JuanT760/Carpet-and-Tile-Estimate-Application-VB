'Name:          Juan Toscano
'Purpose:       Calculates an estimate price for the cleaning of carpet.
'Programmer:    Juan Toscano on 04/11/2018

Public Class Carpet
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate and display the estimate amount.'

        Dim intEstCost As Integer

        'Check, and calculate the checkboxes that are checked.'
        'Add respective values to each checkboxes; All values are based on Carpet Price .'

        'Bedrooms'
        If chk1Bed.Checked Then
            intEstCost = intEstCost + 40
        End If

        If chk2Bed.Checked Then
            intEstCost = intEstCost + 80
        End If

        If chk3Bed.Checked Then
            intEstCost = intEstCost + 120
        End If

        'Living Rooms'
        If chk1Living.Checked Then
            intEstCost = intEstCost + 70
        End If

        If chk2Living.Checked Then
            intEstCost = intEstCost + 140
        End If

        If chk3Living.Checked Then
            intEstCost = intEstCost + 210
        End If

        'Discount'
        If chkSenior.Checked Then
            intEstCost = intEstCost - 5
        End If

        If chkFamily.Checked Then
            intEstCost = intEstCost - 10
        End If

        'Other'
        If chkBuisness.Checked Then
            intEstCost = intEstCost + 65
        End If

        If chkHeavyStains.Checked Then
            intEstCost = intEstCost + 25
        End If

        If chkRug.Checked Then
            intEstCost = intEstCost + 10
        End If

        'Assign value to display on the label'
        lblDisplayEst.Text = intEstCost.ToString("C2")
    End Sub

    Private Sub btnShowTile_Click(sender As Object, e As EventArgs) Handles btnShowTile.Click
        Tile.Show()
    End Sub
End Class
