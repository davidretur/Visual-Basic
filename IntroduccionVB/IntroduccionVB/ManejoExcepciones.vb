Public Class ManejoExcepciones
    Public Shared Sub LLamaExcepcion(ByVal iex As Integer)
        Try

            Select Case iex
                Case 1
                    ExcepcionInvalidCast()
                Case 2
                    ExcepcionOutOfRange()
                Case 3
                    LevantaExcepcionInvalidOperation()
                Case 4
                    LevantaExcepcionEmpleado()
                Case 5
                    LevantaExcepcionGenerica()
                Case 6
                    ExcepcionControlada()
            End Select

        Catch e As FormatException
            Console.WriteLine("Error de conversión " & e.Message)
        Catch e As IndexOutOfRangeException
            Console.WriteLine("índice fuera de rango " & e.Message)
        Catch e As InvalidOperationException
            Console.WriteLine("Operacion Invalida " & e.Message)
        Catch e As EmpleadoNoEncontradoException
            Console.WriteLine("Excepción de usuario " & e.Message)
        Catch e As NullReferenceException
            Console.WriteLine("Excepción de usuario " & e.Message)
        Catch e As Exception
            Console.WriteLine("Excepción General " & e.Message)
        Finally
            Console.WriteLine("El finally siempre se ejecuta")
        End Try
    End Sub

    Public Shared Sub ExcepcionInvalidCast()
        Dim num As Integer
        Dim snum As String
        snum = "mil quinientos"
        num = Convert.ToInt32(snum)
    End Sub

    Public Shared Sub ExcepcionOutOfRange()
        Dim num As Integer() = {1, 2, 3, 4}
        Dim i As Integer = num(5)
    End Sub

    Public Shared Sub LevantaExcepcionInvalidOperation()
        Throw New InvalidOperationException("El empleado no se puede eliminar")
    End Sub

    Public Shared Sub LevantaExcepcionGenerica()
        Throw New Exception("Excepción provocada")
    End Sub

    Public Shared Sub LevantaExcepcionEmpleado()
        Throw New EmpleadoNoEncontradoException("id 3455")
    End Sub

    Public Shared Sub ExcepcionControlada()
        Try
            Dim num As Integer
            Dim snum As String
            snum = "mil quinientos"
            num = Convert.ToInt32(snum)
        Catch e As Exception
            Console.WriteLine("Excepción Controlada " & e.Message)
            Throw New Exception("Excepción provocada", e)
        Finally
            Console.WriteLine("El finally siempre se ejecuta")
        End Try
    End Sub
End Class

Public Class CreaExcepcion
    Public Shared Sub ExcepcionControlada()
        Dim num As Integer
        Dim snum As String
        snum = "mil quinientos"
        num = Convert.ToInt32(snum)
    End Sub
End Class

Public Class LevantaExcepciones
    Private _nombre As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                Throw New ArgumentNullException(paramName:=NameOf(value), message:="El nombre no puede ser nulo")
            Else
                _nombre = value
            End If
        End Set
    End Property

    Public Shared Sub UsoThrow(ByVal sueldo As Decimal, ByVal empleados As List(Of Empleado))
        If sueldo <= 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(sueldo), "El sueldo debe ser positivo.")
        End If
        If empleados.Count >= 1 Then
            Dim _nombre As String = empleados(0).nombre
        Else
            Throw New ArgumentException("NO existe ningún empleado")
        End If
    End Sub

    Public Shared Sub EliminarEmpleado(ByVal id As Integer)
        Throw New EmpleadoNoEncontradoException($"id {id}")
    End Sub

    Public Shared Sub ProcesoExcepcion(ByVal snum As String, ByVal idx As Integer)
        Try
            Dim num As Integer
            num = Convert.ToInt32(snum)
            Dim arrnum As Integer() = {1, 2, 3, 4}
            Dim i As Integer = arrnum(idx)
            EliminarEmpleado(id:=5)
            Console.WriteLine("Proceso Exitoso")
        Catch e As FormatException
            Console.WriteLine("Error de conversión " & e.Message)
        Catch e As IndexOutOfRangeException
            Console.WriteLine("índice fuera de rango " & e.Message)
        Catch e As InvalidOperationException
            Console.WriteLine("Operacion Invalida " & e.Message)
        Catch e As EmpleadoNoEncontradoException
            Console.WriteLine("Excepción de usuario " & e.Message)
        Catch e As NullReferenceException
            Console.WriteLine("Excepción de usuario " & e.Message)
        Catch e As Exception
            Console.WriteLine("Excepción General " & e.Message)
        Finally
            Console.WriteLine("El finally siempre se ejecuta")
        End Try
    End Sub
End Class

