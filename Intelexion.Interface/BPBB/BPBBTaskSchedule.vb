Imports System.Web
Imports System.Data.SqlClient
Imports Intelexion.Framework.Controller
Imports Intelexion.Framework.Model
Imports Intelexion.Framework.View
Imports Intelexion.Framework.Utilities

Namespace BPBB
    Public Class BPBBTaskSchedule
        Inherits BusinessProcess.BusinessProcessBuildingBlock

        Private results As ResultCollection
        Private presentation As PresentationEntity

        Public Overrides Function doProcess(ByVal context As HttpContext, ByVal bc As String) As Forward
            'Se trae el objeto presentation creado en el BusinessProcessHandler
            presentation = DirectCast(context.Session.Item("presentation"), PresentationEntity)

            'FormEntityMapper.map(objExperienciaLaboralArea, context.Request.Form)

            'Abre la conexion a la Base de Datos
            openDataConnection()

            Try
                Select Case bc

                    Case "ListarTareas"
                    Case Else
                        Dim err As New ErrorEntity
                        Dim mensajes As New CultureStringCollection
                        mensajes.culture = New Globalization.CultureInfo(DirectCast(context.Session.Item("LID"), String))
                        err.errorNumber = 107 ' Command Unknown
                        err.errorDescription = mensajes.GetString(104)
                        presentation.AddError(err)
                        mensajes = Nothing
                        closeDataConnection()
                        Return getForward("error")
                End Select
            Catch ex As SystemException
                closeDataConnection()
                Throw ex
            End Try
        End Function

        Public Overrides Sub addMappings()
            addMapping("Error", "/ErrorPage.aspx")
        End Sub
        Private Function checkDataForErrors(ByVal context As HttpContext) As Boolean
            Dim presentation As PresentationEntity
            Dim hasErrors As Boolean = False
            Dim err As ErrorEntity
            presentation = DirectCast(context.Session.Item("presentation"), PresentationEntity)
            If Not Me.dataconn Is Nothing Then
                hasErrors = Me.dataconn.HasErrors
                While Me.dataconn.HasErrors
                    err = New ErrorEntity
                    err.errorNumber = -1
                    err.errorDescription = Me.dataconn.getNextError
                    presentation.AddError(err)
                End While
            End If
            Return hasErrors
        End Function

        Public Overrides Sub openDataConnection()
            If MyBase.dataconn Is Nothing OrElse MyBase.dataconn.getConnection.State <> ConnectionState.Open Then
                MyBase.dataconn = SQLConnectionProvider.getConnection("framework")
                MyBase.dataconn.getConnection.Open()
            End If
        End Sub

        Public Overrides Sub addInputParameters()
        End Sub

        Public Overrides Sub addOutputParameters()
        End Sub
    End Class
End Namespace