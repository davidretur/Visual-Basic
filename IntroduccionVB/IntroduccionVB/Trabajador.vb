Public Class Trabajador
    Inherits Persona

    Public Overridable Property sueldo As Decimal

    Public Sub New()
    End Sub

    Public Sub New(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As DateTime)
        MyBase.New(nombre, apellidos, fechaNacimiento)
    End Sub

    Public Overrides Function ClaveUnica() As String
        Return nombre.Substring(0, 2) + edad().ToString() + apellidos.Substring(0, 2)
    End Function

    Public Overridable Function Aguinaldo(ByVal diaslaborados As Integer) As Decimal
        Dim vaguinaldo As Decimal
        vaguinaldo = sueldo / 24 * (diaslaborados / 365)
        Return vaguinaldo
    End Function

    Public Overrides Function ToString() As String
        Return "Trabajador: " & nombre & " " + apellidos & "sueldo: " & sueldo.ToString()
    End Function
End Class

