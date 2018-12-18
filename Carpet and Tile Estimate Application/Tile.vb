'Name:          Juan Toscano
'Purpose:       Calculates an estimate price for the cleaning of tile.
'Programmer:    Juan Toscano on 04/11/2018

Public Class Tile
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate and display the estimate amount.'
        'Declare, and use variables'

        Dim intEstCost0 As Integer
        Dim intEstCost1 As Integer

        Dim TileBed As Integer
        Dim TileLiving As Integer

        TileBed = 70
        TileLiving = 120

        'TryParse - (String.Text, Integer)
        Integer.TryParse(txtBed.Text, intEstCost0)

        'Tile Bedrooms'
        Select Case intEstCost0
            Case "0"
                intEstCost0 = 0
            Case "1"
                intEstCost0 = 1 * TileBed
            Case "2"
                intEstCost0 = 2 * TileBed
            Case "3"
                intEstCost0 = 3 * TileBed
            Case Else
                intEstCost0 = "999"
        End Select

        'TryParse - (String.Text, Integer)
        Integer.TryParse(txtLiving.Text, intEstCost1)

        'Tile Living Rooms'
        Select Case intEstCost1
            Case "0"
                intEstCost1 = 0
            Case "1"
                intEstCost1 = 1 * TileLiving
            Case "2"
                intEstCost1 = 2 * TileLiving
            Case "3"
                intEstCost1 = 3 * TileLiving
            Case Else
                intEstCost1 = "999"

        End Select

        'Assign value to display on the label'
        lblDisplayEst0.Text = intEstCost0.ToString("C2")
        lblDisplayEst1.Text = intEstCost1.ToString("C2")

    End Sub
End Class