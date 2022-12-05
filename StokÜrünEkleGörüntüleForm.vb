Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.OleDb


Public Class StokÜrünEkleGörüntüleForm
    Private Stok As New SqlDataAdapter
    Private SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)

    Private Sub StokÜrünEkleGörüntüleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StokGetir()
    End Sub

    Private Sub StokGetir()
        Dim Sorgu As String = "SELECT * FROM StokTablosu"
        Stok = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim SorguCumlesiOlusturucu As New SqlCommandBuilder(Stok)
        Try
            SQLBaglanti.Open() 'Bağlantı açıldı
            Stok.Fill(StokDS, "StokTablosu") 'Select sonucu dönen kayıtları DataSet içerisine aktardık
            'Insert, Delete ve Update cümlelerini oluştur
            SorguCumlesiOlusturucu.GetInsertCommand()
            SorguCumlesiOlusturucu.GetUpdateCommand()
            SorguCumlesiOlusturucu.GetDeleteCommand()
            'Kayıtlar üzerinde gezinme, ekleme ve form nesneleri ile bağlama için kullanacağımız nesneye atama yap
            StokBS.DataSource = StokDS
            StokBS.DataMember = "StokTablosu"
            StokNesneleriGetir()
            StokBS.MoveLast()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantı kapatıldı
        End Try
    End Sub
    Private Sub StokNesneleriGetir()
        DateTimePicker3.DataBindings.Add("Value", StokBS, "TeslimatOnayTarihi", True)
        TextBox1.DataBindings.Add("Text", StokBS, "TeslimatGelenYer")
        NumericUpDown1.DataBindings.Add("Text", StokBS, "GelenKoliAdeti")
        TextBox2.DataBindings.Add("Text", StokBS, "GelenKoliAçıklaması")
        TextBox4.DataBindings.Add("Text", StokBS, "ÜrününTürü")
        ComboBox1.DataBindings.Add("Text", StokBS, "ÜrününMarkası")
        TextBox3.DataBindings.Add("Text", StokBS, "ÜrünSTK")
        DataGridView1.DataSource = StokBS

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Kayıt Silinecek. Mevcut kaydı silmek istediğine emin misin?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Silme Uyarısı") = MsgBoxResult.Yes Then
            StokBS.RemoveCurrent()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "") Then
            MessageBox.Show("Tüm Alanları Doldurduğunuzdan Emin Olunuz...", "Hata")
        Else
            Try
                Me.Validate()
                StokBS.EndEdit()
                Stok.Update(StokDS, "StokTablosu")
                MessageBox.Show("Kayıtlar üzerinde yapılan değişiklikler başarı ile kaydedildi.", "Kayıt İşlemi")
            Catch ex As Exception
                MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
            End Try
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StokBS.AddNew()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim personelArama As String = "select * from StokTablosu where ÜrünSTK like @ara"
        Stok = New SqlDataAdapter(personelArama, SQLBaglanti)
        Stok.SelectCommand.Parameters.Add("@ara", SqlDbType.VarChar).Value = "%" & TextBox5.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Stok)
        Try
            SQLBaglanti.Open()
            If StokDS.Tables.Contains("StokTablosu") Then
                StokDS.Tables("StokTablosu").Clear()

            End If
            Stok.Fill(StokDS, "StokTablosu")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            StokBS.DataSource = StokDS.Tables("StokTablosu")
            DataGridView1.DataSource = StokBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim Ürünara As String = "select * from StokTablosu where ÜrününMarkası like @marka"
        Stok = New SqlDataAdapter(Ürünara, SQLBaglanti)
        Stok.SelectCommand.Parameters.Add("@marka", SqlDbType.VarChar).Value = "%" & TextBox6.Text & "%"
        Dim personelSorguOlusturucu As New SqlCommandBuilder(Stok)
        Try
            SQLBaglanti.Open()
            If StokDS.Tables.Contains("StokTablosu") Then
                StokDS.Tables("StokTablosu").Clear()

            End If
            Stok.Fill(StokDS, "StokTablosu")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            StokBS.DataSource = StokDS.Tables("StokTablosu")
            DataGridView1.DataSource = StokBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StokBS.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StokBS.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StokBS.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StokBS.MoveLast()
    End Sub
End Class