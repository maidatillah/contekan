<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLpetugas
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
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PetugasTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.PetugasTableAdapter()
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PetugasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_pengaduan.rptpetugas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(22, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 258)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_pengaduanDataSet
        '
        Me.db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "Petugas"
        Me.PetugasBindingSource.DataSource = Me.db_pengaduanDataSet
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'frmLpetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 305)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLpetugas"
        Me.Text = "frmLpetugas"
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PetugasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents PetugasTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.PetugasTableAdapter
End Class
