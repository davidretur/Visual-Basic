Public Class Diccionario
    Private Shared _TerminosTecnicos As Dictionary(Of String, String)

    Public Shared Sub Carga()
        _TerminosTecnicos = New Dictionary(Of String, String)()
        _TerminosTecnicos.Add("HTML", "Es un lenguaje de marcado que se utiliza para el desarrollo de páginas...")
        _TerminosTecnicos.Add("HTTP", "El Protocolo de transferencia de hipertexto...")
        _TerminosTecnicos.Add("FTP", "El Protocolo de transferencia de archivos...")
        _TerminosTecnicos.Add("TCP-IP", "Es un conjunto de protocolos que permiten la comunicación ...")
        _TerminosTecnicos("ASP") = "(Active Server Pages) es la tecnología desarrollada por Microsoft..."

        Try
            _TerminosTecnicos.Add("HTML", "Es un lenguaje de marcado que se utiliza para el desarrollo de páginas...")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        _TerminosTecnicos("HTML") = "Hyper Text Marcado Lenguaje..."
    End Sub

    Public Shared Sub Extrae()
        Dim definicion As String = _TerminosTecnicos("HTML")
        Console.WriteLine(definicion)
        Dim termino As String = "HTML"

        Try
            definicion = _TerminosTecnicos(termino)
        Catch __unusedKeyNotFoundException1__ As KeyNotFoundException
            Console.WriteLine("Témino no encontrado")
        End Try

        Dim valor As String = ""

        If _TerminosTecnicos.TryGetValue("HTML", valor) Then
            Console.WriteLine($"HTML: {valor}")
        Else
            Console.WriteLine("""HTML"" no encontrado")
        End If

        If Not _TerminosTecnicos.ContainsKey("HTML") Then
            _TerminosTecnicos.Add("HTML", "Es un lenguaje de marcado que se utiliza para el desarrollo de páginas...")
        End If

        For Each kvp As KeyValuePair(Of String, String) In _TerminosTecnicos
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
        Next

        Dim valoresColeccion As Dictionary(Of String, String).ValueCollection = _TerminosTecnicos.Values
        Console.WriteLine()

        For Each s As String In _TerminosTecnicos.Values
            Console.WriteLine("Value = {0}", s)
        Next

        Dim keysColeccion As Dictionary(Of String, String).KeyCollection = _TerminosTecnicos.Keys
        Console.WriteLine()

        For Each s As String In keysColeccion
            Console.WriteLine("Key = {0}", s)
        Next

        _TerminosTecnicos.Remove("HTML")

        If Not _TerminosTecnicos.ContainsKey("HTML") Then
            Console.WriteLine("HTML no encontrado")
        End If
    End Sub

    Public Shared Sub CargaTrabajadores()
        Dim _TerminosTecnicos As Dictionary(Of String, String)
        _TerminosTecnicos = New Dictionary(Of String, String)()
        Dim lstTrabajadores As Dictionary(Of Integer, Trabajador) = New Dictionary(Of Integer, Trabajador)()
        Dim oTrabajador1 As Trabajador = New Trabajador("David", "Duarte Hernandez", New DateTime(1977, 7, 17))
        lstTrabajadores.Add(1, oTrabajador1)
        Dim oTrabajador2 As Trabajador = lstTrabajadores(2)
        oTrabajador1 = lstTrabajadores(1)
        oTrabajador1.nombre = "Juan"
        lstTrabajadores.Remove(1)

        For Each kvTrabajador As KeyValuePair(Of Integer, Trabajador) In lstTrabajadores
            Console.WriteLine($"Key = {kvTrabajador.Key}")
            Dim trabajador As Trabajador = kvTrabajador.Value
            Console.WriteLine($"nombre: {trabajador.nombre}")
            Console.WriteLine($"apellidos:{trabajador.apellidos}")
            Console.WriteLine($"Fecha Nacimiento: {trabajador.fechaNacimiento.ToString("dd/MMM/yyyy")}")
        Next

        Console.WriteLine(oTrabajador2.nombre)
    End Sub
End Class

