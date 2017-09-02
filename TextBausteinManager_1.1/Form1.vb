Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices.ComTypes
Imports System.Threading


Public Class Form1
    Inherits System.Windows.Forms.Form
    Private NodeCount As Integer
    Private FolderCount As Integer
    Private NodeMap As String
    Private Const MAPSIZE As Integer = 128
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents save_XML As Button
    Friend WithEvents load_XML As Button
    Private NewNodeMap As New System.Text.StringBuilder(MAPSIZE)
    Friend WithEvents del_Node As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem

    Dim VT_edit As Boolean = False
    Dim Edit_TBox_URL_Artikel = False
    Dim TBMOffer As Boolean = False
    Dim TBMStructure As Boolean = False
    Dim counter As Integer = 0
    Dim mySelectedNode As New TreeNode
    Dim XMLp As New XMLParser
    Dim SO_RW_XML As New XML_Offer_read_write
    Dim VT_DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml")
    Dim Dateiname_tree As String = ""

    Dim Vertreter_e_mail As String = ""
    Dim Vertreter_Mobilummer As String = ""
    Dim FilePath As String = "Server"

    Private mdrect As Rectangle
    Private mdindex As Integer

#Region "Programm und UserInterface initialisieren"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml", "")
        End If
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini", "")
        End If
        With DataGridView5.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(DataGridView5.Font, FontStyle.Regular)
        End With
        With DataGridView5.RowsDefaultCellStyle
            .Font = New Font(DataGridView5.Font, FontStyle.Regular)
        End With
    End Sub

    Sub InitHMI()
        Form2.DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
        With DataGridView5
            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        End With
        'Vorlagen Dokumente in Combobox laden
        Dim OrtEigeneDateien As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        Dim Dir As New DirectoryInfo(OrtEigeneDateien & "\Benutzerdefinierte Office-Vorlagen\")
        For Each file As FileInfo In Dir.GetFiles
            If Microsoft.VisualBasic.Left(file.Name, 1) <> "~" Then
                CBox_DokVorlage.Items.Add(file.Name)
            End If
        Next
        TreeView_actualize()
        GroupBox2.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")" 'Anzahl Artikel
        GroupBox3.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Dim tn As TreeNode = NewTreeView1.Nodes(0)
        NewTreeView1.SelectedNode = tn
        NewTreeView1.Select()
        NewTreeView1.Focus()
        'Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
#End Region

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Save_product_structure()
    End Sub

#Region "Hersteller, Produkt und Artikel im TreeView hinzufügen oder löschen; TSB=ToolStripButton"
    Private Sub TSB_AddManufacturerNode_Click(sender As Object, e As EventArgs) Handles TSB_AddManufacturerNode.Click
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim answer As Object
        ' If NewTreeView1.SelectedNode.Tag <> "document" Then
        prompt = "Hersteller:"
        title = "Herstellername eingeben"
        defaultResponse = "Hersteller Knoten"
        answer = InputBox(prompt, title, defaultResponse)
        If answer IsNot "" Then
            Dim newNode As TreeNode = New TreeNode(answer, 0, 0)
            System.Threading.Interlocked.Increment(Me.FolderCount)
            Me.NewTreeView1.Nodes.Add(newNode) 'Hersteller immer als Wurzelknoten einfügen
            newNode.Text = answer
            newNode.Name = "manufacturer_" & Guid.NewGuid.ToString
            newNode.Tag = "manufacturer"
            newNode.ImageIndex = 4
            newNode.SelectedImageIndex = 4
            'Datatable schreiben
            Dim NewHRow As DataSet1.HerstellerRow
            NewHRow = DataSet1.Hersteller.NewHerstellerRow()
            NewHRow.HerstellerID = newNode.Name
            NewHRow.Hersteller = newNode.Text
            DataSet1.Hersteller.Rows.Add(NewHRow)
            TBox_NodeText.Text = newNode.Text
            TBox_NodeName.Text = newNode.Name
            TBox_NodeTag.Text = newNode.Tag
            TBox_NodeImageIndex.Text = 4
            TBox_NodeSelImageIndex.Text = 4
            TBMStructure = True
        End If
    End Sub

    Private Sub TSB_AddProductNode_Click(sender As Object, e As EventArgs) Handles TSB_AddProductNode.Click
        'MsgBox("add_Produkt")
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim answer As Object
        ' If NewTreeView1.SelectedNode.Tag <> "document" Then
        prompt = "Produkt:"
        title = "Produktname eingeben"
        defaultResponse = "Produkt Knoten"
        answer = InputBox(prompt, title, defaultResponse)
        If answer IsNot "" Then
            Dim newNode As TreeNode = New TreeNode(answer, 0, 0)
            System.Threading.Interlocked.Increment(Me.FolderCount)
            If NewTreeView1.Nodes.Count = 0 Then
                Me.NewTreeView1.Nodes.Add(newNode)
            Else
                If NewTreeView1.SelectedNode IsNot Nothing Then
                    Me.NewTreeView1.SelectedNode.Nodes.Add(newNode)
                Else
                    MsgBox("kein Knoten ausgewählt", MsgBoxStyle.Exclamation)
                End If
            End If
            newNode.Text = answer
            newNode.Name = "product_" & Guid.NewGuid.ToString
            newNode.Tag = "product"
            newNode.ImageIndex = 0
            newNode.SelectedImageIndex = 0
            'Datatable schreiben
            Dim NewPRow As DataSet1.ProduktRow
            NewPRow = DataSet1.Produkt.NewProduktRow
            NewPRow.ProduktID = newNode.Name
            NewPRow.ProduktTyp = newNode.Text
            NewPRow.HerstellerID = CBox_Hersteller.SelectedValue 'Verknüpfung zum Hersteller erstellen
            DataSet1.Produkt.Rows.Add(NewPRow)
            TBox_NodeText.Text = newNode.Text
            TBox_NodeName.Text = newNode.Name
            TBox_NodeTag.Text = newNode.Tag
            TBox_NodeImageIndex.Text = 0
            TBox_NodeSelImageIndex.Text = 0
            TBMStructure = True
        End If
    End Sub

    Private Sub TSB_AddArticleNode_Click_1(sender As Object, e As EventArgs) Handles TSB_AddArticleNode.Click
        Try
            If NewTreeView1.SelectedNode.Tag = "product" Then
                'MsgBox("add_Artikel")
                Dim prompt As String = String.Empty
                Dim title As String = String.Empty
                Dim defaultResponse As String = String.Empty
                Dim answer As Object
                prompt = "Artikel: "
                title = "Knotennamen des Artikels eingeben"
                defaultResponse = "Artikel Knoten"
                answer = InputBox(prompt, title, defaultResponse)
                If answer IsNot "" Then
                    Dim newNode As TreeNode = New TreeNode(answer, 2, 2)
                    System.Threading.Interlocked.Increment(Me.NodeCount)
                    If NewTreeView1.Nodes.Count = 0 Then
                        Me.NewTreeView1.Nodes.Add(newNode)
                    Else
                        Me.NewTreeView1.SelectedNode.Nodes.Add(newNode)
                    End If
                    newNode.Name = "article_" & Guid.NewGuid.ToString
                    newNode.Tag = "article"
                    newNode.ImageIndex = 1
                    newNode.SelectedImageIndex = 1
                    'Datatable schreiben
                    Dim NewARow As DataSet1.ArtikelRow

                    NewARow = DataSet1.Artikel.NewArtikelRow()
                    NewARow.ArtikelID = newNode.Name

                    NewARow.ProduktID = CBox_Produkt.SelectedValue 'Verknüpfung zum Produkt erstellen
                    DataSet1.Artikel.Rows.Add(NewARow)
                    TBox_NodeText.Text = newNode.Text
                    TBox_NodeName.Text = newNode.Name
                    TBox_NodeTag.Text = newNode.Tag
                    TBox_NodeImageIndex.Text = 1
                    TBox_NodeSelImageIndex.Text = 1
                    TBMStructure = True
                    GroupBox2.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")"
                End If
            Else
                MsgBox("Hier kann kein Artikel eingefügt werden", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Es existiert kein gültiger Wurzelknoten", vbExclamation)
        End Try
    End Sub

    Private Sub TSB_DeleteNode_Click(sender As Object, e As EventArgs) Handles TSB_DeleteNode.Click
        If NewTreeView1.Nodes.Count > 0 Then
            If NewTreeView1.SelectedNode.Checked = False Then
                Select Case MessageBox.Show("Wollen Sie den selektierten Knoten wirklich löschen?", "Knoten löschen", MessageBoxButtons.YesNo)
                    Case DialogResult.Yes
                        If NewTreeView1.SelectedNode.Tag = "article" Then
                            Dim ARowEdit As DataSet1.ArtikelRow
                            ARowEdit = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
                            ARowEdit.Delete()
                        End If
                        If NewTreeView1.SelectedNode.Tag = "product" Then
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.Delete()
                        End If
                        NewTreeView1.Nodes.Remove(NewTreeView1.SelectedNode)
                    Case DialogResult.No
                        MsgBox("Löschen abgebrochen", vbExclamation)
                End Select
                GroupBox2.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")"
            Else
                MsgBox("Der Knoten ist noch im aktuellen Angebot enthalten!", vbExclamation)
            End If
        End If
    End Sub
#End Region

#Region "Treeview Drag and Drop"
    Private Sub NewTreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NewTreeView1.MouseDown
        NewTreeView1.LabelEdit = False
        Me.NewTreeView1.SelectedNode = Me.NewTreeView1.GetNodeAt(e.X, e.Y)
        mySelectedNode = Me.NewTreeView1.GetNodeAt(e.X, e.Y) ' wird zum Knoten editieren benötigt
    End Sub

    Private Sub NewTreeView1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles NewTreeView1.ItemDrag
        If Me.NewTreeView1.SelectedNode.Tag <> "manufacturer" Then
            DoDragDrop(e.Item, DragDropEffects.Move)
        End If
    End Sub

    Private Sub NewTreeView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub NewTreeView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragDrop
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", False) AndAlso Not (Me.NodeMap = "") Then
            Dim MovingNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            Dim NodeIndexes As String() = Me.NodeMap.Split("|"c)
            Dim InsertCollection As TreeNodeCollection = Me.NewTreeView1.Nodes
            Dim i As Integer = 0
            While i < NodeIndexes.Length - 1
                InsertCollection = InsertCollection(Int32.Parse(NodeIndexes(i))).Nodes
                System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            If Not (InsertCollection Is Nothing) Then
                InsertCollection.Insert(Int32.Parse(NodeIndexes(NodeIndexes.Length - 1)), CType(MovingNode.Clone, TreeNode))
                Me.NewTreeView1.SelectedNode = InsertCollection(Int32.Parse(NodeIndexes(NodeIndexes.Length - 1)))
                MovingNode.Remove()
            End If
        End If
        NewArticleBinding()
    End Sub

    Private Sub NewTreeView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragOver
        Dim NodeOver As TreeNode = Me.NewTreeView1.GetNodeAt(Me.NewTreeView1.PointToClient(Cursor.Position))
        Dim NodeMoving As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
        Dim TopTreeNode As TreeNode = NewTreeView1.TopNode
        If Not (NodeOver Is Nothing) AndAlso (Not (NodeOver Is NodeMoving) OrElse (Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = (NodeOver.Parent.Nodes.Count - 1))) Then
            If NodeOver IsNot TopTreeNode Then
                Dim OffsetY As Integer = Me.NewTreeView1.PointToClient(Cursor.Position).Y - NodeOver.Bounds.Top
                Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
                Dim g As Graphics = Me.NewTreeView1.CreateGraphics
                If NodeOver.ImageIndex = 1 Then
                    If OffsetY < (NodeOver.Bounds.Height / 2) Then
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        SetNewNodeMap(NodeOver, False)  ' ERROR!  Not sure why
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        Me.DrawLeafTopPlaceholders(NodeOver)
                    Else
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        Dim ParentDragDrop As TreeNode = Nothing
                        If Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = (NodeOver.Parent.Nodes.Count - 1) Then
                            Dim XPos As Integer = Me.NewTreeView1.PointToClient(Cursor.Position).X
                            If XPos < NodeOver.Bounds.Left Then
                                ParentDragDrop = NodeOver.Parent
                                If XPos < (ParentDragDrop.Bounds.Left - Me.NewTreeView1.ImageList.Images(ParentDragDrop.ImageIndex).Size.Width) Then
                                    If Not (ParentDragDrop.Parent Is Nothing) Then
                                        ParentDragDrop = ParentDragDrop.Parent
                                    End If
                                End If
                            End If
                        End If
                        SetNewNodeMap(Microsoft.VisualBasic.IIf(Not (ParentDragDrop Is Nothing), ParentDragDrop, NodeOver), True)
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        DrawLeafBottomPlaceholders(NodeOver, ParentDragDrop)
                    End If
                Else
                    If OffsetY < (NodeOver.Bounds.Height / 3) Then
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        SetNewNodeMap(NodeOver, False)
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        Me.DrawFolderTopPlaceholders(NodeOver)
                    Else
                        If (Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = 0) AndAlso (OffsetY > (NodeOver.Bounds.Height - (NodeOver.Bounds.Height / 3))) Then
                            Dim tnParadox As TreeNode = NodeOver
                            While Not (tnParadox.Parent Is Nothing)
                                If tnParadox.Parent Is NodeMoving Then
                                    Me.NodeMap = ""
                                    Return
                                End If
                                tnParadox = tnParadox.Parent
                            End While
                            SetNewNodeMap(NodeOver, True)
                            If SetMapsEqual() = True Then
                                Return
                            End If
                            Me.Refresh()
                            DrawFolderTopPlaceholders(NodeOver)
                        Else
                            If NodeOver.Nodes.Count > 0 Then
                                NodeOver.Expand()
                            Else
                                If NodeMoving Is NodeOver Then
                                    Return
                                End If
                                Dim tnParadox As TreeNode = NodeOver
                                While Not (tnParadox.Parent Is Nothing)
                                    If tnParadox.Parent Is NodeMoving Then
                                        Me.NodeMap = ""
                                        Return
                                    End If
                                    tnParadox = tnParadox.Parent
                                End While
                                SetNewNodeMap(NodeOver, False)
                                NewNodeMap = NewNodeMap.Insert(NewNodeMap.Length, "|0")
                                If SetMapsEqual() = True Then
                                    Return
                                End If
                                Me.Refresh()
                                DrawAddToFolderPlaceholder(NodeOver)
                            End If
                        End If
                    End If
                End If
            Else
                Me.DrawLeafTopPlaceholders(NodeOver)
            End If
        End If
    End Sub

    Private Sub DrawLeafTopPlaceholders(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer = NodeOver.Bounds.Left - NodeOverImageWidth
        Dim RightPos As Integer = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Top - 4), New Point(LeftPos, NodeOver.Bounds.Top + 4), New Point(LeftPos + 4, NodeOver.Bounds.Y), New Point(LeftPos + 4, NodeOver.Bounds.Top - 1), New Point(LeftPos, NodeOver.Bounds.Top - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Top - 4), New Point(RightPos, NodeOver.Bounds.Top + 4), New Point(RightPos - 4, NodeOver.Bounds.Y), New Point(RightPos - 4, NodeOver.Bounds.Top - 1), New Point(RightPos, NodeOver.Bounds.Top - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Top), New Point(RightPos, NodeOver.Bounds.Top))
    End Sub

    Private Sub DrawLeafBottomPlaceholders(ByVal NodeOver As TreeNode, ByVal ParentDragDrop As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer
        Dim RightPos As Integer
        If Not (ParentDragDrop Is Nothing) Then
            LeftPos = ParentDragDrop.Bounds.Left - (Me.NewTreeView1.ImageList.Images(ParentDragDrop.ImageIndex).Size.Width + 8)
        Else
            LeftPos = NodeOver.Bounds.Left - NodeOverImageWidth
        End If
        RightPos = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Bottom - 4), New Point(LeftPos, NodeOver.Bounds.Bottom + 4), New Point(LeftPos + 4, NodeOver.Bounds.Bottom), New Point(LeftPos + 4, NodeOver.Bounds.Bottom - 1), New Point(LeftPos, NodeOver.Bounds.Bottom - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Bottom - 4), New Point(RightPos, NodeOver.Bounds.Bottom + 4), New Point(RightPos - 4, NodeOver.Bounds.Bottom), New Point(RightPos - 4, NodeOver.Bounds.Bottom - 1), New Point(RightPos, NodeOver.Bounds.Bottom - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Bottom), New Point(RightPos, NodeOver.Bounds.Bottom))
    End Sub

    Private Sub DrawFolderTopPlaceholders(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer
        Dim RightPos As Integer
        LeftPos = NodeOver.Bounds.Left - NodeOverImageWidth
        RightPos = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Top - 4), New Point(LeftPos, NodeOver.Bounds.Top + 4), New Point(LeftPos + 4, NodeOver.Bounds.Y), New Point(LeftPos + 4, NodeOver.Bounds.Top - 1), New Point(LeftPos, NodeOver.Bounds.Top - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Top - 4), New Point(RightPos, NodeOver.Bounds.Top + 4), New Point(RightPos - 4, NodeOver.Bounds.Y), New Point(RightPos - 4, NodeOver.Bounds.Top - 1), New Point(RightPos, NodeOver.Bounds.Top - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Top), New Point(RightPos, NodeOver.Bounds.Top))
    End Sub

    Private Sub DrawAddToFolderPlaceholder(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim RightPos As Integer = NodeOver.Bounds.Right + 6
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) + 4), New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) + 4), New Point(RightPos - 4, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2)), New Point(RightPos - 4, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) - 1), New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) - 5)}
        Me.Refresh()
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
    End Sub

    Private Sub SetNewNodeMap(ByVal tnNode As TreeNode, ByVal boolBelowNode As Boolean)
        NewNodeMap.Length = 0
        If boolBelowNode Then
            NewNodeMap.Insert(0, CType(tnNode.Index, Integer) + 1)
        Else
            NewNodeMap.Insert(0, CType(tnNode.Index, Integer))
        End If
        Dim tnCurNode As TreeNode = tnNode
        While Not (tnCurNode.Parent Is Nothing)
            tnCurNode = tnCurNode.Parent
            If NewNodeMap.Length = 0 AndAlso boolBelowNode = True Then
                NewNodeMap.Insert(0, CStr(tnCurNode.Index + 1) + "|")
            Else
                NewNodeMap.Insert(0, CStr(tnCurNode.Index) + "|")
            End If
        End While
    End Sub

    Private Function SetMapsEqual() As Boolean
        If Me.NewNodeMap.ToString = Me.NodeMap Then
            Return True
        Else
            Me.NodeMap = Me.NewNodeMap.ToString
            Return False
        End If
    End Function

    Sub NewArticleBinding()
        Try
            If NewTreeView1.SelectedNode.Tag = "article" Then
                Dim PRowEdit As DataSet1.ProduktRow
                PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Parent.Name)
                Dim ARowEdit As DataSet1.ArtikelRow
                ARowEdit = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
                ARowEdit.ProduktID = NewTreeView1.SelectedNode.Parent.Name
            End If
            If NewTreeView1.SelectedNode.Tag = "product" Then
                If NewTreeView1.SelectedNode.Parent IsNot Nothing Then
                    If NewTreeView1.SelectedNode.Parent.Tag = "manufacturer" Then
                        If NewTreeView1.SelectedNode.Parent.Name IsNot Nothing Then
                            Dim HRowEdit As DataSet1.HerstellerRow
                            HRowEdit = DataSet1.Hersteller.FindByHerstellerID(NewTreeView1.SelectedNode.Parent.Name)
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.HerstellerID = NewTreeView1.SelectedNode.Parent.Name
                            'MsgBox(HRowEdit.HerstellerID)
                        Else
                            Dim HRowEdit As DataSet1.HerstellerRow
                            HRowEdit = DataSet1.Hersteller.FindByHerstellerID(NewTreeView1.TopNode.Name)
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.HerstellerID = NewTreeView1.TopNode.Name
                            'MsgBox(HRowEdit.HerstellerID)
                        End If
                    Else
                        Dim PRowEdit As DataSet1.ProduktRow
                        PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Parent.Name)
                        PRowEdit.ProduktID = NewTreeView1.SelectedNode.Parent.Name
                    End If
                    NewTreeView1.SelectedNode.ImageIndex = 0
                    NewTreeView1.SelectedNode.SelectedImageIndex = 0
                Else
                    Dim PRowEdit As DataSet1.ProduktRow
                    PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                    PRowEdit.HerstellerID = "undefined"
                    NewTreeView1.SelectedNode.ImageIndex = 5
                    NewTreeView1.SelectedNode.SelectedImageIndex = 5
                End If
            End If
        Catch ex As Exception
            MsgBox("Es existiert kein gültiger Wurzelknoten", vbExclamation)
        End Try
    End Sub
