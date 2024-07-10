Public Class Cadenas
    Class SurroundingClass
        Public Shared Sub CadenaLiteral()
            Dim cadena As String
            Dim ruta As String = "c:\Documentos\DiplomadoNet"
            Console.WriteLine(ruta)
            ruta = "c:\Documentos\DiplomadoNet"
            Console.WriteLine(ruta)
            cadena = ("En un string \ es el caracter de escape: " & vbLf & " Nueva línea & " & vbTab & " Tabulador")
            Console.WriteLine(cadena)
            cadena = ("En un string \ es el caracter de escape: \n & \t")
            Console.WriteLine(cadena)
            Dim texto As String = " Secuencias de Escape
            \a Alerta  0x0007
            \b Retroceso   0x0008
            \f Avance de página    0x000C
            \n Nueva línea 0x000A
            \r Retorno de carro    0x000D
            \t Tabulación horizontal   0x0009
            \v Tabulación vertical 0x000B"
            Console.WriteLine(texto)
            Dim quote As String = "Estamos estudiando con ""TICH"""
            Console.WriteLine(quote)
        End Sub

        Public Shared Sub Concatenacion()
            Dim nombre As String = "David"
            Dim primerApellido As String = "Duarte"
            Dim segundoApellido As String = "Hernandez"
            Dim nombreCompleto As String = nombre & " " & primerApellido & " " & segundoApellido
            Console.WriteLine(nombreCompleto)
            nombre = nombre & " "
            nombre += " "
            nombre += primerApellido
            nombre += " "
            nombre += segundoApellido
            Console.WriteLine(nombre)
        End Sub

        Public Shared Sub CadenasVaciasYNulas()
            Dim cadena As String = "Hola"
            Dim cadenaNula As String = Nothing
            Dim cadenaVacia As String = String.Empty
            Dim cadenaPaso As String = cadena & cadenaNula
            Console.WriteLine(cadenaPaso)
            cadenaPaso = cadena & cadenaVacia
            Console.WriteLine(cadenaPaso)
            Dim nuevaCadenaVacia As String = cadenaVacia & cadenaNula
            Console.WriteLine(nuevaCadenaVacia)
            Console.WriteLine(cadenaVacia.Length)
            Console.WriteLine(nuevaCadenaVacia.Length)
            Dim b As Boolean = (cadenaVacia = cadenaNula)
            Console.WriteLine(b)
            Dim s1 As String = vbNullChar & "abc"
            Dim s2 As String = "abc" & vbNullChar
            Console.WriteLine("*" & s1 & "*")
            Console.WriteLine("*" & s2 & "*")
            Console.WriteLine(s2.Length)
        End Sub

        Public Shared Sub FormatoCompuesto()
            Dim nombre As String = "David"
            Dim primerApellido As String = "Duarte"
            Dim segundoApellido As String = "Hernandez"
            Dim edad As Integer = 35
            Console.WriteLine("{0} {1} {2} es el instructor y tiene {3} años de edad.", nombre, primerApellido, segundoApellido, edad)
            Console.WriteLine("Hace {3} años nació {1} {2} {0}", nombre, primerApellido, segundoApellido, edad)
            Console.WriteLine("El nació en el año {0}.", 2022 - edad)
            Dim cadena As String
            cadena = String.Format("{0} {1} {2} es el instructor y tiene {3} años de edad.", nombre, primerApellido, segundoApellido, edad)
            Console.WriteLine(cadena)
            cadena = String.Format("Hace {3} años nació {1} {2} {0}", nombre, primerApellido, segundoApellido, edad)
            Console.WriteLine(cadena)
            cadena = String.Format("El nació en el año {0}.", 2021 - edad)
            Console.WriteLine(cadena)
        End Sub

        Public Shared Sub Interpolacion()
            Dim nombre As String = "David"
            Dim primerApellido As String = "Duarte"
            Dim segundoApellido As String = "Hernandez"
            Dim edad As Integer = 35
            Dim cadena As String
            cadena = $"{nombre} {primerApellido} {segundoApellido} es el instructor y tiene {edad} años de edad."
            Console.WriteLine(cadena)
            cadena = $"Hace {edad} años nació {primerApellido} {segundoApellido} {nombre}"
            Console.WriteLine(cadena)
            cadena = $"El nació en el año {2021 - edad}."
            Console.WriteLine(cadena)
            Console.WriteLine($"{nombre} {primerApellido} {segundoApellido} es el instructor y tiene {edad} años de edad.")
            Console.WriteLine($"Hace {edad} años nació {primerApellido} {segundoApellido} {nombre}")
            Console.WriteLine($"El nació en el año {2021 - edad}.")
        End Sub

        Public Shared Sub PropiedadesYMetodos()
            Dim nombre As String = "  David Duarte  "
            Console.WriteLine(nombre.Length)
            Console.WriteLine(nombre.ToUpper())
            Console.WriteLine(nombre.ToLower())
            Console.WriteLine(nombre.TrimEnd())
            Console.WriteLine(nombre.TrimStart())
            Console.WriteLine(nombre.Trim())
            Console.WriteLine(nombre.PadLeft(50))
            Console.WriteLine(nombre.PadLeft(50, "*"c))
            Console.WriteLine(nombre.PadRight(50))
            Console.WriteLine(nombre.PadRight(50, "*"c))
            Console.WriteLine(nombre.Substring(5, 3))
            Console.WriteLine(nombre.Remove(5, 5))
            Console.WriteLine(nombre.Replace("David", "Jose"))
            Console.WriteLine(nombre)
            nombre = nombre.Replace("David", "Jose")
            Console.WriteLine(nombre.IndexOf("Duarte", 2))
            Dim otroNombre As String = nombre
            Console.WriteLine(nombre.Equals(otroNombre))
            Console.WriteLine(nombre.CompareTo("David"))
            Console.WriteLine("David".CompareTo("David"))
            Console.WriteLine(nombre.Contains("David"))
            nombre = nombre.Trim()
            Console.WriteLine(nombre.StartsWith("David"))
            Console.WriteLine(nombre.EndsWith("David"))
            nombre = "David Duarte"
            Dim partesNombre As String() = nombre.Split(" "c)
            Console.WriteLine(partesNombre(0))
            Console.WriteLine(partesNombre(1))
            Console.WriteLine(partesNombre(2))
            Dim OtraVezCompleto As String = String.Join(" ", partesNombre)
            Console.WriteLine(OtraVezCompleto)
            Dim letras As Char() = nombre.ToCharArray()
            Console.WriteLine(letras(0))
            Console.WriteLine(letras(1))
            Console.WriteLine(letras(2))
            Console.WriteLine(letras(3))
            Console.WriteLine(letras(4))
        End Sub
    End Class
End Class
