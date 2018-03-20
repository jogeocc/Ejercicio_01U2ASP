<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuBienvenida))
        Me.LblImagen = New System.Windows.Forms.Label()
        Me.BtnContinuar = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LblBienv = New System.Windows.Forms.Label()
        Me.TxtOpcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblImagen
        '
        Me.LblImagen.AutoSize = True
        Me.LblImagen.Image = CType(resources.GetObject("LblImagen.Image"), System.Drawing.Image)
        Me.LblImagen.Location = New System.Drawing.Point(270, 104)
        Me.LblImagen.MinimumSize = New System.Drawing.Size(200, 200)
        Me.LblImagen.Name = "LblImagen"
        Me.LblImagen.Size = New System.Drawing.Size(200, 200)
        Me.LblImagen.TabIndex = 19
        '
        'BtnContinuar
        '
        Me.BtnContinuar.BackColor = System.Drawing.Color.Silver
        Me.BtnContinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinuar.Location = New System.Drawing.Point(273, 324)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(197, 39)
        Me.BtnContinuar.TabIndex = 18
        Me.BtnContinuar.Text = "Continuar"
        Me.BtnContinuar.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(12, 300)
        Me.label6.Name = "label6"
        Me.label6.Padding = New System.Windows.Forms.Padding(5)
        Me.label6.Size = New System.Drawing.Size(157, 30)
        Me.label6.TabIndex = 17
        Me.label6.Text = "6) Ver resultados"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 265)
        Me.label5.Name = "label5"
        Me.label5.Padding = New System.Windows.Forms.Padding(5)
        Me.label5.Size = New System.Drawing.Size(173, 30)
        Me.label5.TabIndex = 16
        Me.label5.Text = "5) Realizar División"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 229)
        Me.label4.Name = "label4"
        Me.label4.Padding = New System.Windows.Forms.Padding(5)
        Me.label4.Size = New System.Drawing.Size(183, 30)
        Me.label4.TabIndex = 15
        Me.label4.Text = "4) Realizar Producto"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(13, 194)
        Me.label3.Name = "label3"
        Me.label3.Padding = New System.Windows.Forms.Padding(5)
        Me.label3.Size = New System.Drawing.Size(159, 30)
        Me.label3.TabIndex = 14
        Me.label3.Text = "3) Realizar Resta"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(13, 160)
        Me.label2.Name = "label2"
        Me.label2.Padding = New System.Windows.Forms.Padding(5)
        Me.label2.Size = New System.Drawing.Size(163, 30)
        Me.label2.TabIndex = 13
        Me.label2.Text = "2) Realizar Sumar"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 125)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(5)
        Me.label1.Size = New System.Drawing.Size(160, 30)
        Me.label1.TabIndex = 12
        Me.label1.Text = "1) Ingresar Datos"
        '
        'LblBienv
        '
        Me.LblBienv.AutoSize = True
        Me.LblBienv.BackColor = System.Drawing.Color.Silver
        Me.LblBienv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienv.Location = New System.Drawing.Point(75, 9)
        Me.LblBienv.Name = "LblBienv"
        Me.LblBienv.Padding = New System.Windows.Forms.Padding(10)
        Me.LblBienv.Size = New System.Drawing.Size(341, 44)
        Me.LblBienv.TabIndex = 11
        Me.LblBienv.Text = "Bienvenido por favor elija una opción"
        Me.LblBienv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtOpcion
        '
        Me.TxtOpcion.BackColor = System.Drawing.SystemColors.MenuText
        Me.TxtOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOpcion.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtOpcion.Location = New System.Drawing.Point(167, 59)
        Me.TxtOpcion.MaximumSize = New System.Drawing.Size(150, 30)
        Me.TxtOpcion.MinimumSize = New System.Drawing.Size(150, 30)
        Me.TxtOpcion.Name = "TxtOpcion"
        Me.TxtOpcion.Size = New System.Drawing.Size(150, 29)
        Me.TxtOpcion.TabIndex = 10
        Me.TxtOpcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 385)
        Me.Controls.Add(Me.LblImagen)
        Me.Controls.Add(Me.BtnContinuar)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.LblBienv)
        Me.Controls.Add(Me.TxtOpcion)
        Me.Name = "MenuBienvenida"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LblImagen As Label
    Private WithEvents BtnContinuar As Button
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents LblBienv As Label
    Private WithEvents TxtOpcion As TextBox
End Class
