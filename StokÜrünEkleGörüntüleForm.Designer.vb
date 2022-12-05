<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StokÜrünEkleGörüntüleForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TeslimatOnayTarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeslimatGelenYer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GelenKoliAdeti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GelenKoliAçıklaması = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ÜrününTürü = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ÜrününMarkası = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ÜrünSTK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StokDS = New System.Data.DataSet()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StokBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StokDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Crimson
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.DarkGray
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1200, 489)
        Me.SplitContainer1.SplitterDistance = 557
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 117)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arama İşlemleri"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(157, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(303, 29)
        Me.TextBox6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ÜRÜNÜN MARKASI:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(157, 29)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(303, 29)
        Me.TextBox5.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "STOK KODU:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(278, 261)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(268, 20)
        Me.TextBox3.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Ürünün Stok Kodu:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nike", "Adidas", "Kinetix", "Hummel", "Lumberjack", "Puma", "Reebok", "Skechers", "U.S. POLO ASSN", "BUTIGO"})
        Me.ComboBox1.Location = New System.Drawing.Point(278, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(268, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(278, 118)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(268, 42)
        Me.TextBox2.TabIndex = 61
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(278, 89)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 60
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 42)
        Me.TextBox1.TabIndex = 59
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(278, 10)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(268, 20)
        Me.DateTimePicker3.TabIndex = 58
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.Image = Global.SAP.My.Resources.Resources.delete
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(379, 292)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(149, 70)
        Me.Button7.TabIndex = 57
        Me.Button7.Text = "Sil"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button6.Image = Global.SAP.My.Resources.Resources.addnew
        Me.Button6.Location = New System.Drawing.Point(196, 292)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(159, 70)
        Me.Button6.TabIndex = 56
        Me.Button6.Text = "Yeni Kayıt Oluştur"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Image = Global.SAP.My.Resources.Resources.save
        Me.Button5.Location = New System.Drawing.Point(23, 292)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 70)
        Me.Button5.TabIndex = 55
        Me.Button5.Text = "Kaydet"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(278, 179)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(268, 20)
        Me.TextBox4.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 26)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Ürünün Türü:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 26)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Ürünün Markası:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 26)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Teslimat Açıklaması:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 26)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Teslimat Alınan Yer Adres:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 26)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Gelen Koli Adeti:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 26)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Teslimat Onay Tarihi:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.SAP.My.Resources.Resources.last
        Me.Button4.Location = New System.Drawing.Point(468, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 48)
        Me.Button4.TabIndex = 58
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeslimatOnayTarihi, Me.TeslimatGelenYer, Me.GelenKoliAdeti, Me.GelenKoliAçıklaması, Me.ÜrününTürü, Me.ÜrününMarkası, Me.ÜrünSTK})
        Me.DataGridView1.DataSource = Me.StokBS
        Me.DataGridView1.Location = New System.Drawing.Point(-13, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 362)
        Me.DataGridView1.TabIndex = 0
        '
        'TeslimatOnayTarihi
        '
        Me.TeslimatOnayTarihi.DataPropertyName = "TeslimatOnayTarihi"
        Me.TeslimatOnayTarihi.HeaderText = "TeslimatOnayTarihi"
        Me.TeslimatOnayTarihi.Name = "TeslimatOnayTarihi"
        '
        'TeslimatGelenYer
        '
        Me.TeslimatGelenYer.DataPropertyName = "TeslimatGelenYer"
        Me.TeslimatGelenYer.HeaderText = "TeslimatGelenYer"
        Me.TeslimatGelenYer.Name = "TeslimatGelenYer"
        '
        'GelenKoliAdeti
        '
        Me.GelenKoliAdeti.DataPropertyName = "GelenKoliAdeti"
        Me.GelenKoliAdeti.HeaderText = "GelenKoliAdeti"
        Me.GelenKoliAdeti.Name = "GelenKoliAdeti"
        '
        'GelenKoliAçıklaması
        '
        Me.GelenKoliAçıklaması.DataPropertyName = "GelenKoliAçıklaması"
        Me.GelenKoliAçıklaması.HeaderText = "GelenKoliAçıklaması"
        Me.GelenKoliAçıklaması.Name = "GelenKoliAçıklaması"
        '
        'ÜrününTürü
        '
        Me.ÜrününTürü.DataPropertyName = "ÜrününTürü"
        Me.ÜrününTürü.HeaderText = "ÜrününTürü"
        Me.ÜrününTürü.Name = "ÜrününTürü"
        '
        'ÜrününMarkası
        '
        Me.ÜrününMarkası.DataPropertyName = "ÜrününMarkası"
        Me.ÜrününMarkası.HeaderText = "ÜrününMarkası"
        Me.ÜrününMarkası.Name = "ÜrününMarkası"
        '
        'ÜrünSTK
        '
        Me.ÜrünSTK.DataPropertyName = "ÜrünSTK"
        Me.ÜrünSTK.HeaderText = "ÜrünSTK"
        Me.ÜrünSTK.Name = "ÜrünSTK"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.SAP.My.Resources.Resources._next
        Me.Button3.Location = New System.Drawing.Point(323, 369)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 48)
        Me.Button3.TabIndex = 57
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.SAP.My.Resources.Resources.first
        Me.Button1.Location = New System.Drawing.Point(24, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 48)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.SAP.My.Resources.Resources.previous
        Me.Button2.Location = New System.Drawing.Point(173, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 48)
        Me.Button2.TabIndex = 56
        Me.Button2.UseVisualStyleBackColor = False
        '
        'StokDS
        '
        Me.StokDS.DataSetName = "NewDataSet"
        '
        'StokÜrünEkleGörüntüleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 489)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "StokÜrünEkleGörüntüleForm"
        Me.Text = "StokÜrünEkleGörüntüleForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StokBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StokDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents StokDS As DataSet
    Friend WithEvents StokBS As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TeslimatOnayTarihi As DataGridViewTextBoxColumn
    Friend WithEvents TeslimatGelenYer As DataGridViewTextBoxColumn
    Friend WithEvents GelenKoliAdeti As DataGridViewTextBoxColumn
    Friend WithEvents GelenKoliAçıklaması As DataGridViewTextBoxColumn
    Friend WithEvents ÜrününTürü As DataGridViewTextBoxColumn
    Friend WithEvents ÜrününMarkası As DataGridViewTextBoxColumn
    Friend WithEvents ÜrünSTK As DataGridViewTextBoxColumn
End Class
