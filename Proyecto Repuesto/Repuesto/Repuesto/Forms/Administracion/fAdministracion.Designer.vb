<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAdministracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAdministracion))
        Me.bnavAdmin = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.lblCodigoAdmin = New System.Windows.Forms.Label()
        Me.lblNombreAdmin = New System.Windows.Forms.Label()
        Me.lblUsuarioAdmin = New System.Windows.Forms.Label()
        Me.lblPassAdmin = New System.Windows.Forms.Label()
        Me.lblApellidoAdmin = New System.Windows.Forms.Label()
        Me.msAdministracion = New System.Windows.Forms.MenuStrip()
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
        Me.lblTipoUserAdmin = New System.Windows.Forms.Label()
        Me.txtCodigoAdmin = New System.Windows.Forms.TextBox()
        Me.txtUserAdmin = New System.Windows.Forms.TextBox()
        Me.txtPassAdmin = New System.Windows.Forms.TextBox()
        Me.txtApellidoAdmin = New System.Windows.Forms.TextBox()
        Me.txtNombreAdmin = New System.Windows.Forms.TextBox()
        Me.txtTipoUserAdmin = New System.Windows.Forms.TextBox()
        Me.gbGenerales = New System.Windows.Forms.GroupBox()
        Me.gbDatosUserAdmin = New System.Windows.Forms.GroupBox()
        Me.cbTipoIdenAdmin = New System.Windows.Forms.ComboBox()
        Me.txtNroIdenAdmin = New System.Windows.Forms.TextBox()
        Me.lblNroIdenAdmin = New System.Windows.Forms.Label()
        Me.lblTipoIdenAdmin = New System.Windows.Forms.Label()
        Me.dsRepuesto = New Repuesto.RepuestoDBDataSet()
        Me.bsLogin = New System.Windows.Forms.BindingSource(Me.components)
        Me.TLoginTableAdapter = New Repuesto.RepuestoDBDataSetTableAdapters.tLoginTableAdapter()
        Me.bsTipoIdentificacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTipoIdentificacionTableAdapter = New Repuesto.RepuestoDBDataSetTableAdapters.tTipoIdentificacionTableAdapter()
        Me.bsTipoUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.TTipoUserTableAdapter = New Repuesto.RepuestoDBDataSetTableAdapters.tTipoUserTableAdapter()
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavAdmin.SuspendLayout()
        Me.msAdministracion.SuspendLayout()
        Me.gbGenerales.SuspendLayout()
        Me.gbDatosUserAdmin.SuspendLayout()
        CType(Me.dsRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipoIdentificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipoUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnavAdmin
        '
        Me.bnavAdmin.AddNewItem = Nothing
        Me.bnavAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.bnavAdmin.CountItem = Me.BindingNavigatorCountItem
        Me.bnavAdmin.DeleteItem = Me.btsBorrar
        Me.bnavAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bnavAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btsBuscar, Me.ToolStripSeparator1, Me.btsPrimero, Me.btsAnterior, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.btsSiguiente, Me.btsUltimo, Me.BindingNavigatorSeparator2, Me.btsNuevo, Me.btsEditar, Me.btsBorrar, Me.btsAceptar, Me.btsCancelar, Me.ToolStripSeparator2, Me.btsImprimir, Me.btsSalir})
        Me.bnavAdmin.Location = New System.Drawing.Point(0, 224)
        Me.bnavAdmin.MoveFirstItem = Me.btsPrimero
        Me.bnavAdmin.MoveLastItem = Me.btsUltimo
        Me.bnavAdmin.MoveNextItem = Me.btsSiguiente
        Me.bnavAdmin.MovePreviousItem = Me.btsAnterior
        Me.bnavAdmin.Name = "bnavAdmin"
        Me.bnavAdmin.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.bnavAdmin.Size = New System.Drawing.Size(743, 42)
        Me.bnavAdmin.TabIndex = 0
        Me.bnavAdmin.Text = "Navegador"
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
        'lblCodigoAdmin
        '
        Me.lblCodigoAdmin.AutoSize = True
        Me.lblCodigoAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigoAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoAdmin.Location = New System.Drawing.Point(84, 23)
        Me.lblCodigoAdmin.Name = "lblCodigoAdmin"
        Me.lblCodigoAdmin.Size = New System.Drawing.Size(56, 17)
        Me.lblCodigoAdmin.TabIndex = 1
        Me.lblCodigoAdmin.Text = "Código:"
        '
        'lblNombreAdmin
        '
        Me.lblNombreAdmin.AutoSize = True
        Me.lblNombreAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblNombreAdmin.Location = New System.Drawing.Point(102, 23)
        Me.lblNombreAdmin.Name = "lblNombreAdmin"
        Me.lblNombreAdmin.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreAdmin.TabIndex = 2
        Me.lblNombreAdmin.Text = "Nombre:"
        '
        'lblUsuarioAdmin
        '
        Me.lblUsuarioAdmin.AutoSize = True
        Me.lblUsuarioAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblUsuarioAdmin.Location = New System.Drawing.Point(79, 54)
        Me.lblUsuarioAdmin.Name = "lblUsuarioAdmin"
        Me.lblUsuarioAdmin.Size = New System.Drawing.Size(61, 17)
        Me.lblUsuarioAdmin.TabIndex = 3
        Me.lblUsuarioAdmin.Text = "Usuario:"
        '
        'lblPassAdmin
        '
        Me.lblPassAdmin.AutoSize = True
        Me.lblPassAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblPassAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblPassAdmin.Location = New System.Drawing.Point(55, 85)
        Me.lblPassAdmin.Name = "lblPassAdmin"
        Me.lblPassAdmin.Size = New System.Drawing.Size(85, 17)
        Me.lblPassAdmin.TabIndex = 4
        Me.lblPassAdmin.Text = "Contraseña:"
        '
        'lblApellidoAdmin
        '
        Me.lblApellidoAdmin.AutoSize = True
        Me.lblApellidoAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidoAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblApellidoAdmin.Location = New System.Drawing.Point(102, 54)
        Me.lblApellidoAdmin.Name = "lblApellidoAdmin"
        Me.lblApellidoAdmin.Size = New System.Drawing.Size(62, 17)
        Me.lblApellidoAdmin.TabIndex = 5
        Me.lblApellidoAdmin.Text = "Apellido:"
        '
        'msAdministracion
        '
        Me.msAdministracion.BackColor = System.Drawing.Color.Gainsboro
        Me.msAdministracion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdicionToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.msAdministracion.Location = New System.Drawing.Point(0, 0)
        Me.msAdministracion.Name = "msAdministracion"
        Me.msAdministracion.Size = New System.Drawing.Size(743, 24)
        Me.msAdministracion.TabIndex = 6
        Me.msAdministracion.Text = "MenuStrip"
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
        'lblTipoUserAdmin
        '
        Me.lblTipoUserAdmin.AutoSize = True
        Me.lblTipoUserAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoUserAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblTipoUserAdmin.Location = New System.Drawing.Point(29, 117)
        Me.lblTipoUserAdmin.Name = "lblTipoUserAdmin"
        Me.lblTipoUserAdmin.Size = New System.Drawing.Size(111, 17)
        Me.lblTipoUserAdmin.TabIndex = 8
        Me.lblTipoUserAdmin.Text = "Tipo de usuario:"
        '
        'txtCodigoAdmin
        '
        Me.txtCodigoAdmin.BackColor = System.Drawing.Color.White
        Me.txtCodigoAdmin.Enabled = False
        Me.txtCodigoAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoAdmin.Location = New System.Drawing.Point(146, 20)
        Me.txtCodigoAdmin.Name = "txtCodigoAdmin"
        Me.txtCodigoAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtCodigoAdmin.TabIndex = 9
        '
        'txtUserAdmin
        '
        Me.txtUserAdmin.BackColor = System.Drawing.Color.White
        Me.txtUserAdmin.Enabled = False
        Me.txtUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtUserAdmin.Location = New System.Drawing.Point(146, 51)
        Me.txtUserAdmin.Name = "txtUserAdmin"
        Me.txtUserAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtUserAdmin.TabIndex = 10
        '
        'txtPassAdmin
        '
        Me.txtPassAdmin.Enabled = False
        Me.txtPassAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtPassAdmin.Location = New System.Drawing.Point(146, 82)
        Me.txtPassAdmin.Name = "txtPassAdmin"
        Me.txtPassAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtPassAdmin.TabIndex = 11
        '
        'txtApellidoAdmin
        '
        Me.txtApellidoAdmin.Enabled = False
        Me.txtApellidoAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtApellidoAdmin.Location = New System.Drawing.Point(170, 51)
        Me.txtApellidoAdmin.Name = "txtApellidoAdmin"
        Me.txtApellidoAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtApellidoAdmin.TabIndex = 12
        '
        'txtNombreAdmin
        '
        Me.txtNombreAdmin.Enabled = False
        Me.txtNombreAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtNombreAdmin.Location = New System.Drawing.Point(170, 20)
        Me.txtNombreAdmin.Name = "txtNombreAdmin"
        Me.txtNombreAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtNombreAdmin.TabIndex = 13
        '
        'txtTipoUserAdmin
        '
        Me.txtTipoUserAdmin.Enabled = False
        Me.txtTipoUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoUserAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtTipoUserAdmin.Location = New System.Drawing.Point(146, 114)
        Me.txtTipoUserAdmin.Name = "txtTipoUserAdmin"
        Me.txtTipoUserAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtTipoUserAdmin.TabIndex = 14
        '
        'gbGenerales
        '
        Me.gbGenerales.Controls.Add(Me.txtTipoUserAdmin)
        Me.gbGenerales.Controls.Add(Me.txtPassAdmin)
        Me.gbGenerales.Controls.Add(Me.txtUserAdmin)
        Me.gbGenerales.Controls.Add(Me.txtCodigoAdmin)
        Me.gbGenerales.Controls.Add(Me.lblTipoUserAdmin)
        Me.gbGenerales.Controls.Add(Me.lblPassAdmin)
        Me.gbGenerales.Controls.Add(Me.lblUsuarioAdmin)
        Me.gbGenerales.Controls.Add(Me.lblCodigoAdmin)
        Me.gbGenerales.Location = New System.Drawing.Point(19, 39)
        Me.gbGenerales.Name = "gbGenerales"
        Me.gbGenerales.Size = New System.Drawing.Size(326, 165)
        Me.gbGenerales.TabIndex = 15
        Me.gbGenerales.TabStop = False
        '
        'gbDatosUserAdmin
        '
        Me.gbDatosUserAdmin.Controls.Add(Me.cbTipoIdenAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.txtNroIdenAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.lblNroIdenAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.lblTipoIdenAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.txtNombreAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.txtApellidoAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.lblApellidoAdmin)
        Me.gbDatosUserAdmin.Controls.Add(Me.lblNombreAdmin)
        Me.gbDatosUserAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosUserAdmin.ForeColor = System.Drawing.Color.Black
        Me.gbDatosUserAdmin.Location = New System.Drawing.Point(381, 39)
        Me.gbDatosUserAdmin.Name = "gbDatosUserAdmin"
        Me.gbDatosUserAdmin.Size = New System.Drawing.Size(350, 164)
        Me.gbDatosUserAdmin.TabIndex = 16
        Me.gbDatosUserAdmin.TabStop = False
        Me.gbDatosUserAdmin.Text = "Datos del usuario"
        '
        'cbTipoIdenAdmin
        '
        Me.cbTipoIdenAdmin.Enabled = False
        Me.cbTipoIdenAdmin.ForeColor = System.Drawing.Color.Black
        Me.cbTipoIdenAdmin.FormattingEnabled = True
        Me.cbTipoIdenAdmin.Location = New System.Drawing.Point(170, 82)
        Me.cbTipoIdenAdmin.Name = "cbTipoIdenAdmin"
        Me.cbTipoIdenAdmin.Size = New System.Drawing.Size(141, 24)
        Me.cbTipoIdenAdmin.TabIndex = 18
        Me.cbTipoIdenAdmin.ValueMember = "ttiden_Ident"
        '
        'txtNroIdenAdmin
        '
        Me.txtNroIdenAdmin.Enabled = False
        Me.txtNroIdenAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroIdenAdmin.ForeColor = System.Drawing.Color.Black
        Me.txtNroIdenAdmin.Location = New System.Drawing.Point(170, 114)
        Me.txtNroIdenAdmin.Name = "txtNroIdenAdmin"
        Me.txtNroIdenAdmin.Size = New System.Drawing.Size(141, 23)
        Me.txtNroIdenAdmin.TabIndex = 17
        '
        'lblNroIdenAdmin
        '
        Me.lblNroIdenAdmin.AutoSize = True
        Me.lblNroIdenAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblNroIdenAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroIdenAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblNroIdenAdmin.Location = New System.Drawing.Point(39, 117)
        Me.lblNroIdenAdmin.Name = "lblNroIdenAdmin"
        Me.lblNroIdenAdmin.Size = New System.Drawing.Size(125, 17)
        Me.lblNroIdenAdmin.TabIndex = 16
        Me.lblNroIdenAdmin.Text = "Nro. identificación:"
        '
        'lblTipoIdenAdmin
        '
        Me.lblTipoIdenAdmin.AutoSize = True
        Me.lblTipoIdenAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoIdenAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdenAdmin.ForeColor = System.Drawing.Color.Black
        Me.lblTipoIdenAdmin.Location = New System.Drawing.Point(18, 85)
        Me.lblTipoIdenAdmin.Name = "lblTipoIdenAdmin"
        Me.lblTipoIdenAdmin.Size = New System.Drawing.Size(146, 17)
        Me.lblTipoIdenAdmin.TabIndex = 14
        Me.lblTipoIdenAdmin.Text = "Tipo de identificación:"
        '
        'dsRepuesto
        '
        Me.dsRepuesto.DataSetName = "dsRepuesto"
        Me.dsRepuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsLogin
        '
        Me.bsLogin.DataMember = "tLogin"
        Me.bsLogin.DataSource = Me.dsRepuesto
        '
        'TLoginTableAdapter
        '
        Me.TLoginTableAdapter.ClearBeforeFill = True
        '
        'bsTipoIdentificacion
        '
        Me.bsTipoIdentificacion.DataMember = "tTipoIdentificacion"
        Me.bsTipoIdentificacion.DataSource = Me.dsRepuesto
        '
        'TTipoIdentificacionTableAdapter
        '
        Me.TTipoIdentificacionTableAdapter.ClearBeforeFill = True
        '
        'bsTipoUser
        '
        Me.bsTipoUser.DataMember = "tTipoUser"
        Me.bsTipoUser.DataSource = Me.dsRepuesto
        '
        'TTipoUserTableAdapter
        '
        Me.TTipoUserTableAdapter.ClearBeforeFill = True
        '
        'fAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(743, 266)
        Me.Controls.Add(Me.gbDatosUserAdmin)
        Me.Controls.Add(Me.gbGenerales)
        Me.Controls.Add(Me.bnavAdmin)
        Me.Controls.Add(Me.msAdministracion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fAdministracion"
        Me.ShowIcon = False
        Me.Text = "Administracion"
        CType(Me.bnavAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavAdmin.ResumeLayout(False)
        Me.bnavAdmin.PerformLayout()
        Me.msAdministracion.ResumeLayout(False)
        Me.msAdministracion.PerformLayout()
        Me.gbGenerales.ResumeLayout(False)
        Me.gbGenerales.PerformLayout()
        Me.gbDatosUserAdmin.ResumeLayout(False)
        Me.gbDatosUserAdmin.PerformLayout()
        CType(Me.dsRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipoIdentificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipoUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnavAdmin As System.Windows.Forms.BindingNavigator
    Friend WithEvents btsAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btsBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btsCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btsSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCodigoAdmin As System.Windows.Forms.Label
    Friend WithEvents lblNombreAdmin As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioAdmin As System.Windows.Forms.Label
    Friend WithEvents lblPassAdmin As System.Windows.Forms.Label
    Friend WithEvents lblApellidoAdmin As System.Windows.Forms.Label
    Friend WithEvents msAdministracion As System.Windows.Forms.MenuStrip
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
    Friend WithEvents lblTipoUserAdmin As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtUserAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreAdmin As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoUserAdmin As System.Windows.Forms.TextBox
    Friend WithEvents gbGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatosUserAdmin As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoIdenAdmin As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroIdenAdmin As System.Windows.Forms.TextBox
    Friend WithEvents lblNroIdenAdmin As System.Windows.Forms.Label
    Friend WithEvents lblTipoIdenAdmin As System.Windows.Forms.Label
    Friend WithEvents btsImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btsNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents dsRepuesto As Repuesto.RepuestoDBDataSet
    Friend WithEvents bsLogin As System.Windows.Forms.BindingSource
    Friend WithEvents TLoginTableAdapter As Repuesto.RepuestoDBDataSetTableAdapters.tLoginTableAdapter
    Friend WithEvents bsTipoIdentificacion As System.Windows.Forms.BindingSource
    Friend WithEvents TTipoIdentificacionTableAdapter As Repuesto.RepuestoDBDataSetTableAdapters.tTipoIdentificacionTableAdapter
    Friend WithEvents bsTipoUser As System.Windows.Forms.BindingSource
    Friend WithEvents TTipoUserTableAdapter As Repuesto.RepuestoDBDataSetTableAdapters.tTipoUserTableAdapter
End Class
