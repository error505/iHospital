<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KontrolnaTabla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KontrolnaTabla))
        Me.Doktor = New System.Windows.Forms.Button()
        Me.BtnPacijent = New System.Windows.Forms.Button()
        Me.BtnSestra = New System.Windows.Forms.Button()
        Me.BtnRecepti = New System.Windows.Forms.Button()
        Me.BtnLaboratorija = New System.Windows.Forms.Button()
        Me.BtnMenadzment = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BtnBankaKrvi = New System.Windows.Forms.Button()
        Me.BtnLijkovi = New System.Windows.Forms.Button()
        Me.BtnOperacija = New System.Windows.Forms.Button()
        Me.BtnRodjenje = New System.Windows.Forms.Button()
        Me.BtnSmrt = New System.Windows.Forms.Button()
        Me.BtnKrevet = New System.Windows.Forms.Button()
        Me.BtnObavjestenja = New System.Windows.Forms.Button()
        Me.BtnPodesavanja = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnOdjeljenja = New System.Windows.Forms.Button()
        Me.BtnDoktori1 = New System.Windows.Forms.Button()
        Me.BtnPacijenti1 = New System.Windows.Forms.Button()
        Me.BtnSestre1 = New System.Windows.Forms.Button()
        Me.BtnLijekovi1 = New System.Windows.Forms.Button()
        Me.BtnLaboratorija1 = New System.Windows.Forms.Button()
        Me.BtnMenadzment1 = New System.Windows.Forms.Button()
        Me.DoktorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet = New iBolnica.ibolnicaDataSet()
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
        Me.DoktorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Naslov = New System.Windows.Forms.Label()
        Me.BtnFarmaceuti = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.LblDoktoriCount = New System.Windows.Forms.Label()
        Me.LblDoktori = New System.Windows.Forms.Label()
        Me.LblPacijenti = New System.Windows.Forms.Label()
        Me.LblPacijentiCount = New System.Windows.Forms.Label()
        Me.LblSestre = New System.Windows.Forms.Label()
        Me.LblSestreCount = New System.Windows.Forms.Label()
        Me.OdjeljenjeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoktorTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter()
        Me.TableAdapterManager = New iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager()
        Me.OdjeljenjeTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.odjeljenjeTableAdapter()
        Me.PacijentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacijentTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter()
        Me.SestreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SestraTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter()
        Me.SestraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IbolnicaDataSet1 = New iBolnica.ibolnicaDataSet()
        Me.LblNaslov = New System.Windows.Forms.Label()
        Me.PodesavanjaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PodesavanjaTableAdapter = New iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter()
        Me.BtnPodesavanja1 = New System.Windows.Forms.Button()
        CType(Me.DoktorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoktorBindingNavigator.SuspendLayout()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdjeljenjeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SestreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SestraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IbolnicaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Doktor
        '
        Me.Doktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Doktor.ForeColor = System.Drawing.Color.Transparent
        Me.Doktor.Image = Global.iBolnica.My.Resources.Resources.Doktor
        Me.Doktor.Location = New System.Drawing.Point(225, 145)
        Me.Doktor.Name = "Doktor"
        Me.Doktor.Size = New System.Drawing.Size(205, 86)
        Me.Doktor.TabIndex = 0
        Me.Doktor.UseVisualStyleBackColor = True
        '
        'BtnPacijent
        '
        Me.BtnPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijent.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPacijent.Image = Global.iBolnica.My.Resources.Resources.Pacijent
        Me.BtnPacijent.Location = New System.Drawing.Point(436, 145)
        Me.BtnPacijent.Name = "BtnPacijent"
        Me.BtnPacijent.Size = New System.Drawing.Size(204, 86)
        Me.BtnPacijent.TabIndex = 1
        Me.BtnPacijent.UseVisualStyleBackColor = True
        '
        'BtnSestra
        '
        Me.BtnSestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSestra.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSestra.Image = Global.iBolnica.My.Resources.Resources.Sestra
        Me.BtnSestra.Location = New System.Drawing.Point(646, 145)
        Me.BtnSestra.Name = "BtnSestra"
        Me.BtnSestra.Size = New System.Drawing.Size(202, 86)
        Me.BtnSestra.TabIndex = 2
        Me.BtnSestra.UseVisualStyleBackColor = True
        '
        'BtnRecepti
        '
        Me.BtnRecepti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecepti.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRecepti.Image = Global.iBolnica.My.Resources.Resources.Recepti
        Me.BtnRecepti.Location = New System.Drawing.Point(1060, 145)
        Me.BtnRecepti.Name = "BtnRecepti"
        Me.BtnRecepti.Size = New System.Drawing.Size(202, 86)
        Me.BtnRecepti.TabIndex = 3
        Me.BtnRecepti.UseVisualStyleBackColor = True
        '
        'BtnLaboratorija
        '
        Me.BtnLaboratorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaboratorija.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLaboratorija.Image = Global.iBolnica.My.Resources.Resources.Lab
        Me.BtnLaboratorija.Location = New System.Drawing.Point(1268, 145)
        Me.BtnLaboratorija.Name = "BtnLaboratorija"
        Me.BtnLaboratorija.Size = New System.Drawing.Size(202, 86)
        Me.BtnLaboratorija.TabIndex = 4
        Me.BtnLaboratorija.UseVisualStyleBackColor = True
        '
        'BtnMenadzment
        '
        Me.BtnMenadzment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenadzment.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMenadzment.Image = Global.iBolnica.My.Resources.Resources.Menad
        Me.BtnMenadzment.Location = New System.Drawing.Point(854, 329)
        Me.BtnMenadzment.Name = "BtnMenadzment"
        Me.BtnMenadzment.Size = New System.Drawing.Size(202, 86)
        Me.BtnMenadzment.TabIndex = 5
        Me.BtnMenadzment.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Transparent
        Me.Button7.Image = Global.iBolnica.My.Resources.Resources.Sastanci
        Me.Button7.Location = New System.Drawing.Point(225, 237)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(205, 86)
        Me.Button7.TabIndex = 6
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Transparent
        Me.Button8.Image = Global.iBolnica.My.Resources.Resources.Placanje
        Me.Button8.Location = New System.Drawing.Point(436, 237)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(204, 86)
        Me.Button8.TabIndex = 7
        Me.Button8.UseVisualStyleBackColor = True
        '
        'BtnBankaKrvi
        '
        Me.BtnBankaKrvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBankaKrvi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBankaKrvi.Image = Global.iBolnica.My.Resources.Resources.krv
        Me.BtnBankaKrvi.Location = New System.Drawing.Point(644, 237)
        Me.BtnBankaKrvi.Name = "BtnBankaKrvi"
        Me.BtnBankaKrvi.Size = New System.Drawing.Size(204, 86)
        Me.BtnBankaKrvi.TabIndex = 8
        Me.BtnBankaKrvi.UseVisualStyleBackColor = True
        '
        'BtnLijkovi
        '
        Me.BtnLijkovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLijkovi.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLijkovi.Image = Global.iBolnica.My.Resources.Resources.Lijekovi1
        Me.BtnLijkovi.Location = New System.Drawing.Point(852, 237)
        Me.BtnLijkovi.Name = "BtnLijkovi"
        Me.BtnLijkovi.Size = New System.Drawing.Size(202, 86)
        Me.BtnLijkovi.TabIndex = 9
        Me.BtnLijkovi.UseVisualStyleBackColor = True
        '
        'BtnOperacija
        '
        Me.BtnOperacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOperacija.ForeColor = System.Drawing.Color.Transparent
        Me.BtnOperacija.Image = Global.iBolnica.My.Resources.Resources.operacije
        Me.BtnOperacija.Location = New System.Drawing.Point(1060, 237)
        Me.BtnOperacija.Name = "BtnOperacija"
        Me.BtnOperacija.Size = New System.Drawing.Size(202, 86)
        Me.BtnOperacija.TabIndex = 10
        Me.BtnOperacija.UseVisualStyleBackColor = True
        '
        'BtnRodjenje
        '
        Me.BtnRodjenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRodjenje.ForeColor = System.Drawing.Color.Transparent
        Me.BtnRodjenje.Image = Global.iBolnica.My.Resources.Resources.Rodjenje
        Me.BtnRodjenje.Location = New System.Drawing.Point(1268, 237)
        Me.BtnRodjenje.Name = "BtnRodjenje"
        Me.BtnRodjenje.Size = New System.Drawing.Size(202, 86)
        Me.BtnRodjenje.TabIndex = 11
        Me.BtnRodjenje.UseVisualStyleBackColor = True
        '
        'BtnSmrt
        '
        Me.BtnSmrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSmrt.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSmrt.Image = Global.iBolnica.My.Resources.Resources.Smrt
        Me.BtnSmrt.Location = New System.Drawing.Point(225, 329)
        Me.BtnSmrt.Name = "BtnSmrt"
        Me.BtnSmrt.Size = New System.Drawing.Size(205, 86)
        Me.BtnSmrt.TabIndex = 12
        Me.BtnSmrt.UseVisualStyleBackColor = True
        '
        'BtnKrevet
        '
        Me.BtnKrevet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKrevet.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKrevet.Image = Global.iBolnica.My.Resources.Resources.kreveti
        Me.BtnKrevet.Location = New System.Drawing.Point(436, 329)
        Me.BtnKrevet.Name = "BtnKrevet"
        Me.BtnKrevet.Size = New System.Drawing.Size(204, 86)
        Me.BtnKrevet.TabIndex = 13
        Me.BtnKrevet.UseVisualStyleBackColor = True
        '
        'BtnObavjestenja
        '
        Me.BtnObavjestenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnObavjestenja.ForeColor = System.Drawing.Color.Transparent
        Me.BtnObavjestenja.Image = Global.iBolnica.My.Resources.Resources.Obavjestenja
        Me.BtnObavjestenja.Location = New System.Drawing.Point(646, 329)
        Me.BtnObavjestenja.Name = "BtnObavjestenja"
        Me.BtnObavjestenja.Size = New System.Drawing.Size(202, 86)
        Me.BtnObavjestenja.TabIndex = 14
        Me.BtnObavjestenja.UseVisualStyleBackColor = True
        '
        'BtnPodesavanja
        '
        Me.BtnPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPodesavanja.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPodesavanja.Image = Global.iBolnica.My.Resources.Resources.Podesavanja_11
        Me.BtnPodesavanja.Location = New System.Drawing.Point(1060, 329)
        Me.BtnPodesavanja.Name = "BtnPodesavanja"
        Me.BtnPodesavanja.Size = New System.Drawing.Size(202, 86)
        Me.BtnPodesavanja.TabIndex = 15
        Me.BtnPodesavanja.UseVisualStyleBackColor = True
        '
        'BtnBackup
        '
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBackup.Image = Global.iBolnica.My.Resources.Resources.Backup
        Me.BtnBackup.Location = New System.Drawing.Point(1268, 329)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(202, 86)
        Me.BtnBackup.TabIndex = 16
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'BtnOdjeljenja
        '
        Me.BtnOdjeljenja.BackColor = System.Drawing.Color.Teal
        Me.BtnOdjeljenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOdjeljenja.ForeColor = System.Drawing.Color.Teal
        Me.BtnOdjeljenja.Image = Global.iBolnica.My.Resources.Resources.odjeljenja
        Me.BtnOdjeljenja.Location = New System.Drawing.Point(0, 230)
        Me.BtnOdjeljenja.Name = "BtnOdjeljenja"
        Me.BtnOdjeljenja.Size = New System.Drawing.Size(199, 37)
        Me.BtnOdjeljenja.TabIndex = 18
        Me.BtnOdjeljenja.UseVisualStyleBackColor = False
        '
        'BtnDoktori1
        '
        Me.BtnDoktori1.BackColor = System.Drawing.Color.Teal
        Me.BtnDoktori1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDoktori1.ForeColor = System.Drawing.Color.Teal
        Me.BtnDoktori1.Image = Global.iBolnica.My.Resources.Resources.Doktor_1
        Me.BtnDoktori1.Location = New System.Drawing.Point(0, 266)
        Me.BtnDoktori1.Name = "BtnDoktori1"
        Me.BtnDoktori1.Size = New System.Drawing.Size(199, 37)
        Me.BtnDoktori1.TabIndex = 19
        Me.BtnDoktori1.UseVisualStyleBackColor = False
        '
        'BtnPacijenti1
        '
        Me.BtnPacijenti1.BackColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacijenti1.ForeColor = System.Drawing.Color.Teal
        Me.BtnPacijenti1.Image = Global.iBolnica.My.Resources.Resources.Pacijent_1
        Me.BtnPacijenti1.Location = New System.Drawing.Point(0, 302)
        Me.BtnPacijenti1.Name = "BtnPacijenti1"
        Me.BtnPacijenti1.Size = New System.Drawing.Size(199, 37)
        Me.BtnPacijenti1.TabIndex = 20
        Me.BtnPacijenti1.UseVisualStyleBackColor = False
        '
        'BtnSestre1
        '
        Me.BtnSestre1.BackColor = System.Drawing.Color.Teal
        Me.BtnSestre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSestre1.ForeColor = System.Drawing.Color.Teal
        Me.BtnSestre1.Image = Global.iBolnica.My.Resources.Resources.Sestre
        Me.BtnSestre1.Location = New System.Drawing.Point(0, 338)
        Me.BtnSestre1.Name = "BtnSestre1"
        Me.BtnSestre1.Size = New System.Drawing.Size(199, 37)
        Me.BtnSestre1.TabIndex = 21
        Me.BtnSestre1.UseVisualStyleBackColor = False
        '
        'BtnLijekovi1
        '
        Me.BtnLijekovi1.BackColor = System.Drawing.Color.Teal
        Me.BtnLijekovi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLijekovi1.ForeColor = System.Drawing.Color.Teal
        Me.BtnLijekovi1.Image = Global.iBolnica.My.Resources.Resources.Lijekovi_1
        Me.BtnLijekovi1.Location = New System.Drawing.Point(0, 374)
        Me.BtnLijekovi1.Name = "BtnLijekovi1"
        Me.BtnLijekovi1.Size = New System.Drawing.Size(199, 37)
        Me.BtnLijekovi1.TabIndex = 22
        Me.BtnLijekovi1.UseVisualStyleBackColor = False
        '
        'BtnLaboratorija1
        '
        Me.BtnLaboratorija1.BackColor = System.Drawing.Color.Teal
        Me.BtnLaboratorija1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaboratorija1.ForeColor = System.Drawing.Color.Teal
        Me.BtnLaboratorija1.Image = Global.iBolnica.My.Resources.Resources.Lab_1
        Me.BtnLaboratorija1.Location = New System.Drawing.Point(0, 410)
        Me.BtnLaboratorija1.Name = "BtnLaboratorija1"
        Me.BtnLaboratorija1.Size = New System.Drawing.Size(199, 37)
        Me.BtnLaboratorija1.TabIndex = 23
        Me.BtnLaboratorija1.UseVisualStyleBackColor = False
        '
        'BtnMenadzment1
        '
        Me.BtnMenadzment1.BackColor = System.Drawing.Color.Teal
        Me.BtnMenadzment1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenadzment1.ForeColor = System.Drawing.Color.Teal
        Me.BtnMenadzment1.Image = Global.iBolnica.My.Resources.Resources.Men
        Me.BtnMenadzment1.Location = New System.Drawing.Point(0, 446)
        Me.BtnMenadzment1.Name = "BtnMenadzment1"
        Me.BtnMenadzment1.Size = New System.Drawing.Size(199, 37)
        Me.BtnMenadzment1.TabIndex = 24
        Me.BtnMenadzment1.UseVisualStyleBackColor = False
        '
        'DoktorBindingNavigator
        '
        Me.DoktorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DoktorBindingNavigator.BindingSource = Me.DoktorBindingSource
        Me.DoktorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DoktorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DoktorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DoktorBindingNavigatorSaveItem})
        Me.DoktorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoktorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DoktorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DoktorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DoktorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DoktorBindingNavigator.Name = "DoktorBindingNavigator"
        Me.DoktorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DoktorBindingNavigator.Size = New System.Drawing.Size(1527, 25)
        Me.DoktorBindingNavigator.TabIndex = 29
        Me.DoktorBindingNavigator.Text = "BindingNavigator1"
        Me.DoktorBindingNavigator.Visible = False
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
        'DoktorBindingNavigatorSaveItem
        '
        Me.DoktorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoktorBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoktorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoktorBindingNavigatorSaveItem.Name = "DoktorBindingNavigatorSaveItem"
        Me.DoktorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DoktorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(225, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 392)
        Me.Panel1.TabIndex = 30
        '
        'Naslov
        '
        Me.Naslov.AutoSize = True
        Me.Naslov.BackColor = System.Drawing.Color.Transparent
        Me.Naslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Naslov.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Naslov.Location = New System.Drawing.Point(247, 71)
        Me.Naslov.Name = "Naslov"
        Me.Naslov.Size = New System.Drawing.Size(0, 29)
        Me.Naslov.TabIndex = 31
        '
        'BtnFarmaceuti
        '
        Me.BtnFarmaceuti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFarmaceuti.ForeColor = System.Drawing.Color.Transparent
        Me.BtnFarmaceuti.Image = Global.iBolnica.My.Resources.Resources.Farmaceuti
        Me.BtnFarmaceuti.Location = New System.Drawing.Point(852, 145)
        Me.BtnFarmaceuti.Name = "BtnFarmaceuti"
        Me.BtnFarmaceuti.Size = New System.Drawing.Size(202, 86)
        Me.BtnFarmaceuti.TabIndex = 32
        Me.BtnFarmaceuti.UseVisualStyleBackColor = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLogOut.Location = New System.Drawing.Point(1395, 17)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogOut.TabIndex = 34
        Me.BtnLogOut.Text = "Odjavi Se"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'LblDoktoriCount
        '
        Me.LblDoktoriCount.AutoSize = True
        Me.LblDoktoriCount.BackColor = System.Drawing.Color.Transparent
        Me.LblDoktoriCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblDoktoriCount.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblDoktoriCount.Location = New System.Drawing.Point(1227, 103)
        Me.LblDoktoriCount.Name = "LblDoktoriCount"
        Me.LblDoktoriCount.Size = New System.Drawing.Size(0, 24)
        Me.LblDoktoriCount.TabIndex = 35
        '
        'LblDoktori
        '
        Me.LblDoktori.AutoSize = True
        Me.LblDoktori.BackColor = System.Drawing.Color.Transparent
        Me.LblDoktori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDoktori.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblDoktori.Location = New System.Drawing.Point(1205, 74)
        Me.LblDoktori.Name = "LblDoktori"
        Me.LblDoktori.Size = New System.Drawing.Size(60, 20)
        Me.LblDoktori.TabIndex = 36
        Me.LblDoktori.Text = "Doktori"
        '
        'LblPacijenti
        '
        Me.LblPacijenti.AutoSize = True
        Me.LblPacijenti.BackColor = System.Drawing.Color.Transparent
        Me.LblPacijenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPacijenti.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblPacijenti.Location = New System.Drawing.Point(1287, 74)
        Me.LblPacijenti.Name = "LblPacijenti"
        Me.LblPacijenti.Size = New System.Drawing.Size(68, 20)
        Me.LblPacijenti.TabIndex = 38
        Me.LblPacijenti.Text = "Pacijenti"
        '
        'LblPacijentiCount
        '
        Me.LblPacijentiCount.AutoSize = True
        Me.LblPacijentiCount.BackColor = System.Drawing.Color.Transparent
        Me.LblPacijentiCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblPacijentiCount.ForeColor = System.Drawing.Color.DarkRed
        Me.LblPacijentiCount.Location = New System.Drawing.Point(1314, 103)
        Me.LblPacijentiCount.Name = "LblPacijentiCount"
        Me.LblPacijentiCount.Size = New System.Drawing.Size(0, 24)
        Me.LblPacijentiCount.TabIndex = 37
        '
        'LblSestre
        '
        Me.LblSestre.AutoSize = True
        Me.LblSestre.BackColor = System.Drawing.Color.Transparent
        Me.LblSestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblSestre.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblSestre.Location = New System.Drawing.Point(1378, 74)
        Me.LblSestre.Name = "LblSestre"
        Me.LblSestre.Size = New System.Drawing.Size(56, 20)
        Me.LblSestre.TabIndex = 40
        Me.LblSestre.Text = "Sestre"
        '
        'LblSestreCount
        '
        Me.LblSestreCount.AutoSize = True
        Me.LblSestreCount.BackColor = System.Drawing.Color.Transparent
        Me.LblSestreCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblSestreCount.ForeColor = System.Drawing.Color.DarkGreen
        Me.LblSestreCount.Location = New System.Drawing.Point(1398, 103)
        Me.LblSestreCount.Name = "LblSestreCount"
        Me.LblSestreCount.Size = New System.Drawing.Size(0, 24)
        Me.LblSestreCount.TabIndex = 39
        '
        'OdjeljenjeBindingSource
        '
        Me.OdjeljenjeBindingSource.DataMember = "odjeljenje"
        Me.OdjeljenjeBindingSource.DataSource = Me.IbolnicaDataSet
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
        'PacijentBindingSource
        '
        Me.PacijentBindingSource.DataMember = "pacijent"
        Me.PacijentBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'PacijentTableAdapter
        '
        Me.PacijentTableAdapter.ClearBeforeFill = True
        '
        'SestreBindingSource
        '
        Me.SestreBindingSource.DataSource = Me.IbolnicaDataSet
        Me.SestreBindingSource.Position = 0
        '
        'SestraTableAdapter
        '
        Me.SestraTableAdapter.ClearBeforeFill = True
        '
        'SestraBindingSource
        '
        Me.SestraBindingSource.DataMember = "sestra"
        Me.SestraBindingSource.DataSource = Me.IbolnicaDataSet
        '
        'IbolnicaDataSet1
        '
        Me.IbolnicaDataSet1.DataSetName = "ibolnicaDataSet"
        Me.IbolnicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblNaslov
        '
        Me.LblNaslov.AutoSize = True
        Me.LblNaslov.BackColor = System.Drawing.Color.Transparent
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PodesavanjaBindingSource, "naziv_sistema", True))
        Me.LblNaslov.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.LblNaslov.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblNaslov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblNaslov.Location = New System.Drawing.Point(12, 9)
        Me.LblNaslov.Name = "LblNaslov"
        Me.LblNaslov.Size = New System.Drawing.Size(0, 37)
        Me.LblNaslov.TabIndex = 41
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
        'BtnPodesavanja1
        '
        Me.BtnPodesavanja1.BackColor = System.Drawing.Color.Teal
        Me.BtnPodesavanja1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPodesavanja1.ForeColor = System.Drawing.Color.Teal
        Me.BtnPodesavanja1.Image = Global.iBolnica.My.Resources.Resources.Podesavanja
        Me.BtnPodesavanja1.Location = New System.Drawing.Point(0, 482)
        Me.BtnPodesavanja1.Name = "BtnPodesavanja1"
        Me.BtnPodesavanja1.Size = New System.Drawing.Size(199, 37)
        Me.BtnPodesavanja1.TabIndex = 42
        Me.BtnPodesavanja1.UseVisualStyleBackColor = False
        '
        'KontrolnaTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.iBolnica.My.Resources.Resources.pozadina1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1527, 821)
        Me.Controls.Add(Me.BtnPodesavanja1)
        Me.Controls.Add(Me.LblNaslov)
        Me.Controls.Add(Me.LblSestre)
        Me.Controls.Add(Me.LblSestreCount)
        Me.Controls.Add(Me.LblPacijenti)
        Me.Controls.Add(Me.LblPacijentiCount)
        Me.Controls.Add(Me.LblDoktori)
        Me.Controls.Add(Me.LblDoktoriCount)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnFarmaceuti)
        Me.Controls.Add(Me.Naslov)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DoktorBindingNavigator)
        Me.Controls.Add(Me.BtnMenadzment1)
        Me.Controls.Add(Me.BtnLaboratorija1)
        Me.Controls.Add(Me.BtnLijekovi1)
        Me.Controls.Add(Me.BtnSestre1)
        Me.Controls.Add(Me.BtnPacijenti1)
        Me.Controls.Add(Me.BtnDoktori1)
        Me.Controls.Add(Me.BtnOdjeljenja)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnPodesavanja)
        Me.Controls.Add(Me.BtnObavjestenja)
        Me.Controls.Add(Me.BtnKrevet)
        Me.Controls.Add(Me.BtnSmrt)
        Me.Controls.Add(Me.BtnRodjenje)
        Me.Controls.Add(Me.BtnOperacija)
        Me.Controls.Add(Me.BtnLijkovi)
        Me.Controls.Add(Me.BtnBankaKrvi)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnMenadzment)
        Me.Controls.Add(Me.BtnLaboratorija)
        Me.Controls.Add(Me.BtnRecepti)
        Me.Controls.Add(Me.BtnSestra)
        Me.Controls.Add(Me.BtnPacijent)
        Me.Controls.Add(Me.Doktor)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.PodesavanjaBindingSource, "naslov_sistema", True))
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KontrolnaTabla"
        Me.Text = "iBolnica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DoktorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoktorBindingNavigator.ResumeLayout(False)
        Me.DoktorBindingNavigator.PerformLayout()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdjeljenjeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacijentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SestreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SestraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IbolnicaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodesavanjaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Doktor As System.Windows.Forms.Button
    Friend WithEvents BtnPacijent As System.Windows.Forms.Button
    Friend WithEvents BtnSestra As System.Windows.Forms.Button
    Friend WithEvents BtnRecepti As System.Windows.Forms.Button
    Friend WithEvents BtnLaboratorija As System.Windows.Forms.Button
    Friend WithEvents BtnMenadzment As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents BtnBankaKrvi As System.Windows.Forms.Button
    Friend WithEvents BtnLijkovi As System.Windows.Forms.Button
    Friend WithEvents BtnOperacija As System.Windows.Forms.Button
    Friend WithEvents BtnRodjenje As System.Windows.Forms.Button
    Friend WithEvents BtnSmrt As System.Windows.Forms.Button
    Friend WithEvents BtnKrevet As System.Windows.Forms.Button
    Friend WithEvents BtnObavjestenja As System.Windows.Forms.Button
    Friend WithEvents BtnPodesavanja As System.Windows.Forms.Button
    Friend WithEvents BtnBackup As System.Windows.Forms.Button
    Friend WithEvents BtnOdjeljenja As System.Windows.Forms.Button
    Friend WithEvents BtnDoktori1 As System.Windows.Forms.Button
    Friend WithEvents BtnPacijenti1 As System.Windows.Forms.Button
    Friend WithEvents BtnSestre1 As System.Windows.Forms.Button
    Friend WithEvents BtnLijekovi1 As System.Windows.Forms.Button
    Friend WithEvents BtnLaboratorija1 As System.Windows.Forms.Button
    Friend WithEvents BtnMenadzment1 As System.Windows.Forms.Button
    Friend WithEvents IbolnicaDataSet As iBolnica.ibolnicaDataSet
    Friend WithEvents DoktorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoktorTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.doktorTableAdapter
    Friend WithEvents TableAdapterManager As iBolnica.ibolnicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoktorBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DoktorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OdjeljenjeTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.odjeljenjeTableAdapter
    Friend WithEvents OdjeljenjeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Naslov As System.Windows.Forms.Label
    Friend WithEvents BtnFarmaceuti As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents PacijentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacijentTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.pacijentTableAdapter
    Friend WithEvents LblDoktoriCount As System.Windows.Forms.Label
    Friend WithEvents LblDoktori As System.Windows.Forms.Label
    Friend WithEvents LblPacijenti As System.Windows.Forms.Label
    Friend WithEvents LblPacijentiCount As System.Windows.Forms.Label
    Friend WithEvents LblSestre As System.Windows.Forms.Label
    Friend WithEvents LblSestreCount As System.Windows.Forms.Label
    Friend WithEvents SestreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SestraTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.sestraTableAdapter
    Friend WithEvents SestraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IbolnicaDataSet1 As iBolnica.ibolnicaDataSet
    Friend WithEvents LblNaslov As System.Windows.Forms.Label
    Friend WithEvents PodesavanjaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PodesavanjaTableAdapter As iBolnica.ibolnicaDataSetTableAdapters.podesavanjaTableAdapter
    Friend WithEvents BtnPodesavanja1 As System.Windows.Forms.Button

End Class
