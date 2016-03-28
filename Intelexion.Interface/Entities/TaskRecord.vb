
Imports Intelexion.Framework.Model
Imports System.Xml.Serialization
Imports System.IO

Namespace Entities
    <XmlRootAttribute("TaskBlock", _
     Namespace:="http://www.intelexion.com/", IsNullable:=False)> _
    Public Class TaskRecord
        Inherits EntityObject
#Region "Campos Privados de la Entidad"
        'Campos de la entidad
        Private _idTask As Integer
        Private _status As Int16
        Private _taskBlockId As String
        Private _data As String
        Private _registroRegreso As String
        'Campos Default
        Private _UID As String
        Private _LID As String
        Private _idAccion As Integer
#End Region

#Region "Constructores"

        Public Sub New()
            _idTask = 0
            _status = 0
            _data = ""
            _registroRegreso = ""
            _taskBlockId = ""
            _UID = ""
            _LID = 0
            _idAccion = 0
        End Sub

#End Region

#Region "Propiedades de la entidad"
        Public Property idTask() As Integer
            Get
                Return _idTask
            End Get
            Set(ByVal Value As Integer)
                _idTask = Value
            End Set
        End Property

        Public Property status() As Int16
            Get
                Return _status
            End Get
            Set(ByVal Value As Int16)
                _status = Value
            End Set
        End Property

        Public Property taskBlockId() As String
            Get
                Return _taskBlockId
            End Get
            Set(ByVal Value As String)
                _taskBlockId = Value
            End Set
        End Property
        Public Property data() As String
            Get
                Return _data
            End Get
            Set(ByVal Value As String)
                _data = Value
            End Set
        End Property

        Public Property registroRegreso() As String
            Get
                Return _registroRegreso
            End Get
            Set(ByVal Value As String)
                _registroRegreso = Value
            End Set
        End Property

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
