Imports System.Data.SqlClient

Public Class AylıkCiroForm
    Private Personel As New SqlDataAdapter
    Private SQLBaglanti As New SqlConnection(SQLBAGLANTİCUMLESİ)

    Private Sub AylıkCiroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AylikCirolarıGetir()



    End Sub
    Private Sub AylikCirolarıGetir()
        Dim Sorgu As String = "SELECT * FROM Ciro"
        Personel = New SqlDataAdapter(Sorgu, SQLBaglanti)
        Dim SorguCumlesiOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open() 'Bağlantı açıldı
            Personel.Fill(CiroDS, "Ciro") 'Select sonucu dönen kayıtları DataSet içerisine aktardık
            'Insert, Delete ve Update cümlelerini oluştur
            SorguCumlesiOlusturucu.GetInsertCommand()
            SorguCumlesiOlusturucu.GetUpdateCommand()
            SorguCumlesiOlusturucu.GetDeleteCommand()
            'Kayıtlar üzerinde gezinme, ekleme ve form nesneleri ile bağlama için kullanacağımız nesneye atama yap

            CiroBS.DataSource = CiroDS
            CiroBS.DataMember = "Ciro"
            FormElemanlarınıbagla()
            CiroBS.MoveLast()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
        Finally
            SQLBaglanti.Close() 'Bağlantı kapatıldı
        End Try

    End Sub

    Private Sub FormElemanlarınıbagla()
        TarihDateTimePicker.DataBindings.Add("Value", CiroBS, "BelirlenenTarih", True)
        TextBox1.DataBindings.Add("Text", CiroBS, "BeklenenSatıs")
        DataGridView1.DataSource = CiroBS

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CiroBS.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CiroBS.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CiroBS.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CiroBS.MoveLast()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Bu alanlar zorunludur.", "Dikkat")

        Else
            Try
                Me.Validate()
                CiroBS.EndEdit()
                Personel.Update(CiroDS, "Ciro")
                MessageBox.Show("Kayıtlar üzerinde yapılan değişiklikler başarı ile kaydedildi.", "Kayıt İşlemi")
            Catch ex As Exception
                MessageBox.Show("Hata oluştu. Oluşan Hata: " & ex.Message, "Hata")
            End Try
        End If




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CiroBS.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MsgBox("Kayıt Silinecek. Mevcut kaydı silmek istediğine emin misin?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Silme Uyarısı") = MsgBoxResult.Yes Then
            CiroBS.RemoveCurrent()
        End If
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        Dim personelArama As String = "select * from Ciro where BeklenenSatıs like @ara"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        Personel.SelectCommand.Parameters.Add("@ara", SqlDbType.VarChar).Value = "%" & TextBox2.Text & "%"

        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If CiroDS.Tables.Contains("Ciro") Then
                CiroDS.Tables("Ciro").Clear()

            End If
            Personel.Fill(CiroDS, "Ciro")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            CiroBS.DataSource = CiroDS.Tables("Ciro")
            DataGridView1.DataSource = CiroBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub

    Private Sub DateTimePicker1_Validated(sender As Object, e As EventArgs) 

        Dim personelArama As String = "select * from Ciro where BelirlenenTarih like @ara"
        Personel = New SqlDataAdapter(personelArama, SQLBaglanti)
        ' Personel.SelectCommand.Parameters.Add("@ara", SqlDbType.VarChar).Value = 

        Dim personelSorguOlusturucu As New SqlCommandBuilder(Personel)
        Try
            SQLBaglanti.Open()
            If CiroDS.Tables.Contains("Ciro") Then
                CiroDS.Tables("Ciro").Clear()

            End If
            Personel.Fill(CiroDS, "Ciro")
            personelSorguOlusturucu.GetInsertCommand()
            personelSorguOlusturucu.GetUpdateCommand()
            personelSorguOlusturucu.GetDeleteCommand()
            CiroBS.DataSource = CiroDS.Tables("Ciro")
            DataGridView1.DataSource = CiroBS




        Catch ex As Exception
            MessageBox.Show("Hata Oluştu : Hata " & ex.Message)


        Finally
            SQLBaglanti.Close()


        End Try
    End Sub
End Class