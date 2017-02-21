<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Podesavanja_Form
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
        Dim Naziv_sistemaLabel As System.Windows.Forms.Label
        Dim Naslov_sistemaLabel As System.Windows.Forms.Label
        Dim Broj_telefonaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Podesavanja_Form))
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.PodesavanjaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PodesavanjaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Naziv_sistemaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Naslov_sistemaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Broj_telefonaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BtnDodajPodatke = New System.Windows.Forms.Button()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Naziv_sistemaLabel = New System.Windows.Forms.Label()
        Naslov_sistemaLabel = New System.Windows.Forms.Label()
        Broj_telefonaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PodesavanjaBindingNavigator.SuspendLayout()
        CType(Me.Naziv_sistemaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Naslov_sistemaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Broj_telefonaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Naziv_sistemaLabel
        '
        Naziv_sistemaLabel.AutoSize = True
        Naziv_sistemaLabel.Location = New System.Drawing.Point(12, 36)
        Naziv_sistemaLabel.Name = "Naziv_sistemaLabel"
        Naziv_sistemaLabel.Size = New System.Drawing.Size(75, 13)
        Naziv_sistemaLabel.TabIndex = 3
        Naziv_sistemaLabel.Text = "Naziv sistema:"
        '
        'Naslov_sistemaLabel
        '
        Naslov_sistemaLabel.AutoSize = True
        Naslov_sistemaLabel.Location = New System.Drawing.Point(12, 62)
        Naslov_sistemaLabel.Name = "Naslov_sistemaLabel"
        Naslov_sistemaLabel.Size = New System.Drawing.Size(81, 13)
        Naslov_sistemaLabel.TabIndex = 5
        Naslov_sistemaLabel.Text = "Naslov sistema:"
        '
        'Broj_telefonaLabel
        '
        Broj_telefonaLabel.AutoSize = True
        Broj_telefonaLabel.Location = New System.Drawing.Point(12, 88)
        Broj_telefonaLabel.Name = "Broj_telefonaLabel"
        Broj_telefonaLabel.Size = New System.Drawing.Size(69, 13)
        Broj_telefonaLabel.TabIndex = 7
        Broj_telefonaLabel.Text = "Broj telefona:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 114)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PodesavanjaBindingSource
        '
        Me.PodesavanjaBindingSource.DataMember = "podesavanja"
        Me.PodesavanjaBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'PodesavanjaTableAdapter
        '
        Me.PodesavanjaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.podesavanjaTableAdapter = Me.PodesavanjaTableAdapter
        Me.TableAdapterManager.porukaTableAdapter = Nothing
        Me.TableAdapterManager.receptTableAdapter = Nothing
        Me.TableAdapterManager.sastanciTableAdapter = Nothing
        Me.TableAdapterManager.sestraTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PodesavanjaBindingNavigator
        '
        Me.PodesavanjaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PodesavanjaBindingNavigator.BindingSource = Me.PodesavanjaBindingSource
        Me.PodesavanjaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PodesavanjaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PodesavanjaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PodesavanjaBindingNavigatorSaveItem})
        Me.PodesavanjaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PodesavanjaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PodesavanjaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PodesavanjaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PodesavanjaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PodesavanjaBindingNavigator.Name = "PodesavanjaBindingNavigator"
        Me.PodesavanjaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PodesavanjaBindingNavigator.Size = New System.Drawing.Size(783, 25)
        Me.PodesavanjaBindingNavigator.TabIndex = 0
        Me.PodesavanjaBindingNavigator.Text = "BindingNavigator1"
        Me.PodesavanjaBindingNavigator.Visible = False
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
        'PodesavanjaBindingNavigatorSaveItem
        '
        Me.PodesavanjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PodesavanjaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PodesavanjaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PodesavanjaBindingNavigatorSaveItem.Name = "PodesavanjaBindingNavigatorSaveItem"
        Me.PodesavanjaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PodesavanjaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Naziv_sistemaTextEdit
        '
        Me.Naziv_sistemaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PodesavanjaBindingSource, "naziv_sistema", True))
        Me.Naziv_sistemaTextEdit.Location = New System.Drawing.Point(100, 33)
        Me.Naziv_sistemaTextEdit.Name = "Naziv_sistemaTextEdit"
        Me.Naziv_sistemaTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.Naziv_sistemaTextEdit.TabIndex = 4
        '
        'Naslov_sistemaTextEdit
        '
        Me.Naslov_sistemaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.Naslov_sistemaTextEdit.Location = New System.Drawing.Point(100, 59)
        Me.Naslov_sistemaTextEdit.Name = "Naslov_sistemaTextEdit"
        Me.Naslov_sistemaTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.Naslov_sistemaTextEdit.TabIndex = 6
        '
        'Broj_telefonaTextEdit
        '
        Me.Broj_telefonaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PodesavanjaBindingSource, "broj_telefona", True))
        Me.Broj_telefonaTextEdit.Location = New System.Drawing.Point(100, 85)
        Me.Broj_telefonaTextEdit.Name = "Broj_telefonaTextEdit"
        Me.Broj_telefonaTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.Broj_telefonaTextEdit.TabIndex = 8
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PodesavanjaBindingSource, "email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(100, 111)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.EmailTextEdit.TabIndex = 10
        '
        'BtnDodajPodatke
        '
        Me.BtnDodajPodatke.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnDodajPodatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDodajPodatke.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDodajPodatke.Location = New System.Drawing.Point(173, 150)
        Me.BtnDodajPodatke.Name = "BtnDodajPodatke"
        Me.BtnDodajPodatke.Size = New System.Drawing.Size(147, 23)
        Me.BtnDodajPodatke.TabIndex = 23
        Me.BtnDodajPodatke.Text = "Dodaj Podatke"
        Me.BtnDodajPodatke.UseVisualStyleBackColor = False
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(281, 4)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 36
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'Podesavanja_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 176)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.BtnDodajPodatke)
        Me.Controls.Add(Naziv_sistemaLabel)
        Me.Controls.Add(Me.Naziv_sistemaTextEdit)
        Me.Controls.Add(Naslov_sistemaLabel)
        Me.Controls.Add(Me.Naslov_sistemaTextEdit)
        Me.Controls.Add(Broj_telefonaLabel)
        Me.Controls.Add(Me.Broj_telefonaTextEdit)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextEdit)
        Me.Controls.Add(Me.PodesavanjaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Podesavanja_Form"
        Me.Text = "Podesavanja_Form"
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PodesavanjaBindingNavigator.ResumeLayout(False)
        Me.PodesavanjaBindingNavigator.PerformLayout()
        CType(Me.Naziv_sistemaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Naslov_sistemaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Broj_telefonaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PodesavanjaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PodesavanjaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Naziv_sistemaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Naslov_sistemaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Broj_telefonaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnDodajPodatke As System.Windows.Forms.Button
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
End Class
