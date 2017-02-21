<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DodajIzvjestaj_Form
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
        Dim Pacijent_idLabel2 As System.Windows.Forms.Label
        Dim Doktor_idLabel2 As System.Windows.Forms.Label
        Dim VrijemeLabel2 As System.Windows.Forms.Label
        Dim OpisLabel2 As System.Windows.Forms.Label
        Dim Pacijent_idLabel1 As System.Windows.Forms.Label
        Dim Doktor_idLabel1 As System.Windows.Forms.Label
        Dim VrijemeLabel1 As System.Windows.Forms.Label
        Dim OpisLabel1 As System.Windows.Forms.Label
        Dim Izvjestaj_o_rodjenjuLabel As System.Windows.Forms.Label
        Dim Izvjestaj_smrti_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DodajIzvjestaj_Form))
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Izvjestaj_o_rodjenjuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Izvjestaj_o_rodjenjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Izvjestaj_smrtDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Izvjestaj_smrtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNovaOperacija = New System.Windows.Forms.Button()
        Me.BtnDodajObavjestenje = New System.Windows.Forms.Button()
        Me.TipTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VrijemeDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Izvjestaj_o_rodjenjuSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OpisTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.VrijemeDateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Izvjestaj_smrti_idSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.PacijentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.OpisTextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.VrijemeDateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.Izvjestaj_operacijaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_operacijaTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.Izvjestaj_o_rodjenjuTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_o_rodjenjuTableAdapter()
        Me.Izvjestaj_smrtTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_smrtTableAdapter()
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
        Pacijent_idLabel2 = New System.Windows.Forms.Label()
        Doktor_idLabel2 = New System.Windows.Forms.Label()
        VrijemeLabel2 = New System.Windows.Forms.Label()
        OpisLabel2 = New System.Windows.Forms.Label()
        Pacijent_idLabel1 = New System.Windows.Forms.Label()
        Doktor_idLabel1 = New System.Windows.Forms.Label()
        VrijemeLabel1 = New System.Windows.Forms.Label()
        OpisLabel1 = New System.Windows.Forms.Label()
        Izvjestaj_o_rodjenjuLabel = New System.Windows.Forms.Label()
        Izvjestaj_smrti_idLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Izvjestaj_operacijaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_operacijaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Izvjestaj_o_rodjenjuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_o_rodjenjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Izvjestaj_smrtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_smrtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Izvjestaj_o_rodjenjuSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.Izvjestaj_smrti_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpisTextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VrijemeDateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Izvjestaj_operacijaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Izvjestaj_operacijaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipLabel
        '
        TipLabel.AutoSize = True
        TipLabel.Location = New System.Drawing.Point(15, 50)
        TipLabel.Name = "TipLabel"
        TipLabel.Size = New System.Drawing.Size(25, 13)
        TipLabel.TabIndex = 2
        TipLabel.Text = "Tip:"
        '
        'OpisLabel
        '
        OpisLabel.AutoSize = True
        OpisLabel.Location = New System.Drawing.Point(15, 76)
        OpisLabel.Name = "OpisLabel"
        OpisLabel.Size = New System.Drawing.Size(31, 13)
        OpisLabel.TabIndex = 4
        OpisLabel.Text = "Opis:"
        '
        'VrijemeLabel
        '
        VrijemeLabel.AutoSize = True
        VrijemeLabel.Location = New System.Drawing.Point(15, 102)
        VrijemeLabel.Name = "VrijemeLabel"
        VrijemeLabel.Size = New System.Drawing.Size(44, 13)
        VrijemeLabel.TabIndex = 6
        VrijemeLabel.Text = "Vrijeme:"
        '
        'Doktor_idLabel
        '
        Doktor_idLabel.AutoSize = True
        Doktor_idLabel.Location = New System.Drawing.Point(15, 128)
        Doktor_idLabel.Name = "Doktor_idLabel"
        Doktor_idLabel.Size = New System.Drawing.Size(42, 13)
        Doktor_idLabel.TabIndex = 8
        Doktor_idLabel.Text = "Doktor:"
        '
        'Pacijent_idLabel
        '
        Pacijent_idLabel.AutoSize = True
        Pacijent_idLabel.Location = New System.Drawing.Point(15, 154)
        Pacijent_idLabel.Name = "Pacijent_idLabel"
        Pacijent_idLabel.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel.TabIndex = 10
        Pacijent_idLabel.Text = "Pacijent:"
        '
        'Pacijent_idLabel2
        '
        Pacijent_idLabel2.AutoSize = True
        Pacijent_idLabel2.Location = New System.Drawing.Point(11, 144)
        Pacijent_idLabel2.Name = "Pacijent_idLabel2"
        Pacijent_idLabel2.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel2.TabIndex = 8
        Pacijent_idLabel2.Text = "Pacijent:"
        '
        'Doktor_idLabel2
        '
        Doktor_idLabel2.AutoSize = True
        Doktor_idLabel2.Location = New System.Drawing.Point(11, 118)
        Doktor_idLabel2.Name = "Doktor_idLabel2"
        Doktor_idLabel2.Size = New System.Drawing.Size(42, 13)
        Doktor_idLabel2.TabIndex = 6
        Doktor_idLabel2.Text = "Doktor:"
        '
        'VrijemeLabel2
        '
        VrijemeLabel2.AutoSize = True
        VrijemeLabel2.Location = New System.Drawing.Point(11, 92)
        VrijemeLabel2.Name = "VrijemeLabel2"
        VrijemeLabel2.Size = New System.Drawing.Size(44, 13)
        VrijemeLabel2.TabIndex = 4
        VrijemeLabel2.Text = "Vrijeme:"
        '
        'OpisLabel2
        '
        OpisLabel2.AutoSize = True
        OpisLabel2.Location = New System.Drawing.Point(11, 66)
        OpisLabel2.Name = "OpisLabel2"
        OpisLabel2.Size = New System.Drawing.Size(31, 13)
        OpisLabel2.TabIndex = 2
        OpisLabel2.Text = "Opis:"
        '
        'Pacijent_idLabel1
        '
        Pacijent_idLabel1.AutoSize = True
        Pacijent_idLabel1.Location = New System.Drawing.Point(8, 144)
        Pacijent_idLabel1.Name = "Pacijent_idLabel1"
        Pacijent_idLabel1.Size = New System.Drawing.Size(48, 13)
        Pacijent_idLabel1.TabIndex = 8
        Pacijent_idLabel1.Text = "Pacijent:"
        '
        'Doktor_idLabel1
        '
        Doktor_idLabel1.AutoSize = True
        Doktor_idLabel1.Location = New System.Drawing.Point(8, 118)
        Doktor_idLabel1.Name = "Doktor_idLabel1"
        Doktor_idLabel1.Size = New System.Drawing.Size(42, 13)
        Doktor_idLabel1.TabIndex = 6
        Doktor_idLabel1.Text = "Doktor:"
        '
        'VrijemeLabel1
        '
        VrijemeLabel1.AutoSize = True
        VrijemeLabel1.Location = New System.Drawing.Point(8, 92)
        VrijemeLabel1.Name = "VrijemeLabel1"
        VrijemeLabel1.Size = New System.Drawing.Size(44, 13)
        VrijemeLabel1.TabIndex = 4
        VrijemeLabel1.Text = "Vrijeme:"
        '
        'OpisLabel1
        '
        OpisLabel1.AutoSize = True
        OpisLabel1.Location = New System.Drawing.Point(8, 66)
        OpisLabel1.Name = "OpisLabel1"
        OpisLabel1.Size = New System.Drawing.Size(31, 13)
        OpisLabel1.TabIndex = 2
        OpisLabel1.Text = "Opis:"
        '
        'Izvjestaj_o_rodjenjuLabel
        '
        Izvjestaj_o_rodjenjuLabel.AutoSize = True
        Izvjestaj_o_rodjenjuLabel.Location = New System.Drawing.Point(8, 44)
        Izvjestaj_o_rodjenjuLabel.Name = "Izvjestaj_o_rodjenjuLabel"
        Izvjestaj_o_rodjenjuLabel.Size = New System.Drawing.Size(97, 13)
        Izvjestaj_o_rodjenjuLabel.TabIndex = 61
        Izvjestaj_o_rodjenjuLabel.Text = "Izvjestaj o rodjenju:"
        '
        'Izvjestaj_smrti_idLabel
        '
        Izvjestaj_smrti_idLabel.AutoSize = True
        Izvjestaj_smrti_idLabel.Location = New System.Drawing.Point(11, 44)
        Izvjestaj_smrti_idLabel.Name = "Izvjestaj_smrti_idLabel"
        Izvjestaj_smrti_idLabel.Size = New System.Drawing.Size(82, 13)
        Izvjestaj_smrti_idLabel.TabIndex = 61
        Izvjestaj_smrti_idLabel.Text = "izvjestaj smrti id:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 348)
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
        Me.TabPage1.Size = New System.Drawing.Size(752, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "= Izvjestaj Operacija"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnUredi
        '
        Me.BtnUredi.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.BtnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUredi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUredi.Location = New System.Drawing.Point(658, 6)
        Me.BtnUredi.Name = "BtnUredi"
        Me.BtnUredi.Size = New System.Drawing.Size(38, 28)
        Me.BtnUredi.TabIndex = 78
        Me.BtnUredi.UseVisualStyleBackColor = True
        '
        'BtnIzbrisi
        '
        Me.BtnIzbrisi.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIzbrisi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnIzbrisi.Location = New System.Drawing.Point(702, 6)
        Me.BtnIzbrisi.Name = "BtnIzbrisi"
        Me.BtnIzbrisi.Size = New System.Drawing.Size(38, 28)
        Me.BtnIzbrisi.TabIndex = 77
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
        Me.Izvjestaj_operacijaDataGridView.Size = New System.Drawing.Size(746, 316)
        Me.Izvjestaj_operacijaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "izvjestaj_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Izvjstaja"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tip"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tip"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vrijeme"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vrijeme"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID Doktora"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID Pacijenta"
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
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Izvjestaj_o_rodjenjuDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "= Izvjestaj Rodjenje"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(558, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 28)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(602, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 28)
        Me.Button2.TabIndex = 77
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Izvjestaj_o_rodjenjuDataGridView
        '
        Me.Izvjestaj_o_rodjenjuDataGridView.AllowUserToAddRows = False
        Me.Izvjestaj_o_rodjenjuDataGridView.AutoGenerateColumns = False
        Me.Izvjestaj_o_rodjenjuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Izvjestaj_o_rodjenjuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Izvjestaj_o_rodjenjuDataGridView.DataSource = Me.Izvjestaj_o_rodjenjuBindingSource
        Me.Izvjestaj_o_rodjenjuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Izvjestaj_o_rodjenjuDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Izvjestaj_o_rodjenjuDataGridView.Name = "Izvjestaj_o_rodjenjuDataGridView"
        Me.Izvjestaj_o_rodjenjuDataGridView.Size = New System.Drawing.Size(746, 316)
        Me.Izvjestaj_o_rodjenjuDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "izvjestaj_o_rodjenju"
        Me.DataGridViewTextBoxColumn7.HeaderText = "izvjestaj_o_rodjenju"
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
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vrijeme"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Vrijeme"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID Doktora"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID Pacijenta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Izvjestaj_o_rodjenjuBindingSource
        '
        Me.Izvjestaj_o_rodjenjuBindingSource.DataMember = "izvjestaj_o_rodjenju"
        Me.Izvjestaj_o_rodjenjuBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Izvjestaj_smrtDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(752, 322)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "= Izvjestaj Smrt"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.iBolnica.My.Resources.Resources.edit
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(550, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 28)
        Me.Button3.TabIndex = 78
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.iBolnica.My.Resources.Resources.izbrisi
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(594, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 28)
        Me.Button4.TabIndex = 77
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Izvjestaj_smrtDataGridView
        '
        Me.Izvjestaj_smrtDataGridView.AllowUserToAddRows = False
        Me.Izvjestaj_smrtDataGridView.AutoGenerateColumns = False
        Me.Izvjestaj_smrtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Izvjestaj_smrtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Izvjestaj_smrtDataGridView.DataSource = Me.Izvjestaj_smrtBindingSource
        Me.Izvjestaj_smrtDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Izvjestaj_smrtDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Izvjestaj_smrtDataGridView.Name = "Izvjestaj_smrtDataGridView"
        Me.Izvjestaj_smrtDataGridView.Size = New System.Drawing.Size(752, 322)
        Me.Izvjestaj_smrtDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "izvjestaj_smrti_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "izvjestaj_smrti_id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "opis"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Opis"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "vrijeme"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Vrijeme"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "doktor_id"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID Doktora"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "pacijent_id"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID Pacijenta"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Izvjestaj_smrtBindingSource
        '
        Me.Izvjestaj_smrtBindingSource.DataMember = "izvjestaj_smrt"
        Me.Izvjestaj_smrtBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ComboBox2)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.Controls.Add(Me.BtnNovaOperacija)
        Me.TabPage4.Controls.Add(Me.BtnDodajObavjestenje)
        Me.TabPage4.Controls.Add(TipLabel)
        Me.TabPage4.Controls.Add(Me.TipTextEdit)
        Me.TabPage4.Controls.Add(OpisLabel)
        Me.TabPage4.Controls.Add(Me.OpisTextEdit)
        Me.TabPage4.Controls.Add(VrijemeLabel)
        Me.TabPage4.Controls.Add(Me.VrijemeDateEdit)
        Me.TabPage4.Controls.Add(Doktor_idLabel)
        Me.TabPage4.Controls.Add(Pacijent_idLabel)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(752, 322)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "+ Dodaj Operaciju"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_operacijaBindingSource, "pacijent_id", True))
        Me.ComboBox2.DataSource = Me.PacijentBindingSource
        Me.ComboBox2.DisplayMember = "ime"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(79, 153)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 61
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
        Me.ComboBox1.Location = New System.Drawing.Point(79, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 60
        Me.ComboBox1.ValueMember = "doktor_id"
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'BtnNovaOperacija
        '
        Me.BtnNovaOperacija.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnNovaOperacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovaOperacija.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovaOperacija.Location = New System.Drawing.Point(14, 17)
        Me.BtnNovaOperacija.Name = "BtnNovaOperacija"
        Me.BtnNovaOperacija.Size = New System.Drawing.Size(141, 23)
        Me.BtnNovaOperacija.TabIndex = 59
        Me.BtnNovaOperacija.Text = "Nova Operacija"
        Me.BtnNovaOperacija.UseVisualStyleBackColor = False
        '
        'BtnDodajObavjestenje
        '
        Me.BtnDodajObavjestenje.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajObavjestenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajObavjestenje.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajObavjestenje.Location = New System.Drawing.Point(67, 177)
        Me.BtnDodajObavjestenje.Name = "BtnDodajObavjestenje"
        Me.BtnDodajObavjestenje.Size = New System.Drawing.Size(112, 23)
        Me.BtnDodajObavjestenje.TabIndex = 58
        Me.BtnDodajObavjestenje.Text = "Dodaj Operaciju"
        Me.BtnDodajObavjestenje.UseVisualStyleBackColor = False
        '
        'TipTextEdit
        '
        Me.TipTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "tip", True))
        Me.TipTextEdit.Location = New System.Drawing.Point(79, 47)
        Me.TipTextEdit.Name = "TipTextEdit"
        Me.TipTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.TipTextEdit.TabIndex = 3
        '
        'OpisTextEdit
        '
        Me.OpisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "opis", True))
        Me.OpisTextEdit.Location = New System.Drawing.Point(79, 73)
        Me.OpisTextEdit.Name = "OpisTextEdit"
        Me.OpisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit.TabIndex = 5
        '
        'VrijemeDateEdit
        '
        Me.VrijemeDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_operacijaBindingSource, "vrijeme", True))
        Me.VrijemeDateEdit.EditValue = Nothing
        Me.VrijemeDateEdit.Location = New System.Drawing.Point(79, 99)
        Me.VrijemeDateEdit.Name = "VrijemeDateEdit"
        Me.VrijemeDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.VrijemeDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.VrijemeDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeDateEdit.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Izvjestaj_o_rodjenjuLabel)
        Me.TabPage5.Controls.Add(Me.Izvjestaj_o_rodjenjuSpinEdit)
        Me.TabPage5.Controls.Add(Me.ComboBox4)
        Me.TabPage5.Controls.Add(Me.ComboBox3)
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(OpisLabel1)
        Me.TabPage5.Controls.Add(Me.OpisTextEdit1)
        Me.TabPage5.Controls.Add(VrijemeLabel1)
        Me.TabPage5.Controls.Add(Me.VrijemeDateEdit1)
        Me.TabPage5.Controls.Add(Doktor_idLabel1)
        Me.TabPage5.Controls.Add(Pacijent_idLabel1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(752, 322)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "+ Dodaj Rodjenje"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Izvjestaj_o_rodjenjuSpinEdit
        '
        Me.Izvjestaj_o_rodjenjuSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_o_rodjenjuBindingSource, "izvjestaj_o_rodjenju", True))
        Me.Izvjestaj_o_rodjenjuSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Izvjestaj_o_rodjenjuSpinEdit.Location = New System.Drawing.Point(110, 41)
        Me.Izvjestaj_o_rodjenjuSpinEdit.Name = "Izvjestaj_o_rodjenjuSpinEdit"
        Me.Izvjestaj_o_rodjenjuSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Izvjestaj_o_rodjenjuSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Izvjestaj_o_rodjenjuSpinEdit.TabIndex = 62
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_o_rodjenjuBindingSource, "pacijent_id", True))
        Me.ComboBox4.DataSource = Me.PacijentBindingSource1
        Me.ComboBox4.DisplayMember = "ime"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(110, 140)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 61
        Me.ComboBox4.ValueMember = "pacijent_id"
        '
        'PacijentBindingSource1
        '
        Me.PacijentBindingSource1.DataMember = "pacijent"
        Me.PacijentBindingSource1.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_o_rodjenjuBindingSource, "doktor_id", True))
        Me.ComboBox3.DataSource = Me.DoktorBindingSource1
        Me.ComboBox3.DisplayMember = "ime"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(110, 116)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 60
        Me.ComboBox3.ValueMember = "doktor_id"
        '
        'DoktorBindingSource1
        '
        Me.DoktorBindingSource1.DataMember = "doktor"
        Me.DoktorBindingSource1.DataSource = Me.IbolnicaDataSet
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 23)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Novo Rodjenje"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Location = New System.Drawing.Point(98, 167)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 23)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "Dodaj Rodjenje"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'OpisTextEdit1
        '
        Me.OpisTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_o_rodjenjuBindingSource, "opis", True))
        Me.OpisTextEdit1.Location = New System.Drawing.Point(110, 63)
        Me.OpisTextEdit1.Name = "OpisTextEdit1"
        Me.OpisTextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit1.TabIndex = 3
        '
        'VrijemeDateEdit1
        '
        Me.VrijemeDateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_o_rodjenjuBindingSource, "vrijeme", True))
        Me.VrijemeDateEdit1.EditValue = Nothing
        Me.VrijemeDateEdit1.Location = New System.Drawing.Point(110, 89)
        Me.VrijemeDateEdit1.Name = "VrijemeDateEdit1"
        Me.VrijemeDateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit1.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.VrijemeDateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.VrijemeDateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeDateEdit1.TabIndex = 5
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Izvjestaj_smrti_idLabel)
        Me.TabPage6.Controls.Add(Me.Izvjestaj_smrti_idSpinEdit)
        Me.TabPage6.Controls.Add(Me.ComboBox6)
        Me.TabPage6.Controls.Add(Me.ComboBox5)
        Me.TabPage6.Controls.Add(Me.Button7)
        Me.TabPage6.Controls.Add(Me.Button8)
        Me.TabPage6.Controls.Add(OpisLabel2)
        Me.TabPage6.Controls.Add(Me.OpisTextEdit2)
        Me.TabPage6.Controls.Add(VrijemeLabel2)
        Me.TabPage6.Controls.Add(Me.VrijemeDateEdit2)
        Me.TabPage6.Controls.Add(Doktor_idLabel2)
        Me.TabPage6.Controls.Add(Pacijent_idLabel2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(752, 322)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "+ Dodaj Smrt"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Izvjestaj_smrti_idSpinEdit
        '
        Me.Izvjestaj_smrti_idSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_smrtBindingSource, "izvjestaj_smrti_id", True))
        Me.Izvjestaj_smrti_idSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Izvjestaj_smrti_idSpinEdit.Location = New System.Drawing.Point(99, 41)
        Me.Izvjestaj_smrti_idSpinEdit.Name = "Izvjestaj_smrti_idSpinEdit"
        Me.Izvjestaj_smrti_idSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Izvjestaj_smrti_idSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.Izvjestaj_smrti_idSpinEdit.TabIndex = 62
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_smrtBindingSource, "pacijent_id", True))
        Me.ComboBox6.DataSource = Me.PacijentBindingSource2
        Me.ComboBox6.DisplayMember = "ime"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(99, 144)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox6.TabIndex = 61
        Me.ComboBox6.ValueMember = "pacijent_id"
        '
        'PacijentBindingSource2
        '
        Me.PacijentBindingSource2.DataMember = "pacijent"
        Me.PacijentBindingSource2.DataSource = Me.IbolnicaDataSet
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Izvjestaj_smrtBindingSource, "doktor_id", True))
        Me.ComboBox5.DataSource = Me.DoktorBindingSource2
        Me.ComboBox5.DisplayMember = "ime"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(99, 118)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 60
        Me.ComboBox5.ValueMember = "doktor_id"
        '
        'DoktorBindingSource2
        '
        Me.DoktorBindingSource2.DataMember = "doktor"
        Me.DoktorBindingSource2.DataSource = Me.IbolnicaDataSet
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Location = New System.Drawing.Point(14, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 23)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "Nova Smrt"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Location = New System.Drawing.Point(87, 167)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 23)
        Me.Button8.TabIndex = 58
        Me.Button8.Text = "Dodaj Smrt"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'OpisTextEdit2
        '
        Me.OpisTextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_smrtBindingSource, "opis", True))
        Me.OpisTextEdit2.Location = New System.Drawing.Point(99, 63)
        Me.OpisTextEdit2.Name = "OpisTextEdit2"
        Me.OpisTextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.OpisTextEdit2.TabIndex = 3
        '
        'VrijemeDateEdit2
        '
        Me.VrijemeDateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Izvjestaj_smrtBindingSource, "vrijeme", True))
        Me.VrijemeDateEdit2.EditValue = Nothing
        Me.VrijemeDateEdit2.Location = New System.Drawing.Point(99, 89)
        Me.VrijemeDateEdit2.Name = "VrijemeDateEdit2"
        Me.VrijemeDateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VrijemeDateEdit2.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.VrijemeDateEdit2.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.VrijemeDateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.VrijemeDateEdit2.TabIndex = 5
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
        Me.TableAdapterManager.izvjestaj_o_rodjenjuTableAdapter = Me.Izvjestaj_o_rodjenjuTableAdapter
        Me.TableAdapterManager.izvjestaj_operacijaTableAdapter = Me.Izvjestaj_operacijaTableAdapter
        Me.TableAdapterManager.izvjestaj_smrtTableAdapter = Me.Izvjestaj_smrtTableAdapter
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
        'Izvjestaj_o_rodjenjuTableAdapter
        '
        Me.Izvjestaj_o_rodjenjuTableAdapter.ClearBeforeFill = True
        '
        'Izvjestaj_smrtTableAdapter
        '
        Me.Izvjestaj_smrtTableAdapter.ClearBeforeFill = True
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
        Me.Izvjestaj_operacijaBindingNavigator.Size = New System.Drawing.Size(851, 25)
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
        Me.BtnZatvori.Location = New System.Drawing.Point(725, 2)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 74
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'DodajIzvjestaj_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 360)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.Izvjestaj_operacijaBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DodajIzvjestaj_Form"
        Me.Text = "DodajIzvjestaj_Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Izvjestaj_operacijaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_operacijaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Izvjestaj_o_rodjenjuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_o_rodjenjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Izvjestaj_smrtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_smrtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Izvjestaj_o_rodjenjuSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.Izvjestaj_smrti_idSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpisTextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VrijemeDateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Izvjestaj_operacijaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Izvjestaj_operacijaBindingNavigator.ResumeLayout(False)
        Me.Izvjestaj_operacijaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
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
    Friend WithEvents Izvjestaj_o_rodjenjuTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_o_rodjenjuTableAdapter
    Friend WithEvents Izvjestaj_o_rodjenjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Izvjestaj_smrtTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.izvjestaj_smrtTableAdapter
    Friend WithEvents Izvjestaj_smrtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VrijemeDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents BtnNovaOperacija As System.Windows.Forms.Button
    Friend WithEvents BtnDodajObavjestenje As System.Windows.Forms.Button
    Friend WithEvents BtnUredi As System.Windows.Forms.Button
    Friend WithEvents BtnIzbrisi As System.Windows.Forms.Button
    Friend WithEvents Izvjestaj_operacijaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Izvjestaj_o_rodjenjuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Izvjestaj_smrtDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents OpisTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VrijemeDateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents OpisTextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VrijemeDateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents PacijentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents DoktorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents PacijentBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents DoktorBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Izvjestaj_o_rodjenjuSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Izvjestaj_smrti_idSpinEdit As DevExpress.XtraEditors.SpinEdit
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
