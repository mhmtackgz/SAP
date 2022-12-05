Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class PersonelKayıtlarıGoruntule
    Private Personel As New SqlDataAdapter
    Private SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)

    Private Sub PersonelKayıtlarıGoruntule_Load(sender As Object, e As EventArgs) Handles Me.Load
        Personelleri_Getir()



    End Sub

    Private Sub Personelleri_Getir()
        Dim Sorgu As String = "SELECT * FROM PersonelTablosu"
        Personel = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim SorguCumlesiOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open() 'Bağlantı açıldı
            Personel.Fill(PersonelDataSet, "PersonelTablosu") 'Select sonucu dönen kayıtları DataSet içerisine aktardık
            'Insert, Delete ve Update cümlelerini oluştur
            SorguCumlesiOlusturucu.GetInsertCommand()
            SorguCumlesiOlusturucu.GetUpdateCommand()
            SorguCumlesiOlusturucu.GetDeleteCommand()
            'Kayıtlar üzerinde gezinme, ekleme ve form nesneleri ile bağlama için kullanacağımız nesneye atama yap
            PersonelBindingSource.DataSource = PersonelDataSet
            PersonelBindingSource.DataMember = "PersonelTablosu"
            FormNesneleriniBagla()
            PersonelBindingSource.MoveLast()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantı kapatıldı
        End Try
    End Sub
    Private Sub FormNesneleriniBagla()
        ADTextBox.DataBindings.Add("Text", PersonelBindingSource, "PersonelAD")
        SoyadTextBox.DataBindings.Add("Text", PersonelBindingSource, "PersonelSoyad")
        GörevTextBox.DataBindings.Add("Text", PersonelBindingSource, "Görevi")
        TelTextBox.DataBindings.Add("Text", PersonelBindingSource, "Telefon_Numarası")
        TextBox1.DataBindings.Add("Text", PersonelBindingSource, "Eğitim_Durumu")
        TextBox2.DataBindings.Add("Text", PersonelBindingSource, "Mail_Adresi")
        DateTimePicker1.DataBindings.Add("Value", PersonelBindingSource, "İşeBaşlamaTarihi", True)
        DataGridView1.DataSource = PersonelBindingSource
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PersonelBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PersonelBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PersonelBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PersonelBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (ADTextBox.Text = "" Or SoyadTextBox.Text = "" Or TelTextBox.Text = "" Or TextBox1.Text = "" Or GörevTextBox.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Bu alanlar zorunludur.", "Dikkat")
        Else
            Try
                Me.Validate()
                PersonelBindingSource.EndEdit()
                Personel.Update(PersonelDataSet, "PersonelTablosu")
                MessageBox.Show("Kayıtlar üzerinde yapılan değişiklikler başarı ile kaydedildi.", "Kayıt İşlemi")
            Catch ex As Exception
                MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
            End Try
        End If












    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PersonelBindingSource.AddNew()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Kayıt Silinecek. Mevcut kaydı silmek istediğine emin misin?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Personel Silme Uyarısı") = MsgBoxResult.Yes Then
            PersonelBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub ADTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ADTextBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Sadece Harf Giriniz", "Dikkat!")
        End If


    End Sub

    Private Sub TelTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelTextBox.KeyPress


        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True

        End If
        If TelTextBox.Text.Length <= 9 Then
        Else
            MessageBox.Show("Telefon Numarası 10 Hanelidir.Başına 0 eklemeden deneyiniz.")
            TelTextBox.Text = ""


        End If
    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim personelArama As String = "select * from PersonelTablosu where PersonelAd like @arama"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@arama", SqlDbType.VarChar).Value = "%" & TextBox3.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If PersonelDataSet.Tables.Contains("PersonelTablosu") Then
                PersonelDataSet.Tables("PersonelTablosu").Clear()

            End If
            Personel.Fill(PersonelDataSet, "PersonelTablosu")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            PersonelBindingSource.DataSource = PersonelDataSet.Tables("PersonelTablosu")
            DataGridView1.DataSource = PersonelBindingSource




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim personelArama As String = "select * from PersonelTablosu where Görevi like @görev"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@görev", SqlDbType.VarChar).Value = "%" & TextBox4.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If PersonelDataSet.Tables.Contains("PersonelTablosu") Then
                PersonelDataSet.Tables("PersonelTablosu").Clear()

            End If
            Personel.Fill(PersonelDataSet, "PersonelTablosu")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            PersonelBindingSource.DataSource = PersonelDataSet.Tables("PersonelTablosu")
            DataGridView1.DataSource = PersonelBindingSource




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim personelArama As String = "select * from PersonelTablosu where PersonelSoyad like @soyad"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@soyad", SqlDbType.VarChar).Value = "%" & TextBox5.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If PersonelDataSet.Tables.Contains("PersonelTablosu") Then
                PersonelDataSet.Tables("PersonelTablosu").Clear()

            End If
            Personel.Fill(PersonelDataSet, "PersonelTablosu")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            PersonelBindingSource.DataSource = PersonelDataSet.Tables("PersonelTablosu")
            DataGridView1.DataSource = PersonelBindingSource




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub









    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    'Dim Sorgu As String = "SELECT * FROM PersonelTablosu WHERE Adi LIKE @PersonelAd"
    'Dim SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)
    'Dim SQLKomut As New SqlCommand(Sorgu, SQLBaglanti)
    '   SQLKomut.Parameters.Add("@PersonelAd", SqlDbType.NVarChar, 70).Value = "%" & PersonelAd & "%"
    'Dim PersonelTablosu As New DataTable
    'Try
    '       SQLBaglanti.Open()
    '      PersonelTablosu.Load(SQLKomut.ExecuteReader)
    '     DataGridView1.DataSource = PersonelTablosu
    'Catch ex As Exception
    '       MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
    'Finally
    '       SQLBaglanti.Close() 'Bağlantı kapatıldı
    'End Try
    'End Sub

    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    '   PersonelAd = TextBox3.Text.Trim

    'End Sub
End Class





