<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepti_Form
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
        Dim Istorija_slucajaLabel As System.Windows.Forms.Label
        Dim LijekLabel As System.Windows.Forms.Label
        Dim Lijek_od_farmaceutaLabel As System.Windows.Forms.Label
        Dim OpisLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepti_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReceptDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnDodajRecept = New System.Windows.Forms.Button()
        Me.BtnNoviRecept = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.FarmaceutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LijekoviBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Istorija_slucajaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.ReceptTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.receptTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.ReceptBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ReceptBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.LijekoviTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.lijekoviTableAdapter()
        Me.FarmaceutTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.farmaceutTableAdapter()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Doktor_idLabel = New System.Windows.Forms.Label()
        Pacijent_idLabel = New System.Windows.Forms.Label()
        Istorija_slucajaLabel = New System.Windows.Forms.Label()
        LijekLabel = New System.Windows.Forms.Label()
        Lijek_od_farmaceutaLabel = New System.Windows.Forms.Label()
        OpisLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ReceptDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaceutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LijekoviBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Istorija_slucajaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceptBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Doktor_idLabel
        '
        Doktor_idLabel.AutoSize = True
        Doktor_idLabel.Location = New System.Drawing.Point(8, 64)
        Doktor_idLabel.Name = "Doktor_idLabel"
        Doktor_idLabel.Size = New System.Drawing.Size(56, 13)
        Doktor_idLabel.TabIndex = 4
        Doktor_idLabel.Text = "Doktor ID:"
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(8, 91)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(62, 13)
        Pacijent_idLabel.TabIndex = 6
        Pacijent_idLabel.Text = "Pacijent ID:"
        '
        'Istorija_slucajaLabel
        '
        Istorija_slucajaLabel.AutoSize = True
        Istorija_slucajaLabel.Location = New System.Drawing.Point(8, 117)
        Istorija_slucajaLabel.Name = "Istorija_slucajaLabel"
        Istorija_slucajaLabel.Size = New System.Drawing.Size(76, 13)
        Istorija_slucajaLabel.TabIndex = 8
        Istorija_slucajaLabel.Text = "Istorija slucaja:"
        '
        'LijekLabel
        '
        LijekLabel.AutoSize = True
        LijekLabel.Location = New System.Drawing.Point(8, 143)
        LijekLabel.Name = "LijekLabel"
        LijekLabel.Size = New System.Drawing.Size(32, 13)
        LijekLabel.TabIndex = 10
        LijekLabel.Text = "Lijek:"
        '
        'Lijek_od_farmaceutaLabel
        '
        Lijek_od_farmaceutaLabel.AutoSize = True
        Lijek_od_farmaceutaLabel.Location = New System.Drawing.Point(8, 169)
        Lijek_od_farmaceutaLabel.Name = "Lijek_od_farmaceutaLabel"
        Lijek_od_farmaceutaLabel.Size = New System.Drawing.Size(103, 13)
        Lijek_od_farmaceutaLabel.TabIndex = 12
        Lijek_od_farmaceutaLabel.Text = "Lijek od farmaceuta:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(8, 195)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 14
        OpisLabel.Text = "Opis:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 382)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReceptDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1067, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Recepata"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReceptDataGridView
        '
        Me.ReceptDataGridView.AllowUserToAddRows = False
        Me.ReceptDataGridView.AutoGenerateColumns = False
        Me.ReceptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceptDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ReceptDataGridView.DataSource = Me.ReceptBindingSource
        Me.ReceptDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceptDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ReceptDataGridView.Name = "ReceptDataGridView"
        Me.ReceptDataGridView.Size = New System.Drawing.Size(1061, 350)
        Me.ReceptDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "recept_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Recepta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID Doktora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID Pacijenta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "istorija_slucaja"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Istorija slucaja"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "lijek"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lijek"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "lijek_od_farmaceuta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lijek od farmaceuta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Doktor"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Doktor"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Pacijent"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pacijent"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ReceptBindingSource
        '
        Me.ReceptBindingSource.DataMember = "recept"
        Me.ReceptBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.ComboBox5)
        Me.TabPage2.Controls.Add(Me.ComboBox6)
        Me.TabPage2.Controls.Add(Me.BtnDodajRecept)
        Me.TabPage2.Controls.Add(Me.BtnNoviRecept)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Doktor_idLabel)
        Me.TabPage2.Controls.Add(Pacijent_idLabel)
        Me.TabPage2.Controls.Add(Istorija_slucajaLabel)
        Me.TabPage2.Controls.Add(Me.Istorija_slucajaTextEdit)
        Me.TabPage2.Controls.Add(LijekLabel)
        Me.TabPage2.Controls.Add(Lijek_od_farmaceutaLabel)
        Me.TabPage2.Controls.Add(OpisLabel)
        Me.TabPage2.Controls.Add(Me.OpisTextEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1067, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Recept"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "Doktor", True))
        Me.ComboBox5.DataSource = Me.DoktorBindingSource
        Me.ComboBox5.DisplayMember = "ime"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(113, 51)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox5.TabIndex = 45
        Me.ComboBox5.ValueMember = "ime"
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "Pacijent", True))
        Me.ComboBox6.DataSource = Me.PacijentBindingSource
        Me.ComboBox6.DisplayMember = "ime"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(113, 83)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox6.TabIndex = 44
        Me.ComboBox6.ValueMember = "ime"
        '
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnDodajRecept
        '
        Me.BtnDodajRecept.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajRecept.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnDodajRecept.Location = New System.Drawing.Point(131, 228)
        Me.BtnDodajRecept.Name = "BtnDodajRecept"
        Me.BtnDodajRecept.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajRecept.TabIndex = 41
        Me.BtnDodajRecept.Text = "Dodaj Recept"
        Me.BtnDodajRecept.UseVisualStyleBackColor = False
        '
        'BtnNoviRecept
        '
        Me.BtnNoviRecept.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviRecept.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNoviRecept.Location = New System.Drawing.Point(11, 20)
        Me.BtnNoviRecept.Name = "BtnNoviRecept"
        Me.BtnNoviRecept.Size = New System.Drawing.Size(122, 23)
        Me.BtnNoviRecept.TabIndex = 40
        Me.BtnNoviRecept.Text = "Novi Recept"
        Me.BtnNoviRecept.UseVisualStyleBackColor = False
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "lijek_od_farmaceuta", True))
        Me.ComboBox4.DataSource = Me.FarmaceutBindingSource
        Me.ComboBox4.DisplayMember = "ime"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(113, 166)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox4.TabIndex = 19
        Me.ComboBox4.ValueMember = "ime"
        '
        'FarmaceutBindingSource
        '
        Me.FarmaceutBindingSource.DataMember = "farmaceut"
        Me.FarmaceutBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "lijek", True))
        Me.ComboBox3.DataSource = Me.LijekoviBindingSource
        Me.ComboBox3.DisplayMember = "ime"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(113, 140)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox3.TabIndex = 18
        Me.ComboBox3.ValueMember = "ime"
        '
        'LijekoviBindingSource
        '
        Me.LijekoviBindingSource.DataMember = "lijekovi"
        Me.LijekoviBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'Istorija_slucajaTextEdit
        '
        Me.Istorija_slucajaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceptBindingSource, "istorija_slucaja", True))
        Me.Istorija_slucajaTextEdit.Location = New System.Drawing.Point(113, 114)
        Me.Istorija_slucajaTextEdit.Name = "Istorija_slucajaTextEdit"
        Me.Istorija_slucajaTextEdit.Size = New System.Drawing.Size(118, 20)
        Me.Istorija_slucajaTextEdit.TabIndex = 9
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ReceptBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(113, 192)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(118, 20)
        Me.OpisTextEdit.TabIndex = 15
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(984, 36)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 41
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(1028, 36)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 40
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'ReceptTableAdapter
        '
        Me.ReceptTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.receptTableAdapter = Me.ReceptTableAdapter
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceptBindingNavigator
        '
        Me.ReceptBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceptBindingNavigator.BindingSource = Me.ReceptBindingSource
        Me.ReceptBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceptBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceptBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceptBindingNavigatorSaveItem})
        Me.ReceptBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceptBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceptBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceptBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceptBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceptBindingNavigator.Name = "ReceptBindingNavigator"
        Me.ReceptBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceptBindingNavigator.Size = New System.Drawing.Size(974, 25)
        Me.ReceptBindingNavigator.TabIndex = 1
        Me.ReceptBindingNavigator.Text = "BindingNavigator1"
        Me.ReceptBindingNavigator.Visible = False
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
        'ReceptBindingNavigatorSaveItem
        '
        Me.ReceptBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceptBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceptBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceptBindingNavigatorSaveItem.Name = "ReceptBindingNavigatorSaveItem"
        Me.ReceptBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReceptBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DoktorTableAdapter
        '
        Me.DoktorTableAdapter.ClearBeforeFill = True
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'LijekoviTableAdapter
        '
        Me.LijekoviTableAdapter.ClearBeforeFill = True
        '
        'FarmaceutTableAdapter
        '
        Me.FarmaceutTableAdapter.ClearBeforeFill = True
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(1033, 2)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 36
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "doktor_id", True))
        Me.ComboBox1.DataSource = Me.DoktorBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 47
        Me.ComboBox1.ValueMember = "doktor_id"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReceptBindingSource, "pacijent_id", True))
        Me.ComboBox2.DataSource = Me.PacijentBindingSource
        Me.ComboBox2.DisplayMember = "ime"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(113, 83)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(118, 21)
        Me.ComboBox2.TabIndex = 46
        Me.ComboBox2.ValueMember = "pacijent_id"
        '
        'Recepti_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 391)
        Me.Controls.Add(Me.BtnUredi)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.BtnIzbrisi)
        Me.Controls.Add(Me.ReceptBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recepti_Form"
        Me.Text = "Recepti_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ReceptDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaceutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LijekoviBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Istorija_slucajaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceptBindingNavigator.ResumeLayout(False)
        Me.ReceptBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents ReceptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceptTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.receptTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReceptBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReceptBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Istorija_slucajaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents LijekoviBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LijekoviTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.lijekoviTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents FarmaceutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FarmaceutTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.farmaceutTableAdapter
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents BtnNoviRecept As System.Windows.Forms.Button
    Friend WithEvents BtnDodajRecept As System.Windows.Forms.Button
    Friend WithEvents ReceptDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
