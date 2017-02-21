<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Obavijesti_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obavijesti_form))
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
        Me.ObavjestenjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ObavjestenjaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObavjestenjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObavjestenjaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObavjestenjaBindingNavigator.SuspendLayout()
        CType(Me.ObavjestenjaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IbolnicaDataSet
        '
        Me.IbolnicaDataSet.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObavjestenjaBindingSource
        '
        Me.ObavjestenjaBindingSource.DataMember = "obavjestenja"
        Me.ObavjestenjaBindingSource.DataSource = Me.IbolnicaDataSet
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
        Me.ObavjestenjaBindingNavigator.Size = New System.Drawing.Size(1063, 25)
        Me.ObavjestenjaBindingNavigator.TabIndex = 0
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
        'ObavjestenjaDataGridView
        '
        Me.ObavjestenjaDataGridView.AllowUserToAddRows = False
        Me.ObavjestenjaDataGridView.AllowUserToDeleteRows = False
        Me.ObavjestenjaDataGridView.AllowUserToOrderColumns = True
        Me.ObavjestenjaDataGridView.AutoGenerateColumns = False
        Me.ObavjestenjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObavjestenjaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ObavjestenjaDataGridView.DataSource = Me.ObavjestenjaBindingSource
        Me.ObavjestenjaDataGridView.Location = New System.Drawing.Point(0, 29)
        Me.ObavjestenjaDataGridView.Name = "ObavjestenjaDataGridView"
        Me.ObavjestenjaDataGridView.ReadOnly = True
        Me.ObavjestenjaDataGridView.RowHeadersVisible = False
        Me.ObavjestenjaDataGridView.Size = New System.Drawing.Size(904, 220)
        Me.ObavjestenjaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "obavjestenje_naslov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Naslov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "obavjestenje"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Obavjestenje"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "vrijemekreiranja"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Vrijeme Kreiranja"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'BtnZatvori
        '
        Me.BtnZatvori.BackgroundImage = Global.iBolnica.My.Resources.Resources.zatvori
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZatvori.ForeColor = System.Drawing.Color.Transparent
        Me.BtnZatvori.Location = New System.Drawing.Point(864, 1)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(39, 23)
        Me.BtnZatvori.TabIndex = 31
        Me.BtnZatvori.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(829, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Sledeca"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(733, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Prethodna"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "= Obavještenja"
        '
        'Obavijesti_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 278)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnZatvori)
        Me.Controls.Add(Me.ObavjestenjaDataGridView)
        Me.Controls.Add(Me.ObavjestenjaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Obavijesti_form"
        Me.Text = "Obavijesti_form"
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObavjestenjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObavjestenjaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObavjestenjaBindingNavigator.ResumeLayout(False)
        Me.ObavjestenjaBindingNavigator.PerformLayout()
        CType(Me.ObavjestenjaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ObavjestenjaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BtnZatvori As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
