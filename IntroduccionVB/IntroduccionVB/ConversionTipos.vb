Public Class ConversionTipos
    Public Shared Sub ConversionEntero()
        Dim snum As String = "1234"
        Dim num As Integer
        num = Convert.ToInt32(snum)
        Console.WriteLine(num)
    End Sub

    Public Shared Sub Conversiones()
        Dim num As Integer = 2147483647
        Dim bigNum As Long = num
        Dim pequeño As SByte = 23
        Dim corto As Short = pequeño
        Console.WriteLine($"num {num} bigNum {bigNum}")
        Console.WriteLine($"sbyte {pequeño} short {corto}")
        num = CInt(bigNum)
        pequeño = CSByte(corto)
        Console.WriteLine($"num {num} bigNum {bigNum}")
        Console.WriteLine($"sbyte {pequeño} short {corto}")
        Dim snum As String = "2147483647"
        num = Integer.Parse(snum)
        num = Convert.ToInt32(snum)
        Dim valido As Boolean
        valido = Integer.TryParse(snum, num)
        snum = "mil quinientos"
        valido = Integer.TryParse(snum, num)

        Try
            num = Integer.Parse(snum)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim sfecha As String = "2021-06-01"
        Dim fecha As DateTime
        fecha = DateTime.Parse(sfecha)
        fecha = Convert.ToDateTime(sfecha)
        valido = DateTime.TryParse(sfecha, fecha)
        sfecha = "2021-06-03"
        valido = DateTime.TryParse(sfecha, fecha)
        Dim empleado As Empleado = New Empleado("David Empleado", "Duarte", New DateTime(1978, 10, 2))
        Dim directivo As Directivo = New Directivo("David Directivo", "Duarte", New DateTime(1978, 10, 2))
        Console.WriteLine("Antes de Convertir Explicitamente")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        empleado = directivo
        Console.WriteLine("Despues de Convertir Implicitamente")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        directivo = CType(empleado, Directivo)
        Console.WriteLine("Despues de Convertir Explicitamete")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        directivo = TryCast(empleado, Directivo)
        Console.WriteLine("Despues de Convertir Explicitamete")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")

        Try
            fecha = DateTime.Parse(sfecha)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        fecha = DateTime.Parse(sfecha)
        fecha = Convert.ToDateTime(sfecha)
    End Sub

    Public Shared Sub ConversionesExpo()
        Dim num As Integer = 2147483647
        Dim bigNum As Long = num
        Dim pequeño As SByte = 23
        Dim corto As Short = pequeño
        Dim empleado As Empleado = New Empleado("David Empleado", "Duarte", New DateTime(1978, 10, 2))
        Dim directivo As Directivo = New Directivo("David Directivo", "Duarte", New DateTime(1978, 10, 2))
        empleado = directivo
        directivo = CType(empleado, Directivo)
        Console.WriteLine("Antes de Convertir Explicitamente")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        Console.WriteLine($"num {num} bigNum {bigNum}")
        Console.WriteLine($"sbyte {pequeño} short {corto}")
        num = CInt(bigNum)
        pequeño = CSByte(corto)
        directivo = CType(empleado, Directivo)
        directivo = TryCast(empleado, Directivo)
        Console.WriteLine($"num {num} bigNum {bigNum}")
        Console.WriteLine($"sbyte {pequeño} short {corto}")
        Dim snum As String = "1234"
        Dim numa As Integer
        Dim valido As Boolean
        Dim sfecha As String = "2020-02-29"
        Dim fecha As DateTime
        numa = Integer.Parse(snum)
        numa = Convert.ToInt32(snum)
        valido = Integer.TryParse(snum, num)
        snum = "mil quinientos"
        valido = Integer.TryParse(snum, numa)
        fecha = DateTime.Parse(sfecha)
        fecha = Convert.ToDateTime(sfecha)
        valido = DateTime.TryParse(sfecha, fecha)

        Try
            num = Integer.Parse(snum)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Despues de Convertir Implicitamente")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        directivo = CType(empleado, Directivo)
        Console.WriteLine("Despues de Convertir Explicitamete")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")
        directivo = TryCast(empleado, Directivo)
        Console.WriteLine("Despues de Convertir Explicitamete")
        Console.WriteLine($"Empleado nombre: {empleado.nombre} apellidos {empleado.apellidos} fechaNacimiento {empleado.fechaNacimiento}")
        Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}")

        Try
            fecha = DateTime.Parse(sfecha)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        fecha = DateTime.Parse(sfecha)
        fecha = Convert.ToDateTime(sfecha)
    End Sub
End Class

