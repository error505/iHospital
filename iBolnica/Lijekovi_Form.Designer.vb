<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lijekovi_Form
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
        Dim ImeLabel As System.Windows.Forms.Label
        Dim Lijek_kategorija_idLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim CijenaLabel As System.Windows.Forms.Label
        Dim ProizvodjacLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ImeLabel1 As System.Windows.Forms.Label
        Dim OpisLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lijekovi_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.LijekoviDataGridView = New System.Windows.Forms.DataGridView()
        Me.LijekoviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnNovLijek = New System.Windows.Forms.Button()
        Me.BtnDodajLijek = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.KategorijelijekovaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CijenaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProizvodjacTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnKategorija = New System.Windows.Forms.Button()
        Me.BtnDodaj = New System.Windows.Forms.Button()
        Me.ImeTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LijekoviTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.lijekoviTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.Kategorije_lijekovaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.kategorije_lijekovaTableAdapter()
        Me.LijekoviBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LijekoviBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImeLabel = New System.Windows.Forms.Label()
        Lijek_kategorija_idLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        CijenaLabel = New System.Windows.Forms.Label()
        ProizvodjacLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ImeLabel1 = New System.Windows.Forms.Label()
        OpisLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LijekoviDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LijekoviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.KategorijelijekovaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CijenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProizvodjacTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ImeTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LijekoviBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LijekoviBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(6, 49)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(58, 13)
        ImeLabel.TabIndex = 2
        ImeLabel.Text = "Ime Lijeka:"
        '
        'Lijek_kategorija_idLabel
        '
        Lijek_kategorija_idLabel.AutoSize = True
        Lijek_kategorija_idLabel.Location = New System.Drawing.Point(6, 75)
        Lijek_kategorija_idLabel.Name = "Lijek_kategorija_idLabel"
        Lijek_kategorija_idLabel.Size = New System.Drawing.Size(81, 13)
        Lijek_kategorija_idLabel.TabIndex = 4
        Lijek_kategorija_idLabel.Text = "Lijek kategorija:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(6, 101)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 6
        OpisLabel.Text = "Opis:"
        '
        'CijenaLabel
        '
        CijenaLabel.AutoSize = True
        CijenaLabel.Location = New System.Drawing.Point(6, 127)
        CijenaLabel.Name = "CijenaLabel"
        CijenaLabel.Size = New System.Drawing.Size(39, 13)
        CijenaLabel.TabIndex = 8
        CijenaLabel.Text = "Cijena:"
        '
        'ProizvodjacLabel
        '
        ProizvodjacLabel.AutoSize = True
        ProizvodjacLabel.Location = New System.Drawing.Point(6, 153)
        ProizvodjacLabel.Name = "ProizvodjacLabel"
        ProizvodjacLabel.Size = New System.Drawing.Size(65, 13)
        ProizvodjacLabel.TabIndex = 10
        ProizvodjacLabel.Text = "Proizvodjac:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(6, 179)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 12
        StatusLabel.Text = "Status:"
        '
        'ImeLabel1
        '
        ImeLabel1.AutoSize = True
        ImeLabel1.Location = New System.Drawing.Point(11, 48)
        ImeLabel1.Name = "ImeLabel1"
        ImeLabel1.Size = New System.Drawing.Size(77, 13)
        ImeLabel1.TabIndex = 2
        ImeLabel1.Text = "Ime Kategorije:"
        '
        'OpisLabel1
        '
        OpisLabel1.AutoSize = True
        OpisLabel1.Location = New System.Drawing.Point(11, 74)
        OpisLabel1.Name = "OpisLabel1"
        OpisLabel1.Size = New System.Drawing.Size(31, 13)
        OpisLabel1.TabIndex = 4
        OpisLabel1.Text = "Opis:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(847, 266)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.LijekoviDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(839, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Lijekova"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(751, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 36
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(795, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 35
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'LijekoviDataGridView
        '
        Me.LijekoviDataGridView.AllowUserToAddRows = False
        Me.LijekoviDataGridView.AutoGenerateColumns = False
        Me.LijekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LijekoviDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.LijekoviDataGridView.DataSource = Me.LijekoviBindingSource
        Me.LijekoviDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LijekoviDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.LijekoviDataGridView.Name = "LijekoviDataGridView"
        Me.LijekoviDataGridView.Size = New System.Drawing.Size(833, 234)
        Me.LijekoviDataGridView.TabIndex = 0
        '
        'LijekoviBindingSource
        '
        Me.LijekoviBindingSource.DataMember = "lijekovi"
        Me.LijekoviBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnNovLijek)
        Me.TabPage2.Controls.Add(Me.BtnDodajLijek)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(ImeLabel)
        Me.TabPage2.Controls.Add(Me.ImeTextEdit)
        Me.TabPage2.Controls.Add(Lijek_kategorija_idLabel)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Controls.Add(CijenaLabel)
        Me.TabPage2.Controls.Add(Me.CijenaTextEdit)
        Me.TabPage2.Controls.Add(ProizvodjacLabel)
        Me.TabPage2.Controls.Add(Me.ProizvodjacTextEdit)
        Me.TabPage2.Controls.Add(StatusLabel)
        Me.TabPage2.Controls.Add(Me.StatusTextEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(839, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Lijek"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnNovLijek
        '
        Me.BtnNovLijek.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovLijek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovLijek.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovLijek.Location = New System.Drawing.Point(9, 17)
        Me.BtnNovLijek.Name = "BtnNovLijek"
        Me.BtnNovLijek.Size = New System.Drawing.Size(104, 23)
        Me.BtnNovLijek.TabIndex = 23
        Me.BtnNovLijek.Text = "Novi Lijek"
        Me.BtnNovLijek.UseVisualStyleBackColor = False
        '
        'BtnDodajLijek
        '
        Me.BtnDodajLijek.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajLijek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajLijek.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajLijek.Location = New System.Drawing.Point(100, 202)
        Me.BtnDodajLijek.Name = "BtnDodajLijek"
        Me.BtnDodajLijek.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajLijek.TabIndex = 22
        Me.BtnDodajLijek.Text = "Dodaj Lijek"
        Me.BtnDodajLijek.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LijekoviBindingSource, "lijek_kategorija_id", True))
        Me.ComboBox1.DataSource = Me.KategorijelijekovaBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(100, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "lijek_kategorija_id"
        '
        'KategorijelijekovaBindingSource
        '
        Me.KategorijelijekovaBindingSource.DataMember = "kategorije_lijekova"
        Me.KategorijelijekovaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LijekoviBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(100, 46)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 3
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LijekoviBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(100, 98)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 7
        '
        'CijenaTextEdit
        '
        Me.CijenaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LijekoviBindingSource, "cijena", True))
        Me.CijenaTextEdit.Location = New System.Drawing.Point(100, 124)
        Me.CijenaTextEdit.Name = "CijenaTextEdit"
        Me.CijenaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CijenaTextEdit.TabIndex = 9
        '
        'ProizvodjacTextEdit
        '
        Me.ProizvodjacTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LijekoviBindingSource, "proizvodjac", True))
        Me.ProizvodjacTextEdit.Location = New System.Drawing.Point(100, 150)
        Me.ProizvodjacTextEdit.Name = "ProizvodjacTextEdit"
        Me.ProizvodjacTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ProizvodjacTextEdit.TabIndex = 11
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LijekoviBindingSource, "status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(100, 176)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextEdit.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnKategorija)
        Me.TabPage3.Controls.Add(Me.BtnDodaj)
        Me.TabPage3.Controls.Add(ImeLabel1)
        Me.TabPage3.Controls.Add(Me.ImeTextEdit1)
        Me.TabPage3.Controls.Add(OpisLabel1)
        Me.TabPage3.Controls.Add(Me.OpisTextEdit1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(839, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "+ Dodaj Kategoriju LIjeka"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BtnKategorija
        '
        Me.BtnKategorija.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKategorija.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKategorija.Location = New System.Drawing.Point(14, 16)
        Me.BtnKategorija.Name = "BtnKategorija"
        Me.BtnKategorija.Size = New System.Drawing.Size(104, 23)
        Me.BtnKategorija.TabIndex = 25
        Me.BtnKategorija.Text = "Nova Kategorija"
        Me.BtnKategorija.UseVisualStyleBackColor = False
        '
        'BtnDodaj
        '
        Me.BtnDodaj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodaj.Location = New System.Drawing.Point(105, 115)
        Me.BtnDodaj.Name = "BtnDodaj"
        Me.BtnDodaj.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodaj.TabIndex = 24
        Me.BtnDodaj.Text = "Dodaj Kategoriju"
        Me.BtnDodaj.UseVisualStyleBackColor = False
        '
        'ImeTextEdit1
        '
        Me.ImeTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KategorijelijekovaBindingSource, "ime", True))
        Me.ImeTextEdit1.Location = New System.Drawing.Point(105, 45)
        Me.ImeTextEdit1.Name = "ImeTextEdit1"
        Me.ImeTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit1.TabIndex = 3
        '
        'OpisTextEdit1
        '
        Me.OpisTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KategorijelijekovaBindingSource, "opis", True))
        Me.OpisTextEdit1.Location = New System.Drawing.Point(105, 71)
        Me.OpisTextEdit1.Name = "OpisTextEdit1"
        Me.OpisTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit1.TabIndex = 5
        '
        'LijekoviTableAdapter
        '
        Me.LijekoviTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banka_krviTableAdapter = Nothing
        Me.TableAdapterManager.dijagnoza_izvjestajTableAdapter = Nothing
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
        Me.TableAdapterManager.kategorije_lijekovaTableAdapter = Me.Kategorije_lijekovaTableAdapter
        Me.TableAdapterManager.krevetTableAdapter = Nothing
        Me.TableAdapterManager.laborantTableAdapter = Nothing
        Me.TableAdapterManager.lijekoviTableAdapter = Me.LijekoviTableAdapter
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
        'Kategorije_lijekovaTableAdapter
        '
        Me.Kategorije_lijekovaTableAdapter.ClearBeforeFill = True
        '
        'LijekoviBindingNavigator
        '
        Me.LijekoviBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LijekoviBindingNavigator.BindingSource = Me.LijekoviBindingSource
        Me.LijekoviBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LijekoviBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LijekoviBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LijekoviBindingNavigatorSaveItem})
        Me.LijekoviBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LijekoviBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LijekoviBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LijekoviBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LijekoviBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LijekoviBindingNavigator.Name = "LijekoviBindingNavigator"
        Me.LijekoviBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LijekoviBindingNavigator.Size = New System.Drawing.Size(853, 25)
        Me.LijekoviBindingNavigator.TabIndex = 1
        Me.LijekoviBindingNavigator.Text = "BindingNavigator1"
        Me.LijekoviBindingNavigator.Visible = False
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
        'LijekoviBindingNavigatorSaveItem
        '
        Me.LijekoviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LijekoviBindingNavigatorSaveItem.Image = CType(resources.GetObject("LijekoviBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LijekoviBindingNavigatorSaveItem.Name = "LijekoviBindingNavigatorSaveItem"
        Me.LijekoviBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LijekoviBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(807, 0)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 34
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "lijek_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Lijeka"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ime Lijeka"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lijek_kategorija_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID Kategorije Lijeka"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Opis Lijeka"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cijena"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cijena"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "proizvodjac"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Proizvodjac"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Lijekovi_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 273)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.LijekoviBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lijekovi_Form"
        Me.Text = "Lijekovi_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.LijekoviDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LijekoviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.KategorijelijekovaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CijenaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProizvodjacTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ImeTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LijekoviBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LijekoviBindingNavigator.ResumeLayout(False)
        Me.LijekoviBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents LijekoviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LijekoviTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.lijekoviTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LijekoviBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LijekoviBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LijekoviDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CijenaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProizvodjacTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Kategorije_lijekovaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.kategorije_lijekovaTableAdapter
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents KategorijelijekovaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnNovLijek As System.Windows.Forms.Button
    Friend WithEvents BtnDodajLijek As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents BtnKategorija As System.Windows.Forms.Button
    Friend WithEvents BtnDodaj As System.Windows.Forms.Button
    Friend WithEvents ImeTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
