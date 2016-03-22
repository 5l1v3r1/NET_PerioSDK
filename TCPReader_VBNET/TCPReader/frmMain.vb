Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.Threading
Imports PerioTcpRdrBase
Imports PerioTCPRdr


Public Class mainForm

    Public Structure TMsg
        Public MsgID As UShort
        Public MsgName As String
    End Structure

    Public rdr As PerioTCPRdrComp
    Dim ReadDataBlock As Boolean
    Dim ConfirmationType As New TInputConfirmationType
    Dim OffflineMsg As TMsg() = New TMsg(78) {}

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdr = New PerioTCPRdrComp()
        AddHandler rdr.OnRxCardID, AddressOf rdrOnRxCardID
        AddHandler rdr.OnRxTurnstileTurn, AddressOf rdrOnTurnstileTurn
        AddHandler rdr.OnRxSerialReadStr, AddressOf rdrOnRxSerialStr
        AddHandler rdr.OnRxDoorOpenAlarm, AddressOf rdrOnRxDoorOpenAlarm
        AddHandler rdr.OnConnected, AddressOf rdrOnConnected
        AddHandler rdr.OnDisConnected, AddressOf rdrOnDisConnected

        dtTimer.Enabled = True
        txtUygulamaTipi.SelectedIndex = 0
        ReadDataBlock = False

    End Sub

    Private Sub SendUdpDataToLog(str As String)

        Dim method As MethodInvoker = Sub() udpLogText.AppendText(str)

        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If

    End Sub

    Private Sub StartListener(portNumber As Integer)
        Dim bitti As Boolean = False

        Dim listener As New UdpClient(portNumber)
        Dim groupEP As New IPEndPoint(IPAddress.Any, portNumber)
        Try
            While Not bitti
                Dim bytes As Byte() = listener.Receive(groupEP)
                SendUdpDataToLog("Received broadcast from {0} :" & vbLf & " {1}" & vbLf + groupEP.ToString() + Encoding.ASCII.GetString(bytes, 0, bytes.Length))
            End While
        Catch e As Exception
            udpLogText.AppendText("Hata oluştu : " + e.ToString())
        Finally
            listener.Close()
        End Try
    End Sub

    Private Sub rdrOnRxDoorOpenAlarm(source As Object, e As RxDoorOpenAlarmArgs)
        Dim method As MethodInvoker = Sub()

                                          If e.DoorOpen Then
                                              AddLog("Kapı Açık Kaldı. ")
                                          Else

                                              AddLog("Kapı kapandı. Açık kalan süre [" + Convert.ToString(e.OpenTime) + "].")
                                          End If

                                      End Sub

        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If


    End Sub

    Private Sub rdrOnRxCardID(source As Object, e As RxCardIDArgs)

        Dim DataValue As Byte() = New Byte(18) {}
        Dim str As [String]

        Dim s As PerioTCPRdrComp = TryCast(source, PerioTCPRdrComp)



        Dim method As MethodInvoker = Sub()
                                          'AddLog("Okunulan Kart ID [" + e.CardID + "]." + " IP: " + s.IP + " device Id: " + s.DeviceID + " device name: " + s.DeviceName)


                                          Dim gelenHata As String = ""
                                          Dim ui As uyeIslemleri = New uyeIslemleri()
                                          Dim uyeBilgisi As tUye = New tUye()
                                          uyeBilgisi.uyeKartId = e.CardID
                                          uyeBilgisi.uyeAdi = "Tunç Güleç"

                                          Dim uyeVarmi As Boolean = ui.kartVarmi(uyeBilgisi, gelenHata)

                                          If uyeVarmi Then
                                              rdr.SetBeepRelayAndSecreenMessage(0, 0, "", "Üye Bulundu ", uyeBilgisi.uyeAdi, "", _
                                              "", "", "", 5, 15, 0, _
                                              5, 35, 0, 0, 0, 0, _
                                              0, 0, 0, 0, 0, 0, _
                                              2, 2, 50, 50, 0, 10, _
                                              True)
                                          Else
                                              rdr.SetBeepRelayAndSecreenMessage(0, 0, "Baslik", gelenHata, uyeBilgisi.uyeKartId, "", _
                                              "", "", "", 5, 15, 0, _
                                              5, 35, 0, 0, 0, 0, _
                                              0, 0, 0, 0, 0, 0, _
                                              2, 2, 50, 50, 0, 10, _
                                              False)
                                          End If



                                          'MessageBox.Show(gelenHata)

                                          If ReadDataBlock Then
                                              If rdr.ReadCardBlockData(5, 1, TKeyType.ktKeyA, DataValue) Then
                                                  str = ""

                                                  For i As Integer = 0 To 15
                                                      If str = "" Then
                                                          str = Convert.ToString(DataValue(i))
                                                      Else
                                                          str += "-" + Convert.ToInt32(DataValue(i))
                                                      End If
                                                  Next

                                                  AddLog("Okunulan değer [" + str + "]")

                                                  For i As Integer = 0 To 15
                                                      DataValue(i) = CByte(i + 2)
                                                  Next


                                                  If rdr.WriteCardBlockData(5, 1, TKeyType.ktKeyA, DataValue) Then
                                                      AddLog("Data yazıldı.")



                                                  End If

                                              End If
                                          End If




                                          'rdr.SetBeepRelayAndSecreenMessage(0, 0, "", "Online ", "Test", "", _
                                          '    "", "", "", 5, 15, 0, _
                                          '    5, 35, 0, 0, 0, 0, _
                                          '    0, 0, 0, 0, 0, 0, _
                                          '    2, 2, 5, 5, 0, 10, _
                                          '    False)

                                          ''0555 597 19 84 ömer aydın


                                          If ReadDataBlock Then

                                              If rdr.ReadCardBlockData(5, 1, TKeyType.ktKeyA, DataValue) Then
                                                  str = ""

                                                  For i As Integer = 0 To 15
                                                      If str = "" Then
                                                          str = Convert.ToString(DataValue(i))
                                                      Else
                                                          str += "-" + Convert.ToString(DataValue(i))


                                                      End If
                                                  Next

                                                  AddLog("Okunulan değer 2 [" + str + "]")


                                              End If



                                          End If

                                      End Sub
        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If
    End Sub

    Private Sub rdrOnTurnstileTurn(source As Object, e As RxTurnstileTurnArgs)
        Dim method As MethodInvoker = Sub()
                                          If e.Success Then

                                              AddLog("Turnike Dönüş başarılı Kart ID [" + e.CardID + "].")
                                          Else
                                              AddLog("Turnike Dönüş başarısız Kart ID [" + e.CardID + "].")

                                          End If
                                      End Sub

        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If
    End Sub

    Private Sub rdrOnRxSerialStr(source As Object, e As RxSerialReadStrArgs)
        Dim method As MethodInvoker = Sub() AddLog("Okunulan Data [" + e.Data + " - SerialPortNo : " + Convert.ToString(e.SerialPortNo) + "].")
        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If
    End Sub

    Private Sub rdrOnConnected(source As Object)
        Dim method As MethodInvoker = Sub() AddLog("Bağlantı Kuruldu. ")

        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If
    End Sub

    Private Sub rdrOnDisConnected(source As Object)
        Dim method As MethodInvoker = Sub() AddLog("Bağlantı Kesild. ")

        If InvokeRequired Then
            BeginInvoke(method)
        Else
            method.Invoke()
        End If
    End Sub

    Public Sub AddLog(str As String, Optional SM As [Boolean] = False)
        Dim log As String
        log = appLog.Text


        Dim ss As String, dd As String, sa As String, msc As String = ""
        ss = Convert.ToString(DateTime.Now.Hour)
        dd = Convert.ToString(DateTime.Now.Minute)
        sa = Convert.ToString(DateTime.Now.Second)
        msc = Convert.ToString(DateTime.Now.Millisecond)

        If Convert.ToString(DateTime.Now.Hour).Length < 2 Then
            ss = "0" + Convert.ToString(DateTime.Now.Hour)
        End If


        If Convert.ToString(DateTime.Now.Minute).Length < 2 Then
            dd = "0" + Convert.ToString(DateTime.Now.Minute)
        End If


        If Convert.ToString(DateTime.Now.Second).Length < 2 Then
            sa = "0" + Convert.ToString(DateTime.Now.Second)
        End If

        If Convert.ToString(DateTime.Now.Millisecond).Length < 2 Then
            msc = "0" + Convert.ToString(DateTime.Now.Millisecond)
        End If


        'appLog.Text = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second.ToString() + " > " + str + "\n" + log;
        appLog.Text = Convert.ToString((Convert.ToString((Convert.ToString((Convert.ToString((Convert.ToString(ss & Convert.ToString(":")) & dd) + ":") & sa) + " : ") & msc) + " > ") & str) + vbLf) & log
        If SM Then
            MessageBox.Show(str)
        End If
    End Sub



    Private Sub btnBaglan_Click(sender As Object, e As EventArgs) Handles btnBaglan.Click


        Select Case cbReaderType.SelectedIndex
            Case 0
                rdr.ReaderType = TReaderType.rdr63M_V3
            Case 1
                rdr.ReaderType = TReaderType.rdr63M_V5
            Case 2
                rdr.ReaderType = TReaderType.rdr26M
        End Select

        Select Case cbProtocol.SelectedIndex
            Case 0
                rdr.pProtocolType = TProtocolType.PR0
            Case 1
                rdr.pProtocolType = TProtocolType.PR1
            Case 2
                rdr.pProtocolType = TProtocolType.PR2
            Case 3
                rdr.pProtocolType = TProtocolType.PR3
        End Select

        Select Case cbDfSize.SelectedIndex
            Case 0
                rdr.DFType = TDFType.df4MB
            Case 1
                rdr.DFType = TDFType.df8MB
        End Select


        Select Case txtUygulamaTipi.SelectedIndex
            Case 0
                rdr.fwAppType = TfwAppType.fwHGS
            Case 1
                rdr.fwAppType = TfwAppType.fwPDKS
            Case 2
                rdr.fwAppType = TfwAppType.fwYMK
        End Select


        btnUDPbaslat.PerformClick()

        rdr.IP = edtIp.Text
        rdr.Port = Convert.ToInt32(edtPortNo.Value)
        rdr.TimeOut = Convert.ToUInt32(edtTimeOut.Value)
        rdr.DeviceLoginKey = edtDeviceKey.Text
        rdr.CommandRetry = Convert.ToInt32(edtCmtRetry.Value)
        rdr.AutoConnect = cbAutoConnect.Checked
        rdr.AutoRxEnabled = cbAutoRxEnabled.Checked

        Select Case txtUygulamaTipi.SelectedIndex
            Case 0
                rdr.fwAppType = TfwAppType.fwPDKS
            Case 1
                rdr.fwAppType = TfwAppType.fwHGS
            Case 2
                rdr.fwAppType = TfwAppType.fwYMK
        End Select

        rdr.OnlineReConnectTimeOut = 5000

        Try

            Me.Cursor = Cursors.WaitCursor
            Try
                rdr.Connect()

                If rdr.Connected Then
                    AddLog(rdr.IP & " adresi ile bağlantı sağlandı.")
                    GoTo loadSettings
                Else
                    AddLog(rdr.IP & " adresi ile bağlantı kurulamadı.")
                End If

            Catch ex As Exception
                AddLog("Bağlantı sağlanamadı. " & ex.Message & " hatası ", False)
                Me.Cursor = Cursors.Default
            End Try

        Finally

            Me.Cursor = Cursors.Default

        End Try

