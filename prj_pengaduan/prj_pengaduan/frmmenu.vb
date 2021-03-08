Public Class frmmenu

    Private Sub btnmasyarakat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmasyarakat.Click
        frmmasyarakat.Show()
    End Sub

    Private Sub btnpetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpetugas.Click
        frmpetugas.Show()
    End Sub

    Private Sub btnpengaduan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpengaduan.Click
        frmpengaduan.Show()
    End Sub

    Private Sub btntanggapan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntanggapan.Click
        frmtanggapan.Show()
    End Sub

    Private Sub btnLmasyarakat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLmasyarakat.Click
        frmLmasyarakat.Show()
    End Sub

    Private Sub btnLpetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLpetugas.Click
        frmLpetugas.Show()
    End Sub

    Private Sub btnLpengaduan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLpengaduan.Click
        frmLpengaduan.Show()
    End Sub

    Private Sub btnLtanggapan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLtanggapan.Click
        frmLtanggapan.Show()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If MsgBox("Apakah Anda Ingin Keluar??", vbYesNo + vbQuestion, "Peringatan") = vbYes Then
            End
        End If
    End Sub
End Class