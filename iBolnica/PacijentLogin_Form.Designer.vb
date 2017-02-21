<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacijentLogin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PacijentLogin_Form))
        Me.BtnRecept = New System.Windows.Forms.Button()
        Me.BtnBankaKrvi = New System.Windows.Forms.Button()
        Me.BtnSastanci = New System.Windows.Forms.Button()
        Me.Doktor = New System.Windows.Forms.Button()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.BtnUredisastanke = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'BtnRecept
        '
        Me.BtnRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecept.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRecept.Image = Global.iBolnica.My.Resources.Resources.Recepti
        Me.BtnRecept.Location = New System.Drawing.Point(962, 145)
        Me.BtnRecept.Name = "BtnRecept"
        Me.BtnRecept.Size = New System.Drawing.Size(204, 86)
        Me.BtnRecept.TabIndex = 20
        Me.BtnRecept.UseVisualStyleBackColor = True
        '
        'BtnBankaKrvi
        '
        Me.BtnBankaKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankaKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBankaKrvi.Image = Global.iBolnica.My.Resources.Resources.krv
        Me.BtnBankaKrvi.Location = New System.Drawing.Point(720, 145)
        Me.BtnBankaKrvi.Name = "BtnBankaKrvi"
        Me.BtnBankaKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnBankaKrvi.TabIndex = 19
        Me.BtnBankaKrvi.UseVisualStyleBackColor = True
        '
        'BtnSastanci
        '
        Me.BtnSastanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSastanci.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSastanci.Image = Global.iBolnica.My.Resources.Resources.Sastanci
        Me.BtnSastanci.Location = New System.Drawing.Point(474, 145)
        Me.BtnSastanci.Name = "BtnSastanci"
        Me.BtnSastanci.Size = New System.Drawing.Size(205, 86)
        Me.BtnSastanci.TabIndex = 18
        Me.BtnSastanci.UseVisualStyleBackColor = True
        '
        'Doktor
        '
        Me.Doktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Doktor.ForeColor = System.Drawing.Color.Transparent
        Me.Doktor.Image = Global.iBolnica.My.Resources.Resources.Doktor
        Me.Doktor.Location = New System.Drawing.Point(233, 145)
        Me.Doktor.Name = "Doktor"
        Me.Doktor.Size = New System.Drawing.Size(205, 86)
        Me.Doktor.TabIndex = 21
        Me.Doktor.UseVisualStyleBackColor = True
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.Location = New System.Drawing.Point(252, 71)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 33
        '
        'BtnUredisastanke
        '
        Me.BtnUredisastanke.BackColor = System.Drawing.Color.Teal
        Me.BtnUredisastanke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredisastanke.ForeColor = System.Drawing.Color.Teal
        Me.BtnUredisastanke.Image = Global.iBolnica.My.Resources.Resources.pogledaj_sastanke
        Me.BtnUredisastanke.Location = New System.Drawing.Point(0, 182)
        Me.BtnUredisastanke.Name = "BtnUredisastanke"
        Me.BtnUredisastanke.Size = New System.Drawing.Size(199, 37)
        Me.BtnUredisastanke.TabIndex = 34
        Me.BtnUredisastanke.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(233, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 410)
        Me.Panel1.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Image = Global.iBolnica.My.Resources.Resources.Pogledaj_recept
        Me.Button1.Location = New System.Drawing.Point(0, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 37)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Image = Global.iBolnica.My.Resources.Resources.Pogledaj_Doktora
        Me.Button2.Location = New System.Drawing.Point(0, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Teal
        Me.Button3.Image = Global.iBolnica.My.Resources.Resources.Banka_Krvi
        Me.Button3.Location = New System.Drawing.Point(0, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 37)
        Me.Button3.TabIndex = 38
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(252, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1220, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Pacijent Panel"
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1335, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 42
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
        Me.LblNaslov.Location = New System.Drawing.Point(12, 3)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 44
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
        'PacijentLogin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1444, 692)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnUredisastanke)
        Me.Controls.Add(Me.Naslov)
        Me.Controls.Add(Me.Doktor)
        Me.Controls.Add(Me.BtnRecept)
        Me.Controls.Add(Me.BtnBankaKrvi)
        Me.Controls.Add(Me.BtnSastanci)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PacijentLogin_Form"
        Me.Text = "PacijentLogin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRecept As System.Windows.Forms.Button
    Friend WithEvents BtnBankaKrvi As System.Windows.Forms.Button
    Friend WithEvents BtnSastanci As System.Windows.Forms.Button
    Friend WithEvents Doktor As System.Windows.Forms.Button
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents BtnUredisastanke As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
End Class
