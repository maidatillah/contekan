﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLtanggapan
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
        Me.TanggapanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TanggapanTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TanggapanTableAdapter()
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggapanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TanggapanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prj_pengaduan.rpttanggapan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_pengaduanDataSet
        '
        Me.db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TanggapanBindingSource
        '
        Me.TanggapanBindingSource.DataMember = "Tanggapan"
        Me.TanggapanBindingSource.DataSource = Me.db_pengaduanDataSet
        '
        'TanggapanTableAdapter
        '
        Me.TanggapanTableAdapter.ClearBeforeFill = True
        '
        'frmLtanggapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 274)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmLtanggapan"
        Me.Text = "frmLtanggapan"
        CType(Me.db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggapanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TanggapanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents TanggapanTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.TanggapanTableAdapter
End Class
