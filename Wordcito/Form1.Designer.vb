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
        Me.CmbSize = New System.Windows.Forms.ComboBox()
        Me.CmbFont = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOscuro = New System.Windows.Forms.Button()
        Me.BtnClaro = New System.Windows.Forms.Button()
        Me.BtnSistema = New System.Windows.Forms.Button()
        Me.BtnLeer = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'CmbSize
        '
        Me.CmbSize.FormattingEnabled = True
        Me.CmbSize.Items.AddRange(New Object() {"11", "14", "18", "20", "22", "26"})
        Me.CmbSize.Location = New System.Drawing.Point(132, 118)
        Me.CmbSize.Name = "CmbSize"
        Me.CmbSize.Size = New System.Drawing.Size(151, 24)
        Me.CmbSize.TabIndex = 0
        '
        'CmbFont
        '
        Me.CmbFont.FormattingEnabled = True
        Me.CmbFont.Items.AddRange(New Object() {"Microsoft Sans Serif", "Georgia", "Arial", "Times New Roman ", "Trebuchet MS", "Verdana"})
        Me.CmbFont.Location = New System.Drawing.Point(322, 118)
        Me.CmbFont.Name = "CmbFont"
        Me.CmbFont.Size = New System.Drawing.Size(151, 24)
        Me.CmbFont.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tamaño de letra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de letra"
        '
        'BtnOscuro
        '
        Me.BtnOscuro.Location = New System.Drawing.Point(595, 118)
        Me.BtnOscuro.Name = "BtnOscuro"
        Me.BtnOscuro.Size = New System.Drawing.Size(92, 30)
        Me.BtnOscuro.TabIndex = 4
        Me.BtnOscuro.Text = "Oscuro"
        Me.BtnOscuro.UseVisualStyleBackColor = True
        '
        'BtnClaro
        '
        Me.BtnClaro.Location = New System.Drawing.Point(707, 118)
        Me.BtnClaro.Name = "BtnClaro"
        Me.BtnClaro.Size = New System.Drawing.Size(92, 30)
        Me.BtnClaro.TabIndex = 5
        Me.BtnClaro.Text = "Claro"
        Me.BtnClaro.UseVisualStyleBackColor = True
        '
        'BtnSistema
        '
        Me.BtnSistema.Location = New System.Drawing.Point(823, 118)
        Me.BtnSistema.Name = "BtnSistema"
        Me.BtnSistema.Size = New System.Drawing.Size(92, 30)
        Me.BtnSistema.TabIndex = 6
        Me.BtnSistema.Text = "Sistema"
        Me.BtnSistema.UseVisualStyleBackColor = True
        '
        'BtnLeer
        '
        Me.BtnLeer.Location = New System.Drawing.Point(595, 658)
        Me.BtnLeer.Name = "BtnLeer"
        Me.BtnLeer.Size = New System.Drawing.Size(92, 30)
        Me.BtnLeer.TabIndex = 10
        Me.BtnLeer.Text = "Leer"
        Me.BtnLeer.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(707, 658)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(92, 30)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(823, 658)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(92, 30)
        Me.BtnSalir.TabIndex = 12
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(132, 179)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(783, 460)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 780)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnLeer)
        Me.Controls.Add(Me.BtnSistema)
        Me.Controls.Add(Me.BtnClaro)
        Me.Controls.Add(Me.BtnOscuro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbFont)
        Me.Controls.Add(Me.CmbSize)
        Me.Name = "Form1"
        Me.Text = "Wordcito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSize As ComboBox
    Friend WithEvents CmbFont As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOscuro As Button
    Friend WithEvents BtnClaro As Button
    Friend WithEvents BtnSistema As Button
    Friend WithEvents BtnLeer As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
