<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sastanci_Form
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
        Dim Doktor_idLabel As System.Windows.Forms.Label
        Dim Pacijent_idLabel As System.Windows.Forms.Label
        Dim Vrijem_sastankaLabel As System.Windows.Forms.Label
        Dim LokacijaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sastanci_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.SastanciDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SastanciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LokacijaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vrijem_sastankaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BtnNovSastanak = New System.Windows.Forms.Button()
        Me.BtnDodajSastanak = New System.Windows.Forms.Button()
        Me.SastanciTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.sastanciTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.SastanciBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SastanciBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Doktor_idLabel = New System.Windows.Forms.Label()
        Pacijent_idLabel = New System.Windows.Forms.Label()
        Vrijem_sastankaLabel = New System.Windows.Forms.Label()
        LokacijaLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SastanciDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SastanciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.LokacijaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vrijem_sastankaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vrijem_sastankaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SastanciBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SastanciBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Doktor_idLabel
        '
        Doktor_idLabel.AutoSize = True
        Doktor_idLabel.Location = New System.Drawing.Point(6, 69)
        Doktor_idLabel.Name = "Doktor_idLabel"
        Doktor_idLabel.Size = New System.Drawing.Size(56, 13)
        Doktor_idLabel.TabIndex = 4
        Doktor_idLabel.Text = "Doktor ID:"
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(6, 95)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(62, 13)
        Pacijent_idLabel.TabIndex = 6
        Pacijent_idLabel.Text = "Pacijent ID:"
        '
        'Vrijem_sastankaLabel
        '
        Vrijem_sastankaLabel.AutoSize = True
        Vrijem_sastankaLabel.Location = New System.Drawing.Point(7, 43)
        Vrijem_sastankaLabel.Name = "Vrijem_sastankaLabel"
        Vrijem_sastankaLabel.Size = New System.Drawing.Size(92, 13)
        Vrijem_sastankaLabel.TabIndex = 27
        Vrijem_sastankaLabel.Text = "Vrijeme Sastanka:"
        '
        'LokacijaLabel
        '
        LokacijaLabel.AutoSize = True
        LokacijaLabel.Location = New System.Drawing.Point(4, 131)
        LokacijaLabel.Name = "LokacijaLabel"
        LokacijaLabel.Size = New System.Drawing.Size(50, 13)
        LokacijaLabel.TabIndex = 32
        LokacijaLabel.Text = "Lokacija:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 274)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.SastanciDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(857, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Sastanaka"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(761, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 45
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(805, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 44
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'SastanciDataGridView
        '
        Me.SastanciDataGridView.AllowUserToAddRows = False
        Me.SastanciDataGridView.AutoGenerateColumns = False
        Me.SastanciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SastanciDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.SastanciDataGridView.DataSource = Me.SastanciBindingSource
        Me.SastanciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SastanciDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SastanciDataGridView.Name = "SastanciDataGridView"
        Me.SastanciDataGridView.Size = New System.Drawing.Size(851, 242)
        Me.SastanciDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sastanci_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "sastanci_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "doktor_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pacijent_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vrijem_sastanka"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vrijeme Sastanka"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Doktor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Doktor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pacijent"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pacijent"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Lokacija"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Lokacija"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'SastanciBindingSource
        '
        Me.SastanciBindingSource.DataMember = "sastanci"
        Me.SastanciBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(LokacijaLabel)
        Me.TabPage2.Controls.Add(Me.LokacijaTextEdit)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Vrijem_sastankaLabel)
        Me.TabPage2.Controls.Add(Me.Vrijem_sastankaDateEdit)
        Me.TabPage2.Controls.Add(Me.BtnNovSastanak)
        Me.TabPage2.Controls.Add(Me.BtnDodajSastanak)
        Me.TabPage2.Controls.Add(Doktor_idLabel)
        Me.TabPage2.Controls.Add(Pacijent_idLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(857, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Sastanak"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LokacijaTextEdit
        '
        Me.LokacijaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SastanciBindingSource, "Lokacija", True))
        Me.LokacijaTextEdit.Location = New System.Drawing.Point(97, 128)
        Me.LokacijaTextEdit.Name = "LokacijaTextEdit"
        Me.LokacijaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LokacijaTextEdit.TabIndex = 33
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SastanciBindingSource, "Pacijent", True))
        Me.ComboBox3.DataSource = Me.PacijentBindingSource
        Me.ComboBox3.DisplayMember = "ime"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(97, 98)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox3.TabIndex = 32
        Me.ComboBox3.ValueMember = "ime"
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SastanciBindingSource, "Doktor", True))
        Me.ComboBox4.DataSource = Me.DoktorBindingSource
        Me.ComboBox4.DisplayMember = "ime"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(97, 69)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox4.TabIndex = 31
        Me.ComboBox4.ValueMember = "ime"
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'Vrijem_sastankaDateEdit
        '
        Me.Vrijem_sastankaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SastanciBindingSource, "vrijem_sastanka", True))
        Me.Vrijem_sastankaDateEdit.EditValue = Nothing
        Me.Vrijem_sastankaDateEdit.Location = New System.Drawing.Point(97, 40)
        Me.Vrijem_sastankaDateEdit.Name = "Vrijem_sastankaDateEdit"
        Me.Vrijem_sastankaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Vrijem_sastankaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Vrijem_sastankaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.Vrijem_sastankaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.Vrijem_sastankaDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.Vrijem_sastankaDateEdit.TabIndex = 28
        '
        'BtnNovSastanak
        '
        Me.BtnNovSastanak.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovSastanak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovSastanak.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNovSastanak.Location = New System.Drawing.Point(8, 11)
        Me.BtnNovSastanak.Name = "BtnNovSastanak"
        Me.BtnNovSastanak.Size = New System.Drawing.Size(104, 23)
        Me.BtnNovSastanak.TabIndex = 25
        Me.BtnNovSastanak.Text = "Novi Sastanak"
        Me.BtnNovSastanak.UseVisualStyleBackColor = False
        '
        'BtnDodajSastanak
        '
        Me.BtnDodajSastanak.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajSastanak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajSastanak.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDodajSastanak.Location = New System.Drawing.Point(97, 169)
        Me.BtnDodajSastanak.Name = "BtnDodajSastanak"
        Me.BtnDodajSastanak.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajSastanak.TabIndex = 24
        Me.BtnDodajSastanak.Text = "Dodaj Sastanak"
        Me.BtnDodajSastanak.UseVisualStyleBackColor = False
        '
        'SastanciTableAdapter
        '
        Me.SastanciTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.sastanciTableAdapter = Me.SastanciTableAdapter
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SastanciBindingNavigator
        '
        Me.SastanciBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SastanciBindingNavigator.BindingSource = Me.SastanciBindingSource
        Me.SastanciBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SastanciBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SastanciBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SastanciBindingNavigatorSaveItem})
        Me.SastanciBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SastanciBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SastanciBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SastanciBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SastanciBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SastanciBindingNavigator.Name = "SastanciBindingNavigator"
        Me.SastanciBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SastanciBindingNavigator.Size = New System.Drawing.Size(596, 25)
        Me.SastanciBindingNavigator.TabIndex = 1
        Me.SastanciBindingNavigator.Text = "BindingNavigator1"
        Me.SastanciBindingNavigator.Visible = False
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
        'SastanciBindingNavigatorSaveItem
        '
        Me.SastanciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SastanciBindingNavigatorSaveItem.Image = CType(resources.GetObject("SastanciBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SastanciBindingNavigatorSaveItem.Name = "SastanciBindingNavigatorSaveItem"
        Me.SastanciBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SastanciBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(823, 3)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 37
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DoktorTableAdapter
        '
        Me.DoktorTableAdapter.ClearBeforeFill = True
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SastanciBindingSource, "pacijent_id", True))
        Me.ComboBox2.DataSource = Me.PacijentBindingSource
        Me.ComboBox2.DisplayMember = "ime"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(97, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 35
        Me.ComboBox2.ValueMember = "pacijent_id"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SastanciBindingSource, "doktor_id", True))
        Me.ComboBox1.DataSource = Me.DoktorBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(97, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "doktor_id"
        '
        'Sastanci_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 286)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.SastanciBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sastanci_Form"
        Me.Text = "Sastanci_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SastanciDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SastanciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.LokacijaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vrijem_sastankaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vrijem_sastankaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SastanciBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SastanciBindingNavigator.ResumeLayout(False)
        Me.SastanciBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents SastanciBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SastanciTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.sastanciTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SastanciBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SastanciBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNovSastanak As System.Windows.Forms.Button
    Friend WithEvents BtnDodajSastanak As System.Windows.Forms.Button
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents Vrijem_sastankaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents SastanciDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LokacijaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
