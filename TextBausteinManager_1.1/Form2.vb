Imports System
Imports System.IO

Public Class Form2
    Dim VT_DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataSet2.Vertreter.Rows.Count = 0 Then
            DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
        End If
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        DataSet2.Vertreter.WriteXml(VT_DataFile.FullName)
    End Sub

    Private Sub Showed_name_change()
        GroupBox1.Text = TextBox2.Text & " " & TextBox3.Text & " " & TextBox4.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Showed_name_change()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Showed_name_change()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Showed_name_change()
    End Sub
End Class