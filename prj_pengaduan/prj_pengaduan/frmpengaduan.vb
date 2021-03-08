Public Class frmpengaduan

    Private Sub PengaduanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengaduanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PengaduanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_pengaduanDataSet)

    End Sub

    Private Sub frmpengaduan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_pengaduanDataSet.Pengaduan' table. You can move, or remove it, as needed.
        Me.PengaduanTableAdapter.Fill(Me.Db_pengaduanDataSet.Pengaduan)

    End Sub
End Class