loadSettings:

        btnFirmWareVersiyonu.PerformClick()
        btnHeadTailGonder.PerformClick()
        btnGetir.PerformClick()
        btnCihazGenelAyarlariGetir.PerformClick()
        btnCihazCalismaModuGetir.PerformClick()
        btnCihazSeriNumarasiGetir.PerformClick()
        btnSeriPortGetir.PerformClick()




        'For Each thisForm As Control In Me.Controls

        '    If thisForm.HasChildren Then

        '        For Each tabControls As Control In thisForm.Controls

        '            'If tabControls.GetType Is GetType(TabControl) Then

        '            For Each thisCnt As Control In tabControls.Controls
        '                MessageBox.Show(thisCnt.Name)
        '            Next


        '            ' End If

        '        Next

        '    End If

        'Next



    End Sub



    Private Sub btnBaglantiKes_Click(sender As Object, e As EventArgs) Handles btnBaglantiKes.Click
        rdr.DisConnect()
    End Sub

    Private Sub btnLoglariTemizle_Click(sender As Object, e As EventArgs) Handles btnLoglariTemizle.Click
        appLog.Clear()
    End Sub

    Private Sub btnFirmWareVersiyonu_Click(sender As Object, e As EventArgs) Handles btnFirmWareVersiyonu.Click

        If rdr.Connected Then
            txtCihazFirmWareVersiyonu.Text = rdr.GetFwVwersion()
            AddLog("Cihaz FW versiyonu getirildi.")
        Else
            AddLog("Cihazla bağlantı yok.")
        End If

    End Sub


    Private Sub btnHeadTailGonder_Click(sender As Object, e As EventArgs) Handles btnHeadTailGonder.Click


        If rdr.Connected Then

            Dim Head As Integer
            Dim Tail As Integer
            Dim Capacity As Integer

            If rdr.GetHeadTailCapacity(Head, Tail, Capacity) Then
                txtHead.Value = Head
                txtTail.Value = Tail
                lblKapasite.Text = Capacity.ToString()
                AddLog("Head -Tail Bilgisi getirildi.")
            Else
                AddLog("Head -Tail Bilgisi getirilemedi.")
            End If

        Else
            AddLog("Cihazla bağlantı yok")
        End If





    End Sub

    Private Sub btnHeadTailGetir_Click(sender As Object, e As EventArgs) Handles btnHeadTailGetir.Click

        If rdr.Connected Then

            If rdr.SetHeadTail(Convert.ToInt32(txtHead.Value), Convert.ToInt32(txtTail.Value)) Then
                AddLog("Head -Tail Bilgisi Gönderildi.")
            Else
                AddLog("Head -Tail Bilgisi Gönderilemedi.")
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If


    End Sub

    Private Sub dtTimer_Tick(sender As Object, e As EventArgs) Handles dtTimer.Tick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rdr.Connected Then
            If rdr.SetDateTime(txtTarihSaat.Value) Then
                AddLog("Tarih saat bilgisi gönderildi.")
            Else
                AddLog("Tarih saat bilgisi gönderilemedi.")
            End If
        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If

    End Sub




    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

        If rdr.Connected Then

            If rdr.GetDeviceStatus Then
                txtAktif.Checked = True
            Else
                txtPasif.Checked = True
            End If
            AddLog("Cihaz durumu getirildi.")

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If


    End Sub



    Private Sub btnGonder_Click(sender As Object, e As EventArgs) Handles btnGonder.Click


        If rdr.Connected Then

            If rdr.SetDeviceStatus(txtAktif.Checked) Then
                AddLog("Cihaz durumu gönderildi.")
            Else
                AddLog("Cihaz durumu gönderilemedi.")
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If


    End Sub



    Private Sub btnCihaziYenidenBaslat_Click(sender As Object, e As EventArgs) Handles btnCihaziYenidenBaslat.Click

        Dim onay As New DialogResult

        onay = MessageBox.Show("Cihazın yeniden başlatılmasını istediğinizden emin misiniz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If onay = Windows.Forms.DialogResult.Yes Then
            GoTo baslat
        End If


baslat:
        If rdr.Connected Then
            rdr.Reboot()
            rdr.DisConnect()
            Thread.Sleep(300)
            rdr.Connect()
        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If


    End Sub


    Private Sub btnFabrikaAyarlarinaDon_Click(sender As Object, e As EventArgs) Handles btnFabrikaAyarlarinaDon.Click

        Dim onay As New DialogResult

        onay = MessageBox.Show("Cihazın fabrika ayarlarına dönmesini istediğinizden emin misiniz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If onay = Windows.Forms.DialogResult.Yes Then
            GoTo fabrikaAyalari
        End If

fabrikaAyalari:

        If rdr.Connected Then

            If (txtIpAdresiKaydet.Checked) Then
                rdr.SetDeviceFactoryDefault(False)
            Else
                rdr.SetDeviceFactoryDefault(True)
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If

    End Sub


    Private Sub btnCihazGenelAyarlariGetir_Click(sender As Object, e As EventArgs) Handles btnCihazGenelAyarlariGetir.Click


        Dim rSettings As New TGeneralDeviceSettins

        If rdr.Connected Then

            If rdr.GetDeviceGeneralSettings(rSettings) Then

                txtCihazNo.Value = rSettings.DevNo

                Select Case rSettings.IdleScreenType
                    Case TIdleScreenType.stText
                        txtVarsayilanMesaj.Checked = True
                    Case TIdleScreenType.stLogo
                        txtVarsayilanLogo.Checked = True
                End Select

                txtBirinciSatir.Text = rSettings.DefaultScreenTxt1
                txtIkinciSatir.Text = rSettings.DefaultScreenTxt2
                txtArkaPlanIsigi.Value = rSettings.Backlight
                txtRenkYogunlugu.Value = rSettings.Contrast

                Select Case rSettings.TrOut1Type
                    Case TrOutType.NrOpen
                        txtTransistorCikisi1NormalOpen.Checked = True
                    Case TrOutType.NrClosed
                        txtTransistorCikisi1NormalClosed.Checked = True
                End Select


                Select Case rSettings.TrOut2Type
                    Case TrOutType.NrOpen
                        txtTransistorCikisi2NormalOpen.Checked = True
                    Case TrOutType.NrClosed
                        txtTransistorCikisi2NormalClosed.Checked = True
                End Select

                txtGunlukYenidenBaslatma.Checked = rSettings.DailyRebootEnb
                txtGunlukYenidenBaslatmaZamani.Value = rSettings.RebootTime
                txtKartOkumaSuresi.Value = rSettings.CardReadBeepTime
                txtArdasikKartOkumaAraligi.Value = rSettings.VariableClearTimeout
                AddLog("Cihaz Genel Bilgileri Getirildi.")

            Else

                AddLog("Cihaz Genel Bilgileri Getirilemedi.")
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If




    End Sub


    Private Sub btnCihazCalismaModuGetir_Click(sender As Object, e As EventArgs) Handles btnCihazCalismaModuGetir.Click

        Dim rSettings As New TWorkModeSettings

        If rdr.Connected Then

            If (rdr.GetDeviceWorkModeSettings(rSettings)) Then


                Select Case rSettings.WorkingMode
                    Case TWorkingMode.wmOffline
                        txtCihazCalismaModuOfflineWhiteList.Checked = True
                    Case TWorkingMode.wmOfflineCard
                        txtCihazCalismaModuOfflineKartVeKaraListe.Checked = True
                    Case TWorkingMode.wmTCPOnline
                        txtCihazCalismaModuOnlineTcp.Checked = True
                    Case TWorkingMode.wmUDPOnline
                        txtCihazCalismaModuOnlineUdp.Checked = True
                End Select

                cbOnlineEnabledOffline.Checked = rSettings.OfflineModePermission
                txtZamanAsimi.Value = rSettings.ServerAnswerTimeOut
                AddLog("Cihaz çalışma modu getirildi.")
            Else
                AddLog("Cihaz çalışma modu getirilemedi.")

            End If


        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If





    End Sub


    Private Sub btnCihazSeriNumarasiGetir_Click(sender As Object, e As EventArgs) Handles btnCihazSeriNumarasiGetir.Click

        If rdr.Connected Then


            Dim serialNo As String = ""

            serialNo = rdr.GetSerialNumber()

            If serialNo <> "" Then
                txtCihazSeriNumarasi.Text = serialNo
                AddLog("Cihaz seri numarası getirildi.")
            Else
                AddLog("Cihaz seri numarası getirilemedi.")
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If

    End Sub

    Private Sub btnCihazCalismaModuGonder_Click(sender As Object, e As EventArgs) Handles btnCihazCalismaModuGonder.Click


        Dim rSettings As New TWorkModeSettings()

        If rdr.Connected Then

            If txtCihazCalismaModuOfflineWhiteList.Checked Then
                rSettings.WorkingMode = TWorkingMode.wmOffline
            ElseIf txtCihazCalismaModuOfflineKartVeKaraListe.Checked Then
                rSettings.WorkingMode = TWorkingMode.wmOfflineCard
            ElseIf txtCihazCalismaModuOnlineTcp.Checked Then
                rSettings.WorkingMode = TWorkingMode.wmTCPOnline
            ElseIf txtCihazCalismaModuOnlineUdp.Checked Then
                rSettings.WorkingMode = TWorkingMode.wmUDPOnline
            End If

            rSettings.OfflineModePermission = cbOnlineEnabledOffline.Checked
            rSettings.ServerAnswerTimeOut = txtZamanAsimi.Value

            If rdr.SetDeviceWorkModeSettings(rSettings) Then
                AddLog("Cihaz genel ayarları gönderildi.")
            Else
                AddLog("Cihaz genel ayarları gönderilemedi")
            End If


        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If


    End Sub


    Private Sub btnCihazGenelAyarlariGonder_Click(sender As Object, e As EventArgs) Handles btnCihazGenelAyarlariGonder.Click

        Dim rSettings As New TGeneralDeviceSettins

        If rdr.Connected Then


            rSettings.DevNo = txtCihazNo.Value
            rSettings.Backlight = txtArkaPlanIsigi.Value
            rSettings.CardReadBeepTime = txtKartOkumaSuresi.Value
            rSettings.CardReadTimeOut = txtArdasikKartOkumaAraligi.Value
            rSettings.Contrast = txtRenkYogunlugu.Value
            rSettings.DailyRebootEnb = txtGunlukYenidenBaslatma.Checked
            rSettings.DefaultScreenTxt1 = txtBirinciSatir.Text
            rSettings.DefaultScreenTxt2 = txtIkinciSatir.Text

            If txtVarsayilanLogo.Checked Then
                rSettings.IdleScreenType = TIdleScreenType.stLogo
            ElseIf txtVarsayilanMesaj.Checked Then
                rSettings.IdleScreenType = TIdleScreenType.stText
            End If

            rSettings.RebootTime = txtGunlukYenidenBaslatmaZamani.Value

            If txtTransistorCikisi1NormalClosed.Checked Then
                rSettings.TrOut1Type = TrOutType.NrClosed
            ElseIf txtTransistorCikisi1NormalOpen.Checked Then
                rSettings.TrOut1Type = TrOutType.NrOpen
            End If


            If txtTransistorCikisi2NormalClosed.Checked Then
                rSettings.TrOut2Type = TrOutType.NrClosed
            ElseIf txtTransistorCikisi2NormalOpen.Checked Then
                rSettings.TrOut2Type = TrOutType.NrOpen
            End If

            rSettings.VariableClearTimeout = txtArdasikKartOkumaAraligi.Value


            If rdr.SetDeviceGeneralSettings(rSettings) Then
                AddLog("Cihaz çalışma modu ayarları gönderildi.")
            Else
                AddLog("Cihaz çalışma modu ayarları gönderilemedi.")
            End If


        Else
            AddLog("Cihaz bağlantısı yok")
        End If


    End Sub



    Private Sub btnCihazSeriNumarasiGonder_Click(sender As Object, e As EventArgs) Handles btnCihazSeriNumarasiGonder.Click


        If rdr.Connected Then


            If txtCihazSeriNumarasi.Text.Trim() = "" Then

                MessageBox.Show("cihaz seri numarası boş olamaz.")
            Else

                If (rdr.SetSerialNumber(txtCihazSeriNumarasi.Text)) Then
                    AddLog("Cihaz seri numarası gönderildi.")
                Else
                    AddLog("cihaz seri numarası gönderilemedi.")
                End If


            End If

        Else
            AddLog("Cihaz bağlantısı yok")
        End If

    End Sub


    Private Sub btnSeriPortGetir_Click(sender As Object, e As EventArgs) Handles btnSeriPortGetir.Click


        Dim s0, s1, SerailAppType As Byte

        If rdr.Connected Then


            If (rdr.GetSerialPortBaudrateSettings(SerailAppType, s0, s1)) Then

                If SerailAppType < 2 Then
                    txtSeriPortBaudRateUygulamaTipi.SelectedIndex = SerailAppType
                Else
                    txtSeriPortBaudRateUygulamaTipi.SelectedIndex = 0
                End If


                txtSeriPortBaudRateSeri0.SelectedIndex = s0
                txtSeriPortBaudRateSeri1.SelectedIndex = s1
                AddLog("Cihaz seriport boudrate ayarları getirildi.")
            Else
                AddLog("Cihaz seriport boudrate ayarları getirilemedi.")
            End If

        Else
            AddLog("Cihaz bağlantısı yok")
        End If

    End Sub


    Private Sub btnSeriPortGonder_Click(sender As Object, e As EventArgs) Handles btnSeriPortGonder.Click


        If rdr.Connected Then


            If rdr.SetSerialPortBaudrateSettings(txtSeriPortBaudRateUygulamaTipi.SelectedIndex, txtSeriPortBaudRateSeri0.SelectedIndex, txtSeriPortBaudRateSeri1.SelectedIndex) Then
                AddLog("Cihaz seriport boudrate ayarları gönderildi")
            Else
                AddLog("Cihaz seriport boudrate ayarları gönderilemedi")

            End If


        Else

            AddLog("Cihaz bağlantısı yok")
        End If


    End Sub



    Private Sub btnSeriPortTest_Click(sender As Object, e As EventArgs) Handles btnSeriPortTest.Click

    End Sub

    Private Sub btnTanimliTumKisileriSil_Click(sender As Object, e As EventArgs) Handles btnTanimliTumKisileriSil.Click


        If rdr.Connected Then

            Dim onay As DialogResult
            onay = MessageBox.Show("Cihazdaki tüm kişilerin silinmesini istediğinizden emin misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If onay = Windows.Forms.DialogResult.Yes Then

                Try
                    rdr.ClearWhitelist()
                    AddLog("Kişiler silindi")
                Catch ex As Exception
                    AddLog("Kişiler silinemedi. " & ex.Message & " hatası meydana geldi.")
                End Try

            End If

        Else
            AddLog("Cihaz bağlantısı yok")
        End If




    End Sub

    Private Sub btnKisiEkle_Click(sender As Object, e As EventArgs) Handles btnKisiEkle.Click


        If rdr.Connected Then


            Dim iErr As Integer
            Dim InxNm As UInteger
            Dim CardID As String
            lblIndexNo.Text = "-1"

            CardID = txtKartId.Text

            If (rdr.IsHex(CardID) And (CardID.Length) = 14) Then

                Dim Person As New TPerson()

                Person.CardID = CardID
                Person.Name = txtAd.Text.Substring(0, 18)
                Person.TimeAccessMask(0) = zamanKisitPazartesi.Value
                Person.TimeAccessMask(1) = zamanKisitSali.Value
                Person.TimeAccessMask(2) = zamanKisitCarsamba.Value
                Person.TimeAccessMask(3) = zamanKisitPersembe.Value
                Person.TimeAccessMask(4) = zamanKisitCuma.Value
                Person.TimeAccessMask(5) = zamanKisitCumartesi.Value
                Person.TimeAccessMask(6) = zamanKisitPazar.Value
                Person.Code = txtKod.Value
                Person.Password = txtSifre.Value


                Person.EndDate(0) = txtKartinSonKullanmaTarihi.Value.Day
                Person.EndDate(1) = txtKartinSonKullanmaTarihi.Value.Month
                Person.EndDate(2) = txtKartinSonKullanmaTarihi.Value.Year - 2000

                Person.AccessDevice = txtKisiCihazdaAktif.Checked
                Person.APBEnabled = txtAntiPassBackKontrolu.Checked
                Person.ATCEnabled = txtZamanKisitKontrolu.Checked
                Person.AccessCardEnabled = txtKarttanGirisKontroluYapilsin.Checked


                iErr = rdr.AddWhitelist(Person, InxNm)

                Select Case iErr
                    Case 0
                        AddLog("Kişi eklendi.")
                        lblIndexNo.Text = InxNm.ToString()
                    Case 1
                        AddLog("Daha önce eklenmiş.")
                    Case 20
                        AddLog("Şifre kapasitesi aşıldı.")
                    Case 51
                        AddLog("Bu Kart ID daha önce tanımlanmış.")
                    Case 52
                        AddLog("Bu şifre daha önce tanımlanmış.")
                    Case Else
                        AddLog("Hata iErr : " + iErr.ToString())
                End Select


            Else
                AddLog("Uygun Kart ID girilmemiş.")

            End If



            Else
                AddLog("Cihazla bağlantı yok")
            End If




    End Sub

    Private Sub btnKisiDegistir_Click(sender As Object, e As EventArgs) Handles btnKisiDegistir.Click

        If (rdr.Connected) Then


            Dim iErr As Integer
            Dim InxNm As UInteger
            Dim CardID As String
            lblIndexNo.Text = "-1"
            CardID = txtKartId.Text

            If (rdr.IsHex(CardID) And (CardID.Length = 14)) Then


                Dim Person As New TPerson()

                Person.CardID = CardID
                Person.Name = txtAd.Text.Substring(0, 18)
                Person.TimeAccessMask(0) = zamanKisitPazartesi.Value
                Person.TimeAccessMask(1) = zamanKisitSali.Value
                Person.TimeAccessMask(2) = zamanKisitCarsamba.Value
                Person.TimeAccessMask(3) = zamanKisitPersembe.Value
                Person.TimeAccessMask(4) = zamanKisitCuma.Value
                Person.TimeAccessMask(5) = zamanKisitCumartesi.Value
                Person.TimeAccessMask(6) = zamanKisitPazar.Value
                Person.Code = txtKod.Value
                Person.Password = txtSifre.Value


                Person.EndDate(0) = txtKartinSonKullanmaTarihi.Value.Day
                Person.EndDate(1) = txtKartinSonKullanmaTarihi.Value.Month
                Person.EndDate(2) = txtKartinSonKullanmaTarihi.Value.Year - 2000

                Person.AccessDevice = txtKisiCihazdaAktif.Checked
                Person.APBEnabled = txtAntiPassBackKontrolu.Checked
                Person.ATCEnabled = txtZamanKisitKontrolu.Checked
                Person.AccessCardEnabled = txtKarttanGirisKontroluYapilsin.Checked


                iErr = rdr.EditWhitelistWithCardID(Person, InxNm)

                Select Case iErr
                    Case 0
                        AddLog("Kişi eklendi.")
                        lblIndexNo.Text = InxNm.ToString()
                    Case 1
                        AddLog("Daha önce eklenmiş.")
                    Case 20
                        AddLog("Şifre kapasitesi aşıldı.")
                    Case 51
                        AddLog("Bu Kart ID daha önce tanımlanmış.")
                    Case 52
                        AddLog("Bu şifre daha önce tanımlanmış.")
                    Case Else
                        AddLog("Hata iErr : " + iErr.ToString())
                End Select


            Else
                AddLog("Uygun Kart ID girilmemiş.")
            End If

        Else
            AddLog("Cihazla bağlantı yok")
        End If


    End Sub



    Private Sub btnKisiSil_Click(sender As Object, e As EventArgs) Handles btnKisiSil.Click

        If rdr.Connected Then


            Dim InxNm As New UInteger
            Dim CardID As String
            lblIndexNo.Text = "-1"
            CardID = txtKartId.Text


            If (rdr.IsHex(CardID) And (CardID.Length = 14)) Then

                If (rdr.DeleteWhitelistWithCardID(CardID, InxNm) = 0) Then
                    AddLog("Kişi silindi")
                    lblIndexNo.Text = InxNm.ToString()
                Else
                    AddLog("Kişi silinemedi.")
                End If

            Else
                AddLog("Uygun Kart ID girilmemiş.")
            End If

        Else
            AddLog("Cihazla bağlantı yok")
        End If


    End Sub


    Private Sub btnKisiBul_Click(sender As Object, e As EventArgs) Handles btnKisiBul.Click

        If (rdr.Connected) Then


            Dim iErr As Integer
            Dim InxNm As UInteger
            Dim CardID As String
            lblIndexNo.Text = "-1"
            CardID = txtKartId.Text

            If (rdr.IsHex(CardID) And (CardID.Length = 14)) Then
                Dim Person As New TPerson()

                iErr = rdr.GetWhitelistWithCardID(CardID, Person, InxNm)

                If iErr = 0 Then
                    txtAd.Text = Person.Name
                    zamanKisitPazartesi.Value = Person.TimeAccessMask(0)
                    zamanKisitSali.Value = Person.TimeAccessMask(1)
                    zamanKisitCarsamba.Value = Person.TimeAccessMask(2)
                    zamanKisitPersembe.Value = Person.TimeAccessMask(3)
                    zamanKisitCuma.Value = Person.TimeAccessMask(4)
                    zamanKisitCumartesi.Value = Person.TimeAccessMask(5)
                    zamanKisitPazar.Value = Person.TimeAccessMask(6)
                    txtKod.Value = Person.Code
                    txtSifre.Value = Person.Code
                    txtKartinSonKullanmaTarihi.Value = New DateTime(Person.EndDate(0) - 2000, Person.EndDate(1), Person.EndDate(2))
                    txtKisiCihazdaAktif.Checked = Person.AccessDevice
                    txtAntiPassBackKontrolu.Checked = Person.APBEnabled
                    txtZamanKisitKontrolu.Checked = Person.AccessCardEnabled



                Else
                    AddLog("Kişi getirilemedi.(" + iErr.ToString() + ")")
                End If

            Else
                AddLog("Uygun Kart ID girilmemiş.")
            End If


        Else
            AddLog("Cihazla bağlantı yok")

        End If

    End Sub


    Private Sub btnTanimliKartSayisi_Click(sender As Object, e As EventArgs) Handles btnTanimliKartSayisi.Click



        If rdr.Connected Then


            Dim cnt As Integer = rdr.GetWhitelistCardIDCount()

            If cnt > -1 Then

                lblTanimliKartSayisi.Text = cnt.ToString()

            Else
                lblTanimliKartSayisi.Text = "Kişi sayısı getirilemedi"
                AddLog("Tanımlı kişi sayısı getirilemedi.")
            End If


        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If

        

    End Sub

    Private Sub btnYemekhaneAyarlariGetir_Click(sender As Object, e As EventArgs) Handles btnYemekhaneAyarlariGetir.Click

        Dim rSettings As New TYmkSettings

        If (rdr.Connected) Then

            If (rdr.GetYmkSettings(rSettings)) Then

                txtYemekhaneUygulamaTipi.SelectedIndex = rSettings.AppType
                txtYemekhaneKartSektor.Value = rSettings.YmkSectorNo
                txtYemekhaneSeciliFiyatListesi.Value = rSettings.CurrPriceList
                txtYemekhaneIstasyon.Value = rSettings.YmkSectorNo
                txtYemekhaneYenidenKartOkumaSayi.Value = rSettings.ReReadCardCount
                txtYemekhaneYenidenOkumaFiyatListesi.Value = rSettings.ReReadPriceGroup
                txtYemekhaneYenidenOkumaZamanAralik.Value = rSettings.ReReadTimeOut
                AddLog("Yemek listedi getirildi.")

            Else
                AddLog("Yemekhane ayarları getirilemedi.")
            End If

        Else
            AddLog("Cihaz Bağlantısı Yok.")
        End If




    End Sub

    Private Sub btnYemekhaneAyariGonder_Click(sender As Object, e As EventArgs) Handles btnYemekhaneAyariGonder.Click


        If rdr.Connected Then

            Dim Settings As New TYmkSettings()

            Settings.AppType = txtYemekhaneUygulamaTipi.SelectedIndex
            Settings.CurrPriceList = txtYemekhaneSeciliFiyatListesi.Value
            Settings.YmkSectorNo = txtYemekhaneKartSektor.Value
            Settings.PlantNo = txtYemekhaneIstasyon.Value
            Settings.ReReadCardCount = txtYemekhaneYenidenKartOkumaSayi.Value
            Settings.ReReadPriceGroup = txtYemekhaneYenidenKartOkumaSayi.Value
            Settings.ReReadTimeOut = txtYemekhaneYenidenOkumaZamanAralik.Value

            If (rdr.SetYmkSettings(Settings)) Then
                AddLog("Yemek listesi gönderildi.")
            Else
                AddLog("Yemek listesi gönderilemedi")
            End If

        Else
            AddLog("Cihazla bağlantı yok")

        End If

            

    End Sub


    Private Sub btnYemekOgunTablosu_Click(sender As Object, e As EventArgs) Handles btnYemekOgunTablosu.Click
        frmYemekOgunTablosu.ShowDialog()
    End Sub

    Private Sub btnYemekHakTablosu_Click(sender As Object, e As EventArgs) Handles btnYemekHakTablosu.Click
        frmYemekhakTablosu.ShowDialog()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click


        If rdr.Connected Then

            Dim rSettings As TDeviceTCPSettings

            If rdr.GetDeviceTCPSettings(rSettings) = True Then

                Select Case rSettings.ProtocolType
                    Case TProtocolType.PR0
                        edtHaberlesmeAyarlariProtokol.SelectedIndex = 0
                    Case TProtocolType.PR1
                        edtHaberlesmeAyarlariProtokol.SelectedIndex = 1
                    Case TProtocolType.PR2
                        edtHaberlesmeAyarlariProtokol.SelectedIndex = 2
                    Case TProtocolType.PR3
                        edtHaberlesmeAyarlariProtokol.SelectedIndex = 3
                End Select

                edtHaberlesmeIpAdresi.Text = rSettings.IPAdress
                edtHaberlesmeAltAgMaskesi.Text = rSettings.NetMask
                edtHaberlesmeAyarlariVarsayilanAgGecidi.Text = rSettings.DefGetway
                edtHaberlesmeBirinciDnsSunucu.Text = rSettings.PriDNS
                edtHaberlesmeIkinciDnsSunucu.Text = rSettings.SecDNS
                edtHaberlesmeAyarlariPortNumarasi.Value = rSettings.Port
                edtHaberlesmeAyarlariServerIpAdress.Text = rSettings.RemIpAdress

                If rSettings.ConnectOnlyRemIpAdress = True Then
                    chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = True
                Else
                    chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = False
                End If


                If rSettings.DHCP = True Then
                    chkHaberlesmeAyarlariDHCPAktif.Checked = True
                Else
                    chkHaberlesmeAyarlariDHCPAktif.Checked = False
                End If

                txtServerEchoZamanAsimi.Value = rSettings.ServerEchoTimeOut

                AddLog("haberleşme ayarları getirildi.")


            Else
                AddLog("Cihaz gelen ayarları getirilemedi.")

            End If



        Else
            AddLog("Cihazla bağlantı yok")

        End If





    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click

        Dim rSettings As TTCPSettings = New TTCPSettings()

        If rdr.Connected Then



            Select Case edtHaberlesmeAyarlariProtokol.SelectedIndex

                Case 0 : rSettings.ProtocolType = TProtocolType.PR0
                Case 1 : rSettings.ProtocolType = TProtocolType.PR1
                Case 2 : rSettings.ProtocolType = TProtocolType.PR2
                Case 3 : rSettings.ProtocolType = TProtocolType.PR3

            End Select


            rSettings.IPAdress = edtHaberlesmeIpAdresi.Text
            rSettings.NetMask = edtHaberlesmeAltAgMaskesi.Text
            rSettings.DefGetway = edtHaberlesmeAyarlariVarsayilanAgGecidi.Text
            rSettings.PriDNS = edtHaberlesmeBirinciDnsSunucu.Text
            rSettings.SecDNS = edtHaberlesmeIkinciDnsSunucu.Text
            rSettings.Port = Convert.ToUInt32(edtHaberlesmeAyarlariPortNumarasi.Value)
            rSettings.RemIpAdress = edtHaberlesmeAyarlariServerIpAdress.Text


            If chkHaberlesmeAyarlariSadeceServerIleHaberles.Checked = True Then
                rSettings.ConnectOnlyRemIpAdress = True
            Else
                rSettings.ConnectOnlyRemIpAdress = False
            End If


            If chkHaberlesmeAyarlariDHCPAktif.Checked = True Then
                rSettings.DHCP = True
            Else
                rSettings.DHCP = False
            End If



            If rdr.SetDeviceTCPSettings(rSettings) = True Then
                AddLog("TCP ayarları cihaza gönderildi.")
            Else
                AddLog("TCP ayarları cihaza gönderilemedi.")
            End If




        Else
            AddLog("Cihazla bağlantı yok")
        End If


    End Sub


    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click

        Dim rSettings As TUDPSettings

        If rdr.Connected Then


            Try
                If rdr.GetDeviceUDPSettings(rSettings) = True Then

                    edtUDPayarlariIpAdresi.Text = rSettings.RemUDPAdress
                    edtUDPayarlariPortNumarasi.Value = rSettings.UDPPort

                    If rSettings.UDPIsActive = True Then
                        chkUDPayarlariUDPAktif.Checked = True
                    Else
                        chkUDPayarlariUDPAktif.Checked = False
                    End If


                    If rSettings.UDPLogIsActive = True Then
                        chkUDPayarlariUDPLogAktif.Checked = True
                    Else
                        chkUDPayarlariUDPLogAktif.Checked = False
                    End If


                Else
                    AddLog("Haberleşme ayarları getirilemedi.")
                End If

            Catch ex As Exception
                AddLog("Haberleşme ayarları getirilemedi.")
            End Try


        Else

            AddLog("Cihazla bağlantı yok")
        End If


    End Sub


    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click

        Dim rSettings As TUDPSettings = New TUDPSettings()

        If rdr.Connected Then

            rSettings.RemUDPAdress = edtUDPayarlariIpAdresi.Text
            rSettings.UDPPort = Convert.ToUInt32(edtUDPayarlariPortNumarasi.Value)

            If chkUDPayarlariUDPAktif.Checked = True Then
                rSettings.UDPIsActive = True
            Else
                rSettings.UDPIsActive = False
            End If


            If chkUDPayarlariUDPLogAktif.Checked = True Then
                rSettings.UDPLogIsActive = True
            Else
                rSettings.UDPLogIsActive = False
            End If

            If rdr.SetDeviceUDPSettings(rSettings) = True Then
                AddLog("Udp ayarları gönderildi.")
            Else
                AddLog("udp ayarları gönderilemedi.")
            End If



        Else
            AddLog("Cihazla bağlantı yok")

        End If



    End Sub



    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click

        Dim rSettings As TClientTCPSettings = New TClientTCPSettings()

        If rdr.Connected Then

            If rdr.GetDeviceClientTCPSettings(rSettings) = True Then
                edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Text = rSettings.IPAdress
                edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Value = Convert.ToUInt32(rSettings.Port)
                AddLog("TCP client ayarları getirildi.")
            Else
                AddLog("TCP IP ayarları getirilemedi.")
            End If

        Else
            AddLog("Cihazla bağlantı yok")
        End If

    End Sub


    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click

        Dim rSettings As TClientTCPSettings = New TClientTCPSettings()

        If rdr.Connected Then

            rSettings.IPAdress = edtHaberlesmeAyarlariTCPclientAyarlariIpAdresi.Text
            rSettings.Port = Convert.ToUInt32(edtHaberlesmeAyarlariTCPclientAyarlariPortNumarasi.Value)

            If rdr.SetDeviceClientTCPSettings(rSettings) = True Then
                AddLog("TCP IP ayarları gönderildi.")
            Else
                AddLog("TCP IP ayarları gönderilemedi.")
            End If


        Else
            AddLog("Cihazla bağlantı yok")
        End If


    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click



    End Sub

    Private Sub btnMacAdresiGetir_Click(sender As Object, e As EventArgs) Handles btnMacAdresiGetir.Click


        Dim strMACAddress As String

        If rdr.Connected Then

            strMACAddress = rdr.GetMACAddress()

            If strMACAddress = "" Or strMACAddress = vbNull Then
                AddLog("Cihaz mac adresi getirilemedi.")
            Else
                txtMacAdresi.Text = strMACAddress
                AddLog("Cihaz mac adresi getirildi.")
            End If

        Else
            AddLog("Cihazla bağlantı yok")
        End If



    End Sub

    Private Sub button43_Click(sender As Object, e As EventArgs) Handles button43.Click


        Dim Sifre As String = ""
        If rdr.Connected = True Then
            Sifre = rdr.GetWebPassword()
        Else
            AddLog("Cihazla bağlantı sağlanamadı.")
            If (Sifre <> "*") Then
                AddLog("Web arayüz şifresi getirildi")
                txtWebAraYuzuSifresi.Text = Sifre
            Else
                AddLog("Web arayüz şifresi getirilemedi")
            End If

        End If


    End Sub


    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click


        Dim isSet As Boolean = False

        If (rdr.Connected = True) Then
            isSet = rdr.SetWebPassword(txtWebAraYuzuSifresi.Text)

            If (isSet = True) Then
                MessageBox.Show("Web arayüz şifresi değiştirildi.")
            Else
                MessageBox.Show("Web arayüz şifresi değiştirilemedi.")
            End If

        Else
            AddLog("Cihazla bağlantı sağlanamadı.")
        End If


    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click


        Dim KeyList As TMfrKeyListStr = New TMfrKeyListStr()

        If (rdr.Connected = True) Then

            If rdr.GetMfrKeyList(KeyList) = True Then
                groupBox23.Controls.Clear()

                For i As Integer = 0 To 15 Step 1

                    Dim ntKeyA As TextBox = New TextBox()
                    ntKeyA.Left = 10
                    ntKeyA.Name = "keyA" + i.ToString()

                    ntKeyA.Text = KeyList.Sector(i).KeyA.ToString()
                    ntKeyA.Top = groupBox23.Top + i * 25

                    Dim ntKeyB As TextBox = New TextBox()
                    ntKeyB.Left = ntKeyA.Width + 30
                    ntKeyB.Name = "keyB" + i.ToString()

                    If i = 0 Then
                        ntKeyA.Top = 30
                        ntKeyB.Top = 30
                    End If

                    ntKeyB.Text = KeyList.Sector(i).KeyB.ToString()
                    ntKeyB.Top = groupBox23.Top + i * 25

                    groupBox23.Controls.Add(ntKeyA)
                    groupBox23.Controls.Add(ntKeyB)


                Next



            End If

        Else
            AddLog("Cihazla bağlantı sağlanamadı.")
        End If





    End Sub

    Const regExChar As String = "0123456789ABCDEF"

    Function invalidCharRegEx(ByVal incomingString As String) As Boolean


        Dim turner As Boolean = False
        Dim chr As String

        For i As Integer = 0 To incomingString.Length Step 1
            chr = incomingString.Substring(i, 1)

            If regExChar.IndexOf(chr) = -1 Then
                turner = True
            End If
        Next

        Return turner

    End Function



    Sub writeKeyList()
        Dim KeyList As TMfrKeyListStr = New TMfrKeyListStr()

        If rdr.Connected Then

            For i As Integer = 0 To 16 Step 1
                Dim tbxA As TextBox = groupBox23.Controls.Find("KeyA" + i.ToString(), False).FirstOrDefault()
                Dim tbxB As TextBox = groupBox23.Controls.Find("KeyB" + i.ToString(), False).FirstOrDefault()
                KeyList.Sector(i).KeyA = tbxA.Text
                KeyList.Sector(i).KeyB = tbxB.Text
            Next

            If rdr.SetMfrKeyList(KeyList) Then
                AddLog("Key listesi başarıyla gönderildi.")
            Else
                AddLog("Key listesi gönderilemedi")
            End If

        Else
            AddLog("Cihazla bağlantınız yok.")
        End If


    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click

        For Each item As TextBox In groupBox23.Controls


            If item Is CType(item, TextBox) Then

                If invalidCharRegEx(item.Text) Then
                    MessageBox.Show("Focuslanan alanda geçersiz karakterler var.")
                    item.Focus()
                    Exit For
                Else
                    writeKeyList()
                End If

            End If

        Next


    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click

        For Each item As TextBox In groupBox23.Controls
            If item Is CType(item, TextBox) Then
                item.Text = "FFFFFFFFFFFF"
            End If
        Next

    End Sub


    Private Sub btnHaberlesmeAyariGonder_Click(sender As Object, e As EventArgs) Handles btnHaberlesmeAyariGonder.Click


        Dim rSettings As TLcdScreen = New TLcdScreen()
        Dim onlineBlink As Boolean = False

        If (chkedtEkranMesajlariBlink.Checked = True) Then
            onlineBlink = True
        Else
            onlineBlink = False
        End If

        If rdr.Connected Then

            Try

                If (rdr.ReaderType = TReaderType.rdr26M) Then
                    If rdr.SetBeepRelayAndSecreenMessage(
                            ekranMesajiOnlieSatir1.Text,
                            ekranMesajiOnlieSatir2.Text,
                            Convert.ToUInt32(edtEkranMesajlariEkranSure.Value),
                            Convert.ToUInt32(edtEkranMesajlariRoleSuresi1.Value),
                            Convert.ToUInt32(edtEkranMesajlariBuzzerSuresi.Value),
                            onlineBlink) Then

                        AddLog("Bilgiler cihaza gönderildi.")
                    Else
                        AddLog("Bilgiler cihaza gönderilemedi.")

                    End If
                Else

                    If (rdr.SetBeepRelayAndSecreenMessage(
                           edtEkranMesajlariUstBaslikTipi.SelectedIndex,
                           edtEkranMesajlariAltBaslikTipi.SelectedIndex,
                           edtEkranMesajlariUstBaslik.Text,
                           ekranMesajiOnlieSatir1.Text,
                           ekranMesajiOnlieSatir2.Text,
                           ekranMesajiOnlieSatir3.Text,
                           ekranMesajiOnlieSatir4.Text,
                           ekranMesajiOnlieSatir5.Text,
                           edtEkranMesajlariAltBaslik.Text,
                           Convert.ToByte(ekranMesajiOnlieSatir1x.Value),
                           Convert.ToByte(ekranMesajiOnlieSatir1y.Value),
                           0,
                           Convert.ToByte(ekranMesajiOnlieSatir2x.Value),
                           Convert.ToByte(ekranMesajiOnlieSatir2y.Value),
                           0,
                           Convert.ToByte(ekranMesajiOnlieSatir3x.Value),
                           Convert.ToByte(ekranMesajiOnlieSatir3y.Value),
                           0,
                           Convert.ToByte(ekranMesajiOnlieSatir4x.Value),
                           Convert.ToByte(ekranMesajiOnlieSatir4y.Value),
                           0,
                           Convert.ToByte(ekranMesajiOnlieSatir5x.Value),
                           Convert.ToByte(ekranMesajiOnlieSatir5y.Value),
                           0,
                           Convert.ToByte(edtEkranMesajiSatirSayisi.Value),
                           Convert.ToByte(edtEkranMesajlariFontTipi.SelectedIndex),
                           Convert.ToByte(edtEkranMesajlariEkranSure.Value),
                           Convert.ToByte(edtEkranMesajlariRoleSuresi1.Value),
                           Convert.ToByte(edtEkranMesajlariRoleSuresi2.Value),
                           Convert.ToByte(edtEkranMesajlariBuzzerSuresi.Value),
                           onlineBlink
                           ) = True) Then
                        AddLog("Bilgiler cihaza gönderildi.")
                    Else
                        AddLog("Bilgiler cihaza gönderilemedi.")
                    End If


                End If


            Catch ex As Exception
                AddLog("Bilgiler cihaza gönderilemedi." & ex.Message)
            End Try


        Else
            AddLog("Cihazla bağlantınız yok.")
        End If



    End Sub

    Private Sub btnInputBoxMesajGonder_Click(sender As Object, e As EventArgs) Handles btnInputBoxMesajGonder.Click

        If (rdr.Connected = True) Then


            If (rdr.ReaderType = TReaderType.rdr26M) Then
                MessageBox.Show("63M için geçerlidir.")
            Else

                Dim isBlink As Boolean = False

                If (txtInputBoxMesajGonderIsBlink.Checked = True) Then
                    isBlink = True
                End If


                If (rdr.SetBeepRelayAndInboxMessage(txtInputBoxMesajGonderUstBaslikTipi.SelectedIndex, txtInputBoxMesajGonderBaslik.Text, txtInputBoxMesajGonderBirinciSatir.Text, txtInputBoxMesajGonderIkinciSatir.Text, Convert.ToByte(txtInputBoxMesajGonderBirinciSatirx.Value), Convert.ToByte(txtInputBoxMesajGonderBirinciSatirZ.Value), 0, Convert.ToByte(txtInputBoxMesajGonderIkinciSatirX.Value), Convert.ToByte(txtInputBoxMesajGonderIkinciSatirZ.Value), 0, Convert.ToByte(txtInputBoxMesajGonderEkranSure.Value), Convert.ToByte(txtInputBoxMesajGonderRoleSure1.Value), Convert.ToByte(txtInputBoxMesajGonderRoleSure2.Value), Convert.ToByte(txtInputBoxMesajGonderBuzzerSure1.Value), isBlink, Convert.ToByte(txtInputBoxMesajGonderKlavyeTipi.Value))) Then
                    AddLog("Bilgiler gönderildi.")
                Else
                    AddLog("Bilgiler gönderilemedi.")
                End If
            End If

        Else

            AddLog("Cihazla bağlantınız yok.")

        End If




    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim LcdScreenMsg As TLcdScreen = New TLcdScreen()

        Dim IsBlink As Boolean = False

        If (rdr.Connected = True) Then

            If (chkekranMesajiOfflineBlink.Checked = True) Then : IsBlink = True : Else : IsBlink = False : End If

            LcdScreenMsg.ID = Convert.ToUInt32(OffflineMsg(edtCihazMesajTipiOffline.SelectedIndex).MsgID)
            LcdScreenMsg.HeaderType = Convert.ToByte(edtCihazMesajUstBaslikTipiOffline.SelectedIndex)
            LcdScreenMsg.Caption = edtCihazMesajUstBaslikOffline.Text
            LcdScreenMsg.Line(0).Text = ekranMesajiOfflineSatir1.Text
            LcdScreenMsg.Line(1).Text = ekranMesajiOfflineSatir2.Text
            LcdScreenMsg.Line(2).Text = ekranMesajiOfflineSatir3.Text
            LcdScreenMsg.Line(3).Text = ekranMesajiOfflineSatir4.Text
            LcdScreenMsg.Line(4).Text = ekranMesajiOfflineSatir5.Text

            LcdScreenMsg.Line(0).X = Convert.ToByte(ekranMesajiOfflineSatir1x.Value)
            LcdScreenMsg.Line(1).X = Convert.ToByte(ekranMesajiOfflineSatir2x.Value)
            LcdScreenMsg.Line(2).X = Convert.ToByte(ekranMesajiOfflineSatir3x.Value)
            LcdScreenMsg.Line(3).X = Convert.ToByte(ekranMesajiOfflineSatir4x.Value)
            LcdScreenMsg.Line(4).X = Convert.ToByte(ekranMesajiOfflineSatir5x.Value)

            LcdScreenMsg.Line(0).Y = Convert.ToByte(ekranMesajiOfflineSatir1z.Value)
            LcdScreenMsg.Line(1).Y = Convert.ToByte(ekranMesajiOfflineSatir2z.Value)
            LcdScreenMsg.Line(2).Y = Convert.ToByte(ekranMesajiOfflineSatir3z.Value)
            LcdScreenMsg.Line(3).Y = Convert.ToByte(ekranMesajiOfflineSatir4z.Value)
            LcdScreenMsg.Line(4).Y = Convert.ToByte(ekranMesajiOfflineSatir5z.Value)

            LcdScreenMsg.FooterType = Convert.ToByte(ekranMesajiOfflinealtBaslikTipi.SelectedIndex)
            LcdScreenMsg.Footer = ekranMesajiOfflinealtBaslik.Text
            LcdScreenMsg.LineCount = Convert.ToByte(edtEkranMesajiSatirSayisiOffline.Value)
            LcdScreenMsg.FontType = Convert.ToByte(ekranMesajiOfflinealtBaslikFontTipi.SelectedIndex)
            LcdScreenMsg.ScreenDuration = Convert.ToUInt32(ekranMesajiOfflineEkranSuresi.Value)
            LcdScreenMsg.RL_Time1 = Convert.ToUInt32(ekranMesajiOfflineRoleSuresi1.Value)
            LcdScreenMsg.RL_Time2 = Convert.ToUInt32(ekranMesajiOfflineRoleSuresi2.Value)
            LcdScreenMsg.BZR_time = Convert.ToUInt32(ekranMesajiOfflineBuzzerSuresi.Value)
            LcdScreenMsg.IsBlink = IsBlink

            If (rdr.SetLCDMessages(LcdScreenMsg) = True) Then
                AddLog("Bilgiler başarıyla gönderildi.")
            Else
                AddLog("Bilgiler gönderilemedi")
            End If



        Else
            AddLog("Cihazla bağlantınız yok.")

        End If





    End Sub


    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click

        If (rdr.Connected = True) Then

            If (rdr.SetLCDMessagesFactoryDefault() = True) Then

                AddLog("Cihaz sıfırlandı.")
            Else
                AddLog("Cihaz ayarları sıfırlanamadı.")
            End If

        Else
            AddLog("Cihazla bağlantı yok.")
        End If


    End Sub

    Private Sub button18_Click(sender As Object, e As EventArgs) Handles button18.Click


        Dim rSettings As TAccessGeneralSettings = New TAccessGeneralSettings()


        If (rdr.Connected = True) Then


            If (rdr.GetAppGeneralSettings(rSettings) = True) Then

                edtGenelAyarlarGecisTipi.SelectedIndex = rSettings.AccessMode.AccessType
                edtGenelAyarlarSifreGecisTipi.SelectedIndex = rSettings.AccessMode.PasswordType
                edtUygulamaAyariGirisTipi.SelectedIndex = rSettings.InputSettings.InputType
                edtUygulamaayarlariGecisSuresi.Value = rSettings.InputSettings.InputDurationTimeout

                If (rSettings.TimeAccessConstraintEnabled = True) Then : edtGenelAyarlarZamanKisitTablosuEtkin.Checked = True
                Else : edtGenelAyarlarZamanKisitTablosuEtkin.Checked = False : End If



                AddLog("Uygulama genel bilgileri getirildi.")


            Else
                AddLog("Uygulama genel bilgileri getirilemedi.")

            End If


            Else
                AddLog("Cihazla bağlantı yok.")

            End If




    End Sub


    Private Sub button19_Click(sender As Object, e As EventArgs) Handles button19.Click

        Dim rSettings As TAccessGeneralSettings = New TAccessGeneralSettings()

        If (rdr.Connected = True) Then

            rSettings.AccessMode.AccessType = Convert.ToByte(edtGenelAyarlarGecisTipi.SelectedIndex)
            rSettings.AccessMode.PasswordType = Convert.ToByte(edtGenelAyarlarSifreGecisTipi.SelectedIndex)
            rSettings.InputSettings.InputDurationTimeout = Convert.ToByte(edtUygulamaayarlariGecisSuresi.Value)
            rSettings.InputSettings.InputType = Convert.ToByte(edtUygulamaAyariGirisTipi.SelectedIndex)

            If (edtGenelAyarlarZamanKisitTablosuEtkin.Checked = True) Then
                rSettings.TimeAccessConstraintEnabled = True
            Else : rSettings.TimeAccessConstraintEnabled = False : End If

            If (rdr.SetAppGeneralSettings(rSettings) = True) Then
                AddLog("Uygulama genel bilgileri cihaza gönderilid.")
            Else : AddLog("Uygulama bilgileri cihaza gönderilemedi.")
            End If




        Else
            AddLog("Cihazla bağlantı yok.")
        End If





    End Sub


    Private Sub button20_Click(sender As Object, e As EventArgs) Handles button20.Click
        frmPdksZamanKisitTablosu.ShowDialog()
    End Sub

    Private Sub button22_Click(sender As Object, e As EventArgs) Handles button22.Click


        Dim rSettings As TAPBSettings = New TAPBSettings()

        If (rdr.Connected = True) Then

            If (rdr.GetAntiPassbackSettings(rSettings) = True) Then

                edtUygulamaAyarlariAPBtipi.SelectedIndex = rSettings.APBType
                edtAntiPassBackArdisikGecisAraligi.Value = rSettings.SequentialTransitionTime
                edtUygulamaAyarlariGuvenlikBolgeNo.Value = rSettings.SecurityZone

                If (rSettings.ApbInOut = 0) Then
                    radioUygulamaAyarlariAntiPassBackGiris.Checked = True
                Else : radioUygulamaAyarlariAntiPassBackCikis.Checked = False : End If

                AddHandler edtUygulamaAyarlariAPBtipi.SelectedIndexChanged, AddressOf edtUygulamaAyarlariAPBtipi_SelectedIndexChanged
                AddLog("APB Ayarları getirildi.")

            Else
                AddLog("APB Ayarları getirilemedi.")

            End If


        Else
            AddLog("Cihazla bağlantı yok.")
        End If

    End Sub

    Private Sub button27_Click(sender As Object, e As EventArgs) Handles button27.Click

        Dim Settings As TOutOfServiceSettings = New TOutOfServiceSettings()

        If (rdr.Connected = True) Then

            If (rdr.GetOutOfServiceSettings(Settings) = True) Then

                chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Checked = Settings.Enabled
                chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Text = Settings.ScreenText1
                chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Text = Settings.ScreenText2

                Select Case Settings.OutType
                    Case 0
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Checked = True
                    Case 1
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Checked = True
                    Case 2
                        chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Checked = True
                End Select

                AddLog("Hizmet dışı ayarları getirildi")

            Else
                AddLog("Hizmet dışı ayarları getirilemedi")

            End If
        Else

            AddLog("Cihazla bağlantı yok.")
        End If


    End Sub

    Private Sub button26_Click(sender As Object, e As EventArgs) Handles button26.Click


        Dim Settings As TOutOfServiceSettings = New TOutOfServiceSettings()

        If (rdr.Connected = True) Then

            Settings.Enabled = chkOkuyucuHizmetDisiAyarlariHizmetDisiEtkin.Checked
            Settings.ScreenText1 = chkOkuyucuHizmetDisiAyarlariHizmet1Satir.Text
            Settings.ScreenText2 = chkOkuyucuHizmetDisiAyarlariHizmet2Satir.Text


            If (chkOkuyucuHizmetDisiAyarlariTransistorCikisiDegisiklikYok.Checked = True) Then
                Settings.OutType = 0
            ElseIf (chkOkuyucuHizmetDisiAyarlariTransistorCikisi1.Checked = True) Then
                Settings.OutType = 1
            ElseIf (chkOkuyucuHizmetDisiAyarlariTransistorCikisi2.Checked = True) Then
                Settings.OutType = 2
            End If


            If (rdr.SetOutOfServiceSettings(Settings) = True) Then
                AddLog("Uygulama genel bilgileri gönderildi.")
            Else : AddLog("Uygulama genel bilgileri gönderilemedi.")
            End If



        Else

            AddLog("Cihazla bağlantı yok.")

        End If




    End Sub

    Private Sub button25_Click(sender As Object, e As EventArgs) Handles button25.Click
        frmPdksHizmetDisiTablosu.ShowDialog()
    End Sub

    Private Sub edtUygulamaAyarlariAPBtipi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles edtUygulamaAyarlariAPBtipi.SelectedIndexChanged

        Select Case edtUygulamaAyarlariAPBtipi.SelectedIndex

            Case 0

                edtAntiPassBackArdisikGecisAraligi.Value = 0
                edtAntiPassBackArdisikGecisAraligi.Visible = False
                radioUygulamaAyarlariAntiPassBackGiris.Visible = False
                radioUygulamaAyarlariAntiPassBackCikis.Visible = False
                edtUygulamaAyarlariGuvenlikBolgeNo.Visible = False
                labelGuvenlikBolgeNo.Visible = False
                labeGecisAraligi.Visible = False

            Case 1

                labelGuvenlikBolgeNo.Visible = True
                edtUygulamaAyarlariGuvenlikBolgeNo.Visible = True
                radioUygulamaAyarlariAntiPassBackGiris.Visible = True
                radioUygulamaAyarlariAntiPassBackCikis.Visible = True
                labelGuvenlikBolgeNo.Visible = True
                labeGecisAraligi.Visible = False
                edtAntiPassBackArdisikGecisAraligi.Visible = False


            Case Else

                labelGuvenlikBolgeNo.Visible = True
                edtUygulamaAyarlariGuvenlikBolgeNo.Visible = True
                radioUygulamaAyarlariAntiPassBackGiris.Visible = True
                radioUygulamaAyarlariAntiPassBackCikis.Visible = True
                labelGuvenlikBolgeNo.Visible = True
                labeGecisAraligi.Visible = True
                edtAntiPassBackArdisikGecisAraligi.Visible = True


        End Select


    End Sub


    Private Sub button21_Click(sender As Object, e As EventArgs) Handles button21.Click


        Dim rSettings As TAPBSettings = New TAPBSettings()

        If (rdr.Connected = True) Then

            rSettings.APBType = Convert.ToByte(edtUygulamaAyarlariAPBtipi.SelectedIndex)
            rSettings.SequentialTransitionTime = Convert.ToByte(edtAntiPassBackArdisikGecisAraligi.Value)
            rSettings.SecurityZone = Convert.ToByte(edtUygulamaAyarlariGuvenlikBolgeNo.Value)

            If (radioUygulamaAyarlariAntiPassBackGiris.Checked = True) Then
                rSettings.ApbInOut = 0
            ElseIf (radioUygulamaAyarlariAntiPassBackCikis.Checked = True) Then
                rSettings.ApbInOut = 1
            End If

            If (rdr.SetAntiPassbackSettings(rSettings) = True) Then
                AddLog("APB Ayarları gönderildi.")
            Else : AddLog("APB Ayarları gönderilemeddi.")
            End If


        Else


        End If

    End Sub

    Private Sub button24_Click(sender As Object, e As EventArgs) Handles button24.Click

        Dim EksOtherSettings As TEksOtherSettings = New TEksOtherSettings()

        If (rdr.Connected = True) Then

            If (rdr.GetEksOtherSettings(EksOtherSettings) = True) Then
                digerEKSAyarlariKisiVerisi.Value = EksOtherSettings.PersDataCardSector
                digerEKSAyarlariEKSverisi.Value = EksOtherSettings.AccessDataCardSector
                AddLog("Eks Diğer Bilgileri getirildi")
            Else : AddLog("Eks Diğer Bilgileri getirilemedi")
            End If


        Else
            AddLog("Cihazla bağlantınız yok")
        End If



    End Sub


    Private Sub button23_Click(sender As Object, e As EventArgs) Handles button23.Click

        Dim EksOtherSettings As TEksOtherSettings = New TEksOtherSettings()


        If (rdr.Connected = True) Then


            EksOtherSettings.PersDataCardSector = Convert.ToByte(digerEKSAyarlariKisiVerisi.Value)
            EksOtherSettings.AccessDataCardSector = Convert.ToByte(digerEKSAyarlariEKSverisi.Value)

            If (rdr.SetEksOtherSettings(EksOtherSettings) = True) Then
                AddLog("Eks Diğer Bilgileri gönderildi.")
            Else
                AddLog("Eks Diğer Bilgileri gönderilemedi.")
            End If

        Else
            AddLog("Cihazla bağlantınız yok")

        End If

    End Sub

    Private Sub button30_Click(sender As Object, e As EventArgs) Handles button30.Click

        Dim Settings As TBellSettings = New TBellSettings()

        If (rdr.Connected = True) Then

            If (rdr.GetBellSettings(Settings) = True) Then

                If (Settings.Enabled = True) Then : chkZilCaldirmaEtkin.Checked = True : Else : chkZilCaldirmaEtkin.Checked = False : End If
                edtZilCaldirma1Satir.Text = Settings.ScreenText1
                edtZilCaldirma2Satir.Text = Settings.ScreenText2

                Select Case Settings.OutType
                    Case 1
                        chkZilCaldirmaTransistorCikisi1.Checked = True
                    Case 2
                        chkZilCaldirmaTransistorCikisi2.Checked = True
                End Select

                AddLog("Zil çaldırma bilgileri getirildi.")


            Else

                AddLog("Ayarlar getirilemedi")
            End If


        Else
            AddLog("Cihazla bağlantınız yok")
        End If




    End Sub

    Private Sub button29_Click(sender As Object, e As EventArgs) Handles button29.Click

        Dim Settings As TBellSettings = New TBellSettings()

        If (rdr.Connected = True) Then

            If (chkZilCaldirmaEtkin.Checked = True) Then : Settings.Enabled = True : Else : Settings.Enabled = False : End If
            Settings.ScreenText1 = edtZilCaldirma1Satir.Text
            Settings.ScreenText2 = edtZilCaldirma2Satir.Text

            If (chkZilCaldirmaTransistorCikisi1.Checked = True) Then : Settings.OutType = 1 : Else : Settings.OutType = 2 : End If
            If (rdr.SetBellSettings(Settings) = True) Then : AddLog("Zil çaldırma bilgileri gönderildi.") : Else : AddLog("Zil çaldırma bilgileri gönderilemedi.") : End If



        Else
            AddLog("Cihazla bağlantınız yok")
        End If

    End Sub

    Private Sub button17_Click(sender As Object, e As EventArgs) Handles button17.Click

        If (rdr.Connected = True) Then
            If (chkYenidenBaslat.Checked = True) Then
                rdr.SetAppFactoryDefault(True)
                rdr.DisConnect()
                Thread.Sleep(1000)
                rdr.Connect()
            Else
                AddLog("Cihaz fabrika ayarlarına dönülemedi.")
            End If

        Else
            AddLog("Cihaza bağlantı sağlanamadı.")

        End If


    End Sub



    Private Sub button28_Click(sender As Object, e As EventArgs) Handles button28.Click

        frmZilTablosu.ShowDialog()


    End Sub


    Private Sub btnReadRecs_Click(sender As Object, e As EventArgs) Handles btnReadRecs.Click


        If (rdr.Connected) Then

            Dim tempRecs As TAccessRecords = New TAccessRecords()
            Dim Start As UInteger = Convert.ToUInt32(edtStartRead.Value)
            Dim HowMany As UInteger = Convert.ToUInt32(edtHowManyRead.Value)

            If (rdr.ReadRecords(Start, HowMany, tempRecs)) Then

                Dim str As String = ""

                For i As Integer = 0 To tempRecs.Count Step 1

                    str = "i : " & i.ToString() + " CardID : " & tempRecs.raDeviceRecs(i).CardID.ToString() _
                            & " TimeDate : " + tempRecs.raDeviceRecs(i).TimeDate.ToString() _
                            & " DoorNo : " + tempRecs.raDeviceRecs(i).DoorNo.ToString() _
                            & " RecordType : " + tempRecs.raDeviceRecs(i).RecordType.ToString()
                    richTextBoxRecs.AppendText(str + "\u2028")

                Next

                AddLog("Veriler okundu.")

            Else
                MessageBox.Show("Bilgiler getirilemedi")
            End If



        Else
            MessageBox.Show("Cihazla bağlantınız yok")
        End If


    End Sub

    Private Sub btnTransferRecs_Click(sender As Object, e As EventArgs) Handles btnTransferRecs.Click

        If (rdr.Connected) Then

            Dim tmpRecs As TAccessRecords = New TAccessRecords()

            If (rdr.TransferRecords(tmpRecs)) Then

                Dim str As String = ""

                For i As Integer = 0 To tmpRecs.Count Step 1

                    str = "i : " & i.ToString() + " CardID : " & tmpRecs.raDeviceRecs(i).CardID.ToString() _
                            & " TimeDate : " & tmpRecs.raDeviceRecs(i).TimeDate.ToString() _
                            & " DoorNo : " & tmpRecs.raDeviceRecs(i).DoorNo.ToString() _
                            & " RecordType : " & tmpRecs.raDeviceRecs(i).RecordType.ToString()
                    richTextBoxRecs.AppendText(str + "\u2028")
                    AddLog("Veriler transfer edildi.")
                Next

                AddLog("Veriler transfer edilemedi!")

            Else
                MessageBox.Show("Bilgiler gönderilemedi")
            End If


        Else
            MessageBox.Show("Cihazla bağlantınız yok")
        End If


    End Sub

    Private Sub btnHgsGenelAyarlariGetir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsGenelAyarlariGonder_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsEkle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsSil_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsDegistir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsBul_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHgsGenelAyarlariGetir_Click_1(sender As Object, e As EventArgs) Handles btnHgsGenelAyarlariGetir.Click

        Dim rSettings As THGS_Settings = New THGS_Settings()

        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")

        Else

            If (rdr.Connected = True) Then

                If (rdr.GetHGSSettings(rSettings) = True) Then

                    txtHgsGenelAyarlarSeriPaketBoyutu.Value = rSettings.PaketBoyu
                    txtHgsGenelAyarlarKartBaslangici.Value = rSettings.CardBaslangic
                    txtHgsGenelAyarlarTagId.Value = rSettings.CardBoyu
                    txtHgsGenelAyarlarTransistorCikisi1.Value = rSettings.TrCikisSure1
                    txtHgsGenelAyarlarTransistorCikisi2.Value = rSettings.TrCikisSure2
                    txtHgsGenelAyarlarProgramModu.SelectedIndex = rSettings.ProgramMode - 1
                    txtHgsGenelAyarlarDiziArdisikKontrol1.Value = rSettings.DiziEklemeSure1
                    txtHgsGenelAyarlarDiziArdisikKontrol2.Value = rSettings.DiziEklemeSure2
                    If (rSettings.ZamanKisitEnb = True) Then
                        txtHgsGenelAyarlarZamanKisitEtkin.Checked = True
                    Else
                        txtHgsGenelAyarlarZamanKisitEtkin.Checked = False
                    End If
                    txtHgsGenelAyarlarAntenGuc1.Value = rSettings.AntenPower1
                    txtHgsGenelAyarlarAntenGuc2.Value = rSettings.AntenPower2
                    txtHgsGenelAyarlarAntenKtanima.Value = rSettings.AntenTanitim
                    txtHgsGenelAyarlarAracDaireSayisi.Value = rSettings.DefMaksimumArac
                    txtHgsGenelAyarlarArdisikGecisSuresi.Value = rSettings.DefAntiPassPack
                    txtHgsGenelAyarlarAppType.Value = rSettings.AppType

                    AddLog("Bilgiler getirildi.")
                Else
                    AddLog("Bilgiler getirilemedi.")
                End If
            Else
                AddLog("Cihazla bağlantı yok.")
            End If

        End If





    End Sub

    Private Sub btnHgsGenelAyarlariGonder_Click_1(sender As Object, e As EventArgs) Handles btnHgsGenelAyarlariGonder.Click


        Dim rSettings As THGS_Settings = New THGS_Settings()

        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else

            If (rdr.Connected = True) Then

                rSettings.PaketBoyu = Convert.ToByte(txtHgsGenelAyarlarSeriPaketBoyutu.Value)
                rSettings.CardBaslangic = Convert.ToByte(txtHgsGenelAyarlarKartBaslangici.Value)
                rSettings.CardBoyu = Convert.ToByte(txtHgsGenelAyarlarTagId.Value)
                rSettings.TrCikisSure1 = Convert.ToByte(txtHgsGenelAyarlarTransistorCikisi1.Value)
                rSettings.TrCikisSure2 = Convert.ToByte(txtHgsGenelAyarlarTransistorCikisi2.Value)
                rSettings.ProgramMode = Convert.ToByte((txtHgsGenelAyarlarProgramModu.SelectedIndex + 1))
                rSettings.DiziEklemeSure1 = Convert.ToByte(txtHgsGenelAyarlarDiziArdisikKontrol1.Value)
                rSettings.DiziEklemeSure2 = Convert.ToByte(txtHgsGenelAyarlarDiziArdisikKontrol2.Value)

                If (txtHgsGenelAyarlarZamanKisitEtkin.Checked = True) Then
                    rSettings.ZamanKisitEnb = True
                Else : rSettings.ZamanKisitEnb = False
                End If

                rSettings.AntenPower1 = Convert.ToByte(txtHgsGenelAyarlarAntenGuc1.Value)
                rSettings.AntenPower2 = Convert.ToByte(txtHgsGenelAyarlarAntenGuc2.Value)
                rSettings.AntenTanitim = Convert.ToByte(txtHgsGenelAyarlarAntenKtanima.Value)
                rSettings.DefMaksimumArac = Convert.ToByte(txtHgsGenelAyarlarAracDaireSayisi.Value)
                rSettings.DefAntiPassPack = Convert.ToByte(txtHgsGenelAyarlarArdisikGecisSuresi.Value)
                rSettings.AppType = Convert.ToByte(txtHgsGenelAyarlarAppType.Value)

                If (rdr.SetHGSSettings(rSettings) = True) Then
                    AddLog("Bilgiler gönderildi.")
                Else
                    AddLog("Bilgiler gönderilemedi.")
                End If


            Else
                MessageBox.Show("Cihazla bağlantı yok")
            End If


            End If




    End Sub

    Private Sub button38_Click(sender As Object, e As EventArgs) Handles button38.Click


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else
            If (rdr.Connected = True) Then
                rdr.ClearWhitelist()
                rdr.DisConnect()
                Thread.Sleep(1000)
                rdr.Connect()
            Else
                AddLog("Cihazla bağlantı sağlanamadı.")
            End If
        End If

    End Sub


    Private Sub btnHgsEkle_Click_1(sender As Object, e As EventArgs) Handles btnHgsEkle.Click


        Dim iErr, InxNm As Integer
        Dim CardID As String
        Dim Devam As Boolean
        Dim Arac As THGSArac = New THGSArac()


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else

            CardID = txtHgsGenelAyarlarKartId.Text
            Devam = True

            If Not Devam Then
                MessageBox.Show("Uygun tag id girilmemiş.")
            Else

                Arac.CardID = CardID
                Arac.Name = txtHgsGenelAyarlarKartHGSAdi.Text
                Arac.TimeAccessMask(0) = Convert.ToByte(txtHgsGenelAyarlarPazartesi.Value)
                Arac.TimeAccessMask(1) = Convert.ToByte(txtHgsGenelAyarlarSali.Value)
                Arac.TimeAccessMask(2) = Convert.ToByte(txtHgsGenelAyarlarCarsamb.Value)
                Arac.TimeAccessMask(3) = Convert.ToByte(txtHgsGenelAyarlarPersembe.Value)
                Arac.TimeAccessMask(4) = Convert.ToByte(txtHgsGenelAyarlarCuma.Value)
                Arac.TimeAccessMask(5) = Convert.ToByte(txtHgsGenelAyarlarCumartesi.Value)
                Arac.TimeAccessMask(6) = Convert.ToByte(txtHgsGenelAyarlarPazar.Value)
                Arac.Daire = Convert.ToUInt32(txtHgsGenelAyarlarDaire.Value)
                Arac.AracNo = Convert.ToByte(txtHgsGenelAyarlarArac.Value)
                Arac.EndDate = Convert.ToDateTime(txtHgsGenelAyarlarKartinSonKullanmaTarihi.Text)

                If (txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = True) Then
                    Arac.AccessDevice = True
                Else : Arac.AccessDevice = False
                End If

                If (txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = True) Then
                    Arac.APBEnabled = True
                Else
                    Arac.APBEnabled = False
                End If


                If (txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = True) Then
                    Arac.ATCEnabled = True
                Else
                    Arac.ATCEnabled = False
                End If

                iErr = rdr.AddHGSWhitelist(Arac, InxNm)


                Select Case iErr

                    Case 0
                        AddLog("Araç eklendi.")
                        labelHgsTanimliKisiSayisi.Text = Convert.ToString(InxNm)
                    Case 26
                        AddLog("Bu Daire- Araç daha önce tanımlanmış.")
                    Case 24
                        AddLog("Tag ID var Daire yok.")
                    Case 25
                        AddLog("Daire var Tag ID yok.")
                    Case 52
                        AddLog("sonra")
                    Case Else
                        AddLog("Araç eklenemedi.")

                End Select


            End If

        End If



    End Sub

    Private Sub btnHgsSil_Click_1(sender As Object, e As EventArgs) Handles btnHgsSil.Click

        Dim CardID As String
        Dim InxNm As Integer

        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else

            If (rdr.Connected = True) Then
                CardID = txtHgsGenelAyarlarKartId.Text
                If (rdr.DeleteHGSWhitelistWithCardID(CardID, InxNm) = 0) Then
                    AddLog("Araç kaydı silindi.")
                    lblHGSIndexNo.Text = Convert.ToString(InxNm)
                Else
                    AddLog("Araç silinemedi.")
                End If
            End If
        End If



    End Sub

    Private Sub btnHgsDegistir_Click_1(sender As Object, e As EventArgs) Handles btnHgsDegistir.Click

        Dim Arac As THGSArac = New THGSArac()
        Dim iErr, i, cnt, InxNm As Integer
        Dim CardID As String = ""


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else

            lblIndexNo.Text = "-1"

            CardID = txtHgsGenelAyarlarKartId.Text


            Arac.CardID = CardID
            Arac.Name = txtHgsGenelAyarlarKartHGSAdi.Text
            Arac.TimeAccessMask(0) = Convert.ToByte(txtHgsGenelAyarlarPazartesi.Value)
            Arac.TimeAccessMask(1) = Convert.ToByte(txtHgsGenelAyarlarSali.Value)
            Arac.TimeAccessMask(2) = Convert.ToByte(txtHgsGenelAyarlarCarsamb.Value)
            Arac.TimeAccessMask(3) = Convert.ToByte(txtHgsGenelAyarlarPersembe.Value)
            Arac.TimeAccessMask(4) = Convert.ToByte(txtHgsGenelAyarlarCuma.Value)
            Arac.TimeAccessMask(5) = Convert.ToByte(txtHgsGenelAyarlarCumartesi.Value)
            Arac.TimeAccessMask(6) = Convert.ToByte(txtHgsGenelAyarlarPazar.Value)
            Arac.Daire = Convert.ToByte(txtHgsGenelAyarlarDaire.Value)
            Arac.AracNo = Convert.ToByte(txtHgsGenelAyarlarArac.Value)
            Arac.EndDate = Convert.ToDateTime(txtHgsGenelAyarlarKartinSonKullanmaTarihi.Text)


            If (txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = True) Then
                Arac.AccessDevice = True
            Else
                Arac.AccessDevice = False
            End If

            If (txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = True) Then
                Arac.APBEnabled = True
            Else
                Arac.APBEnabled = False
            End If


            If (txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = True) Then
                Arac.ATCEnabled = True
            Else
                Arac.ATCEnabled = True
            End If

            iErr = rdr.EditHGSWhitelistWithCardID(Arac, InxNm)

            Select Case iErr
                Case 0
                    AddLog("Araç değiştirildi.")
                    lblHGSIndexNo.Text = Convert.ToString(InxNm)
                Case 20
                    AddLog("Araç kapasitesi aşıldı.")
            End Select




        End If


    End Sub


    Private Sub btnHgsBul_Click_1(sender As Object, e As EventArgs) Handles btnHgsBul.Click


        Dim Arac As THGSArac
        Dim iErr, i, cnt, InxNm As Integer
        Dim CardID As String


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")
        Else


            If (rdr.Connected = True) Then

                CardID = txtHgsGenelAyarlarKartId.Text
                iErr = rdr.GetHGSWhitelistWithCardID(CardID, Arac, InxNm)

                If iErr = 0 Then

                    txtHgsGenelAyarlarKartId.Text = CardID
                    txtHgsGenelAyarlarKartHGSAdi.Text = Arac.Name
                    txtHgsGenelAyarlarPazartesi.Value = Arac.TimeAccessMask(0)
                    txtHgsGenelAyarlarSali.Value = Arac.TimeAccessMask(1)
                    txtHgsGenelAyarlarCarsamb.Value = Arac.TimeAccessMask(2)
                    txtHgsGenelAyarlarPersembe.Value = Arac.TimeAccessMask(3)
                    txtHgsGenelAyarlarCuma.Value = Arac.TimeAccessMask(4)
                    txtHgsGenelAyarlarCumartesi.Value = Arac.TimeAccessMask(5)
                    txtHgsGenelAyarlarPazar.Value = Arac.TimeAccessMask(6)
                    txtHgsGenelAyarlarDaire.Value = Arac.Daire
                    txtHgsGenelAyarlarArac.Value = Arac.AracNo
                    txtHgsGenelAyarlarKartinSonKullanmaTarihi.Value = Arac.EndDate

                    If (Arac.AccessDevice = True) Then
                        txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = True
                    Else
                        txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = False
                    End If


                    If (Arac.APBEnabled = True) Then
                        txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = True
                    Else
                        txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = False
                    End If


                    If (Arac.ATCEnabled = True) Then
                        txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = True
                    Else
                        txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = False
                        lblHGSIndexNo.Text = Convert.ToString(InxNm)
                    End If
                    AddLog("araç bilgileri getirildi")
                Else
                    AddLog("araç kaydı buluanamadı")
                End If


            Else
                MessageBox.Show("Cihazla bağlantı yok")
            End If


                End If


    End Sub

    Private Sub btnDaireSil_Click(sender As Object, e As EventArgs) Handles btnDaireSil.Click

        Dim InxNm As Integer


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.")
        Else

            If (rdr.Connected = True) Then

                If (txtHgsGenelAyarlarDaire.Value >= 0 And txtHgsGenelAyarlarArac.Value >= 0) Then

                    If (rdr.DeleteHGSWhitelistWithDaireArac(Convert.ToUInt32(txtHgsGenelAyarlarDaire.Value), Convert.ToByte(txtHgsGenelAyarlarArac.Value), InxNm) = 0) Then

                        AddLog("Araç silindi")

                    Else : AddLog("Araç silinemedi.")
                    End If



                Else
                    AddLog("Cihazla bağlantı yok.")

                End If

                End If
            End If



    End Sub

    Private Sub btnDaireBul_Click(sender As Object, e As EventArgs) Handles btnDaireBul.Click

        Dim Arac As THGSArac
        Dim iErr, i, cnt, InxNm As Integer
        Dim CardID As String


        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Bu uygulama sadece çalışma modu HGS alanında çalışır.")
        Else
            If (rdr.Connected = True) Then

                If (txtHgsGenelAyarlarDaire.Value >= 0 And txtHgsGenelAyarlarArac.Value >= 0) Then

                    iErr = rdr.GetHGSWhitelistWithDaireArac(Convert.ToUInt32(txtHgsGenelAyarlarDaire.Value), Convert.ToByte(txtHgsGenelAyarlarArac.Value), Arac, InxNm)

                    If (iErr = 0) Then

                        txtHgsGenelAyarlarKartId.Text = Arac.CardID
                        txtHgsGenelAyarlarKartHGSAdi.Text = Arac.Name.Trim()
                        txtHgsGenelAyarlarPazartesi.Value = Arac.TimeAccessMask(0)
                        txtHgsGenelAyarlarSali.Value = Arac.TimeAccessMask(1)
                        txtHgsGenelAyarlarCarsamb.Value = Arac.TimeAccessMask(2)
                        txtHgsGenelAyarlarPersembe.Value = Arac.TimeAccessMask(3)
                        txtHgsGenelAyarlarCuma.Value = Arac.TimeAccessMask(4)
                        txtHgsGenelAyarlarCumartesi.Value = Arac.TimeAccessMask(5)
                        txtHgsGenelAyarlarPazar.Value = Arac.TimeAccessMask(6)
                        txtHgsGenelAyarlarDaireHak.Value = Arac.Daire
                        txtHgsGenelAyarlarArac.Value = Arac.AracNo
                        txtHgsGenelAyarlarKartinSonKullanmaTarihi.Value = Arac.EndDate

                        If (Arac.AccessDevice = True) Then
                            txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = True
                        Else : txtHgsGenelAyarlarKisiCihazdaAktifMi.Checked = False
                        End If

                        If (Arac.APBEnabled = True) Then
                            txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = True
                        Else : txtHgsGenelAyarlarAntiPassBackKontroluOlsunMu.Checked = False
                        End If

                        If (Arac.ATCEnabled = True) Then
                            txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = True
                        Else : txtHgsGenelAyarlarKisitKontroluOlsunMu.Checked = False
                        End If

                        lblHGSIndexNo.Text = Convert.ToString(InxNm)
                        AddLog("Araç getirildi.")



                    End If

                End If


            Else
                MessageBox.Show("Cihazla bağlantı yok")
            End If


        End If




    End Sub


    Private Sub btnDaireAracHakkiGetir_Click(sender As Object, e As EventArgs) Handles btnDaireAracHakkiGetir.Click

        Dim hak As Byte = 0
        If (txtUygulamaTipi.Text <> "HGS") Then
            MessageBox.Show("Sadece HGS fw ile çalışır.")


        Else

            If (rdr.Connected = True) Then

                If (rdr.GetHGSDaireParkHak(Convert.ToUInt32(txtDaireAracHakkiOtoparkHakkiDaire.Value), hak) = True) Then
                    txtDaireAracHakkiOtoparkHakki.Value = hak
                    AddLog("Hak bilgileri getirildi.")
                Else
                    AddLog("Bilgiler getirilemedi.")
                End If
            Else
                AddLog("Cihazla bağlantı yok")

            End If

        End If


    End Sub

    Private Sub btnDaireAracHakkiGonder_Click(sender As Object, e As EventArgs) Handles btnDaireAracHakkiGonder.Click


        If (txtUygulamaTipi.Text <> "HGS") Then

            MessageBox.Show("Sadece HGS fw ile çalışır.")


        Else

            If (rdr.Connected = True) Then

                If (rdr.SetHGSDaireParkHak(Convert.ToByte(txtDaireAracHakkiOtoparkHakkiDaire.Value), Convert.ToByte(txtDaireAracHakkiOtoparkHakki.Value)) = True) Then
                    AddLog("Bilgiler gönderildi.")
                Else
                    AddLog("Bilgiler gönderilemedi.")
                End If

            Else
                AddLog("cihazla bağlantı yok")

            End If

        End If

    End Sub
End Class
