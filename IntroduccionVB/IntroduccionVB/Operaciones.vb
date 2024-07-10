Public Class Operaciones
    Public Shared Sub numeros()
        Dim entero1, entero2, rentero As Integer
        Dim flotante1, flotante2, rflotante As Single
        Dim decimal1, decimal2, rdecimal As Decimal
        entero1 = 5
        entero2 = 2
        flotante1 = 5.5F
        flotante2 = 2.5F
        decimal1 = 5.5D
        decimal2 = 2.5D
        Console.WriteLine("Operador de suma +")
        rentero = entero1 + entero2
        rflotante = flotante1 + flotante2
        rdecimal = decimal1 + decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador de resta -")
        rentero = entero1 - entero2
        rflotante = flotante1 - flotante2
        rdecimal = decimal1 - decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador de multiplicacion *")
        rentero = entero1 * entero2
        rflotante = flotante1 * flotante2
        rdecimal = decimal1 * decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador de división /")
        rentero = entero1 / entero2
        rflotante = flotante1 / flotante2
        rdecimal = decimal1 / decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador Residuo %")
        rentero = entero1 Mod entero2
        rflotante = flotante1 Mod flotante2
        rdecimal = decimal1 Mod decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador unario menos -")
        Console.WriteLine(-entero1)
        Console.WriteLine(-(-entero1))
        Console.ReadKey()
        Console.WriteLine("Operador de incremento prefijo")
        entero1 = 5
        Console.WriteLine(entero1)
        Console.WriteLine(System.Threading.Interlocked.Increment(entero1))
        Console.WriteLine(entero1)
        Console.ReadKey()
        Console.WriteLine("Operador de incremento sufijo")
        entero1 = 5
        Console.WriteLine(entero1)
        Console.WriteLine(Math.Min(System.Threading.Interlocked.Increment(entero1), entero1 - 1))
        Console.WriteLine(entero1)
        Console.WriteLine("Operador de decremento prefijo")
        entero1 = 5
        Console.WriteLine(entero1)
        Console.WriteLine(System.Threading.Interlocked.Decrement(entero1))
        Console.WriteLine(entero1)
        Console.ReadKey()
        Console.WriteLine("Operador de decremento sufijo")
        entero1 = 5
        Console.WriteLine(entero1)
        Console.WriteLine(Math.Max(System.Threading.Interlocked.Decrement(entero1), entero1 + 1))
        Console.WriteLine(entero1)
        Console.ReadKey()
        Console.WriteLine("Asignación Compuesta")
        entero1 = 5
        entero1 += 9
        Console.WriteLine(entero1)
        entero1 -= 4
        Console.WriteLine(entero1)
        entero1 *= 2

        Console.WriteLine(entero1)
        entero1 /= 4
        Console.WriteLine(entero1)
        entero1 = entero1 Mod 3
        Console.WriteLine(entero1)
    End Sub

    Public Shared Sub numerosExpo()
        Dim entero1, entero2, rentero As Integer
        Dim flotante1, flotante2, rflotante As Single
        Dim decimal1, decimal2, rdecimal As Decimal
        entero1 = 5
        entero2 = 2
        flotante1 = 5.5F
        flotante2 = 2.5F
        decimal1 = 5.5D
        decimal2 = 2.5D
        rentero = entero1 + entero2
        rflotante = flotante1 + flotante2
        rdecimal = decimal1 + decimal2
        rentero = entero1 - entero2
        rflotante = flotante1 - flotante2
        rdecimal = decimal1 - decimal2
        rentero = entero1 * entero2
        rflotante = flotante1 * flotante2
        rdecimal = decimal1 * decimal2
        rentero = entero1 / entero2
        rflotante = flotante1 / flotante2
        rdecimal = decimal1 / decimal2
        rentero = entero1 Mod entero2
        rflotante = flotante1 Mod flotante2
        rdecimal = decimal1 Mod decimal2
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        Console.WriteLine("Operador Residuo %")
        Console.WriteLine(rentero)
        Console.WriteLine(rflotante)
        Console.WriteLine(rdecimal)
        Console.ReadKey()
        entero1 = 5
        Console.WriteLine(-entero1)
        Console.WriteLine(-(-entero1))
        Console.ReadKey()
        entero1 = 5
        Console.WriteLine(System.Threading.Interlocked.Increment(entero1))
        Console.WriteLine(entero1)
        entero1 = 5
        Console.WriteLine(Math.Min(System.Threading.Interlocked.Increment(entero1), entero1 - 1))
        Console.WriteLine(entero1)
        entero1 = 5
        Console.WriteLine(System.Threading.Interlocked.Decrement(entero1))
        Console.WriteLine(entero1)
        entero1 = 5
        Console.WriteLine(Math.Max(System.Threading.Interlocked.Decrement(entero1), entero1 + 1))
        Console.WriteLine(entero1)
        entero1 = 5
        entero1 += 9
        Console.WriteLine(entero1)
        entero1 -= 4
        Console.WriteLine(entero1)
        entero1 *= 2
        Console.WriteLine(entero1)
        entero1 /= 4
        Console.WriteLine(entero1)
        entero1 = entero1 Mod 3
        Console.WriteLine(entero1)
    End Sub

    Public Shared Sub cadenas()
        Dim nombre As String = "Jorge"
        Dim primerApellido As String = "Valdivia"
        Dim segundoApellido As String = "Rosas"
        Dim nombreCompleto As String = nombre & " " & primerApellido & " " & segundoApellido
        nombre = nombre & " "
        nombre += " "
        nombre += primerApellido
        nombre += " "
        nombre += segundoApellido
        Dim s5 As String = "Printing backwards"

        For i As Integer = 0 To s5.Length - 1
            Console.Write(s5(s5.Length - i - 1))
        Next
    End Sub
End Class

