<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdvd
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkategori = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtkodedvd = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dvdData = New System.Windows.Forms.DataGridView()
        Me.delete = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataDvdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Update = New System.Windows.Forms.Button()
        CType(Me.dvdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(511, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "200511090"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Abdul Rozak"
        '
        'txtkategori
        '
        Me.txtkategori.Location = New System.Drawing.Point(218, 141)
        Me.txtkategori.Name = "txtkategori"
        Me.txtkategori.Size = New System.Drawing.Size(233, 22)
        Me.txtkategori.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(87, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Kode Dvd"
        '
        'txtkodedvd
        '
        Me.txtkodedvd.Location = New System.Drawing.Point(218, 61)
        Me.txtkodedvd.Name = "txtkodedvd"
        Me.txtkodedvd.Size = New System.Drawing.Size(233, 22)
        Me.txtkodedvd.TabIndex = 64
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(501, 186)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 32)
        Me.btnClear.TabIndex = 63
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dvdData
        '
        Me.dvdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvdData.Location = New System.Drawing.Point(62, 241)
        Me.dvdData.Name = "dvdData"
        Me.dvdData.RowTemplate.Height = 24
        Me.dvdData.Size = New System.Drawing.Size(577, 233)
        Me.dvdData.TabIndex = 62
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(406, 186)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 31)
        Me.delete.TabIndex = 61
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(218, 186)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 31)
        Me.simpan.TabIndex = 60
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(218, 98)
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(233, 22)
        Me.txtjudul.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(87, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(87, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Judul DVD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(213, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 29)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Data DVD"
        '
        'DataDvdToolStripMenuItem
        '
        Me.DataDvdToolStripMenuItem.Name = "DataDvdToolStripMenuItem"
        Me.DataDvdToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.DataDvdToolStripMenuItem.Text = "Data Dvd"
        '
        'DataSewaToolStripMenuItem
        '
        Me.DataSewaToolStripMenuItem.Name = "DataSewaToolStripMenuItem"
        Me.DataSewaToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.DataSewaToolStripMenuItem.Text = "Data Sewa"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDvdToolStripMenuItem, Me.DataSewaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 28)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(311, 186)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 31)
        Me.Update.TabIndex = 70
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Frmdvd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 495)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtkategori)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkodedvd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dvdData)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Frmdvd"
        Me.Text = "Form1"
        CType(Me.dvdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtkodedvd As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents dvdData As DataGridView
    Friend WithEvents delete As Button
    Friend WithEvents simpan As Button
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataDvdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Update As Button
End Class
