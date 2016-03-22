Imports PerioTcpRdrBase

Public Class frmPdksHizmetDisiTablosu

    Function minTimeToStr(veri As Date) As String

        Dim res As String = ""
        Dim hour As String = ""
        Dim minute As String = ""

        hour = Convert.ToString(veri.Hour)
        minute = Convert.ToString(veri.Minute)

        If (hour.Length < 2) Then
            hour = "0" + hour
        End If


        If (minute.Length < 2) Then
            minute = "0" + minute
        End If

        res = hour + ":" + minute

        Return res

    End Function



    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

        Dim OSTable As TOSTable = New TOSTable()

        If (mainForm.rdr.Connected = True) Then


            If (mainForm.rdr.GetOutOfServiceTable(OSTable) = True) Then

                For i As Integer = 0 To 5 Step 1

                    For j As Integer = 0 To 3 Step 1


                        Select Case i

                            Case 0


                                Select Case j
                                    Case 0
                                        hizmetDisiTablosuBas1_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_1.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                End Select

                            Case 1

                                Select Case j
                                    Case 0
                                        hizmetDisiTablosuBas1_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")

                                    Case 3
                                        hizmetDisiTablosuBas4_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_2.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                End Select

                            Case 2

                                Select Case j
                                    Case 0
                                        hizmetDisiTablosuBas1_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_3.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                End Select


                            Case 3

                                Select Case j
                                    Case 0
                                        hizmetDisiTablosuBas1_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_4.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                End Select



                            Case 4

                                Select Case j

                                    Case 0
                                        hizmetDisiTablosuBas1_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_5.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")

                                End Select

                            Case 5

                                Select Case j

                                    Case 0
                                        hizmetDisiTablosuBas1_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_6.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                End Select

                            Case 6


                                Select Case j

                                    Case 0
                                        hizmetDisiTablosuBas1_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit1_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 1
                                        hizmetDisiTablosuBas2_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit2_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 2
                                        hizmetDisiTablosuBas3_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit3_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")
                                    Case 3
                                        hizmetDisiTablosuBas4_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).StartTime)).Replace("01.01.2000 ", "")
                                        hizmetDisiTablosuBit4_7.Text = Convert.ToString(minTimeToStr(OSTable.day(i).part(j).EndTime)).Replace("01.01.2000 ", "")

                                End Select




                        End Select


                    Next

                Next


            End If



        End If




    End Sub


    Private Sub btnGonder_Click(sender As Object, e As EventArgs) Handles btnGonder.Click

        Dim OSTable As TOSTable = New TOSTable()

        If (mainForm.rdr.Connected = True) Then


            For i As Integer = 0 To 6 Step 1


                For j As Integer = 1 To 2 Step 1

                    Select Case i


                        Case 0

                            Select Case j

                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_1.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_1.Text).Second)
                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_1.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_1.Text).Second)
                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_1.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_1.Text).Second)
                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_1.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_1.Text).Second)
                            End Select


                        Case 1


                            Select Case j

                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_2.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_2.Text).Second)
                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_2.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_2.Text).Second)
                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_2.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_2.Text).Second)
                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_2.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_2.Text).Second)


                            End Select


                        Case 2


                            Select Case j

                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_3.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_3.Text).Second)
                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_3.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_3.Text).Second)
                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_3.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_3.Text).Second)
                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_3.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_3.Text).Second)
                            End Select

                        Case 3

                            Select Case j

                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_4.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_4.Text).Second)

                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_4.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_4.Text).Second)

                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_4.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_4.Text).Second)

                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_4.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_4.Text).Second)



                            End Select

                        Case 4

                            Select Case j


                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_5.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_5.Text).Second)
                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_5.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_5.Text).Second)
                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_5.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_5.Text).Second)
                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_5.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_5.Text).Second)


                            End Select


                        Case 5


                            Select Case j

                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_6.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_6.Text).Second)

                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_6.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_6.Text).Second)

                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_6.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_6.Text).Second)

                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_6.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_6.Text).Second)


                            End Select

                        Case 6

                            Select Case j


                                Case 0
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas1_7.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit1_7.Text).Second)
                                Case 1
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas2_7.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit2_7.Text).Second)
                                Case 2
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas3_7.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit3_7.Text).Second)
                                Case 3
                                    OSTable.day(i).part(j).StartTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBas4_7.Text).Second)
                                    OSTable.day(i).part(j).EndTime = New DateTime(2000, 1, 1, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Hour, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Minute, Convert.ToDateTime(hizmetDisiTablosuBit4_7.Text).Second)

                            End Select



                    End Select

                Next

            Next


        End If



    End Sub
End Class