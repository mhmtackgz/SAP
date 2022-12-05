<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KullanıcıGirisEkranı
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KullanıcıGirisEkranı))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PersonelDataSet = New System.Data.DataSet()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Textbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Tamam = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Temizle = New System.Windows.Forms.Button()
        CType(Me.PersonelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kullanıcı Adı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Şifre:"
        '
        'PersonelDataSet
        '
        Me.PersonelDataSet.DataSetName = "PersonelDataSet"
        '
        'Textbox1
        '
        Me.Textbox1.BackColor = System.Drawing.Color.Cornsilk
        Me.Textbox1.BorderColorFocused = System.Drawing.Color.Black
        Me.Textbox1.BorderColorIdle = System.Drawing.Color.Cornsilk
        Me.Textbox1.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Textbox1.BorderThickness = 3
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Textbox1.isPassword = False
        Me.Textbox1.Location = New System.Drawing.Point(22, 142)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(430, 44)
        Me.Textbox1.TabIndex = 11
        Me.Textbox1.Text = "Kullanıcı Adınızı Giriniz.."
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox2
        '
        Me.Textbox2.BackColor = System.Drawing.Color.Cornsilk
        Me.Textbox2.BorderColorFocused = System.Drawing.Color.Black
        Me.Textbox2.BorderColorIdle = System.Drawing.Color.Cornsilk
        Me.Textbox2.BorderColorMouseHover = System.Drawing.Color.Black
        Me.Textbox2.BorderThickness = 3
        Me.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Textbox2.isPassword = True
        Me.Textbox2.Location = New System.Drawing.Point(22, 229)
        Me.Textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(429, 44)
        Me.Textbox2.TabIndex = 12
        Me.Textbox2.Text = "123123213"
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Tamam
        '
        Me.Tamam.BackColor = System.Drawing.Color.SeaGreen
        Me.Tamam.CausesValidation = False
        Me.Tamam.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Tamam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tamam.Font = New System.Drawing.Font("Microsoft YaHei", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tamam.ForeColor = System.Drawing.Color.White
        Me.Tamam.Image = CType(resources.GetObject("Tamam.Image"), System.Drawing.Image)
        Me.Tamam.Location = New System.Drawing.Point(20, 325)
        Me.Tamam.Name = "Tamam"
        Me.Tamam.Size = New System.Drawing.Size(204, 76)
        Me.Tamam.TabIndex = 3
        Me.Tamam.Text = "&Tamam"
        Me.Tamam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tamam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Tamam.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.Red
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.Location = New System.Drawing.Point(248, 325)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(202, 76)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&İptal"
        Me.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(407, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.SAP.My.Resources.Resources.Users_Administrator_icon
        Me.PictureBox3.Location = New System.Drawing.Point(187, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Crimson
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(30, 277)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(139, 20)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Şifremi Unuttum"
        '
        'Temizle
        '
        Me.Temizle.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Temizle.BackColor = System.Drawing.Color.Transparent
        Me.Temizle.BackgroundImage = Global.SAP.My.Resources.Resources.delete
        Me.Temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Temizle.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temizle.ForeColor = System.Drawing.Color.Black
        Me.Temizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Temizle.Location = New System.Drawing.Point(359, 274)
        Me.Temizle.Name = "Temizle"
        Me.Temizle.Size = New System.Drawing.Size(91, 50)
        Me.Temizle.TabIndex = 16
        Me.Temizle.Text = "Temizle"
        Me.Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Temizle.UseCompatibleTextRendering = True
        Me.Temizle.UseVisualStyleBackColor = True
        '
        'KullanıcıGirisEkranı
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.BackgroundImage = Global.SAP.My.Resources.Resources.pexels_photo_220182
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(462, 413)
        Me.Controls.Add(Me.Temizle)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Textbox2)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Tamam)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KullanıcıGirisEkranı"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KullanıcıGirisEkranı"
        CType(Me.PersonelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Tamam As Button
    Friend WithEvents PersonelDataSet As DataSet
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Textbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Temizle As Button
End Class
