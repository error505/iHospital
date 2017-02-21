<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IzvjestajSaOperacija_Form
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
        Dim TipLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim VrijemeLabel As System.Windows.Forms.Label
        Dim Doktor_idLabel As System.Windows.Forms.Label
        Dim Pacijent_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IzvjestajSaOperacija_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.Izvjestaj_operacijaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Izvjestaj_operacijaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNovIzvjestaj = New System.Windows.Forms.Button()
        Me.BtnDodajIzvjestaj = New System.Windows.Forms.Button()
        Me.TipTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VrijemeDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.Izvjestaj_operacijaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_operacijaTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.Izvjestaj_operacijaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        TipLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        VrijemeLabel = New System.Windows.Forms.Label()
        Doktor_idLabel = New System.Windows.Forms.Label()
        Pacijent_idLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Izvjestaj_operacijaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_operacijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_operacijaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Izvjestaj_operacijaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipLabel
        '
        TipLabel.AutoSize = True
        TipLabel.Location = New System.Drawing.Point(8, 42)
        TipLabel.Name = "TipLabel"
        TipLabel.Size = New System.Drawing.Size(25, 13)
        TipLabel.TabIndex = 2
        TipLabel.Text = "Tip:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(8, 68)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 4
        OpisLabel.Text = "Opis:"
        '
        'VrijemeLabel
        '
        VrijemeLabel.AutoSize = True
        VrijemeLabel.Location = New System.Drawing.Point(8, 94)
        VrijemeLabel.Name = "VrijemeLabel"
        VrijemeLabel.Size = New System.Drawing.Size(44, 13)
        VrijemeLabel.TabIndex = 6
        VrijemeLabel.Text = "Vrijeme:"
        '
        'Doktor_idLabel
        '
        Doktor_idLabel.AutoSize = True
        Doktor_idLabel.Location = New System.Drawing.Point(8, 120)
        Doktor_idLabel.Name = "Doktor_idLabel"
        Doktor_idLabel.Size = New System.Drawing.Size(42, 13)
        Doktor_idLabel.TabIndex = 8
        Doktor_idLabel.Text = "Doktor:"
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(8, 146)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel.TabIndex = 10
        Pacijent_idLabel.Text = "Pacijent:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 253)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.Izvjestaj_operacijaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Izvjestaja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(653, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 46
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(697, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 45
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'Izvjestaj_operacijaDataGridView
        '
        Me.Izvjestaj_operacijaDataGridView.AllowUserToAddRows = False
        Me.Izvjestaj_operacijaDataGridView.AutoGenerateColumns = False
        Me.Izvjestaj_operacijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Izvjestaj_operacijaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Izvjestaj_operacijaDataGridView.DataSource = Me.Izvjestaj_operacijaBindingSource
        Me.Izvjestaj_operacijaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Izvjestaj_operacijaDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Izvjestaj_operacijaDataGridView.Name = "Izvjestaj_operacijaDataGridView"
        Me.Izvjestaj_operacijaDataGridView.Size = New System.Drawing.Size(748, 221)
        Me.Izvjestaj_operacijaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "izvjestaj_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "izvjestaj_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tip"
        Me.DataGridViewTextBoxColumn2.HeaderText = "tip"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn3.HeaderText = "opis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vrijeme"
        Me.DataGridViewTextBoxColumn4.HeaderText = "vrijeme"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "doktor_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pacijent_id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Izvjestaj_operacijaBindingSource
        '
        Me.Izvjestaj_operacijaBindingSource.DataMember = "izvjestaj_operacija"
        Me.Izvjestaj_operacijaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.BtnNovIzvjestaj)
        Me.TabPage2.Controls.Add(Me.BtnDodajIzvjestaj)
        Me.TabPage2.Controls.Add(TipLabel)
        Me.TabPage2.Controls.Add(Me.TipTextEdit)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Controls.Add(VrijemeLabel)
        Me.TabPage2.Controls.Add(Me.VrijemeDateEdit)
        Me.TabPage2.Controls.Add(Doktor_idLabel)
        Me.TabPage2.Controls.Add(Pacijent_idLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Izvjestaj"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_operacijaBindingSource, "pacijent_id", True))
        Me.ComboBox2.DataSource = Me.PacijentBindingSource
        Me.ComboBox2.DisplayMember = "ime"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(72, 141)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 29
        Me.ComboBox2.ValueMember = "pacijent_id"
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_operacijaBindingSource, "doktor_id", True))
        Me.ComboBox1.DataSource = Me.DoktorBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(72, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.ValueMember = "doktor_id"
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnNovIzvjestaj
        '
        Me.BtnNovIzvjestaj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovIzvjestaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovIzvjestaj.Location = New System.Drawing.Point(6, 6)
        Me.BtnNovIzvjestaj.Name = "BtnNovIzvjestaj"
        Me.BtnNovIzvjestaj.Size = New System.Drawing.Size(104, 23)
        Me.BtnNovIzvjestaj.TabIndex = 27
        Me.BtnNovIzvjestaj.Text = "Novi Izvjestaj"
        Me.BtnNovIzvjestaj.UseVisualStyleBackColor = False
        '
        'BtnDodajIzvjestaj
        '
        Me.BtnDodajIzvjestaj.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajIzvjestaj.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajIzvjestaj.Location = New System.Drawing.Point(72, 181)
        Me.BtnDodajIzvjestaj.Name = "BtnDodajIzvjestaj"
        Me.BtnDodajIzvjestaj.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajIzvjestaj.TabIndex = 26
        Me.BtnDodajIzvjestaj.Text = "Dodaj Izvjestaj"
        Me.BtnDodajIzvjestaj.UseVisualStyleBackColor = False
        '
        'TipTextEdit
        '
        Me.TipTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "tip", True))
        Me.TipTextEdit.Location = New System.Drawing.Point(72, 39)
        Me.TipTextEdit.Name = "TipTextEdit"
        Me.TipTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TipTextEdit.TabIndex = 3
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(72, 65)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 5
        '
        'VrijemeDateEdit
        '
        Me.VrijemeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "vrijeme", True))
        Me.VrijemeDateEdit.EditValue = Nothing
        Me.VrijemeDateEdit.Location = New System.Drawing.Point(72, 91)
        Me.VrijemeDateEdit.Name = "VrijemeDateEdit"
        Me.VrijemeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.VrijemeDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeDateEdit.TabIndex = 7
        '
        'Izvjestaj_operacijaTableAdapter
        '
        Me.Izvjestaj_operacijaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banka_krviTableAdapter = Nothing
        Me.TableAdapterManager.dijagnoza_izvjestajTableAdapter = Nothing
        Me.TableAdapterManager.dodjela_krevetaTableAdapter = Nothing
        Me.TableAdapterManager.doktorTableAdapter = Me.DoktorTableAdapter
        Me.TableAdapterManager.donator_krviTableAdapter = Nothing
        Me.TableAdapterManager.email_templateTableAdapter = Nothing
        Me.TableAdapterManager.fakturaTableAdapter = Nothing
        Me.TableAdapterManager.farmaceutTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_o_rodjenjuTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_operacijaTableAdapter = Me.Izvjestaj_operacijaTableAdapter
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
        'DoktorTableAdapter
        '
        Me.DoktorTableAdapter.ClearBeforeFill = True
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'Izvjestaj_operacijaBindingNavigator
        '
        Me.Izvjestaj_operacijaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Izvjestaj_operacijaBindingNavigator.BindingSource = Me.Izvjestaj_operacijaBindingSource
        Me.Izvjestaj_operacijaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Izvjestaj_operacijaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Izvjestaj_operacijaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Izvjestaj_operacijaBindingNavigatorSaveItem})
        Me.Izvjestaj_operacijaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Izvjestaj_operacijaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Izvjestaj_operacijaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Izvjestaj_operacijaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Izvjestaj_operacijaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Izvjestaj_operacijaBindingNavigator.Name = "Izvjestaj_operacijaBindingNavigator"
        Me.Izvjestaj_operacijaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Izvjestaj_operacijaBindingNavigator.Size = New System.Drawing.Size(975, 25)
        Me.Izvjestaj_operacijaBindingNavigator.TabIndex = 1
        Me.Izvjestaj_operacijaBindingNavigator.Text = "BindingNavigator1"
        Me.Izvjestaj_operacijaBindingNavigator.Visible = False
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
        'Izvjestaj_operacijaBindingNavigatorSaveItem
        '
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Izvjestaj_operacijaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem.Name = "Izvjestaj_operacijaBindingNavigatorSaveItem"
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Izvjestaj_operacijaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(716, 0)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 42
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'IzvjestajSaOperacija_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 257)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.Izvjestaj_operacijaBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IzvjestajSaOperacija_Form"
        Me.Text = "IzvjestajSaOperacija_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Izvjestaj_operacijaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_operacijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_operacijaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Izvjestaj_operacijaBindingNavigator.ResumeLayout(False)
        Me.Izvjestaj_operacijaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents Izvjestaj_operacijaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Izvjestaj_operacijaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_operacijaTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Izvjestaj_operacijaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Izvjestaj_operacijaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Izvjestaj_operacijaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VrijemeDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNovIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents BtnDodajIzvjestaj As System.Windows.Forms.Button
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
End Class
