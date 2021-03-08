Public Class frmLpetugas

    Private Sub frmLpetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_pengaduanDataSet.Petugas' table. You can move, or remove it, as needed.
        Me.PetugasTableAdapter.Fill(Me.db_pengaduanDataSet.Petugas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class