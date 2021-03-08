<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLpengaduan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_pengaduanDataSet = New prj_pengaduan.db_pengaduanDataSet()
        Me.MasyarakatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasyarakatTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.MasyarakatTableAdapter()
        Me.PengaduanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengaduanTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.PengaduanTableAdapter()
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasyarakatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PengaduanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_pengaduan.rptpengaduan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(651, 267)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_pengaduanDataSet
        '
        Me.db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasyarakatBindingSource
        '
        Me.MasyarakatBindingSource.DataMember = "Masyarakat"
        Me.MasyarakatBindingSource.DataSource = Me.db_pengaduanDataSet
        '
        'MasyarakatTableAdapter
        '
        Me.MasyarakatTableAdapter.ClearBeforeFill = True
        '
        'PengaduanBindingSource
        '
        Me.PengaduanBindingSource.DataMember = "Pengaduan"
        Me.PengaduanBindingSource.DataSource = Me.db_pengaduanDataSet
        '
        'PengaduanTableAdapter
        '
        Me.PengaduanTableAdapter.ClearBeforeFill = True
        '
        'frmLpengaduan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 301)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLpengaduan"
        Me.Text = "frmLpengaduan"
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasyarakatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MasyarakatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents MasyarakatTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.MasyarakatTableAdapter
    Friend WithEvents PengaduanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PengaduanTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.PengaduanTableAdapter
End Class
