<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmasyarakat = New System.Windows.Forms.Button()
        Me.btnpetugas = New System.Windows.Forms.Button()
        Me.btnpengaduan = New System.Windows.Forms.Button()
        Me.btntanggapan = New System.Windows.Forms.Button()
        Me.btnLmasyarakat = New System.Windows.Forms.Button()
        Me.btnLpetugas = New System.Windows.Forms.Button()
        Me.btnLpengaduan = New System.Windows.Forms.Button()
        Me.btnLtanggapan = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Laporan"
        '
        'btnmasyarakat
        '
        Me.btnmasyarakat.Location = New System.Drawing.Point(29, 69)
        Me.btnmasyarakat.Name = "btnmasyarakat"
        Me.btnmasyarakat.Size = New System.Drawing.Size(75, 23)
        Me.btnmasyarakat.TabIndex = 2
        Me.btnmasyarakat.Text = "Masyrakat"
        Me.btnmasyarakat.UseVisualStyleBackColor = True
        '
        'btnpetugas
        '
        Me.btnpetugas.Location = New System.Drawing.Point(29, 98)
        Me.btnpetugas.Name = "btnpetugas"
        Me.btnpetugas.Size = New System.Drawing.Size(75, 23)
        Me.btnpetugas.TabIndex = 3
        Me.btnpetugas.Text = "Petugas"
        Me.btnpetugas.UseVisualStyleBackColor = True
        '
        'btnpengaduan
        '
        Me.btnpengaduan.Location = New System.Drawing.Point(29, 127)
        Me.btnpengaduan.Name = "btnpengaduan"
        Me.btnpengaduan.Size = New System.Drawing.Size(75, 23)
        Me.btnpengaduan.TabIndex = 4
        Me.btnpengaduan.Text = "Pengaduan"
        Me.btnpengaduan.UseVisualStyleBackColor = True
        '
        'btntanggapan
        '
        Me.btntanggapan.Location = New System.Drawing.Point(29, 156)
        Me.btntanggapan.Name = "btntanggapan"
        Me.btntanggapan.Size = New System.Drawing.Size(75, 23)
        Me.btntanggapan.TabIndex = 5
        Me.btntanggapan.Text = "Tanggapan"
        Me.btntanggapan.UseVisualStyleBackColor = True
        '
        'btnLmasyarakat
        '
        Me.btnLmasyarakat.Location = New System.Drawing.Point(178, 69)
        Me.btnLmasyarakat.Name = "btnLmasyarakat"
        Me.btnLmasyarakat.Size = New System.Drawing.Size(75, 23)
        Me.btnLmasyarakat.TabIndex = 6
        Me.btnLmasyarakat.Text = "Masyarakat"
        Me.btnLmasyarakat.UseVisualStyleBackColor = True
        '
        'btnLpetugas
        '
        Me.btnLpetugas.Location = New System.Drawing.Point(178, 98)
        Me.btnLpetugas.Name = "btnLpetugas"
        Me.btnLpetugas.Size = New System.Drawing.Size(75, 23)
        Me.btnLpetugas.TabIndex = 7
        Me.btnLpetugas.Text = "Petugas"
        Me.btnLpetugas.UseVisualStyleBackColor = True
        '
        'btnLpengaduan
        '
        Me.btnLpengaduan.Location = New System.Drawing.Point(178, 127)
        Me.btnLpengaduan.Name = "btnLpengaduan"
        Me.btnLpengaduan.Size = New System.Drawing.Size(75, 23)
        Me.btnLpengaduan.TabIndex = 8
        Me.btnLpengaduan.Text = "Pengaduan"
        Me.btnLpengaduan.UseVisualStyleBackColor = True
        '
        'btnLtanggapan
        '
        Me.btnLtanggapan.Location = New System.Drawing.Point(178, 156)
        Me.btnLtanggapan.Name = "btnLtanggapan"
        Me.btnLtanggapan.Size = New System.Drawing.Size(75, 23)
        Me.btnLtanggapan.TabIndex = 9
        Me.btnLtanggapan.Text = "Tanggapan"
        Me.btnLtanggapan.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(105, 204)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 10
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnLtanggapan)
        Me.Controls.Add(Me.btnLpengaduan)
        Me.Controls.Add(Me.btnLpetugas)
        Me.Controls.Add(Me.btnLmasyarakat)
        Me.Controls.Add(Me.btntanggapan)
        Me.Controls.Add(Me.btnpengaduan)
        Me.Controls.Add(Me.btnpetugas)
        Me.Controls.Add(Me.btnmasyarakat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmenu"
        Me.Text = "MENU UTAMA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnmasyarakat As System.Windows.Forms.Button
    Friend WithEvents btnpetugas As System.Windows.Forms.Button
    Friend WithEvents btnpengaduan As System.Windows.Forms.Button
    Friend WithEvents btntanggapan As System.Windows.Forms.Button
    Friend WithEvents btnLmasyarakat As System.Windows.Forms.Button
    Friend WithEvents btnLpetugas As System.Windows.Forms.Button
    Friend WithEvents btnLpengaduan As System.Windows.Forms.Button
    Friend WithEvents btnLtanggapan As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
End Class
