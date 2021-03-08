<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmasyarakat
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
        Dim NIKLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim TelpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmasyarakat))
        Me.Db_pengaduanDataSet = New prj_pengaduan.db_pengaduanDataSet()
        Me.MasyarakatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasyarakatTableAdapter = New prj_pengaduan.db_pengaduanDataSetTableAdapters.MasyarakatTableAdapter()
        Me.TableAdapterManager = New prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager()
        Me.MasyarakatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MasyarakatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NIKTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TelpTextBox = New System.Windows.Forms.TextBox()
        Me.MasyarakatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btbrefresh = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        NIKLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        TelpLabel = New System.Windows.Forms.Label()
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasyarakatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasyarakatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasyarakatBindingNavigator.SuspendLayout()
        CType(Me.MasyarakatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIKLabel
        '
        NIKLabel.AutoSize = True
        NIKLabel.Location = New System.Drawing.Point(16, 35)
        NIKLabel.Name = "NIKLabel"
        NIKLabel.Size = New System.Drawing.Size(28, 13)
        NIKLabel.TabIndex = 1
        NIKLabel.Text = "NIK:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(16, 61)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(16, 87)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(16, 113)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "Password:"
        '
        'TelpLabel
        '
        TelpLabel.AutoSize = True
        TelpLabel.Location = New System.Drawing.Point(16, 139)
        TelpLabel.Name = "TelpLabel"
        TelpLabel.Size = New System.Drawing.Size(31, 13)
        TelpLabel.TabIndex = 9
        TelpLabel.Text = "Telp:"
        '
        'Db_pengaduanDataSet
        '
        Me.Db_pengaduanDataSet.DataSetName = "db_pengaduanDataSet"
        Me.Db_pengaduanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasyarakatBindingSource
        '
        Me.MasyarakatBindingSource.DataMember = "Masyarakat"
        Me.MasyarakatBindingSource.DataSource = Me.Db_pengaduanDataSet
        '
        'MasyarakatTableAdapter
        '
        Me.MasyarakatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasyarakatTableAdapter = Me.MasyarakatTableAdapter
        Me.TableAdapterManager.PengaduanTableAdapter = Nothing
        Me.TableAdapterManager.PetugasTableAdapter = Nothing
        Me.TableAdapterManager.TanggapanTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MasyarakatBindingNavigator
        '
        Me.MasyarakatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MasyarakatBindingNavigator.BindingSource = Me.MasyarakatBindingSource
        Me.MasyarakatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MasyarakatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MasyarakatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MasyarakatBindingNavigatorSaveItem})
        Me.MasyarakatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MasyarakatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MasyarakatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MasyarakatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MasyarakatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MasyarakatBindingNavigator.Name = "MasyarakatBindingNavigator"
        Me.MasyarakatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MasyarakatBindingNavigator.Size = New System.Drawing.Size(837, 25)
        Me.MasyarakatBindingNavigator.TabIndex = 0
        Me.MasyarakatBindingNavigator.Text = "BindingNavigator1"
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
        'MasyarakatBindingNavigatorSaveItem
        '
        Me.MasyarakatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MasyarakatBindingNavigatorSaveItem.Image = CType(resources.GetObject("MasyarakatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MasyarakatBindingNavigatorSaveItem.Name = "MasyarakatBindingNavigatorSaveItem"
        Me.MasyarakatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MasyarakatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NIKTextBox
        '
        Me.NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasyarakatBindingSource, "NIK", True))
        Me.NIKTextBox.Location = New System.Drawing.Point(80, 32)
        Me.NIKTextBox.Name = "NIKTextBox"
        Me.NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIKTextBox.TabIndex = 2
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasyarakatBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(80, 58)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasyarakatBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(80, 84)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasyarakatBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(80, 110)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 8
        '
        'TelpTextBox
        '
        Me.TelpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MasyarakatBindingSource, "Telp", True))
        Me.TelpTextBox.Location = New System.Drawing.Point(80, 136)
        Me.TelpTextBox.Name = "TelpTextBox"
        Me.TelpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelpTextBox.TabIndex = 10
        '
        'MasyarakatDataGridView
        '
        Me.MasyarakatDataGridView.AutoGenerateColumns = False
        Me.MasyarakatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MasyarakatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MasyarakatDataGridView.DataSource = Me.MasyarakatBindingSource
        Me.MasyarakatDataGridView.Location = New System.Drawing.Point(226, 32)
        Me.MasyarakatDataGridView.Name = "MasyarakatDataGridView"
        Me.MasyarakatDataGridView.Size = New System.Drawing.Size(542, 152)
        Me.MasyarakatDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIK"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIK"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
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
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(12, 183)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 12
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'btbrefresh
        '
        Me.btbrefresh.Location = New System.Drawing.Point(12, 212)
        Me.btbrefresh.Name = "btbrefresh"
        Me.btbrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btbrefresh.TabIndex = 13
        Me.btbrefresh.Text = "Refresh"
        Me.btbrefresh.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'frmmasyarakat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 323)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btbrefresh)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.MasyarakatDataGridView)
        Me.Controls.Add(NIKLabel)
        Me.Controls.Add(Me.NIKTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(TelpLabel)
        Me.Controls.Add(Me.TelpTextBox)
        Me.Controls.Add(Me.MasyarakatBindingNavigator)
        Me.Name = "frmmasyarakat"
        Me.Text = "Masyarakat"
        CType(Me.Db_pengaduanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasyarakatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasyarakatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasyarakatBindingNavigator.ResumeLayout(False)
        Me.MasyarakatBindingNavigator.PerformLayout()
        CType(Me.MasyarakatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_pengaduanDataSet As prj_pengaduan.db_pengaduanDataSet
    Friend WithEvents MasyarakatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasyarakatTableAdapter As prj_pengaduan.db_pengaduanDataSetTableAdapters.MasyarakatTableAdapter
    Friend WithEvents TableAdapterManager As prj_pengaduan.db_pengaduanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasyarakatBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MasyarakatBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MasyarakatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btbrefresh As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
