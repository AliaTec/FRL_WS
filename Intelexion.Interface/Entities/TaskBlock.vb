
Imports Intelexion.Framework.Model
Imports System.Xml.Serialization
Imports System.IO

Namespace Entities
    <XmlRootAttribute("TaskBlock", _
     Namespace:="http://www.intelexion.com/", IsNullable:=False)> _
    Public Class TaskBlock
        Inherits EntityObject
#Region "Campos Privados de la Entidad"
        'Campos de la entidad
        Private _idTask As Integer
        Private _taskStartTimeStamp As DateTime
        Private _taskFinishTimeStamp As DateTime
        Private _taskStatus As Int16
        Private _taskBlockId As String
        'Campos Default
        Private _UID As String
        Private _LID As String
        Private _idAccion As Integer
#End Region

#Region "Constructores"

        Public Sub New()
            _idTask = 0
            _taskStartTimeStamp = Date.Now
            _taskFinishTimeStamp = Date.Now
            _taskStatus = 0
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

        Public Property taskStartTimeStamp() As DateTime
            Get
                Return _taskStartTimeStamp
            End Get
            Set(ByVal Value As DateTime)
                _taskStartTimeStamp = Value
            End Set
        End Property

        Public Property taskFinishTimeStamp() As DateTime
            Get
                Return _taskFinishTimeStamp
            End Get
            Set(ByVal Value As DateTime)
                _taskFinishTimeStamp = Value
            End Set
        End Property

        Public Property taskStatus() As Int16
            Get
                Return _taskStatus
            End Get
            Set(ByVal Value As Int16)
                _taskStatus = Value
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
