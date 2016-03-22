Imports PerioTCPRdr

Public Class frmZilTablosu

    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click
        Dim BellTable As TBellTable

        If (mainForm.rdr.Connected = True) Then

            If (mainForm.rdr.GetBellTable(Convert.ToByte(txtGun.Value), BellTable) = True) Then


                For i As Integer = 0 To 23 Step 1

                    Select Case i

                        Case 0
                            txtSaat1.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 1
                            txtSaat2.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 2
                            txtSaat3.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 3
                            txtSaat4.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 4
                            txtSaat5.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 5
                            txtSaat6.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 6
                            txtSaat7.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 7
                            txtSaat8.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 8
                            txtSaat9.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 9
                            txtSaat10.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 10
                            txtSaat11.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 11
                            txtSaat12.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 12
                            txtSaat13.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 13
                            txtSaat14.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 14
                            txtSaat15.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 15
                            txtSaat16.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 16
                            txtSaat17.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 17
                            txtSaat18.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 18
                            txtSaat19.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 19
                            txtSaat20.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 20
                            txtSaat21.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 21
                            txtSaat22.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 22
                            txtSaat23.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")

                        Case 23
                            txtSaat24.Text = Convert.ToString(BellTable.List(i).StartTime).Replace("01.01.2000 ", "")


                    End Select

                Next


            Else


                MessageBox.Show("Zil tablosu getirilemedi.")

            End If




        Else
            MessageBox.Show("Cihazla bağlantınız yok")

        End If


    End Sub

    Private Sub btnGonder_Click(sender As Object, e As EventArgs) Handles btnGonder.Click


        Dim BellTable As TBellTable = New TBellTable()

        If (mainForm.rdr.Connected = True) Then

            For i As Integer = 0 To 23 Step 1

                Select Case i

                    Case 0
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat1.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure1.Text)

                    Case 1
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat2.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure2.Text)

                    Case 2
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat3.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure3.Text)

                    Case 3
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat4.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure4.Text)

                    Case 4
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat5.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure5.Text)

                    Case 5
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat6.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure6.Text)

                    Case 6
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat7.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure7.Text)

                    Case 7
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat8.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure8.Text)

                    Case 8
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat9.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure9.Text)

                    Case 9
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat10.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure10.Text)

                    Case 10
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat11.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure11.Text)

                    Case 11
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat12.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure12.Text)

                    Case 12
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat13.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure13.Text)

                    Case 13
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat14.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure14.Text)

                    Case 14
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat15.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure15.Text)

                    Case 15
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat16.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure16.Text)

                    Case 16
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat17.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure17.Text)

                    Case 17
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat18.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure18.Text)

                    Case 18
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat19.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure19.Text)

                    Case 19
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat20.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure20.Text)

                    Case 20
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat21.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure21.Text)

                    Case 21
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat22.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure22.Text)

                    Case 22
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat23.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure23.Text)

                    Case 23
                        BellTable.List(i).StartTime = Convert.ToDateTime(txtSaat24.Text)
                        BellTable.List(i).Duration = Convert.ToByte(txtSure24.Text)

                End Select

            Next

            If (mainForm.rdr.SetBellTable(Convert.ToByte(txtGun.Value), BellTable) = True) Then
                MessageBox.Show("Zil tablosu gönderildi.")
            Else : MessageBox.Show("Zil tablosu gönderilemedi.") : End If

        Else

            MessageBox.Show("Cihazla bağlantınız yok")
        End If

    End Sub
End Class