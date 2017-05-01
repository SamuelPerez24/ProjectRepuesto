Imports System.Data
Imports QuerysConDBlibrary.QuerysClass
Imports System.Data.OleDb
Imports Repuesto.ConexionClass


Public Class fLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            Conectar()
            Dim Com As New OleDbCommand("SELECT * FROM tLogin WHERE tlog_user='" & txtUsername.Text.Trim() & "' AND tlog_password= '" & txtPassword.Text.Trim() & "' ", Conexion)
            Dim Reader As OleDbDataReader
            Reader = Com.ExecuteReader()

            If Reader.HasRows = True Then
                Do While Reader.Read()
                    Me.Close()
                    fMenuPrincipal.Enabled = True
                Loop
            Else
                Throw New Exception("ERROR AL TRATAR DE INGRESAR AL SISTEMA, USUARIO/CONTRASEÑA INVALIDO")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
            Desconectar()
        Catch ex As Exception
            Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
