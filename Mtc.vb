Public Class Mtc

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim sSport As String = txtSportName.Text()
        If Not Form1.cboSportList.Items.Contains(sSport) Then
            Form1.cboSportList.Items.Add(sSport)
            MessageBox.Show(sSport & " successfully added.", _
                            "Sports List", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        If Not Form1.cboSportList.Items.Contains(sSport) Then
            Form1.cboSportList.Items.Add(sSport)
        End If
        txtSportName.Clear()
        txtSportName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim sSport As String = txtSportName.Text
        If Form1.cboSportList.Items.Contains(sSport) Then
            Form1.cboSportList.Items.Remove(sSport)
            MessageBox.Show(sSport & " successfully removed.", _
                            "Sports List", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If

        If Form1.cboSportList.Items.Contains(sSport) Then
            Form1.cboSportList.Items.Remove(sSport)
        End If
        txtSportName.Clear()
        txtSportName.Focus()
    End Sub
End Class