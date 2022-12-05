Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class KullanıcıGirisEkranı


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



    Private Sub Tamam_Clik(sender As Object, e As EventArgs) Handles Tamam.Click
        If (Textbox1.Text = "") Then
            MessageBox.Show("Kullanıcı Adı Boş Geçilemez", "Kullanıcı Adı")
        ElseIf Textbox2.Text = "" Then
            MessageBox.Show("Şifre Kısmı Boş Geçilemez", "Şifre")
        Else
            Hak = Hak - 1
            Dim SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)
            Dim Sorgu As String = "SELECT * FROM PersonelGiris WHERE kullaniciadi=@kullanici_adi and sifre=@sifre"
            Dim PersonelGiris As New SqlDataAdapter(Sorgu, SQLBaglanti)
            PersonelGiris.SelectCommand.Parameters.Add("@kullanici_adi", SqlDbType.VarChar).Value = Textbox1.Text
            PersonelGiris.SelectCommand.Parameters.Add("@sifre", SqlDbType.VarChar).Value = Textbox2.Text

            Try
                SQLBaglanti.Open() 'Bağlantı açıldı
                PersonelGiris.Fill(PersonelDataSet, "PersonelGiris")
                If PersonelDataSet.Tables("PersonelGiris").Rows.Count = 1 Then
                    AnaForm.Show()
                    MessageBox.Show("Sap Destek Ana Menü Ekranına Hoşgeldiniz", "Giriş Ekranı")
                    Me.Close()
                ElseIf Hak > 0 Then
                    MessageBox.Show("Kullanıcı Adı ve/veya Şifre hatası.Tekrar deneyiniz.", "Hatalı Giriş")
                    Textbox1.Text = ""
                    Textbox2.Text = ""
                Else

                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı. Program Kapatılıyor ", "Çıkış İşlemi")
                    Me.Close()

                End If

            Catch ex As Exception
                MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
            Finally
                SQLBaglanti.Close() 'Bağlantı kapatıldı
            End Try
        End If



    End Sub





    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox1.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Sadece Harf Giriniz", "Dikkat!")
        End If
    End Sub

    Private Sub Textbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Sadece Sayı Giriniz", "Dikkat!")
        ElseIf (TextBox1.Text.Length > 7) Then
            MessageBox.Show("Kullanıcı Adı en az 6 haneli olmalıdır.")
        ElseIf (Textbox2.Text.Length > 6) Then
            MessageBox.Show("Şifre en az 5 haneli olmalıdır.")
        End If


    End Sub

    Private Sub Textbox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Textbox1.MouseDoubleClick
        Textbox1.Text = ""
    End Sub

    Private Sub Textbox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Textbox2.MouseDoubleClick
        Textbox2.Text = ""
    End Sub



    Private Sub Temizle_Click(sender As Object, e As EventArgs) Handles Temizle.Click
        Textbox1.Text = ""
        Textbox2.Text = ""
    End Sub
End Class
'Hak -= 1
'Dim Sorgu As String = "SELECT * FROM PersonelGiris WHERE kullaniciadi=@kadi AND sifre=@sfr"
'Dim SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)
'Dim SQLKomut As New SqlCommand(Sorgu, SQLBaglanti)
'SQLKomut.Parameters.Add("@kadi", SqlDbType.NVarChar, 20)
'SQLKomut.Parameters.Add("@sfr", SqlDbType.NVarChar, 128)
'Dim KAdi As String = TextBox1.Text
'Dim KSifre As String = TextBox2.Text
'Try
'SQLBaglanti.Open()
'SQLKomut.Parameters("@kadi").Value = KAdi
'SQLKomut.Parameters("@sfr").Value = KSifre

'Dim Tablo As New DataTable
'If (Tablo.Rows.Count = 1) AndAlso (KAdi = Tablo.Rows(0)("kullaniciadi") And KSifre = Tablo.Rows(0)("sifre")) Then
'Me.DialogResult = DialogResult.OK
'Me.Close()
'ElseIf Hak > 0 Then
'MessageBox.Show("Kullanıcı Adı ve/veya Şifre hatası.Tekrar deneyiniz.", "Hatalı Giriş")
'Else
'MessageBox.Show("Kullanıcı Adı ve/veya Şifre hatası.Program kapatılacak.", "Hatalı Giriş")
'Me.Close()
'End If
'Catch ex As Exception
'MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
'Finally
'SQLBaglanti.Close()
'End Try
