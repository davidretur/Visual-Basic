<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtigv = New System.Windows.Forms.TextBox()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.txtresulproducto = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad:"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(48, 191)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(112, 35)
        Me.btnnuevo.TabIndex = 3
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(186, 191)
        Me.btncalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(112, 35)
        Me.btncalcular.TabIndex = 4
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(323, 191)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(112, 35)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Importe de compra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "IGV 18%:"
        '
        'txtproducto
        '
        Me.txtproducto.Location = New System.Drawing.Point(194, 27)
        Me.txtproducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(229, 26)
        Me.txtproducto.TabIndex = 9
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(194, 69)
        Me.txtprecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(148, 26)
        Me.txtprecio.TabIndex = 10
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(194, 109)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(148, 26)
        Me.txtcantidad.TabIndex = 11
        '
        'txtigv
        '
        Me.txtigv.Enabled = False
        Me.txtigv.Location = New System.Drawing.Point(194, 121)
        Me.txtigv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(148, 26)
        Me.txtigv.TabIndex = 12
        '
        'txtimporte
        '
        Me.txtimporte.Enabled = False
        Me.txtimporte.Location = New System.Drawing.Point(194, 72)
        Me.txtimporte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(148, 26)
        Me.txtimporte.TabIndex = 13
        '
        'txtresulproducto
        '
        Me.txtresulproducto.Enabled = False
        Me.txtresulproducto.Location = New System.Drawing.Point(194, 27)
        Me.txtresulproducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtresulproducto.Name = "txtresulproducto"
        Me.txtresulproducto.Size = New System.Drawing.Size(229, 26)
        Me.txtresulproducto.TabIndex = 14
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(194, 167)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(148, 26)
        Me.txttotal.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total a pagar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtproducto)
        Me.GroupBox1.Controls.Add(Me.txtprecio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 161)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtresulproducto)
        Me.GroupBox2.Controls.Add(Me.txtigv)
        Me.GroupBox2.Controls.Add(Me.txtimporte)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 201)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(476, 453)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.btnnuevo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de productos - VaidrollTeam"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtigv As TextBox
    Friend WithEvents txtimporte As TextBox
    Friend WithEvents txtresulproducto As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
