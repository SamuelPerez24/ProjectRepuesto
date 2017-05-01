Public Class fAdministracion
#Region "Variables"
    Private proBuscar As Boolean = True
    Private proEditar As Boolean = True
    Private proNuevo As Boolean = True
    Private proEliminar As Boolean = True
    Private proImp As Boolean = True
#End Region
#Region "Métodos privados"
    Private Sub LimpiarTextbox()
        Me.txtCodigoAdmin.Clear()
        Me.txtApellidoAdmin.Clear()
        Me.txtNombreAdmin.Clear()
        Me.txtNroIdenAdmin.Clear()
        Me.txtPassAdmin.Clear()
        Me.txtTipoUserAdmin.Clear()
        Me.txtUserAdmin.Clear()
    End Sub
    Private Sub DesactivarControlesMan()
        Me.btsBuscar.Enabled = False
        Me.btsEditar.Enabled = False
        Me.btsBorrar.Enabled = False
        Me.btsImprimir.Enabled = False
        Me.btsNuevo.Enabled = False
    End Sub
    Private Sub ActivarControlesMan()
        Me.btsBuscar.Enabled = True
        Me.btsEditar.Enabled = True
        Me.btsBorrar.Enabled = True
        Me.btsImprimir.Enabled = True
        Me.btsNuevo.Enabled = True
    End Sub
#End Region
#Region "Eventos del botón ACEPTAR"
    Private Sub AceptarBuscar()
        ActivarControlesMan()
        'Se desactivan los controles.
        Me.btsAceptar.Enabled = False
        Me.btsCancelar.Enabled = False
        Me.proBuscar = False
    End Sub
    Private Sub AceptarEditar()

    End Sub
    Private Sub AceptarEliminar()

    End Sub
    Private Sub AceptarNuevo()

    End Sub
#End Region

    Private Sub btsBuscar_Click(sender As Object, e As EventArgs) Handles btsBuscar.Click
        Me.btsBuscar.Enabled = False
        'Activando los controles a utilizar en el botón de buscar.

        With Me.txtUserAdmin
            .Enabled = True
            .BackColor = Color.AliceBlue
        End With

        LimpiarTextbox()

        Me.btsAceptar.Enabled = True
        Me.btsCancelar.Enabled = True
        Me.proBuscar = True

        DesactivarControlesMan()
    End Sub

    Private Sub btsAceptar_Click(sender As Object, e As EventArgs) Handles btsAceptar.Click
        If Not Me.proBuscar = False Then
            AceptarBuscar()
            Me.txtUserAdmin.BackColor = Color.White
        End If
    End Sub

    Private Sub btsEditar_Click(sender As Object, e As EventArgs) Handles btsEditar.Click
        Me.btsEditar.Enabled = False
        Me.btsBuscar.Enabled = False
    End Sub

    Private Sub btsCancelar_Click(sender As Object, e As EventArgs) Handles btsCancelar.Click
        LimpiarTextbox()
        DesactivarControlesMan()
        Me.btsCancelar.Enabled = False
        Me.btsAceptar.Enabled = False
        Me.btsBuscar.Enabled = True
        Me.proBuscar = True
    End Sub

    Private Sub btsSalir_Click(sender As Object, e As EventArgs) Handles btsSalir.Click
        Me.Close()
    End Sub

    Private Sub fAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsAdministracion.tTipoIdentificacion' table. You can move, or remove it, as needed.
        Me.TTipoIdentificacionTableAdapter.Fill(Me.dsAdministracion.tTipoIdentificacion)
        'TODO: This line of code loads data into the 'dsAdministracion.tFactura' table. You can move, or remove it, as needed.
        Me.TFacturaTableAdapter.Fill(Me.dsAdministracion.tFactura)
        'TODO: This line of code loads data into the 'dsAdministracion.tDetalleFactura' table. You can move, or remove it, as needed.
        Me.TDetalleFacturaTableAdapter.Fill(Me.dsAdministracion.tDetalleFactura)

    End Sub

    Private Sub btsSiguiente_Click(sender As Object, e As EventArgs) Handles btsSiguiente.Click

    End Sub
End Class