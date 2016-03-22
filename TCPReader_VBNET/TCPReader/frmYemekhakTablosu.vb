Imports PerioTCPRdr

Public Class frmYemekhakTablosu

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click


        If (mainForm.rdr.Connected) Then

            isle()

        Else
            MessageBox.Show("Cihazla bağlantı  yok")

        End If


    End Sub



    Sub isle()

        Dim table As New TWeaklyMealRigth()
        dataGridView1.Rows.Clear()
        dataGridView1.Columns.Clear()

        If (mainForm.rdr.GetMealRigthTable(numericUpDown1.Value, table)) Then


            For a As Integer = 0 To 9 Step 1

                If a = 0 Then
                    dataGridView1.Columns.Add("Toplam", "Gün")
                ElseIf a = 9 Then
                    dataGridView1.Columns.Add("Toplam", "Toplam Öğün")
                Else
                    dataGridView1.Columns.Add("Toplam", a.ToString() + ". Öğün")
                End If

                For k As Integer = 0 To 6 Step 1
                    dataGridView1.Rows(k).ReadOnly = True
                    dataGridView1.Rows(k).Resizable = DataGridViewTriState.False
                    dataGridView1.Rows(k).Selected = False


                    Select Case k

                        Case 0
                            dataGridView1.Rows.Add("Pazartesi")
                        Case 1
                            dataGridView1.Rows.Add("Salı")
                        Case 2
                            dataGridView1.Rows.Add("Çarşamba")
                        Case 3
                            dataGridView1.Rows.Add("Perşembe")
                        Case 4
                            dataGridView1.Rows.Add("Cuma")
                        Case 5
                            dataGridView1.Rows.Add("Cumartesi")
                        Case 6
                            dataGridView1.Rows.Add("Pazar")
                    End Select

                Next


                For k As Integer = 0 To 6 Step 1

                    For i As Integer = 0 To 7 Step 1
                        Dim nt As New TextBox
                        nt.Left = i * nt.Width
                        nt.Name = "nt" + i.ToString()
                        panel1.Controls.Add(nt)
                        dataGridView1.Rows(k).Cells(i + 1).Value = table.days(k).MealRigths(i)
                    Next
                    dataGridView1.Rows(k).Cells(9).Value = table.days(k).TotalDayRight
                Next


            Next

            MessageBox.Show("Yemek hak tablosu getirildi")

        Else
            MessageBox.Show("Yemek hak tablosu getirilemedi")
        End If





    End Sub


End Class