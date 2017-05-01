Public Class ConexionClass
    Public Shared Sub Conectar()
        Try
            If Not Conexion.State = ConnectionState.Open Then
                Conexion.Open()
            End If
        Catch ex As Exception
            Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
        End Try
    End Sub
    Public Shared Sub Desconectar()
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ERROR AL TRATAR DE DESCONECTAR LA BASE DE DATOS,#5005: " & ex.Message)
        End Try
    End Sub
End Class
