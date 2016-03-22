Public Class fmrKontorFiyatListesi


    Dim gPriceList = New PerioTCPRdr.TPriceList()

    Sub gridOlustur()
        dataGridView1.Rows.Clear()
        dataGridView1.Columns.Clear()


        For i As Integer = 1 To 8 Step 1
            If (i = 0) Then
                dataGridView1.Columns.Add("", "Öğün")
            End If

            dataGridView1.Columns.Add("", i.ToString() + ". Fiyat")
            dataGridView1.Rows.Add(i.ToString() + ". Öğün")
            dataGridView1.Rows(i).Resizable = DataGridViewTriState.False

        Next

    End Sub

    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

    End Sub


End Class