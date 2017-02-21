<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonatoriKrvi_FOrm
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
        Dim Krvna_grupaLabel As System.Windows.Forms.Label
        Dim PolLabel As System.Windows.Forms.Label
        Dim GodineLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim Poslednja_donacija_vrijemeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DonatoriKrvi_FOrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.Donator_krviDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Donator_krviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BankakrviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poslednja_donacijaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BtnNoviDavatelj = New System.Windows.Forms.Button()
        Me.BtnDodajDavatelja = New System.Windows.Forms.Button()
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PolTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GodineSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Donator_krviTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.donator_krviTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.Donator_krviBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Donator_krviBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.Banka_krviTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.banka_krviTableAdapter()
        ImeLabel = New System.Windows.Forms.Label()
        Krvna_grupaLabel = New System.Windows.Forms.Label()
        PolLabel = New System.Windows.Forms.Label()
        GodineLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        Poslednja_donacija_vrijemeLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Donator_krviDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donator_krviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BankakrviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poslednja_donacijaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poslednja_donacijaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GodineSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Donator_krviBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Donator_krviBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(6, 32)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(72, 13)
        ImeLabel.TabIndex = 2
        ImeLabel.Text = "Ime i Prezime:"
        '
        'Krvna_grupaLabel
        '
        Krvna_grupaLabel.AutoSize = True
        Krvna_grupaLabel.Location = New System.Drawing.Point(6, 58)
        Krvna_grupaLabel.Name = "Krvna_grupaLabel"
        Krvna_grupaLabel.Size = New System.Drawing.Size(68, 13)
        Krvna_grupaLabel.TabIndex = 4
        Krvna_grupaLabel.Text = "Krvna grupa:"
        '
        'PolLabel
        '
        PolLabel.AutoSize = True
        PolLabel.Location = New System.Drawing.Point(6, 84)
        PolLabel.Name = "PolLabel"
        PolLabel.Size = New System.Drawing.Size(25, 13)
        PolLabel.TabIndex = 6
        PolLabel.Text = "Pol:"
        '
        'GodineLabel
        '
        GodineLabel.AutoSize = True
        GodineLabel.Location = New System.Drawing.Point(6, 110)
        GodineLabel.Name = "GodineLabel"
        GodineLabel.Size = New System.Drawing.Size(44, 13)
        GodineLabel.TabIndex = 8
        GodineLabel.Text = "Godine:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(6, 136)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 10
        TelefonLabel.Text = "Telefon:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 162)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 12
        EmailLabel.Text = "Email:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(6, 188)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 14
        AdresaLabel.Text = "Adresa:"
        '
        'Poslednja_donacija_vrijemeLabel
        '
        Poslednja_donacija_vrijemeLabel.AutoSize = True
        Poslednja_donacija_vrijemeLabel.Location = New System.Drawing.Point(6, 214)
        Poslednja_donacija_vrijemeLabel.Name = "Poslednja_donacija_vrijemeLabel"
        Poslednja_donacija_vrijemeLabel.Size = New System.Drawing.Size(135, 13)
        Poslednja_donacija_vrijemeLabel.TabIndex = 16
        Poslednja_donacija_vrijemeLabel.Text = "Poslednja donacija vrijeme:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1052, 317)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.Donator_krviDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1044, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Donatora Krvi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(954, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 85
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(998, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 84
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'Donator_krviDataGridView
        '
        Me.Donator_krviDataGridView.AllowUserToAddRows = False
        Me.Donator_krviDataGridView.AutoGenerateColumns = False
        Me.Donator_krviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Donator_krviDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.Donator_krviDataGridView.DataSource = Me.Donator_krviBindingSource
        Me.Donator_krviDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Donator_krviDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Donator_krviDataGridView.Name = "Donator_krviDataGridView"
        Me.Donator_krviDataGridView.Size = New System.Drawing.Size(1038, 285)
        Me.Donator_krviDataGridView.TabIndex = 83
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "donator_krvi_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Donatora Krvi"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ime i  Prezime Donatora"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "krvna_grupa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Krvna Grupa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pol"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pol"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "godine"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Godine"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefon"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "adresa"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Adresa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "poslednja_donacija"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Vrijeme Poslednje Donacije"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Donator_krviBindingSource
        '
        Me.Donator_krviBindingSource.DataMember = "donator_krvi"
        Me.Donator_krviBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Poslednja_donacijaDateEdit)
        Me.TabPage2.Controls.Add(Me.BtnNoviDavatelj)
        Me.TabPage2.Controls.Add(Me.BtnDodajDavatelja)
        Me.TabPage2.Controls.Add(ImeLabel)
        Me.TabPage2.Controls.Add(Me.ImeTextEdit)
        Me.TabPage2.Controls.Add(Krvna_grupaLabel)
        Me.TabPage2.Controls.Add(PolLabel)
        Me.TabPage2.Controls.Add(Me.PolTextEdit)
        Me.TabPage2.Controls.Add(GodineLabel)
        Me.TabPage2.Controls.Add(Me.GodineSpinEdit)
        Me.TabPage2.Controls.Add(TelefonLabel)
        Me.TabPage2.Controls.Add(Me.TelefonTextEdit)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.EmailTextEdit)
        Me.TabPage2.Controls.Add(AdresaLabel)
        Me.TabPage2.Controls.Add(Me.AdresaTextEdit)
        Me.TabPage2.Controls.Add(Poslednja_donacija_vrijemeLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1044, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Donatora Krvi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Donator_krviBindingSource, "krvna_grupa", True))
        Me.ComboBox1.DataSource = Me.BankakrviBindingSource
        Me.ComboBox1.DisplayMember = "krvna_grupa"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(51, 21)
        Me.ComboBox1.TabIndex = 63
        Me.ComboBox1.ValueMember = "krvna_grupa"
        '
        'BankakrviBindingSource
        '
        Me.BankakrviBindingSource.DataMember = "banka_krvi"
        Me.BankakrviBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'Poslednja_donacijaDateEdit
        '
        Me.Poslednja_donacijaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "poslednja_donacija", True))
        Me.Poslednja_donacijaDateEdit.EditValue = Nothing
        Me.Poslednja_donacijaDateEdit.Location = New System.Drawing.Point(147, 207)
        Me.Poslednja_donacijaDateEdit.Name = "Poslednja_donacijaDateEdit"
        Me.Poslednja_donacijaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Poslednja_donacijaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Poslednja_donacijaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.Poslednja_donacijaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.Poslednja_donacijaDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.Poslednja_donacijaDateEdit.TabIndex = 62
        '
        'BtnNoviDavatelj
        '
        Me.BtnNoviDavatelj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviDavatelj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviDavatelj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNoviDavatelj.Location = New System.Drawing.Point(9, 6)
        Me.BtnNoviDavatelj.Name = "BtnNoviDavatelj"
        Me.BtnNoviDavatelj.Size = New System.Drawing.Size(141, 23)
        Me.BtnNoviDavatelj.TabIndex = 61
        Me.BtnNoviDavatelj.Text = "Novi Donator"
        Me.BtnNoviDavatelj.UseVisualStyleBackColor = False
        '
        'BtnDodajDavatelja
        '
        Me.BtnDodajDavatelja.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajDavatelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajDavatelja.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajDavatelja.Location = New System.Drawing.Point(134, 248)
        Me.BtnDodajDavatelja.Name = "BtnDodajDavatelja"
        Me.BtnDodajDavatelja.Size = New System.Drawing.Size(112, 28)
        Me.BtnDodajDavatelja.TabIndex = 60
        Me.BtnDodajDavatelja.Text = "Dodaj Donatora"
        Me.BtnDodajDavatelja.UseVisualStyleBackColor = False
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(146, 29)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 3
        '
        'PolTextEdit
        '
        Me.PolTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "pol", True))
        Me.PolTextEdit.Location = New System.Drawing.Point(146, 81)
        Me.PolTextEdit.Name = "PolTextEdit"
        Me.PolTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PolTextEdit.TabIndex = 7
        '
        'GodineSpinEdit
        '
        Me.GodineSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "godine", True))
        Me.GodineSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GodineSpinEdit.Location = New System.Drawing.Point(146, 107)
        Me.GodineSpinEdit.Name = "GodineSpinEdit"
        Me.GodineSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GodineSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.GodineSpinEdit.TabIndex = 9
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(146, 133)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextEdit.TabIndex = 11
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(146, 159)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextEdit.TabIndex = 13
        '
        'AdresaTextEdit
        '
        Me.AdresaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Donator_krviBindingSource, "adresa", True))
        Me.AdresaTextEdit.Location = New System.Drawing.Point(146, 185)
        Me.AdresaTextEdit.Name = "AdresaTextEdit"
        Me.AdresaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresaTextEdit.TabIndex = 15
        '
        'Donator_krviTableAdapter
        '
        Me.Donator_krviTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banka_krviTableAdapter = Nothing
        Me.TableAdapterManager.dijagnoza_izvjestajTableAdapter = Nothing
        Me.TableAdapterManager.dodjela_krevetaTableAdapter = Nothing
        Me.TableAdapterManager.doktorTableAdapter = Nothing
        Me.TableAdapterManager.donator_krviTableAdapter = Me.Donator_krviTableAdapter
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
        'Donator_krviBindingNavigator
        '
        Me.Donator_krviBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Donator_krviBindingNavigator.BindingSource = Me.Donator_krviBindingSource
        Me.Donator_krviBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Donator_krviBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Donator_krviBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Donator_krviBindingNavigatorSaveItem})
        Me.Donator_krviBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Donator_krviBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Donator_krviBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Donator_krviBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Donator_krviBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Donator_krviBindingNavigator.Name = "Donator_krviBindingNavigator"
        Me.Donator_krviBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Donator_krviBindingNavigator.Size = New System.Drawing.Size(1065, 25)
        Me.Donator_krviBindingNavigator.TabIndex = 1
        Me.Donator_krviBindingNavigator.Text = "BindingNavigator1"
        Me.Donator_krviBindingNavigator.Visible = False
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
        'Donator_krviBindingNavigatorSaveItem
        '
        Me.Donator_krviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Donator_krviBindingNavigatorSaveItem.Image = CType(resources.GetObject("Donator_krviBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Donator_krviBindingNavigatorSaveItem.Name = "Donator_krviBindingNavigatorSaveItem"
        Me.Donator_krviBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Donator_krviBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(1010, 1)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 82
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'Banka_krviTableAdapter
        '
        Me.Banka_krviTableAdapter.ClearBeforeFill = True
        '
        'DonatoriKrvi_FOrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 324)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.Donator_krviBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DonatoriKrvi_FOrm"
        Me.Text = "DonatoriKrvi_FOrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Donator_krviDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donator_krviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BankakrviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poslednja_donacijaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poslednja_donacijaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GodineSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Donator_krviBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Donator_krviBindingNavigator.ResumeLayout(False)
        Me.Donator_krviBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents Donator_krviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Donator_krviTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.donator_krviTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Donator_krviBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Donator_krviBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PolTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GodineSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNoviDavatelj As System.Windows.Forms.Button
    Friend WithEvents BtnDodajDavatelja As System.Windows.Forms.Button
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents Donator_krviDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Poslednja_donacijaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BankakrviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Banka_krviTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.banka_krviTableAdapter
End Class
