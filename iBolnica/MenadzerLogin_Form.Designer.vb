<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenadzerLogin_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenadzerLogin_Form))
        Me.Naslov = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnIzvjestajDijagnoza = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBankakrvipogled = New System.Windows.Forms.Button()
        Me.BtnIzvjestajDijagnoza1 = New System.Windows.Forms.Button()
        Me.LblNaslov = New System.Windows.Forms.Label()
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.Location = New System.Drawing.Point(248, 67)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1165, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Menadzment Panel"
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1327, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 48
        Me.BtnLogOut.Text = "Odjavi Se"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(219, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 410)
        Me.Panel1.TabIndex = 50
        '
        'BtnIzvjestajDijagnoza
        '
        Me.BtnIzvjestajDijagnoza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzvjestajDijagnoza.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzvjestajDijagnoza.Image = Global.iBolnica.My.Resources.Resources.PogledajUplate
        Me.BtnIzvjestajDijagnoza.Location = New System.Drawing.Point(219, 128)
        Me.BtnIzvjestajDijagnoza.Name = "BtnIzvjestajDijagnoza"
        Me.BtnIzvjestajDijagnoza.Size = New System.Drawing.Size(204, 86)
        Me.BtnIzvjestajDijagnoza.TabIndex = 51
        Me.BtnIzvjestajDijagnoza.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.iBolnica.My.Resources.Resources.Fakture
        Me.Button1.Location = New System.Drawing.Point(538, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 86)
        Me.Button1.TabIndex = 52
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBankakrvipogled
        '
        Me.BtnBankakrvipogled.BackColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankakrvipogled.ForeColor = System.Drawing.Color.Teal
        Me.BtnBankakrvipogled.Image = Global.iBolnica.My.Resources.Resources.Fakture_1
        Me.BtnBankakrvipogled.Location = New System.Drawing.Point(0, 234)
        Me.BtnBankakrvipogled.Name = "BtnBankakrvipogled"
        Me.BtnBankakrvipogled.Size = New System.Drawing.Size(199, 37)
        Me.BtnBankakrvipogled.TabIndex = 54
        Me.BtnBankakrvipogled.UseVisualStyleBackColor = False
        '
        'BtnIzvjestajDijagnoza1
        '
        Me.BtnIzvjestajDijagnoza1.BackColor = System.Drawing.Color.Teal
        Me.BtnIzvjestajDijagnoza1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzvjestajDijagnoza1.ForeColor = System.Drawing.Color.Teal
        Me.BtnIzvjestajDijagnoza1.Image = Global.iBolnica.My.Resources.Resources.uplate
        Me.BtnIzvjestajDijagnoza1.Location = New System.Drawing.Point(0, 198)
        Me.BtnIzvjestajDijagnoza1.Name = "BtnIzvjestajDijagnoza1"
        Me.BtnIzvjestajDijagnoza1.Size = New System.Drawing.Size(199, 37)
        Me.BtnIzvjestajDijagnoza1.TabIndex = 53
        Me.BtnIzvjestajDijagnoza1.UseVisualStyleBackColor = False
        '
        'LblNaslov
        '
        Me.LblNaslov.AutoSize = True
        Me.LblNaslov.BackColor = System.Drawing.Color.Transparent
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.LblNaslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblNaslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNaslov.Location = New System.Drawing.Point(12, 4)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 55
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
        'MenadzerLogin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1440, 684)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.BtnBankakrvipogled)
        Me.Controls.Add(Me.BtnIzvjestajDijagnoza1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnIzvjestajDijagnoza)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Naslov)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenadzerLogin_Form"
        Me.Text = "MenadzerLogin_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnIzvjestajDijagnoza As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnBankakrvipogled As System.Windows.Forms.Button
    Friend WithEvents BtnIzvjestajDijagnoza1 As System.Windows.Forms.Button
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
End Class
