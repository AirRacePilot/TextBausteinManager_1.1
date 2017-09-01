Imports System.IO
Imports System.Xml

Public Class XML_Offer_read_write
    Dim root As XmlNode = Nothing
    Dim node As XmlNode = Nothing
    Dim num As Integer = 0

#Region "XML-Datei Angebotskonfiguration speichern"
    Public Sub Save_offer_xml(ByVal sDataFile As String)
        If Form1.NewTreeView1.Nodes IsNot Nothing Then
            Form1.Cursor = Cursors.WaitCursor
            Dim xmlDoc As New XmlDocument()
            root = xmlDoc.CreateElement(XMLText(Form1.NewTreeView1.Nodes(0).Text)) 'Hier muss der gleich Name wie im Treeview root Knoten stehen!
            xmlDoc.AppendChild(root)
            node = xmlDoc.CreateElement("Firmenadresse")
            root.AppendChild(node)
            ' node.AppendChild(xmlDoc.CreateElement("Firma")).InnerText = XMLText(Form1.TextBox21.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Firma_Zusatz")).InnerText = XMLText(Form1.TextBox22.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Ansprechpartner1")).InnerText = XMLText(Form1.TextBox23.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Ansprechpartner2")).InnerText = XMLText(Form1.TextBox24.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Strasse")).InnerText = XMLText(Form1.TextBox25.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("PLZ")).InnerText = XMLText(Form1.TextBox26.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Ort")).InnerText = XMLText(Form1.TextBox27.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Angebotstitel")).InnerText = XMLText(Form1.TextBox28.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Angebotsnummer")).InnerText = XMLText(Form1.TextBox29.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Dokumentenvorlage")).InnerText = XMLText(Form1.ComboBox5.Text.ToString)
            'node.AppendChild(xmlDoc.CreateElement("Vertreter")).InnerText = XMLText(Form1.ComboBox6.Text.ToString)
            TV1_TraverseCollectionOut(Form1.NewTreeView1.Nodes, xmlDoc)
            xmlDoc.Save(sDataFile)
            'Form1.ToolStripStatusLabel_offerFile.Text = sDataFile
            num = 0
            Form1.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TV1_TraverseCollectionOut(nodes As TreeNodeCollection, xmldoc As XmlDocument)
        Dim node As XmlNode = Nothing
        For Each nd As TreeNode In nodes
            If nd.Checked = True Then
                node = xmldoc.CreateElement("Textbausteine")
                root.AppendChild(node)
                node.AppendChild(xmldoc.CreateElement("Product_ID_" & CStr(num))).InnerText = XMLText(nd.Name)
                node.AppendChild(xmldoc.CreateElement("Articel_ID_" & CStr(num))).InnerText = XMLText(nd.Tag)
                node.AppendChild(xmldoc.CreateElement("AG_selected_" & CStr(num))).InnerText = 1
                num = num + 1
            End If
            TV1_TraverseCollectionOut(nd.Nodes, xmldoc)
        Next
    End Sub

    Function XMLText(Text As String) As String
        XMLText = Replace(Text, " ", "xx_leer_xx")
        XMLText = Replace(Text, "#", "xx_Nummer_xx")
    End Function
#End Region

#Region "XML-Datei Angebotskonfiguration öffnen"
    Public Sub Load_offer_xml(ByVal SDataFile As String)
        'If Form1.TBMStructure = False Then
        'MsgBox("Es ist keine Produktstruktur geladen!", vbExclamation)
        'Else
        Form1.NewTreeView1.CollapseAll()
        'Form1.Uncheckall(Form1.NewTreeView1.Nodes)
        'Form1.UncheckDataSet1()
        Dim xmlDoc As New XmlDocument()
        Dim num As Integer = 0
        Dim Treeview_root_node As String = ""
        xmlDoc.Load(SDataFile)
        root = xmlDoc.DocumentElement
        'Form1.TextBox21.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Firma").InnerText
        'Form1.TextBox22.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Firma_Zusatz").InnerText
        'Form1.TextBox23.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Ansprechpartner1").InnerText
        'Form1.TextBox24.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Ansprechpartner2").InnerText
        'Form1.TextBox25.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Strasse").InnerText
        'Form1.TextBox26.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/PLZ").InnerText
        'Form1.TextBox27.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Ort").InnerText
        'Form1.TextBox28.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Angebotstitel").InnerText
        'Form1.TextBox29.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Angebotsnummer").InnerText
        'Form1.ComboBox5.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Dokumentenvorlage").InnerText
        'Form1.ComboBox6.Text = xmlDoc.SelectSingleNode("/" & root.Name & "/Firmenadresse/Vertreter").InnerText
        Dim node As XmlNode = Nothing
        Dim DocTag As String
        For Each node In xmlDoc.SelectNodes("/" & root.Name & "/Textbausteine") 'Angebot einlesen
            DocTag = xmlDoc.SelectSingleNode("/" & root.Name & "/Textbausteine/TB_Tag_" & CStr(num)).InnerText
            Dim Nodes As TreeNode() = Form1.NewTreeView1.Nodes.Find(xmlDoc.SelectSingleNode("/" & root.Name & "/Textbausteine/TB_Index_" & CStr(num)).InnerText, True)
            Dim node_find As TreeNode = Nothing
            For Each node_find In Nodes
                If node_find.Name <> "Produktknoten" Then
                    If DocTag = node_find.Tag Then
                        'node_find.Checked = True
                        Form1.NewTreeView1.SelectedNode = node_find
                        Form1.NewTreeView1.SelectedNode.Checked = True
                    End If
                End If
            Next
            num = num + 1
        Next
        'Form1.TBMOffer = True
        'Form1.ToolStripStatusLabel_offerFile.Text = SDataFile
        'End If
    End Sub
#End Region




End Class
