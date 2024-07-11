<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtYearPublished = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblYearPublished = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.LibraryDBDataSet = New Library_Management_System.LibraryDBDataSet()
        Me.LibraryDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDBDataSet1 = New Library_Management_System.LibraryDBDataSet1()
        Me.LibraryDBDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.LibraryDBDataSet2 = New Library_Management_System.LibraryDBDataSet2()
        Me.LibraryDBDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New Library_Management_System.LibraryDBDataSet2TableAdapters.BooksTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPublishedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LibraryDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDBDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(34, 55)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(227, 26)
        Me.txtTitle.TabIndex = 0
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(417, 55)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(275, 26)
        Me.txtAuthor.TabIndex = 1
        '
        'txtYearPublished
        '
        Me.txtYearPublished.Location = New System.Drawing.Point(848, 55)
        Me.txtYearPublished.Name = "txtYearPublished"
        Me.txtYearPublished.Size = New System.Drawing.Size(266, 26)
        Me.txtYearPublished.TabIndex = 2
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(1222, 55)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(235, 26)
        Me.txtGenre.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(60, 132)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(279, 59)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(60, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(279, 58)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(60, 292)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(279, 64)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(60, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(279, 60)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(56, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Title"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(502, 9)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(57, 20)
        Me.lblAuthor.TabIndex = 9
        Me.lblAuthor.Text = "Author"
        '
        'lblYearPublished
        '
        Me.lblYearPublished.AutoSize = True
        Me.lblYearPublished.Location = New System.Drawing.Point(953, 9)
        Me.lblYearPublished.Name = "lblYearPublished"
        Me.lblYearPublished.Size = New System.Drawing.Size(116, 20)
        Me.lblYearPublished.TabIndex = 10
        Me.lblYearPublished.Text = "Year Published"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Location = New System.Drawing.Point(1342, 9)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(50, 20)
        Me.lblGenre.TabIndex = 11
        Me.lblGenre.Text = "genre"
        '
        'LibraryDBDataSet
        '
        Me.LibraryDBDataSet.DataSetName = "LibraryDBDataSet"
        Me.LibraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryDBDataSetBindingSource
        '
        Me.LibraryDBDataSetBindingSource.DataSource = Me.LibraryDBDataSet
        Me.LibraryDBDataSetBindingSource.Position = 0
        '
        'LibraryDBDataSet1
        '
        Me.LibraryDBDataSet1.DataSetName = "LibraryDBDataSet1"
        Me.LibraryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryDBDataSet1BindingSource
        '
        Me.LibraryDBDataSet1BindingSource.DataSource = Me.LibraryDBDataSet1
        Me.LibraryDBDataSet1BindingSource.Position = 0
        '
        'dgvBooks
        '
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.YearPublishedDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.dgvBooks.DataSource = Me.BooksBindingSource
        Me.dgvBooks.Location = New System.Drawing.Point(418, 113)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 62
        Me.dgvBooks.RowTemplate.Height = 28
        Me.dgvBooks.Size = New System.Drawing.Size(811, 325)
        Me.dgvBooks.TabIndex = 12
        '
        'LibraryDBDataSet2
        '
        Me.LibraryDBDataSet2.DataSetName = "LibraryDBDataSet2"
        Me.LibraryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryDBDataSet2BindingSource
        '
        Me.LibraryDBDataSet2BindingSource.DataSource = Me.LibraryDBDataSet2
        Me.LibraryDBDataSet2BindingSource.Position = 0
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LibraryDBDataSet2BindingSource
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 150
        '
        'YearPublishedDataGridViewTextBoxColumn
        '
        Me.YearPublishedDataGridViewTextBoxColumn.DataPropertyName = "YearPublished"
        Me.YearPublishedDataGridViewTextBoxColumn.HeaderText = "YearPublished"
        Me.YearPublishedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.YearPublishedDataGridViewTextBoxColumn.Name = "YearPublishedDataGridViewTextBoxColumn"
        Me.YearPublishedDataGridViewTextBoxColumn.Width = 150
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 439)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblYearPublished)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtYearPublished)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Name = "Form1"
        Me.Text = "Library Managment System"
        CType(Me.LibraryDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDBDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDBDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYearPublished As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents LibraryDBDataSetBindingSource As BindingSource
    Friend WithEvents LibraryDBDataSet As LibraryDBDataSet
    Friend WithEvents LibraryDBDataSet1BindingSource As BindingSource
    Friend WithEvents LibraryDBDataSet1 As LibraryDBDataSet1
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents LibraryDBDataSet2BindingSource As BindingSource
    Friend WithEvents LibraryDBDataSet2 As LibraryDBDataSet2
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As LibraryDBDataSet2TableAdapters.BooksTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearPublishedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
