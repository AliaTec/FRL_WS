
Imports Intelexion.Framework.Model
Imports System.Xml.Serialization
Imports System.IO

Namespace Entities
    <XmlRootAttribute("TaskSchedule", _
     Namespace:="http://www.intelexion.com/", IsNullable:=False)> _
    Public Class TaskSchedule
        Inherits EntityObject
#Region "Campos Privados de la Entidad"
        'Campos de la entidad
        Private _idTask As Integer
        Private _taskDescription As String
        Private _TaskFrequency As Int16
        Private _TaskHour As Int16
        Private _TaskMinutes As Int16
        Private _TaskName As String

        'Campos Default
        Private _UID As String
        Private _LID As String
        Private _idAccion As Integer
#End Region

#Region "Constructores"

        Public Sub New()
            _idTask = 0
            _taskDescription = ""
            _TaskFrequency = 0
            _TaskHour = 0
            _TaskMinutes = 0
            _TaskName = ""
            _UID = ""
            _LID = ""
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
        Public Property taskDescription() As String
            Get
                Return _taskDescription
            End Get
            Set(ByVal Value As String)
                _taskDescription = Value
            End Set
        End Property
        Public Property TaskFrequency() As Int16
            Get
                Return _TaskFrequency
            End Get
            Set(ByVal Value As Int16)
                _TaskFrequency = Value
            End Set
        End Property
        Public Property TaskHour() As Int16
            Get
                Return _TaskHour
            End Get
            Set(ByVal Value As Int16)
                _TaskHour = Value
            End Set
        End Property
        Public Property TaskMinutes() As Int16
            Get
                Return _TaskMinutes
            End Get
            Set(ByVal Value As Int16)
                _TaskMinutes = Value
            End Set
        End Property
        Public Property TaskName() As String
            Get
                Return _TaskName
            End Get
            Set(ByVal Value As String)
                _TaskName = Value
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
