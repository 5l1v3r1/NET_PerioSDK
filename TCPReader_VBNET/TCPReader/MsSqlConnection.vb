Imports System.Data.SqlClient
Imports System.Configuration





Public Class vtBaglanti


    Private dbUserName As String
    Private dbUserPassword As String
    Private dbIp As String
    Private DbDataBaseName As String

    Public komut As SqlCommand = New SqlCommand()
    Public baglantimiz As SqlConnection
    Public reader As SqlDataReader
    Public adapter As SqlDataAdapter = New SqlDataAdapter()


    Public Sub vtBaglanti(ByRef baglandi As Boolean)

        Dim result As Boolean

        result = baglan()

        baglandi = result

    End Sub



    Public Function baglan() As Boolean

        Dim result As Boolean = False
        Me.DbDataBaseName = "dbKutuphane"
        Me.dbIp = "TUNCGULEC"
        Me.dbUserName = ""
        Me.dbUserPassword = ""

        baglantimiz = New SqlConnection("Data Source=" & dbIp & " ;Initial Catalog=" & DbDataBaseName & "; Integrated Security=SSPI;timeout=10000")

        If baglantimiz.State = ConnectionState.Broken Or baglantimiz.State = ConnectionState.Closed Then

            Try
                baglantimiz.Open()
                result = True
            Catch ex As Exception
                result = True
            End Try


        End If

        Return result

    End Function



End Class
