Imports System.Data.SqlClient
Module VeriTabaniBağlantiModül
    Public Function SQLBAGLANTİCUMLESİ() As String
        Dim Sonuc As String = Nothing
        Dim CumleOlusturucu As New SqlConnectionStringBuilder
        CumleOlusturucu.DataSource = "MEHMETPC\SQL"
        CumleOlusturucu.InitialCatalog = "FLO"
        CumleOlusturucu.IntegratedSecurity = True
        Sonuc = CumleOlusturucu.ConnectionString
        Return Sonuc
    End Function
End Module
