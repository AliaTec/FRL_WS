
Imports Intelexion.Framework.Model
Imports System.Xml.Serialization
Imports System.IO

Namespace Entities
        <XmlRootAttribute("Task", _
         Namespace:="http://www.intelexion.com/", IsNullable:=False)> _
        Public Class Task
            Inherits EntityObject
#Region "Campos Privados de la Entidad"
        'Campos de la entidad
        'Campos Default
        Private _UID As String
        Private _LID As String
        Private _idAccion As Integer
#End Region

#Region "Constructores"

        Public Sub New()
        End Sub

#End Region

#Region "Propiedades de la entidad"
        'Propedades Default
        Public Property UID() As String
            Get
                Return _UID
            End Get
            Set(ByVal Value As String)
                _UID = Value
            End Set
        End Property

        Public Property LID() As String
            Get
                Return _LID
            End Get
            Set(ByVal Value As String)
                _LID = Value
            End Set
        End Property

        Public Property idAccion() As Integer
            Get
                Return _idAccion
            End Get
            Set(ByVal Value As Integer)
                _idAccion = Value
            End Set
        End Property

#End Region
    End Class
    End Namespace
