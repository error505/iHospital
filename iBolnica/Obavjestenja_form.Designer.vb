<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obavjestenja_form
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
        Dim Obavjestenje_naslovLabel As System.Windows.Forms.Label
        Dim ObavjestenjeLabel As System.Windows.Forms.Label
        Dim Vrijeme_kreiranjaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obavjestenja_form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.ObavjestenjaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ObavjestenjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.VrijemekreiranjaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BtnNovoObavjestenje = New System.Windows.Forms.Button()
        Me.BtnDodajObavjestenje = New System.Windows.Forms.Button()
        Me.Obavjestenje_naslovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ObavjestenjeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ObavjestenjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.obavjestenjaTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.ObavjestenjaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ObavjestenjaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Obavjestenje_naslovLabel = New System.Windows.Forms.Label()
        ObavjestenjeLabel = New System.Windows.Forms.Label()
        Vrijeme_kreiranjaLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ObavjestenjaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObavjestenjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.VrijemekreiranjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemekreiranjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obavjestenje_naslovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObavjestenjeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObavjestenjaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObavjestenjaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Obavjestenje_naslovLabel
        '
        Obavjestenje_naslovLabel.AutoSize = True
        Obavjestenje_naslovLabel.Location = New System.Drawing.Point(6, 47)
        Obavjestenje_naslovLabel.Name = "Obavjestenje_naslovLabel"
        Obavjestenje_naslovLabel.Size = New System.Drawing.Size(106, 13)
        Obavjestenje_naslovLabel.TabIndex = 2
        Obavjestenje_naslovLabel.Text = "Obavjestenje naslov:"
        '
        'ObavjestenjeLabel
        '
        ObavjestenjeLabel.AutoSize = True
        ObavjestenjeLabel.Location = New System.Drawing.Point(6, 73)
        ObavjestenjeLabel.Name = "ObavjestenjeLabel"
        ObavjestenjeLabel.Size = New System.Drawing.Size(72, 13)
        ObavjestenjeLabel.TabIndex = 4
        ObavjestenjeLabel.Text = "Obavjestenje:"
        '
        'Vrijeme_kreiranjaLabel
        '
        Vrijeme_kreiranjaLabel.AutoSize = True
        Vrijeme_kreiranjaLabel.Location = New System.Drawing.Point(6, 99)
        Vrijeme_kreiranjaLabel.Name = "Vrijeme_kreiranjaLabel"
        Vrijeme_kreiranjaLabel.Size = New System.Drawing.Size(87, 13)
        Vrijeme_kreiranjaLabel.TabIndex = 6
        Vrijeme_kreiranjaLabel.Text = "Vrijeme kreiranja:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(558, 286)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.ObavjestenjaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(550, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Obavjestenja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackColor = System.Drawing.Color.Transparent
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(457, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 73
        Me.BtnUredi.UseVisualStyleBackColor = False
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(501, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 72
        Me.BtnIzbrisi.UseVisualStyleBackColor = False
        '
        'ObavjestenjaDataGridView
        '
        Me.ObavjestenjaDataGridView.AllowUserToAddRows = False
        Me.ObavjestenjaDataGridView.AutoGenerateColumns = False
        Me.ObavjestenjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObavjestenjaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.ObavjestenjaDataGridView.DataSource = Me.ObavjestenjaBindingSource
        Me.ObavjestenjaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObavjestenjaDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ObavjestenjaDataGridView.Name = "ObavjestenjaDataGridView"
        Me.ObavjestenjaDataGridView.Size = New System.Drawing.Size(544, 254)
        Me.ObavjestenjaDataGridView.TabIndex = 0
        '
        'ObavjestenjaBindingSource
        '
        Me.ObavjestenjaBindingSource.DataMember = "obavjestenja"
        Me.ObavjestenjaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.VrijemekreiranjaDateEdit)
        Me.TabPage2.Controls.Add(Me.BtnNovoObavjestenje)
        Me.TabPage2.Controls.Add(Me.BtnDodajObavjestenje)
        Me.TabPage2.Controls.Add(Obavjestenje_naslovLabel)
        Me.TabPage2.Controls.Add(Me.Obavjestenje_naslovTextEdit)
        Me.TabPage2.Controls.Add(ObavjestenjeLabel)
        Me.TabPage2.Controls.Add(Me.ObavjestenjeTextEdit)
        Me.TabPage2.Controls.Add(Vrijeme_kreiranjaLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(550, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Obavjestenje"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'VrijemekreiranjaDateEdit
        '
        Me.VrijemekreiranjaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObavjestenjaBindingSource, "vrijemekreiranja", True))
        Me.VrijemekreiranjaDateEdit.EditValue = Nothing
        Me.VrijemekreiranjaDateEdit.Location = New System.Drawing.Point(116, 96)
        Me.VrijemekreiranjaDateEdit.Name = "VrijemekreiranjaDateEdit"
        Me.VrijemekreiranjaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemekreiranjaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemekreiranjaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.VrijemekreiranjaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.VrijemekreiranjaDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.VrijemekreiranjaDateEdit.TabIndex = 58
        '
        'BtnNovoObavjestenje
        '
        Me.BtnNovoObavjestenje.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovoObavjestenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovoObavjestenje.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNovoObavjestenje.Location = New System.Drawing.Point(9, 6)
        Me.BtnNovoObavjestenje.Name = "BtnNovoObavjestenje"
        Me.BtnNovoObavjestenje.Size = New System.Drawing.Size(141, 23)
        Me.BtnNovoObavjestenje.TabIndex = 57
        Me.BtnNovoObavjestenje.Text = "Novo Obavjestenje"
        Me.BtnNovoObavjestenje.UseVisualStyleBackColor = False
        '
        'BtnDodajObavjestenje
        '
        Me.BtnDodajObavjestenje.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajObavjestenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajObavjestenje.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDodajObavjestenje.Location = New System.Drawing.Point(104, 133)
        Me.BtnDodajObavjestenje.Name = "BtnDodajObavjestenje"
        Me.BtnDodajObavjestenje.Size = New System.Drawing.Size(112, 23)
        Me.BtnDodajObavjestenje.TabIndex = 56
        Me.BtnDodajObavjestenje.Text = "Dodaj Obavjestenje"
        Me.BtnDodajObavjestenje.UseVisualStyleBackColor = False
        '
        'Obavjestenje_naslovTextEdit
        '
        Me.Obavjestenje_naslovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObavjestenjaBindingSource, "obavjestenje_naslov", True))
        Me.Obavjestenje_naslovTextEdit.Location = New System.Drawing.Point(116, 44)
        Me.Obavjestenje_naslovTextEdit.Name = "Obavjestenje_naslovTextEdit"
        Me.Obavjestenje_naslovTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Obavjestenje_naslovTextEdit.TabIndex = 3
        '
        'ObavjestenjeTextEdit
        '
        Me.ObavjestenjeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ObavjestenjaBindingSource, "obavjestenje", True))
        Me.ObavjestenjeTextEdit.Location = New System.Drawing.Point(116, 70)
        Me.ObavjestenjeTextEdit.Name = "ObavjestenjeTextEdit"
        Me.ObavjestenjeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ObavjestenjeTextEdit.TabIndex = 5
        '
        'ObavjestenjaTableAdapter
        '
        Me.ObavjestenjaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.obavjestenjaTableAdapter = Me.ObavjestenjaTableAdapter
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
        'ObavjestenjaBindingNavigator
        '
        Me.ObavjestenjaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ObavjestenjaBindingNavigator.BindingSource = Me.ObavjestenjaBindingSource
        Me.ObavjestenjaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ObavjestenjaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ObavjestenjaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ObavjestenjaBindingNavigatorSaveItem})
        Me.ObavjestenjaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ObavjestenjaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ObavjestenjaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ObavjestenjaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ObavjestenjaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ObavjestenjaBindingNavigator.Name = "ObavjestenjaBindingNavigator"
        Me.ObavjestenjaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ObavjestenjaBindingNavigator.Size = New System.Drawing.Size(935, 25)
        Me.ObavjestenjaBindingNavigator.TabIndex = 1
        Me.ObavjestenjaBindingNavigator.Text = "BindingNavigator1"
        Me.ObavjestenjaBindingNavigator.Visible = False
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
        'ObavjestenjaBindingNavigatorSaveItem
        '
        Me.ObavjestenjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ObavjestenjaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ObavjestenjaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ObavjestenjaBindingNavigatorSaveItem.Name = "ObavjestenjaBindingNavigatorSaveItem"
        Me.ObavjestenjaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ObavjestenjaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(512, 2)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 69
        Me.BtnZatvori.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "obavjestenje_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Obavjestenja"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "obavjestenje_naslov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naslov Obavjestenja"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "obavjestenje"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Obavjestenje"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vrijemekreiranja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vrijeme kreiranja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Obavjestenja_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 298)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.ObavjestenjaBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Obavjestenja_form"
        Me.Text = "Obavjestenja_form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ObavjestenjaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObavjestenjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.VrijemekreiranjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemekreiranjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obavjestenje_naslovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObavjestenjeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObavjestenjaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObavjestenjaBindingNavigator.ResumeLayout(False)
        Me.ObavjestenjaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents ObavjestenjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObavjestenjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.obavjestenjaTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObavjestenjaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ObavjestenjaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Obavjestenje_naslovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ObavjestenjeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNovoObavjestenje As System.Windows.Forms.Button
    Friend WithEvents BtnDodajObavjestenje As System.Windows.Forms.Button
    Friend WithEvents VrijemekreiranjaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ObavjestenjaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
