Public Class frmmasyarakat

    Private Sub MasyarakatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasyarakatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MasyarakatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_pengaduanDataSet)

    End Sub

    Private Sub frmmasyarakat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_pengaduanDataSet.Masyarakat' table. You can move, or remove it, as needed.
        Me.MasyarakatTableAdapter.Fill(Me.Db_pengaduanDataSet.Masyarakat)

    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        Me.MasyarakatBindingSource.Filter = "NIK LIKE '" & TextBox1.Text & "%'"
    End Sub

    Private Sub btbrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbrefresh.Click
        Me.MasyarakatDataGridView.DataSource = Me.Db_pengaduanDataSet.Masyarakat
    End Sub
End Class
