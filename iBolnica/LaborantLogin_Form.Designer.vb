<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaborantLogin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaborantLogin_Form))
        Me.BtnIzvjestajDijagnoza = New System.Windows.Forms.Button()
        Me.BtnBankKrvi = New System.Windows.Forms.Button()
        Me.BtnDonatorKrvi = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.BtnDonatorKrvi1 = New System.Windows.Forms.Button()
        Me.BtnBankakrvipogled = New System.Windows.Forms.Button()
        Me.BtnIzvjestajDijagnoza1 = New System.Windows.Forms.Button()
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
        'BtnIzvjestajDijagnoza
        '
        Me.BtnIzvjestajDijagnoza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzvjestajDijagnoza.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzvjestajDijagnoza.Image = Global.iBolnica.My.Resources.Resources.Izvjestaj_o_diagnozi
        Me.BtnIzvjestajDijagnoza.Location = New System.Drawing.Point(217, 134)
        Me.BtnIzvjestajDijagnoza.Name = "BtnIzvjestajDijagnoza"
        Me.BtnIzvjestajDijagnoza.Size = New System.Drawing.Size(204, 86)
        Me.BtnIzvjestajDijagnoza.TabIndex = 16
        Me.BtnIzvjestajDijagnoza.UseVisualStyleBackColor = True
        '
        'BtnBankKrvi
        '
        Me.BtnBankKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBankKrvi.Image = Global.iBolnica.My.Resources.Resources.krv
        Me.BtnBankKrvi.Location = New System.Drawing.Point(531, 134)
        Me.BtnBankKrvi.Name = "BtnBankKrvi"
        Me.BtnBankKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnBankKrvi.TabIndex = 17
        Me.BtnBankKrvi.UseVisualStyleBackColor = True
        '
        'BtnDonatorKrvi
        '
        Me.BtnDonatorKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDonatorKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDonatorKrvi.Image = Global.iBolnica.My.Resources.Resources.Donatori_Krvi
        Me.BtnDonatorKrvi.Location = New System.Drawing.Point(880, 134)
        Me.BtnDonatorKrvi.Name = "BtnDonatorKrvi"
        Me.BtnDonatorKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnDonatorKrvi.TabIndex = 18
        Me.BtnDonatorKrvi.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(217, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 511)
        Me.Panel1.TabIndex = 35
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.Location = New System.Drawing.Point(248, 67)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 34
        '
        'BtnDonatorKrvi1
        '
        Me.BtnDonatorKrvi1.BackColor = System.Drawing.Color.Teal
        Me.BtnDonatorKrvi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDonatorKrvi1.ForeColor = System.Drawing.Color.Teal
        Me.BtnDonatorKrvi1.Image = Global.iBolnica.My.Resources.Resources.Donatori_Krvi_1
        Me.BtnDonatorKrvi1.Location = New System.Drawing.Point(0, 296)
        Me.BtnDonatorKrvi1.Name = "BtnDonatorKrvi1"
        Me.BtnDonatorKrvi1.Size = New System.Drawing.Size(199, 37)
        Me.BtnDonatorKrvi1.TabIndex = 38
        Me.BtnDonatorKrvi1.UseVisualStyleBackColor = False
        '
        'BtnBankakrvipogled
        '
        Me.BtnBankakrvipogled.BackColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankakrvipogled.ForeColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.Image = Global.iBolnica.My.Resources.Resources.Banka_Krvi
        Me.BtnBankakrvipogled.Location = New System.Drawing.Point(0, 260)
        Me.BtnBankakrvipogled.Name = "BtnBankakrvipogled"
        Me.BtnBankakrvipogled.Size = New System.Drawing.Size(199, 37)
        Me.BtnBankakrvipogled.TabIndex = 37
        Me.BtnBankakrvipogled.UseVisualStyleBackColor = False
        '
        'BtnIzvjestajDijagnoza1
        '
        Me.BtnIzvjestajDijagnoza1.BackColor = System.Drawing.Color.Teal
        Me.BtnIzvjestajDijagnoza1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzvjestajDijagnoza1.ForeColor = System.Drawing.Color.Teal
        Me.BtnIzvjestajDijagnoza1.Image = Global.iBolnica.My.Resources.Resources.Izvjestaj_o_diagnozi_1
        Me.BtnIzvjestajDijagnoza1.Location = New System.Drawing.Point(0, 224)
        Me.BtnIzvjestajDijagnoza1.Name = "BtnIzvjestajDijagnoza1"
        Me.BtnIzvjestajDijagnoza1.Size = New System.Drawing.Size(199, 37)
        Me.BtnIzvjestajDijagnoza1.TabIndex = 36
        Me.BtnIzvjestajDijagnoza1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1192, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Laborant Panel"
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1325, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 46
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
        Me.LblNaslov.Location = New System.Drawing.Point(12, 5)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 48
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
        'LaborantLogin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1407, 763)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnDonatorKrvi1)
        Me.Controls.Add(Me.BtnBankakrvipogled)
        Me.Controls.Add(Me.BtnIzvjestajDijagnoza1)
        Me.Controls.Add(Me.Naslov)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnDonatorKrvi)
        Me.Controls.Add(Me.BtnBankKrvi)
        Me.Controls.Add(Me.BtnIzvjestajDijagnoza)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaborantLogin_Form"
        Me.Text = "LaborantLogin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIzvjestajDijagnoza As System.Windows.Forms.Button
    Friend WithEvents BtnBankKrvi As System.Windows.Forms.Button
    Friend WithEvents BtnDonatorKrvi As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents BtnDonatorKrvi1 As System.Windows.Forms.Button
    Friend WithEvents BtnBankakrvipogled As System.Windows.Forms.Button
    Friend WithEvents BtnIzvjestajDijagnoza1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
End Class
