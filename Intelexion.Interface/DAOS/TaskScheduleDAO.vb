Imports System.Data.SqlClient
Imports Intelexion.Framework.Model

Namespace DAOS
    Public Class TaskScheduleDAO
        Inherits DAO

        Private sqlConsultaTodas As String = "spq_TaskSchedule '@UID','@LID','@idAccion'"

        Public Sub New(ByVal DataConnection As SQLDataConnection)
            MyBase.New(DataConnection)
        End Sub

        Public Function ConsultaTodas(ByVal value As Entities.TaskSchedule) As SqlDataReader
            Dim data As SqlDataReader
            Dim resultado As Boolean
            Dim comandstr As String
            comandstr = sqlConsultaTodas
            resultado = Me.ExecuteQuery(comandstr, data, value)
            Return data
        End Function

    End Class
End Namespace
