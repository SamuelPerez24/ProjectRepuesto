Imports System.Data.OleDb
Imports System.Data
Module modVariables
    Public Ruta As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\RepuestoDB.accdb;Persist Security Info=False;"
    Public Conexion As New OleDbConnection(Ruta)
    Public DS As DataSet = New DataSet()
    Public Adap As OleDbDataAdapter

End Module
