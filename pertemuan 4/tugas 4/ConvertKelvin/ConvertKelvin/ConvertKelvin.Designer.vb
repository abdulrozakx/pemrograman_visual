﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertKelvin
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.LabelReamur = New System.Windows.Forms.Label()
        Me.LabelFahrenheit = New System.Windows.Forms.Label()
        Me.LabelCelcius = New System.Windows.Forms.Label()
        Me.LabelKelvin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(144, 78)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 32)
        Me.btnConvert.TabIndex = 35
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(144, 206)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(100, 27)
        Me.txtReamur.TabIndex = 34
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(144, 163)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 27)
        Me.txtFahrenheit.TabIndex = 33
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(144, 122)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(100, 27)
        Me.txtCelcius.TabIndex = 32
        '
        'txtKelvin
        '
        Me.txtKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(144, 35)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(100, 27)
        Me.txtKelvin.TabIndex = 31
        '
        'LabelReamur
        '
        Me.LabelReamur.AutoSize = True
        Me.LabelReamur.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReamur.Location = New System.Drawing.Point(40, 208)
        Me.LabelReamur.Name = "LabelReamur"
        Me.LabelReamur.Size = New System.Drawing.Size(61, 23)
        Me.LabelReamur.TabIndex = 30
        Me.LabelReamur.Text = "Reamur"
        '
        'LabelFahrenheit
        '
        Me.LabelFahrenheit.AutoSize = True
        Me.LabelFahrenheit.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFahrenheit.Location = New System.Drawing.Point(40, 165)
        Me.LabelFahrenheit.Name = "LabelFahrenheit"
        Me.LabelFahrenheit.Size = New System.Drawing.Size(79, 23)
        Me.LabelFahrenheit.TabIndex = 29
        Me.LabelFahrenheit.Text = "Fahrenheit"
        '
        'LabelCelcius
        '
        Me.LabelCelcius.AutoSize = True
        Me.LabelCelcius.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCelcius.Location = New System.Drawing.Point(40, 124)
        Me.LabelCelcius.Name = "LabelCelcius"
        Me.LabelCelcius.Size = New System.Drawing.Size(57, 23)
        Me.LabelCelcius.TabIndex = 28
        Me.LabelCelcius.Text = "Celcius"
        '
        'LabelKelvin
        '
        Me.LabelKelvin.AutoSize = True
        Me.LabelKelvin.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKelvin.Location = New System.Drawing.Point(40, 38)
        Me.LabelKelvin.Name = "LabelKelvin"
        Me.LabelKelvin.Size = New System.Drawing.Size(47, 23)
        Me.LabelKelvin.TabIndex = 27
        Me.LabelKelvin.Text = "Kelvin"
        '
        'ConvertKelvin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 268)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.LabelReamur)
        Me.Controls.Add(Me.LabelFahrenheit)
        Me.Controls.Add(Me.LabelCelcius)
        Me.Controls.Add(Me.LabelKelvin)
        Me.Name = "ConvertKelvin"
        Me.Text = "Convert Kelvin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents LabelReamur As Label
    Friend WithEvents LabelFahrenheit As Label
    Friend WithEvents LabelCelcius As Label
    Friend WithEvents LabelKelvin As Label
End Class
