<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fakture_Form
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
        Dim Pacijent_idLabel As System.Windows.Forms.Label
        Dim NazivLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim KolicinaLabel As System.Windows.Forms.Label
        Dim Vrijeme_kreiranjaLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fakture_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.FakturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FakturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNovaFaktura = New System.Windows.Forms.Button()
        Me.BtnDodajFakturu = New System.Windows.Forms.Button()
        Me.NazivTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KolicinaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Vrijeme_kreiranjaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FakturaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.fakturaTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.FakturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FakturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Pacijent_idLabel = New System.Windows.Forms.Label()
        NazivLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        KolicinaLabel = New System.Windows.Forms.Label()
        Vrijeme_kreiranjaLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.FakturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FakturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NazivTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KolicinaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vrijeme_kreiranjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vrijeme_kreiranjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FakturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FakturaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(13, 45)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel.TabIndex = 2
        Pacijent_idLabel.Text = "Pacijent:"
        '
        'NazivLabel
        '
        NazivLabel.AutoSize = True
        NazivLabel.Location = New System.Drawing.Point(13, 71)
        NazivLabel.Name = "NazivLabel"
        NazivLabel.Size = New System.Drawing.Size(37, 13)
        NazivLabel.TabIndex = 4
        NazivLabel.Text = "Naziv:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(13, 97)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 6
        OpisLabel.Text = "Opis:"
        '
        'KolicinaLabel
        '
        KolicinaLabel.AutoSize = True
        KolicinaLabel.Location = New System.Drawing.Point(13, 123)
        KolicinaLabel.Name = "KolicinaLabel"
        KolicinaLabel.Size = New System.Drawing.Size(47, 13)
        KolicinaLabel.TabIndex = 8
        KolicinaLabel.Text = "Kolicina:"
        '
        'Vrijeme_kreiranjaLabel
        '
        Vrijeme_kreiranjaLabel.AutoSize = True
        Vrijeme_kreiranjaLabel.Location = New System.Drawing.Point(13, 149)
        Vrijeme_kreiranjaLabel.Name = "Vrijeme_kreiranjaLabel"
        Vrijeme_kreiranjaLabel.Size = New System.Drawing.Size(87, 13)
        Vrijeme_kreiranjaLabel.TabIndex = 10
        Vrijeme_kreiranjaLabel.Text = "Vrijeme kreiranja:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(13, 175)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 12
        StatusLabel.Text = "Status:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 293)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.FakturaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Faktura"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(759, 6)
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
        Me.BtnIzbrisi.Location = New System.Drawing.Point(803, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 38
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'FakturaDataGridView
        '
        Me.FakturaDataGridView.AllowUserToAddRows = False
        Me.FakturaDataGridView.AutoGenerateColumns = False
        Me.FakturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FakturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.FakturaDataGridView.DataSource = Me.FakturaBindingSource
        Me.FakturaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FakturaDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.FakturaDataGridView.Name = "FakturaDataGridView"
        Me.FakturaDataGridView.Size = New System.Drawing.Size(845, 261)
        Me.FakturaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "faktura_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "faktura_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "pacijent_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "naziv"
        Me.DataGridViewTextBoxColumn3.HeaderText = "naziv"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn4.HeaderText = "opis"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "kolicina"
        Me.DataGridViewTextBoxColumn5.HeaderText = "kolicina"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "vrijeme_kreiranja"
        Me.DataGridViewTextBoxColumn6.HeaderText = "vrijeme_kreiranja"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn7.HeaderText = "status"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FakturaBindingSource
        '
        Me.FakturaBindingSource.DataMember = "faktura"
        Me.FakturaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BtnNovaFaktura)
        Me.TabPage2.Controls.Add(Me.BtnDodajFakturu)
        Me.TabPage2.Controls.Add(Pacijent_idLabel)
        Me.TabPage2.Controls.Add(NazivLabel)
        Me.TabPage2.Controls.Add(Me.NazivTextEdit)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Controls.Add(KolicinaLabel)
        Me.TabPage2.Controls.Add(Me.KolicinaSpinEdit)
        Me.TabPage2.Controls.Add(Vrijeme_kreiranjaLabel)
        Me.TabPage2.Controls.Add(Me.Vrijeme_kreiranjaDateEdit)
        Me.TabPage2.Controls.Add(StatusLabel)
        Me.TabPage2.Controls.Add(Me.StatusTextEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(851, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Fakturu"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FakturaBindingSource, "pacijent_id", True))
        Me.ComboBox1.DataSource = Me.PacijentBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.ValueMember = "pacijent_id"
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnNovaFaktura
        '
        Me.BtnNovaFaktura.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovaFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovaFaktura.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovaFaktura.Location = New System.Drawing.Point(16, 6)
        Me.BtnNovaFaktura.Name = "BtnNovaFaktura"
        Me.BtnNovaFaktura.Size = New System.Drawing.Size(104, 23)
        Me.BtnNovaFaktura.TabIndex = 23
        Me.BtnNovaFaktura.Text = "Nova Faktura"
        Me.BtnNovaFaktura.UseVisualStyleBackColor = False
        '
        'BtnDodajFakturu
        '
        Me.BtnDodajFakturu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajFakturu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajFakturu.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajFakturu.Location = New System.Drawing.Point(105, 208)
        Me.BtnDodajFakturu.Name = "BtnDodajFakturu"
        Me.BtnDodajFakturu.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajFakturu.TabIndex = 22
        Me.BtnDodajFakturu.Text = "Dodaj Fakturu"
        Me.BtnDodajFakturu.UseVisualStyleBackColor = False
        '
        'NazivTextEdit
        '
        Me.NazivTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FakturaBindingSource, "naziv", True))
        Me.NazivTextEdit.Location = New System.Drawing.Point(105, 68)
        Me.NazivTextEdit.Name = "NazivTextEdit"
        Me.NazivTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.NazivTextEdit.TabIndex = 5
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FakturaBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(105, 94)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 7
        '
        'KolicinaSpinEdit
        '
        Me.KolicinaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FakturaBindingSource, "kolicina", True))
        Me.KolicinaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KolicinaSpinEdit.Location = New System.Drawing.Point(105, 120)
        Me.KolicinaSpinEdit.Name = "KolicinaSpinEdit"
        Me.KolicinaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KolicinaSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.KolicinaSpinEdit.TabIndex = 9
        '
        'Vrijeme_kreiranjaDateEdit
        '
        Me.Vrijeme_kreiranjaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FakturaBindingSource, "vrijeme_kreiranja", True))
        Me.Vrijeme_kreiranjaDateEdit.EditValue = Nothing
        Me.Vrijeme_kreiranjaDateEdit.Location = New System.Drawing.Point(105, 146)
        Me.Vrijeme_kreiranjaDateEdit.Name = "Vrijeme_kreiranjaDateEdit"
        Me.Vrijeme_kreiranjaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Vrijeme_kreiranjaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Vrijeme_kreiranjaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.Vrijeme_kreiranjaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.Vrijeme_kreiranjaDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.Vrijeme_kreiranjaDateEdit.TabIndex = 11
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FakturaBindingSource, "status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(105, 172)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextEdit.TabIndex = 13
        '
        'FakturaTableAdapter
        '
        Me.FakturaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.placanjeTableAdapter = Nothing
        Me.TableAdapterManager.podesavanjaTableAdapter = Nothing
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'FakturaBindingNavigator
        '
        Me.FakturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FakturaBindingNavigator.BindingSource = Me.FakturaBindingSource
        Me.FakturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FakturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FakturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FakturaBindingNavigatorSaveItem})
        Me.FakturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FakturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FakturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FakturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FakturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FakturaBindingNavigator.Name = "FakturaBindingNavigator"
        Me.FakturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FakturaBindingNavigator.Size = New System.Drawing.Size(1016, 25)
        Me.FakturaBindingNavigator.TabIndex = 1
        Me.FakturaBindingNavigator.Text = "BindingNavigator1"
        Me.FakturaBindingNavigator.Visible = False
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
        'FakturaBindingNavigatorSaveItem
        '
        Me.FakturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FakturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FakturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FakturaBindingNavigatorSaveItem.Name = "FakturaBindingNavigatorSaveItem"
        Me.FakturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FakturaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(817, 0)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 35
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'Fakture_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 305)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.FakturaBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fakture_Form"
        Me.Text = "Fakture_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.FakturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FakturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NazivTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KolicinaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vrijeme_kreiranjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vrijeme_kreiranjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FakturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FakturaBindingNavigator.ResumeLayout(False)
        Me.FakturaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents FakturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FakturaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.fakturaTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FakturaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FakturaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FakturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazivTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KolicinaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Vrijeme_kreiranjaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnNovaFaktura As System.Windows.Forms.Button
    Friend WithEvents BtnDodajFakturu As System.Windows.Forms.Button
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
End Class
