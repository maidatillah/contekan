<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpengaduan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpengaduan))
        Dim Id_PengaduanLabel As System.Windows.Forms.Label
        Dim Tgl_PengaduanLabel As System.Windows.Forms.Label
        Dim NIKLabel As System.Windows.Forms.Label
        Dim Isi_LaporanLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.Db_pengaduanDataSet = New prj_pengaduan.db_pengaduanDataSet()
        Me.PengaduanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengaduanTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.PengaduanTableAdapter()
        Me.TableAdapterManager = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager()
        Me.PengaduanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PengaduanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_PengaduanTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_PengaduanTextBox = New System.Windows.Forms.TextBox()
        Me.NIKTextBox = New System.Windows.Forms.TextBox()
        Me.Isi_LaporanTextBox = New System.Windows.Forms.TextBox()
        Me.FotoTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PengaduanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_PengaduanLabel = New System.Windows.Forms.Label()
        Tgl_PengaduanLabel = New System.Windows.Forms.Label()
        NIKLabel = New System.Windows.Forms.Label()
        Isi_LaporanLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengaduanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PengaduanBindingNavigator.SuspendLayout()
        CType(Me.PengaduanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_pengaduanDataSet
        '
        Me.Db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.Db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PengaduanBindingSource
        '
        Me.PengaduanBindingSource.DataMember = "Pengaduan"
        Me.PengaduanBindingSource.DataSource = Me.Db_pengaduanDataSet
        '
        'PengaduanTableAdapter
        '
        Me.PengaduanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasyarakatTableAdapter = Nothing
        Me.TableAdapterManager.PengaduanTableAdapter = Me.PengaduanTableAdapter
        Me.TableAdapterManager.PetugasTableAdapter = Nothing
        Me.TableAdapterManager.TanggapanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PengaduanBindingNavigator
        '
        Me.PengaduanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PengaduanBindingNavigator.BindingSource = Me.PengaduanBindingSource
        Me.PengaduanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PengaduanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PengaduanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PengaduanBindingNavigatorSaveItem})
        Me.PengaduanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PengaduanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PengaduanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PengaduanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PengaduanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PengaduanBindingNavigator.Name = "PengaduanBindingNavigator"
        Me.PengaduanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PengaduanBindingNavigator.Size = New System.Drawing.Size(846, 25)
        Me.PengaduanBindingNavigator.TabIndex = 0
        Me.PengaduanBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PengaduanBindingNavigatorSaveItem
        '
        Me.PengaduanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PengaduanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PengaduanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PengaduanBindingNavigatorSaveItem.Name = "PengaduanBindingNavigatorSaveItem"
        Me.PengaduanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PengaduanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_PengaduanLabel
        '
        Id_PengaduanLabel.AutoSize = True
        Id_PengaduanLabel.Location = New System.Drawing.Point(13, 35)
        Id_PengaduanLabel.Name = "Id_PengaduanLabel"
        Id_PengaduanLabel.Size = New System.Drawing.Size(77, 13)
        Id_PengaduanLabel.TabIndex = 1
        Id_PengaduanLabel.Text = "Id Pengaduan:"
        '
        'Id_PengaduanTextBox
        '
        Me.Id_PengaduanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "Id_Pengaduan", True))
        Me.Id_PengaduanTextBox.Location = New System.Drawing.Point(102, 32)
        Me.Id_PengaduanTextBox.Name = "Id_PengaduanTextBox"
        Me.Id_PengaduanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_PengaduanTextBox.TabIndex = 2
        '
        'Tgl_PengaduanLabel
        '
        Tgl_PengaduanLabel.AutoSize = True
        Tgl_PengaduanLabel.Location = New System.Drawing.Point(13, 61)
        Tgl_PengaduanLabel.Name = "Tgl_PengaduanLabel"
        Tgl_PengaduanLabel.Size = New System.Drawing.Size(83, 13)
        Tgl_PengaduanLabel.TabIndex = 3
        Tgl_PengaduanLabel.Text = "Tgl Pengaduan:"
        '
        'Tgl_PengaduanTextBox
        '
        Me.Tgl_PengaduanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "Tgl_Pengaduan", True))
        Me.Tgl_PengaduanTextBox.Location = New System.Drawing.Point(102, 58)
        Me.Tgl_PengaduanTextBox.Name = "Tgl_PengaduanTextBox"
        Me.Tgl_PengaduanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tgl_PengaduanTextBox.TabIndex = 4
        '
        'NIKLabel
        '
        NIKLabel.AutoSize = True
        NIKLabel.Location = New System.Drawing.Point(13, 87)
        NIKLabel.Name = "NIKLabel"
        NIKLabel.Size = New System.Drawing.Size(28, 13)
        NIKLabel.TabIndex = 5
        NIKLabel.Text = "NIK:"
        '
        'NIKTextBox
        '
        Me.NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "NIK", True))
        Me.NIKTextBox.Location = New System.Drawing.Point(102, 84)
        Me.NIKTextBox.Name = "NIKTextBox"
        Me.NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIKTextBox.TabIndex = 6
        '
        'Isi_LaporanLabel
        '
        Isi_LaporanLabel.AutoSize = True
        Isi_LaporanLabel.Location = New System.Drawing.Point(13, 113)
        Isi_LaporanLabel.Name = "Isi_LaporanLabel"
        Isi_LaporanLabel.Size = New System.Drawing.Size(62, 13)
        Isi_LaporanLabel.TabIndex = 7
        Isi_LaporanLabel.Text = "Isi Laporan:"
        '
        'Isi_LaporanTextBox
        '
        Me.Isi_LaporanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "Isi_Laporan", True))
        Me.Isi_LaporanTextBox.Location = New System.Drawing.Point(102, 110)
        Me.Isi_LaporanTextBox.Name = "Isi_LaporanTextBox"
        Me.Isi_LaporanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Isi_LaporanTextBox.TabIndex = 8
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(13, 139)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(31, 13)
        FotoLabel.TabIndex = 9
        FotoLabel.Text = "Foto:"
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(102, 136)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FotoTextBox.TabIndex = 10
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(13, 165)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PengaduanBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(102, 162)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 12
        '
        'PengaduanDataGridView
        '
        Me.PengaduanDataGridView.AutoGenerateColumns = False
        Me.PengaduanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PengaduanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PengaduanDataGridView.DataSource = Me.PengaduanBindingSource
        Me.PengaduanDataGridView.Location = New System.Drawing.Point(16, 205)
        Me.PengaduanDataGridView.Name = "PengaduanDataGridView"
        Me.PengaduanDataGridView.Size = New System.Drawing.Size(642, 146)
        Me.PengaduanDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Pengaduan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Pengaduan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tgl_Pengaduan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tgl_Pengaduan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NIK"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NIK"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Isi_Laporan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Isi_Laporan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Foto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Foto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'frmpengaduan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 363)
        Me.Controls.Add(Me.PengaduanDataGridView)
        Me.Controls.Add(Id_PengaduanLabel)
        Me.Controls.Add(Me.Id_PengaduanTextBox)
        Me.Controls.Add(Tgl_PengaduanLabel)
        Me.Controls.Add(Me.Tgl_PengaduanTextBox)
        Me.Controls.Add(NIKLabel)
        Me.Controls.Add(Me.NIKTextBox)
        Me.Controls.Add(Isi_LaporanLabel)
        Me.Controls.Add(Me.Isi_LaporanTextBox)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.PengaduanBindingNavigator)
        Me.Name = "frmpengaduan"
        Me.Text = "Pengaduan"
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengaduanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PengaduanBindingNavigator.ResumeLayout(False)
        Me.PengaduanBindingNavigator.PerformLayout()
        CType(Me.PengaduanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents PengaduanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PengaduanTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.PengaduanTableAdapter
    Friend WithEvents TableAdapterManager As prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PengaduanBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PengaduanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_PengaduanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tgl_PengaduanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Isi_LaporanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PengaduanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
