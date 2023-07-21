<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsewa
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
        Me.dvdData = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjuduldvd = New System.Windows.Forms.TextBox()
        Me.txtkodedvd = New System.Windows.Forms.TextBox()
        Me.txtkodesewa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.sewaData = New System.Windows.Forms.DataGridView()
        Me.tglkembali = New System.Windows.Forms.TextBox()
        Me.tglsewa = New System.Windows.Forms.TextBox()
        Me.txtpenyewa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataSewaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDvdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.Button()
        CType(Me.dvdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sewaData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvdData
        '
        Me.dvdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvdData.Location = New System.Drawing.Point(667, 62)
        Me.dvdData.Name = "dvdData"
        Me.dvdData.RowTemplate.Height = 24
        Me.dvdData.Size = New System.Drawing.Size(412, 233)
        Me.dvdData.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(999, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "200511090"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(910, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Abdul Rozak"
        '
        'txtjuduldvd
        '
        Me.txtjuduldvd.Location = New System.Drawing.Point(389, 108)
        Me.txtjuduldvd.Name = "txtjuduldvd"
        Me.txtjuduldvd.Size = New System.Drawing.Size(161, 22)
        Me.txtjuduldvd.TabIndex = 95
        '
        'txtkodedvd
        '
        Me.txtkodedvd.Location = New System.Drawing.Point(261, 108)
        Me.txtkodedvd.Name = "txtkodedvd"
        Me.txtkodedvd.Size = New System.Drawing.Size(122, 22)
        Me.txtkodedvd.TabIndex = 94
        '
        'txtkodesewa
        '
        Me.txtkodesewa.Location = New System.Drawing.Point(261, 78)
        Me.txtkodesewa.Name = "txtkodesewa"
        Me.txtkodesewa.Size = New System.Drawing.Size(233, 22)
        Me.txtkodesewa.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(116, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Kode Sewa"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(473, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 32)
        Me.btnClear.TabIndex = 91
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'sewaData
        '
        Me.sewaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sewaData.Location = New System.Drawing.Point(78, 395)
        Me.sewaData.Name = "sewaData"
        Me.sewaData.RowTemplate.Height = 24
        Me.sewaData.Size = New System.Drawing.Size(1036, 242)
        Me.sewaData.TabIndex = 90
        '
        'tglkembali
        '
        Me.tglkembali.Location = New System.Drawing.Point(261, 181)
        Me.tglkembali.Name = "tglkembali"
        Me.tglkembali.Size = New System.Drawing.Size(233, 22)
        Me.tglkembali.TabIndex = 89
        '
        'tglsewa
        '
        Me.tglsewa.Location = New System.Drawing.Point(261, 145)
        Me.tglsewa.Name = "tglsewa"
        Me.tglsewa.Size = New System.Drawing.Size(233, 22)
        Me.tglsewa.TabIndex = 88
        '
        'txtpenyewa
        '
        Me.txtpenyewa.Location = New System.Drawing.Point(261, 262)
        Me.txtpenyewa.Name = "txtpenyewa"
        Me.txtpenyewa.Size = New System.Drawing.Size(233, 22)
        Me.txtpenyewa.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(116, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Nama Penyewa"
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(261, 221)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(233, 22)
        Me.txtharga.TabIndex = 85
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.label.Location = New System.Drawing.Point(116, 223)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(55, 20)
        Me.label.TabIndex = 84
        Me.label.Text = "Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(349, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Sewa DVD"
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(374, 302)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(75, 29)
        Me.delete.TabIndex = 82
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(191, 302)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 29)
        Me.simpan.TabIndex = 81
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(116, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Tanggal Kembali"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(116, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Tanggal sewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(116, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Kode DVD"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSewaToolStripMenuItem, Me.DataDvdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 28)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataSewaToolStripMenuItem
        '
        Me.DataSewaToolStripMenuItem.Name = "DataSewaToolStripMenuItem"
        Me.DataSewaToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.DataSewaToolStripMenuItem.Text = "Data sewa"
        '
        'DataDvdToolStripMenuItem
        '
        Me.DataDvdToolStripMenuItem.Name = "DataDvdToolStripMenuItem"
        Me.DataDvdToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.DataDvdToolStripMenuItem.Text = "Data Dvd"
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(281, 300)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(75, 31)
        Me.Update.TabIndex = 101
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Frmsewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 567)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.dvdData)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtjuduldvd)
        Me.Controls.Add(Me.txtkodedvd)
        Me.Controls.Add(Me.txtkodesewa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.sewaData)
        Me.Controls.Add(Me.tglkembali)
        Me.Controls.Add(Me.tglsewa)
        Me.Controls.Add(Me.txtpenyewa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmsewa"
        Me.Text = "Frmsewa"
        CType(Me.dvdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sewaData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dvdData As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjuduldvd As TextBox
    Friend WithEvents txtkodedvd As TextBox
    Friend WithEvents txtkodesewa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents sewaData As DataGridView
    Friend WithEvents tglkembali As TextBox
    Friend WithEvents tglsewa As TextBox
    Friend WithEvents txtpenyewa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents delete As Button
    Friend WithEvents simpan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataSewaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDvdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Update As Button
End Class
