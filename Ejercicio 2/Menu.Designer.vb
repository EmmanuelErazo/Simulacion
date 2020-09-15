<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.txtCantidadExperimento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGananciaPromedio = New System.Windows.Forms.TextBox()
        Me.cmb_tabla_referencia = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbnCompraDiaria = New System.Windows.Forms.RadioButton()
        Me.RbnDemandaDiaAnterior = New System.Windows.Forms.RadioButton()
        Me.txt_compra_diaria = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precio_compra = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txt_faltante = New System.Windows.Forms.TextBox()
        Me.txt_precio_venta = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_precio_reventa = New System.Windows.Forms.TextBox()
        Me.cmbCargarEjemplo = New System.Windows.Forms.Button()
        Me.cmbLimpiar = New System.Windows.Forms.Button()
        Me.cmbGenerar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtPrecioCompraFaltante = New System.Windows.Forms.TextBox()
        Me.LblPrecioCompraFaltante = New System.Windows.Forms.Label()
        Me.RbnSiComprar = New System.Windows.Forms.RadioButton()
        Me.RbnNoComprar = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad de experimentos"
        '
        'txtCantidadExperimento
        '
        Me.txtCantidadExperimento.Location = New System.Drawing.Point(148, 9)
        Me.txtCantidadExperimento.Name = "txtCantidadExperimento"
        Me.txtCantidadExperimento.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadExperimento.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mostrar Desde"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(148, 47)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 1
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(148, 85)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mostrar Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ganancia Diaria Promedio"
        '
        'txtGananciaPromedio
        '
        Me.txtGananciaPromedio.Enabled = False
        Me.txtGananciaPromedio.Location = New System.Drawing.Point(433, 10)
        Me.txtGananciaPromedio.Name = "txtGananciaPromedio"
        Me.txtGananciaPromedio.Size = New System.Drawing.Size(100, 20)
        Me.txtGananciaPromedio.TabIndex = 7
        '
        'cmb_tabla_referencia
        '
        Me.cmb_tabla_referencia.Location = New System.Drawing.Point(458, 49)
        Me.cmb_tabla_referencia.Name = "cmb_tabla_referencia"
        Me.cmb_tabla_referencia.Size = New System.Drawing.Size(136, 23)
        Me.cmb_tabla_referencia.TabIndex = 4
        Me.cmb_tabla_referencia.Text = "Ver Tabla de Referencia"
        Me.cmb_tabla_referencia.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbnCompraDiaria)
        Me.GroupBox2.Controls.Add(Me.RbnDemandaDiaAnterior)
        Me.GroupBox2.Controls.Add(Me.txt_compra_diaria)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 85)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compra Diaria de Flores"
        '
        'RbnCompraDiaria
        '
        Me.RbnCompraDiaria.AutoSize = True
        Me.RbnCompraDiaria.Checked = True
        Me.RbnCompraDiaria.Location = New System.Drawing.Point(15, 45)
        Me.RbnCompraDiaria.Name = "RbnCompraDiaria"
        Me.RbnCompraDiaria.Size = New System.Drawing.Size(91, 17)
        Me.RbnCompraDiaria.TabIndex = 2
        Me.RbnCompraDiaria.TabStop = True
        Me.RbnCompraDiaria.Text = "Compra Diaria"
        Me.RbnCompraDiaria.UseVisualStyleBackColor = True
        '
        'RbnDemandaDiaAnterior
        '
        Me.RbnDemandaDiaAnterior.AutoSize = True
        Me.RbnDemandaDiaAnterior.Location = New System.Drawing.Point(15, 22)
        Me.RbnDemandaDiaAnterior.Name = "RbnDemandaDiaAnterior"
        Me.RbnDemandaDiaAnterior.Size = New System.Drawing.Size(129, 17)
        Me.RbnDemandaDiaAnterior.TabIndex = 1
        Me.RbnDemandaDiaAnterior.Text = "Demanda Dia Anterior"
        Me.RbnDemandaDiaAnterior.UseVisualStyleBackColor = True
        '
        'txt_compra_diaria
        '
        Me.txt_compra_diaria.Location = New System.Drawing.Point(137, 44)
        Me.txt_compra_diaria.Name = "txt_compra_diaria"
        Me.txt_compra_diaria.Size = New System.Drawing.Size(52, 20)
        Me.txt_compra_diaria.TabIndex = 0
        Me.txt_compra_diaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.txt_precio_compra)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txt_faltante)
        Me.groupBox1.Controls.Add(Me.txt_precio_venta)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txt_precio_reventa)
        Me.groupBox1.Location = New System.Drawing.Point(32, 111)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(216, 154)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Rosas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Precio Compra $"
        '
        'txt_precio_compra
        '
        Me.txt_precio_compra.Location = New System.Drawing.Point(116, 28)
        Me.txt_precio_compra.Name = "txt_precio_compra"
        Me.txt_precio_compra.Size = New System.Drawing.Size(52, 20)
        Me.txt_precio_compra.TabIndex = 0
        Me.txt_precio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(28, 58)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(77, 13)
        Me.label6.TabIndex = 47
        Me.label6.Text = "Precio Venta $"
        '
        'txt_faltante
        '
        Me.txt_faltante.Location = New System.Drawing.Point(116, 115)
        Me.txt_faltante.Name = "txt_faltante"
        Me.txt_faltante.Size = New System.Drawing.Size(52, 20)
        Me.txt_faltante.TabIndex = 3
        Me.txt_faltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_precio_venta
        '
        Me.txt_precio_venta.Location = New System.Drawing.Point(116, 57)
        Me.txt_precio_venta.Name = "txt_precio_venta"
        Me.txt_precio_venta.Size = New System.Drawing.Size(52, 20)
        Me.txt_precio_venta.TabIndex = 1
        Me.txt_precio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(21, 118)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(84, 13)
        Me.label8.TabIndex = 51
        Me.label8.Text = "Costo Faltante $"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(15, 88)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(90, 13)
        Me.label7.TabIndex = 49
        Me.label7.Text = "Precio Reventa $"
        '
        'txt_precio_reventa
        '
        Me.txt_precio_reventa.Location = New System.Drawing.Point(116, 86)
        Me.txt_precio_reventa.Name = "txt_precio_reventa"
        Me.txt_precio_reventa.Size = New System.Drawing.Size(52, 20)
        Me.txt_precio_reventa.TabIndex = 2
        Me.txt_precio_reventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCargarEjemplo
        '
        Me.cmbCargarEjemplo.Location = New System.Drawing.Point(458, 85)
        Me.cmbCargarEjemplo.Name = "cmbCargarEjemplo"
        Me.cmbCargarEjemplo.Size = New System.Drawing.Size(136, 23)
        Me.cmbCargarEjemplo.TabIndex = 3
        Me.cmbCargarEjemplo.Text = "Cargar Ejemplo"
        Me.cmbCargarEjemplo.UseVisualStyleBackColor = True
        '
        'cmbLimpiar
        '
        Me.cmbLimpiar.Location = New System.Drawing.Point(291, 49)
        Me.cmbLimpiar.Name = "cmbLimpiar"
        Me.cmbLimpiar.Size = New System.Drawing.Size(136, 23)
        Me.cmbLimpiar.TabIndex = 5
        Me.cmbLimpiar.Text = "Limpiar"
        Me.cmbLimpiar.UseVisualStyleBackColor = True
        '
        'cmbGenerar
        '
        Me.cmbGenerar.Location = New System.Drawing.Point(565, 353)
        Me.cmbGenerar.Name = "cmbGenerar"
        Me.cmbGenerar.Size = New System.Drawing.Size(75, 23)
        Me.cmbGenerar.TabIndex = 10
        Me.cmbGenerar.Text = "Generar"
        Me.cmbGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtPrecioCompraFaltante)
        Me.GroupBox3.Controls.Add(Me.LblPrecioCompraFaltante)
        Me.GroupBox3.Controls.Add(Me.RbnSiComprar)
        Me.GroupBox3.Controls.Add(Me.RbnNoComprar)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra De Mercaderia Faltante"
        '
        'TxtPrecioCompraFaltante
        '
        Me.TxtPrecioCompraFaltante.Location = New System.Drawing.Point(116, 74)
        Me.TxtPrecioCompraFaltante.Name = "TxtPrecioCompraFaltante"
        Me.TxtPrecioCompraFaltante.Size = New System.Drawing.Size(52, 20)
        Me.TxtPrecioCompraFaltante.TabIndex = 3
        '
        'LblPrecioCompraFaltante
        '
        Me.LblPrecioCompraFaltante.AutoSize = True
        Me.LblPrecioCompraFaltante.Location = New System.Drawing.Point(12, 77)
        Me.LblPrecioCompraFaltante.Name = "LblPrecioCompraFaltante"
        Me.LblPrecioCompraFaltante.Size = New System.Drawing.Size(85, 13)
        Me.LblPrecioCompraFaltante.TabIndex = 2
        Me.LblPrecioCompraFaltante.Text = "Precio Compra $"
        '
        'RbnSiComprar
        '
        Me.RbnSiComprar.AutoSize = True
        Me.RbnSiComprar.Location = New System.Drawing.Point(18, 52)
        Me.RbnSiComprar.Name = "RbnSiComprar"
        Me.RbnSiComprar.Size = New System.Drawing.Size(34, 17)
        Me.RbnSiComprar.TabIndex = 1
        Me.RbnSiComprar.TabStop = True
        Me.RbnSiComprar.Text = "Si"
        Me.RbnSiComprar.UseVisualStyleBackColor = True
        '
        'RbnNoComprar
        '
        Me.RbnNoComprar.AutoSize = True
        Me.RbnNoComprar.Checked = True
        Me.RbnNoComprar.Location = New System.Drawing.Point(18, 29)
        Me.RbnNoComprar.Name = "RbnNoComprar"
        Me.RbnNoComprar.Size = New System.Drawing.Size(39, 17)
        Me.RbnNoComprar.TabIndex = 0
        Me.RbnNoComprar.TabStop = True
        Me.RbnNoComprar.Text = "No"
        Me.RbnNoComprar.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 388)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmbGenerar)
        Me.Controls.Add(Me.cmbLimpiar)
        Me.Controls.Add(Me.cmbCargarEjemplo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.cmb_tabla_referencia)
        Me.Controls.Add(Me.txtGananciaPromedio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCantidadExperimento)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_menu"
        Me.Text = "Menu"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidadExperimento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGananciaPromedio As TextBox
    Friend WithEvents cmb_tabla_referencia As Button
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents txt_compra_diaria As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label5 As Label
    Private WithEvents txt_precio_compra As TextBox
    Private WithEvents label6 As Label
    Private WithEvents txt_faltante As TextBox
    Private WithEvents txt_precio_venta As TextBox
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents txt_precio_reventa As TextBox
    Friend WithEvents cmbCargarEjemplo As Button
    Friend WithEvents cmbLimpiar As Button
    Friend WithEvents cmbGenerar As Button
    Friend WithEvents RbnCompraDiaria As RadioButton
    Friend WithEvents RbnDemandaDiaAnterior As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblPrecioCompraFaltante As Label
    Friend WithEvents RbnSiComprar As RadioButton
    Friend WithEvents RbnNoComprar As RadioButton
    Friend WithEvents TxtPrecioCompraFaltante As TextBox
End Class
