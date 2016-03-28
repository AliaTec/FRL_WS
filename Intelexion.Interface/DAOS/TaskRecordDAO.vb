Imports System.Data.SqlClient
Imports Intelexion.Framework.Model

Namespace DAOS
    Public Class TaskRecordDAO
        Inherits DAO

        Private sqlAlta As String = "spa_TaskRecord '@idTask','@taskBlockId','@data','@status','@UID','@LID','@idAccion'"
        Private sqlConsulta As String = "spq_TaskRecord '@idTask','@taskBlockId','@UID','@LID','@idAccion'"

        Public Sub New(ByVal DataConnection As SQLDataConnection)
            MyBase.New(DataConnection)
        End Sub

        Public Function Alta(ByVal value As Entities.TaskRecord) As Boolean
            Dim resultado As Boolean
            Dim comandstr As String
            comandstr = sqlAlta
            resultado = Me.executeNonQuery(comandstr, value)
            Return resultado
        End Function

        Public Function Consulta(ByVal value As Entities.TaskRecord) As SqlDataReader
            Dim resultado As Boolean
            Dim data As SqlDataReader
            Dim comandstr As String
            comandstr = sqlConsulta
            resultado = Me.ExecuteQuery(comandstr, data, value)
            Return data
        End Function

    End Class
End Namespace
