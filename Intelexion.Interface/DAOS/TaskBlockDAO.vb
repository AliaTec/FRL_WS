Imports System.Data.SqlClient
Imports Intelexion.Framework.Model

Namespace DAOS
    Public Class TaskBlockDAO
        Inherits DAO

        Private sqlCreaBloque As String = "spa_TaskBlock '@idTask','@UID','@LID','@idAccion'"
        Private sqlProcesaBloque As String = "sp_TaskBlock '@idTask','@taskBlockId','@UID','@LID','@idAccion'"
        Private sqlCancelaBloque As String = "spb_TaskBlock '@idTask','@taskBlockId','@UID','@LID','@idAccion'"

        Public Sub New(ByVal DataConnection As SQLDataConnection)
            MyBase.New(DataConnection)
        End Sub

        Public Function CreaBloque(ByVal value As Entities.TaskBlock) As SqlDataReader
            Dim data As SqlDataReader
            Dim resultado As Boolean
            Dim comandstr As String
            comandstr = sqlCreaBloque
            resultado = Me.ExecuteQuery(comandstr, data, value)
            Return data
        End Function

        Public Function ProcesaBloque(ByVal value As Entities.TaskBlock) As SqlDataReader
            Dim data As SqlDataReader
            Dim resultado As Boolean
            Dim comandstr As String
            comandstr = sqlProcesaBloque
            resultado = Me.ExecuteQuery(comandstr, data, value)
            Return data
        End Function

        Public Function CancelaBloque(ByVal value As Entities.TaskBlock) As SqlDataReader
            Dim data As SqlDataReader
            Dim resultado As Boolean
            Dim comandstr As String
            comandstr = sqlCancelaBloque
            resultado = Me.ExecuteQuery(comandstr, data, value)
            Return data
        End Function

    End Class
End Namespace
