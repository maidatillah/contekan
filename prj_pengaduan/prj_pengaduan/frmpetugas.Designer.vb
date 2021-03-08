<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpetugas
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
        Dim Id_PetugasLabel As System.Windows.Forms.Label
        Dim Nama_PetugasLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim TelpLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpetugas))
        Me.Db_pengaduanDataSet = New prj_pengaduan.db_pengaduanDataSet()
        Me.PengaduanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PengaduanTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.PengaduanTableAdapter()
        Me.TableAdapterManager = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager()
        Me.PetugasTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.PetugasTableAdapter()
        Me.PengaduanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PengaduanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_PetugasTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TelpTextBox = New System.Windows.Forms.TextBox()
        Me.LevelTextBox = New System.Windows.Forms.TextBox()
        Me.PetugasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_PetugasLabel = New System.Windows.Forms.Label()
        Nama_PetugasLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        TelpLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PengaduanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PengaduanBindingNavigator.SuspendLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_PetugasLabel
        '
        Id_PetugasLabel.AutoSize = True
        Id_PetugasLabel.Location = New System.Drawing.Point(16, 39)
        Id_PetugasLabel.Name = "Id_PetugasLabel"
        Id_PetugasLabel.Size = New System.Drawing.Size(61, 13)
        Id_PetugasLabel.TabIndex = 1
        Id_PetugasLabel.Text = "Id Petugas:"
        '
        'Nama_PetugasLabel
        '
        Nama_PetugasLabel.AutoSize = True
        Nama_PetugasLabel.Location = New System.Drawing.Point(16, 65)
        Nama_PetugasLabel.Name = "Nama_PetugasLabel"
        Nama_PetugasLabel.Size = New System.Drawing.Size(80, 13)
        Nama_PetugasLabel.TabIndex = 3
        Nama_PetugasLabel.Text = "Nama Petugas:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(16, 91)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(16, 117)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'TelpLabel
        '
        TelpLabel.AutoSize = True
        TelpLabel.Location = New System.Drawing.Point(16, 143)
        TelpLabel.Name = "TelpLabel"
        TelpLabel.Size = New System.Drawing.Size(31, 13)
        TelpLabel.TabIndex = 9
        TelpLabel.Text = "Telp:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(16, 169)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(36, 13)
        LevelLabel.TabIndex = 11
        LevelLabel.Text = "Level:"
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
        Me.TableAdapterManager.PetugasTableAdapter = Me.PetugasTableAdapter
        Me.TableAdapterManager.TanggapanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
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
        Me.PengaduanBindingNavigator.Size = New System.Drawing.Size(825, 25)
        Me.PengaduanBindingNavigator.TabIndex = 0
        Me.PengaduanBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PengaduanBindingNavigatorSaveItem
        '
        Me.PengaduanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PengaduanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PengaduanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PengaduanBindingNavigatorSaveItem.Name = "PengaduanBindingNavigatorSaveItem"
        Me.PengaduanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PengaduanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "Petugas"
        Me.PetugasBindingSource.DataSource = Me.Db_pengaduanDataSet
        '
        'Id_PetugasTextBox
        '
        Me.Id_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Id_Petugas", True))
        Me.Id_PetugasTextBox.Location = New System.Drawing.Point(102, 36)
        Me.Id_PetugasTextBox.Name = "Id_PetugasTextBox"
        Me.Id_PetugasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_PetugasTextBox.TabIndex = 2
        '
        'Nama_PetugasTextBox
        '
        Me.Nama_PetugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Nama_Petugas", True))
        Me.Nama_PetugasTextBox.Location = New System.Drawing.Point(102, 62)
        Me.Nama_PetugasTextBox.Name = "Nama_PetugasTextBox"
        Me.Nama_PetugasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_PetugasTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(102, 88)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(102, 114)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 8
        '
        'TelpTextBox
        '
        Me.TelpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Telp", True))
        Me.TelpTextBox.Location = New System.Drawing.Point(102, 140)
        Me.TelpTextBox.Name = "TelpTextBox"
        Me.TelpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelpTextBox.TabIndex = 10
        '
        'LevelTextBox
        '
        Me.LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PetugasBindingSource, "Level", True))
        Me.LevelTextBox.Location = New System.Drawing.Point(102, 166)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LevelTextBox.TabIndex = 12
        '
        'PetugasDataGridView
        '
        Me.PetugasDataGridView.AutoGenerateColumns = False
        Me.PetugasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PetugasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PetugasDataGridView.DataSource = Me.PetugasBindingSource
        Me.PetugasDataGridView.Location = New System.Drawing.Point(19, 202)
        Me.PetugasDataGridView.Name = "PetugasDataGridView"
        Me.PetugasDataGridView.Size = New System.Drawing.Size(642, 132)
        Me.PetugasDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Petugas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Petugas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama_Petugas"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama_Petugas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Telp"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Level"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'frmpetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 372)
        Me.Controls.Add(Me.PetugasDataGridView)
        Me.Controls.Add(Id_PetugasLabel)
        Me.Controls.Add(Me.Id_PetugasTextBox)
        Me.Controls.Add(Nama_PetugasLabel)
        Me.Controls.Add(Me.Nama_PetugasTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(TelpLabel)
        Me.Controls.Add(Me.TelpTextBox)
        Me.Controls.Add(LevelLabel)
        Me.Controls.Add(Me.LevelTextBox)
        Me.Controls.Add(Me.PengaduanBindingNavigator)
        Me.Name = "frmpetugas"
        Me.Text = "Petugas"
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengaduanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PengaduanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PengaduanBindingNavigator.ResumeLayout(False)
        Me.PengaduanBindingNavigator.PerformLayout()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PetugasTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.PetugasTableAdapter
    Friend WithEvents PetugasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Id_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_PetugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PetugasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
