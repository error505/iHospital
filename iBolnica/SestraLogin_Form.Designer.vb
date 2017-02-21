<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SestraLogin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SestraLogin_Form))
        Me.BtnKrevet = New System.Windows.Forms.Button()
        Me.BtnBankaKrvi = New System.Windows.Forms.Button()
        Me.BtnPacijent = New System.Windows.Forms.Button()
        Me.BtnIzvjestaj = New System.Windows.Forms.Button()
        Me.BtnDodajizvjestaj = New System.Windows.Forms.Button()
        Me.BtnBankakrvipogled = New System.Windows.Forms.Button()
        Me.BtnKreveti1 = New System.Windows.Forms.Button()
        Me.BtnPacijenti1 = New System.Windows.Forms.Button()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.LblNaslov = New System.Windows.Forms.Label()
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKrevet
        '
        Me.BtnKrevet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKrevet.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKrevet.Image = Global.iBolnica.My.Resources.Resources.kreveti
        Me.BtnKrevet.Location = New System.Drawing.Point(547, 135)
        Me.BtnKrevet.Name = "BtnKrevet"
        Me.BtnKrevet.Size = New System.Drawing.Size(204, 86)
        Me.BtnKrevet.TabIndex = 16
        Me.BtnKrevet.UseVisualStyleBackColor = True
        '
        'BtnBankaKrvi
        '
        Me.BtnBankaKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankaKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBankaKrvi.Image = Global.iBolnica.My.Resources.Resources.krv
        Me.BtnBankaKrvi.Location = New System.Drawing.Point(879, 135)
        Me.BtnBankaKrvi.Name = "BtnBankaKrvi"
        Me.BtnBankaKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnBankaKrvi.TabIndex = 15
        Me.BtnBankaKrvi.UseVisualStyleBackColor = True
        '
        'BtnPacijent
        '
        Me.BtnPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPacijent.Image = Global.iBolnica.My.Resources.Resources.Pacijent
        Me.BtnPacijent.Location = New System.Drawing.Point(215, 135)
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
        Me.BtnIzvjestaj.Location = New System.Drawing.Point(1194, 135)
        Me.BtnIzvjestaj.Name = "BtnIzvjestaj"
        Me.BtnIzvjestaj.Size = New System.Drawing.Size(204, 86)
        Me.BtnIzvjestaj.TabIndex = 19
        Me.BtnIzvjestaj.UseVisualStyleBackColor = True
        '
        'BtnDodajizvjestaj
        '
        Me.BtnDodajizvjestaj.BackColor = System.Drawing.Color.Teal
        Me.BtnDodajizvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajizvjestaj.ForeColor = System.Drawing.Color.Teal
        Me.BtnDodajizvjestaj.Image = Global.iBolnica.My.Resources.Resources.Dodaj_izvjestaj
        Me.BtnDodajizvjestaj.Location = New System.Drawing.Point(-1, 322)
        Me.BtnDodajizvjestaj.Name = "BtnDodajizvjestaj"
        Me.BtnDodajizvjestaj.Size = New System.Drawing.Size(199, 37)
        Me.BtnDodajizvjestaj.TabIndex = 30
        Me.BtnDodajizvjestaj.UseVisualStyleBackColor = False
        '
        'BtnBankakrvipogled
        '
        Me.BtnBankakrvipogled.BackColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankakrvipogled.ForeColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.Image = Global.iBolnica.My.Resources.Resources.Banka_Krvi
        Me.BtnBankakrvipogled.Location = New System.Drawing.Point(-1, 286)
        Me.BtnBankakrvipogled.Name = "BtnBankakrvipogled"
        Me.BtnBankakrvipogled.Size = New System.Drawing.Size(199, 37)
        Me.BtnBankakrvipogled.TabIndex = 29
        Me.BtnBankakrvipogled.UseVisualStyleBackColor = False
        '
        'BtnKreveti1
        '
        Me.BtnKreveti1.BackColor = System.Drawing.Color.Teal
        Me.BtnKreveti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKreveti1.ForeColor = System.Drawing.Color.Teal
        Me.BtnKreveti1.Image = Global.iBolnica.My.Resources.Resources.kreveti_1
        Me.BtnKreveti1.Location = New System.Drawing.Point(0, 250)
        Me.BtnKreveti1.Name = "BtnKreveti1"
        Me.BtnKreveti1.Size = New System.Drawing.Size(199, 37)
        Me.BtnKreveti1.TabIndex = 28
        Me.BtnKreveti1.UseVisualStyleBackColor = False
        '
        'BtnPacijenti1
        '
        Me.BtnPacijenti1.BackColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijenti1.ForeColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.Image = Global.iBolnica.My.Resources.Resources.Pacijent_1
        Me.BtnPacijenti1.Location = New System.Drawing.Point(0, 214)
        Me.BtnPacijenti1.Name = "BtnPacijenti1"
        Me.BtnPacijenti1.Size = New System.Drawing.Size(199, 37)
        Me.BtnPacijenti1.TabIndex = 27
        Me.BtnPacijenti1.UseVisualStyleBackColor = False
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.Location = New System.Drawing.Point(250, 67)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(215, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1249, 410)
        Me.Panel1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1233, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Sestre Panel"
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1348, 16)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 44
        Me.BtnLogOut.Text = "Odjavi Se"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'LblNaslov
        '
        Me.LblNaslov.AutoSize = True
        Me.LblNaslov.BackColor = System.Drawing.Color.Transparent
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.LblNaslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblNaslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNaslov.Location = New System.Drawing.Point(12, 6)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 46
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
        'SestraLogin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1476, 737)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Naslov)
        Me.Controls.Add(Me.BtnDodajizvjestaj)
        Me.Controls.Add(Me.BtnBankakrvipogled)
        Me.Controls.Add(Me.BtnKreveti1)
        Me.Controls.Add(Me.BtnPacijenti1)
        Me.Controls.Add(Me.BtnIzvjestaj)
        Me.Controls.Add(Me.BtnKrevet)
        Me.Controls.Add(Me.BtnBankaKrvi)
        Me.Controls.Add(Me.BtnPacijent)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SestraLogin_Form"
        Me.Text = "SestraLogin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnKrevet As System.Windows.Forms.Button
    Friend WithEvents BtnBankaKrvi As System.Windows.Forms.Button
    Friend WithEvents BtnPacijent As System.Windows.Forms.Button
    Friend WithEvents BtnIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents BtnDodajizvjestaj As System.Windows.Forms.Button
    Friend WithEvents BtnBankakrvipogled As System.Windows.Forms.Button
    Friend WithEvents BtnKreveti1 As System.Windows.Forms.Button
    Friend WithEvents BtnPacijenti1 As System.Windows.Forms.Button
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
End Class
