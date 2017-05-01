<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInventario))
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
        Me.lblComentInv = New System.Windows.Forms.Label()
        Me.txtIdProveedorInv = New System.Windows.Forms.TextBox()
        Me.txtCantMaxInv = New System.Windows.Forms.TextBox()
        Me.lblCantMaxInv = New System.Windows.Forms.Label()
        Me.txtCantMinInv = New System.Windows.Forms.TextBox()
        Me.lblCantMinInv = New System.Windows.Forms.Label()
        Me.txtCostoInv = New System.Windows.Forms.TextBox()
        Me.lblCostoInv = New System.Windows.Forms.Label()
        Me.txtPrecioInv = New System.Windows.Forms.TextBox()
        Me.lblPrecioInv = New System.Windows.Forms.Label()
        Me.lblFechaInv = New System.Windows.Forms.Label()
        Me.txtTipoInv = New System.Windows.Forms.TextBox()
        Me.lblTipoInv = New System.Windows.Forms.Label()
        Me.lblDescripcionInv = New System.Windows.Forms.Label()
        Me.txtNombreInv = New System.Windows.Forms.TextBox()
        Me.lblNombreInv = New System.Windows.Forms.Label()
        Me.dtpFechaInv = New System.Windows.Forms.DateTimePicker()
        Me.rtxtDescripcionInv = New System.Windows.Forms.RichTextBox()
        Me.gbDatosGralinv = New System.Windows.Forms.GroupBox()
        Me.lblCodProveedor = New System.Windows.Forms.LinkLabel()
        Me.gbDetInv = New System.Windows.Forms.GroupBox()
        Me.rtxtComentInv = New System.Windows.Forms.RichTextBox()
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
        Me.msInventario.SuspendLayout()
        Me.gbDatosGralinv.SuspendLayout()
        Me.gbDetInv.SuspendLayout()
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'msInventario
        '
        Me.msInventario.BackColor = System.Drawing.Color.Gainsboro
        Me.msInventario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdicionToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msInventario.Location = New System.Drawing.Point(0, 0)
        Me.msInventario.Name = "msInventario"
        Me.msInventario.Size = New System.Drawing.Size(685, 24)
        Me.msInventario.TabIndex = 8
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
        Me.txtCodigoInv.Location = New System.Drawing.Point(151, 24)
        Me.txtCodigoInv.Name = "txtCodigoInv"
        Me.txtCodigoInv.Size = New System.Drawing.Size(154, 23)
        Me.txtCodigoInv.TabIndex = 11
        '
        'lblCodigoInv
        '
        Me.lblCodigoInv.AutoSize = True
        Me.lblCodigoInv.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoInv.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoInv.Location = New System.Drawing.Point(89, 27)
        Me.lblCodigoInv.Name = "lblCodigoInv"
        Me.lblCodigoInv.Size = New System.Drawing.Size(56, 17)
        Me.lblCodigoInv.TabIndex = 10
        Me.lblCodigoInv.Text = "Código:"
        '
        'lblComentInv
        '
        Me.lblComentInv.AutoSize = True
        Me.lblComentInv.BackColor = System.Drawing.Color.Transparent
        Me.lblComentInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentInv.ForeColor = System.Drawing.Color.Black
        Me.lblComentInv.Location = New System.Drawing.Point(358, 244)
        Me.lblComentInv.Name = "lblComentInv"
        Me.lblComentInv.Size = New System.Drawing.Size(84, 17)
        Me.lblComentInv.TabIndex = 12
        Me.lblComentInv.Text = "Comentario:"
        '
        'txtIdProveedorInv
        '
        Me.txtIdProveedorInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedorInv.ForeColor = System.Drawing.Color.Black
        Me.txtIdProveedorInv.Location = New System.Drawing.Point(150, 159)
        Me.txtIdProveedorInv.Name = "txtIdProveedorInv"
        Me.txtIdProveedorInv.Size = New System.Drawing.Size(141, 23)
        Me.txtIdProveedorInv.TabIndex = 15
        '
        'txtCantMaxInv
        '
        Me.txtCantMaxInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantMaxInv.ForeColor = System.Drawing.Color.Black
        Me.txtCantMaxInv.Location = New System.Drawing.Point(150, 121)
        Me.txtCantMaxInv.Name = "txtCantMaxInv"
        Me.txtCantMaxInv.Size = New System.Drawing.Size(141, 23)
        Me.txtCantMaxInv.TabIndex = 17
        '
        'lblCantMaxInv
        '
        Me.lblCantMaxInv.AutoSize = True
        Me.lblCantMaxInv.BackColor = System.Drawing.Color.Transparent
        Me.lblCantMaxInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantMaxInv.ForeColor = System.Drawing.Color.Black
        Me.lblCantMaxInv.Location = New System.Drawing.Point(48, 124)
        Me.lblCantMaxInv.Name = "lblCantMaxInv"
        Me.lblCantMaxInv.Size = New System.Drawing.Size(96, 17)
        Me.lblCantMaxInv.TabIndex = 16
        Me.lblCantMaxInv.Text = "Cant. máxima:"
        '
        'txtCantMinInv
        '
        Me.txtCantMinInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantMinInv.ForeColor = System.Drawing.Color.Black
        Me.txtCantMinInv.Location = New System.Drawing.Point(150, 89)
        Me.txtCantMinInv.Name = "txtCantMinInv"
        Me.txtCantMinInv.Size = New System.Drawing.Size(141, 23)
        Me.txtCantMinInv.TabIndex = 19
        '
        'lblCantMinInv
        '
        Me.lblCantMinInv.AutoSize = True
        Me.lblCantMinInv.BackColor = System.Drawing.Color.Transparent
        Me.lblCantMinInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantMinInv.ForeColor = System.Drawing.Color.Black
        Me.lblCantMinInv.Location = New System.Drawing.Point(51, 92)
        Me.lblCantMinInv.Name = "lblCantMinInv"
        Me.lblCantMinInv.Size = New System.Drawing.Size(93, 17)
        Me.lblCantMinInv.TabIndex = 18
        Me.lblCantMinInv.Text = "Cant. miníma:"
        '
        'txtCostoInv
        '
        Me.txtCostoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoInv.ForeColor = System.Drawing.Color.Black
        Me.txtCostoInv.Location = New System.Drawing.Point(150, 55)
        Me.txtCostoInv.Name = "txtCostoInv"
        Me.txtCostoInv.Size = New System.Drawing.Size(141, 23)
        Me.txtCostoInv.TabIndex = 21
        '
        'lblCostoInv
        '
        Me.lblCostoInv.AutoSize = True
        Me.lblCostoInv.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoInv.ForeColor = System.Drawing.Color.Black
        Me.lblCostoInv.Location = New System.Drawing.Point(96, 58)
        Me.lblCostoInv.Name = "lblCostoInv"
        Me.lblCostoInv.Size = New System.Drawing.Size(48, 17)
        Me.lblCostoInv.TabIndex = 20
        Me.lblCostoInv.Text = "Costo:"
        '
        'txtPrecioInv
        '
        Me.txtPrecioInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioInv.ForeColor = System.Drawing.Color.Black
        Me.txtPrecioInv.Location = New System.Drawing.Point(150, 22)
        Me.txtPrecioInv.Name = "txtPrecioInv"
        Me.txtPrecioInv.Size = New System.Drawing.Size(141, 23)
        Me.txtPrecioInv.TabIndex = 23
        '
        'lblPrecioInv
        '
        Me.lblPrecioInv.AutoSize = True
        Me.lblPrecioInv.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioInv.ForeColor = System.Drawing.Color.Black
        Me.lblPrecioInv.Location = New System.Drawing.Point(41, 25)
        Me.lblPrecioInv.Name = "lblPrecioInv"
        Me.lblPrecioInv.Size = New System.Drawing.Size(103, 17)
        Me.lblPrecioInv.TabIndex = 22
        Me.lblPrecioInv.Text = "Precio unitario:"
        '
        'lblFechaInv
        '
        Me.lblFechaInv.AutoSize = True
        Me.lblFechaInv.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInv.ForeColor = System.Drawing.Color.Black
        Me.lblFechaInv.Location = New System.Drawing.Point(16, 126)
        Me.lblFechaInv.Name = "lblFechaInv"
        Me.lblFechaInv.Size = New System.Drawing.Size(129, 17)
        Me.lblFechaInv.TabIndex = 24
        Me.lblFechaInv.Text = "Fecha de creación:"
        '
        'txtTipoInv
        '
        Me.txtTipoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoInv.ForeColor = System.Drawing.Color.Black
        Me.txtTipoInv.Location = New System.Drawing.Point(151, 91)
        Me.txtTipoInv.Name = "txtTipoInv"
        Me.txtTipoInv.Size = New System.Drawing.Size(154, 23)
        Me.txtTipoInv.TabIndex = 27
        '
        'lblTipoInv
        '
        Me.lblTipoInv.AutoSize = True
        Me.lblTipoInv.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoInv.ForeColor = System.Drawing.Color.Black
        Me.lblTipoInv.Location = New System.Drawing.Point(105, 94)
        Me.lblTipoInv.Name = "lblTipoInv"
        Me.lblTipoInv.Size = New System.Drawing.Size(40, 17)
        Me.lblTipoInv.TabIndex = 26
        Me.lblTipoInv.Text = "Tipo:"
        '
        'lblDescripcionInv
        '
        Me.lblDescripcionInv.AutoSize = True
        Me.lblDescripcionInv.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcionInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionInv.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcionInv.Location = New System.Drawing.Point(59, 164)
        Me.lblDescripcionInv.Name = "lblDescripcionInv"
        Me.lblDescripcionInv.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcionInv.TabIndex = 28
        Me.lblDescripcionInv.Text = "Descripción:"
        '
        'txtNombreInv
        '
        Me.txtNombreInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreInv.ForeColor = System.Drawing.Color.Black
        Me.txtNombreInv.Location = New System.Drawing.Point(151, 57)
        Me.txtNombreInv.Name = "txtNombreInv"
        Me.txtNombreInv.Size = New System.Drawing.Size(154, 23)
        Me.txtNombreInv.TabIndex = 31
        '
        'lblNombreInv
        '
        Me.lblNombreInv.AutoSize = True
        Me.lblNombreInv.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInv.ForeColor = System.Drawing.Color.Black
        Me.lblNombreInv.Location = New System.Drawing.Point(83, 60)
        Me.lblNombreInv.Name = "lblNombreInv"
        Me.lblNombreInv.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreInv.TabIndex = 30
        Me.lblNombreInv.Text = "Nombre:"
        '
        'dtpFechaInv
        '
        Me.dtpFechaInv.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpFechaInv.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpFechaInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInv.Location = New System.Drawing.Point(151, 128)
        Me.dtpFechaInv.Name = "dtpFechaInv"
        Me.dtpFechaInv.Size = New System.Drawing.Size(154, 23)
        Me.dtpFechaInv.TabIndex = 32
        '
        'rtxtDescripcionInv
        '
        Me.rtxtDescripcionInv.ForeColor = System.Drawing.Color.Black
        Me.rtxtDescripcionInv.Location = New System.Drawing.Point(151, 163)
        Me.rtxtDescripcionInv.Name = "rtxtDescripcionInv"
        Me.rtxtDescripcionInv.Size = New System.Drawing.Size(154, 61)
        Me.rtxtDescripcionInv.TabIndex = 33
        Me.rtxtDescripcionInv.Text = ""
        '
        'gbDatosGralinv
        '
        Me.gbDatosGralinv.Controls.Add(Me.rtxtDescripcionInv)
        Me.gbDatosGralinv.Controls.Add(Me.dtpFechaInv)
        Me.gbDatosGralinv.Controls.Add(Me.txtNombreInv)
        Me.gbDatosGralinv.Controls.Add(Me.lblNombreInv)
        Me.gbDatosGralinv.Controls.Add(Me.lblDescripcionInv)
        Me.gbDatosGralinv.Controls.Add(Me.txtTipoInv)
        Me.gbDatosGralinv.Controls.Add(Me.lblTipoInv)
        Me.gbDatosGralinv.Controls.Add(Me.lblFechaInv)
        Me.gbDatosGralinv.Controls.Add(Me.txtCodigoInv)
        Me.gbDatosGralinv.Controls.Add(Me.lblCodigoInv)
        Me.gbDatosGralinv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGralinv.ForeColor = System.Drawing.Color.Black
        Me.gbDatosGralinv.Location = New System.Drawing.Point(5, 37)
        Me.gbDatosGralinv.Name = "gbDatosGralinv"
        Me.gbDatosGralinv.Size = New System.Drawing.Size(331, 258)
        Me.gbDatosGralinv.TabIndex = 34
        Me.gbDatosGralinv.TabStop = False
        Me.gbDatosGralinv.Text = "Datos generales del producto"
        '
        'lblCodProveedor
        '
        Me.lblCodProveedor.AutoSize = True
        Me.lblCodProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblCodProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodProveedor.ForeColor = System.Drawing.Color.Black
        Me.lblCodProveedor.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCodProveedor.Location = New System.Drawing.Point(19, 162)
        Me.lblCodProveedor.Name = "lblCodProveedor"
        Me.lblCodProveedor.Size = New System.Drawing.Size(125, 17)
        Me.lblCodProveedor.TabIndex = 35
        Me.lblCodProveedor.TabStop = True
        Me.lblCodProveedor.Text = "Código proveedor:"
        '
        'gbDetInv
        '
        Me.gbDetInv.Controls.Add(Me.lblCodProveedor)
        Me.gbDetInv.Controls.Add(Me.txtPrecioInv)
        Me.gbDetInv.Controls.Add(Me.lblPrecioInv)
        Me.gbDetInv.Controls.Add(Me.txtCostoInv)
        Me.gbDetInv.Controls.Add(Me.lblCostoInv)
        Me.gbDetInv.Controls.Add(Me.txtCantMinInv)
        Me.gbDetInv.Controls.Add(Me.lblCantMinInv)
        Me.gbDetInv.Controls.Add(Me.txtCantMaxInv)
        Me.gbDetInv.Controls.Add(Me.lblCantMaxInv)
        Me.gbDetInv.Controls.Add(Me.txtIdProveedorInv)
        Me.gbDetInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetInv.ForeColor = System.Drawing.Color.Black
        Me.gbDetInv.Location = New System.Drawing.Point(361, 39)
        Me.gbDetInv.Name = "gbDetInv"
        Me.gbDetInv.Size = New System.Drawing.Size(312, 194)
        Me.gbDetInv.TabIndex = 36
        Me.gbDetInv.TabStop = False
        Me.gbDetInv.Text = "Detalle de producto"
        '
        'rtxtComentInv
        '
        Me.rtxtComentInv.ForeColor = System.Drawing.Color.Black
        Me.rtxtComentInv.Location = New System.Drawing.Point(443, 241)
        Me.rtxtComentInv.Name = "rtxtComentInv"
        Me.rtxtComentInv.Size = New System.Drawing.Size(230, 54)
        Me.rtxtComentInv.TabIndex = 34
        Me.rtxtComentInv.Text = ""
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
        Me.bnavAdmin.Location = New System.Drawing.Point(0, 308)
        Me.bnavAdmin.MoveFirstItem = Me.btsPrimero
        Me.bnavAdmin.MoveLastItem = Me.btsUltimo
        Me.bnavAdmin.MoveNextItem = Me.btsSiguiente
        Me.bnavAdmin.MovePreviousItem = Me.btsAnterior
        Me.bnavAdmin.Name = "bnavAdmin"
        Me.bnavAdmin.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.bnavAdmin.Size = New System.Drawing.Size(685, 42)
        Me.bnavAdmin.TabIndex = 37
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
        'fInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(685, 350)
        Me.Controls.Add(Me.bnavAdmin)
        Me.Controls.Add(Me.rtxtComentInv)
        Me.Controls.Add(Me.gbDetInv)
        Me.Controls.Add(Me.gbDatosGralinv)
        Me.Controls.Add(Me.lblComentInv)
        Me.Controls.Add(Me.msInventario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fInventario"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Inventario"
        Me.msInventario.ResumeLayout(False)
        Me.msInventario.PerformLayout()
        Me.gbDatosGralinv.ResumeLayout(False)
        Me.gbDatosGralinv.PerformLayout()
        Me.gbDetInv.ResumeLayout(False)
        Me.gbDetInv.PerformLayout()
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavAdmin.ResumeLayout(False)
        Me.bnavAdmin.PerformLayout()
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
    Friend WithEvents lblComentInv As System.Windows.Forms.Label
    Friend WithEvents txtIdProveedorInv As System.Windows.Forms.TextBox
    Friend WithEvents txtCantMaxInv As System.Windows.Forms.TextBox
    Friend WithEvents lblCantMaxInv As System.Windows.Forms.Label
    Friend WithEvents txtCantMinInv As System.Windows.Forms.TextBox
    Friend WithEvents lblCantMinInv As System.Windows.Forms.Label
    Friend WithEvents txtCostoInv As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoInv As System.Windows.Forms.Label
    Friend WithEvents txtPrecioInv As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioInv As System.Windows.Forms.Label
    Friend WithEvents lblFechaInv As System.Windows.Forms.Label
    Friend WithEvents txtTipoInv As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoInv As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionInv As System.Windows.Forms.Label
    Friend WithEvents txtNombreInv As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreInv As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInv As System.Windows.Forms.DateTimePicker
    Friend WithEvents rtxtDescripcionInv As System.Windows.Forms.RichTextBox
    Friend WithEvents gbDatosGralinv As System.Windows.Forms.GroupBox
    Friend WithEvents lblCodProveedor As System.Windows.Forms.LinkLabel
    Friend WithEvents gbDetInv As System.Windows.Forms.GroupBox
    Friend WithEvents rtxtComentInv As System.Windows.Forms.RichTextBox
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
