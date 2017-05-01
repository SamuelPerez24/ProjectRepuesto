Imports System.Data
Imports Repuesto

Public Class fMenuPrincipal

    Dim mdiChildForm As New Form

    Private Sub fMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fLogin.Show()

        IsMdiContainer = True
        mdiChildForm.MdiParent = Me
        FondoMDI()
    End Sub
    'Método para cambiar fondo del MDI Container
    Private Sub FondoMDI()
        Dim Cont As Control
        For Each Cont In Me.Controls
            If TypeOf (Cont) Is MdiClient Then
                Cont.BackColor = System.Drawing.Color.White
            End If
        Next
    End Sub

    Private Sub tsSalida_Click(sender As Object, e As EventArgs) Handles tsSalida.Click
        Application.Exit()
    End Sub

    Private Sub tsAdministrador_Click(sender As Object, e As EventArgs) Handles tsAdministrador.Click
        fAdministracion.MdiParent = Me
        fAdministracion.Show()
    End Sub

    Private Sub tsInventario_Click(sender As Object, e As EventArgs) Handles tsInventario.Click
        fInventario.MdiParent = Me
        fInventario.Show()
    End Sub

    Private Sub tsProveedor_Click(sender As Object, e As EventArgs) Handles tsProveedor.Click
        fProveedor.MdiParent = Me
        fProveedor.Show()
    End Sub

    Private Sub tsFacturacion_Click(sender As Object, e As EventArgs) Handles tsFacturacion.Click
        fFacturacion.MdiParent = Me
        fFacturacion.Show()
    End Sub
End Class