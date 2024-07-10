Public Class CuerpoExpresion
    Private Shared nombre As String = "David"
    Private Shared apellidos As String = "Duarte Hernandez"

    Public Shared Sub Sintaxis()
        Console.WriteLine("Una definición de cuerpo de expresión tiene la siguiente sintaxis general: " & vbLf & " member => expression;")
    End Sub

    Public Shared Sub LLamaExpresion()
        nombre = "David"
        apellidos = "Duarte"
        Dim nombreCompleto As String
        nombreCompleto = NombreDetallado()
        Console.WriteLine(nombreCompleto)
        nombreCompleto = NombreSemidetallado()
        Console.WriteLine(nombreCompleto)
        nombreCompleto = NombreDetallado("David", "Duarte")
        Console.WriteLine(nombreCompleto)
        nombreCompleto = NombreSemidetallado("David", "Duarte")
        Console.WriteLine(nombreCompleto)
        nombreCompleto = NombreCuerpoExpresion()
        Console.WriteLine(nombreCompleto)
        nombreCompleto = NombreCuerpoExpresion("David", "Duarte")
        Console.WriteLine(nombreCompleto)
    End Sub

    Private Shared Function NombreDetallado() As String
        Dim nombreCompleto As String
        nombreCompleto = $"{nombre} {apellidos}".Trim()
        Return nombreCompleto
    End Function

    Private Shared Function NombreSemidetallado() As String
        Return $"{nombre} {apellidos}".Trim()
    End Function

    Private Shared Function NombreDetallado(ByVal nombre As String, ByVal apellidos As String) As String
        Dim nombreCompleto As String
        nombreCompleto = $"{nombre} {apellidos}".Trim()
        Return nombreCompleto
    End Function

    Private Shared Function NombreSemidetallado(ByVal nombre As String, ByVal apellidos As String) As String
        Return $"{nombre} {apellidos}".Trim()
    End Function

    Private Shared Function NombreCuerpoExpresion() As String
        Return $"{nombre} {apellidos}".Trim()
    End Function

    Private Shared Function NombreCuerpoExpresion(ByVal nombre As String, ByVal apellidos As String) As String
        Return $"{nombre} {apellidos}".Trim()
    End Function
End Class
