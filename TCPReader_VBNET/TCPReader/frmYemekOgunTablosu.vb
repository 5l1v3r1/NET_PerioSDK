Public Class frmYemekOgunTablosu

    Dim gMealTable = New PerioTCPRdr.TMealTable


    Sub formaDiz(day As Integer, MealTable As PerioTCPRdr.TMealTable)
        panel1.Controls.Clear()

        If mainForm.rdr.Connected Then


            For i As Integer = 0 To 7 Step 1
                Dim list1 = New TextBox
                Dim list2 = New TextBox
                Dim list3 = New ComboBox
                Dim list4 = New TextBox
                Dim list5 = New ComboBox
                Dim list6 = New CheckBox

                Dim ogunLabel As New Label With {
                                               .Text = i.ToString() & ".Öğün ",
                                               .Name = "ogunLbl" & i.ToString(),
                                               .Left = 15,
                                               .AutoSize = True,
                                               .Top = i * 30
                                                }


                list1.Name = "txtOgunAdi" + i.ToString()
                list1.Width = 100
                list1.Left = ogunLabel.Width + 10
                list1.Top = i * 30
                list1.Text = MealTable.days(day).list(i).Name

                Dim stBas As String = ""

                If MealTable.days(day).list(i).StartTime.Hour.ToString.Length < 2 Then
                    stBas = "0" & MealTable.days(day).list(i).StartTime.Hour.ToString()
                End If

                If MealTable.days(day).list(i).StartTime.Minute.ToString.Length < 2 Then
                    stBas = stBas & ":0" & MealTable.days(day).list(i).StartTime.Minute.ToString()
                Else
                    stBas = stBas & ":" & MealTable.days(day).list(i).StartTime.Minute.ToString()
                End If


                list2.Name = "txtBaslangicSaati" + i.ToString()
                list2.Width = 100
                list2.Left = ogunLabel.Width + list1.Width + 20
                list2.Top = i * 30
                'list2.Text = MealTable.days(day).list(i).StartTime.Hour & ":" & MealTable.days(day).list(i).StartTime.Minute
                list2.Text = stBas



                '0 1 2 dün bugün yarın
                list3.Name = "txtDunBugunYarin" + i.ToString()
                list3.Width = 50
                list3.Left = ogunLabel.Width + list1.Width + list2.Width + 30
                list3.Top = i * 30
                list3.Items.Add("Dün")
                list3.Items.Add("Bugün")
                list3.Items.Add("Yarın")
                list3.SelectedIndex = MealTable.days(day).list(i).StartDBY

                Dim stBit As String = ""

                If MealTable.days(day).list(i).EndTime.Hour.ToString.Length < 2 Then
                    stBit = "0" & MealTable.days(day).list(i).EndTime.Hour.ToString()
                End If

                If MealTable.days(day).list(i).EndTime.Minute.ToString.Length < 2 Then
                    stBit = stBit & ":0" & MealTable.days(day).list(i).EndTime.Minute.ToString()
                Else
                    stBit = stBit & ":" & MealTable.days(day).list(i).EndTime.Minute.ToString()
                End If

                list4.Name = "txtBitisSaati" + i.ToString()
                list4.Width = 100
                list4.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + 40
                list4.Top = i * 30
                'list4.Text = MealTable.days(day).list(i).EndTime.ToString().Replace("01.01.2000", "").Trim().Remove(5, 3)
                list4.Text = stBit

                list5.Name = "txtDunBugunYarin1" + i.ToString()
                list5.Width = 50
                list5.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + list4.Width + 50
                list5.Top = i * 30
                list5.Items.Add("Dün")
                list5.Items.Add("Bugün")
                list5.Items.Add("Yarın")
                list5.SelectedIndex = MealTable.days(day).list(i).EndDBY

                list6.Name = "txtAktif" + i.ToString()
                list6.AutoSize = True
                '//list6.Width = 35
                list6.Left = ogunLabel.Width + list1.Width + list2.Width + list3.Width + list4.Width + list5.Width + 60
                list6.Top = i * 30
                list6.Text = "Aktif / Pasif"

                If (MealTable.days(day).list(i).Active) Then
                    list6.Checked = True
                Else
                    list6.Checked = False
                End If

                panel1.Controls.Add(ogunLabel)
                panel1.Controls.Add(list1)
                panel1.Controls.Add(list2)
                panel1.Controls.Add(list3)
                panel1.Controls.Add(list4)
                panel1.Controls.Add(list5)
                panel1.Controls.Add(list6)

            Next





        Else
            MessageBox.Show("Cihazla bağlantınız yok")

        End If


    End Sub

    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

        If txtGun.SelectedIndex < 0 Then
            MessageBox.Show("Gün seçin")
        Else
            formaDiz(txtGun.SelectedIndex, gMealTable)
        End If




    End Sub


  


    Sub yaz(day As Integer, MealTable As PerioTCPRdr.TMealTable)

        For i As Integer = 0 To 7 Step 1

            Dim txtOgunAdi As TextBox = panel1.Controls.Find("txtOgunAdi" + i.ToString(), True).FirstOrDefault()
            Dim txtBaslangicSaati As TextBox = panel1.Controls.Find("txtBaslangicSaati" + i.ToString(), False).FirstOrDefault()
            Dim txtDunBugunYarin As ComboBox = panel1.Controls.Find("txtDunBugunYarin" + i.ToString(), False).FirstOrDefault()
            Dim txtBitisSaati As TextBox = panel1.Controls.Find("txtBitisSaati" + i.ToString(), False).FirstOrDefault()
            Dim txtDunBugunYarin1 As ComboBox = panel1.Controls.Find("txtDunBugunYarin1" + i.ToString(), False).FirstOrDefault()
            Dim txtAktif As CheckBox = panel1.Controls.Find("txtAktif" + i.ToString(), False).FirstOrDefault()
            MealTable.days(day).list(i).Name = txtOgunAdi.Text
            MealTable.days(day).list(i).StartTime = New DateTime(2000, 1, 1, txtBaslangicSaati.Text.Substring(0, 2), txtBaslangicSaati.Text.Substring(3, 2), 0)
            MealTable.days(day).list(i).StartDBY = txtDunBugunYarin.SelectedIndex
            MealTable.days(day).list(i).EndTime = New DateTime(2000, 1, 1, txtBaslangicSaati.Text.Substring(0, 2), txtBaslangicSaati.Text.Substring(3, 2), 0)
            MealTable.days(day).list(i).EndDBY = txtDunBugunYarin1.SelectedIndex
            If (txtAktif.Checked = True) Then
                MealTable.days(day).list(i).Active = True
            Else
                MealTable.days(day).list(i).Active = False
            End If
        Next
    End Sub


    Private Sub btnGonder_Click(sender As Object, e As EventArgs) Handles btnGonder.Click

        If (mainForm.rdr.Connected) Then
            yaz(txtGun.SelectedIndex, gMealTable)
            If (mainForm.rdr.SetMealTable(gMealTable)) Then
                MessageBox.Show("Bilgiler gönderildi.")
            Else
                MessageBox.Show("Bilgiler gönderilemedi")
            End If
        Else
            MessageBox.Show("Cihazla bağlantı yok.")

        End If


    End Sub


End Class