<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMenuPrincipal
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblNombre = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblUser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblCargo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFecha = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.msMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsAdministrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsInventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsFacturacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.msMenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.lblNombre, Me.ToolStripSeparator2, Me.lblUser, Me.ToolStripSeparator3, Me.lblCargo, Me.ToolStripSeparator4, Me.lblFecha, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 676)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1108, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(331, 22)
        Me.ToolStripLabel1.Text = "                                                                                 " & _
    "                           "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.Color.Navy
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 22)
        Me.lblNombre.Text = "Nombre"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.ForeColor = System.Drawing.Color.Navy
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(60, 22)
        Me.lblUser.Text = "Usuario"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'lblCargo
        '
        Me.lblCargo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCargo.ForeColor = System.Drawing.Color.Navy
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(50, 22)
        Me.lblCargo.Text = "Cargo"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.ForeColor = System.Drawing.Color.Navy
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 22)
        Me.lblFecha.Text = "Fecha"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'msMenuPrincipal
        '
        Me.msMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAdministrador, Me.tsInventario, Me.tsProveedor, Me.tsFacturacion, Me.tsSalida})
        Me.msMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msMenuPrincipal.Name = "msMenuPrincipal"
        Me.msMenuPrincipal.Size = New System.Drawing.Size(1108, 27)
        Me.msMenuPrincipal.TabIndex = 1
        Me.msMenuPrincipal.Text = "MenuStrip1"
        '
        'tsAdministrador
        '
        Me.tsAdministrador.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsAdministrador.ForeColor = System.Drawing.Color.Navy
        Me.tsAdministrador.Name = "tsAdministrador"
        Me.tsAdministrador.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsAdministrador.Size = New System.Drawing.Size(204, 23)
        Me.tsAdministrador.Text = "&Administración de Usuarios"
        '
        'tsInventario
        '
        Me.tsInventario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsInventario.ForeColor = System.Drawing.Color.Navy
        Me.tsInventario.Name = "tsInventario"
        Me.tsInventario.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.tsInventario.Size = New System.Drawing.Size(89, 23)
        Me.tsInventario.Text = "&Inventario"
        '
        'tsProveedor
        '
        Me.tsProveedor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsProveedor.ForeColor = System.Drawing.Color.Navy
        Me.tsProveedor.Name = "tsProveedor"
        Me.tsProveedor.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsProveedor.Size = New System.Drawing.Size(93, 23)
        Me.tsProveedor.Text = "&Proveedor"
        '
        'tsFacturacion
        '
        Me.tsFacturacion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsFacturacion.ForeColor = System.Drawing.Color.Navy
        Me.tsFacturacion.Name = "tsFacturacion"
        Me.tsFacturacion.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsFacturacion.Size = New System.Drawing.Size(98, 23)
        Me.tsFacturacion.Text = "&Facturación"
        '
        'tsSalida
        '
        Me.tsSalida.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsSalida.ForeColor = System.Drawing.Color.Navy
        Me.tsSalida.Name = "tsSalida"
        Me.tsSalida.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsSalida.Size = New System.Drawing.Size(62, 23)
        Me.tsSalida.Text = "&Salida"
        '
        'fMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1108, 701)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.msMenuPrincipal)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fMenuPrincipal"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal - Repuesto"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.msMenuPrincipal.ResumeLayout(False)
        Me.msMenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblNombre As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblCargo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents msMenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents tsAdministrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsInventario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsProveedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsFacturacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSalida As System.Windows.Forms.ToolStripMenuItem
End Class
