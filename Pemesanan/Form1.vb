Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtMenu.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnPesan.Click
        ListOrder.Items.Add(CboNama.Text & "(" & TxtJumlah.Text & ")")
        CboNama.Text = ""
        TxtJumlah.Text = ""
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        CboNama.Items.Add(TxtMenu.Text)
        TxtMenu.Text = ""
    End Sub
End Class
