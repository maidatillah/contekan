Public Class frmLtanggapan

    Private Sub frmLtanggapan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_pengaduanDataSet.Tanggapan' table. You can move, or remove it, as needed.
        Me.TanggapanTableAdapter.Fill(Me.db_pengaduanDataSet.Tanggapan)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class