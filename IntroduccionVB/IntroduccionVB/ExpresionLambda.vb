Imports System.Linq.Expressions

Public Class ExpresionLambda
    Shared cuadrado As Func(Of Integer, Integer) = Function(x) x * x
    Shared EsTres As Func(Of Integer, Boolean) = Function(b) b = 3
    Shared EsJorge As Func(Of Empleado, Boolean) = Function(empleado) empleado.nombre = "David"

    Public Shared Sub Presentacion()
        Console.WriteLine(cuadrado(3))
        Console.WriteLine(EsTres(2))
        Console.WriteLine(EsTres(3))
        Dim empleado1 As Empleado = New Empleado() With {
            .idEstado = 1,
            .nombre = "Jose"
        }
        Dim empleado2 As Empleado = New Empleado() With {
            .idEstado = 2,
            .nombre = "David"
        }
        Console.WriteLine(EsJorge(empleado1))
        Console.WriteLine(EsJorge(empleado2))
        Dim e As Expression(Of Func(Of Integer, Integer)) = Function(x) x * x
        Console.WriteLine(e)
        Dim entero As Integer() = {2, 3, 4, 5}
        Dim enteroCuadrado = entero.[Select](Function(x) x * x)

        For Each num As Integer In enteroCuadrado
            Console.WriteLine(num)
        Next
    End Sub
End Class

