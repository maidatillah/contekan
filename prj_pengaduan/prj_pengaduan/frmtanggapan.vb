Public Class frmtanggapan

    Private Sub TanggapanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TanggapanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TanggapanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_pengaduanDataSet)

    End Sub

    Private Sub frmtanggapan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_pengaduanDataSet.Tanggapan' table. You can move, or remove it, as needed.
        Me.TanggapanTableAdapter.Fill(Me.Db_pengaduanDataSet.Tanggapan)

    End Sub
End Class