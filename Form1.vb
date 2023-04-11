Public Class KaraokeMusicNight

    Private _decPerSong As Decimal = 2.99D
    Private _decPerHour As Decimal = 8.99D

    Private Sub KaraokeMusicNight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub

    Private Function ValidateInput() As Boolean
        Dim intNum As Integer
        Dim blnValid As Boolean

        Try
            intNum = Convert.ToInt32(txtInputNum.Text)
            If intNum > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a positive whole number", , "Input Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Input Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount", , "Input Error")
        Catch Exception As SystemException
            MsgBox("Please enter a valid number", , "Input Error")
        End Try

        txtInputNum.Focus()
        txtInputNum.Clear()
        Return blnValid
    End Function

    Private Function GetSongCost(ByVal intSongs As Integer) As Decimal
        Dim decSongsCost As Decimal
        decSongsCost = intSongs * _decPerSong
        Return decSongsCost
    End Function

    Private Function GetRoomCost(ByVal intHours As Integer) As Decimal
        Dim decRoomCost As Decimal
        decRoomCost = intHours * _decPerHour
        Return decRoomCost
    End Function

    Private Sub ClearForm()
        cboSelection.SelectedIndex = -1
        lblSongsHours.Visible = False
        txtInputNum.Visible = False
        btnTotalCost.Visible = False
        btnClear.Visible = False
        lblTotalCost.Visible = False
        txtInputNum.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim intInput As Integer
        Dim decTotal As Decimal

        If ValidateInput() Then
            intInput = Convert.ToInt32(txtInputNum.Text)

            If cboSelection.SelectedIndex = 0 Then
                decTotal = GetSongCost(intInput)
            Else
                decTotal = GetRoomCost(intInput)
            End If

            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
            lblTotalCost.Visible = True
        End If
    End Sub

    Private Sub cboSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelection.SelectedIndexChanged
        If cboSelection.SelectedIndex = 0 Then
            lblSongsHours.Text = "Number of Karaoke Songs"
            lblSongsHours.Visible = True
            txtInputNum.Visible = True
            btnTotalCost.Visible = True
            btnClear.Visible = True
            txtInputNum.Focus()
        End If

        If cboSelection.SelectedIndex = 1 Then
            lblSongsHours.Text = "Hourly Rental of Karaoke Room"
            lblSongsHours.Visible = True
            txtInputNum.Visible = True
            btnTotalCost.Visible = True
            btnClear.Visible = True
            txtInputNum.Focus()
        End If
    End Sub
End Class
