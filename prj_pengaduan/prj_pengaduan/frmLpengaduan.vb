Public Class frmLpengaduan

    Private Sub frmLpengaduan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_pengaduanDataSet.Pengaduan' table. You can move, or remove it, as needed.
        Me.PengaduanTableAdapter.Fill(Me.db_pengaduanDataSet.Pengaduan)
        'TODO: This line of code loads data into the 'db_pengaduanDataSet.Masyarakat' table. You can move, or remove it, as needed.
        Me.MasyarakatTableAdapter.Fill(Me.db_pengaduanDataSet.Masyarakat)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class