<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProveedor))
        Me.msProveedor = New System.Windows.Forms.MenuStrip()
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
        Me.rtxtComentPro = New System.Windows.Forms.RichTextBox()
        Me.dtpFechaPro = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaPro = New System.Windows.Forms.Label()
        Me.txtCodigoPro = New System.Windows.Forms.TextBox()
        Me.lblComentPro = New System.Windows.Forms.Label()
        Me.lblCodigoPro = New System.Windows.Forms.Label()
        Me.rtxtDireccionPro = New System.Windows.Forms.RichTextBox()
        Me.txtNombrePro = New System.Windows.Forms.TextBox()
        Me.lblNombrePro = New System.Windows.Forms.Label()
        Me.lblDireccionPro = New System.Windows.Forms.Label()
        Me.lblTelefonoPro = New System.Windows.Forms.Label()
        Me.mtxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblCiudadPro = New System.Windows.Forms.Label()
        Me.cbCiudadPro = New System.Windows.Forms.ComboBox()
        Me.cbProvinciaPro = New System.Windows.Forms.ComboBox()
        Me.lblProvinciaPro = New System.Windows.Forms.Label()
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.bnavAdmin = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btsAgregar = New System.Windows.Forms.ToolStripButton()
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
        Me.btsEditar = New System.Windows.Forms.ToolStripButton()
        Me.btsCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btsSalir = New System.Windows.Forms.ToolStripButton()
        Me.msProveedor.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'msProveedor
        '
        Me.msProveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.msProveedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdicionToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msProveedor.Location = New System.Drawing.Point(0, 0)
        Me.msProveedor.Name = "msProveedor"
        Me.msProveedor.Size = New System.Drawing.Size(656, 24)
        Me.msProveedor.TabIndex = 10
        Me.msProveedor.Text = "MenuStrip"
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
        'rtxtComentPro
        '
        Me.rtxtComentPro.ForeColor = System.Drawing.Color.Black
        Me.rtxtComentPro.Location = New System.Drawing.Point(333, 51)
        Me.rtxtComentPro.Name = "rtxtComentPro"
        Me.rtxtComentPro.Size = New System.Drawing.Size(265, 75)
        Me.rtxtComentPro.TabIndex = 40
        Me.rtxtComentPro.Text = ""
        '
        'dtpFechaPro
        '
        Me.dtpFechaPro.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpFechaPro.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpFechaPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPro.Location = New System.Drawing.Point(153, 80)
        Me.dtpFechaPro.Name = "dtpFechaPro"
        Me.dtpFechaPro.Size = New System.Drawing.Size(154, 23)
        Me.dtpFechaPro.TabIndex = 39
        '
        'lblFechaPro
        '
        Me.lblFechaPro.AutoSize = True
        Me.lblFechaPro.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPro.ForeColor = System.Drawing.Color.Black
        Me.lblFechaPro.Location = New System.Drawing.Point(25, 85)
        Me.lblFechaPro.Name = "lblFechaPro"
        Me.lblFechaPro.Size = New System.Drawing.Size(122, 17)
        Me.lblFechaPro.TabIndex = 38
        Me.lblFechaPro.Text = "Fecha de ingreso:"
        '
        'txtCodigoPro
        '
        Me.txtCodigoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPro.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoPro.Location = New System.Drawing.Point(153, 22)
        Me.txtCodigoPro.Name = "txtCodigoPro"
        Me.txtCodigoPro.Size = New System.Drawing.Size(154, 23)
        Me.txtCodigoPro.TabIndex = 36
        '
        'lblComentPro
        '
        Me.lblComentPro.AutoSize = True
        Me.lblComentPro.BackColor = System.Drawing.Color.Transparent
        Me.lblComentPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentPro.ForeColor = System.Drawing.Color.Black
        Me.lblComentPro.Location = New System.Drawing.Point(330, 25)
        Me.lblComentPro.Name = "lblComentPro"
        Me.lblComentPro.Size = New System.Drawing.Size(84, 17)
        Me.lblComentPro.TabIndex = 37
        Me.lblComentPro.Text = "Comentario:"
        '
        'lblCodigoPro
        '
        Me.lblCodigoPro.AutoSize = True
        Me.lblCodigoPro.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoPro.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoPro.Location = New System.Drawing.Point(88, 25)
        Me.lblCodigoPro.Name = "lblCodigoPro"
        Me.lblCodigoPro.Size = New System.Drawing.Size(56, 17)
        Me.lblCodigoPro.TabIndex = 35
        Me.lblCodigoPro.Text = "Código:"
        '
        'rtxtDireccionPro
        '
        Me.rtxtDireccionPro.ForeColor = System.Drawing.Color.Black
        Me.rtxtDireccionPro.Location = New System.Drawing.Point(153, 109)
        Me.rtxtDireccionPro.Name = "rtxtDireccionPro"
        Me.rtxtDireccionPro.Size = New System.Drawing.Size(154, 61)
        Me.rtxtDireccionPro.TabIndex = 44
        Me.rtxtDireccionPro.Text = ""
        '
        'txtNombrePro
        '
        Me.txtNombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrePro.ForeColor = System.Drawing.Color.Black
        Me.txtNombrePro.Location = New System.Drawing.Point(153, 51)
        Me.txtNombrePro.Name = "txtNombrePro"
        Me.txtNombrePro.Size = New System.Drawing.Size(154, 23)
        Me.txtNombrePro.TabIndex = 43
        '
        'lblNombrePro
        '
        Me.lblNombrePro.AutoSize = True
        Me.lblNombrePro.BackColor = System.Drawing.Color.Transparent
        Me.lblNombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePro.ForeColor = System.Drawing.Color.Black
        Me.lblNombrePro.Location = New System.Drawing.Point(82, 57)
        Me.lblNombrePro.Name = "lblNombrePro"
        Me.lblNombrePro.Size = New System.Drawing.Size(62, 17)
        Me.lblNombrePro.TabIndex = 42
        Me.lblNombrePro.Text = "Nombre:"
        '
        'lblDireccionPro
        '
        Me.lblDireccionPro.AutoSize = True
        Me.lblDireccionPro.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccionPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionPro.ForeColor = System.Drawing.Color.Black
        Me.lblDireccionPro.Location = New System.Drawing.Point(76, 109)
        Me.lblDireccionPro.Name = "lblDireccionPro"
        Me.lblDireccionPro.Size = New System.Drawing.Size(71, 17)
        Me.lblDireccionPro.TabIndex = 41
        Me.lblDireccionPro.Text = "Dirección:"
        '
        'lblTelefonoPro
        '
        Me.lblTelefonoPro.AutoSize = True
        Me.lblTelefonoPro.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefonoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoPro.ForeColor = System.Drawing.Color.Black
        Me.lblTelefonoPro.Location = New System.Drawing.Point(79, 178)
        Me.lblTelefonoPro.Name = "lblTelefonoPro"
        Me.lblTelefonoPro.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefonoPro.TabIndex = 45
        Me.lblTelefonoPro.Text = "Teléfono:"
        '
        'mtxtTelefono
        '
        Me.mtxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtTelefono.ForeColor = System.Drawing.Color.Black
        Me.mtxtTelefono.Location = New System.Drawing.Point(153, 176)
        Me.mtxtTelefono.Mask = "(999) 000-0000"
        Me.mtxtTelefono.Name = "mtxtTelefono"
        Me.mtxtTelefono.Size = New System.Drawing.Size(154, 23)
        Me.mtxtTelefono.TabIndex = 46
        Me.mtxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCiudadPro
        '
        Me.lblCiudadPro.AutoSize = True
        Me.lblCiudadPro.BackColor = System.Drawing.Color.Transparent
        Me.lblCiudadPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudadPro.ForeColor = System.Drawing.Color.Black
        Me.lblCiudadPro.Location = New System.Drawing.Point(91, 208)
        Me.lblCiudadPro.Name = "lblCiudadPro"
        Me.lblCiudadPro.Size = New System.Drawing.Size(56, 17)
        Me.lblCiudadPro.TabIndex = 47
        Me.lblCiudadPro.Text = "Ciudad:"
        '
        'cbCiudadPro
        '
        Me.cbCiudadPro.ForeColor = System.Drawing.Color.Black
        Me.cbCiudadPro.FormattingEnabled = True
        Me.cbCiudadPro.Location = New System.Drawing.Point(153, 207)
        Me.cbCiudadPro.Name = "cbCiudadPro"
        Me.cbCiudadPro.Size = New System.Drawing.Size(154, 21)
        Me.cbCiudadPro.TabIndex = 48
        '
        'cbProvinciaPro
        '
        Me.cbProvinciaPro.ForeColor = System.Drawing.Color.Black
        Me.cbProvinciaPro.FormattingEnabled = True
        Me.cbProvinciaPro.Location = New System.Drawing.Point(153, 234)
        Me.cbProvinciaPro.Name = "cbProvinciaPro"
        Me.cbProvinciaPro.Size = New System.Drawing.Size(154, 21)
        Me.cbProvinciaPro.TabIndex = 50
        '
        'lblProvinciaPro
        '
        Me.lblProvinciaPro.AutoSize = True
        Me.lblProvinciaPro.BackColor = System.Drawing.Color.Transparent
        Me.lblProvinciaPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvinciaPro.ForeColor = System.Drawing.Color.Black
        Me.lblProvinciaPro.Location = New System.Drawing.Point(74, 235)
        Me.lblProvinciaPro.Name = "lblProvinciaPro"
        Me.lblProvinciaPro.Size = New System.Drawing.Size(70, 17)
        Me.lblProvinciaPro.TabIndex = 49
        Me.lblProvinciaPro.Text = "Provincia:"
        '
        'gbProveedor
        '
        Me.gbProveedor.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbProveedor.Controls.Add(Me.cbProvinciaPro)
        Me.gbProveedor.Controls.Add(Me.lblProvinciaPro)
        Me.gbProveedor.Controls.Add(Me.cbCiudadPro)
        Me.gbProveedor.Controls.Add(Me.lblCiudadPro)
        Me.gbProveedor.Controls.Add(Me.mtxtTelefono)
        Me.gbProveedor.Controls.Add(Me.lblTelefonoPro)
        Me.gbProveedor.Controls.Add(Me.rtxtDireccionPro)
        Me.gbProveedor.Controls.Add(Me.txtNombrePro)
        Me.gbProveedor.Controls.Add(Me.lblNombrePro)
        Me.gbProveedor.Controls.Add(Me.lblDireccionPro)
        Me.gbProveedor.Controls.Add(Me.rtxtComentPro)
        Me.gbProveedor.Controls.Add(Me.dtpFechaPro)
        Me.gbProveedor.Controls.Add(Me.lblFechaPro)
        Me.gbProveedor.Controls.Add(Me.txtCodigoPro)
        Me.gbProveedor.Controls.Add(Me.lblComentPro)
        Me.gbProveedor.Controls.Add(Me.lblCodigoPro)
        Me.gbProveedor.Location = New System.Drawing.Point(20, 34)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(619, 276)
        Me.gbProveedor.TabIndex = 51
        Me.gbProveedor.TabStop = False
        '
        'bnavAdmin
        '
        Me.bnavAdmin.AddNewItem = Me.btsAgregar
        Me.bnavAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.bnavAdmin.CountItem = Me.BindingNavigatorCountItem
        Me.bnavAdmin.DeleteItem = Me.btsBorrar
        Me.bnavAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bnavAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btsBuscar, Me.ToolStripSeparator1, Me.btsPrimero, Me.btsAnterior, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.btsSiguiente, Me.btsUltimo, Me.BindingNavigatorSeparator2, Me.btsEditar, Me.btsBorrar, Me.btsAgregar, Me.btsCancelar, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.btsSalir})
        Me.bnavAdmin.Location = New System.Drawing.Point(0, 324)
        Me.bnavAdmin.MoveFirstItem = Me.btsPrimero
        Me.bnavAdmin.MoveLastItem = Me.btsUltimo
        Me.bnavAdmin.MoveNextItem = Me.btsSiguiente
        Me.bnavAdmin.MovePreviousItem = Me.btsAnterior
        Me.bnavAdmin.Name = "bnavAdmin"
        Me.bnavAdmin.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.bnavAdmin.Size = New System.Drawing.Size(656, 42)
        Me.bnavAdmin.TabIndex = 52
        Me.bnavAdmin.Text = "Navegador"
        '
        'btsAgregar
        '
        Me.btsAgregar.Enabled = False
        Me.btsAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsAgregar.Image = CType(resources.GetObject("btsAgregar.Image"), System.Drawing.Image)
        Me.btsAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsAgregar.Name = "btsAgregar"
        Me.btsAgregar.RightToLeftAutoMirrorImage = True
        Me.btsAgregar.Size = New System.Drawing.Size(55, 39)
        Me.btsAgregar.Text = "Aceptar"
        Me.btsAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.btsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
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
        Me.btsPrimero.Enabled = False
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
        Me.btsAnterior.Enabled = False
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
        Me.btsSiguiente.Enabled = False
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
        Me.btsUltimo.Enabled = False
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
        'btsCancelar
        '
        Me.btsCancelar.Enabled = False
        Me.btsCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsCancelar.Image = CType(resources.GetObject("btsCancelar.Image"), System.Drawing.Image)
        Me.btsCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(33, 39)
        Me.ToolStripButton1.Text = "Imp"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btsSalir
        '
        Me.btsSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btsSalir.Image = CType(resources.GetObject("btsSalir.Image"), System.Drawing.Image)
        Me.btsSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btsSalir.Name = "btsSalir"
        Me.btsSalir.Size = New System.Drawing.Size(35, 39)
        Me.btsSalir.Text = "Salir"
        Me.btsSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'fProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(656, 366)
        Me.Controls.Add(Me.bnavAdmin)
        Me.Controls.Add(Me.gbProveedor)
        Me.Controls.Add(Me.msProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fProveedor"
        Me.ShowIcon = False
        Me.Text = "Proveedor"
        Me.msProveedor.ResumeLayout(False)
        Me.msProveedor.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavAdmin.ResumeLayout(False)
        Me.bnavAdmin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msProveedor As System.Windows.Forms.MenuStrip
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
    Friend WithEvents rtxtComentPro As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpFechaPro As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaPro As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPro As System.Windows.Forms.TextBox
    Friend WithEvents lblComentPro As System.Windows.Forms.Label
    Friend WithEvents lblCodigoPro As System.Windows.Forms.Label
    Friend WithEvents rtxtDireccionPro As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNombrePro As System.Windows.Forms.TextBox
    Friend WithEvents lblNombrePro As System.Windows.Forms.Label
    Friend WithEvents lblDireccionPro As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoPro As System.Windows.Forms.Label
    Friend WithEvents mtxtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCiudadPro As System.Windows.Forms.Label
    Friend WithEvents cbCiudadPro As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvinciaPro As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvinciaPro As System.Windows.Forms.Label
    Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents bnavAdmin As System.Windows.Forms.BindingNavigator
    Friend WithEvents btsAgregar As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents btsEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsSalir As System.Windows.Forms.ToolStripButton
End Class
