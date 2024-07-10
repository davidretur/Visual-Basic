Public Class DeclaracionVariables
    Public Shared Sub NumerosEnteros()
        Dim enteroSbyte As SByte
        enteroSbyte = 127
        Console.WriteLine(enteroSbyte)
        Dim enterobyte As Byte
        enterobyte = 255
        Console.WriteLine(enterobyte)
        Dim enteroshort As Short
        enteroshort = -32767
        Console.WriteLine(enteroshort)
        Dim enteroushort As UShort
        enteroushort = 65535
        Console.WriteLine(enteroushort)
        Dim enteroint As Integer
        enteroint = 2147483647
        Console.WriteLine(enteroint)
        Dim enterouint As UInteger
        enterouint = 4294967295
        Console.WriteLine(enterouint)
        Dim enterolong As Long
        enterolong = 922337236854775807
        Console.WriteLine(enterolong)
        Dim enteroulong As ULong
        enteroulong = 1844674407370955161
        Console.WriteLine(enteroulong)
    End Sub
    Public Shared Sub NumerosFraccionados()
        Dim flotante As Single = 1.84467441E+19F
        Console.WriteLine(flotante)
        Dim doble As Double = 1844674407370.1235R
        Console.WriteLine(doble)
        Dim conDecimales As Decimal = 1234567.458967D
        Console.WriteLine(conDecimales)
    End Sub
    Public Shared Sub Cadenas()
        Dim caracter As Char
        Dim cadena As String
        caracter = "a"c
        Console.WriteLine(caracter)
        cadena = Nothing
        cadena = String.Empty
        cadena = "Esta es una cadena de caracteres"
        Console.WriteLine(cadena)
    End Sub
    Public Shared Sub Boleanos()
        Dim boleano As Boolean
        boleano = True
        boleano = False
        Console.WriteLine(boleano)
    End Sub
    Public Shared Sub Fechas()
        Dim fechaHora As DateTime
        fechaHora = New DateTime(2022, 1, 1, 8, 30, 52)
        Console.WriteLine(fechaHora)
    End Sub
    Public Shared Sub DeclaracionVar()
        Dim aas = 127
        Console.WriteLine(aas)
        Dim enterobyte = 255
        Console.WriteLine(enterobyte)
        Dim enteroshort = -32767
        Console.WriteLine(enteroshort)
        Dim enteroushort = 65535
        Console.WriteLine(enteroushort)
        Dim enteroint = 2147483647
        Console.WriteLine(enteroint)
        Dim enterouint = 4294967295
        Console.WriteLine(enterouint)
        Dim enterolong = 922337236854775807
        Console.WriteLine(enterolong)
        Dim enteroulong = 1844674407370955161
        Console.WriteLine(enteroulong)
        Dim flotante = 1.84467441E+19F
        Console.WriteLine(flotante)
        Dim doble = 1844674407370.1235R
        Console.WriteLine(doble)
        Dim conDecimales = 1234567.458967D
        Console.WriteLine(conDecimales)
        Dim caracter = "a"c
        Console.WriteLine(caracter)
        Dim cadena = "Esta es una cadena de caracteres"
        Console.WriteLine(cadena)
        Dim boleano = False
        Console.WriteLine(boleano)
        Dim fechaHora = New DateTime(2021, 1, 1, 8, 30, 52)
        Console.WriteLine(fechaHora)
    End Sub
    Public Shared Sub DeclaracionVariablesNuleables()
        Dim enteroSbyte As SByte?
        enteroSbyte = Nothing
        enteroSbyte = 127
        Console.WriteLine(enteroSbyte)
        Dim enterobyte As Byte?
        enterobyte = Nothing
        enterobyte = 255
        Console.WriteLine(enterobyte)
        Dim enteroshort As Short?
        enteroshort = Nothing
        enteroshort = -32767
        Console.WriteLine(enteroshort)
        Dim enteroushort As UShort?
        enteroushort = Nothing
        enteroushort = 65535
        Console.WriteLine(enteroushort)
        Dim enteroint As Integer?
        enteroint = Nothing
        enteroint = 2147483647
        Console.WriteLine(enteroint)
        Dim enterouint As UInteger?
        enterouint = Nothing
        enterouint = 4294967295
        Console.WriteLine(enterouint)
        Dim enterolong As Long?
        enterolong = Nothing
        enterolong = 922337236854775807
        Console.WriteLine(enterolong)
        Dim enteroulong As ULong?
        enteroulong = Nothing
        enteroulong = 1844674407370955161
        Console.WriteLine(enteroulong)
        Dim caracter As Char?
        caracter = Nothing
        caracter = "a"c
        Console.WriteLine(caracter)
        Dim boleano As Boolean?
        boleano = Nothing
        boleano = False
        Console.WriteLine(boleano)
        Dim fecha As DateTime?
        fecha = Nothing
        fecha = New DateTime(2021, 7, 10, 7, 10, 24)
        Console.WriteLine(fecha)
        Dim arr As Integer?() = New Integer?(9) {}
    End Sub
    Public Shared Sub Arreglos()
        Dim enterosSbyte As SByte() = {1, 2, 3}
        Console.WriteLine(enterosSbyte(0))
        Dim enterobyte As Byte() = New Byte(2) {}
        enterobyte(0) = 1
        enterobyte(1) = 2
        enterobyte(2) = 3
        Console.WriteLine(enterobyte(0))
        Dim enteroshort As Short() = {1, 2, 3}
        Console.WriteLine(enteroshort(0))
        Dim enteroushort As UShort() = {1, 2, 3}
        Console.WriteLine(enteroushort(0))
        Dim enteroint As Integer() = {1, 2, 3}
        Console.WriteLine(enteroint(0))
        Dim enterouint As UInteger() = {1, 2, 3}
        Console.WriteLine(enterouint)
        Dim enterolong As Long() = {1, 2, 3}
        Console.WriteLine(enterolong)
        Dim enteroulong As ULong() = {1, 2, 3}
        Console.WriteLine(enteroulong)
        Dim flotante As Single() = {18.789F, 1.3F, 2.5F}
        Console.WriteLine(flotante)
        Dim doble As Double() = {18.789, 1.3, 2.5}
        Console.WriteLine(doble)
        Dim conDecimales As Decimal() = {1.23D, 2.34D, 3.45D}
        Console.WriteLine(conDecimales)
        Dim caracter As Char() = {"A"c, "B"c, "C"c}
        Console.WriteLine(caracter)
        Console.WriteLine(caracter(0))
        Console.WriteLine(caracter(1))
        Console.WriteLine(caracter(2))
        Dim cadena As String = New String(caracter)
        Dim nombre As String() = {"A", "B", "C"}
        Console.WriteLine(cadena)
        Dim boleano As Boolean() = {False, True, False}
        Console.WriteLine(boleano)
        Dim fechaHora As DateTime() = {New DateTime(2020, 7, 10, 7, 10, 24), New DateTime(2021, 7, 10, 7, 10, 24), New DateTime(2022, 7, 10, 7, 10, 24)}
        Console.WriteLine(fechaHora)
        Dim arreglo2D As Integer(,) = New Integer(,) {
        {1, 2},
        {3, 4},
        {5, 6},
        {7, 8}}
        Dim arreglo2Da As Integer(,) = New Integer(3, 1) {
        {1, 2},
        {3, 4},
        {5, 6},
        {7, 8}}
        Dim arreglo2Db As String(,) = New String(2, 1) {
        {"uno", "dos"},
        {"tres", "cuatro"},
        {"cinco", "seis"}}
        Dim arreglo3D As Integer(,,) = New Integer(,,) {
        {
        {1, 2, 3},
        {4, 5, 6}},
        {
        {7, 8, 9},
        {10, 11, 12}}}
        System.Console.WriteLine(arreglo2D(0, 0))
        System.Console.WriteLine(arreglo2D(0, 1))
        System.Console.WriteLine(arreglo2Da(1, 0))
        System.Console.WriteLine(arreglo2Da(1, 1))
        System.Console.WriteLine(arreglo2Db(1, 0))
        System.Console.WriteLine(arreglo3D(1, 0, 1))
        System.Console.WriteLine(arreglo3D(1, 1, 2))
    End Sub
    Enum Color
        Rojo
        Verde
        Azul
        Amarillo
        Cafe
    End Enum
    Enum ErrorCode
        Ninguno = 0
        Desconocido = 1
        NoHayConexion = 100
        RegistroInexistente = 200
    End Enum
    Public Shared Sub Enumeraciones()
        Dim oColor As Color
        oColor = Color.Azul
        Console.WriteLine(oColor)
        Dim [error] As ErrorCode
        [error] = ErrorCode.RegistroInexistente
        Console.WriteLine([error])
        Dim b = CType(1, Color)
        Console.WriteLine(b)
        Dim c As Color = CType(5, Color)
        Console.WriteLine(c)
    End Sub

End Class
