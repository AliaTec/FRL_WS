Imports System.Data.SqlClient
Imports Intelexion.Framework.Model

Namespace DAOS
    Public Class TaskDAO
        Inherits DAO


        Public Sub New(ByVal DataConnection As SQLDataConnection)
            MyBase.New(DataConnection)
        End Sub

    End Class
End Namespace
