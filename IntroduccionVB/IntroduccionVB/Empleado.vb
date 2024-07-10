Public Class Empleado
    Private _nombre As String
    Private _fechaNacimiento As DateTime

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento As DateTime
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As DateTime)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property apellidos As String
    Public Property idEstado As Integer
    Public Property sueldoMensual As Decimal

    Public ReadOnly Property edad As Integer
        Get
            Dim hoy As DateTime = DateTime.Now
            Dim vedad As Integer = hoy.Year - _fechaNacimiento.Year
            Return vedad
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As DateTime)
        _nombre = nombre
        Me.apellidos = apellidos
        _fechaNacimiento = fechaNacimiento
    End Sub

    Public Sub New(ByVal nombre As String, ByVal apellidos As String)
        _nombre = nombre
        Me.apellidos = apellidos
    End Sub

    Public Function Aguinaldo(ByVal fechaContratacion As DateTime) As Decimal
        Dim vaguinaldo As Decimal
        vaguinaldo = sueldoMensual / 24 * (diasLaborados(fechaContratacion) / 365)
        Return vaguinaldo
    End Function

    Private Function diasLaborados(ByVal fechaContratacion As DateTime) As Integer
        Dim hoy As DateTime = DateTime.Now
        Dim fechaInicio As DateTime = If(fechaContratacion.Year < hoy.Year, New DateTime(hoy.Year, 1, 1), fechaContratacion)
        Dim fechaFinal As DateTime = New DateTime(hoy.Year, 12, 31)
        Dim fechaDiff As TimeSpan = fechaFinal.Subtract(fechaInicio)
        Return fechaDiff.Days
    End Function

    Protected Function AguinaldoProtegido(ByVal fechaContratacion As DateTime) As Decimal
        Dim aguinaldo As Decimal
        aguinaldo = sueldoMensual / 24 * (diasLaborados(fechaContratacion) / 365)
        Return aguinaldo
    End Function

    Friend Function AguinaldoInterno(ByVal fechaContratacion As DateTime) As Decimal
        Dim aguinaldo As Decimal
        aguinaldo = sueldoMensual / 24 * (diasLaborados(fechaContratacion) / 365)
        Return aguinaldo
    End Function

    Protected Friend Function AguinaldoProtegidoInterno(ByVal fechaContratacion As DateTime) As Decimal
        Dim aguinaldo As Decimal
        aguinaldo = sueldoMensual / 24 * (diasLaborados(fechaContratacion) / 365)
        Return aguinaldo
    End Function

    Private Protected Function AguinaldoPrivadoProtegido(ByVal fechaContratacion As DateTime) As Decimal
        Dim aguinaldo As Decimal
        aguinaldo = sueldoMensual / 24 * (diasLaborados(fechaContratacion) / 365)
        Return aguinaldo
    End Function

    Public Shared Function diasLaboradosEstaticos(ByVal fechaContratacion As DateTime) As Integer
        Dim hoy As DateTime = DateTime.Now
        Dim fechaInicio As DateTime = If(fechaContratacion.Year < hoy.Year, New DateTime(hoy.Year, 1, 1), fechaContratacion)
        Dim fechaFinal As DateTime = New DateTime(hoy.Year, 12, 31)
        Dim fechaDiff As TimeSpan = fechaFinal.Subtract(fechaInicio)
        Return fechaDiff.Days
    End Function

    Public Overrides Function ToString() As String
        Return "Empleado: " & nombre & " " & apellidos
    End Function
End Class

