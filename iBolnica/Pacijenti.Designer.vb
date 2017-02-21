<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacijenti
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Dim AdresaLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim PolLabel As System.Windows.Forms.Label
        Dim Datum_rodjenjaLabel As System.Windows.Forms.Label
        Dim StarostLabel As System.Windows.Forms.Label
        Dim Krvna_grupaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacijenti))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.PacijentDataGridView = New System.Windows.Forms.DataGridView()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BankakrviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNoviPacijent = New System.Windows.Forms.Button()
        Me.BtnDodajPacijenta = New System.Windows.Forms.Button()
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PolTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Datum_rodjenjaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StarostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.Banka_krviTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.banka_krviTableAdapter()
        Me.PacijentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PacijentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        PolLabel = New System.Windows.Forms.Label()
        Datum_rodjenjaLabel = New System.Windows.Forms.Label()
        StarostLabel = New System.Windows.Forms.Label()
        Krvna_grupaLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PacijentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BankakrviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datum_rodjenjaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StarostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacijentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(26, 40)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(72, 13)
        ImeLabel.TabIndex = 2
        ImeLabel.Text = "Ime i Prezime:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(26, 66)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(26, 92)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(51, 13)
        PaswordLabel.TabIndex = 6
        PaswordLabel.Text = "Pasword:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(26, 118)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 8
        AdresaLabel.Text = "Adresa:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(26, 144)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 10
        TelefonLabel.Text = "Telefon:"
        '
        'PolLabel
        '
        PolLabel.AutoSize = True
        PolLabel.Location = New System.Drawing.Point(26, 170)
        PolLabel.Name = "PolLabel"
        PolLabel.Size = New System.Drawing.Size(25, 13)
        PolLabel.TabIndex = 12
        PolLabel.Text = "Pol:"
        '
        'Datum_rodjenjaLabel
        '
        Datum_rodjenjaLabel.AutoSize = True
        Datum_rodjenjaLabel.Location = New System.Drawing.Point(26, 196)
        Datum_rodjenjaLabel.Name = "Datum_rodjenjaLabel"
        Datum_rodjenjaLabel.Size = New System.Drawing.Size(81, 13)
        Datum_rodjenjaLabel.TabIndex = 14
        Datum_rodjenjaLabel.Text = "Datum rodjenja:"
        '
        'StarostLabel
        '
        StarostLabel.AutoSize = True
        StarostLabel.Location = New System.Drawing.Point(26, 222)
        StarostLabel.Name = "StarostLabel"
        StarostLabel.Size = New System.Drawing.Size(43, 13)
        StarostLabel.TabIndex = 16
        StarostLabel.Text = "Starost:"
        '
        'Krvna_grupaLabel
        '
        Krvna_grupaLabel.AutoSize = True
        Krvna_grupaLabel.Location = New System.Drawing.Point(26, 248)
        Krvna_grupaLabel.Name = "Krvna_grupaLabel"
        Krvna_grupaLabel.Size = New System.Drawing.Size(68, 13)
        Krvna_grupaLabel.TabIndex = 18
        Krvna_grupaLabel.Text = "Krvna grupa:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1246, 371)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.PacijentDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1238, 345)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Pacijenata"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(1151, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 39
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(1195, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 38
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'PacijentDataGridView
        '
        Me.PacijentDataGridView.AllowUserToAddRows = False
        Me.PacijentDataGridView.AutoGenerateColumns = False
        Me.PacijentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PacijentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PacijentDataGridView.DataSource = Me.PacijentBindingSource
        Me.PacijentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PacijentDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PacijentDataGridView.Name = "PacijentDataGridView"
        Me.PacijentDataGridView.Size = New System.Drawing.Size(1232, 339)
        Me.PacijentDataGridView.TabIndex = 37
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BtnNoviPacijent)
        Me.TabPage2.Controls.Add(Me.BtnDodajPacijenta)
        Me.TabPage2.Controls.Add(ImeLabel)
        Me.TabPage2.Controls.Add(Me.ImeTextEdit)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.EmailTextEdit)
        Me.TabPage2.Controls.Add(PaswordLabel)
        Me.TabPage2.Controls.Add(Me.PaswordTextEdit)
        Me.TabPage2.Controls.Add(AdresaLabel)
        Me.TabPage2.Controls.Add(Me.AdresaTextEdit)
        Me.TabPage2.Controls.Add(TelefonLabel)
        Me.TabPage2.Controls.Add(Me.TelefonTextEdit)
        Me.TabPage2.Controls.Add(PolLabel)
        Me.TabPage2.Controls.Add(Me.PolTextEdit)
        Me.TabPage2.Controls.Add(Datum_rodjenjaLabel)
        Me.TabPage2.Controls.Add(Me.Datum_rodjenjaTextEdit)
        Me.TabPage2.Controls.Add(StarostLabel)
        Me.TabPage2.Controls.Add(Me.StarostSpinEdit)
        Me.TabPage2.Controls.Add(Krvna_grupaLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1238, 345)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Pacijenta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PacijentBindingSource, "krvna_grupa", True))
        Me.ComboBox1.DataSource = Me.BankakrviBindingSource
        Me.ComboBox1.DisplayMember = "krvna_grupa"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 246)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(55, 21)
        Me.ComboBox1.TabIndex = 38
        Me.ComboBox1.ValueMember = "krvna_grupa"
        '
        'BankakrviBindingSource
        '
        Me.BankakrviBindingSource.DataMember = "banka_krvi"
        Me.BankakrviBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnNoviPacijent
        '
        Me.BtnNoviPacijent.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviPacijent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNoviPacijent.Location = New System.Drawing.Point(29, 6)
        Me.BtnNoviPacijent.Name = "BtnNoviPacijent"
        Me.BtnNoviPacijent.Size = New System.Drawing.Size(122, 23)
        Me.BtnNoviPacijent.TabIndex = 37
        Me.BtnNoviPacijent.Text = "Novi Pacijent"
        Me.BtnNoviPacijent.UseVisualStyleBackColor = False
        '
        'BtnDodajPacijenta
        '
        Me.BtnDodajPacijenta.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajPacijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajPacijenta.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajPacijenta.Location = New System.Drawing.Point(157, 278)
        Me.BtnDodajPacijenta.Name = "BtnDodajPacijenta"
        Me.BtnDodajPacijenta.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajPacijenta.TabIndex = 36
        Me.BtnDodajPacijenta.Text = "Dodaj Pacijenta"
        Me.BtnDodajPacijenta.UseVisualStyleBackColor = False
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(157, 37)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 3
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(157, 63)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextEdit.TabIndex = 5
        '
        'PaswordTextEdit
        '
        Me.PaswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "pasword", True))
        Me.PaswordTextEdit.Location = New System.Drawing.Point(157, 89)
        Me.PaswordTextEdit.Name = "PaswordTextEdit"
        Me.PaswordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PaswordTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextEdit.TabIndex = 7
        '
        'AdresaTextEdit
        '
        Me.AdresaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "adresa", True))
        Me.AdresaTextEdit.Location = New System.Drawing.Point(157, 115)
        Me.AdresaTextEdit.Name = "AdresaTextEdit"
        Me.AdresaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresaTextEdit.TabIndex = 9
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(157, 141)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextEdit.TabIndex = 11
        '
        'PolTextEdit
        '
        Me.PolTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "pol", True))
        Me.PolTextEdit.Location = New System.Drawing.Point(157, 167)
        Me.PolTextEdit.Name = "PolTextEdit"
        Me.PolTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PolTextEdit.TabIndex = 13
        '
        'Datum_rodjenjaTextEdit
        '
        Me.Datum_rodjenjaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "datum_rodjenja", True))
        Me.Datum_rodjenjaTextEdit.Location = New System.Drawing.Point(157, 193)
        Me.Datum_rodjenjaTextEdit.Name = "Datum_rodjenjaTextEdit"
        Me.Datum_rodjenjaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Datum_rodjenjaTextEdit.TabIndex = 15
        '
        'StarostSpinEdit
        '
        Me.StarostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PacijentBindingSource, "starost", True))
        Me.StarostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.StarostSpinEdit.Location = New System.Drawing.Point(157, 219)
        Me.StarostSpinEdit.Name = "StarostSpinEdit"
        Me.StarostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StarostSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.StarostSpinEdit.TabIndex = 17
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(1203, 1)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 34
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banka_krviTableAdapter = Me.Banka_krviTableAdapter
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
        Me.TableAdapterManager.kategorije_lijekovaTableAdapter = Nothing
        Me.TableAdapterManager.krevetTableAdapter = Nothing
        Me.TableAdapterManager.laborantTableAdapter = Nothing
        Me.TableAdapterManager.lijekoviTableAdapter = Nothing
        Me.TableAdapterManager.menadzmentTableAdapter = Nothing
        Me.TableAdapterManager.obavjestenjaTableAdapter = Nothing
        Me.TableAdapterManager.odjeljenjeTableAdapter = Nothing
        Me.TableAdapterManager.pacijentTableAdapter = Me.PacijentTableAdapter
        Me.TableAdapterManager.placanjeTableAdapter = Nothing
        Me.TableAdapterManager.podesavanjaTableAdapter = Nothing
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Banka_krviTableAdapter
        '
        Me.Banka_krviTableAdapter.ClearBeforeFill = True
        '
        'PacijentBindingNavigator
        '
        Me.PacijentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PacijentBindingNavigator.BindingSource = Me.PacijentBindingSource
        Me.PacijentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PacijentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PacijentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PacijentBindingNavigatorSaveItem})
        Me.PacijentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacijentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PacijentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PacijentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PacijentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PacijentBindingNavigator.Name = "PacijentBindingNavigator"
        Me.PacijentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PacijentBindingNavigator.Size = New System.Drawing.Size(1247, 25)
        Me.PacijentBindingNavigator.TabIndex = 35
        Me.PacijentBindingNavigator.Text = "BindingNavigator1"
        Me.PacijentBindingNavigator.Visible = False
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
        'PacijentBindingNavigatorSaveItem
        '
        Me.PacijentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PacijentBindingNavigatorSaveItem.Image = CType(resources.GetObject("PacijentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PacijentBindingNavigatorSaveItem.Name = "PacijentBindingNavigatorSaveItem"
        Me.PacijentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PacijentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Pacijenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ime i Prezime"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pasword"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pasword"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "adresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Adresa"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "pol"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pol"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "datum_rodjenja"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Datum rodjenja"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "starost"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Starost"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "krvna_grupa"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Krvna grupa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Pacijenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 383)
        Me.Controls.Add(Me.PacijentBindingNavigator)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pacijenti"
        Me.Text = "Pacijenti"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PacijentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BankakrviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datum_rodjenjaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StarostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacijentBindingNavigator.ResumeLayout(False)
        Me.PacijentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacijentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PacijentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PolTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Datum_rodjenjaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StarostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BtnNoviPacijent As System.Windows.Forms.Button
    Friend WithEvents BtnDodajPacijenta As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Banka_krviTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.banka_krviTableAdapter
    Friend WithEvents BankakrviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents PacijentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
