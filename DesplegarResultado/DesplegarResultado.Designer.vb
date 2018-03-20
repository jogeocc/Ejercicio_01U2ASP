<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesplegarResultado
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.TxtDiv = New System.Windows.Forms.TextBox()
        Me.TxtProd = New System.Windows.Forms.TextBox()
        Me.TxtResta = New System.Windows.Forms.TextBox()
        Me.TxtSuma = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(368, 191)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(99, 58)
        Me.BtnCerrar.TabIndex = 19
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(41, 181)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 24)
        Me.label5.TabIndex = 18
        Me.label5.Text = "División"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(41, 144)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 24)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Producto"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(41, 111)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(57, 24)
        Me.label3.TabIndex = 16
        Me.label3.Text = "Resta"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(41, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 24)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Suma"
        '
        'TxtDiv
        '
        Me.TxtDiv.Enabled = False
        Me.TxtDiv.Location = New System.Drawing.Point(175, 184)
        Me.TxtDiv.Name = "TxtDiv"
        Me.TxtDiv.Size = New System.Drawing.Size(165, 20)
        Me.TxtDiv.TabIndex = 14
        '
        'TxtProd
        '
        Me.TxtProd.Enabled = False
        Me.TxtProd.Location = New System.Drawing.Point(175, 144)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.Size = New System.Drawing.Size(165, 20)
        Me.TxtProd.TabIndex = 13
        '
        'TxtResta
        '
        Me.TxtResta.Enabled = False
        Me.TxtResta.Location = New System.Drawing.Point(175, 109)
        Me.TxtResta.Name = "TxtResta"
        Me.TxtResta.Size = New System.Drawing.Size(165, 20)
        Me.TxtResta.TabIndex = 12
        '
        'TxtSuma
        '
        Me.TxtSuma.Enabled = False
        Me.TxtSuma.Location = New System.Drawing.Point(175, 74)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(165, 20)
        Me.TxtSuma.TabIndex = 11
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Gray
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(-8, 9)
        Me.label1.MinimumSize = New System.Drawing.Size(500, 0)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(5)
        Me.label1.Size = New System.Drawing.Size(500, 39)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Resultados"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesplegarResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 261)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.TxtDiv)
        Me.Controls.Add(Me.TxtProd)
        Me.Controls.Add(Me.TxtResta)
        Me.Controls.Add(Me.TxtSuma)
        Me.Controls.Add(Me.label1)
        Me.Name = "DesplegarResultado"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BtnCerrar As Button
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents TxtDiv As TextBox
    Private WithEvents TxtProd As TextBox
    Private WithEvents TxtResta As TextBox
    Private WithEvents TxtSuma As TextBox
    Private WithEvents label1 As Label
End Class
