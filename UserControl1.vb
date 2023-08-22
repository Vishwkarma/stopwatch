Public Class UserControl1

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If SS.Text = 59 Then
            MM.Text += 1
            SS.Text = "00"
        ElseIf MM.Text = 59 Then
            HH.Text += 1
            MM.Text = "00"
            SS.Text = "00"
        Else
            SS.Text += 1
        End If
    End Sub

    Private Sub stop_btn_Click(sender As Object, e As EventArgs) Handles stop_btn.Click
        Timer2.Stop()

    End Sub

    Private Sub RESET_BTN_Click(sender As Object, e As EventArgs) Handles RESET_BTN.Click
        SS.Text = "00"
        MM.Text = "00"
        HH.Text = "00"

        Timer2.Start()


    End Sub
End Class
