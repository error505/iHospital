<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Placanje_Form
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
        Dim Tip_placanjeLabel As System.Windows.Forms.Label
        Dim Transakcija_idLabel As System.Windows.Forms.Label
        Dim Faktura_idLabel As System.Windows.Forms.Label
        Dim Pacijent_idLabel As System.Windows.Forms.Label
        Dim MetodaLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim KolicinaLabel As System.Windows.Forms.Label
        Dim VrijemeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Placanje_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.PlacanjeDataGridView = New System.Windows.Forms.DataGridView()
        Me.PlacanjeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnNovoPlacanje = New System.Windows.Forms.Button()
        Me.BtnDodajUplatu = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FakturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tip_placanjeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Transakcija_idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MetodaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KolicinaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.VrijemeSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PlacanjeTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.placanjeTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.FakturaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.fakturaTableAdapter()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.PlacanjeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PlacanjeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Tip_placanjeLabel = New System.Windows.Forms.Label()
        Transakcija_idLabel = New System.Windows.Forms.Label()
        Faktura_idLabel = New System.Windows.Forms.Label()
        Pacijent_idLabel = New System.Windows.Forms.Label()
        MetodaLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        KolicinaLabel = New System.Windows.Forms.Label()
        VrijemeLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PlacanjeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlacanjeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FakturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tip_placanjeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transakcija_idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetodaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KolicinaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlacanjeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlacanjeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tip_placanjeLabel
        '
        Tip_placanjeLabel.AutoSize = True
        Tip_placanjeLabel.Location = New System.Drawing.Point(3, 47)
        Tip_placanjeLabel.Name = "Tip_placanjeLabel"
        Tip_placanjeLabel.Size = New System.Drawing.Size(68, 13)
        Tip_placanjeLabel.TabIndex = 2
        Tip_placanjeLabel.Text = "Tip placanje:"
        '
        'Transakcija_idLabel
        '
        Transakcija_idLabel.AutoSize = True
        Transakcija_idLabel.Location = New System.Drawing.Point(3, 73)
        Transakcija_idLabel.Name = "Transakcija_idLabel"
        Transakcija_idLabel.Size = New System.Drawing.Size(76, 13)
        Transakcija_idLabel.TabIndex = 4
        Transakcija_idLabel.Text = "Transakcija id:"
        '
        'Faktura_idLabel
        '
        Faktura_idLabel.AutoSize = True
        Faktura_idLabel.Location = New System.Drawing.Point(3, 99)
        Faktura_idLabel.Name = "Faktura_idLabel"
        Faktura_idLabel.Size = New System.Drawing.Size(46, 13)
        Faktura_idLabel.TabIndex = 6
        Faktura_idLabel.Text = "Faktura:"
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(3, 125)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel.TabIndex = 8
        Pacijent_idLabel.Text = "Pacijent:"
        '
        'MetodaLabel
        '
        MetodaLabel.AutoSize = True
        MetodaLabel.Location = New System.Drawing.Point(3, 151)
        MetodaLabel.Name = "MetodaLabel"
        MetodaLabel.Size = New System.Drawing.Size(46, 13)
        MetodaLabel.TabIndex = 10
        MetodaLabel.Text = "Metoda:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(3, 177)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 12
        OpisLabel.Text = "Opis:"
        '
        'KolicinaLabel
        '
        KolicinaLabel.AutoSize = True
        KolicinaLabel.Location = New System.Drawing.Point(3, 203)
        KolicinaLabel.Name = "KolicinaLabel"
        KolicinaLabel.Size = New System.Drawing.Size(47, 13)
        KolicinaLabel.TabIndex = 14
        KolicinaLabel.Text = "Kolicina:"
        '
        'VrijemeLabel
        '
        VrijemeLabel.AutoSize = True
        VrijemeLabel.Location = New System.Drawing.Point(3, 229)
        VrijemeLabel.Name = "VrijemeLabel"
        VrijemeLabel.Size = New System.Drawing.Size(44, 13)
        VrijemeLabel.TabIndex = 16
        VrijemeLabel.Text = "Vrijeme:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1072, 329)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.PlacanjeDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1064, 303)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Uplata"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(963, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 34
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(1007, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 33
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'PlacanjeDataGridView
        '
        Me.PlacanjeDataGridView.AllowUserToAddRows = False
        Me.PlacanjeDataGridView.AutoGenerateColumns = False
        Me.PlacanjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlacanjeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PlacanjeDataGridView.DataSource = Me.PlacanjeBindingSource
        Me.PlacanjeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlacanjeDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PlacanjeDataGridView.Name = "PlacanjeDataGridView"
        Me.PlacanjeDataGridView.Size = New System.Drawing.Size(1058, 297)
        Me.PlacanjeDataGridView.TabIndex = 0
        '
        'PlacanjeBindingSource
        '
        Me.PlacanjeBindingSource.DataMember = "placanje"
        Me.PlacanjeBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnNovoPlacanje)
        Me.TabPage2.Controls.Add(Me.BtnDodajUplatu)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Tip_placanjeLabel)
        Me.TabPage2.Controls.Add(Me.Tip_placanjeTextEdit)
        Me.TabPage2.Controls.Add(Transakcija_idLabel)
        Me.TabPage2.Controls.Add(Me.Transakcija_idTextEdit)
        Me.TabPage2.Controls.Add(Faktura_idLabel)
        Me.TabPage2.Controls.Add(Pacijent_idLabel)
        Me.TabPage2.Controls.Add(MetodaLabel)
        Me.TabPage2.Controls.Add(Me.MetodaTextEdit)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Controls.Add(KolicinaLabel)
        Me.TabPage2.Controls.Add(Me.KolicinaSpinEdit)
        Me.TabPage2.Controls.Add(VrijemeLabel)
        Me.TabPage2.Controls.Add(Me.VrijemeSpinEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1064, 303)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Uplatu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnNovoPlacanje
        '
        Me.BtnNovoPlacanje.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovoPlacanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovoPlacanje.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovoPlacanje.Location = New System.Drawing.Point(6, 15)
        Me.BtnNovoPlacanje.Name = "BtnNovoPlacanje"
        Me.BtnNovoPlacanje.Size = New System.Drawing.Size(104, 23)
        Me.BtnNovoPlacanje.TabIndex = 21
        Me.BtnNovoPlacanje.Text = "Novo Placanje"
        Me.BtnNovoPlacanje.UseVisualStyleBackColor = False
        '
        'BtnDodajUplatu
        '
        Me.BtnDodajUplatu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajUplatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajUplatu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajUplatu.Location = New System.Drawing.Point(74, 265)
        Me.BtnDodajUplatu.Name = "BtnDodajUplatu"
        Me.BtnDodajUplatu.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajUplatu.TabIndex = 20
        Me.BtnDodajUplatu.Text = "Dodaj Uplatu"
        Me.BtnDodajUplatu.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlacanjeBindingSource, "pacijent_id", True))
        Me.ComboBox2.DataSource = Me.PacijentBindingSource
        Me.ComboBox2.DisplayMember = "ime"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(81, 122)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.ValueMember = "pacijent_id"
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PlacanjeBindingSource, "faktura_id", True))
        Me.ComboBox1.DataSource = Me.FakturaBindingSource
        Me.ComboBox1.DisplayMember = "naziv"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "faktura_id"
        '
        'FakturaBindingSource
        '
        Me.FakturaBindingSource.DataMember = "faktura"
        Me.FakturaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'Tip_placanjeTextEdit
        '
        Me.Tip_placanjeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "tip_placanje", True))
        Me.Tip_placanjeTextEdit.Location = New System.Drawing.Point(81, 44)
        Me.Tip_placanjeTextEdit.Name = "Tip_placanjeTextEdit"
        Me.Tip_placanjeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Tip_placanjeTextEdit.TabIndex = 3
        '
        'Transakcija_idTextEdit
        '
        Me.Transakcija_idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "transakcija_id", True))
        Me.Transakcija_idTextEdit.Location = New System.Drawing.Point(81, 70)
        Me.Transakcija_idTextEdit.Name = "Transakcija_idTextEdit"
        Me.Transakcija_idTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Transakcija_idTextEdit.TabIndex = 5
        '
        'MetodaTextEdit
        '
        Me.MetodaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "metoda", True))
        Me.MetodaTextEdit.Location = New System.Drawing.Point(81, 148)
        Me.MetodaTextEdit.Name = "MetodaTextEdit"
        Me.MetodaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.MetodaTextEdit.TabIndex = 11
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(81, 174)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 13
        '
        'KolicinaSpinEdit
        '
        Me.KolicinaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "kolicina", True))
        Me.KolicinaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KolicinaSpinEdit.Location = New System.Drawing.Point(81, 200)
        Me.KolicinaSpinEdit.Name = "KolicinaSpinEdit"
        Me.KolicinaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KolicinaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.KolicinaSpinEdit.TabIndex = 15
        '
        'VrijemeSpinEdit
        '
        Me.VrijemeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PlacanjeBindingSource, "vrijeme", True))
        Me.VrijemeSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.VrijemeSpinEdit.Location = New System.Drawing.Point(81, 226)
        Me.VrijemeSpinEdit.Name = "VrijemeSpinEdit"
        Me.VrijemeSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeSpinEdit.TabIndex = 17
        '
        'PlacanjeTableAdapter
        '
        Me.PlacanjeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.fakturaTableAdapter = Me.FakturaTableAdapter
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
        Me.TableAdapterManager.pacijentTableAdapter = Me.PacijentTableAdapter
        Me.TableAdapterManager.placanjeTableAdapter = Me.PlacanjeTableAdapter
        Me.TableAdapterManager.podesavanjaTableAdapter = Nothing
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FakturaTableAdapter
        '
        Me.FakturaTableAdapter.ClearBeforeFill = True
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'PlacanjeBindingNavigator
        '
        Me.PlacanjeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlacanjeBindingNavigator.BindingSource = Me.PlacanjeBindingSource
        Me.PlacanjeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlacanjeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlacanjeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlacanjeBindingNavigatorSaveItem})
        Me.PlacanjeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlacanjeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlacanjeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlacanjeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlacanjeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlacanjeBindingNavigator.Name = "PlacanjeBindingNavigator"
        Me.PlacanjeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlacanjeBindingNavigator.Size = New System.Drawing.Size(1069, 25)
        Me.PlacanjeBindingNavigator.TabIndex = 1
        Me.PlacanjeBindingNavigator.Text = "BindingNavigator1"
        Me.PlacanjeBindingNavigator.Visible = False
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
        'PlacanjeBindingNavigatorSaveItem
        '
        Me.PlacanjeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlacanjeBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlacanjeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlacanjeBindingNavigatorSaveItem.Name = "PlacanjeBindingNavigatorSaveItem"
        Me.PlacanjeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PlacanjeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(1029, 1)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 33
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "placanje_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Uplate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tip_placanje"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tip Placanja"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "transakcija_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID Transakcije"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "faktura_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID Fakture"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID Pacijenta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "metoda"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Metoda Placanja"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "kolicina"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Iznos uplate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vrijeme"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Vrijeme"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Placanje_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 335)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.PlacanjeBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Placanje_Form"
        Me.Text = "Placanje_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PlacanjeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlacanjeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FakturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tip_placanjeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transakcija_idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetodaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KolicinaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlacanjeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlacanjeBindingNavigator.ResumeLayout(False)
        Me.PlacanjeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PlacanjeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlacanjeTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.placanjeTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlacanjeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PlacanjeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlacanjeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Tip_placanjeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Transakcija_idTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MetodaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KolicinaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents VrijemeSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FakturaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.fakturaTableAdapter
    Friend WithEvents FakturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNovoPlacanje As System.Windows.Forms.Button
    Friend WithEvents BtnDodajUplatu As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
