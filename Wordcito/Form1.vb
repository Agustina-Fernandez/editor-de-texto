Public Class Form1
    'Establecemos una fuente y un tamaño predeterminados
    Public fuente As String = "Arial"
    Public tamano As Integer = 16
    'Archivo local en el que se va a guardar lo que escribamos
    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\wordCito.rtf"

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Guardamos en el archivo lo que escribimos con el tamaño y la fuente que elegimos
        RichTextBox1.SaveFile(ruta, RichTextBoxStreamType.RichText)
        MessageBox.Show("Información guardada")
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        'Si el archivo existe entonces lo mostrara
        If My.Computer.FileSystem.FileExists(ruta) Then
            RichTextBox1.LoadFile(ruta, RichTextBoxStreamType.RichText)
            'Cambiamos el color del texto para que se vea en modo claro
            RichTextBox1.SelectAll()
            If Me.BackColor = Color.WhiteSmoke Then
                RichTextBox1.SelectionColor = Color.Black
            Else
                RichTextBox1.SelectionColor = Me.ForeColor
            End If

            'Si no existe,entonces dira que no se encontró
        Else
            MessageBox.Show("No se encontró ningun archivo guardado en el escritorio")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim respuesta = MsgBox("¿Desea guardar los cambios antes de salir?", vbQuestion + vbYesNoCancel, "Guardar y Salir")
        'Si la respuesta es SI entonces guardara el texto con el tamaño y fuente elegidos
        If respuesta = 6 Then
            RichTextBox1.SaveFile(ruta, RichTextBoxStreamType.RichText)
            MessageBox.Show("Información guardada")
            End
            'Si la respuesta es NO entonces no se guardara y se cerrara el programa
        ElseIf respuesta = 7 Then
            End
        End If
    End Sub

    Private Sub BtnOscuro_Click(sender As Object, e As EventArgs) Handles BtnOscuro.Click
        'Para cambiar la interfaz a MODO OSCURO
        Me.BackColor = Color.Black
        CmbFont.BackColor = Color.Black
        CmbSize.BackColor = Color.Black
        BtnClaro.BackColor = Color.Black
        BtnOscuro.BackColor = Color.Black
        BtnSistema.BackColor = Color.Black
        BtnGuardar.BackColor = Color.Black
        BtnLeer.BackColor = Color.Black
        BtnSalir.BackColor = Color.Black
        RichTextBox1.BackColor = Color.Black

        Me.ForeColor = Color.White
        CmbFont.ForeColor = Color.White
        CmbSize.ForeColor = Color.White
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub BtnClaro_Click(sender As Object, e As EventArgs) Handles BtnClaro.Click
        'Para cambiar la interfaz a MODO CLARO
        Me.BackColor = Color.WhiteSmoke
        CmbFont.BackColor = Color.WhiteSmoke
        CmbSize.BackColor = Color.WhiteSmoke
        BtnClaro.BackColor = Color.WhiteSmoke
        BtnOscuro.BackColor = Color.WhiteSmoke
        BtnSistema.BackColor = Color.WhiteSmoke
        BtnGuardar.BackColor = Color.WhiteSmoke
        BtnLeer.BackColor = Color.WhiteSmoke
        BtnSalir.BackColor = Color.WhiteSmoke
        RichTextBox1.BackColor = Color.WhiteSmoke

        Me.ForeColor = Color.Black
        CmbFont.ForeColor = Color.Black
        CmbSize.ForeColor = Color.Black
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub BtnSistema_Click(sender As Object, e As EventArgs) Handles BtnSistema.Click
        'Para cambiar la interfaz a MODO SISTEMA
        Me.BackColor = Color.BlueViolet
        CmbFont.BackColor = Color.BlueViolet
        CmbSize.BackColor = Color.BlueViolet
        BtnClaro.BackColor = Color.BlueViolet
        BtnOscuro.BackColor = Color.BlueViolet
        BtnSistema.BackColor = Color.BlueViolet
        BtnGuardar.BackColor = Color.BlueViolet
        BtnLeer.BackColor = Color.BlueViolet
        BtnSalir.BackColor = Color.BlueViolet
        RichTextBox1.BackColor = Color.BlueViolet

        Me.ForeColor = Color.White
        CmbFont.ForeColor = Color.White
        CmbSize.ForeColor = Color.White
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub CmbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSize.SelectedIndexChanged
        'Para aplicar los distintos tamaños al texto
        If CmbSize.SelectedIndex = 0 Then
            tamano = 11
        ElseIf CmbSize.SelectedIndex = 1 Then
            tamano = 14
        ElseIf CmbSize.SelectedIndex = 2 Then
            tamano = 18
        ElseIf CmbSize.SelectedIndex = 3 Then
            tamano = 20
        ElseIf CmbSize.SelectedIndex = 4 Then
            tamano = 22
        ElseIf CmbSize.SelectedIndex = 5 Then
            tamano = 26
        End If

        'Para evitar errores si se seleccionan multiples tamaños de texto
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionFont = New Font(fuente, tamano, RichTextBox1.SelectionFont.Style)
        End If
    End Sub

    Private Sub CmbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFont.SelectedIndexChanged
        'Para aplicar las distintas fuentes al texto
        If CmbFont.SelectedIndex = 0 Then
            fuente = "Microsoft Sans Serif"
        ElseIf CmbFont.SelectedIndex = 1 Then
            fuente = "Georgia"
        ElseIf CmbFont.SelectedIndex = 2 Then
            fuente = "Arial"
        ElseIf CmbFont.SelectedIndex = 3 Then
            fuente = "Times New Roman"
        ElseIf CmbFont.SelectedIndex = 4 Then
            fuente = "Trebuchet MS"
        ElseIf CmbFont.SelectedIndex = 5 Then
            fuente = "Verdana"
        End If

        'Para evitar errores si se seleccionan multiples fuentes de texto
        If RichTextBox1.SelectionFont IsNot Nothing Then
            RichTextBox1.SelectionFont = New Font(fuente, tamano, RichTextBox1.SelectionFont.Style)
        End If
    End Sub
End Class
