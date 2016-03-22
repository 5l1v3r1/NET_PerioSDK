Imports PerioTcpRdrBase
Imports PerioTCPRdr

Public Class frmPdksZamanKisitTablosu


    Sub rAddLog(str As String)
        logText.AppendText(str)
    End Sub



    Function timetoStr(inComingTime As DateTime) As String

        Dim returned As String = ""
        Dim second As Integer
        Dim hour As Integer
        Dim minute As Integer
        Dim strSecond As String
        Dim strHour As String
        Dim strMinute As String

        hour = inComingTime.Hour
        second = inComingTime.Second
        minute = inComingTime.Minute

        If (Convert.ToString(hour).Length < 2) Then : strHour = "0" + Convert.ToString(hour) : Else : strHour = Convert.ToString(hour) : End If
        If (Convert.ToString(minute).Length < 2) Then : strMinute = "0" + Convert.ToString(minute) : Else : strMinute = Convert.ToString(minute) : End If
        If (Convert.ToString(second).Length < 2) Then : strSecond = "0" + Convert.ToString(second) : Else : strSecond = Convert.ToString(second) : End If

        returned = strHour + ":" + strMinute

        Return returned



    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click


        Dim TACList As TTACList = New TTACList()

        If mainForm.rdr.Connected Then

            If (mainForm.rdr.GetTimeConstraintTables(Convert.ToByte(edtTabloAdi.Value), TACList) = True) Then

                edtListeAdi.Text = TACList.Name

                For i As Integer = 0 To 17 Step 1

                    Select Case i

                        Case 0
                            tabloVerileri1SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri1SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 1
                            tabloVerileri2SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri2SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 2
                            tabloVerileri3SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri3SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 3
                            tabloVerileri4SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri4SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 4
                            tabloVerileri5SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri5SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 5
                            tabloVerileri6SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri6SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 6
                            tabloVerileri7SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri7SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                        Case 7
                            tabloVerileri8SatirBaslangic.Text = timetoStr(TACList.Part(i).StartTime).Replace("01.01.2000 ", "")
                            tabloVerileri8SatirBitis.Text = timetoStr(TACList.Part(i).EndTime).Replace("01.01.2000 ", "")
                    End Select

                Next
                rAddLog("Bilgiler getirildi")
            Else
                rAddLog("Bilgiler getirilemedi")
            End If



        Else
            rAddLog("Cihazla bağlantınız yok")
        End If


    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim TACList As TTACList = New TTACList()

        If (mainForm.rdr.Connected = True) Then
            TACList.Name = edtListeAdi.Text

            For i As Integer = 0 To 7 Step 1

                Select Case i

                    Case 0
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri1SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri1SatirBitis.Text)
                    Case 1
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri2SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri2SatirBitis.Text)
                    Case 2
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri3SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri3SatirBitis.Text)

                    Case 3
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri4SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri4SatirBitis.Text)

                    Case 4
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri5SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri5SatirBitis.Text)

                    Case 5
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri6SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri6SatirBitis.Text)

                    Case 6
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri7SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri7SatirBitis.Text)

                    Case 7
                        TACList.Part(i).StartTime = Convert.ToDateTime(tabloVerileri8SatirBaslangic.Text)
                        TACList.Part(i).EndTime = Convert.ToDateTime(tabloVerileri8SatirBitis.Text)
                End Select

            Next


            Try
                If (mainForm.rdr.SetTimeConstraintTables(Convert.ToByte(edtTabloAdi.Value), TACList) = True) Then
                    rAddLog("Zaman Kısıt Tablosu gönderildi.")
                Else : rAddLog("Zaman Kısıt Tablosu gönderilemedi.")
                End If

            Catch ex As Exception
                rAddLog("Zaman Kısıt Tablosu gönderilemedi." + ex.Message)
            End Try

        Else
            rAddLog("Cihazla bağlantınız yok")
        End If



    End Sub


End Class