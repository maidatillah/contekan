<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtanggapan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtanggapan))
        Dim Id_TanggapanLabel As System.Windows.Forms.Label
        Dim Id_PengaduanLabel As System.Windows.Forms.Label
        Dim Tgl_PengaduanLabel As System.Windows.Forms.Label
        Dim TanggapanLabel As System.Windows.Forms.Label
        Dim Id_PetugasLabel As System.Windows.Forms.Label
        Me.Db_pengaduanDataSet = New prj_pengaduan.db_pengaduanDataSet()
        Me.TanggapanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TanggapanTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TanggapanTableAdapter()
        Me.TableAdapterManager = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager()
        Me.TanggapanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TanggapanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_TanggapanTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PengaduanTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_PengaduanTextBox = New System.Windows.Forms.TextBox()
        Me.TanggapanTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.TanggapanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_TanggapanLabel = New System.Windows.Forms.Label()
        Id_PengaduanLabel = New System.Windows.Forms.Label()
        Tgl_PengaduanLabel = New System.Windows.Forms.Label()
        TanggapanLabel = New System.Windows.Forms.Label()
        Id_PetugasLabel = New System.Windows.Forms.Label()
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggapanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggapanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TanggapanBindingNavigator.SuspendLayout()
        CType(Me.TanggapanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Db_pengaduanDataSet
        '
        Me.Db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.Db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TanggapanBindingSource
        '
        Me.TanggapanBindingSource.DataMember = "Tanggapan"
        Me.TanggapanBindingSource.DataSource = Me.Db_pengaduanDataSet
        '
        'TanggapanTableAdapter
        '
        Me.TanggapanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasyarakatTableAdapter = Nothing
        Me.TableAdapterManager.PengaduanTableAdapter = Nothing
        Me.TableAdapterManager.PetugasTableAdapter = Nothing
        Me.TableAdapterManager.TanggapanTableAdapter = Me.TanggapanTableAdapter
        Me.TableAdapterManager.UpdateOrder = prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TanggapanBindingNavigator
        '
        Me.TanggapanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TanggapanBindingNavigator.BindingSource = Me.TanggapanBindingSource
        Me.TanggapanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TanggapanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TanggapanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TanggapanBindingNavigatorSaveItem})
        Me.TanggapanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TanggapanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TanggapanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TanggapanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TanggapanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TanggapanBindingNavigator.Name = "TanggapanBindingNavigator"
        Me.TanggapanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TanggapanBindingNavigator.Size = New System.Drawing.Size(830, 25)
        Me.TanggapanBindingNavigator.TabIndex = 0
        Me.TanggapanBindingNavigator.Text = "BindingNavigator1"
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
        'TanggapanBindingNavigatorSaveItem
        '
        Me.TanggapanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TanggapanBindingNavigatorSaveItem.Image = CType(resources.GetObject("TanggapanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TanggapanBindingNavigatorSaveItem.Name = "TanggapanBindingNavigatorSaveItem"
        Me.TanggapanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TanggapanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_TanggapanLabel
        '
        Id_TanggapanLabel.AutoSize = True
        Id_TanggapanLabel.Location = New System.Drawing.Point(15, 38)
        Id_TanggapanLabel.Name = "Id_TanggapanLabel"
        Id_TanggapanLabel.Size = New System.Drawing.Size(77, 13)
        Id_TanggapanLabel.TabIndex = 1
        Id_TanggapanLabel.Text = "Id Tanggapan:"
        '
        'Id_TanggapanTextBox
        '
        Me.Id_TanggapanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TanggapanBindingSource, "Id_Tanggapan", True))
        Me.Id_TanggapanTextBox.Location = New System.Drawing.Point(104, 35)
        Me.Id_TanggapanTextBox.Name = "Id_TanggapanTextBox"
        Me.Id_TanggapanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_TanggapanTextBox.TabIndex = 2
        '
        'Id_PengaduanLabel
        '
        Id_PengaduanLabel.AutoSize = True
        Id_PengaduanLabel.Location = New System.Drawing.Point(15, 64)
        Id_PengaduanLabel.Name = "Id_PengaduanLabel"
        Id_PengaduanLabel.Size = New System.Drawing.Size(77, 13)
        Id_PengaduanLabel.TabIndex = 3
        Id_PengaduanLabel.Text = "Id Pengaduan:"
        '
        'Id_PengaduanTextBox
        '
        Me.Id_PengaduanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TanggapanBindingSource, "Id_Pengaduan", True))
        Me.Id_PengaduanTextBox.Location = New System.Drawing.Point(104, 61)
        Me.Id_PengaduanTextBox.Name = "Id_PengaduanTextBox"
        Me.Id_PengaduanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_PengaduanTextBox.TabIndex = 4
        '
        'Tgl_PengaduanLabel
        '
        Tgl_PengaduanLabel.AutoSize = True
        Tgl_PengaduanLabel.Location = New System.Drawing.Point(15, 90)
        Tgl_PengaduanLabel.Name = "Tgl_PengaduanLabel"
        Tgl_PengaduanLabel.Size = New System.Drawing.Size(83, 13)
        Tgl_PengaduanLabel.TabIndex = 5
        Tgl_PengaduanLabel.Text = "Tgl Pengaduan:"
        '
        'Tgl_PengaduanTextBox
        '
        Me.Tgl_PengaduanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TanggapanBindingSource, "Tgl_Pengaduan", True))
        Me.Tgl_PengaduanTextBox.Location = New System.Drawing.Point(104, 87)
        Me.Tgl_PengaduanTextBox.Name = "Tgl_PengaduanTextBox"
        Me.Tgl_PengaduanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tgl_PengaduanTextBox.TabIndex = 6
        '
        'TanggapanLabel
        '
        TanggapanLabel.AutoSize = True
        TanggapanLabel.Location = New System.Drawing.Point(15, 116)
        TanggapanLabel.Name = "TanggapanLabel"
        TanggapanLabel.Size = New System.Drawing.Size(65, 13)
        TanggapanLabel.TabIndex = 7
        TanggapanLabel.Text = "Tanggapan:"
        '
        'TanggapanTextBox
        '
        Me.TanggapanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TanggapanBindingSource, "Tanggapan", True))
        Me.TanggapanTextBox.Location = New System.Drawing.Point(104, 113)
        Me.TanggapanTextBox.Name = "TanggapanTextBox"
        Me.TanggapanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TanggapanTextBox.TabIndex = 8
        '
        'Id_PetugasLabel
        '
        Id_PetugasLabel.AutoSize = True
        Id_PetugasLabel.Location = New System.Drawing.Point(15, 142)
        Id_PetugasLabel.Name = "Id_PetugasLabel"
        Id_PetugasLabel.Size = New System.Drawing.Size(61, 13)
        Id_PetugasLabel.TabIndex = 9
        Id_PetugasLabel.Text = "Id Petugas:"
        '
        'Id_PetugasTextBox
        '
        Me.Id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TanggapanBindingSource, "Id_Petugas", True))
        Me.Id_PetugasTextBox.Location = New System.Drawing.Point(104, 139)
        Me.Id_PetugasTextBox.Name = "Id_PetugasTextBox"
        Me.Id_PetugasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_PetugasTextBox.TabIndex = 10
        '
        'TanggapanDataGridView
        '
        Me.TanggapanDataGridView.AutoGenerateColumns = False
        Me.TanggapanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TanggapanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TanggapanDataGridView.DataSource = Me.TanggapanBindingSource
        Me.TanggapanDataGridView.Location = New System.Drawing.Point(234, 35)
        Me.TanggapanDataGridView.Name = "TanggapanDataGridView"
        Me.TanggapanDataGridView.Size = New System.Drawing.Size(543, 124)
        Me.TanggapanDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Tanggapan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Tanggapan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Pengaduan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id_Pengaduan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tgl_Pengaduan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tgl_Pengaduan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tanggapan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggapan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Id_Petugas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Id_Petugas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmtanggapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 326)
        Me.Controls.Add(Me.TanggapanDataGridView)
        Me.Controls.Add(Id_TanggapanLabel)
        Me.Controls.Add(Me.Id_TanggapanTextBox)
        Me.Controls.Add(Id_PengaduanLabel)
        Me.Controls.Add(Me.Id_PengaduanTextBox)
        Me.Controls.Add(Tgl_PengaduanLabel)
        Me.Controls.Add(Me.Tgl_PengaduanTextBox)
        Me.Controls.Add(TanggapanLabel)
        Me.Controls.Add(Me.TanggapanTextBox)
        Me.Controls.Add(Id_PetugasLabel)
        Me.Controls.Add(Me.Id_PetugasTextBox)
        Me.Controls.Add(Me.TanggapanBindingNavigator)
        Me.Name = "frmtanggapan"
        Me.Text = "Tanggapan"
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggapanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggapanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TanggapanBindingNavigator.ResumeLayout(False)
        Me.TanggapanBindingNavigator.PerformLayout()
        CType(Me.TanggapanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents TanggapanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TanggapanTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.TanggapanTableAdapter
    Friend WithEvents TableAdapterManager As prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TanggapanBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TanggapanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_TanggapanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_PengaduanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tgl_PengaduanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggapanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggapanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
