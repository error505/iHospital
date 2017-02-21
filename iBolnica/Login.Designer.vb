<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnIzlaz = New System.Windows.Forms.Button()
        Me.TipNaloga = New System.Windows.Forms.ComboBox()
        Me.AdminTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.adminTableAdapter()
        Me.DoktorTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.FarmaceutTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.farmaceutTableAdapter()
        Me.LaborantTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter()
        Me.MenadzmentTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.menadzmentTableAdapter()
        Me.PacijentTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.SestraTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter()
        Me.QueriesTableAdapter1 = New iBolnica.ibolnicaDataSetTableAdapters.QueriesTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblNaslov = New System.Windows.Forms.Label()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(338, 440)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(338, 479)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(273, 20)
        Me.TextBox2.TabIndex = 4
        '
        'BtnLogin
        '
        Me.BtnLogin.BackgroundImage = Global.iBolnica.My.Resources.Resources.back
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Location = New System.Drawing.Point(315, 507)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(296, 28)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Prijavi Se"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(359, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Unesite vaš e-mail i pasword"
        '
        'BtnIzlaz
        '
        Me.BtnIzlaz.BackColor = System.Drawing.Color.DarkRed
        Me.BtnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzlaz.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnIzlaz.Location = New System.Drawing.Point(858, 12)
        Me.BtnIzlaz.Name = "BtnIzlaz"
        Me.BtnIzlaz.Size = New System.Drawing.Size(95, 23)
        Me.BtnIzlaz.TabIndex = 8
        Me.BtnIzlaz.Text = "IZLAZ        X"
        Me.BtnIzlaz.UseVisualStyleBackColor = False
        '
        'TipNaloga
        '
        Me.TipNaloga.FormattingEnabled = True
        Me.TipNaloga.Items.AddRange(New Object() {"Admin", "Doktor", "Sestra", "Farmaceut", "Laborant", "Menadzer", "Pacijent"})
        Me.TipNaloga.Location = New System.Drawing.Point(315, 403)
        Me.TipNaloga.Name = "TipNaloga"
        Me.TipNaloga.Size = New System.Drawing.Size(296, 21)
        Me.TipNaloga.TabIndex = 9
        Me.TipNaloga.Text = "Tip Naloga"
        '
        'AdminTableAdapter1
        '
        Me.AdminTableAdapter1.ClearBeforeFill = True
        '
        'DoktorTableAdapter1
        '
        Me.DoktorTableAdapter1.ClearBeforeFill = True
        '
        'FarmaceutTableAdapter1
        '
        Me.FarmaceutTableAdapter1.ClearBeforeFill = True
        '
        'LaborantTableAdapter1
        '
        Me.LaborantTableAdapter1.ClearBeforeFill = True
        '
        'MenadzmentTableAdapter1
        '
        Me.MenadzmentTableAdapter1.ClearBeforeFill = True
        '
        'PacijentTableAdapter1
        '
        Me.PacijentTableAdapter1.ClearBeforeFill = True
        '
        'SestraTableAdapter1
        '
        Me.SestraTableAdapter1.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Image = Global.iBolnica.My.Resources.Resources.mail
        Me.Label5.Location = New System.Drawing.Point(310, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "     "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Image = Global.iBolnica.My.Resources.Resources.password
        Me.Label6.Location = New System.Drawing.Point(312, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "     "
        '
        'LblNaslov
        '
        Me.LblNaslov.AutoSize = True
        Me.LblNaslov.BackColor = System.Drawing.Color.Transparent
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.LblNaslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblNaslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNaslov.Location = New System.Drawing.Point(5, 5)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 42
        '
        'PodesavanjaBindingSource
        '
        Me.PodesavanjaBindingSource.DataMember = "podesavanja"
        Me.PodesavanjaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PodesavanjaTableAdapter
        '
        Me.PodesavanjaTableAdapter.ClearBeforeFill = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "adminico.png")
        Me.ImageList1.Images.SetKeyName(1, "doktorico.png")
        Me.ImageList1.Images.SetKeyName(2, "farmaceutico.png")
        Me.ImageList1.Images.SetKeyName(3, "laborantico.png")
        Me.ImageList1.Images.SetKeyName(4, "menadzerico.png")
        Me.ImageList1.Images.SetKeyName(5, "pacijentico.png")
        Me.ImageList1.Images.SetKeyName(6, "sestraico.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.iBolnica.My.Resources.Resources.adminico1
        Me.PictureBox1.Location = New System.Drawing.Point(419, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 77)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.login3
        Me.ClientSize = New System.Drawing.Size(968, 650)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TipNaloga)
        Me.Controls.Add(Me.BtnIzlaz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents AdminTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.adminTableAdapter
    Friend WithEvents DoktorTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents FarmaceutTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.farmaceutTableAdapter
    Friend WithEvents LaborantTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter
    Friend WithEvents MenadzmentTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.menadzmentTableAdapter
    Friend WithEvents PacijentTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents SestraTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter
    Friend WithEvents QueriesTableAdapter1 As iBolnica.ibolnicaDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnIzlaz As System.Windows.Forms.Button
    Friend WithEvents TipNaloga As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
