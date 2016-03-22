


Public Module uye


    Public Structure tUye

        Public uyeAdi As String
        Public uyeKartId As String

    End Structure


    Public Class uyeIslemleri

        Private Property baglandimi As Boolean = False
        Shared vt As vtBaglanti = New vtBaglanti()

        Public Sub uyeIslemleri()

            vt = New vtBaglanti()
            vt.vtBaglanti(baglandimi)

        End Sub


        Public Sub uyeEkle(ByVal uyeBilgisi As tUye)

            If baglandimi Then
                vt.komut.Connection = vt.baglantimiz
                vt.komut.CommandType = CommandType.StoredProcedure
                vt.komut.CommandText = "sp_uyeEkle"
                vt.komut.Parameters.Clear()
                vt.komut.Parameters.AddWithValue("", "")
                vt.komut.ExecuteNonQuery()
                vt.komut.Dispose()
            End If

        End Sub


        Public Function kartVarmi(ByVal uyeBilgisi As tUye, ByRef mesaj As String) As Boolean

            Dim result As Boolean = False
            Dim _mesaj As String = ""


            If uyeBilgisi.uyeKartId <> "" Then

                vt.baglan()
                vt.komut.Connection = vt.baglantimiz
                vt.komut.Parameters.Clear()
                vt.komut.CommandType = CommandType.Text
                vt.komut.CommandText = "select * from tblUye where kartId='" & uyeBilgisi.uyeKartId & "'"

                vt.reader = vt.komut.ExecuteReader()

                vt.reader.Read()

                If vt.reader.HasRows Then

                    If vt.reader("yasakli") <> vbNull Then

                        If vt.reader("yasakli") = True Then
                            _mesaj = "Kullanıcı yasaklı"
                        Else
                            _mesaj = "Üye Bulundu"
                        End If

                    End If


                Else
                    _mesaj = "Üye Bulunamadı."
                End If


                mesaj = _mesaj

            Else
                _mesaj = "Kart girilmemiş."

            End If

            Return result
        End Function



    End Class



End Module

