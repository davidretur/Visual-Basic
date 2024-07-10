Public Class Directivo
    Inherits Empleado

    Public Sub New()
    End Sub

    Public Sub New(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As DateTime)
        MyBase.New(nombre, apellidos, fechaNacimiento)
    End Sub

    Public Sub Accesar()
        Dim aguinaldo As Decimal = Me.Aguinaldo(New DateTime(2021, 6, 1))
        aguinaldo = AguinaldoInterno(New DateTime(2021, 6, 1))
        aguinaldo = AguinaldoProtegidoInterno(New DateTime(2021, 6, 1))
        aguinaldo = AguinaldoProtegido(New DateTime(2021, 6, 1))
        aguinaldo = AguinaldoPrivadoProtegido(New DateTime(2021, 6, 1))
    End Sub
End Class
