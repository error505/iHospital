﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratorija_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laboratorija_Form))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.LaborantDataGridView = New System.Windows.Forms.DataGridView()
        Me.LaborantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnDodajLaboranta = New System.Windows.Forms.Button()
        Me.BtnNoviLaborant = New System.Windows.Forms.Button()
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LaborantTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.LaborantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LaborantBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LaborantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LaborantBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(6, 54)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(72, 13)
        ImeLabel.TabIndex = 2
        ImeLabel.Text = "Ime i Prezime:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 80)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(6, 106)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(51, 13)
        PaswordLabel.TabIndex = 6
        PaswordLabel.Text = "Pasword:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(6, 132)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 8
        AdresaLabel.Text = "Adresa:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(6, 158)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 10
        TelefonLabel.Text = "Telefon:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(709, 276)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.LaborantDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(701, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Laboranata"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(610, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 49
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(654, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 48
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'LaborantDataGridView
        '
        Me.LaborantDataGridView.AllowUserToAddRows = False
        Me.LaborantDataGridView.AutoGenerateColumns = False
        Me.LaborantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaborantDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LaborantDataGridView.DataSource = Me.LaborantBindingSource
        Me.LaborantDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LaborantDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.LaborantDataGridView.Name = "LaborantDataGridView"
        Me.LaborantDataGridView.RowHeadersVisible = False
        Me.LaborantDataGridView.Size = New System.Drawing.Size(695, 244)
        Me.LaborantDataGridView.TabIndex = 0
        '
        'LaborantBindingSource
        '
        Me.LaborantBindingSource.DataMember = "laborant"
        Me.LaborantBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnDodajLaboranta)
        Me.TabPage2.Controls.Add(ImeLabel)
        Me.TabPage2.Controls.Add(Me.BtnNoviLaborant)
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
        Me.TabPage2.Size = New System.Drawing.Size(701, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Laboranta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnDodajLaboranta
        '
        Me.BtnDodajLaboranta.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajLaboranta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajLaboranta.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajLaboranta.Location = New System.Drawing.Point(52, 193)
        Me.BtnDodajLaboranta.Name = "BtnDodajLaboranta"
        Me.BtnDodajLaboranta.Size = New System.Drawing.Size(126, 23)
        Me.BtnDodajLaboranta.TabIndex = 45
        Me.BtnDodajLaboranta.Text = "Dodaj Laboranta"
        Me.BtnDodajLaboranta.UseVisualStyleBackColor = False
        '
        'BtnNoviLaborant
        '
        Me.BtnNoviLaborant.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviLaborant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviLaborant.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNoviLaborant.Location = New System.Drawing.Point(16, 22)
        Me.BtnNoviLaborant.Name = "BtnNoviLaborant"
        Me.BtnNoviLaborant.Size = New System.Drawing.Size(122, 23)
        Me.BtnNoviLaborant.TabIndex = 44
        Me.BtnNoviLaborant.Text = "Novi Laborant"
        Me.BtnNoviLaborant.UseVisualStyleBackColor = False
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LaborantBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(78, 51)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 3
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LaborantBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(78, 77)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextEdit.TabIndex = 5
        '
        'PaswordTextEdit
        '
        Me.PaswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LaborantBindingSource, "pasword", True))
        Me.PaswordTextEdit.Location = New System.Drawing.Point(78, 103)
        Me.PaswordTextEdit.Name = "PaswordTextEdit"
        Me.PaswordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PaswordTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextEdit.TabIndex = 7
        '
        'AdresaTextEdit
        '
        Me.AdresaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LaborantBindingSource, "adresa", True))
        Me.AdresaTextEdit.Location = New System.Drawing.Point(78, 129)
        Me.AdresaTextEdit.Name = "AdresaTextEdit"
        Me.AdresaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresaTextEdit.TabIndex = 9
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LaborantBindingSource, "telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(78, 155)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextEdit.TabIndex = 11
        '
        'LaborantTableAdapter
        '
        Me.LaborantTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.laborantTableAdapter = Me.LaborantTableAdapter
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
        'LaborantBindingNavigator
        '
        Me.LaborantBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LaborantBindingNavigator.BindingSource = Me.LaborantBindingSource
        Me.LaborantBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LaborantBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LaborantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LaborantBindingNavigatorSaveItem})
        Me.LaborantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LaborantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LaborantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LaborantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LaborantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LaborantBindingNavigator.Name = "LaborantBindingNavigator"
        Me.LaborantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LaborantBindingNavigator.Size = New System.Drawing.Size(725, 25)
        Me.LaborantBindingNavigator.TabIndex = 1
        Me.LaborantBindingNavigator.Text = "BindingNavigator1"
        Me.LaborantBindingNavigator.Visible = False
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
        'LaborantBindingNavigatorSaveItem
        '
        Me.LaborantBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LaborantBindingNavigatorSaveItem.Image = CType(resources.GetObject("LaborantBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LaborantBindingNavigatorSaveItem.Name = "LaborantBindingNavigatorSaveItem"
        Me.LaborantBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LaborantBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(674, 2)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 47
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "laborant_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Laboranta"
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
        'Laboratorija_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 283)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.LaborantBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laboratorija_Form"
        Me.Text = "Laboratorija_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.LaborantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LaborantBindingNavigator.ResumeLayout(False)
        Me.LaborantBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents LaborantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LaborantTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.laborantTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaborantBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LaborantBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LaborantDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnDodajLaboranta As System.Windows.Forms.Button
    Friend WithEvents BtnNoviLaborant As System.Windows.Forms.Button
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
