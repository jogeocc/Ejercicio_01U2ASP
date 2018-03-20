<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDatos
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblNum = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(204, 155)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(123, 42)
        Me.BtnRegresar.TabIndex = 7
        Me.BtnRegresar.Text = "Regresar a menú"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(66, 155)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 42)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.BackColor = System.Drawing.Color.Gray
        Me.LblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum.Location = New System.Drawing.Point(-19, 9)
        Me.LblNum.MinimumSize = New System.Drawing.Size(400, 0)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Padding = New System.Windows.Forms.Padding(5)
        Me.LblNum.Size = New System.Drawing.Size(400, 34)
        Me.LblNum.TabIndex = 5
        Me.LblNum.Text = "Ingrese el Número 1"
        Me.LblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(103, 78)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(175, 20)
        Me.TxtNum.TabIndex = 4
        '
        'AgregarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 236)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.TxtNum)
        Me.Name = "AgregarDatos"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents BtnRegresar As Button
    Private WithEvents BtnGuardar As Button
    Private WithEvents LblNum As Label
    Private WithEvents TxtNum As TextBox
End Class
