Imports System.Data.SqlClient
Public Class KesilenTaxFreeForm
    Private TaxFree As New SqlDataAdapter
    Private SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)

    Private Sub KesilenTaxFreeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KesilenTaxFree()
    End Sub


    Private Sub KesilenTaxFree()

        Dim Sorgu As String = "SELECT * FROM TaxFree"
        TaxFree = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim SorguCumlesiOlusturucu As New SqlCommandBuilder(TaxFree)
        Try
            SQLBaglanti.Open() 'Bağlantı açıldı
            TaxFree.Fill(TFDataSet, "TaxFree") 'Select sonucu dönen kayıtları DataSet içerisine aktardık
            'Insert, Delete ve Update cümlelerini oluştur
            SorguCumlesiOlusturucu.GetInsertCommand()
            SorguCumlesiOlusturucu.GetUpdateCommand()
            SorguCumlesiOlusturucu.GetDeleteCommand()
            'Kayıtlar üzerinde gezinme, ekleme ve form nesneleri ile bağlama için kullanacağımız nesneye atama yap
            TFBSource.DataSource = TFDataSet
            TFBSource.DataMember = "TaxFree"
            NesneleriBagla()
            TFBSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantı kapatıldı
        End Try
    End Sub
    Private Sub NesneleriBagla()
        TextBox1.DataBindings.Add("Text", TFBSource, "İslemiYapanKasiyer")
        TextBox2.DataBindings.Add("Text", TFBSource, "İşlemTutarı")
        DateTimePicker1.DataBindings.Add("Value", TFBSource, "İşlemTarihi", True)
        TextBox3.DataBindings.Add("Text", TFBSource, "MüsteriTelefonNo")
        TextBox4.DataBindings.Add("Text", TFBSource, "PasaportNo")
        TextBox5.DataBindings.Add("Text", TFBSource, "FişNo")
        ComboBox1.DataBindings.Add("Text", TFBSource, "ÖdemeTürü")

        DataGridView1.DataSource = TFBSource
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim ödemetipi As String = "select * from TaxFree where ÖdemeTürü like @tur"
        TaxFree = New SqlDataAdapter(ödemetipi, SQLBaglanti)
        TaxFree.SelectCommand.Parameters.Add("@tur", SqlDbType.VarChar).Value = "%" & TextBox6.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(TaxFree)
        Try
            SQLBaglanti.Open()
            If TFDataSet.Tables.Contains("TaxFree") Then
                TFDataSet.Tables("TaxFree").Clear()

            End If
            TaxFree.Fill(TFDataSet, "TaxFree")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            TFBSource.DataSource = TFDataSet.Tables("TaxFree")
            DataGridView1.DataSource = TFBSource




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim ödemetipi As String = "select * from TaxFree where MüsteriTelefonNo like @tur"
        TaxFree = New SqlDataAdapter(ödemetipi, SQLBaglanti)
        TaxFree.SelectCommand.Parameters.Add("@tur", SqlDbType.VarChar).Value = "%" & TextBox7.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(TaxFree)
        Try
            SQLBaglanti.Open()
            If TFDataSet.Tables.Contains("TaxFree") Then
                TFDataSet.Tables("TaxFree").Clear()

            End If
            TaxFree.Fill(TFDataSet, "TaxFree")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            TFBSource.DataSource = TFDataSet.Tables("TaxFree")
            DataGridView1.DataSource = TFBSource




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TFBSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TFBSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TFBSource.MovePrevious()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TFBSource.MoveFirst()
    End Sub
End Class