Imports System.Data.SqlClient
Public Class KesilenFaturaDetay
    Private Personel As New SqlDataAdapter
    Private SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)

    Private Sub KesilenFaturaDetay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Faturalar()
    End Sub

    Private Sub Faturalar()
        Dim Sorgu As String = "SELECT * FROM Faturalar"
        Personel = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim SorguCumlesiOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open() 'Bağlantı açıldı
            Personel.Fill(FaturaDetayDS, "Faturalar") 'Select sonucu dönen kayıtları DataSet içerisine aktardık
            'Insert, Delete ve Update cümlelerini oluştur
            SorguCumlesiOlusturucu.GetInsertCommand()
            SorguCumlesiOlusturucu.GetUpdateCommand()
            SorguCumlesiOlusturucu.GetDeleteCommand()
            'Kayıtlar üzerinde gezinme, ekleme ve form nesneleri ile bağlama için kullanacağımız nesneye atama yap
            FaturaDetayBS.DataSource = FaturaDetayDS
            FaturaDetayBS.DataMember = "Faturalar"
            FormNesneleriniBagla()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantı kapatıldı
        End Try
    End Sub
    Private Sub FormNesneleriniBagla()
        KasiyerTextBox.DataBindings.Add("Text", FaturaDetayBS, "FaturayıKesenKasiyer")
        DateTimePicker1.DataBindings.Add("Value", FaturaDetayBS, "FaturaKesimTarihi", True)
        TutarTextBox.DataBindings.Add("Text", FaturaDetayBS, "İşlemTutarı")
        TelefonTextBox.DataBindings.Add("Text", FaturaDetayBS, "Telno")
        KurumTelTextBox.DataBindings.Add("Text", FaturaDetayBS, "KurumTelefonNo")
        KurumAdresTextBox.DataBindings.Add("Text", FaturaDetayBS, "KurumAdres")
        E_PostaTextBox.DataBindings.Add("Text", FaturaDetayBS, "Eposta")
        FaturaNoTextBox.DataBindings.Add("Text", FaturaDetayBS, "FaturaNo")
        DateTimePicker2.DataBindings.Add("Value", FaturaDetayBS, "İşlemTarihi", True)
        DataGridView1.DataSource = FaturaDetayBS


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FaturaDetayBS.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FaturaDetayBS.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FaturaDetayBS.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FaturaDetayBS.MoveLast()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If (KasiyerTextBox.Text = "" Or TutarTextBox.Text = "" Or TelefonTextBox.Text = "" Or KurumTelTextBox.Text = "" Or KurumAdresTextBox.Text = "" Or E_PostaTextBox.Text = "" Or FaturaNoTextBox.Text = "") Then

            MessageBox.Show("Bu alanlar zorunludur.", "Dikkat")
        Else
            Try
                Me.Validate()
                FaturaDetayBS.EndEdit()
                Personel.Update(FaturaDetayDS, "Faturalar")
                MessageBox.Show("Kayıtlar üzerinde yapılan değişiklikler başarı ile kaydedildi.", "Kayıt İşlemi")
            Catch ex As Exception
                MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
            End Try
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Kayıt Silinecek. Mevcut kaydı silmek istediğine emin misin?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Personel Silme Uyarısı") = MsgBoxResult.Yes Then
            FaturaDetayBS.RemoveCurrent()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim personelArama As String = "select * from Faturalar where FaturaNo like @fatura"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@fatura", SqlDbType.VarChar).Value = "%" & TextBox1.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If FaturaDetayDS.Tables.Contains("Faturalar") Then
                FaturaDetayDS.Tables("Faturalar").Clear()

            End If
            Personel.Fill(FaturaDetayDS, "Faturalar")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            FaturaDetayBS.DataSource = FaturaDetayDS.Tables("Faturalar")
            DataGridView1.DataSource = FaturaDetayBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim personelArama As String = "select * from Faturalar where Telno like @tel"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@tel", SqlDbType.VarChar).Value = "%" & TextBox2.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If FaturaDetayDS.Tables.Contains("Faturalar") Then
                FaturaDetayDS.Tables("Faturalar").Clear()

            End If
            Personel.Fill(FaturaDetayDS, "Faturalar")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            FaturaDetayBS.DataSource = FaturaDetayDS.Tables("Faturalar")
            DataGridView1.DataSource = FaturaDetayBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim personelArama As String = "select * from Faturalar where İşlemTutarı like @tl"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@tl", SqlDbType.VarChar).Value = "%" & TextBox3.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If FaturaDetayDS.Tables.Contains("Faturalar") Then
                FaturaDetayDS.Tables("Faturalar").Clear()

            End If
            Personel.Fill(FaturaDetayDS, "Faturalar")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            FaturaDetayBS.DataSource = FaturaDetayDS.Tables("Faturalar")
            DataGridView1.DataSource = FaturaDetayBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TelefonTextBox_TextChanged(sender As Object, e As EventArgs) Handles TelefonTextBox.TextChanged
        If TelefonTextBox.Text.Length >= 11 Then
            MessageBox.Show("Telefon Numarası En Fazla 11 Haneli Olabilir")
        End If
    End Sub

    Private Sub KurumAdresTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KurumAdresTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TelefonTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonTextBox.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KurumTelTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KurumTelTextBox.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class

