Module ModuloPrincipal
    Private urlWS As String
    Private connString As String
    Private pathLog As String

    Public Sub Main(ByVal Args() As String)
        Dim forma As New frmMain
        If Args.Length = 0 OrElse Args(0).Trim = "" Then
            forma.ShowDialog()
        Else
            Select Case Args(0)
                Case "1"
                    Interfase(1)
                Case "2"
                    Interfase(2)
                Case "3"
                    Interfase(3)
                Case "4"
                    Interfase(4)
                Case "5"
                    Interfase(5)
                Case "6"
                    Interfase(6)
                Case "7"
                    Interfase(7)
                Case Else
            End Select
            Application.Exit()
        End If
    End Sub

    Public Sub Interfase(ByVal idTask As Integer)
        Dim dataConn As Intelexion.Framework.Model.SQLDataConnection = Nothing
        Dim ClaTrab As Integer
        Dim ClaEmpresa As Integer
        Dim ApPaterno As String = ""
        Dim ApMaterno As String = ""
        Dim Nombre As String = ""
        Dim ClaUbBase As Integer
        Dim ClaUbPago As Integer
        Dim ClaDepto As Integer
        Dim ClaPuesto As Integer
        Dim ClaClasif As Integer
        Dim ClaRolTurno As Integer
        Dim ClaTabPre As Integer
        Dim ClaPeriodo As Integer
        Dim ClaRegPat As String = ""
        Dim ClaCC As Integer
        Dim TipoSal As Integer
        Dim SueDiario As Double
        Dim SueInteg As Double
        Dim SueMensual As Double
        Dim FechaIngreso As String = ""
        Dim FechaIngresoEmpresa As String = ""
        Dim TipoContrato As Integer
        Dim ClaFormaPago As Integer
        Dim ClaBanco As Integer
        Dim CuentaBanco As String = ""
        Dim Plaza As Integer
        Dim LugarNac As String = ""
        Dim FechaNac As String = ""
        Dim Sexo As String = ""
        Dim Sindicalizado As Integer
        Dim Email As String = ""
        Dim EdoCivil As String = ""
        Dim RFC As String = ""
        Dim NoIMSS As String = ""
        Dim CURP As String = ""
        Dim Calle As String = ""
        Dim Colonia As String = ""
        Dim CodPostal As Integer
        Dim Ciudad As String = ""
        Dim Estado As String = ""
        Dim Telefono As String = ""
        Dim EstatusDelTrabajador As Integer
        Dim FechaDeBaja As String = ""
        Dim NumeroDeCartillaMilitar As String = ""
        Dim Nacionalidad As String = ""
        Dim Estatura As Double
        Dim Peso As Double
        Dim NombredelPadre As String = ""
        Dim NombredelaMadre As String = ""
        Dim AvisarenCasodeAccidente As String = ""
        Dim AvisoParentesco As Integer
        Dim AvisoCalle As String = ""
        Dim AvisoCiudad As String = ""
        Dim AvisoCP As Integer
        Dim AvisoTelefono As String = ""
        Dim ClaveRazonsocial As Integer
        Dim FechaMov As String = ""
        Dim ClaTipoMov As Integer
        Dim Comentarios As String = ""
        Dim FechaReal As String = ""
        Dim FinContrato As String = ""
        Dim Sucursal As String = ""
        Dim FechaFinContrato As String = ""
        Dim ClaRazonSocial As Integer
        Dim EstadoNacimiento As String = ""
        Dim Familiares As String = ""
        Dim Escolaridad As String = ""
        Dim NumInfonavit As String = ""
        Dim TipoDescuento As Integer
        Dim Monto As Double
        Dim FechaSuspension As String

  
        Try
            cargaConfiguracion()
            Dim proxy As New Fortia.FortiaRHNService(urlWS)

            proxy.Timeout = System.Threading.Timeout.Infinite 'cambiar tiempo
            Dim conn As New System.Data.SqlClient.SqlConnection
            conn.ConnectionString = connString
            dataConn = New Intelexion.Framework.Model.SQLDataConnection(conn)
            dataConn.getConnection.Open()

            Dim response As Xml.XmlNode = Nothing
            Dim exito As Boolean = False
            Dim mensaje As String = ""
            Dim Operacion As String = ""
            Dim descripcionMovimiento As String = ""
            Dim Empleado As String = ""

            Dim sqlAdp As New SqlClient.SqlDataAdapter
            Dim sqlCmd As New SqlClient.SqlCommand
            Dim ds As New DataSet
            Dim contador As Integer


            Select Case idTask
                Case 1
                    'Altas
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido 'usar dataset y hacer ciclo aqui se llama (1 sp por case)

                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_Altas", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador
                    Dim c As Integer = 0

                    For i As Integer = 0 To contador - 1

                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        ApPaterno = ds.Tables(0).Rows(i)(3).ToString()
                        ApMaterno = ds.Tables(0).Rows(i)(4).ToString()
                        Nombre = ds.Tables(0).Rows(i)(5).ToString()
                        ClaUbBase = Integer.Parse(ds.Tables(0).Rows(i)(6).ToString())
                        ClaDepto = Integer.Parse(ds.Tables(0).Rows(i)(7).ToString())
                        ClaPuesto = Integer.Parse(ds.Tables(0).Rows(i)(8).ToString())
                        ClaPeriodo = Integer.Parse(ds.Tables(0).Rows(i)(9).ToString())
                        ClaClasif = Integer.Parse(ds.Tables(0).Rows(i)(10).ToString())
                        Plaza = Integer.Parse(ds.Tables(0).Rows(i)(11).ToString())
                        FechaIngreso = ds.Tables(0).Rows(i)(12).ToString()
                        ClaRegPat = ds.Tables(0).Rows(i)(13).ToString()
                        ClaCC = Integer.Parse(ds.Tables(0).Rows(i)(14).ToString())
                        TipoSal = Integer.Parse(ds.Tables(0).Rows(i)(15).ToString())
                        SueDiario = ds.Tables(0).Rows(i)(16).ToString()
                        SueInteg = ds.Tables(0).Rows(i)(17).ToString()
                        SueMensual = ds.Tables(0).Rows(i)(18).ToString()
                        FechaIngresoEmpresa = ds.Tables(0).Rows(i)(19).ToString()
                        TipoContrato = Integer.Parse(ds.Tables(0).Rows(i)(20).ToString())
                        ClaFormaPago = Integer.Parse(ds.Tables(0).Rows(i)(21).ToString())
                        ClaBanco = Integer.Parse(ds.Tables(0).Rows(i)(22).ToString())
                        CuentaBanco = ds.Tables(0).Rows(i)(23).ToString()
                        LugarNac = ds.Tables(0).Rows(i)(24).ToString()
                        FechaNac = ds.Tables(0).Rows(i)(25).ToString()
                        Sexo = ds.Tables(0).Rows(i)(26).ToString()
                        Sindicalizado = Integer.Parse(ds.Tables(0).Rows(i)(27).ToString())
                        Email = ds.Tables(0).Rows(i)(28).ToString()
                        EdoCivil = ds.Tables(0).Rows(i)(29).ToString()
                        RFC = ds.Tables(0).Rows(i)(30).ToString()
                        NoIMSS = ds.Tables(0).Rows(i)(31).ToString()
                        CURP = ds.Tables(0).Rows(i)(32).ToString()
                        Calle = ds.Tables(0).Rows(i)(33).ToString()
                        Colonia = ds.Tables(0).Rows(i)(34).ToString()
                        CodPostal = Integer.Parse(ds.Tables(0).Rows(i)(35).ToString())
                        Ciudad = ds.Tables(0).Rows(i)(36).ToString()
                        Estado = ds.Tables(0).Rows(i)(37).ToString()
                        NombredelPadre = ds.Tables(0).Rows(i)(38).ToString()
                        NombredelaMadre = ds.Tables(0).Rows(i)(39).ToString()
                        AvisarenCasodeAccidente = ds.Tables(0).Rows(i)(40).ToString()
                        AvisoParentesco = ds.Tables(0).Rows(i)(41).ToString()
                        AvisoCalle = ds.Tables(0).Rows(i)(42).ToString()
                        AvisoCiudad = ds.Tables(0).Rows(i)(43).ToString()
                        AvisoCP = ds.Tables(0).Rows(i)(44).ToString()
                        AvisoTelefono = ds.Tables(0).Rows(i)(45).ToString()
                        Telefono = ds.Tables(0).Rows(i)(46).ToString()
                        EstatusDelTrabajador = Integer.Parse(ds.Tables(0).Rows(i)(47).ToString())
                        FechaDeBaja = ds.Tables(0).Rows(i)(48).ToString()
                        Nacionalidad = ds.Tables(0).Rows(i)(49).ToString()
                        ClaveRazonsocial = Integer.Parse(ds.Tables(0).Rows(i)(50).ToString())
                        ClaUbPago = Integer.Parse(ds.Tables(0).Rows(i)(51).ToString())
                        ClaRolTurno = Integer.Parse(ds.Tables(0).Rows(i)(52).ToString())
                        ClaTabPre = Integer.Parse(ds.Tables(0).Rows(i)(53).ToString())
                        EstadoNacimiento = ds.Tables(0).Rows(i)(54).ToString()
                        Familiares = ds.Tables(0).Rows(i)(55).ToString()
                        Escolaridad = ds.Tables(0).Rows(i)(56).ToString()
                        NumInfonavit = ds.Tables(0).Rows(i)(57).ToString()
                        'MsgBox("Enviado1")
                        'proxy.Altas(ClaTipoMov, ClaTrab, ClaEmpresa, ApPaterno, ApMaterno, Nombre, ClaUbBase, ClaUbPago, ClaDepto, ClaPuesto, ClaClasif, ClaRolTurno, ClaTabPre, ClaPeriodo, ClaRegPat, ClaCC, TipoSal, SueDiario, SueInteg, SueMensual, FechaIngreso, FechaIngresoEmpresa, TipoContrato, ClaFormaPago, ClaBanco, CuentaBanco, LugarNac, FechaNac, Sexo, Sindicalizado, Email, EdoCivil, RFC, NoIMSS, CURP, Calle, Colonia, CodPostal, Ciudad, Estado, Telefono, EstatusDelTrabajador, FechaDeBaja, NumeroDeCartillaMilitar, Nacionalidad, Estatura, Peso, NombredelPadre, NombredelaMadre, AvisarenCasodeAccidente, AvisoParentesco, AvisoCalle, AvisoCiudad, AvisoCP, AvisoTelefono, ClaveRazonsocial, Plaza)
                        'MsgBox("Enviado2")
                        response = proxy.Altas(ClaTipoMov, ClaTrab, ClaEmpresa, ApPaterno, ApMaterno, Nombre, ClaUbBase, ClaUbPago, ClaDepto, ClaPuesto, ClaClasif, ClaRolTurno, ClaTabPre, ClaPeriodo, ClaRegPat, ClaCC, TipoSal, SueDiario, SueInteg, SueMensual, FechaIngreso, FechaIngresoEmpresa, TipoContrato, ClaFormaPago, ClaBanco, CuentaBanco, LugarNac, FechaNac, Sexo, Sindicalizado, Email, EdoCivil, RFC, NoIMSS, CURP, Calle, Colonia, CodPostal, Ciudad, Estado, Telefono, EstatusDelTrabajador, FechaDeBaja, NumeroDeCartillaMilitar, Nacionalidad, Estatura, Peso, NombredelPadre, NombredelaMadre, AvisarenCasodeAccidente, AvisoParentesco, AvisoCalle, AvisoCiudad, AvisoCP, AvisoTelefono, ClaveRazonsocial, Plaza, EstadoNacimiento, Familiares, Escolaridad, NumInfonavit)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "Alta"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaMov=" + ClaTipoMov.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",ClaEmpresa=" + ClaEmpresa.ToString() + ",ApPaterno=" + ApPaterno.ToString() + ",ApMaterno=" + ApMaterno.ToString() + ",Nombre=" + Nombre.ToString() + ",UbBase=" + ClaUbBase.ToString() + ",ClaUbPago=" + ClaUbPago.ToString() + ",ClaDepto=" + ClaDepto.ToString() + ",ClaPuesto=" + ClaPuesto.ToString() + ",Clasif=" + ClaClasif.ToString() + ",RolTurno=" + ClaRolTurno.ToString() + ",TabPre=" + ClaTabPre.ToString() + ",Periodo=" + ClaPeriodo.ToString() + ",RegPat=" + ClaRegPat.ToString() + ",ClaCC=" + ClaCC.ToString() + ",TipoSal=" + TipoSal.ToString() + ",SueDiario=" + SueDiario.ToString() + ",SueInteg=" + SueInteg.ToString() + ",SueMensual=" + SueMensual.ToString() + ",FechaIngreso=" + FechaIngreso.ToString() + ",FechaIngresoEmpresa=" + FechaIngresoEmpresa.ToString() + ",TipoContrato=" + TipoContrato.ToString() + ",FormaPago=" + ClaFormaPago.ToString() + ",Banco=" + ClaBanco.ToString() + ",CuentaBanco=" + CuentaBanco.ToString() + ",Plaza=" + Plaza.ToString() + ",LugarNac=" + LugarNac.ToString() + ",FechaNac=" + FechaNac.ToString() + ",Sexo=" + Sexo.ToString() + ",Sindicalizado=" + Sindicalizado.ToString() + ",Email=" + Email.ToString() + ",EdoCivil=" + EdoCivil.ToString() + ",RFC=" + RFC.ToString() + ",NoIMSS=" + NoIMSS.ToString() + ",CURP=" + CURP.ToString() + ",Calle=" + Calle.ToString() + ",Colonia=" + Colonia.ToString() + ",CP=" + CodPostal.ToString() + ",Ciudad=" + Ciudad.ToString() + ",Estado=" + Estado.ToString() + ",Telefono=" + Telefono.ToString() + ",Estatus=" + EstatusDelTrabajador.ToString() + ",FechaBaja=" + FechaDeBaja.ToString() + ",Cartilla=" + NumeroDeCartillaMilitar.ToString() + ",Nacionalidad=" + Nacionalidad.ToString() + ",Estatura=" + Estatura.ToString() + ",Peso=" + Peso.ToString() + ",Padre=" + NombredelPadre.ToString() + ",Madre=" + NombredelaMadre.ToString() + ",Accidente=" + AvisarenCasodeAccidente.ToString() + ",Parentesco=" + AvisoParentesco.ToString() + ",calle=" + AvisoCalle.ToString() + ",Avciudad=" + AvisoCiudad.ToString() + ",AvCP=" + AvisoCP.ToString() + ",avTel=" + AvisoTelefono.ToString() + ",RazonSocial=" + ClaveRazonsocial.ToString() + ",EstadoNacimiento=" + EstadoNacimiento.ToString() + ",Familiares=" + Familiares.ToString() + ",Escolaridad=" + Escolaridad.ToString() + ",Infonavit=" + NumInfonavit.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)

                    Next i


                Case 2
                    'Bajas
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido

                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_Bajas", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1

                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        FechaMov = ds.Tables(0).Rows(i)(3).ToString()
                        FechaReal = ds.Tables(0).Rows(i)(4).ToString()

                        'proxy.Bajas(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, FechaReal)

                        response = proxy.Bajas(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, FechaReal)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "Baja"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaMov=" + ClaTipoMov.ToString() + ",claTrab=" + ClaTrab.ToString() + ",claEmpresa=" + ClaEmpresa.ToString() + ",FechaMov=" + FechaMov.ToString() + ",FechaReal=" + FechaReal.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)

                    Next i

                Case 3
                    'CambiosInformacionTrabajador
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido


                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_Cambios", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1
                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        ApPaterno = ds.Tables(0).Rows(i)(3).ToString()
                        ApMaterno = ds.Tables(0).Rows(i)(4).ToString()
                        Nombre = ds.Tables(0).Rows(i)(5).ToString()
                        ClaUbBase = Integer.Parse(ds.Tables(0).Rows(i)(6).ToString())
                        ClaDepto = Integer.Parse(ds.Tables(0).Rows(i)(7).ToString())
                        ClaPuesto = Integer.Parse(ds.Tables(0).Rows(i)(8).ToString())
                        ClaPeriodo = Integer.Parse(ds.Tables(0).Rows(i)(9).ToString())
                        ClaClasif = Integer.Parse(ds.Tables(0).Rows(i)(10).ToString())
                        Plaza = Integer.Parse(ds.Tables(0).Rows(i)(11).ToString())
                        FechaIngreso = ds.Tables(0).Rows(i)(12).ToString()
                        ClaRegPat = ds.Tables(0).Rows(i)(13).ToString()
                        ClaCC = Integer.Parse(ds.Tables(0).Rows(i)(14).ToString())
                        TipoSal = Integer.Parse(ds.Tables(0).Rows(i)(15).ToString())
                        SueDiario = ds.Tables(0).Rows(i)(16).ToString()
                        SueInteg = ds.Tables(0).Rows(i)(17).ToString()
                        SueMensual = ds.Tables(0).Rows(i)(18).ToString()
                        FechaIngresoEmpresa = ds.Tables(0).Rows(i)(19).ToString()
                        TipoContrato = Integer.Parse(ds.Tables(0).Rows(i)(20).ToString())
                        ClaFormaPago = Integer.Parse(ds.Tables(0).Rows(i)(21).ToString())
                        ClaBanco = Integer.Parse(ds.Tables(0).Rows(i)(22).ToString())
                        CuentaBanco = ds.Tables(0).Rows(i)(23).ToString()
                        LugarNac = ds.Tables(0).Rows(i)(24).ToString()
                        FechaNac = ds.Tables(0).Rows(i)(25).ToString()
                        Sexo = ds.Tables(0).Rows(i)(26).ToString()
                        Sindicalizado = Integer.Parse(ds.Tables(0).Rows(i)(27).ToString())
                        Email = ds.Tables(0).Rows(i)(28).ToString()
                        EdoCivil = ds.Tables(0).Rows(i)(29).ToString()
                        RFC = ds.Tables(0).Rows(i)(30).ToString()
                        NoIMSS = ds.Tables(0).Rows(i)(31).ToString()
                        CURP = ds.Tables(0).Rows(i)(32).ToString()
                        Calle = ds.Tables(0).Rows(i)(33).ToString()
                        Colonia = ds.Tables(0).Rows(i)(34).ToString()
                        CodPostal = Integer.Parse(ds.Tables(0).Rows(i)(35).ToString())
                        Ciudad = ds.Tables(0).Rows(i)(36).ToString()
                        Estado = ds.Tables(0).Rows(i)(37).ToString()
                        NombredelPadre = ds.Tables(0).Rows(i)(38).ToString()
                        NombredelaMadre = ds.Tables(0).Rows(i)(39).ToString()
                        AvisarenCasodeAccidente = ds.Tables(0).Rows(i)(40).ToString()
                        AvisoParentesco = ds.Tables(0).Rows(i)(41).ToString()
                        AvisoCalle = ds.Tables(0).Rows(i)(42).ToString()
                        AvisoCiudad = ds.Tables(0).Rows(i)(43).ToString()
                        AvisoCP = ds.Tables(0).Rows(i)(44).ToString()
                        AvisoTelefono = ds.Tables(0).Rows(i)(45).ToString()
                        Telefono = ds.Tables(0).Rows(i)(46).ToString()
                        EstatusDelTrabajador = Integer.Parse(ds.Tables(0).Rows(i)(47).ToString())
                        FechaDeBaja = ds.Tables(0).Rows(i)(48).ToString()
                        Nacionalidad = ds.Tables(0).Rows(i)(49).ToString()
                        ClaveRazonsocial = Integer.Parse(ds.Tables(0).Rows(i)(50).ToString())
                        ClaUbPago = Integer.Parse(ds.Tables(0).Rows(i)(51).ToString())
                        ClaRolTurno = Integer.Parse(ds.Tables(0).Rows(i)(52).ToString())
                        ClaTabPre = Integer.Parse(ds.Tables(0).Rows(i)(53).ToString())
                        NumInfonavit = ds.Tables(0).Rows(i)(54).ToString()
                        'MsgBox("Enviado1")

                        ' proxy.CambiosInformacionTrabajador(ClaTipoMov, ClaTrab, ClaEmpresa, ApPaterno, ApMaterno, Nombre, ClaUbBase, ClaUbPago, ClaDepto, ClaPuesto, ClaClasif, ClaRolTurno, ClaTabPre, ClaPeriodo, ClaRegPat, ClaCC, TipoSal, SueDiario, SueMensual, SueInteg, FechaIngreso, FechaIngresoEmpresa, TipoContrato, ClaFormaPago, ClaBanco, CuentaBanco, Plaza, LugarNac, FechaNac, Sexo, Sindicalizado, Email, EdoCivil, RFC, NoIMSS, CURP, Calle, Colonia, CodPostal, Ciudad, Estado, Telefono, EstatusDelTrabajador, FechaDeBaja, Nacionalidad, NombredelPadre, NombredelaMadre, AvisarenCasodeAccidente, AvisoParentesco, AvisoCalle, AvisoCiudad, AvisoCP, AvisoTelefono, ClaveRazonsocial)

                        response = proxy.CambiosInformacionTrabajador(ClaTipoMov, ClaTrab, ClaEmpresa, ApPaterno, ApMaterno, Nombre, ClaUbBase, ClaUbPago, ClaDepto, ClaPuesto, ClaClasif, ClaRolTurno, ClaTabPre, ClaPeriodo, ClaRegPat, ClaCC, TipoSal, SueDiario, SueMensual, SueInteg, FechaIngreso, FechaIngresoEmpresa, TipoContrato, ClaFormaPago, ClaBanco, CuentaBanco, Plaza, LugarNac, FechaNac, Sexo, Sindicalizado, Email, EdoCivil, RFC, NoIMSS, CURP, Calle, Colonia, CodPostal, Ciudad, Estado, Telefono, EstatusDelTrabajador, FechaDeBaja, Nacionalidad, NombredelPadre, NombredelaMadre, AvisarenCasodeAccidente, AvisoParentesco, AvisoCalle, AvisoCiudad, AvisoCP, AvisoTelefono, ClaveRazonsocial, NumInfonavit)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "CambioInformacion"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaMov=" + ClaTipoMov.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",ClaEmpresa=" + ClaEmpresa.ToString() + ",ApPaterno=" + ApPaterno.ToString() + ",ApMaterno=" + ApMaterno.ToString() + ",Nombre=" + Nombre.ToString() + ",UbBase=" + ClaUbBase.ToString() + ",ClaUbPago=" + ClaUbPago.ToString() + ",ClaDepto=" + ClaDepto.ToString() + ",ClaPuesto=" + ClaPuesto.ToString() + ",Clasif=" + ClaClasif.ToString() + ",RolTurno=" + ClaRolTurno.ToString() + ",TabPre=" + ClaTabPre.ToString() + ",Periodo=" + ClaPeriodo.ToString() + ",RegPat=" + ClaRegPat.ToString() + ",ClaCC=" + ClaCC.ToString() + ",TipoSal=" + TipoSal.ToString() + ",SueDiario=" + SueDiario.ToString() + ",SueInteg=" + SueInteg.ToString() + ",SueMensual=" + SueMensual.ToString() + ",FechaIngreso=" + FechaIngreso.ToString() + ",FechaIngresoEmpresa=" + FechaIngresoEmpresa.ToString() + ",TipoContrato=" + TipoContrato.ToString() + ",FormaPago=" + ClaFormaPago.ToString() + ",Banco=" + ClaBanco.ToString() + ",CuentaBanco=" + CuentaBanco.ToString() + ",Plaza=" + Plaza.ToString() + ",LugarNac=" + LugarNac.ToString() + ",FechaNac=" + FechaNac.ToString() + ",Sexo=" + Sexo.ToString() + ",Sindicalizado=" + Sindicalizado.ToString() + ",Email=" + Email.ToString() + ",EdoCivil=" + EdoCivil.ToString() + ",RFC=" + RFC.ToString() + ",NoIMSS=" + NoIMSS.ToString() + ",CURP=" + CURP.ToString() + ",Calle=" + Calle.ToString() + ",Colonia=" + Colonia.ToString() + ",CP=" + CodPostal.ToString() + ",Ciudad=" + Ciudad.ToString() + ",Estado=" + Estado.ToString() + ",Telefono=" + Telefono.ToString() + ",Estatus=" + EstatusDelTrabajador.ToString() + ",FechaBaja=" + FechaDeBaja.ToString() + ",Cartilla=" + NumeroDeCartillaMilitar.ToString() + ",Nacionalidad=" + Nacionalidad.ToString() + ",Estatura=" + Estatura.ToString() + ",Peso=" + Peso.ToString() + ",Padre=" + NombredelPadre.ToString() + ",Madre=" + NombredelaMadre.ToString() + ",Accidente=" + AvisarenCasodeAccidente.ToString() + ",Parentesco=" + AvisoParentesco.ToString() + ",calle=" + AvisoCalle.ToString() + ",Avciudad=" + AvisoCiudad.ToString() + ",AvCP=" + AvisoCP.ToString() + ",avTel=" + AvisoTelefono.ToString() + ",RazonSocial=" + ClaveRazonsocial.ToString() + ",Infonavit=" + NumInfonavit.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)


                    Next i


                Case 4
                    'CambiosSueldoTrabajador
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido

                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_CambioSueldo", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1
                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        FechaMov = ds.Tables(0).Rows(i)(3).ToString()
                        ClaUbBase = Integer.Parse(ds.Tables(0).Rows(i)(4).ToString())
                        ClaUbPago = Integer.Parse(ds.Tables(0).Rows(i)(5).ToString())
                        ClaCC = Integer.Parse(ds.Tables(0).Rows(i)(6).ToString())
                        ClaDepto = Integer.Parse(ds.Tables(0).Rows(i)(7).ToString())
                        ClaPuesto = Integer.Parse(ds.Tables(0).Rows(i)(8).ToString())
                        ClaClasif = Integer.Parse(ds.Tables(0).Rows(i)(9).ToString())
                        ClaRegPat = ds.Tables(0).Rows(i)(10).ToString()
                        ClaTabPre = Integer.Parse(ds.Tables(0).Rows(i)(11).ToString())
                        ClaRolTurno = Integer.Parse(ds.Tables(0).Rows(i)(12).ToString())
                        TipoSal = Integer.Parse(ds.Tables(0).Rows(i)(13).ToString())
                        TipoContrato = Integer.Parse(ds.Tables(0).Rows(i)(14).ToString())
                        SueDiario = ds.Tables(0).Rows(i)(15).ToString()
                        SueMensual = ds.Tables(0).Rows(i)(16).ToString()
                        SueInteg = ds.Tables(0).Rows(i)(17).ToString()
                        ClaRazonSocial = Integer.Parse(ds.Tables(0).Rows(i)(18).ToString())
                        ClaPeriodo = Integer.Parse(ds.Tables(0).Rows(i)(19).ToString())
                        'MsgBox("Enviado1")

                        'proxy.CambiosSueldoTrabajador(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, ClaUbBase, ClaUbPago, ClaCC, ClaDepto, ClaPuesto, ClaClasif, ClaRegPat, ClaTabPre, ClaRolTurno, TipoSal, TipoContrato, SueDiario, SueMensual, SueInteg, ClaRazonSocial)

                        response = proxy.CambiosSueldoTrabajador(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, ClaUbBase, ClaUbPago, ClaCC, ClaDepto, ClaPuesto, ClaClasif, ClaRegPat, ClaTabPre, ClaRolTurno, TipoSal, TipoContrato, SueDiario, SueMensual, SueInteg, ClaRazonSocial, ClaPeriodo)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "CambioSueldo"
                        Empleado = ClaTrab.ToString()

                        descripcionMovimiento = "ClaMov=" + ClaTipoMov.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",Empresa=" + ClaEmpresa.ToString() + ",FechaMov=" + FechaMov.ToString() + ",UbBase=" + ClaUbBase.ToString() + ",UbPago=" + ClaUbPago.ToString() + ",ClaCC=" + ClaCC.ToString() + ",ClaDepto=" + ClaDepto.ToString() + ",ClaPuesto=" + ClaPuesto.ToString() + ",ClaClasif=" + ClaClasif.ToString() + ",ClaRegPat=" + ClaRegPat.ToString() + ",ClaTabPre=" + ClaTabPre.ToString() + ",ClaRolTurno=" + ClaRolTurno.ToString() + ",TipoSal=" + TipoSal.ToString() + ",TipoContrato=" + TipoContrato.ToString() + ",SueDiario=" + SueDiario.ToString() + ",SueMensual=" + SueMensual.ToString() + ",SueInteg=" + SueInteg.ToString() + ",ClaRazonSocial=" + ClaRazonSocial.ToString() + ",ClaPeriodo=" + ClaPeriodo.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)

                    Next i

                Case 5
                    'Reingresos
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido

                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_Reingresos", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1
                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        FechaMov = ds.Tables(0).Rows(i)(3).ToString()
                        ClaUbBase = Integer.Parse(ds.Tables(0).Rows(i)(4).ToString())
                        ClaUbPago = Integer.Parse(ds.Tables(0).Rows(i)(5).ToString())
                        ClaCC = Integer.Parse(ds.Tables(0).Rows(i)(6).ToString())
                        ClaDepto = Integer.Parse(ds.Tables(0).Rows(i)(7).ToString())
                        ClaPuesto = Integer.Parse(ds.Tables(0).Rows(i)(8).ToString())
                        ClaClasif = Integer.Parse(ds.Tables(0).Rows(i)(9).ToString())
                        ClaRegPat = ds.Tables(0).Rows(i)(10).ToString()
                        ClaTabPre = Integer.Parse(ds.Tables(0).Rows(i)(11).ToString())
                        ClaRolTurno = Integer.Parse(ds.Tables(0).Rows(i)(12).ToString())
                        TipoSal = Integer.Parse(ds.Tables(0).Rows(i)(13).ToString())
                        TipoContrato = Integer.Parse(ds.Tables(0).Rows(i)(14).ToString())
                        SueDiario = ds.Tables(0).Rows(i)(15).ToString()
                        SueMensual = ds.Tables(0).Rows(i)(16).ToString()
                        SueInteg = ds.Tables(0).Rows(i)(17).ToString()
                        ClaveRazonsocial = Integer.Parse(ds.Tables(0).Rows(i)(18).ToString())
                        Plaza = Integer.Parse(ds.Tables(0).Rows(i)(19).ToString())

                        'proxy.Reingresos(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, ClaUbBase, ClaUbPago, ClaCC, ClaDepto, ClaPuesto, ClaClasif, ClaRegPat, ClaTabPre, ClaRolTurno, TipoSal, TipoContrato, SueDiario, SueMensual, SueInteg, ClaRazonSocial, Plaza)

                        response = proxy.Reingresos(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, ClaUbBase, ClaUbPago, ClaCC, ClaDepto, ClaPuesto, ClaClasif, ClaRegPat, ClaTabPre, ClaRolTurno, TipoSal, TipoContrato, SueDiario, SueMensual, SueInteg, ClaveRazonsocial, Plaza)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "Reingreso"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaMov=" + ClaTipoMov.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",Empresa=" + ClaEmpresa.ToString() + ",FechaMov=" + FechaMov.ToString() + ",UbBase=" + ClaUbBase.ToString() + ",UbPago=" + ClaUbPago.ToString() + ",ClaCC=" + ClaCC.ToString() + ",ClaDepto=" + ClaDepto.ToString() + ",ClaPuesto=" + ClaPuesto.ToString() + ",ClaClasif=" + ClaClasif.ToString() + ",ClaRegPat=" + ClaRegPat.ToString() + ",ClaTabPre=" + ClaTabPre.ToString() + ",ClaRolTurno=" + ClaRolTurno.ToString() + ",TipoSal=" + TipoSal.ToString() + ",TipoContrato=" + TipoContrato.ToString() + ",SueDiario=" + SueDiario.ToString() + ",SueMensual=" + SueMensual.ToString() + ",SueInteg=" + SueInteg.ToString() + ",ClaveRazonSocial=" + ClaveRazonsocial.ToString() + ",Plaza=" + Plaza.ToString()

                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)
                    Next i

                Case 6
                    'Alta Infonavit
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido

                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_AltaInfonavit", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1

                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        FechaMov = ds.Tables(0).Rows(i)(3).ToString()
                        NumInfonavit = ds.Tables(0).Rows(i)(4).ToString()
                        TipoDescuento = Integer.Parse(ds.Tables(0).Rows(i)(5).ToString())
                        Monto = Double.Parse(ds.Tables(0).Rows(i)(6).ToString())
                        FechaSuspension = ds.Tables(0).Rows(i)(7).ToString()



                        'proxy.Bajas(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, FechaReal)

                        response = proxy.AltaInfonavit(ClaEmpresa, ClaTrab, ClaTipoMov, FechaMov, NumInfonavit, TipoDescuento, Monto, FechaSuspension)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "AltaInfonavit"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaEmpresa=" + ClaEmpresa.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",ClaTipoMov=" + ClaTipoMov.ToString() + ",FechaMov=" + FechaMov.ToString() + ",NumInfonavit=" + NumInfonavit.ToString() + ",TipoDescuento=" + TipoDescuento.ToString() + ",Monto=" + Monto.ToString() + "FechaSuspension=" + FechaSuspension.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)

                    Next i

                Case 7
                    'Elimina Infonavit
                    'TO DO:Obtener los movimientos, asignar los valores a las variables que se mandan en cada caso y mandar llamar el servicio
                    'para cada registro obtenido
                    '(ByVal claEmpresa As Integer, ByVal claTrab As Integer, ByVal tipoMov As Integer, ByVal fechaMovimiento As String, ByVal numeroInfonavit As String, ByVal tipoDescuento As Integer)
                    Dim da As New SqlClient.SqlDataAdapter("sp_interfazFortia_EliminaInfonavit", conn)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(ds)
                    contador = ds.Tables(0).Rows.Count.ToString
                    Dim r As Integer
                    r = contador


                    For i As Integer = 0 To contador - 1

                        ClaTipoMov = Integer.Parse(ds.Tables(0).Rows(i)(0).ToString())
                        ClaTrab = Integer.Parse(ds.Tables(0).Rows(i)(1).ToString())
                        ClaEmpresa = Integer.Parse(ds.Tables(0).Rows(i)(2).ToString())
                        FechaMov = ds.Tables(0).Rows(i)(3).ToString()
                        NumInfonavit = ds.Tables(0).Rows(i)(4).ToString()
                        TipoDescuento = Integer.Parse(ds.Tables(0).Rows(i)(5).ToString())


                        'proxy.Bajas(ClaTipoMov, ClaTrab, ClaEmpresa, FechaMov, FechaReal)

                        response = proxy.EliminarDatosInfonavit(ClaEmpresa, ClaTrab, ClaTipoMov, FechaMov, NumInfonavit, TipoDescuento)

                        If Not (response Is Nothing) Then
                            If response.SelectSingleNode("//Exito").InnerText = "1" Then
                                exito = True
                            Else
                                exito = False
                            End If
                            mensaje = response.SelectSingleNode("//Mensaje").InnerText
                        Else
                            exito = False
                            mensaje = "Error, no se obtuvo respuesta"
                        End If
                        Operacion = "EliminaInfonavit"
                        Empleado = ClaTrab.ToString()
                        descripcionMovimiento = "ClaEmpresa=" + ClaEmpresa.ToString() + ",ClaTrab=" + ClaTrab.ToString() + ",ClaTipoMov=" + ClaTipoMov.ToString() + ",FechaMov=" + FechaMov.ToString() + ",NumInfonavit=" + NumInfonavit.ToString() + ",TipoDescuento=" + TipoDescuento.ToString()
                        writeLogEntry(Operacion, descripcionMovimiento, exito, mensaje)
                        writeLogEntry_SP(Operacion, descripcionMovimiento, exito, mensaje, Empleado, conn)

                    Next i
            End Select

            dataConn.getConnection.Close()
        Catch Exep As Exception
            Try
                'MsgBox("An exception occurred:" & Exep.Message)
                writeLogEntry(idTask.ToString(), "Exep", "false", Exep.Message)
                dataConn.getConnection.Close()
            Catch ex As Exception

            End Try
        End Try
    End Sub



    Private Function cargaConfiguracion() As Boolean
        Dim rv As Boolean
        rv = False
        Try
            Dim xmlConfigFile As New System.Xml.XmlDataDocument
            Dim path As String
            path = Application.ExecutablePath.ToLower.Replace("bin\interfacemanager.exe", "")
            xmlConfigFile.Load(path + "Config.xml")
            urlWS = xmlConfigFile.SelectSingleNode("//URLWebService").InnerText
            connString = xmlConfigFile.SelectSingleNode("//ConnectionString").InnerText
            pathLog = xmlConfigFile.SelectSingleNode("//LogFile").InnerText
            rv = True
        Catch ex As Exception
        End Try
        Return rv
    End Function


    Public Sub writeLogEntry(ByVal operacion As String, ByVal descripcionMovimiento As String, ByVal exito As Boolean, ByVal mensaje As String)
        Dim mtx As System.Threading.Mutex = Nothing
        Dim msgLine As String
        msgLine = Now.ToString + "," + operacion + "," + descripcionMovimiento + "," + exito.ToString + "," + mensaje
        Try
            mtx = New System.Threading.Mutex(False, "LogWriter")
            mtx.WaitOne()
            Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter(pathLog, True)
            sw.WriteLine(msgLine)
            sw.Close()
        Catch ex As Exception
        Finally
            Try
                mtx.ReleaseMutex()
            Catch ex As Exception
            End Try
        End Try
    End Sub

    Public Sub writeLogEntry_SP(ByVal operacion As String, ByVal descripcionMovimiento As String, ByVal exito As Boolean, ByVal mensaje As String, ByVal Empleado As String, ByVal conn As System.Data.SqlClient.SqlConnection)
        Dim cmd As New SqlClient.SqlCommand("spa_Log_ITXFortia", conn)
        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Operacion", operacion.ToString())
            cmd.Parameters.AddWithValue("@Empleado", Empleado.ToString())
            cmd.Parameters.AddWithValue("@descripcion", descripcionMovimiento.ToString())
            cmd.Parameters.AddWithValue("@Exito", exito.ToString())
            cmd.Parameters.AddWithValue("@Mensaje", mensaje.ToString())
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

End Module
