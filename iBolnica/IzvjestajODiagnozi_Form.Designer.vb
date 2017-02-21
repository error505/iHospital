<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IzvjestajODiagnozi_Form
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
        Dim Tip_izvjestajaLabel As System.Windows.Forms.Label
        Dim Tip_dokumentaLabel As System.Windows.Forms.Label
        Dim Ime_fajlaLabel As System.Windows.Forms.Label
        Dim Recept_idLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim Laborant_idLabel As System.Windows.Forms.Label
        Dim SlikaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IzvjestajODiagnozi_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.Dijagnoza_izvjestajDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Dijagnoza_izvjestajBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SlikaPictureBox = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ReceptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LaborantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNoviIzvjestaj = New System.Windows.Forms.Button()
        Me.BtnDodajIzvjestaj = New System.Windows.Forms.Button()
        Me.Tip_izvjestajaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Tip_dokumentaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ime_fajlaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Dijagnoza_izvjestajTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.dijagnoza_izvjestajTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.Dijagnoza_izvjestajBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.ReceptTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.receptTableAdapter()
        Me.LaborantTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Tip_izvjestajaLabel = New System.Windows.Forms.Label()
        Tip_dokumentaLabel = New System.Windows.Forms.Label()
        Ime_fajlaLabel = New System.Windows.Forms.Label()
        Recept_idLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        Laborant_idLabel = New System.Windows.Forms.Label()
        SlikaLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dijagnoza_izvjestajDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dijagnoza_izvjestajBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SlikaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tip_izvjestajaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tip_dokumentaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ime_fajlaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dijagnoza_izvjestajBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dijagnoza_izvjestajBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tip_izvjestajaLabel
        '
        Tip_izvjestajaLabel.AutoSize = True
        Tip_izvjestajaLabel.Location = New System.Drawing.Point(3, 61)
        Tip_izvjestajaLabel.Name = "Tip_izvjestajaLabel"
        Tip_izvjestajaLabel.Size = New System.Drawing.Size(71, 13)
        Tip_izvjestajaLabel.TabIndex = 2
        Tip_izvjestajaLabel.Text = "Tip izvjestaja:"
        '
        'Tip_dokumentaLabel
        '
        Tip_dokumentaLabel.AutoSize = True
        Tip_dokumentaLabel.Location = New System.Drawing.Point(3, 87)
        Tip_dokumentaLabel.Name = "Tip_dokumentaLabel"
        Tip_dokumentaLabel.Size = New System.Drawing.Size(81, 13)
        Tip_dokumentaLabel.TabIndex = 4
        Tip_dokumentaLabel.Text = "Tip dokumenta:"
        '
        'Ime_fajlaLabel
        '
        Ime_fajlaLabel.AutoSize = True
        Ime_fajlaLabel.Location = New System.Drawing.Point(3, 113)
        Ime_fajlaLabel.Name = "Ime_fajlaLabel"
        Ime_fajlaLabel.Size = New System.Drawing.Size(49, 13)
        Ime_fajlaLabel.TabIndex = 6
        Ime_fajlaLabel.Text = "Ime fajla:"
        '
        'Recept_idLabel
        '
        Recept_idLabel.AutoSize = True
        Recept_idLabel.Location = New System.Drawing.Point(3, 139)
        Recept_idLabel.Name = "Recept_idLabel"
        Recept_idLabel.Size = New System.Drawing.Size(45, 13)
        Recept_idLabel.TabIndex = 8
        Recept_idLabel.Text = "Recept:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(3, 165)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 10
        OpisLabel.Text = "Opis:"
        '
        'Laborant_idLabel
        '
        Laborant_idLabel.AutoSize = True
        Laborant_idLabel.Location = New System.Drawing.Point(3, 188)
        Laborant_idLabel.Name = "Laborant_idLabel"
        Laborant_idLabel.Size = New System.Drawing.Size(49, 13)
        Laborant_idLabel.TabIndex = 14
        Laborant_idLabel.Text = "Laborant"
        '
        'SlikaLabel
        '
        SlikaLabel.AutoSize = True
        SlikaLabel.Location = New System.Drawing.Point(6, 210)
        SlikaLabel.Name = "SlikaLabel"
        SlikaLabel.Size = New System.Drawing.Size(33, 13)
        SlikaLabel.TabIndex = 61
        SlikaLabel.Text = "Slika:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1152, 460)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.Dijagnoza_izvjestajDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1144, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Izvjestaja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(1054, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 78
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(1098, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 77
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'Dijagnoza_izvjestajDataGridView
        '
        Me.Dijagnoza_izvjestajDataGridView.AllowUserToAddRows = False
        Me.Dijagnoza_izvjestajDataGridView.AutoGenerateColumns = False
        Me.Dijagnoza_izvjestajDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dijagnoza_izvjestajDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.Dijagnoza_izvjestajDataGridView.DataSource = Me.Dijagnoza_izvjestajBindingSource
        Me.Dijagnoza_izvjestajDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dijagnoza_izvjestajDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Dijagnoza_izvjestajDataGridView.Name = "Dijagnoza_izvjestajDataGridView"
        Me.Dijagnoza_izvjestajDataGridView.Size = New System.Drawing.Size(1138, 428)
        Me.Dijagnoza_izvjestajDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dijagnoza_izvjestaj_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Dijagnoze"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tip_izvjestaja"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tip izvjestaja"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tip_dokumenta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tip dokumenta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ime_fajla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ime fajla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "recept_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID Recepta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "laborant_id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID Laboranta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "slika"
        Me.DataGridViewImageColumn1.HeaderText = "Slika"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.MinimumWidth = 300
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 300
        '
        'Dijagnoza_izvjestajBindingSource
        '
        Me.Dijagnoza_izvjestajBindingSource.DataMember = "dijagnoza_izvjestaj"
        Me.Dijagnoza_izvjestajBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(SlikaLabel)
        Me.TabPage2.Controls.Add(Me.SlikaPictureBox)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BtnNoviIzvjestaj)
        Me.TabPage2.Controls.Add(Me.BtnDodajIzvjestaj)
        Me.TabPage2.Controls.Add(Tip_izvjestajaLabel)
        Me.TabPage2.Controls.Add(Me.Tip_izvjestajaTextEdit)
        Me.TabPage2.Controls.Add(Tip_dokumentaLabel)
        Me.TabPage2.Controls.Add(Me.Tip_dokumentaTextEdit)
        Me.TabPage2.Controls.Add(Ime_fajlaLabel)
        Me.TabPage2.Controls.Add(Me.Ime_fajlaTextEdit)
        Me.TabPage2.Controls.Add(Recept_idLabel)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Controls.Add(Laborant_idLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1144, 434)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Izvjestaj"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Izaberi Sliku"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 20)
        Me.TextBox1.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(245, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Trazi sliku"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SlikaPictureBox
        '
        Me.SlikaPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Dijagnoza_izvjestajBindingSource, "slika", True))
        Me.SlikaPictureBox.Location = New System.Drawing.Point(115, 256)
        Me.SlikaPictureBox.MaximumSize = New System.Drawing.Size(205, 109)
        Me.SlikaPictureBox.MinimumSize = New System.Drawing.Size(205, 109)
        Me.SlikaPictureBox.Name = "SlikaPictureBox"
        Me.SlikaPictureBox.Size = New System.Drawing.Size(205, 109)
        Me.SlikaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SlikaPictureBox.TabIndex = 62
        Me.SlikaPictureBox.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Dijagnoza_izvjestajBindingSource, "recept_id", True))
        Me.ComboBox2.DataSource = Me.ReceptBindingSource
        Me.ComboBox2.DisplayMember = "opis"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(115, 135)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 61
        Me.ComboBox2.ValueMember = "recept_id"
        '
        'ReceptBindingSource
        '
        Me.ReceptBindingSource.DataMember = "recept"
        Me.ReceptBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Dijagnoza_izvjestajBindingSource, "laborant_id", True))
        Me.ComboBox1.DataSource = Me.LaborantBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 60
        Me.ComboBox1.ValueMember = "laborant_id"
        '
        'LaborantBindingSource
        '
        Me.LaborantBindingSource.DataMember = "laborant"
        Me.LaborantBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnNoviIzvjestaj
        '
        Me.BtnNoviIzvjestaj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviIzvjestaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNoviIzvjestaj.Location = New System.Drawing.Point(6, 17)
        Me.BtnNoviIzvjestaj.Name = "BtnNoviIzvjestaj"
        Me.BtnNoviIzvjestaj.Size = New System.Drawing.Size(141, 23)
        Me.BtnNoviIzvjestaj.TabIndex = 59
        Me.BtnNoviIzvjestaj.Text = "Novi Izvjestaj"
        Me.BtnNoviIzvjestaj.UseVisualStyleBackColor = False
        '
        'BtnDodajIzvjestaj
        '
        Me.BtnDodajIzvjestaj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajIzvjestaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajIzvjestaj.Location = New System.Drawing.Point(115, 371)
        Me.BtnDodajIzvjestaj.Name = "BtnDodajIzvjestaj"
        Me.BtnDodajIzvjestaj.Size = New System.Drawing.Size(112, 28)
        Me.BtnDodajIzvjestaj.TabIndex = 58
        Me.BtnDodajIzvjestaj.Text = "Dodaj Izvjestaj"
        Me.BtnDodajIzvjestaj.UseVisualStyleBackColor = False
        '
        'Tip_izvjestajaTextEdit
        '
        Me.Tip_izvjestajaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Dijagnoza_izvjestajBindingSource, "tip_izvjestaja", True))
        Me.Tip_izvjestajaTextEdit.Location = New System.Drawing.Point(115, 58)
        Me.Tip_izvjestajaTextEdit.Name = "Tip_izvjestajaTextEdit"
        Me.Tip_izvjestajaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Tip_izvjestajaTextEdit.TabIndex = 3
        '
        'Tip_dokumentaTextEdit
        '
        Me.Tip_dokumentaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Dijagnoza_izvjestajBindingSource, "tip_dokumenta", True))
        Me.Tip_dokumentaTextEdit.Location = New System.Drawing.Point(115, 84)
        Me.Tip_dokumentaTextEdit.Name = "Tip_dokumentaTextEdit"
        Me.Tip_dokumentaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Tip_dokumentaTextEdit.TabIndex = 5
        '
        'Ime_fajlaTextEdit
        '
        Me.Ime_fajlaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Dijagnoza_izvjestajBindingSource, "ime_fajla", True))
        Me.Ime_fajlaTextEdit.Location = New System.Drawing.Point(115, 110)
        Me.Ime_fajlaTextEdit.Name = "Ime_fajlaTextEdit"
        Me.Ime_fajlaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Ime_fajlaTextEdit.TabIndex = 7
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Dijagnoza_izvjestajBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(115, 162)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 11
        '
        'Dijagnoza_izvjestajTableAdapter
        '
        Me.Dijagnoza_izvjestajTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banka_krviTableAdapter = Nothing
        Me.TableAdapterManager.dijagnoza_izvjestajTableAdapter = Me.Dijagnoza_izvjestajTableAdapter
        Me.TableAdapterManager.dodjela_krevetaTableAdapter = Nothing
        Me.TableAdapterManager.doktorTableAdapter = Nothing
        Me.TableAdapterManager.donator_krviTableAdapter = Nothing
        Me.TableAdapterManager.email_templateTableAdapter = Nothing
        Me.TableAdapterManager.fakturaTableAdapter = Nothing
        Me.TableAdapterManager.farmaceutTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_o_rodjenjuTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_operacijaTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_smrtTableAdapter = Nothing
        Me.TableAdapterManager.izvjestajTableAdapter = Nothing
        Me.TableAdapterManager.kategorije_lijekovaTableAdapter = Nothing
        Me.TableAdapterManager.krevetTableAdapter = Nothing
        Me.TableAdapterManager.laborantTableAdapter = Nothing
        Me.TableAdapterManager.lijekoviTableAdapter = Nothing
        Me.TableAdapterManager.menadzmentTableAdapter = Nothing
        Me.TableAdapterManager.obavjestenjaTableAdapter = Nothing
        Me.TableAdapterManager.odjeljenjeTableAdapter = Nothing
        Me.TableAdapterManager.pacijentTableAdapter = Nothing
        Me.TableAdapterManager.placanjeTableAdapter = Nothing
        Me.TableAdapterManager.podesavanjaTableAdapter = Nothing
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dijagnoza_izvjestajBindingNavigator
        '
        Me.Dijagnoza_izvjestajBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Dijagnoza_izvjestajBindingNavigator.BindingSource = Me.Dijagnoza_izvjestajBindingSource
        Me.Dijagnoza_izvjestajBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Dijagnoza_izvjestajBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Dijagnoza_izvjestajBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Dijagnoza_izvjestajBindingNavigatorSaveItem})
        Me.Dijagnoza_izvjestajBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Dijagnoza_izvjestajBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Dijagnoza_izvjestajBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Dijagnoza_izvjestajBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Dijagnoza_izvjestajBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Dijagnoza_izvjestajBindingNavigator.Name = "Dijagnoza_izvjestajBindingNavigator"
        Me.Dijagnoza_izvjestajBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Dijagnoza_izvjestajBindingNavigator.Size = New System.Drawing.Size(1079, 25)
        Me.Dijagnoza_izvjestajBindingNavigator.TabIndex = 1
        Me.Dijagnoza_izvjestajBindingNavigator.Text = "BindingNavigator1"
        Me.Dijagnoza_izvjestajBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Dijagnoza_izvjestajBindingNavigatorSaveItem
        '
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem.Image = CType(resources.GetObject("Dijagnoza_izvjestajBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem.Name = "Dijagnoza_izvjestajBindingNavigatorSaveItem"
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Dijagnoza_izvjestajBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(1102, 1)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 74
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'ReceptTableAdapter
        '
        Me.ReceptTableAdapter.ClearBeforeFill = True
        '
        'LaborantTableAdapter
        '
        Me.LaborantTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'IzvjestajODiagnozi_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 478)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.Dijagnoza_izvjestajBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IzvjestajODiagnozi_Form"
        Me.Text = "IzvjestajODiagnozi_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dijagnoza_izvjestajDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dijagnoza_izvjestajBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.SlikaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tip_izvjestajaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tip_dokumentaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ime_fajlaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dijagnoza_izvjestajBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dijagnoza_izvjestajBindingNavigator.ResumeLayout(False)
        Me.Dijagnoza_izvjestajBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents Dijagnoza_izvjestajBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dijagnoza_izvjestajTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.dijagnoza_izvjestajTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Dijagnoza_izvjestajBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Dijagnoza_izvjestajBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dijagnoza_izvjestajDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tip_izvjestajaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tip_dokumentaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ime_fajlaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNoviIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents BtnDodajIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ReceptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceptTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.receptTableAdapter
    Friend WithEvents LaborantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LaborantTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SlikaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
End Class
