Imports System.ComponentModel

Public Class AnaForm


    Private Sub PersonelKayıtlarıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelKayıtlarıToolStripMenuItem.Click
        PersonelKayıtlarıGoruntule.MdiParent = Me
        PersonelKayıtlarıGoruntule.Show()
        PersonelKayıtlarıGoruntule.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ÇıkışToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem1.Click
        Me.Close()

    End Sub






    Private Sub AnaForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Programı  Kapatmak İstiyormusunuz?", "UYARI", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then

            Application.Exit()


        Else

            e.Cancel = True


        End If
    End Sub

    Private Sub AylıkHedefCirpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AylıkHedefCirpToolStripMenuItem.Click
        AylıkCiroForm.MdiParent = Me
        AylıkCiroForm.Show()
        AylıkCiroForm.WindowState = FormWindowState.Maximized
        SatısTutarForm.Hide()
        KesilenFaturaDetay.Hide()
        StokÜrünEkleGörüntüleForm.Hide()
        KesilenTaxFreeForm.Hide()

    End Sub

    Private Sub SatışTutarlarıToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SatısTutarForm.MdiParent = Me
        SatısTutarForm.Show()
        SatısTutarForm.WindowState = FormWindowState.Maximized
        AylıkCiroForm.Hide()
        KesilenFaturaDetay.Hide()
        StokÜrünEkleGörüntüleForm.Hide()
        KesilenTaxFreeForm.Hide()
    End Sub

    Private Sub KesilenTaxFreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KesilenTaxFreeToolStripMenuItem.Click
        KesilenTaxFreeForm.MdiParent = Me
        KesilenTaxFreeForm.Show()
        KesilenTaxFreeForm.WindowState = FormWindowState.Maximized
        AylıkCiroForm.Hide()
        SatısTutarForm.Hide()
        StokÜrünEkleGörüntüleForm.Hide()
        KesilenFaturaDetay.Hide()

    End Sub

    Private Sub StokÜrünleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokÜrünleriToolStripMenuItem.Click
        StokÜrünEkleGörüntüleForm.MdiParent = Me
        StokÜrünEkleGörüntüleForm.Show()
        StokÜrünEkleGörüntüleForm.WindowState = FormWindowState.Maximized
        AylıkCiroForm.Hide()
        SatısTutarForm.Hide()
        KesilenFaturaDetay.Hide()
        KesilenTaxFreeForm.Hide()
    End Sub

    Private Sub KesilenFaturalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KesilenFaturalarToolStripMenuItem.Click
        KesilenFaturaDetay.MdiParent = Me
        KesilenFaturaDetay.Show()
        KesilenFaturaDetay.WindowState = FormWindowState.Maximized
        AylıkCiroForm.Hide()
        SatısTutarForm.Hide()
        StokÜrünEkleGörüntüleForm.Hide()
        KesilenTaxFreeForm.Hide()
    End Sub



End Class