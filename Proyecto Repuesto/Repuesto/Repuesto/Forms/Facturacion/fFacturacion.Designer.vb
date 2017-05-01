<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFacturacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fFacturacion))
        Me.msInventario = New System.Windows.Forms.MenuStrip()
        Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrimeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnteriorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PróximoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeEsteProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodigoInv = New System.Windows.Forms.TextBox()
        Me.lblCodigoInv = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefonoPro = New System.Windows.Forms.Label()
        Me.rtxtDireccionPro = New System.Windows.Forms.RichTextBox()
        Me.lblDireccionPro = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.dtpFechaPro = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaPro = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bnavFact = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.btsBorrar = New System.Windows.Forms.ToolStripButton()
        Me.btsBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btsPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btsAnterior = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btsSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btsUltimo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btsNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btsEditar = New System.Windows.Forms.ToolStripButton()
        Me.btsAceptar = New System.Windows.Forms.ToolStripButton()
        Me.btsCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btsSalir = New System.Windows.Forms.ToolStripButton()
        Me.msInventario.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavFact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavFact.SuspendLayout()
        Me.SuspendLayout()
        '
        'msInventario
        '
        Me.msInventario.BackColor = System.Drawing.Color.Gainsboro
        Me.msInventario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdicionToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msInventario.Location = New System.Drawing.Point(0, 0)
        Me.msInventario.Name = "msInventario"
        Me.msInventario.Size = New System.Drawing.Size(668, 24)
        Me.msInventario.TabIndex = 38
        Me.msInventario.Text = "MenuStrip"
        '
        'EdicionToolStripMenuItem
        '
        Me.EdicionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.CortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.SeleccionarTodoToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.EdicionToolStripMenuItem.Text = "Edición"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DeshacerToolStripMenuItem.Text = "&Deshacer"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CortarToolStripMenuItem.Text = "Cor&tar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CopiarToolStripMenuItem.Text = "&Copiar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PegarToolStripMenuItem.Text = "&Pegar"
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SeleccionarTodoToolStripMenuItem.Text = "Seleccion&ar Todo"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.ToolStripSeparator3, Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ToolStripSeparator4, Me.PrimeroToolStripMenuItem, Me.AnteriorToolStripMenuItem, Me.PróximoToolStripMenuItem, Me.UltimoToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'CancelarToolStripMenuItem
        '
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorrarToolStripMenuItem.Text = "B&orrar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'PrimeroToolStripMenuItem
        '
        Me.PrimeroToolStripMenuItem.Name = "PrimeroToolStripMenuItem"
        Me.PrimeroToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.PrimeroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrimeroToolStripMenuItem.Text = "Pri&mero"
        '
        'AnteriorToolStripMenuItem
        '
        Me.AnteriorToolStripMenuItem.Name = "AnteriorToolStripMenuItem"
        Me.AnteriorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.AnteriorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnteriorToolStripMenuItem.Text = "Anterior"
        '
        'PróximoToolStripMenuItem
        '
        Me.PróximoToolStripMenuItem.Name = "PróximoToolStripMenuItem"
        Me.PróximoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.PróximoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PróximoToolStripMenuItem.Text = "Próximo"
        '
        'UltimoToolStripMenuItem
        '
        Me.UltimoToolStripMenuItem.Name = "UltimoToolStripMenuItem"
        Me.UltimoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UltimoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UltimoToolStripMenuItem.Text = "&Ultimo"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeEsteProgramaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeEsteProgramaToolStripMenuItem
        '
        Me.AcercaDeEsteProgramaToolStripMenuItem.Name = "AcercaDeEsteProgramaToolStripMenuItem"
        Me.AcercaDeEsteProgramaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AcercaDeEsteProgramaToolStripMenuItem.Text = "&Acerca de este programa"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtCodigoInv
        '
        Me.txtCodigoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoInv.Location = New System.Drawing.Point(106, 21)
        Me.txtCodigoInv.Name = "txtCodigoInv"
        Me.txtCodigoInv.Size = New System.Drawing.Size(82, 23)
        Me.txtCodigoInv.TabIndex = 41
        '
        'lblCodigoInv
        '
        Me.lblCodigoInv.AutoSize = True
        Me.lblCodigoInv.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoInv.Location = New System.Drawing.Point(18, 24)
        Me.lblCodigoInv.Name = "lblCodigoInv"
        Me.lblCodigoInv.Size = New System.Drawing.Size(91, 17)
        Me.lblCodigoInv.TabIndex = 40
        Me.lblCodigoInv.Text = "Nro. Factura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre del establecimiento:"
        '
        'mtxtTelefono
        '
        Me.mtxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.mtxtTelefono.Location = New System.Drawing.Point(445, 59)
        Me.mtxtTelefono.Mask = "(999) 000-0000"
        Me.mtxtTelefono.Name = "mtxtTelefono"
        Me.mtxtTelefono.Size = New System.Drawing.Size(195, 23)
        Me.mtxtTelefono.TabIndex = 48
        Me.mtxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTelefonoPro
        '
        Me.lblTelefonoPro.AutoSize = True
        Me.lblTelefonoPro.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefonoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoPro.ForeColor = System.Drawing.Color.Black
        Me.lblTelefonoPro.Location = New System.Drawing.Point(371, 59)
        Me.lblTelefonoPro.Name = "lblTelefonoPro"
        Me.lblTelefonoPro.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefonoPro.TabIndex = 47
        Me.lblTelefonoPro.Text = "Teléfono:"
        '
        'rtxtDireccionPro
        '
        Me.rtxtDireccionPro.ForeColor = System.Drawing.Color.Black
        Me.rtxtDireccionPro.Location = New System.Drawing.Point(442, 91)
        Me.rtxtDireccionPro.Name = "rtxtDireccionPro"
        Me.rtxtDireccionPro.Size = New System.Drawing.Size(198, 60)
        Me.rtxtDireccionPro.TabIndex = 50
        Me.rtxtDireccionPro.Text = ""
        '
        'lblDireccionPro
        '
        Me.lblDireccionPro.AutoSize = True
        Me.lblDireccionPro.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccionPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPro.ForeColor = System.Drawing.Color.Black
        Me.lblDireccionPro.Location = New System.Drawing.Point(368, 94)
        Me.lblDireccionPro.Name = "lblDireccionPro"
        Me.lblDireccionPro.Size = New System.Drawing.Size(71, 17)
        Me.lblDireccionPro.TabIndex = 49
        Me.lblDireccionPro.Text = "Dirección:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(211, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 23)
        Me.TextBox1.TabIndex = 51
        Me.TextBox1.Text = "Repuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(80, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(279, 23)
        Me.TextBox2.TabIndex = 53
        '
        'dtpFechaPro
        '
        Me.dtpFechaPro.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpFechaPro.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpFechaPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPro.Location = New System.Drawing.Point(251, 21)
        Me.dtpFechaPro.Name = "dtpFechaPro"
        Me.dtpFechaPro.Size = New System.Drawing.Size(108, 23)
        Me.dtpFechaPro.TabIndex = 55
        '
        'lblFechaPro
        '
        Me.lblFechaPro.AutoSize = True
        Me.lblFechaPro.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPro.ForeColor = System.Drawing.Color.Black
        Me.lblFechaPro.Location = New System.Drawing.Point(194, 24)
        Me.lblFechaPro.Name = "lblFechaPro"
        Me.lblFechaPro.Size = New System.Drawing.Size(51, 17)
        Me.lblFechaPro.TabIndex = 54
        Me.lblFechaPro.Text = "Fecha:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(445, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(195, 23)
        Me.TextBox3.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(365, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Vendedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPro)
        Me.GroupBox1.Controls.Add(Me.lblFechaPro)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.rtxtDireccionPro)
        Me.GroupBox1.Controls.Add(Me.lblDireccionPro)
        Me.GroupBox1.Controls.Add(Me.mtxtTelefono)
        Me.GroupBox1.Controls.Add(Me.lblTelefonoPro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigoInv)
        Me.GroupBox1.Controls.Add(Me.lblCodigoInv)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 157)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos generales de la factura"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(134, 213)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(93, 23)
        Me.TextBox4.TabIndex = 60
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 17)
        Me.LinkLabel1.TabIndex = 61
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Codigo producto:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 112)
        Me.DataGridView1.TabIndex = 62
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(300, 213)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(92, 23)
        Me.TextBox5.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(235, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Cantidad:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(581, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bnavFact
        '
        Me.bnavFact.AddNewItem = Nothing
        Me.bnavFact.BackColor = System.Drawing.Color.Gainsboro
        Me.bnavFact.CountItem = Me.BindingNavigatorCountItem
        Me.bnavFact.DeleteItem = Me.btsBorrar
        Me.bnavFact.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavFact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bnavFact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btsBuscar, Me.ToolStripSeparator1, Me.btsPrimero, Me.btsAnterior, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.btsSiguiente, Me.btsUltimo, Me.BindingNavigatorSeparator2, Me.btsNuevo, Me.btsEditar, Me.btsBorrar, Me.btsAceptar, Me.btsCancelar, Me.ToolStripSeparator2, Me.btsImprimir, Me.btsSalir})
        Me.bnavFact.Location = New System.Drawing.Point(0, 390)
        Me.bnavFact.MoveFirstItem = Me.btsPrimero
        Me.bnavFact.MoveLastItem = Me.btsUltimo
        Me.bnavFact.MoveNextItem = Me.btsSiguiente
        Me.bnavFact.MovePreviousItem = Me.btsAnterior
        Me.bnavFact.Name = "bnavFact"
        Me.bnavFact.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavFact.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.bnavFact.Size = New System.Drawing.Size(668, 42)
        Me.bnavFact.TabIndex = 64
        Me.bnavFact.Text = "Navegador"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 39)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'btsBorrar
        '
        Me.btsBorrar.Enabled = False
        Me.btsBorrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsBorrar.Image = CType(resources.GetObject("btsBorrar.Image"), System.Drawing.Image)
        Me.btsBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsBorrar.Name = "btsBorrar"
        Me.btsBorrar.RightToLeftAutoMirrorImage = True
        Me.btsBorrar.Size = New System.Drawing.Size(47, 39)
        Me.btsBorrar.Text = "Borrar"
        Me.btsBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsBuscar
        '
        Me.btsBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btsBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsBuscar.ForeColor = System.Drawing.Color.Black
        Me.btsBuscar.Image = CType(resources.GetObject("btsBuscar.Image"), System.Drawing.Image)
        Me.btsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsBuscar.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btsBuscar.Name = "btsBuscar"
        Me.btsBuscar.Size = New System.Drawing.Size(48, 39)
        Me.btsBuscar.Text = "Buscar"
        Me.btsBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btsBuscar.ToolTipText = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'btsPrimero
        '
        Me.btsPrimero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsPrimero.Image = CType(resources.GetObject("btsPrimero.Image"), System.Drawing.Image)
        Me.btsPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsPrimero.Name = "btsPrimero"
        Me.btsPrimero.RightToLeftAutoMirrorImage = True
        Me.btsPrimero.Size = New System.Drawing.Size(37, 39)
        Me.btsPrimero.Text = "Prim"
        Me.btsPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsAnterior
        '
        Me.btsAnterior.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsAnterior.Image = CType(resources.GetObject("btsAnterior.Image"), System.Drawing.Image)
        Me.btsAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsAnterior.Name = "btsAnterior"
        Me.btsAnterior.RightToLeftAutoMirrorImage = True
        Me.btsAnterior.Size = New System.Drawing.Size(31, 39)
        Me.btsAnterior.Text = "Ant"
        Me.btsAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.BackColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 42)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Enabled = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.BackColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator1.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'btsSiguiente
        '
        Me.btsSiguiente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsSiguiente.Image = CType(resources.GetObject("btsSiguiente.Image"), System.Drawing.Image)
        Me.btsSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsSiguiente.Name = "btsSiguiente"
        Me.btsSiguiente.RightToLeftAutoMirrorImage = True
        Me.btsSiguiente.Size = New System.Drawing.Size(28, 39)
        Me.btsSiguiente.Text = "Sig"
        Me.btsSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsUltimo
        '
        Me.btsUltimo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsUltimo.Image = CType(resources.GetObject("btsUltimo.Image"), System.Drawing.Image)
        Me.btsUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsUltimo.Name = "btsUltimo"
        Me.btsUltimo.RightToLeftAutoMirrorImage = True
        Me.btsUltimo.Size = New System.Drawing.Size(28, 39)
        Me.btsUltimo.Text = "Ult"
        Me.btsUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.BackColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator2.ForeColor = System.Drawing.Color.Black
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'btsNuevo
        '
        Me.btsNuevo.Enabled = False
        Me.btsNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsNuevo.Image = CType(resources.GetObject("btsNuevo.Image"), System.Drawing.Image)
        Me.btsNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsNuevo.Name = "btsNuevo"
        Me.btsNuevo.Size = New System.Drawing.Size(48, 39)
        Me.btsNuevo.Text = "Nuevo"
        Me.btsNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsEditar
        '
        Me.btsEditar.Enabled = False
        Me.btsEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsEditar.Image = CType(resources.GetObject("btsEditar.Image"), System.Drawing.Image)
        Me.btsEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsEditar.Name = "btsEditar"
        Me.btsEditar.Size = New System.Drawing.Size(43, 39)
        Me.btsEditar.Text = "Editar"
        Me.btsEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsAceptar
        '
        Me.btsAceptar.Enabled = False
        Me.btsAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsAceptar.Image = CType(resources.GetObject("btsAceptar.Image"), System.Drawing.Image)
        Me.btsAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsAceptar.Name = "btsAceptar"
        Me.btsAceptar.RightToLeftAutoMirrorImage = True
        Me.btsAceptar.Size = New System.Drawing.Size(55, 39)
        Me.btsAceptar.Text = "Aceptar"
        Me.btsAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsCancelar
        '
        Me.btsCancelar.Enabled = False
        Me.btsCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsCancelar.Image = CType(resources.GetObject("btsCancelar.Image"), System.Drawing.Image)
        Me.btsCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsCancelar.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btsCancelar.Name = "btsCancelar"
        Me.btsCancelar.Size = New System.Drawing.Size(58, 39)
        Me.btsCancelar.Text = "Cancelar"
        Me.btsCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.Black
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'btsImprimir
        '
        Me.btsImprimir.Enabled = False
        Me.btsImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsImprimir.Image = CType(resources.GetObject("btsImprimir.Image"), System.Drawing.Image)
        Me.btsImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsImprimir.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btsImprimir.Name = "btsImprimir"
        Me.btsImprimir.Size = New System.Drawing.Size(33, 39)
        Me.btsImprimir.Text = "Imp"
        Me.btsImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsSalir
        '
        Me.btsSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsSalir.Image = CType(resources.GetObject("btsSalir.Image"), System.Drawing.Image)
        Me.btsSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsSalir.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btsSalir.Name = "btsSalir"
        Me.btsSalir.Size = New System.Drawing.Size(35, 39)
        Me.btsSalir.Text = "Salir"
        Me.btsSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'fFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(668, 432)
        Me.Controls.Add(Me.bnavFact)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.msInventario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fFacturacion"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Facturacion"
        Me.msInventario.ResumeLayout(False)
        Me.msInventario.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavFact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavFact.ResumeLayout(False)
        Me.bnavFact.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msInventario As System.Windows.Forms.MenuStrip
    Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AceptarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrimeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnteriorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PróximoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltimoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeEsteProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCodigoInv As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoInv As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefonoPro As System.Windows.Forms.Label
    Friend WithEvents rtxtDireccionPro As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDireccionPro As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaPro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaPro As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bnavFact As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btsBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsSalir As System.Windows.Forms.ToolStripButton
End Class
