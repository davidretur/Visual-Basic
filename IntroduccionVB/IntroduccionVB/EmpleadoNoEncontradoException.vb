Public Class EmpleadoNoEncontradoException
    Inherits Exception

    Public Sub New()
        Console.WriteLine("El empleado no se encontró")
    End Sub

    Public Sub New(ByVal mensaje As String)
        MyBase.New(mensaje)
        Console.WriteLine("El empleado no se encontró: " & mensaje)
    End Sub

    Public Sub New(ByVal mensaje As String, ByVal Exinner As Exception)
        MyBase.New(mensaje, Exinner)
        Console.WriteLine($"El empleado no se encontró: {mensaje}, mensaje original: {Exinner.Message}")
    End Sub
End Class

