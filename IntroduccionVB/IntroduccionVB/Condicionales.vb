Public Class Condicionales
    Public Shared Sub CondicionalIF()
        Dim nombre As String = "David"
        If nombre.Equals("David") Then Console.WriteLine("El nombre es igual a David")

        If nombre.StartsWith("David") Then
            Console.WriteLine("El nombre empieza con David")
        Else
            Console.WriteLine("El nombre NO empieza con David")
        End If

        If nombre.EndsWith("Duarte") Then
            Console.WriteLine("El nombre termina con David")
        Else
            Console.WriteLine("El nombre NO termina con David")
        End If

        Dim a, b, c As Integer
        a = 5
        b = 5
        c = 6

        If a = b Then
            Console.WriteLine("a({0}) es igual a b({1})", a, b)
        Else
            Console.WriteLine("a({0}) es diferente a b({1})", a, b)
        End If

        If a <> b Then
            Console.WriteLine("a({0}) es diferente de b({1})", a, b)
        Else
            Console.WriteLine("a({0}) es igual a b({1})", 1, b)
        End If

        If c > b Then
            Console.WriteLine("c({0}) es mayor que b({1}) ", c, b)
        Else
            Console.WriteLine("c({0}) NO es mayor que b({1})", c, b)
        End If

        If b < c Then
            Console.WriteLine("b({0}) es menor que c({1}) ", b, c)
        Else
            Console.WriteLine("b {0} NO es menor que c({1})", b, c)
        End If

        If a >= b Then
            Console.WriteLine("a{0} es mayor o igual que {1} ", a, b)
        Else
            Console.WriteLine("a{0} NO es mayor NI igual que b{1}", a, b)
        End If

        If a <= b Then
            Console.WriteLine("a{0} es menor o igual que b{1} ", a, b)
        Else
            Console.WriteLine("{0} NO es menor NI igual que {1}")
        End If

        If a + b > 8 Then
            Console.WriteLine("a más b es mayor a 10")
        Else
            Console.WriteLine("a más b es menor o igual a 10")
        End If
    End Sub

    Public Shared Sub OperadoresCondicionales()
        Dim boleano As Boolean = True
        boleano = Not boleano
        Dim vboleano1 As Boolean = True
        Dim vboleano2 As Boolean = True
        Dim fboleano1 As Boolean = False
        Dim fboleano2 As Boolean = False
        Console.WriteLine("Operador de Negación ! ")
        Console.WriteLine($"Operado vboleano1 = {vboleano1} ")
        Console.WriteLine($"Operado !vboleano1 = {Not vboleano1} ")
        Console.WriteLine($"Operado fboleano1 = {fboleano1} ")
        Console.WriteLine($"Operado !fboleano1 = {Not fboleano1} ")
        Console.ReadKey()
        Console.WriteLine("Operador lógico AND (Y) &")

        If vboleano1 And vboleano2 Then
            Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 And vboleano2}) ")
        Else
            Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 And vboleano2}) ")
        End If

        Console.WriteLine("Tabla de verdad operador AND (Y) &")
        Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 And vboleano2} ) ")
        Console.WriteLine($"{vboleano1} Y {fboleano2} => ({vboleano1 And fboleano2} ) ")
        Console.WriteLine($"{fboleano1} Y {vboleano2} => ({fboleano1 And vboleano2} ) ")
        Console.WriteLine($"{fboleano1} Y {fboleano2} => ({fboleano1 And fboleano2} ) ")
        Console.ReadKey()
        Dim r As Boolean = PrimerOperando() And SegundoOperando()
        Dim f As Boolean = False And SegundoOperando()
        Dim b As Boolean = True And SegundoOperando()
        Console.WriteLine(b)
        Console.ReadKey()
        r = PrimerOperando() AndAlso SegundoOperando()
        r = False AndAlso SegundoOperando()
        Console.WriteLine(r)
        b = True AndAlso SegundoOperando()
        Console.WriteLine(b)
        Console.ReadKey()
        Console.WriteLine("Operador AND lógico condicional &&")
        Console.WriteLine("El operador AND lógico condicional &&, 
                también denominado operador AND lógico de cortocircuito,
                calcula el operador AND lógico de sus operandos. 
                El resultado de x && y es true si x y y se evalúan como true. 
                De lo contrario, el resultado es false. 
                Si x se evalúa como false, y NO SE EVALÚA")
        r = False AndAlso SegundoOperando()
        Console.WriteLine(r)
        b = True AndAlso SegundoOperando()
        Console.WriteLine(b)
        Console.ReadKey()
        Console.WriteLine("Operador lógico OR (O) |")

        If vboleano1 Or vboleano2 Then
            Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 Or vboleano2}) ")
        Else
            Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 Or vboleano2}) ")
        End If

        Console.WriteLine("Tabla de verdad operador OR (O) |")
        Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 Or vboleano2} ) ")
        Console.WriteLine($"{vboleano1} Ó {fboleano2} => ({vboleano1 Or fboleano2} ) ")
        Console.WriteLine($"{fboleano1} Ó {vboleano2} => ({fboleano1 Or vboleano2} ) ")
        Console.WriteLine($"{fboleano1} Ó {fboleano2} => ({fboleano1 Or fboleano2} ) ")
        Console.ReadKey()
        r = PrimerOperando() Or SegundoOperando()
        r = False Or SegundoOperando()
        b = True Or SegundoOperando()
        Console.WriteLine(b)
        Console.ReadKey()
        Console.WriteLine("Operador OR lógico condicional ||")
        Console.WriteLine("El operador OR lógico condicional ||, 
                también denominado operador OR lógico de cortocircuito,
                calcula el operador OR lógico de sus operandos. 
                El resultado de x || y es VERDADERO si x Ó y se evalúan como VERDADERO. 
                De lo contrario, el resultado es FALSO. 
                Si x se evalúa como VERDADERO, y NO SE EVALÚA")
        r = False OrElse SegundoOperando()
        Console.WriteLine(r)
        b = True OrElse SegundoOperando()
        Console.WriteLine(b)
        Console.ReadKey()
        Console.WriteLine("Operador lógico OR EXCLUSIVO (XOR) ^")
        Console.WriteLine("El operador OR ^, 
                también denominado operador OR lógico de exclusivo,
                El resultado de x ^ y es VERDADERO si x Ó y se evalúan como VERDADERO, 
                pero no ambos. 
                De lo contrario, el resultado es FALSO. ")

        If vboleano1 Xor vboleano2 Then
            Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 Xor vboleano2}) ")
        Else
            Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 Xor vboleano2}) ")
        End If

        Console.WriteLine("Tabla de verdad operador OR (O) ^")
        Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 Xor vboleano2} ) ")
        Console.WriteLine($"{vboleano1} Ó exclusivo {fboleano2} => ({vboleano1 Xor fboleano2} ) ")
        Console.WriteLine($"{fboleano1} Ó exclusivo {vboleano2} => ({fboleano1 Xor vboleano2} ) ")
        Console.WriteLine($"{fboleano1} Ó exclusivo {fboleano2} => ({fboleano1 Xor fboleano2} ) ")
        Console.ReadKey()
        Dim a1 As Integer = 5
        Dim b1 As Integer = 3
        Dim c1 As Integer = 4

        If (a1 + b1 + c1 > 10) AndAlso (a1 = b1) Then
            Console.WriteLine("La suma es mayor a 10")
            Console.WriteLine("y el primer número es igual al segundo")
        Else
            Console.WriteLine("La suma NO es mayor a 10")
            Console.WriteLine("O el primer número NO es igual al segundo")
        End If

        If (a1 + b1 + c1 > 10) OrElse (a1 = b1) Then
            Console.WriteLine("La suma es mayor a 10")
            Console.WriteLine("O el primer número es igual al segundo")
        Else
            Console.WriteLine("La suma NO es mayor a 10")
            Console.WriteLine("Y el primer número NO es igual al segundo")
        End If
    End Sub

    Private Shared Function PrimerOperando() As Boolean
        Console.WriteLine("Primer operando es evaluado.")
        Return False
    End Function

    Private Shared Function SegundoOperando() As Boolean
        Console.WriteLine("Segundo operando es evalualado.")
        Return True
    End Function

    Public Shared Sub OperadoresCondicionalesExp()
        Dim r As Boolean
        Dim vboleano1 As Boolean = True
        Dim vboleano2 As Boolean = True
        Dim fboleano1 As Boolean = False
        Dim fboleano2 As Boolean = False
        Console.WriteLine($"{vboleano1}")
        Console.WriteLine($"{Not vboleano1}")
        Console.WriteLine($"{Not fboleano1}")
        Console.WriteLine($"{Not fboleano1}")

        If vboleano1 And vboleano2 Then
            Console.WriteLine($"vboleano1 Y vboleano2 son verdaderos")
        Else
            Console.WriteLine($"vboleano1 ó vboleano2 es falso ")
        End If

        If vboleano1 And fboleano2 Then
            Console.WriteLine($"vboleano1 Y fboleano1 son verdaderos")
        Else
            Console.WriteLine($"vboleano1 ó fboleano1 es falso ")
        End If

        r = False And SegundoOperando()
        Console.WriteLine(r)
        r = True And SegundoOperando()
        Console.WriteLine(r)
        r = PrimerOperando() And SegundoOperando()
        Console.WriteLine(r)
        r = False AndAlso SegundoOperando()
        Console.WriteLine(r)
        r = True AndAlso SegundoOperando()
        Console.WriteLine(r)
        r = PrimerOperando() AndAlso SegundoOperando()
        Console.WriteLine(r)

        If vboleano1 Or fboleano1 Then
            Console.WriteLine($"vboleano1 Ó vboleano2 es verdadero")
        Else
            Console.WriteLine($"vboleano1 Y vboleano2 son falsos")
        End If

        r = False Or SegundoOperando()
        Console.WriteLine(r)
        r = True Or SegundoOperando()
        Console.WriteLine(r)
        r = SegundoOperando() Or PrimerOperando()
        Console.WriteLine(r)
        r = False OrElse SegundoOperando()
        Console.WriteLine(r)
        r = True OrElse SegundoOperando()
        Console.WriteLine(r)
        r = SegundoOperando() OrElse PrimerOperando()
        Console.WriteLine(r)

        If vboleano1 Xor vboleano2 Then
            Console.WriteLine($"vboleano1 Ó vboleano2 es verdadero pero no ambos")
        Else
            Console.WriteLine($"vboleano1 Y vboleano2 son verdaderos o ambos son falsos")
        End If

        Dim a1 As Integer = 5
        Dim b1 As Integer = 3
        Dim c1 As Integer = 4

        If (a1 + b1 + c1 > 10) AndAlso (a1 = b1) Then
            Console.WriteLine("La suma de a1 + b1 + c1 es mayor que 10")
            Console.WriteLine("Y a1 es igual a b1")
        Else
            Console.WriteLine("La suma de a1 + b1 + c1 NO es mayor que 10")
            Console.WriteLine("O a1 NO es igual b1")
        End If

        If (a1 + b1 + c1 > 10) OrElse (a1 = b1) Then
            Console.WriteLine("La suma de a1 + b1 + c1 es mayor que 10")
            Console.WriteLine("O a1 es igual b1")
        Else
            Console.WriteLine("La suma de a1 + b1 + c1 NO es mayor que 10")
            Console.WriteLine("Y a1 es diferente a b1")
        End If
    End Sub

    Public Shared Sub CondicionalSwitch()
        Dim caseSwitch As Integer = 1

        Select Case caseSwitch
            Case 1
                Console.WriteLine($"caseSwitch es 1")
            Case 2, 3
                Console.WriteLine("caseSwitch es 2 ó 3")
            Case Else
                Console.WriteLine("caseSwitch no es ni 1, ni 2, ni 3")
        End Select

        Dim c As Color = CType(3, Color)

        Select Case c
            Case Color.Rojo
                Console.WriteLine("El color es Rojo")
            Case Color.Verde
                Console.WriteLine("El color es Verde")
            Case Color.Azul
                Console.WriteLine("El color es Azul")
            Case Else
                Console.WriteLine("El color es desconocido.")
        End Select

        If c = Color.Rojo Then
            Console.WriteLine("El color es Rojo")
        ElseIf c = Color.Verde Then
            Console.WriteLine("El color es Verde")
        ElseIf c = Color.Azul Then
            Console.WriteLine("El color es Azul")
        Else
            Console.WriteLine("El color es desconocido.")
        End If

        Dim caseSwitchCadena As String = "Dos"

        Select Case caseSwitchCadena
            Case "Uno"
                Console.WriteLine($"caseSwitchCadena es {caseSwitchCadena}")
            Case "Dos", "Tres"
                Console.WriteLine($"caseSwitchCadena es {caseSwitchCadena}")
            Case Else
                Console.WriteLine($"caseSwitchCadena tierne un valor inesperado ({caseSwitch})")
        End Select
    End Sub

    Public Shared Sub OperadorCondicionalTerniario()
        Console.WriteLine("El operador condicional ?:, también conocido como operador condicional ternario, 
                                evalúa una expresión booleana y devuelve el resultado de una de las dos expresiones,
en función de que la expresión booleana se evalúe como true o false, 
tal y como se muestra en el siguiente ejemplo:")
        Console.WriteLine("sintaxis " & vbLf & " condition ? consequent : alternative")
        Dim temperatura As Decimal = 14.5D
        Dim resultado As String = If(temperatura < 20D, "Frio", "Caluroso!")
        Console.WriteLine(resultado)

        If temperatura < 20D Then
            resultado = "Frio"
        Else
            resultado = "Caluroso!"
        End If

        Console.WriteLine(resultado)
        temperatura = 24.5D
        resultado = If(temperatura < 20D, "Frio", "Caluroso!")
        Console.WriteLine(resultado)
        temperatura = 22.5D
        resultado = If(temperatura < 20D, "Frio", If(temperatura < 23D, "Perfecto", "Caluroso!"))
        Console.WriteLine(resultado)
        resultado = If(temperatura < 20D, "Frio", (If(temperatura < 23D, "Perfecto", "Caluroso!")))
        Console.WriteLine(resultado)

        If temperatura < 20D Then
            resultado = "Frio"
        Else

            If temperatura < 23D Then
                resultado = "Perfecto"
            Else
                resultado = "Caluroso!"
            End If
        End If

        Console.WriteLine(resultado)
    End Sub

    Public Shared Sub OperadorCondicionalTerniarioExpo()
        Dim temperatura As Decimal = 24.5D
        Dim resultado As String = If(temperatura < 20D, "Frio", "Caluroso!")
        Console.WriteLine(resultado)
        temperatura = 22.5D
        resultado = If(temperatura < 20D, "Frio", (If(temperatura < 23D, "Perfecto", "Caluroso!")))
        Console.WriteLine(resultado)
        resultado = If(temperatura < 20D, "Frio", If(temperatura < 23D, "Perfecto", "Caluroso!"))
        Console.WriteLine(resultado)
    End Sub

    Public Shared Sub OperadorUsoCombinadoNull()
        Console.WriteLine("El operador de uso combinado de NULL ?? 
devuelve el valor del operando izquierdo si no es null; en caso contrario, 
evalúa el operando derecho y devuelve su resultado. 
El operador ?? no evalúa su operando derecho si el operando izquierdo se evalúa como no NULL.")
        Dim a As Integer? = Nothing
        Dim b As Integer? = If(a, 5)
        Console.WriteLine(b)
        Dim c As Integer? = If(b, 10)
        Console.WriteLine(c)
    End Sub

    Public Enum Color
        Rojo
        Verde
        Azul
    End Enum
End Class

