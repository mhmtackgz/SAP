<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnaForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.AnaFormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MağazaBilgileriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AylıkHedefCirpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KesilenFaturalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KesilenTaxFreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokÜrünleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonellerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelKayıtlarıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaFormMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnaFormMenuStrip
        '
        Me.AnaFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MağazaBilgileriToolStripMenuItem, Me.StokToolStripMenuItem, Me.PersonellerToolStripMenuItem, Me.ProgramToolStripMenuItem})
        Me.AnaFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AnaFormMenuStrip.Name = "AnaFormMenuStrip"
        Me.AnaFormMenuStrip.Size = New System.Drawing.Size(900, 24)
        Me.AnaFormMenuStrip.TabIndex = 2
        Me.AnaFormMenuStrip.Text = "MenuStrip1"
        '
        'MağazaBilgileriToolStripMenuItem
        '
        Me.MağazaBilgileriToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MağazaBilgileriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AylıkHedefCirpToolStripMenuItem, Me.KesilenFaturalarToolStripMenuItem, Me.KesilenTaxFreeToolStripMenuItem})
        Me.MağazaBilgileriToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.MağazaBilgileriToolStripMenuItem.Image = Global.SAP.My.Resources.Resources.Paomedia_Small_N_Flat_Shop
        Me.MağazaBilgileriToolStripMenuItem.Name = "MağazaBilgileriToolStripMenuItem"
        Me.MağazaBilgileriToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.MağazaBilgileriToolStripMenuItem.Text = "Mağaza Bilgileri"
        '
        'AylıkHedefCirpToolStripMenuItem
        '
        Me.AylıkHedefCirpToolStripMenuItem.Name = "AylıkHedefCirpToolStripMenuItem"
        Me.AylıkHedefCirpToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AylıkHedefCirpToolStripMenuItem.Text = "Aylık Hedef (Ciro)"
        '
        'KesilenFaturalarToolStripMenuItem
        '
        Me.KesilenFaturalarToolStripMenuItem.Name = "KesilenFaturalarToolStripMenuItem"
        Me.KesilenFaturalarToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.KesilenFaturalarToolStripMenuItem.Text = "Kesilen Fatura Detayları"
        '
        'KesilenTaxFreeToolStripMenuItem
        '
        Me.KesilenTaxFreeToolStripMenuItem.Name = "KesilenTaxFreeToolStripMenuItem"
        Me.KesilenTaxFreeToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.KesilenTaxFreeToolStripMenuItem.Text = "Kesilen TaxFree Detayları"
        '
        'StokToolStripMenuItem
        '
        Me.StokToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.StokToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokÜrünleriToolStripMenuItem})
        Me.StokToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.StokToolStripMenuItem.Image = CType(resources.GetObject("StokToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StokToolStripMenuItem.Name = "StokToolStripMenuItem"
        Me.StokToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.StokToolStripMenuItem.Text = "Stok"
        '
        'StokÜrünleriToolStripMenuItem
        '
        Me.StokÜrünleriToolStripMenuItem.Name = "StokÜrünleriToolStripMenuItem"
        Me.StokÜrünleriToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.StokÜrünleriToolStripMenuItem.Text = "Stok Ürünleri Ve Stoğa Ürün Ekleme"
        '
        'PersonellerToolStripMenuItem
        '
        Me.PersonellerToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PersonellerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonelKayıtlarıToolStripMenuItem})
        Me.PersonellerToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.PersonellerToolStripMenuItem.Image = CType(resources.GetObject("PersonellerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PersonellerToolStripMenuItem.Name = "PersonellerToolStripMenuItem"
        Me.PersonellerToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.PersonellerToolStripMenuItem.Text = "Personeller"
        '
        'PersonelKayıtlarıToolStripMenuItem
        '
        Me.PersonelKayıtlarıToolStripMenuItem.Name = "PersonelKayıtlarıToolStripMenuItem"
        Me.PersonelKayıtlarıToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.PersonelKayıtlarıToolStripMenuItem.Text = "Personel Bilgileri Ekleme Güncelleme"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÇıkışToolStripMenuItem1})
        Me.ProgramToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.ProgramToolStripMenuItem.Image = CType(resources.GetObject("ProgramToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgramToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ÇıkışToolStripMenuItem1
        '
        Me.ÇıkışToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control
        Me.ÇıkışToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ÇıkışToolStripMenuItem1.Image = CType(resources.GetObject("ÇıkışToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ÇıkışToolStripMenuItem1.Name = "ÇıkışToolStripMenuItem1"
        Me.ÇıkışToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ÇıkışToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ÇıkışToolStripMenuItem1.Text = "&Çıkış"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(900, 432)
        Me.Controls.Add(Me.AnaFormMenuStrip)
        Me.ForeColor = System.Drawing.Color.Olive
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AnaFormMenuStrip
        Me.Name = "AnaForm"
        Me.Text = "SAP DESTEK "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AnaFormMenuStrip.ResumeLayout(False)
        Me.AnaFormMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnaFormMenuStrip As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonellerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelKayıtlarıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokÜrünleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MağazaBilgileriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AylıkHedefCirpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KesilenFaturalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KesilenTaxFreeToolStripMenuItem As ToolStripMenuItem
End Class