#End Region

#Region "Artikelfenster Daten updaten"
    Private Sub NewTreeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles NewTreeView1.AfterSelect
        Dim currentNode As TreeNode = Nothing
        ArticleHMI(NewTreeView1.SelectedNode.Tag)
        currentNode = e.Node
        If currentNode.Parent IsNot Nothing Then
            SelectedNodeChanged()
        End If
        If NewTreeView1.SelectedNode.Tag = "manufacturer" Then CBox_Hersteller.Text = NewTreeView1.SelectedNode.Text
        If NewTreeView1.SelectedNode.Tag = "product" Then CBox_Produkt.Text = NewTreeView1.SelectedNode.Text
        TBox_NodeText.Text = NewTreeView1.SelectedNode.Text
        TBox_NodeName.Text = NewTreeView1.SelectedNode.Name
        TBox_NodeTag.Text = NewTreeView1.SelectedNode.Tag
        TBox_NodeImageIndex.Text = CStr(NewTreeView1.SelectedNode.ImageIndex)
        TBox_NodeSelImageIndex.Text = CStr(NewTreeView1.SelectedNode.SelectedImageIndex)

        'wenn der NAme des Knoten geändert wird im Dataset speichern

        If NewTreeView1.SelectedNode.Tag = "manufacturer" Then
            Dim NewHerstellerRow As DataSet1.HerstellerRow
            NewHerstellerRow = DataSet1.Hersteller.FindByHerstellerID(NewTreeView1.SelectedNode.Name)
            NewHerstellerRow.Hersteller = NewTreeView1.SelectedNode.Text
        End If
        If NewTreeView1.SelectedNode.Tag = "product" Then
            Dim NewProduktRow As DataSet1.ProduktRow
            NewProduktRow = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
            NewProduktRow.ProduktTyp = NewTreeView1.SelectedNode.Text
        End If

    End Sub

    Sub ArticleHMI(NodeTag As String)
        If NodeTag = "article" Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Sub SelectedNodeChanged()
        'Beim Click auf NewTreeView1 Zeile im Datagrid 5 selektieren
        For i As Integer = 0 To DataGridView5.Rows.Count - 1
            If DataGridView5.Rows(i).Cells(1).Value.ToString = NewTreeView1.SelectedNode.Name.ToString() Then
                'markiert die Zeile
                DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView5.Rows(i).Selected = True
                DataGridView5.FirstDisplayedScrollingRowIndex = i
            End If
        Next
        'fertig
        If NewTreeView1.SelectedNode.Tag = "article" Then
            Dim PRowindex = ProduktBindingSource.Find("ProduktID", NewTreeView1.SelectedNode.Parent.Name)
            If NewTreeView1.SelectedNode.Parent.Tag <> "manufacturer" Then
                If PRowindex <> -1 Then
                    ProduktBindingSource.Position = PRowindex
                End If
            End If
        End If
        Dim ARowindex = ArtikelBindingSource.Find("ArtikelID", NewTreeView1.SelectedNode.Name)
        If ARowindex <> -1 Then
            ArtikelBindingSource.Position = ARowindex
            Dim rowIndex As Integer = -1
            For Each row As DataGridViewRow In DataGridView5.Rows
                If row.Cells(0).Value.ToString().Equals(NewTreeView1.SelectedNode.Name) Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DataGridView5_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView5.MouseClick
        If DataGridView5.Rows.Count > 0 Then
            Dim ArtikelID As String = ""
            Dim node As TreeNode = Nothing
            ArtikelID = DataGridView5.CurrentRow.Cells(1).Value
            If TBMStructure = True And ArtikelID <> "" Then
                NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(ArtikelID, True)(0)
                NewTreeView1.Select()
                NewTreeView1.SelectedNode.Expand()
            End If
        End If

    End Sub

    Private Sub CBox_Produkt_DropDownClosed(sender As Object, e As EventArgs) Handles CBox_Produkt.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(CBox_Produkt.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub CBox_Hersteller_DropDownClosed(sender As Object, e As EventArgs) Handles CBox_Hersteller.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(CBox_Hersteller.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Btn_URL_Artikel_Click(sender As Object, e As EventArgs) Handles Btn_URL_Artikel.Click
        URL_ArticleCheck()
    End Sub

    Sub URL_ArticleCheck()
        Dim row As DataSet1.ArtikelRow = Nothing
        Dim strFile As String = ""
        OpenFileDialog1.FileName = ""
        If NewTreeView1.SelectedNode IsNot Nothing Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                strFile = OpenFileDialog1.FileName.ToString
                TBox_URL_Artikel.Text = strFile
                If File.Exists(TBox_URL_Artikel.Text) Then
                    NewTreeView1.SelectedNode.ImageIndex = 2
                    NewTreeView1.SelectedNode.SelectedImageIndex = 2
                Else
                    NewTreeView1.SelectedNode.ImageIndex = 3
                    NewTreeView1.SelectedNode.SelectedImageIndex = 3
                End If
            Else
                MsgBox("Aktion durch Benutzer abgebrochen!", vbExclamation)
            End If
        End If
    End Sub

#End Region

#Region "Produktstruktur und Dataset speichern oder speichern unter sowie öffnen"
    Private Sub ProduktstrukturNeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktstrukturNeuToolStripMenuItem.Click
        Save_product_structure()
        TBMStructure = True
        NewTreeView1.Nodes.Clear()
        Save_product_structure_under()
    End Sub


    Private Sub ProduktstrukturÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktstrukturÖffnenToolStripMenuItem.Click
        Open_product_structure()
    End Sub

    Private Sub ProduktstrukturSpeichernToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProduktstrukturSpeichernToolStripMenuItem.Click
        If TBMStructure = True Then
            Save_product_structure()
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub ProduktstrukturSpeichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktstrukturSpeichernUnterToolStripMenuItem.Click
        If TBMStructure = True Then
            Save_product_structure_under()
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub Save_product_structure()
        If Dateiname_tree <> "" Then
            If TBMStructure = True Then
                Dim _DataTree As New FileInfo(Dateiname_tree)
                XMLp.exportTreeViewXML(NewTreeView1, _DataTree.FullName)
                'Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data_" & Path.GetFileNameWithoutExtension(Dateiname_tree) & ".xml")
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                DataSet1.WriteXml(_DataFile.FullName)
            Else
                Save_product_structure_under()
            End If
            Me.Text = "TBM Manager - for Nagel WZM GmbH (c)FM2017"
        Else
            Save_product_structure_under()
        End If
    End Sub

    Private Sub Save_product_structure_under()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Produktstruktur speichern unter|*.xml"
        saveFileDialog1.Title = "Produktstruktur speichern"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dateiname_tree = saveFileDialog1.FileName
            Dim _DataTree As New FileInfo("neu.xml")
            Save_product_structure()
            TBMStructure = True
        End If
    End Sub

    Private Sub Open_product_structure()
        If TBMStructure = False Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Cursor Files|*.xml"
            openFileDialog1.Title = "Bitte eine Produktstruktur auswählen"
            If TBMStructure = True Then Save_product_structure() ' bestehende Produktstruktur abspeichern!
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dateiname_tree = openFileDialog1.FileName
                Dim _DataTree As New FileInfo(Dateiname_tree)
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                If Not _DataFile.Exists Then Return
                NewTreeView1.Nodes.Clear()
                DataSet1.ReadXml(_DataFile.FullName)
                XMLp.importTreeViewXML(NewTreeView1, _DataTree.FullName)
                If NewTreeView1.Nodes.Count > 0 Then
                    InitHMI()
                    TBMStructure = True
                End If
            End If
        Else
            Save_product_structure()
            TBMStructure = False
            DataSet1.Clear()
            Form2.DataSet2.Clear()
            Open_product_structure()
        End If
    End Sub






#End Region

#Region "Vertreterdaten in ComboBox einlesen bzw. editieren"
    Private Sub VertreterlisteBearbeitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VertreterlisteBearbeitenToolStripMenuItem.Click
        VT_edit = True
        Form2.Show()
    End Sub

    Private Sub CBox_Vertreter_Click(sender As Object, e As EventArgs) Handles CBox_Vertreter.Click
        If VT_edit = True Then
            DataSet2.Vertreter.Clear()
            DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
            VT_edit = False
        End If
    End Sub
#End Region

#Region "Texbox Formatierungen erstellen"
    Private Sub MaskedTBox_EK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTBox_EK.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub MaskedTBox_EK_TextChanged(sender As Object, e As EventArgs) Handles MaskedTBox_EK.TextChanged
        If MaskedTBox_EK.Text <> "" Then
            MaskedTBox_EK.Text = String.Format("{0:C2}", CDbl(MaskedTBox_EK.Text)) 'Formatierung mit Währungszeichen
        Else
            MaskedTBox_EK.Text = "0,00 €"
        End If
    End Sub

    Private Sub MaskedTBox_VK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTBox_VK.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub MaskedTBox_VK_TextChanged(sender As Object, e As EventArgs) Handles MaskedTBox_VK.TextChanged
        If MaskedTBox_VK.Text <> "" Then
            MaskedTBox_VK.Text = String.Format("{0:C2}", CDbl(MaskedTBox_VK.Text)) 'Formatierung mit Währungszeichen
        Else
            MaskedTBox_VK.Text = "0,00 €"
        End If
    End Sub

       Private Sub MaskedTBox_Artikelnummer_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTBox_Artikelnummer.MaskInputRejected
        ToolTip1.ToolTipTitle = "falsche Eingabe"
        ToolTip1.Show("nur Zahlen sind zulässig!", MaskedTBox_Artikelnummer, 3000)
    End Sub
#End Region

#Region "NewTreeView1 Icons entsprechend Ihres Zustandes aktualisieren"
    Private Sub TBox_URL_Artikel_KeyUp(sender As Object, e As KeyEventArgs) Handles TBox_URL_Artikel.KeyUp
        If Edit_TBox_URL_Artikel = True Then
            ArtikelBindingSource.EndEdit()
            UpdateTreeIcon()
        End If
    End Sub

    Sub UpdateTreeIcon()
        Dim row As DataSet1.ArtikelRow = Nothing
        row = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
        If row.URL <> "" Then
            If File.Exists(row.URL) And TBox_URL_Artikel.Text <> "" Then
                NewTreeView1.SelectedNode.ImageIndex = 2
                NewTreeView1.SelectedNode.SelectedImageIndex = 2
            Else
                NewTreeView1.SelectedNode.ImageIndex = 3
                NewTreeView1.SelectedNode.SelectedImageIndex = 3
            End If
        Else
            NewTreeView1.SelectedNode.ImageIndex = 1
            NewTreeView1.SelectedNode.SelectedImageIndex = 1
        End If

    End Sub

    Private Sub CheckTBArticle() 'muss nach dem öffnen einer Struktur ausgeführt werden um alle Icons zu aktualisieren
        Dim row As DataSet1.ArtikelRow = Nothing
        For i = 0 To DataSet1.Artikel.Count - 1
            row = DataSet1.Artikel.Rows(i)
            NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(row.ArtikelID, True)(0)
            If row.URL <> "" Then
                If File.Exists(row.URL) And TBox_URL_Artikel.Text <> "" Then
                    NewTreeView1.SelectedNode.ImageIndex = 2
                    NewTreeView1.SelectedNode.SelectedImageIndex = 2
                Else
                    NewTreeView1.SelectedNode.ImageIndex = 3
                    NewTreeView1.SelectedNode.SelectedImageIndex = 3
                End If
            Else
                NewTreeView1.SelectedNode.ImageIndex = 1
                NewTreeView1.SelectedNode.SelectedImageIndex = 1
            End If
        Next
    End Sub

    Private Sub Box_URL_Artikel_lostfocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBox_URL_Artikel.LostFocus
        Edit_TBox_URL_Artikel = False
    End Sub

    Private Sub TBox_URL_Artikel_MouseClick(sender As Object, e As MouseEventArgs) Handles TBox_URL_Artikel.MouseClick
        Edit_TBox_URL_Artikel = True
    End Sub
#End Region

#Region "Knotennamen editieren"
    Private Sub KnotenEditierenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KnotenEditierenToolStripMenuItem.Click
        If Not (mySelectedNode Is Nothing) Then
            NewTreeView1.SelectedNode = mySelectedNode
            NewTreeView1.LabelEdit = True
            If Not mySelectedNode.IsEditing Then
                mySelectedNode.BeginEdit()
            End If
        End If

    End Sub





    Private Sub NewTreeView1_AfterLabelEdit_1(sender As Object, e As NodeLabelEditEventArgs) Handles NewTreeView1.AfterLabelEdit
        If Not (e.Label Is Nothing) Then
            If e.Label.Length > 0 Then
                If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
                    ' Stop editing without canceling the label change.
                    e.Node.EndEdit(False)
                Else
                    ' Cancel the label edit action, inform the user, and
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.ControlChars.Cr & "The invalid characters are '@','.', ',', '!'", "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            Else
                ' Cancel the label edit action, inform the user, and
                ' place the node in edit mode again. 
                e.CancelEdit = True
                MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.ControlChars.Cr & "The label cannot be blank", "Node Label Edit")
                e.Node.BeginEdit()
            End If
        End If
    End Sub



#End Region
    Sub NewNumberOffer()
        Dim SpezRow As DataSet1.SpezOptionenRow = Nothing
        For i = 0 To DataGridView5.Rows.Count - 1
            SpezRow = DataSet1.SpezOptionen.Rows(i) 'OptionsID
            For Each SpezRow In DataSet1.SpezOptionen.Rows
                If DataGridView5.Rows(i).Cells(1).Value = SpezRow.ArtikelID Then
                    SpezRow.SortRow = i + 1
                End If
            Next
        Next
    End Sub


#Region "Einzelne Äste des Baumes komplett ein- oder auschecken und in Angebotstabelle kopieren"
    Private Sub NewTreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles NewTreeView1.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Tag <> "manufacturer" Then
                CheckAllChildNodes(e.Node)
            Else
                MsgBox("Es können nicht gleichzeitig alle Bausteine ausgewählt werden!", vbExclamation)
            End If
        End If
        'NewNumberOffer()
    End Sub

    Private Sub CheckAllChildNodes(treenode As TreeNode)
        Dim TBrow_edit As DataRow = Nothing
        If treenode.Tag = "article" Then
            SeleNodeCheck(treenode)
        Else
            For Each node In treenode.Nodes
                TBrow_edit = DataSet1.Artikel.FindByArtikelID(node.Name)
                If node.checked = False Then
                    node.checked = True
                Else
                    node.checked = False
                End If
                SeleNodeCheck(node)
                If node.Nodes.Count > 0 Then
                    Me.CheckAllChildNodes(node)
                End If
            Next
        End If
    End Sub

    Private Sub SeleNodeCheck(SelNode As TreeNode)
        Dim SpezRow As DataSet1.SpezOptionenRow = Nothing
        Dim InOffer As Boolean = False
        If CB_Angebotsnummer.Text <> "" Then
            SpezRow = DataSet1.SpezOptionen.NewSpezOptionenRow
            If SelNode IsNot Nothing Then
                If SelNode.Checked = True Then
                    'row.AGSelected = "true"
                    'hier neue Artikel im Angebot einfügen
                    SpezRow.Angebotsnummer = CB_Angebotsnummer.Text
                    SpezRow.ArtikelID = SelNode.Name
                    SpezRow.OptionID = CStr(Guid.NewGuid.ToString)
                    SpezRow.SortRow = DataGridView5.Rows.Count + 1
                    'Hier fehlen noch Daten aus der Artikel Tabelle
                    Dim ArtikelRow As DataSet1.ArtikelRow = DataSet1.Artikel.FindByArtikelID(SpezRow.ArtikelID)
                    DataSet1.SpezOptionen.Rows.Add(SpezRow)
                Else
                    If SelNode.Checked = False Then
                        'hier selektierten Artikel aus Angebot entfernen
                        For Each SpezRow In DataSet1.SpezOptionen.Select("ArtikelID = '" & SelNode.Name & "'")
                            If SpezRow.Angebotsnummer = CB_Angebotsnummer.Text Then
                                SpezRow.Delete()
                            End If
                        Next
                    End If
                End If
            End If
            NewNumberOffer()
        End If
    End Sub
#End Region

#Region "Neuen Kunden einfügen oder löschen"
    Private Sub Btn_DelCustomer_Click(sender As Object, e As EventArgs) Handles Btn_DelCustomer.Click
        Dim KRow As DataSet1.KundeRow = Nothing
        KRow = DataSet1.Kunde.FindByKdNummer(CB_Kundennummer.Text)
        Select Case MessageBox.Show("Wollen Sie den Kunden wirklich löschen?", "Kunde löschen", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                KRow.Delete()
            Case DialogResult.No
                MsgBox("Löschen abgebrochen", vbExclamation)
        End Select
        GroupBox3.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
    End Sub

    Private Sub Btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles Btn_AddCustomer.Click
        Try
            Dim prompt As String = String.Empty
            Dim title As String = String.Empty
            Dim defaultResponse As String = String.Empty
            Dim answer As Object
            prompt = "Kundennummer: "
            title = "Neue Kundennummer eingeben"
            defaultResponse = "xx-xxxxx"
            answer = InputBox(prompt, title, defaultResponse)
            CB_Kundennummer.Text = answer
            If answer IsNot "" Then
                Dim NewKRow As DataSet1.KundeRow = Nothing
                NewKRow = DataSet1.Kunde.NewKundeRow
                NewKRow.KundenID = "KdID_" & Guid.NewGuid.ToString
                NewKRow.KdNummer = answer
                NewKRow.Firma1 = TBox_Firma1.Text
                NewKRow.Firma2 = TBox_Firma2.Text
                NewKRow.Name1 = TBox_Name1.Text
                NewKRow.Name2 = TBox_Name2.Text
                NewKRow.Strasse = TBox_Strasse.Text
                NewKRow.PLZ = TB_PLZ.Text
                NewKRow.Ort = TB_Ort.Text
                DataSet1.Kunde.Rows.Add(NewKRow)
            End If
            GroupBox3.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Catch ex As Exception
            MsgBox("Diese Kundennummer ist bereits vorhanden!", vbExclamation)
        End Try
    End Sub
#End Region

#Region "Neues Angebot einfügen;löschen fehlt noch"
    Private Sub Btn_AddOffer_Click(sender As Object, e As EventArgs) Handles Btn_AddOffer.Click
        Try
            Dim prompt As String = String.Empty
            Dim title As String = String.Empty
            Dim defaultResponse As String = String.Empty
            Dim answer As Object
            prompt = "Angebotsnummer: "
            title = "Neue Angebotsnummer eingeben"
            defaultResponse = "wmXXX-XX"
            answer = InputBox(prompt, title, defaultResponse)
            If answer IsNot "" Then
                Dim NewAGRow As DataSet1.AngebotRow = Nothing
                NewAGRow = DataSet1.Angebot.NewAngebotRow
                NewAGRow.Angebotsnummer = answer
                NewAGRow.Kundennummer = CB_Kundennummer.Text
                NewAGRow.AngebotURL = "noch nicht definiert"
                DataSet1.Angebot.Rows.Add(NewAGRow)
            End If
        Catch ex As Exception
            MsgBox("Diese Angebotsnummer ist bereits vorhanden!", vbExclamation)
        End Try
    End Sub
#End Region

#Region "Treeview entsprechend ausgewähltem Angebot aktualisieren"
    Private Sub TraverseChildNodes(nodes As TreeNodeCollection)
        For Each nd As TreeNode In nodes
            nd.Checked = False
            TraverseChildNodes(nd.Nodes)
        Next
    End Sub

    Private Sub CB_Angebotsnummer_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Angebotsnummer.SelectedValueChanged
        TreeView_actualize()
    End Sub

    Private Sub CB_Kundennummer_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Kundennummer.SelectedValueChanged
        TreeView_actualize()
    End Sub

    Sub TreeView_actualize()
        Dim SpezRow As DataSet1.SpezOptionenRow = Nothing
        TraverseChildNodes(NewTreeView1.Nodes)
        For i = 0 To DataSet1.SpezOptionen.Rows.Count - 1
            SpezRow = DataSet1.SpezOptionen.Rows(i)
            If CB_Angebotsnummer.Text = SpezRow.Angebotsnummer Then
                Dim Nodes As TreeNode() = Nothing
                Nodes = NewTreeView1.Nodes.Find(SpezRow.ArtikelID, True)
                For Each node As TreeNode In Nodes
                    node.Checked = True
                Next
            End If
        Next
    End Sub
#End Region

#Region "Word Textmarken Verknüpfungen erstellen/ändern"
    Private Sub TextmarkenDefinierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextmarkenDefinierenToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub BTN_up_Click(sender As Object, e As EventArgs) Handles BTN_up.Click
        Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        Dim Idx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position).row
        DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DataGridView5.CurrentRow.Index > 0 Then
            Dim DRx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position - 1).row
            Dim Index_DRx As Integer
            Dim Index_Idx As Integer
            If Idx.SortRow = DRx.SortRow Then
                If DRx.SortRow > 1 Then
                    DRx.SortRow = DRx.SortRow - 1
                End If
            End If
            Index_DRx = DRx.SortRow
            Index_Idx = Idx.SortRow
            DRx.SortRow = Index_Idx
            Idx.SortRow = Index_DRx
        End If
    End Sub

    Private Sub BTN_down_Click(sender As Object, e As EventArgs) Handles BTN_down.Click
        Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        Dim Idx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position).row
        DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DataGridView5.CurrentRow.Index < DataGridView5.Rows.Count - 1 Then
            Dim DRx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position + 1).row
            Dim Index_DRx As Integer
            Dim Index_Idx As Integer
            If Idx.SortRow = DRx.SortRow Then
                If DRx.SortRow > 1 Then
                    DRx.SortRow = DRx.SortRow + 1
                End If
            End If
            Index_DRx = DRx.SortRow
            Index_Idx = Idx.SortRow
            DRx.SortRow = Index_Idx
            Idx.SortRow = Index_DRx
        End If
    End Sub





#End Region

End Class
