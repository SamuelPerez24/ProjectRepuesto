Imports System.Data.OleDb
Imports System.Data
Public Class QuerysClass
#Region "Select"
    Public Sub Seleccionar(Sql As String, Tabla As String)
        Try
            Try
                If Not Conexion.State = ConnectionState.Open Then
                    Conexion.Open()
                End If
            Catch ex As Exception
                Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
            End Try

            DS.Clear()
            Adap = New OleDbDataAdapter(Sql, Conexion)
            Dim Com As New OleDbCommandBuilder(Adap)
            Adap.Fill(DS, Tabla)

            Conexion.Close()

        Catch ex As Exception
            Throw New Exception("ERROR AL TRATAR DE SELECCIONAR LOS DATOS,#5006: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub
#End Region
#Region "Insert"
    Public Function Insertar(Sql As String) As Boolean
        Try
            Try
                If Not Conexion.State = ConnectionState.Open Then
                    Conexion.Open()
                End If
            Catch ex As Exception
                Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
            End Try

            Dim Com As New OleDbCommand(Sql, Conexion)
            Dim Conteo As Integer = Com.ExecuteNonQuery()
            Conexion.Close()

            If Conteo > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception("ERROR AL TRATAR DE INSERTAR LOS DATOS,#5007: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Function
#End Region
#Region "Update"
    Public Function Actualizar(Tabla As String, Campos As String, Condicion As String) As Boolean
        Try
            Try
                If Not Conexion.State = ConnectionState.Open Then
                    Conexion.Open()
                End If
            Catch ex As Exception
                Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
            End Try

            Dim Sql As String = "UPDATE " & Tabla & " SET " & Campos & " WHERE " & Condicion
            Dim Com As New OleDbCommand(Sql, Conexion)
            Dim Conteo As Integer = Com.ExecuteNonQuery()
            Conexion.Close()

            If Conteo > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception("ERROR AL TRATAR DE ACTUALIZAR LOS DATOS,#5008: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Function
#End Region
#Region "Delete"
    Public Function Borrar(Tabla As String, Condicion As String)
        Try
            Try
                If Not Conexion.State = ConnectionState.Open Then
                    Conexion.Open()
                End If
            Catch ex As Exception
                Throw New Exception("ERROR AL CONECTAR CON LA BASE DE DATOS,#TimeOut: " & ex.Message)
            End Try

            Dim Sql As String = "DELETE FROM " & Tabla & " WHERE " & Condicion
            Dim Com As New OleDbCommand(Sql, Conexion)
            Dim Conteo As Integer = Com.ExecuteNonQuery()

            Conexion.Close()
            If Conteo > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw New Exception("ERROR AL TRATAR DE BORRAR LOS DATOS,#5009: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Function
#End Region
End Class
