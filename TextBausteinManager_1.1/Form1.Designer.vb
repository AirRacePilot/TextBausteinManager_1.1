﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturNeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturSpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturSpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertreterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertreterlisteBearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AngebotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextmarkenDefinierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_AddManufacturerNode = New System.Windows.Forms.ToolStripButton()
        Me.TSB_AddProductNode = New System.Windows.Forms.ToolStripButton()
        Me.TSB_AddArticleNode = New System.Windows.Forms.ToolStripButton()
        Me.TSB_DeleteNode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CMS_NewTreeView1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KnotenEditierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArtikelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TextBausteinManager_1._1.DataSet1()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OptionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotsnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKAngebotSpezOptionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKKundeAngebotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KundeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_AddOffer = New System.Windows.Forms.Button()
        Me.Btn_DelCustomer = New System.Windows.Forms.Button()
        Me.CB_Kundennummer = New System.Windows.Forms.ComboBox()
        Me.CB_Angebotsnummer = New System.Windows.Forms.ComboBox()
        Me.Btn_AddCustomer = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BTN_down = New System.Windows.Forms.Button()
        Me.BTN_up = New System.Windows.Forms.Button()
        Me.CBox_DokVorlage = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CBox_Vertreter = New System.Windows.Forms.ComboBox()
        Me.VertreterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New TextBausteinManager_1._1.DataSet2()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TBox_Angebotstitel = New System.Windows.Forms.TextBox()
        Me.TB_Ort = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TB_PLZ = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TBox_Strasse = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TBox_Name2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBox_Name1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TBox_Firma2 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TBox_Firma1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TBox_NodeSelImageIndex = New System.Windows.Forms.TextBox()
        Me.TBox_NodeImageIndex = New System.Windows.Forms.TextBox()
        Me.TBox_NodeTag = New System.Windows.Forms.TextBox()
        Me.TBox_NodeName = New System.Windows.Forms.TextBox()
        Me.TBox_NodeText = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskedTBox_Artikelnummer = New System.Windows.Forms.MaskedTextBox()
        Me.Btn_URL_Artikel = New System.Windows.Forms.Button()
        Me.TBox_URL_Artikel = New System.Windows.Forms.TextBox()
        Me.TBox_Faktor = New System.Windows.Forms.TextBox()
        Me.MaskedTBox_VK = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTBox_EK = New System.Windows.Forms.MaskedTextBox()
        Me.TBox_Beschreibung = New System.Windows.Forms.TextBox()
        Me.TBox_Angebotstext = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TBox_Rubrik = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBox_Produkt = New System.Windows.Forms.ComboBox()
        Me.ProduktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBox_Hersteller = New System.Windows.Forms.ComboBox()
        Me.HerstellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HerstellerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerstellerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProduktIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategorieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduktTypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HerstellerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ArtikelIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduktIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubrikDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKPreisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VKPreisDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaktorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGSelectedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.ArtikelIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProduktIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RubrikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeschreibungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VKPreisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaktorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AGSelectedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.OptionIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotsnummerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortRowDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpezOptionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HerstellerProduktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProduktArtikelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewTreeView1 = New System.Windows.Forms.TreeView()
        Me.ProduktArtikelBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKArtikelSpezOptionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.CMS_NewTreeView1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKKundeAngebotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerstellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HerstellerProduktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduktArtikelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduktArtikelBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKArtikelSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.VertreterToolStripMenuItem, Me.AngebotToolStripMenuItem, Me.KonfigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1285, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProduktstrukturNeuToolStripMenuItem, Me.ProduktstrukturÖffnenToolStripMenuItem, Me.ProduktstrukturSpeichernToolStripMenuItem, Me.ProduktstrukturSpeichernUnterToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ProduktstrukturNeuToolStripMenuItem
        '
        Me.ProduktstrukturNeuToolStripMenuItem.Name = "ProduktstrukturNeuToolStripMenuItem"
        Me.ProduktstrukturNeuToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ProduktstrukturNeuToolStripMenuItem.Text = "Produktstruktur neu"
        '
        'ProduktstrukturÖffnenToolStripMenuItem
        '
        Me.ProduktstrukturÖffnenToolStripMenuItem.Name = "ProduktstrukturÖffnenToolStripMenuItem"
        Me.ProduktstrukturÖffnenToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ProduktstrukturÖffnenToolStripMenuItem.Text = "Produktstruktur öffnen"
        '
        'ProduktstrukturSpeichernToolStripMenuItem
        '
        Me.ProduktstrukturSpeichernToolStripMenuItem.Name = "ProduktstrukturSpeichernToolStripMenuItem"
        Me.ProduktstrukturSpeichernToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ProduktstrukturSpeichernToolStripMenuItem.Text = "Produktstruktur speichern"
        '
        'ProduktstrukturSpeichernUnterToolStripMenuItem
        '
        Me.ProduktstrukturSpeichernUnterToolStripMenuItem.Name = "ProduktstrukturSpeichernUnterToolStripMenuItem"
        Me.ProduktstrukturSpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ProduktstrukturSpeichernUnterToolStripMenuItem.Text = "Produktstruktur speichern unter"
        '
        'VertreterToolStripMenuItem
        '
        Me.VertreterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VertreterlisteBearbeitenToolStripMenuItem})
        Me.VertreterToolStripMenuItem.Name = "VertreterToolStripMenuItem"
        Me.VertreterToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VertreterToolStripMenuItem.Text = "Vertreter"
        '
        'VertreterlisteBearbeitenToolStripMenuItem
        '
        Me.VertreterlisteBearbeitenToolStripMenuItem.Name = "VertreterlisteBearbeitenToolStripMenuItem"
        Me.VertreterlisteBearbeitenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VertreterlisteBearbeitenToolStripMenuItem.Text = "Liste bearbeiten"
        '
        'AngebotToolStripMenuItem
        '
        Me.AngebotToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem})
        Me.AngebotToolStripMenuItem.Name = "AngebotToolStripMenuItem"
        Me.AngebotToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AngebotToolStripMenuItem.Text = "Angebot"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.NeuToolStripMenuItem.Text = "neu"
        '
        'KonfigurationToolStripMenuItem
        '
        Me.KonfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextmarkenDefinierenToolStripMenuItem})
        Me.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem"
        Me.KonfigurationToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.KonfigurationToolStripMenuItem.Text = "Konfiguration"
        '
        'TextmarkenDefinierenToolStripMenuItem
        '
        Me.TextmarkenDefinierenToolStripMenuItem.Name = "TextmarkenDefinierenToolStripMenuItem"
        Me.TextmarkenDefinierenToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.TextmarkenDefinierenToolStripMenuItem.Text = "word Textmarken definieren"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 648)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1285, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_AddManufacturerNode, Me.TSB_AddProductNode, Me.TSB_AddArticleNode, Me.TSB_DeleteNode, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1285, 31)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_AddManufacturerNode
        '
        Me.TSB_AddManufacturerNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_AddManufacturerNode.Image = Global.TextBausteinManager_1._1.My.Resources.Resources.folder
        Me.TSB_AddManufacturerNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_AddManufacturerNode.Name = "TSB_AddManufacturerNode"
        Me.TSB_AddManufacturerNode.Size = New System.Drawing.Size(28, 28)
        Me.TSB_AddManufacturerNode.Text = "ToolStripButton1"
        '
        'TSB_AddProductNode
        '
        Me.TSB_AddProductNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_AddProductNode.Image = Global.TextBausteinManager_1._1.My.Resources.Resources.folder_document
        Me.TSB_AddProductNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_AddProductNode.Name = "TSB_AddProductNode"
        Me.TSB_AddProductNode.Size = New System.Drawing.Size(28, 28)
        Me.TSB_AddProductNode.Text = "ToolStripButton1"
        '
        'TSB_AddArticleNode
        '
        Me.TSB_AddArticleNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_AddArticleNode.Image = Global.TextBausteinManager_1._1.My.Resources.Resources.file_doc
        Me.TSB_AddArticleNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_AddArticleNode.Name = "TSB_AddArticleNode"
        Me.TSB_AddArticleNode.Size = New System.Drawing.Size(28, 28)
        Me.TSB_AddArticleNode.Text = "ToolStripButton2"
        '
        'TSB_DeleteNode
        '
        Me.TSB_DeleteNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_DeleteNode.Image = Global.TextBausteinManager_1._1.My.Resources.Resources.edit_delete_5
        Me.TSB_DeleteNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_DeleteNode.Name = "TSB_DeleteNode"
        Me.TSB_DeleteNode.Size = New System.Drawing.Size(28, 28)
        Me.TSB_DeleteNode.Text = "ToolStripButton3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder-document.ico")
        Me.ImageList1.Images.SetKeyName(1, "node.png")
        Me.ImageList1.Images.SetKeyName(2, "file-doc.ico")
        Me.ImageList1.Images.SetKeyName(3, "node_chain_broken.png")
        Me.ImageList1.Images.SetKeyName(4, "folder.ico")
        '
        'CMS_NewTreeView1
        '
        Me.CMS_NewTreeView1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMS_NewTreeView1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KnotenEditierenToolStripMenuItem, Me.AnzeigenToolStripMenuItem})
        Me.CMS_NewTreeView1.Name = "CMS_NewTreeView1"
        Me.CMS_NewTreeView1.Size = New System.Drawing.Size(146, 48)
        '
        'KnotenEditierenToolStripMenuItem
        '
        Me.KnotenEditierenToolStripMenuItem.Name = "KnotenEditierenToolStripMenuItem"
        Me.KnotenEditierenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.KnotenEditierenToolStripMenuItem.Text = "umbenennen"
        '
        'AnzeigenToolStripMenuItem
        '
        Me.AnzeigenToolStripMenuItem.Name = "AnzeigenToolStripMenuItem"
        Me.AnzeigenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AnzeigenToolStripMenuItem.Text = "anzeigen"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(600, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(853, 593)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(845, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Angebot"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 399)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(839, 162)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Angebot"
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.OptionIDDataGridViewTextBoxColumn, Me.AngebotsnummerDataGridViewTextBoxColumn, Me.ArtikelIDDataGridViewTextBoxColumn, Me.SortRowDataGridViewTextBoxColumn})
        Me.DataGridView5.DataSource = Me.FKAngebotSpezOptionenBindingSource
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView5.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView5.MultiSelect = False
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(833, 141)
        Me.DataGridView5.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ArtikelID"
        Me.Column1.DataSource = Me.ArtikelBindingSource
        Me.Column1.DisplayMember = "Artikelkurztext"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Artikelkurztext"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "ArtikelID"
        '
        'ArtikelBindingSource
        '
        Me.ArtikelBindingSource.DataMember = "Artikel"
        Me.ArtikelBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ArtikelID"
        Me.Column2.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle7.Format = "00-0000-0000"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column2.DisplayMember = "Artikelnr"
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column2.HeaderText = "Artikelnummer"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.ValueMember = "ArtikelID"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ArtikelID"
        Me.Column3.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column3.DisplayMember = "EKPreis"
        Me.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column3.HeaderText = "EK Preis"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.ValueMember = "ArtikelID"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ArtikelID"
        Me.Column4.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column4.DisplayMember = "VKPreis"
        Me.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column4.HeaderText = "VK Preis"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.ValueMember = "ArtikelID"
        '
        'OptionIDDataGridViewTextBoxColumn
        '
        Me.OptionIDDataGridViewTextBoxColumn.DataPropertyName = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.HeaderText = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.Name = "OptionIDDataGridViewTextBoxColumn"
        Me.OptionIDDataGridViewTextBoxColumn.Visible = False
        '
        'AngebotsnummerDataGridViewTextBoxColumn
        '
        Me.AngebotsnummerDataGridViewTextBoxColumn.DataPropertyName = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.HeaderText = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.Name = "AngebotsnummerDataGridViewTextBoxColumn"
        Me.AngebotsnummerDataGridViewTextBoxColumn.Visible = False
        '
        'ArtikelIDDataGridViewTextBoxColumn
        '
        Me.ArtikelIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.Name = "ArtikelIDDataGridViewTextBoxColumn"
        Me.ArtikelIDDataGridViewTextBoxColumn.Visible = False
        '
        'SortRowDataGridViewTextBoxColumn
        '
        Me.SortRowDataGridViewTextBoxColumn.DataPropertyName = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.HeaderText = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.Name = "SortRowDataGridViewTextBoxColumn"
        '
        'FKAngebotSpezOptionenBindingSource
        '
        Me.FKAngebotSpezOptionenBindingSource.DataMember = "FK_Angebot_SpezOptionen"
        Me.FKAngebotSpezOptionenBindingSource.DataSource = Me.FKKundeAngebotBindingSource
        Me.FKAngebotSpezOptionenBindingSource.Sort = "SortRow"
        '
        'FKKundeAngebotBindingSource
        '
        Me.FKKundeAngebotBindingSource.DataMember = "FK_Kunde_Angebot"
        Me.FKKundeAngebotBindingSource.DataSource = Me.KundeBindingSource
        '
        'KundeBindingSource
        '
        Me.KundeBindingSource.DataMember = "Kunde"
        Me.KundeBindingSource.DataSource = Me.DataSet1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_AddOffer)
        Me.GroupBox3.Controls.Add(Me.Btn_DelCustomer)
        Me.GroupBox3.Controls.Add(Me.CB_Kundennummer)
        Me.GroupBox3.Controls.Add(Me.CB_Angebotsnummer)
        Me.GroupBox3.Controls.Add(Me.Btn_AddCustomer)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.CBox_DokVorlage)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.CBox_Vertreter)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.TBox_Angebotstitel)
        Me.GroupBox3.Controls.Add(Me.TB_Ort)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.TB_PLZ)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.TBox_Strasse)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.TBox_Name2)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.TBox_Name1)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.TBox_Firma2)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.TBox_Firma1)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(839, 396)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kunde"
        '
        'Btn_AddOffer
        '
        Me.Btn_AddOffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddOffer.Location = New System.Drawing.Point(148, 266)
        Me.Btn_AddOffer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AddOffer.Name = "Btn_AddOffer"
        Me.Btn_AddOffer.Size = New System.Drawing.Size(80, 23)
        Me.Btn_AddOffer.TabIndex = 30
        Me.Btn_AddOffer.Text = "neu"
        Me.Btn_AddOffer.UseVisualStyleBackColor = True
        '
        'Btn_DelCustomer
        '
        Me.Btn_DelCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DelCustomer.Location = New System.Drawing.Point(476, 37)
        Me.Btn_DelCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_DelCustomer.Name = "Btn_DelCustomer"
        Me.Btn_DelCustomer.Size = New System.Drawing.Size(115, 24)
        Me.Btn_DelCustomer.TabIndex = 29
        Me.Btn_DelCustomer.Text = "Kunden löschen"
        Me.Btn_DelCustomer.UseVisualStyleBackColor = True
        '
        'CB_Kundennummer
        '
        Me.CB_Kundennummer.DataSource = Me.KundeBindingSource
        Me.CB_Kundennummer.DisplayMember = "KdNummer"
        Me.CB_Kundennummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Kundennummer.FormattingEnabled = True
        Me.CB_Kundennummer.Location = New System.Drawing.Point(5, 37)
        Me.CB_Kundennummer.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_Kundennummer.Name = "CB_Kundennummer"
        Me.CB_Kundennummer.Size = New System.Drawing.Size(311, 24)
        Me.CB_Kundennummer.TabIndex = 28
        Me.CB_Kundennummer.ValueMember = "KundenID"
        '
        'CB_Angebotsnummer
        '
        Me.CB_Angebotsnummer.DataSource = Me.FKKundeAngebotBindingSource
        Me.CB_Angebotsnummer.DisplayMember = "Angebotsnummer"
        Me.CB_Angebotsnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Angebotsnummer.FormattingEnabled = True
        Me.CB_Angebotsnummer.Location = New System.Drawing.Point(5, 267)
        Me.CB_Angebotsnummer.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_Angebotsnummer.Name = "CB_Angebotsnummer"
        Me.CB_Angebotsnummer.Size = New System.Drawing.Size(140, 24)
        Me.CB_Angebotsnummer.TabIndex = 26
        Me.CB_Angebotsnummer.ValueMember = "Angebotsnummer"
        '
        'Btn_AddCustomer
        '
        Me.Btn_AddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddCustomer.Location = New System.Drawing.Point(357, 37)
        Me.Btn_AddCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_AddCustomer.Name = "Btn_AddCustomer"
        Me.Btn_AddCustomer.Size = New System.Drawing.Size(115, 24)
        Me.Btn_AddCustomer.TabIndex = 25
        Me.Btn_AddCustomer.Text = "neuer Kunde"
        Me.Btn_AddCustomer.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 19)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(101, 16)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Kundennummer"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BTN_down)
        Me.GroupBox6.Controls.Add(Me.BTN_up)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 297)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(230, 85)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Element verschieben"
        '
        'BTN_down
        '
        Me.BTN_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_down.Location = New System.Drawing.Point(7, 52)
        Me.BTN_down.Name = "BTN_down"
        Me.BTN_down.Size = New System.Drawing.Size(217, 23)
        Me.BTN_down.TabIndex = 1
        Me.BTN_down.Text = "ab"
        Me.BTN_down.UseVisualStyleBackColor = True
        '
        'BTN_up
        '
        Me.BTN_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_up.Location = New System.Drawing.Point(7, 22)
        Me.BTN_up.Name = "BTN_up"
        Me.BTN_up.Size = New System.Drawing.Size(217, 23)
        Me.BTN_up.TabIndex = 0
        Me.BTN_up.Text = "auf"
        Me.BTN_up.UseVisualStyleBackColor = True
        '
        'CBox_DokVorlage
        '
        Me.CBox_DokVorlage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_DokVorlage.FormattingEnabled = True
        Me.CBox_DokVorlage.Location = New System.Drawing.Point(357, 223)
        Me.CBox_DokVorlage.Name = "CBox_DokVorlage"
        Me.CBox_DokVorlage.Size = New System.Drawing.Size(264, 24)
        Me.CBox_DokVorlage.TabIndex = 21
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(354, 202)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(130, 16)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Dokumentenvorlage"
        '
        'CBox_Vertreter
        '
        Me.CBox_Vertreter.DataSource = Me.VertreterBindingSource
        Me.CBox_Vertreter.DisplayMember = "angezeigterName"
        Me.CBox_Vertreter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_Vertreter.FormattingEnabled = True
        Me.CBox_Vertreter.Location = New System.Drawing.Point(357, 180)
        Me.CBox_Vertreter.Name = "CBox_Vertreter"
        Me.CBox_Vertreter.Size = New System.Drawing.Size(264, 24)
        Me.CBox_Vertreter.TabIndex = 19
        '
        'VertreterBindingSource
        '
        Me.VertreterBindingSource.DataMember = "Vertreter"
        Me.VertreterBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(354, 157)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 16)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Vertreter"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(238, 249)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(86, 16)
        Me.Label32.TabIndex = 16
        Me.Label32.Text = "Angebotstitel"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 249)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 16)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Angebotsnummer"
        '
        'TBox_Angebotstitel
        '
        Me.TBox_Angebotstitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Angebotstitel.Location = New System.Drawing.Point(242, 267)
        Me.TBox_Angebotstitel.Multiline = True
        Me.TBox_Angebotstitel.Name = "TBox_Angebotstitel"
        Me.TBox_Angebotstitel.Size = New System.Drawing.Size(379, 114)
        Me.TBox_Angebotstitel.TabIndex = 14
        '
        'TB_Ort
        '
        Me.TB_Ort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Ort.Location = New System.Drawing.Point(103, 223)
        Me.TB_Ort.Name = "TB_Ort"
        Me.TB_Ort.Size = New System.Drawing.Size(213, 22)
        Me.TB_Ort.TabIndex = 13
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(100, 205)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(25, 16)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Ort"
        '
        'TB_PLZ
        '
        Me.TB_PLZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PLZ.Location = New System.Drawing.Point(5, 223)
        Me.TB_PLZ.Name = "TB_PLZ"
        Me.TB_PLZ.Size = New System.Drawing.Size(75, 22)
        Me.TB_PLZ.TabIndex = 11
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 202)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 16)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "PLZ"
        '
        'TBox_Strasse
        '
        Me.TBox_Strasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Strasse.Location = New System.Drawing.Point(5, 180)
        Me.TBox_Strasse.Name = "TBox_Strasse"
        Me.TBox_Strasse.Size = New System.Drawing.Size(311, 22)
        Me.TBox_Strasse.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 161)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 16)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Straße"
        '
        'TBox_Name2
        '
        Me.TBox_Name2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Name2.Location = New System.Drawing.Point(357, 132)
        Me.TBox_Name2.Name = "TBox_Name2"
        Me.TBox_Name2.Size = New System.Drawing.Size(264, 22)
        Me.TBox_Name2.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(354, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Name2"
        '
        'TBox_Name1
        '
        Me.TBox_Name1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Name1.Location = New System.Drawing.Point(5, 132)
        Me.TBox_Name1.Name = "TBox_Name1"
        Me.TBox_Name1.Size = New System.Drawing.Size(311, 22)
        Me.TBox_Name1.TabIndex = 5
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 16)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Name1"
        '
        'TBox_Firma2
        '
        Me.TBox_Firma2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Firma2.Location = New System.Drawing.Point(357, 88)
        Me.TBox_Firma2.Name = "TBox_Firma2"
        Me.TBox_Firma2.Size = New System.Drawing.Size(264, 22)
        Me.TBox_Firma2.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(357, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 16)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Firma2"
        '
        'TBox_Firma1
        '
        Me.TBox_Firma1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Firma1.Location = New System.Drawing.Point(5, 88)
        Me.TBox_Firma1.Name = "TBox_Firma1"
        Me.TBox_Firma1.Size = New System.Drawing.Size(311, 22)
        Me.TBox_Firma1.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 16)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Firma1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(845, 564)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Artikel"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TBox_NodeSelImageIndex)
        Me.GroupBox5.Controls.Add(Me.TBox_NodeImageIndex)
        Me.GroupBox5.Controls.Add(Me.TBox_NodeTag)
        Me.GroupBox5.Controls.Add(Me.TBox_NodeName)
        Me.GroupBox5.Controls.Add(Me.TBox_NodeText)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 400)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(526, 165)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Knotendaten"
        '
        'TBox_NodeSelImageIndex
        '
        Me.TBox_NodeSelImageIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_NodeSelImageIndex.Location = New System.Drawing.Point(146, 132)
        Me.TBox_NodeSelImageIndex.Name = "TBox_NodeSelImageIndex"
        Me.TBox_NodeSelImageIndex.Size = New System.Drawing.Size(343, 22)
        Me.TBox_NodeSelImageIndex.TabIndex = 9
        '
        'TBox_NodeImageIndex
        '
        Me.TBox_NodeImageIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_NodeImageIndex.Location = New System.Drawing.Point(146, 104)
        Me.TBox_NodeImageIndex.Name = "TBox_NodeImageIndex"
        Me.TBox_NodeImageIndex.Size = New System.Drawing.Size(343, 22)
        Me.TBox_NodeImageIndex.TabIndex = 8
        '
        'TBox_NodeTag
        '
        Me.TBox_NodeTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_NodeTag.Location = New System.Drawing.Point(146, 75)
        Me.TBox_NodeTag.Name = "TBox_NodeTag"
        Me.TBox_NodeTag.Size = New System.Drawing.Size(343, 22)
        Me.TBox_NodeTag.TabIndex = 7
        '
        'TBox_NodeName
        '
        Me.TBox_NodeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_NodeName.Location = New System.Drawing.Point(146, 46)
        Me.TBox_NodeName.Name = "TBox_NodeName"
        Me.TBox_NodeName.Size = New System.Drawing.Size(343, 22)
        Me.TBox_NodeName.TabIndex = 6
        '
        'TBox_NodeText
        '
        Me.TBox_NodeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_NodeText.Location = New System.Drawing.Point(146, 17)
        Me.TBox_NodeText.Name = "TBox_NodeText"
        Me.TBox_NodeText.Size = New System.Drawing.Size(343, 22)
        Me.TBox_NodeText.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "SelImageIndex"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "ImageIndex"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Tag (ArtikelID)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Name (ProduktID)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Text"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedTBox_Artikelnummer)
        Me.GroupBox2.Controls.Add(Me.Btn_URL_Artikel)
        Me.GroupBox2.Controls.Add(Me.TBox_URL_Artikel)
        Me.GroupBox2.Controls.Add(Me.TBox_Faktor)
        Me.GroupBox2.Controls.Add(Me.MaskedTBox_VK)
        Me.GroupBox2.Controls.Add(Me.MaskedTBox_EK)
        Me.GroupBox2.Controls.Add(Me.TBox_Beschreibung)
        Me.GroupBox2.Controls.Add(Me.TBox_Angebotstext)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TBox_Rubrik)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CBox_Produkt)
        Me.GroupBox2.Controls.Add(Me.CBox_Hersteller)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 558)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Artikel"
        '
        'MaskedTBox_Artikelnummer
        '
        Me.MaskedTBox_Artikelnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Artikelnr", True))
        Me.MaskedTBox_Artikelnummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTBox_Artikelnummer.Location = New System.Drawing.Point(9, 129)
        Me.MaskedTBox_Artikelnummer.Margin = New System.Windows.Forms.Padding(2)
        Me.MaskedTBox_Artikelnummer.Mask = "00-0000-0000"
        Me.MaskedTBox_Artikelnummer.Name = "MaskedTBox_Artikelnummer"
        Me.MaskedTBox_Artikelnummer.Size = New System.Drawing.Size(100, 23)
        Me.MaskedTBox_Artikelnummer.TabIndex = 33
        Me.MaskedTBox_Artikelnummer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Btn_URL_Artikel
        '
        Me.Btn_URL_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_URL_Artikel.Location = New System.Drawing.Point(492, 341)
        Me.Btn_URL_Artikel.Name = "Btn_URL_Artikel"
        Me.Btn_URL_Artikel.Size = New System.Drawing.Size(34, 23)
        Me.Btn_URL_Artikel.TabIndex = 27
        Me.Btn_URL_Artikel.Text = "..."
        Me.Btn_URL_Artikel.UseVisualStyleBackColor = True
        '
        'TBox_URL_Artikel
        '
        Me.TBox_URL_Artikel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "URL", True))
        Me.TBox_URL_Artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_URL_Artikel.Location = New System.Drawing.Point(6, 341)
        Me.TBox_URL_Artikel.Name = "TBox_URL_Artikel"
        Me.TBox_URL_Artikel.Size = New System.Drawing.Size(480, 23)
        Me.TBox_URL_Artikel.TabIndex = 26
        '
        'TBox_Faktor
        '
        Me.TBox_Faktor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Faktor", True))
        Me.TBox_Faktor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Faktor.Location = New System.Drawing.Point(388, 130)
        Me.TBox_Faktor.Name = "TBox_Faktor"
        Me.TBox_Faktor.Size = New System.Drawing.Size(138, 23)
        Me.TBox_Faktor.TabIndex = 25
        '
        'MaskedTBox_VK
        '
        Me.MaskedTBox_VK.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "VKPreis", True))
        Me.MaskedTBox_VK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTBox_VK.Location = New System.Drawing.Point(261, 129)
        Me.MaskedTBox_VK.Name = "MaskedTBox_VK"
        Me.MaskedTBox_VK.Size = New System.Drawing.Size(100, 23)
        Me.MaskedTBox_VK.TabIndex = 24
        '
        'MaskedTBox_EK
        '
        Me.MaskedTBox_EK.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "EKPreis", True))
        Me.MaskedTBox_EK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTBox_EK.Location = New System.Drawing.Point(131, 130)
        Me.MaskedTBox_EK.Name = "MaskedTBox_EK"
        Me.MaskedTBox_EK.Size = New System.Drawing.Size(100, 23)
        Me.MaskedTBox_EK.TabIndex = 23
        '
        'TBox_Beschreibung
        '
        Me.TBox_Beschreibung.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Beschreibung", True))
        Me.TBox_Beschreibung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Beschreibung.Location = New System.Drawing.Point(6, 182)
        Me.TBox_Beschreibung.Multiline = True
        Me.TBox_Beschreibung.Name = "TBox_Beschreibung"
        Me.TBox_Beschreibung.Size = New System.Drawing.Size(520, 137)
        Me.TBox_Beschreibung.TabIndex = 22
        '
        'TBox_Angebotstext
        '
        Me.TBox_Angebotstext.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Artikelkurztext", True))
        Me.TBox_Angebotstext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Angebotstext.Location = New System.Drawing.Point(9, 85)
        Me.TBox_Angebotstext.Name = "TBox_Angebotstext"
        Me.TBox_Angebotstext.Size = New System.Drawing.Size(517, 23)
        Me.TBox_Angebotstext.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 322)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 16)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Baustein URL"
        '
        'TBox_Rubrik
        '
        Me.TBox_Rubrik.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Rubrik", True))
        Me.TBox_Rubrik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_Rubrik.Location = New System.Drawing.Point(389, 39)
        Me.TBox_Rubrik.Name = "TBox_Rubrik"
        Me.TBox_Rubrik.Size = New System.Drawing.Size(137, 23)
        Me.TBox_Rubrik.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(385, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Faktor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(258, 111)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "VK Preis"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(128, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 16)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "EK Preis"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 16)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Beschreibung"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Artikelkurztext"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(386, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Rubrik"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Artikelnummer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Produkt"
        '
        'CBox_Produkt
        '
        Me.CBox_Produkt.DataSource = Me.ProduktBindingSource
        Me.CBox_Produkt.DisplayMember = "ProduktTyp"
        Me.CBox_Produkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_Produkt.FormattingEnabled = True
        Me.CBox_Produkt.Location = New System.Drawing.Point(217, 38)
        Me.CBox_Produkt.Name = "CBox_Produkt"
        Me.CBox_Produkt.Size = New System.Drawing.Size(162, 25)
        Me.CBox_Produkt.TabIndex = 2
        Me.CBox_Produkt.ValueMember = "ProduktID"
        '
        'ProduktBindingSource
        '
        Me.ProduktBindingSource.DataMember = "Produkt"
        Me.ProduktBindingSource.DataSource = Me.DataSet1
        '
        'CBox_Hersteller
        '
        Me.CBox_Hersteller.DataSource = Me.HerstellerBindingSource
        Me.CBox_Hersteller.DisplayMember = "Hersteller"
        Me.CBox_Hersteller.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_Hersteller.FormattingEnabled = True
        Me.CBox_Hersteller.Location = New System.Drawing.Point(9, 38)
        Me.CBox_Hersteller.Name = "CBox_Hersteller"
        Me.CBox_Hersteller.Size = New System.Drawing.Size(162, 25)
        Me.CBox_Hersteller.TabIndex = 1
        Me.CBox_Hersteller.ValueMember = "HerstellerID"
        '
        'HerstellerBindingSource
        '
        Me.HerstellerBindingSource.DataMember = "Hersteller"
        Me.HerstellerBindingSource.DataSource = Me.DataSet1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hersteller"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(845, 564)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Hersteller"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HerstellerIDDataGridViewTextBoxColumn, Me.HerstellerDataGridViewTextBoxColumn, Me.URLDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HerstellerBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 564)
        Me.DataGridView1.TabIndex = 0
        '
        'HerstellerIDDataGridViewTextBoxColumn
        '
        Me.HerstellerIDDataGridViewTextBoxColumn.DataPropertyName = "HerstellerID"
        Me.HerstellerIDDataGridViewTextBoxColumn.HeaderText = "HerstellerID"
        Me.HerstellerIDDataGridViewTextBoxColumn.Name = "HerstellerIDDataGridViewTextBoxColumn"
        Me.HerstellerIDDataGridViewTextBoxColumn.Width = 104
        '
        'HerstellerDataGridViewTextBoxColumn
        '
        Me.HerstellerDataGridViewTextBoxColumn.DataPropertyName = "Hersteller"
        Me.HerstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller"
        Me.HerstellerDataGridViewTextBoxColumn.Name = "HerstellerDataGridViewTextBoxColumn"
        Me.HerstellerDataGridViewTextBoxColumn.Width = 91
        '
        'URLDataGridViewTextBoxColumn
        '
        Me.URLDataGridViewTextBoxColumn.DataPropertyName = "URL"
        Me.URLDataGridViewTextBoxColumn.HeaderText = "URL"
        Me.URLDataGridViewTextBoxColumn.Name = "URLDataGridViewTextBoxColumn"
        Me.URLDataGridViewTextBoxColumn.Width = 60
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(845, 564)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Produkt"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProduktIDDataGridViewTextBoxColumn, Me.KategorieDataGridViewTextBoxColumn, Me.ProduktTypDataGridViewTextBoxColumn, Me.HerstellerIDDataGridViewTextBoxColumn1, Me.URLDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.ProduktBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(845, 564)
        Me.DataGridView2.TabIndex = 0
        '
        'ProduktIDDataGridViewTextBoxColumn
        '
        Me.ProduktIDDataGridViewTextBoxColumn.DataPropertyName = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn.HeaderText = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn.Name = "ProduktIDDataGridViewTextBoxColumn"
        Me.ProduktIDDataGridViewTextBoxColumn.Width = 92
        '
        'KategorieDataGridViewTextBoxColumn
        '
        Me.KategorieDataGridViewTextBoxColumn.DataPropertyName = "Kategorie"
        Me.KategorieDataGridViewTextBoxColumn.HeaderText = "Kategorie"
        Me.KategorieDataGridViewTextBoxColumn.Name = "KategorieDataGridViewTextBoxColumn"
        Me.KategorieDataGridViewTextBoxColumn.Width = 91
        '
        'ProduktTypDataGridViewTextBoxColumn
        '
        Me.ProduktTypDataGridViewTextBoxColumn.DataPropertyName = "ProduktTyp"
        Me.ProduktTypDataGridViewTextBoxColumn.HeaderText = "ProduktTyp"
        Me.ProduktTypDataGridViewTextBoxColumn.Name = "ProduktTypDataGridViewTextBoxColumn"
        Me.ProduktTypDataGridViewTextBoxColumn.Width = 103
        '
        'HerstellerIDDataGridViewTextBoxColumn1
        '
        Me.HerstellerIDDataGridViewTextBoxColumn1.DataPropertyName = "HerstellerID"
        Me.HerstellerIDDataGridViewTextBoxColumn1.HeaderText = "HerstellerID"
        Me.HerstellerIDDataGridViewTextBoxColumn1.Name = "HerstellerIDDataGridViewTextBoxColumn1"
        Me.HerstellerIDDataGridViewTextBoxColumn1.Width = 104
        '
        'URLDataGridViewTextBoxColumn1
        '
        Me.URLDataGridViewTextBoxColumn1.DataPropertyName = "URL"
        Me.URLDataGridViewTextBoxColumn1.HeaderText = "URL"
        Me.URLDataGridViewTextBoxColumn1.Name = "URLDataGridViewTextBoxColumn1"
        Me.URLDataGridViewTextBoxColumn1.Width = 60
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(845, 564)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Artikel"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtikelIDDataGridViewTextBoxColumn1, Me.ProduktIDDataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn2, Me.URLDataGridViewTextBoxColumn3, Me.RubrikDataGridViewTextBoxColumn1, Me.BeschreibungDataGridViewTextBoxColumn1, Me.EKPreisDataGridViewTextBoxColumn1, Me.VKPreisDataGridViewTextBoxColumn1, Me.FaktorDataGridViewTextBoxColumn1, Me.AGSelectedDataGridViewCheckBoxColumn1})
        Me.DataGridView3.DataSource = Me.ArtikelBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(845, 564)
        Me.DataGridView3.TabIndex = 0
        '
        'ArtikelIDDataGridViewTextBoxColumn1
        '
        Me.ArtikelIDDataGridViewTextBoxColumn1.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn1.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn1.Name = "ArtikelIDDataGridViewTextBoxColumn1"
        Me.ArtikelIDDataGridViewTextBoxColumn1.Width = 83
        '
        'ProduktIDDataGridViewTextBoxColumn2
        '
        Me.ProduktIDDataGridViewTextBoxColumn2.DataPropertyName = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn2.HeaderText = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn2.Name = "ProduktIDDataGridViewTextBoxColumn2"
        Me.ProduktIDDataGridViewTextBoxColumn2.Width = 92
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn2.HeaderText = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 104
        '
        'URLDataGridViewTextBoxColumn3
        '
        Me.URLDataGridViewTextBoxColumn3.DataPropertyName = "URL"
        Me.URLDataGridViewTextBoxColumn3.HeaderText = "URL"
        Me.URLDataGridViewTextBoxColumn3.Name = "URLDataGridViewTextBoxColumn3"
        Me.URLDataGridViewTextBoxColumn3.Width = 60
        '
        'RubrikDataGridViewTextBoxColumn1
        '
        Me.RubrikDataGridViewTextBoxColumn1.DataPropertyName = "Rubrik"
        Me.RubrikDataGridViewTextBoxColumn1.HeaderText = "Rubrik"
        Me.RubrikDataGridViewTextBoxColumn1.Name = "RubrikDataGridViewTextBoxColumn1"
        Me.RubrikDataGridViewTextBoxColumn1.Width = 72
        '
        'BeschreibungDataGridViewTextBoxColumn1
        '
        Me.BeschreibungDataGridViewTextBoxColumn1.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn1.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn1.Name = "BeschreibungDataGridViewTextBoxColumn1"
        Me.BeschreibungDataGridViewTextBoxColumn1.Width = 116
        '
        'EKPreisDataGridViewTextBoxColumn1
        '
        Me.EKPreisDataGridViewTextBoxColumn1.DataPropertyName = "EKPreis"
        Me.EKPreisDataGridViewTextBoxColumn1.HeaderText = "EKPreis"
        Me.EKPreisDataGridViewTextBoxColumn1.Name = "EKPreisDataGridViewTextBoxColumn1"
        Me.EKPreisDataGridViewTextBoxColumn1.Width = 81
        '
        'VKPreisDataGridViewTextBoxColumn1
        '
        Me.VKPreisDataGridViewTextBoxColumn1.DataPropertyName = "VKPreis"
        Me.VKPreisDataGridViewTextBoxColumn1.HeaderText = "VKPreis"
        Me.VKPreisDataGridViewTextBoxColumn1.Name = "VKPreisDataGridViewTextBoxColumn1"
        Me.VKPreisDataGridViewTextBoxColumn1.Width = 81
        '
        'FaktorDataGridViewTextBoxColumn1
        '
        Me.FaktorDataGridViewTextBoxColumn1.DataPropertyName = "Faktor"
        Me.FaktorDataGridViewTextBoxColumn1.HeaderText = "Faktor"
        Me.FaktorDataGridViewTextBoxColumn1.Name = "FaktorDataGridViewTextBoxColumn1"
        Me.FaktorDataGridViewTextBoxColumn1.Width = 71
        '
        'AGSelectedDataGridViewCheckBoxColumn1
        '
        Me.AGSelectedDataGridViewCheckBoxColumn1.DataPropertyName = "AGSelected"
        Me.AGSelectedDataGridViewCheckBoxColumn1.HeaderText = "AGSelected"
        Me.AGSelectedDataGridViewCheckBoxColumn1.Name = "AGSelectedDataGridViewCheckBoxColumn1"
        Me.AGSelectedDataGridViewCheckBoxColumn1.Width = 87
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(845, 564)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "DebugArtikel"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtikelIDDataGridViewTextBoxColumn2, Me.ProduktIDDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.URLDataGridViewTextBoxColumn2, Me.ArtikelnummerDataGridViewTextBoxColumn, Me.RubrikDataGridViewTextBoxColumn, Me.BeschreibungDataGridViewTextBoxColumn, Me.EKPreisDataGridViewTextBoxColumn, Me.VKPreisDataGridViewTextBoxColumn, Me.FaktorDataGridViewTextBoxColumn, Me.AGSelectedDataGridViewCheckBoxColumn})
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(845, 564)
        Me.DataGridView4.TabIndex = 0
        '
        'ArtikelIDDataGridViewTextBoxColumn2
        '
        Me.ArtikelIDDataGridViewTextBoxColumn2.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn2.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn2.Name = "ArtikelIDDataGridViewTextBoxColumn2"
        Me.ArtikelIDDataGridViewTextBoxColumn2.Width = 83
        '
        'ProduktIDDataGridViewTextBoxColumn1
        '
        Me.ProduktIDDataGridViewTextBoxColumn1.DataPropertyName = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn1.HeaderText = "ProduktID"
        Me.ProduktIDDataGridViewTextBoxColumn1.Name = "ProduktIDDataGridViewTextBoxColumn1"
        Me.ProduktIDDataGridViewTextBoxColumn1.Width = 92
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn1.HeaderText = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 104
        '
        'URLDataGridViewTextBoxColumn2
        '
        Me.URLDataGridViewTextBoxColumn2.DataPropertyName = "URL"
        Me.URLDataGridViewTextBoxColumn2.HeaderText = "URL"
        Me.URLDataGridViewTextBoxColumn2.Name = "URLDataGridViewTextBoxColumn2"
        Me.URLDataGridViewTextBoxColumn2.Width = 60
        '
        'ArtikelnummerDataGridViewTextBoxColumn
        '
        Me.ArtikelnummerDataGridViewTextBoxColumn.DataPropertyName = "Artikelnummer"
        Me.ArtikelnummerDataGridViewTextBoxColumn.HeaderText = "Artikelnummer"
        Me.ArtikelnummerDataGridViewTextBoxColumn.Name = "ArtikelnummerDataGridViewTextBoxColumn"
        Me.ArtikelnummerDataGridViewTextBoxColumn.Width = 118
        '
        'RubrikDataGridViewTextBoxColumn
        '
        Me.RubrikDataGridViewTextBoxColumn.DataPropertyName = "Rubrik"
        Me.RubrikDataGridViewTextBoxColumn.HeaderText = "Rubrik"
        Me.RubrikDataGridViewTextBoxColumn.Name = "RubrikDataGridViewTextBoxColumn"
        Me.RubrikDataGridViewTextBoxColumn.Width = 72
        '
        'BeschreibungDataGridViewTextBoxColumn
        '
        Me.BeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung"
        Me.BeschreibungDataGridViewTextBoxColumn.Name = "BeschreibungDataGridViewTextBoxColumn"
        Me.BeschreibungDataGridViewTextBoxColumn.Width = 116
        '
        'EKPreisDataGridViewTextBoxColumn
        '
        Me.EKPreisDataGridViewTextBoxColumn.DataPropertyName = "EKPreis"
        Me.EKPreisDataGridViewTextBoxColumn.HeaderText = "EKPreis"
        Me.EKPreisDataGridViewTextBoxColumn.Name = "EKPreisDataGridViewTextBoxColumn"
        Me.EKPreisDataGridViewTextBoxColumn.Width = 81
        '
        'VKPreisDataGridViewTextBoxColumn
        '
        Me.VKPreisDataGridViewTextBoxColumn.DataPropertyName = "VKPreis"
        Me.VKPreisDataGridViewTextBoxColumn.HeaderText = "VKPreis"
        Me.VKPreisDataGridViewTextBoxColumn.Name = "VKPreisDataGridViewTextBoxColumn"
        Me.VKPreisDataGridViewTextBoxColumn.Width = 81
        '
        'FaktorDataGridViewTextBoxColumn
        '
        Me.FaktorDataGridViewTextBoxColumn.DataPropertyName = "Faktor"
        Me.FaktorDataGridViewTextBoxColumn.HeaderText = "Faktor"
        Me.FaktorDataGridViewTextBoxColumn.Name = "FaktorDataGridViewTextBoxColumn"
        Me.FaktorDataGridViewTextBoxColumn.Width = 71
        '
        'AGSelectedDataGridViewCheckBoxColumn
        '
        Me.AGSelectedDataGridViewCheckBoxColumn.DataPropertyName = "AGSelected"
        Me.AGSelectedDataGridViewCheckBoxColumn.HeaderText = "AGSelected"
        Me.AGSelectedDataGridViewCheckBoxColumn.Name = "AGSelectedDataGridViewCheckBoxColumn"
        Me.AGSelectedDataGridViewCheckBoxColumn.Width = 87
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DataGridView6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage7.Size = New System.Drawing.Size(845, 564)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Spezifikation"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OptionIDDataGridViewTextBoxColumn1, Me.AngebotsnummerDataGridViewTextBoxColumn1, Me.ArtikelIDDataGridViewTextBoxColumn3, Me.SortRowDataGridViewTextBoxColumn1})
        Me.DataGridView6.DataSource = Me.SpezOptionenBindingSource
        Me.DataGridView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView6.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(841, 560)
        Me.DataGridView6.TabIndex = 0
        '
        'OptionIDDataGridViewTextBoxColumn1
        '
        Me.OptionIDDataGridViewTextBoxColumn1.DataPropertyName = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn1.HeaderText = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn1.Name = "OptionIDDataGridViewTextBoxColumn1"
        '
        'AngebotsnummerDataGridViewTextBoxColumn1
        '
        Me.AngebotsnummerDataGridViewTextBoxColumn1.DataPropertyName = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn1.HeaderText = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn1.Name = "AngebotsnummerDataGridViewTextBoxColumn1"
        '
        'ArtikelIDDataGridViewTextBoxColumn3
        '
        Me.ArtikelIDDataGridViewTextBoxColumn3.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn3.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn3.Name = "ArtikelIDDataGridViewTextBoxColumn3"
        '
        'SortRowDataGridViewTextBoxColumn1
        '
        Me.SortRowDataGridViewTextBoxColumn1.DataPropertyName = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn1.HeaderText = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn1.Name = "SortRowDataGridViewTextBoxColumn1"
        '
        'SpezOptionenBindingSource
        '
        Me.SpezOptionenBindingSource.DataMember = "SpezOptionen"
        Me.SpezOptionenBindingSource.DataSource = Me.DataSet1
        '
        'HerstellerProduktBindingSource
        '
        Me.HerstellerProduktBindingSource.DataMember = "Hersteller_Produkt"
        Me.HerstellerProduktBindingSource.DataSource = Me.HerstellerBindingSource
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProduktArtikelBindingSource
        '
        Me.ProduktArtikelBindingSource.DataSource = Me.DataSet1
        Me.ProduktArtikelBindingSource.Position = 0
        '
        'NewTreeView1
        '
        Me.NewTreeView1.AllowDrop = True
        Me.NewTreeView1.BackColor = System.Drawing.Color.Ivory
        Me.NewTreeView1.CheckBoxes = True
        Me.NewTreeView1.ContextMenuStrip = Me.CMS_NewTreeView1
        Me.NewTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewTreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewTreeView1.ImageIndex = 0
        Me.NewTreeView1.ImageList = Me.ImageList1
        Me.NewTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.NewTreeView1.Name = "NewTreeView1"
        Me.NewTreeView1.SelectedImageIndex = 0
        Me.NewTreeView1.Size = New System.Drawing.Size(428, 593)
        Me.NewTreeView1.TabIndex = 7
        '
        'ProduktArtikelBindingSource1
        '
        Me.ProduktArtikelBindingSource1.DataMember = "Produkt_Artikel"
        Me.ProduktArtikelBindingSource1.DataSource = Me.ProduktBindingSource
        '
        'FKArtikelSpezOptionenBindingSource
        '
        Me.FKArtikelSpezOptionenBindingSource.DataMember = "FK_Artikel_SpezOptionen"
        Me.FKArtikelSpezOptionenBindingSource.DataSource = Me.ArtikelBindingSource
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 55)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NewTreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1285, 593)
        Me.SplitContainer1.SplitterDistance = 428
        Me.SplitContainer1.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HerstellerBindingSource, "Hersteller", True))
        Me.Label8.Location = New System.Drawing.Point(652, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Label8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 670)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.CMS_NewTreeView1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKKundeAngebotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerstellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HerstellerProduktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduktArtikelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduktArtikelBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKArtikelSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktstrukturNeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktstrukturÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktstrukturSpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktstrukturSpeichernUnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSB_AddProductNode As ToolStripButton
    Friend WithEvents TSB_AddArticleNode As ToolStripButton
    Friend WithEvents TSB_DeleteNode As ToolStripButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents TSB_AddManufacturerNode As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_URL_Artikel As Button
    Friend WithEvents TBox_URL_Artikel As TextBox
    Friend WithEvents TBox_Faktor As TextBox
    Friend WithEvents MaskedTBox_VK As MaskedTextBox
    Friend WithEvents MaskedTBox_EK As MaskedTextBox
    Friend WithEvents TBox_Beschreibung As TextBox
    Friend WithEvents TBox_Angebotstext As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TBox_Rubrik As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBox_Produkt As ComboBox
    Friend WithEvents CBox_Hersteller As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HerstellerBindingSource As BindingSource
    Friend WithEvents HerstellerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HerstellerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents URLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduktIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KategorieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProduktTypDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HerstellerIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents URLDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents HerstellerProduktBindingSource As BindingSource
    Friend WithEvents LfdNrDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LfdNrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label25 As Label
    Friend WithEvents TBox_Firma1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TBox_Firma2 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BTN_down As Button
    Friend WithEvents BTN_up As Button
    Friend WithEvents CBox_DokVorlage As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents CBox_Vertreter As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TBox_Angebotstitel As TextBox
    Friend WithEvents TB_Ort As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TB_PLZ As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TBox_Strasse As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TBox_Name2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TBox_Name1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents VertreterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VertreterlisteBearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents VertreterBindingSource As BindingSource
    Friend WithEvents MaskedTBox_Artikelnummer As MaskedTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CMS_NewTreeView1 As ContextMenuStrip
    Friend WithEvents KnotenEditierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnzeigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LfdNrPosAGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LfdNrPosAGDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelBindingSource As BindingSource
    Friend WithEvents KonfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextmarkenDefinierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TBox_NodeSelImageIndex As TextBox
    Friend WithEvents TBox_NodeImageIndex As TextBox
    Friend WithEvents TBox_NodeTag As TextBox
    Friend WithEvents TBox_NodeName As TextBox
    Friend WithEvents TBox_NodeText As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AngebotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label35 As Label
    Friend WithEvents Btn_AddCustomer As Button
    Friend WithEvents CB_Angebotsnummer As ComboBox
    Friend WithEvents CB_Kundennummer As ComboBox
    Friend WithEvents Btn_DelCustomer As Button
    Friend WithEvents Btn_AddOffer As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents ProduktBindingSource As BindingSource
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProduktIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents URLDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RubrikDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AngebotskurztextDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EKPreisDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VKPreisDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FaktorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AGSelectedDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents ProduktArtikelBindingSource As BindingSource
    Friend WithEvents ArtikelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotskurztextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents KundeBindingSource As BindingSource
    Friend WithEvents NewTreeView1 As TreeView
    Friend WithEvents AngebotsnummerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProduktIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents URLDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RubrikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeschreibungDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKPreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VKPreisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaktorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AGSelectedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ProduktArtikelBindingSource1 As BindingSource
    Friend WithEvents FKArtikelSpezOptionenBindingSource As BindingSource
    Friend WithEvents FKKundeAngebotBindingSource As BindingSource
    Friend WithEvents FKAngebotSpezOptionenBindingSource As BindingSource
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents OptionIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AngebotsnummerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SortRowDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SpezOptionenBindingSource As BindingSource
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents OptionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotsnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SortRowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
End Class
