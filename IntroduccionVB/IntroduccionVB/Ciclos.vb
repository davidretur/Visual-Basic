Imports System.Text

Public Class Ciclos

    Public Shared Sub Mientras()
        Dim contador As Integer = 1

        While contador < 4
            Console.WriteLine($"El contador es {contador}")
            contador += 1
        End While

        Console.WriteLine("Salió del while")
    End Sub

    Public Shared Sub HacerMientras()
        Dim contador As Integer = 1

        Do
            Console.WriteLine($"El contador es {contador}")
            contador += 1
        Loop While contador < 4

        Console.WriteLine("Salió del do-while")
    End Sub

    Public Shared Sub Para()
        For contador As Integer = 1 To 4 - 1
            Console.WriteLine($"El contador es {contador}")
        Next

        Console.WriteLine("Salió del for")
        Dim arreglo2D As Integer(,) = New Integer(,) {
        {1, 2},
        {3, 4},
        {5, 6},
        {7, 8}}

        For i As Integer = 0 To 4 - 1

            For j As Integer = 0 To 2 - 1
                Console.WriteLine($"arreglo2D({i},{j}): {arreglo2D(i, j)}")
            Next
        Next

        Console.WriteLine("Salió del for")

        For j As Integer = 0 To 2 - 1

            For i As Integer = 0 To 4 - 1
                Console.WriteLine($"arreglo2D({i},{j}): {arreglo2D(i, j)}")
            Next
        Next

        Console.WriteLine("Salió del for")
    End Sub

    Public Shared Sub PorCadaUno()
        Dim arregloNumeros As Integer() = {1, 2, 3}

        For Each element As Integer In arregloNumeros
            Console.WriteLine($"Elemento: {element} ")
        Next

        Console.WriteLine("Salió del foreach")
    End Sub

    Public Shared Sub ParaAnidados()
        Dim arreglo2Da As Integer(,) = New Integer(3, 1) {
        {1, 2},
        {3, 4},
        {5, 6},
        {7, 8}}
        Dim arreglo2Db As String(,) = New String(1, 2) {
        {"uno", "dos", "tres"},
        {"cuatro", "cinco", "seis"}}
        Dim arreglo3D As Integer(,,) = New Integer(2, 1, 3) {
        {
        {1, 2, 3, 4},
        {5, 6, 7, 8}},
        {
        {9, 10, 11, 12},
        {13, 14, 15, 16}},
        {
        {17, 18, 19, 20},
        {21, 22, 23, 24}}}

        For i As Integer = 0 To 4 - 1

            For j As Integer = 0 To 2 - 1
                Console.WriteLine(arreglo2Da(i, j))
            Next
        Next

        For i As Integer = 0 To 2 - 1

            For j As Integer = 0 To 3 - 1
                Console.WriteLine(arreglo2Db(i, j))
            Next
        Next

        For i As Integer = 0 To 3 - 1

            For j As Integer = 0 To 2 - 1

                For k As Integer = 0 To 4 - 1
                    Console.WriteLine(arreglo3D(i, j, k))
                Next
            Next
        Next
    End Sub

    Public Shared Sub TablaISR()
        Dim tabISR As Decimal(,) = New Decimal(,) {
        {0.01D, 285.45D, 0D, 1.92D, 200.85D},
        {285.46D, 872.85D, 5.55D, 6.4D, 200.85D},
        {872.86D, 1309.2D, 5.55D, 6.4D, 200.7D},
        {1309.21D, 1713.6D, 5.55D, 6.4D, 200.7D},
        {1713.61D, 1745.7D, 5.55D, 6.4D, 193.8D},
        {1745.71D, 2193.75D, 5.55D, 6.4D, 188.7D},
        {2193.76D, 2327.55D, 5.55D, 6.4D, 174.75D},
        {2327.56D, 2422.8D, 5.55D, 6.4D, 160.35D},
        {2422.81D, 2632.65D, 142.2D, 10.88D, 160.35D},
        {2632.66D, 3071.4D, 142.2D, 10.88D, 145.35D},
        {3071.41D, 3510.15D, 142.2D, 10.88D, 125.1D},
        {3510.16D, 3642.6D, 142.2D, 10.88D, 107.4D},
        {3642.61D, 4257.9D, 142.2D, 10.88D, 0D},
        {4257.91D, 4949.55D, 341.85D, 16D, 0D},
        {4949.56D, 5925.9D, 452.55D, 17.92D, 0D},
        {5925.91D, 11951.85D, 627.6D, 21.36D, 0D},
        {11951.86D, 18837.75D, 1914.75D, 23.52D, 0D},
        {18837.76D, 35964.3D, 3534.3D, 30D, 0D},
        {35964.31D, 47952.3D, 8672.25D, 32D, 0D},
        {47952.31D, 143856.9D, 12508.35D, 34D, 0D},
        {143856.91D, 99999999D, 45115.95D, 35D, 0D}}
        Dim a As StringBuilder = New StringBuilder()
        Dim rango As Integer = tabISR.Rank
        Console.WriteLine($"Rango de la Tabla: {rango}")
        Dim rens As Integer = tabISR.GetUpperBound(0)
        Console.WriteLine($"Renglones de la Tabla: {rens}")
        Dim cols As Integer = tabISR.GetUpperBound(1)
        Console.WriteLine($"Columnas de la Tabla: {cols}")

        For i As Integer = 0 To rens

            For j As Integer = 0 To cols
                Console.WriteLine(tabISR(i, j))
            Next
        Next
    End Sub

End Class
