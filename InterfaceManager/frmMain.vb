Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private connString As String
    Private rcTaskSchedule As New Intelexion.Framework.Model.ResultCollection
    Private objTaskSchedule As New Intelexion.Interface.Entities.TaskSchedule

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cboTareas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUltimaEjecucion As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents lblSiguienteEjecucion As System.Windows.Forms.Label
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.cboTareas = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUltimaEjecucion = New System.Windows.Forms.Label
        Me.lblResultado = New System.Windows.Forms.Label
        Me.lblSiguienteEjecucion = New System.Windows.Forms.Label
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboTareas
        '
        Me.cboTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTareas.Location = New System.Drawing.Point(144, 8)
        Me.cboTareas.Name = "cboTareas"
        Me.cboTareas.Size = New System.Drawing.Size(168, 21)
        Me.cboTareas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tarea"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ultima Ejecución"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Siguiente Ejecución"
        '
        'lblUltimaEjecucion
        '
        Me.lblUltimaEjecucion.Location = New System.Drawing.Point(168, 40)
        Me.lblUltimaEjecucion.Name = "lblUltimaEjecucion"
        Me.lblUltimaEjecucion.Size = New System.Drawing.Size(256, 16)
        Me.lblUltimaEjecucion.TabIndex = 5
        '
        'lblResultado
        '
        Me.lblResultado.Location = New System.Drawing.Point(168, 72)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(240, 16)
        Me.lblResultado.TabIndex = 6
        '
        'lblSiguienteEjecucion
        '
        Me.lblSiguienteEjecucion.Location = New System.Drawing.Point(168, 104)
        Me.lblSiguienteEjecucion.Name = "lblSiguienteEjecucion"
        Me.lblSiguienteEjecucion.Size = New System.Drawing.Size(240, 16)
        Me.lblSiguienteEjecucion.TabIndex = 7
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(328, 8)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.TabIndex = 8
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(430, 156)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblSiguienteEjecucion)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblUltimaEjecucion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTareas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 192)
        Me.MinimumSize = New System.Drawing.Size(440, 192)
        Me.Name = "frmMain"
        Me.Text = "Intelexion Interface Manager"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cargaConfiguracion() Then
            If cargaTareas() Then
                If rcTaskSchedule.Count > 0 Then
                    VerificaTareas()
                    Me.cboTareas.DataSource = rcTaskSchedule.Values
                    Me.cboTareas.DisplayMember = "taskDescription"
                    Me.cboTareas.ValueMember = "idTask"
                    CargaDatosTarea()
                End If
            End If
        End If
    End Sub

    Private Function cargaConfiguracion() As Boolean
        Dim rv As Boolean
        rv = False
        Try
            Dim xmlConfigFile As New System.Xml.XmlDataDocument
            xmlConfigFile.Load("../Config.xml")
            connString = xmlConfigFile.SelectSingleNode("//ConnectionString").InnerText
            rv = True
        Catch ex As Exception
        End Try
        Return rv
    End Function

    Private Function cargaTareas() As Boolean
        Dim rv As Boolean
        Dim dataConn As Intelexion.Framework.Model.SQLDataConnection
        rv = False
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection
            conn.ConnectionString = connString
            dataConn = New Intelexion.Framework.Model.SQLDataConnection(conn)
            dataConn.getConnection.Open()
            Dim TaskScheduleData As New Intelexion.Interface.DAOS.TaskScheduleDAO(dataConn)
            rcTaskSchedule.getEntitiesFromDataReader(objTaskSchedule, TaskScheduleData.ConsultaTodas(objTaskSchedule))
            rv = True
            dataConn.getConnection.Close()
        Catch ex As Exception
            Try
                dataConn.getConnection.Close()
            Catch exe As Exception

            End Try
        End Try
        Return rv
    End Function

    Private Function VerificaTareas() As Boolean
        Try
            Dim i As Integer
            Dim path As String
            Dim scheduler As New TaskScheduler.ScheduledTasks
            Dim taskObj As TaskScheduler.Task
            path = Application.ExecutablePath
            For i = 0 To rcTaskSchedule.Count - 1
                If scheduler.OpenTask(DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskName) Is Nothing Then
                    taskObj = scheduler.CreateTask(DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskName)
                    taskObj.ApplicationName = path
                    taskObj.Parameters = DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).idTask
                    taskObj.Hidden = False
                    If DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskFrequency = 1 Then
                        Dim dt As New TaskScheduler.DailyTrigger(DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskHour, DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskMinutes)
                        taskObj.Triggers.Add(dt)
                    End If
                    Dim ts As New System.TimeSpan(2, 0, 0)
                    taskObj.MaxRunTime = ts
                    taskObj.SetAccountInformation("", Nothing)
                    taskObj.Save()
                    taskObj.Close()
                Else
                    taskObj = scheduler.OpenTask(DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskName)
                    taskObj.ApplicationName = path
                    taskObj.Parameters = DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).idTask
                    taskObj.Hidden = False
                    If DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskFrequency = 1 Then
                        Dim dt As New TaskScheduler.DailyTrigger(DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskHour, DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule).TaskMinutes)
                        taskObj.Triggers.Add(dt)
                    End If
                    Dim ts As New System.TimeSpan(2, 0, 0)
                    taskObj.MaxRunTime = ts
                    taskObj.Save()
                    taskObj.Close()
                End If
            Next
            scheduler.Dispose()
        Catch ex As Exception

        End Try
    End Function

    Sub CargaDatosTarea()
        Dim i As Integer
        i = cboTareas.SelectedIndex
        Dim tarea As Intelexion.Interface.Entities.TaskSchedule
        tarea = Nothing
        Try
            tarea = DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule)
        Catch exep As Exception
        End Try
        If Not (tarea Is Nothing) Then
            Dim taskObj As TaskScheduler.Task
            Dim scheduler As New TaskScheduler.ScheduledTasks
            taskObj = scheduler.OpenTask(tarea.TaskName)
            Me.lblResultado.Text = taskObj.ExitCode.ToString
            Me.lblUltimaEjecucion.Text = taskObj.MostRecentRunTime.ToLongDateString + " " + taskObj.MostRecentRunTime.ToLongTimeString
            Me.lblSiguienteEjecucion.Text = taskObj.NextRunTime.ToLongDateString + " " + taskObj.NextRunTime.ToLongTimeString
            taskObj.Close()
            scheduler.Dispose()
        End If
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Dim i As Integer
        i = cboTareas.SelectedIndex
        Dim tarea As Intelexion.Interface.Entities.TaskSchedule
        tarea = Nothing
        Try
            tarea = DirectCast(rcTaskSchedule.GetByIndex(i), Intelexion.Interface.Entities.TaskSchedule)
        Catch exep As Exception
        End Try
        If Not (tarea Is Nothing) Then
            Dim taskObj As TaskScheduler.Task
            Dim scheduler As New TaskScheduler.ScheduledTasks
            taskObj = scheduler.OpenTask(tarea.TaskName)
            taskObj.Run()
            Me.lblResultado.Text = taskObj.ExitCode.ToString
            Me.lblUltimaEjecucion.Text = taskObj.MostRecentRunTime.ToLongDateString + " " + taskObj.MostRecentRunTime.ToLongTimeString
            Me.lblSiguienteEjecucion.Text = taskObj.NextRunTime.ToLongDateString + " " + taskObj.NextRunTime.ToLongTimeString
            taskObj.Close()
            scheduler.Dispose()
        End If
    End Sub

    Private Sub cboTareas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTareas.SelectedIndexChanged
        CargaDatosTarea()
    End Sub
End Class
