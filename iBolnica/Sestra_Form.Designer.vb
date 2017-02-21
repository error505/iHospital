<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sestra_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sestra_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.SestraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SestraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnNovaSestra = New System.Windows.Forms.Button()
        Me.BtnDodajSestru = New System.Windows.Forms.Button()
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SestraTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.SestraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SestraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        ImeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SestraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SestraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SestraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SestraBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(5, 66)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(72, 13)
        ImeLabel.TabIndex = 2
        ImeLabel.Text = "Ime i Prezime:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 92)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(6, 118)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(51, 13)
        PaswordLabel.TabIndex = 6
        PaswordLabel.Text = "Pasword:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(6, 144)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 8
        AdresaLabel.Text = "Adresa:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(6, 170)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 10
        TelefonLabel.Text = "Telefon:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 276)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.SestraDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(773, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Sestara"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(659, 15)
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
        Me.BtnIzbrisi.Location = New System.Drawing.Point(703, 15)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 38
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'SestraDataGridView
        '
        Me.SestraDataGridView.AllowUserToAddRows = False
        Me.SestraDataGridView.AutoGenerateColumns = False
        Me.SestraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SestraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SestraDataGridView.DataSource = Me.SestraBindingSource
        Me.SestraDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SestraDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SestraDataGridView.Name = "SestraDataGridView"
        Me.SestraDataGridView.RowHeadersVisible = False
        Me.SestraDataGridView.Size = New System.Drawing.Size(767, 244)
        Me.SestraDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sestra_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Sestre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ime i Prezime Sestre"
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
        'SestraBindingSource
        '
        Me.SestraBindingSource.DataMember = "sestra"
        Me.SestraBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnNovaSestra)
        Me.TabPage2.Controls.Add(Me.BtnDodajSestru)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(773, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Sestru"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnNovaSestra
        '
        Me.BtnNovaSestra.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovaSestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovaSestra.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNovaSestra.Location = New System.Drawing.Point(20, 16)
        Me.BtnNovaSestra.Name = "BtnNovaSestra"
        Me.BtnNovaSestra.Size = New System.Drawing.Size(122, 23)
        Me.BtnNovaSestra.TabIndex = 39
        Me.BtnNovaSestra.Text = "Nova Sestra"
        Me.BtnNovaSestra.UseVisualStyleBackColor = False
        '
        'BtnDodajSestru
        '
        Me.BtnDodajSestru.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajSestru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajSestru.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDodajSestru.Location = New System.Drawing.Point(81, 208)
        Me.BtnDodajSestru.Name = "BtnDodajSestru"
        Me.BtnDodajSestru.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajSestru.TabIndex = 38
        Me.BtnDodajSestru.Text = "Dodaj Sestru"
        Me.BtnDodajSestru.UseVisualStyleBackColor = False
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SestraBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(81, 63)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 3
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SestraBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(81, 89)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextEdit.TabIndex = 5
        '
        'PaswordTextEdit
        '
        Me.PaswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SestraBindingSource, "pasword", True))
        Me.PaswordTextEdit.Location = New System.Drawing.Point(81, 115)
        Me.PaswordTextEdit.Name = "PaswordTextEdit"
        Me.PaswordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PaswordTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextEdit.TabIndex = 7
        '
        'AdresaTextEdit
        '
        Me.AdresaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SestraBindingSource, "adresa", True))
        Me.AdresaTextEdit.Location = New System.Drawing.Point(81, 141)
        Me.AdresaTextEdit.Name = "AdresaTextEdit"
        Me.AdresaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresaTextEdit.TabIndex = 9
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SestraBindingSource, "telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(81, 167)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextEdit.TabIndex = 11
        '
        'SestraTableAdapter
        '
        Me.SestraTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.sestraTableAdapter = Me.SestraTableAdapter
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SestraBindingNavigator
        '
        Me.SestraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SestraBindingNavigator.BindingSource = Me.SestraBindingSource
        Me.SestraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SestraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SestraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SestraBindingNavigatorSaveItem})
        Me.SestraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SestraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SestraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SestraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SestraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SestraBindingNavigator.Name = "SestraBindingNavigator"
        Me.SestraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SestraBindingNavigator.Size = New System.Drawing.Size(781, 25)
        Me.SestraBindingNavigator.TabIndex = 1
        Me.SestraBindingNavigator.Text = "BindingNavigator1"
        Me.SestraBindingNavigator.Visible = False
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
        'SestraBindingNavigatorSaveItem
        '
        Me.SestraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SestraBindingNavigatorSaveItem.Image = CType(resources.GetObject("SestraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SestraBindingNavigatorSaveItem.Name = "SestraBindingNavigatorSaveItem"
        Me.SestraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SestraBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(739, 2)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 35
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'Sestra_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 285)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.SestraBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sestra_Form"
        Me.Text = "Sestra_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SestraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SestraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SestraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SestraBindingNavigator.ResumeLayout(False)
        Me.SestraBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents SestraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SestraTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SestraBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SestraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SestraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnNovaSestra As System.Windows.Forms.Button
    Friend WithEvents BtnDodajSestru As System.Windows.Forms.Button
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
