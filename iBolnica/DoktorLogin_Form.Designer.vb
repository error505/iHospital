<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoktorLogin_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoktorLogin_Form))
        Me.BtnKrv = New System.Windows.Forms.Button()
        Me.BtnBankaKrvi = New System.Windows.Forms.Button()
        Me.BtnSastanci = New System.Windows.Forms.Button()
        Me.BtnPacijent = New System.Windows.Forms.Button()
        Me.BtnIzvjestaj = New System.Windows.Forms.Button()
        Me.BtnPacijenti1 = New System.Windows.Forms.Button()
        Me.BtnUredisastanke = New System.Windows.Forms.Button()
        Me.BtnDodajrecept = New System.Windows.Forms.Button()
        Me.BtnKreveti1 = New System.Windows.Forms.Button()
        Me.BtnBankakrvipogled = New System.Windows.Forms.Button()
        Me.BtnDodajizvjestaj = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNaslov = New System.Windows.Forms.Label()
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKrv
        '
        Me.BtnKrv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKrv.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKrv.Image = Global.iBolnica.My.Resources.Resources.kreveti
        Me.BtnKrv.Location = New System.Drawing.Point(1018, 167)
        Me.BtnKrv.Name = "BtnKrv"
        Me.BtnKrv.Size = New System.Drawing.Size(204, 86)
        Me.BtnKrv.TabIndex = 17
        Me.BtnKrv.UseVisualStyleBackColor = True
        '
        'BtnBankaKrvi
        '
        Me.BtnBankaKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankaKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBankaKrvi.Image = Global.iBolnica.My.Resources.Resources.krv
        Me.BtnBankaKrvi.Location = New System.Drawing.Point(747, 167)
        Me.BtnBankaKrvi.Name = "BtnBankaKrvi"
        Me.BtnBankaKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnBankaKrvi.TabIndex = 16
        Me.BtnBankaKrvi.UseVisualStyleBackColor = True
        '
        'BtnSastanci
        '
        Me.BtnSastanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSastanci.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSastanci.Image = Global.iBolnica.My.Resources.Resources.Sastanci
        Me.BtnSastanci.Location = New System.Drawing.Point(476, 167)
        Me.BtnSastanci.Name = "BtnSastanci"
        Me.BtnSastanci.Size = New System.Drawing.Size(205, 86)
        Me.BtnSastanci.TabIndex = 15
        Me.BtnSastanci.UseVisualStyleBackColor = True
        '
        'BtnPacijent
        '
        Me.BtnPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPacijent.Image = Global.iBolnica.My.Resources.Resources.Pacijent
        Me.BtnPacijent.Location = New System.Drawing.Point(219, 167)
        Me.BtnPacijent.Name = "BtnPacijent"
        Me.BtnPacijent.Size = New System.Drawing.Size(204, 86)
        Me.BtnPacijent.TabIndex = 14
        Me.BtnPacijent.UseVisualStyleBackColor = True
        '
        'BtnIzvjestaj
        '
        Me.BtnIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzvjestaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzvjestaj.Image = Global.iBolnica.My.Resources.Resources.Izvjestaji
        Me.BtnIzvjestaj.Location = New System.Drawing.Point(1280, 167)
        Me.BtnIzvjestaj.Name = "BtnIzvjestaj"
        Me.BtnIzvjestaj.Size = New System.Drawing.Size(204, 86)
        Me.BtnIzvjestaj.TabIndex = 18
        Me.BtnIzvjestaj.UseVisualStyleBackColor = True
        '
        'BtnPacijenti1
        '
        Me.BtnPacijenti1.BackColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijenti1.ForeColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.Image = Global.iBolnica.My.Resources.Resources.Pacijent_1
        Me.BtnPacijenti1.Location = New System.Drawing.Point(1, 192)
        Me.BtnPacijenti1.Name = "BtnPacijenti1"
        Me.BtnPacijenti1.Size = New System.Drawing.Size(199, 37)
        Me.BtnPacijenti1.TabIndex = 21
        Me.BtnPacijenti1.UseVisualStyleBackColor = False
        '
        'BtnUredisastanke
        '
        Me.BtnUredisastanke.BackColor = System.Drawing.Color.Teal
        Me.BtnUredisastanke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredisastanke.ForeColor = System.Drawing.Color.Teal
        Me.BtnUredisastanke.Image = Global.iBolnica.My.Resources.Resources.uredi_sastanke
        Me.BtnUredisastanke.Location = New System.Drawing.Point(1, 228)
        Me.BtnUredisastanke.Name = "BtnUredisastanke"
        Me.BtnUredisastanke.Size = New System.Drawing.Size(199, 37)
        Me.BtnUredisastanke.TabIndex = 22
        Me.BtnUredisastanke.UseVisualStyleBackColor = False
        '
        'BtnDodajrecept
        '
        Me.BtnDodajrecept.BackColor = System.Drawing.Color.Teal
        Me.BtnDodajrecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajrecept.ForeColor = System.Drawing.Color.Teal
        Me.BtnDodajrecept.Image = Global.iBolnica.My.Resources.Resources.Doda_recept
        Me.BtnDodajrecept.Location = New System.Drawing.Point(1, 264)
        Me.BtnDodajrecept.Name = "BtnDodajrecept"
        Me.BtnDodajrecept.Size = New System.Drawing.Size(199, 37)
        Me.BtnDodajrecept.TabIndex = 23
        Me.BtnDodajrecept.UseVisualStyleBackColor = False
        '
        'BtnKreveti1
        '
        Me.BtnKreveti1.BackColor = System.Drawing.Color.Teal
        Me.BtnKreveti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKreveti1.ForeColor = System.Drawing.Color.Teal
        Me.BtnKreveti1.Image = Global.iBolnica.My.Resources.Resources.kreveti_1
        Me.BtnKreveti1.Location = New System.Drawing.Point(1, 300)
        Me.BtnKreveti1.Name = "BtnKreveti1"
        Me.BtnKreveti1.Size = New System.Drawing.Size(199, 37)
        Me.BtnKreveti1.TabIndex = 24
        Me.BtnKreveti1.UseVisualStyleBackColor = False
        '
        'BtnBankakrvipogled
        '
        Me.BtnBankakrvipogled.BackColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankakrvipogled.ForeColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.Image = Global.iBolnica.My.Resources.Resources.Banka_Krvi
        Me.BtnBankakrvipogled.Location = New System.Drawing.Point(0, 336)
        Me.BtnBankakrvipogled.Name = "BtnBankakrvipogled"
        Me.BtnBankakrvipogled.Size = New System.Drawing.Size(199, 37)
        Me.BtnBankakrvipogled.TabIndex = 25
        Me.BtnBankakrvipogled.UseVisualStyleBackColor = False
        '
        'BtnDodajizvjestaj
        '
        Me.BtnDodajizvjestaj.BackColor = System.Drawing.Color.Teal
        Me.BtnDodajizvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajizvjestaj.ForeColor = System.Drawing.Color.Teal
        Me.BtnDodajizvjestaj.Image = Global.iBolnica.My.Resources.Resources.Dodaj_izvjestaj
        Me.BtnDodajizvjestaj.Location = New System.Drawing.Point(0, 372)
        Me.BtnDodajizvjestaj.Name = "BtnDodajizvjestaj"
        Me.BtnDodajizvjestaj.Size = New System.Drawing.Size(199, 37)
        Me.BtnDodajizvjestaj.TabIndex = 26
        Me.BtnDodajizvjestaj.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(219, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 454)
        Me.Panel1.TabIndex = 27
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.BackColor = System.Drawing.Color.Transparent
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Naslov.Location = New System.Drawing.Point(246, 73)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 32
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1327, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 35
        Me.BtnLogOut.Text = "Odjavi Se"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1220, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Doktor Panel"
        '
        'LblNaslov
        '
        Me.LblNaslov.AutoSize = True
        Me.LblNaslov.BackColor = System.Drawing.Color.Transparent
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.LblNaslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblNaslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNaslov.Location = New System.Drawing.Point(12, 5)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 42
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PodesavanjaBindingSource
        '
        Me.PodesavanjaBindingSource.DataMember = "podesavanja"
        Me.PodesavanjaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'PodesavanjaTableAdapter
        '
        Me.PodesavanjaTableAdapter.ClearBeforeFill = True
        '
        'DoktorLogin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1516, 774)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Naslov)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnDodajizvjestaj)
        Me.Controls.Add(Me.BtnBankakrvipogled)
        Me.Controls.Add(Me.BtnKreveti1)
        Me.Controls.Add(Me.BtnDodajrecept)
        Me.Controls.Add(Me.BtnUredisastanke)
        Me.Controls.Add(Me.BtnPacijenti1)
        Me.Controls.Add(Me.BtnIzvjestaj)
        Me.Controls.Add(Me.BtnKrv)
        Me.Controls.Add(Me.BtnBankaKrvi)
        Me.Controls.Add(Me.BtnSastanci)
        Me.Controls.Add(Me.BtnPacijent)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DoktorLogin_Form"
        Me.Text = "DoktorLogin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnKrv As System.Windows.Forms.Button
    Friend WithEvents BtnBankaKrvi As System.Windows.Forms.Button
    Friend WithEvents BtnSastanci As System.Windows.Forms.Button
    Friend WithEvents BtnPacijent As System.Windows.Forms.Button
    Friend WithEvents BtnIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents BtnPacijenti1 As System.Windows.Forms.Button
    Friend WithEvents BtnUredisastanke As System.Windows.Forms.Button
    Friend WithEvents BtnDodajrecept As System.Windows.Forms.Button
    Friend WithEvents BtnKreveti1 As System.Windows.Forms.Button
    Friend WithEvents BtnBankakrvipogled As System.Windows.Forms.Button
    Friend WithEvents BtnDodajizvjestaj As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
End Class
