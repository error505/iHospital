<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doktor_Forma
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
        Dim Odjeljenje_idLabel As System.Windows.Forms.Label
        Dim ProfilLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doktor_Forma))
        Me.Doktor_Tabela = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnUredi = New System.Windows.Forms.Button()
        Me.BtnIzbrisi = New System.Windows.Forms.Button()
        Me.DoktorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OdjeljenjeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProfilTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BtnNoviDoktor = New System.Windows.Forms.Button()
        Me.BtnDodajDoktora = New System.Windows.Forms.Button()
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.OdjeljenjeTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.odjeljenjeTableAdapter()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.DoktoridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OdjeljenjeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        AdresaLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Odjeljenje_idLabel = New System.Windows.Forms.Label()
        ProfilLabel = New System.Windows.Forms.Label()
        Me.Doktor_Tabela.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DoktorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.OdjeljenjeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(8, 59)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(72, 13)
        ImeLabel.TabIndex = 19
        ImeLabel.Text = "Ime i Prezime:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(8, 85)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 21
        EmailLabel.Text = "Email:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(8, 111)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(51, 13)
        PaswordLabel.TabIndex = 23
        PaswordLabel.Text = "Pasword:"
        '
        'AdresaLabel
        '
        AdresaLabel.AutoSize = True
        AdresaLabel.Location = New System.Drawing.Point(8, 137)
        AdresaLabel.Name = "AdresaLabel"
        AdresaLabel.Size = New System.Drawing.Size(43, 13)
        AdresaLabel.TabIndex = 25
        AdresaLabel.Text = "Adresa:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(8, 163)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 27
        TelefonLabel.Text = "Telefon:"
        '
        'Odjeljenje_idLabel
        '
        Odjeljenje_idLabel.AutoSize = True
        Odjeljenje_idLabel.Location = New System.Drawing.Point(8, 189)
        Odjeljenje_idLabel.Name = "Odjeljenje_idLabel"
        Odjeljenje_idLabel.Size = New System.Drawing.Size(56, 13)
        Odjeljenje_idLabel.TabIndex = 29
        Odjeljenje_idLabel.Text = "Odjeljenje:"
        '
        'ProfilLabel
        '
        ProfilLabel.AutoSize = True
        ProfilLabel.Location = New System.Drawing.Point(8, 215)
        ProfilLabel.Name = "ProfilLabel"
        ProfilLabel.Size = New System.Drawing.Size(33, 13)
        ProfilLabel.TabIndex = 31
        ProfilLabel.Text = "Profil:"
        '
        'Doktor_Tabela
        '
        Me.Doktor_Tabela.Controls.Add(Me.TabPage1)
        Me.Doktor_Tabela.Controls.Add(Me.TabPage2)
        Me.Doktor_Tabela.Location = New System.Drawing.Point(12, 12)
        Me.Doktor_Tabela.Name = "Doktor_Tabela"
        Me.Doktor_Tabela.SelectedIndex = 0
        Me.Doktor_Tabela.Size = New System.Drawing.Size(912, 299)
        Me.Doktor_Tabela.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BtnUredi)
        Me.TabPage1.Controls.Add(Me.BtnIzbrisi)
        Me.TabPage1.Controls.Add(Me.DoktorDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(904, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Lista Doktora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(814, 28)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 2
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(858, 28)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 1
        Me.BtnIzbrisi.UseVisualStyleBackColor = True
        '
        'DoktorDataGridView
        '
        Me.DoktorDataGridView.AllowUserToAddRows = False
        Me.DoktorDataGridView.AutoGenerateColumns = False
        Me.DoktorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoktorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DoktoridDataGridViewTextBoxColumn, Me.ImeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PaswordDataGridViewTextBoxColumn, Me.AdresaDataGridViewTextBoxColumn, Me.TelefonDataGridViewTextBoxColumn, Me.OdjeljenjeidDataGridViewTextBoxColumn, Me.ProfilDataGridViewTextBoxColumn})
        Me.DoktorDataGridView.DataSource = Me.DoktorBindingSource
        Me.DoktorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DoktorDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DoktorDataGridView.Name = "DoktorDataGridView"
        Me.DoktorDataGridView.RowHeadersVisible = False
        Me.DoktorDataGridView.Size = New System.Drawing.Size(898, 267)
        Me.DoktorDataGridView.TabIndex = 0
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
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
        Me.TabPage2.Controls.Add(Odjeljenje_idLabel)
        Me.TabPage2.Controls.Add(ProfilLabel)
        Me.TabPage2.Controls.Add(Me.ProfilTextEdit)
        Me.TabPage2.Controls.Add(Me.BtnNoviDoktor)
        Me.TabPage2.Controls.Add(Me.BtnDodajDoktora)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(904, 273)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ Dodaj Doktora"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.DoktorBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(898, 25)
        Me.BindingNavigator1.TabIndex = 34
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
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
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DoktorBindingSource, "odjeljenje_id", True))
        Me.ComboBox1.DataSource = Me.OdjeljenjeBindingSource
        Me.ComboBox1.DisplayMember = "ime"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(85, 187)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 33
        Me.ComboBox1.ValueMember = "odjeljenje_id"
        '
        'OdjeljenjeBindingSource
        '
        Me.OdjeljenjeBindingSource.DataMember = "odjeljenje"
        Me.OdjeljenjeBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'ImeTextEdit
        '
        Me.ImeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "ime", True))
        Me.ImeTextEdit.Location = New System.Drawing.Point(84, 56)
        Me.ImeTextEdit.Name = "ImeTextEdit"
        Me.ImeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ImeTextEdit.TabIndex = 20
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(84, 82)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextEdit.TabIndex = 22
        '
        'PaswordTextEdit
        '
        Me.PaswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "pasword", True))
        Me.PaswordTextEdit.Location = New System.Drawing.Point(84, 108)
        Me.PaswordTextEdit.Name = "PaswordTextEdit"
        Me.PaswordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PaswordTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextEdit.TabIndex = 24
        '
        'AdresaTextEdit
        '
        Me.AdresaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "adresa", True))
        Me.AdresaTextEdit.Location = New System.Drawing.Point(84, 134)
        Me.AdresaTextEdit.Name = "AdresaTextEdit"
        Me.AdresaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresaTextEdit.TabIndex = 26
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(84, 160)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextEdit.TabIndex = 28
        '
        'ProfilTextEdit
        '
        Me.ProfilTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DoktorBindingSource, "profil", True))
        Me.ProfilTextEdit.Location = New System.Drawing.Point(84, 212)
        Me.ProfilTextEdit.Name = "ProfilTextEdit"
        Me.ProfilTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ProfilTextEdit.TabIndex = 32
        '
        'BtnNoviDoktor
        '
        Me.BtnNoviDoktor.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNoviDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoviDoktor.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNoviDoktor.Location = New System.Drawing.Point(12, 20)
        Me.BtnNoviDoktor.Name = "BtnNoviDoktor"
        Me.BtnNoviDoktor.Size = New System.Drawing.Size(75, 23)
        Me.BtnNoviDoktor.TabIndex = 17
        Me.BtnNoviDoktor.Text = "Novi Doktor"
        Me.BtnNoviDoktor.UseVisualStyleBackColor = False
        '
        'BtnDodajDoktora
        '
        Me.BtnDodajDoktora.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajDoktora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajDoktora.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajDoktora.Location = New System.Drawing.Point(84, 244)
        Me.BtnDodajDoktora.Name = "BtnDodajDoktora"
        Me.BtnDodajDoktora.Size = New System.Drawing.Size(100, 23)
        Me.BtnDodajDoktora.TabIndex = 16
        Me.BtnDodajDoktora.Text = "Dodaj Doktora"
        Me.BtnDodajDoktora.UseVisualStyleBackColor = False
        '
        'DoktorTableAdapter
        '
        Me.DoktorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.izvjestaj_operacijaTableAdapter = Nothing
        Me.TableAdapterManager.izvjestaj_smrtTableAdapter = Nothing
        Me.TableAdapterManager.izvjestajTableAdapter = Nothing
        Me.TableAdapterManager.kategorije_lijekovaTableAdapter = Nothing
        Me.TableAdapterManager.krevetTableAdapter = Nothing
        Me.TableAdapterManager.laborantTableAdapter = Nothing
        Me.TableAdapterManager.lijekoviTableAdapter = Nothing
        Me.TableAdapterManager.menadzmentTableAdapter = Nothing
        Me.TableAdapterManager.obavjestenjaTableAdapter = Nothing
        Me.TableAdapterManager.odjeljenjeTableAdapter = Me.OdjeljenjeTableAdapter
        Me.TableAdapterManager.pacijentTableAdapter = Nothing
        Me.TableAdapterManager.placanjeTableAdapter = Nothing
        Me.TableAdapterManager.podesavanjaTableAdapter = Nothing
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OdjeljenjeTableAdapter
        '
        Me.OdjeljenjeTableAdapter.ClearBeforeFill = True
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(876, 4)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 30
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DoktoridDataGridViewTextBoxColumn
        '
        Me.DoktoridDataGridViewTextBoxColumn.DataPropertyName = "doktor_id"
        Me.DoktoridDataGridViewTextBoxColumn.HeaderText = "ID Doktora"
        Me.DoktoridDataGridViewTextBoxColumn.Name = "DoktoridDataGridViewTextBoxColumn"
        Me.DoktoridDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImeDataGridViewTextBoxColumn
        '
        Me.ImeDataGridViewTextBoxColumn.DataPropertyName = "ime"
        Me.ImeDataGridViewTextBoxColumn.HeaderText = "Ime i Prezime"
        Me.ImeDataGridViewTextBoxColumn.Name = "ImeDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PaswordDataGridViewTextBoxColumn
        '
        Me.PaswordDataGridViewTextBoxColumn.DataPropertyName = "pasword"
        Me.PaswordDataGridViewTextBoxColumn.HeaderText = "Pasword"
        Me.PaswordDataGridViewTextBoxColumn.Name = "PaswordDataGridViewTextBoxColumn"
        '
        'AdresaDataGridViewTextBoxColumn
        '
        Me.AdresaDataGridViewTextBoxColumn.DataPropertyName = "adresa"
        Me.AdresaDataGridViewTextBoxColumn.HeaderText = "Adresa"
        Me.AdresaDataGridViewTextBoxColumn.Name = "AdresaDataGridViewTextBoxColumn"
        '
        'TelefonDataGridViewTextBoxColumn
        '
        Me.TelefonDataGridViewTextBoxColumn.DataPropertyName = "telefon"
        Me.TelefonDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.Name = "TelefonDataGridViewTextBoxColumn"
        '
        'OdjeljenjeidDataGridViewTextBoxColumn
        '
        Me.OdjeljenjeidDataGridViewTextBoxColumn.DataPropertyName = "odjeljenje_id"
        Me.OdjeljenjeidDataGridViewTextBoxColumn.HeaderText = "ID Odjeljenja"
        Me.OdjeljenjeidDataGridViewTextBoxColumn.Name = "OdjeljenjeidDataGridViewTextBoxColumn"
        '
        'ProfilDataGridViewTextBoxColumn
        '
        Me.ProfilDataGridViewTextBoxColumn.DataPropertyName = "profil"
        Me.ProfilDataGridViewTextBoxColumn.HeaderText = "Profil"
        Me.ProfilDataGridViewTextBoxColumn.Name = "ProfilDataGridViewTextBoxColumn"
        '
        'Doktor_Forma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 311)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.Doktor_Tabela)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Doktor_Forma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doktor"
        Me.Doktor_Tabela.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DoktorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.OdjeljenjeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Doktor_Tabela As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents DoktorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnNoviDoktor As System.Windows.Forms.Button
    Friend WithEvents BtnDodajDoktora As System.Windows.Forms.Button
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ImeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PaswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProfilTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OdjeljenjeTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.odjeljenjeTableAdapter
    Friend WithEvents OdjeljenjeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents DoktoridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdjeljenjeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
