Public Class Listas
    Private Shared _lstEnteros As List(Of Integer)
    Private Shared _lstCadenas As List(Of String)
    Private Shared _lstEstados As List(Of Estado)
    Private Shared _lstEmpleados As List(Of Empleado)

    Public Shared Sub CadenasCarga()
        _lstCadenas = New List(Of String)()
        _lstCadenas.Add("Aguascalientes")
        _lstCadenas.Add("Baja California")
        Console.WriteLine("Lista de cadenas")

        For Each cadena As String In _lstCadenas
            Console.WriteLine(cadena)
        Next
    End Sub

    Public Shared Sub EnterosCarga()
        _lstEnteros = New List(Of Integer)()
        _lstEnteros = New List(Of Integer) From {
            8,
            4,
            3,
            6,
            5,
            7
        }
        Console.WriteLine("Lista de enteros")

        For Each entero As Integer In _lstEnteros
            Console.WriteLine(entero)
        Next
    End Sub

    Public Shared Sub EmpleadosCarga()
        _lstEmpleados = New List(Of Empleado)()
        Dim emp1 As Empleado = New Empleado()
        emp1.nombre = "David"
        emp1.idEstado = 1
        emp1.sueldoMensual = 20000D
        _lstEmpleados.Add(emp1)
        Dim emp2 As Empleado = New Empleado()
        emp2 = New Empleado()
        emp2.nombre = "Luis"
        emp2.idEstado = 2
        emp2.sueldoMensual = 25000D
        _lstEmpleados.Add(emp2)
        Dim emp3 As Empleado = New Empleado With {
            .nombre = "Oscar",
            .idEstado = 3,
            .sueldoMensual = 23000D
        }
        _lstEmpleados.Add(emp3)
        Dim emp4 As Empleado = New Empleado With {
            .nombre = "Jose",
            .idEstado = 3,
            .sueldoMensual = 18000D
        }
        _lstEmpleados.Add(emp4)
        Console.WriteLine("Lista de Empleados")

        For Each oEmpleado In _lstEmpleados
            Console.WriteLine($"{oEmpleado.nombre} {oEmpleado.idEstado} ")
        Next
    End Sub

    Public Shared Sub ConcatenarListas()
        Dim lstEmpleados As List(Of Empleado) = New List(Of Empleado) From {
            New Empleado With {
                .nombre = "Antonio",
                .idEstado = 1
            },
            New Empleado With {
                .nombre = "Eli",
                .idEstado = 2
            },
            New Empleado With {
                .nombre = "Juan",
                .idEstado = 2
            }
        }
        _lstEmpleados = _lstEmpleados.Concat(lstEmpleados).ToList()

        For Each oEmpleado In _lstEmpleados
            Console.WriteLine($"{oEmpleado.nombre} {oEmpleado.idEstado} ")
        Next
    End Sub

    Public Shared Sub EstadosDefineYCarga()
        _lstEstados = New List(Of Estado) From {
            New Estado With {
                .id = 1,
                .nombre = "Aguascalientes"
            },
            New Estado With {
                .id = 2,
                .nombre = "Baja California"
            },
            New Estado With {
                .id = 3,
                .nombre = "Baja California Sur"
            },
            New Estado With {
                .id = 4,
                .nombre = "Campeche"
            },
            New Estado With {
                .id = 5,
                .nombre = "Chihuahua"
            },
            New Estado With {
                .id = 6,
                .nombre = "Chiapas"
            },
            New Estado With {
                .id = 7,
                .nombre = "Coahuila"
            },
            New Estado With {
                .id = 8,
                .nombre = "Colima"
            },
            New Estado With {
                .id = 9,
                .nombre = "Durango"
            },
            New Estado With {
                .id = 10,
                .nombre = "Guanajuato"
            },
            New Estado With {
                .id = 11,
                .nombre = "Guerrero"
            },
            New Estado With {
                .id = 12,
                .nombre = "Hidalgo"
            },
            New Estado With {
                .id = 13,
                .nombre = "Jalisco"
            },
            New Estado With {
                .id = 14,
                .nombre = "México"
            },
            New Estado With {
                .id = 15,
                .nombre = "Michoacán"
            },
            New Estado With {
                .id = 16,
                .nombre = "Morelos"
            },
            New Estado With {
                .id = 5,
                .nombre = "Nayarit"
            },
            New Estado With {
                .id = 18,
                .nombre = "Nuevo León"
            },
            New Estado With {
                .id = 20,
                .nombre = "Oaxaca"
            },
            New Estado With {
                .id = 19,
                .nombre = "Colima"
            }
        }
        Console.WriteLine("Lista de Estados")

        For Each oEstado In _lstEstados
            Console.WriteLine($"{oEstado.id} {oEstado.nombre} ")
        Next
    End Sub

    Public Shared Sub Ordenar()
        Dim lstEnterosMenorAMayor = _lstEnteros.OrderBy(Function(x) x).ToList()
        Console.WriteLine("Lista de enteros Menor a Mayor")

        For Each entero As Integer In lstEnterosMenorAMayor
            Console.WriteLine(entero)
        Next

        Dim lstEnterosMayorAMenos = _lstEnteros.OrderByDescending(Function(x) x).ToList()
        Console.WriteLine("Lista de enteros Mayor a Menor")

        For Each entero As Integer In lstEnterosMayorAMenos
            Console.WriteLine(entero)
        Next

        Dim lstEstadosMenorAMayor = _lstCadenas.OrderBy(Function(x) x).ToList()
        Console.WriteLine("Lista de Estados Menor a Mayor")

        For Each estado In lstEstadosMenorAMayor
            Console.WriteLine(estado)
        Next

        Dim lstEstadosMayorAMenos = _lstCadenas.OrderByDescending(Function(x) x).ToList()
        Console.WriteLine("Lista de Estados Mayor a Menor")

        For Each estado In lstEstadosMayorAMenos
            Console.WriteLine(estado)
        Next

        Dim lstEstadosOrdenado = _lstEstados.OrderByDescending(Function(x) x.id).OrderByDescending(Function(x) x.nombre).ToList()
        Console.WriteLine("Lista de Estados Mayor a Menor")

        For Each estado In lstEstadosOrdenado
            Console.WriteLine(estado)
        Next
    End Sub

    Public Shared Sub Agregacion()
        Console.WriteLine($"Total Empleados: {_lstEmpleados.Count()}")
        Console.WriteLine($"Total de Sueldos: {_lstEmpleados.Sum(Function(e) e.sueldoMensual)}")
        Console.WriteLine($"Sueldo Promedio: {_lstEmpleados.Average(Function(e) e.sueldoMensual)}")
        Console.WriteLine($"Sueldo Máximo: {_lstEmpleados.Max(Function(e) e.sueldoMensual)}")
        Console.WriteLine($"Sueldo Mínimo: {_lstEmpleados.Min(Function(e) e.sueldoMensual)}")
    End Sub

    Public Shared Function Buscar(ByVal e As Estado) As Boolean
        Dim encontrado As Boolean = False
        If e.id = 3 Then encontrado = True
        Return encontrado
    End Function

    Public Shared Function Buscars(ByVal e As Estado) As Boolean
        Return e.id = 3
    End Function

    Public Shared Function BuscarCE(ByVal e As Estado) As Boolean
        Return e.id = 3
    End Function

    Public Shared Sub MetodosActualizar()
        _lstEstados = New List(Of Estado)()
        Dim oEstado As Estado = New Estado()
        oEstado.id = 1
        oEstado.nombre = "Aguascalientes"
        _lstEstados.Add(oEstado)
        oEstado = New Estado()
        oEstado.id = 2
        oEstado.nombre = "Estado de México"
        _lstEstados.Add(oEstado)
        _lstEstados.Add(New Estado With {
            .id = 3,
            .nombre = "Colima"
        })
        _lstEstados.Add(New Estado With {
            .id = 4,
            .nombre = "Chiapas"
        })

        For Each estado As Estado In _lstEstados
            Console.WriteLine($"id={estado.id}, nombre={estado.nombre}")
        Next

        Dim Edo1 As Estado = _lstEstados.Find(Function(edo) edo.id = 2)
        Console.WriteLine($"id={Edo1.id}, nombre={Edo1.nombre}")
        Edo1 = _lstEstados.Find(Function(edo) edo.id > 1)
        Edo1.nombre = "Coahuila"

        For Each estado As Estado In _lstEstados
            Console.WriteLine($"id={estado.id}, nombre={estado.nombre}")
        Next

        Dim LstEdo1 As List(Of Estado) = _lstEstados.FindAll(Function(x) x.id > 1)

        For Each estado As Estado In LstEdo1
            Console.WriteLine($"id={estado.id}, nombre={estado.nombre}")
        Next

        _lstEstados.Remove(Edo1)

        For Each estado As Estado In _lstEstados
            Console.WriteLine($"id={estado.id}, nombre={estado.nombre}")
        Next

        _lstEstados.RemoveAll(Function(x) x.id = 2)

        For Each estado As Estado In _lstEstados
            Console.WriteLine($"id={estado.id}, nombre={estado.nombre}")
        Next
    End Sub

    Public Shared Sub Linq()
        _lstEnteros = New List(Of Integer) From {
            8,
            5,
            3,
            6,
            5,
            7
        }
        Dim primero = _lstEnteros.First(Function(entero) entero = 5)
        Dim ultimo = _lstEnteros.Last(Function(x) x = 5)
        Console.WriteLine($"Primero {primero} ultimo {ultimo}")
        Dim primerEstado = _lstEstados.First(Function(estado) estado.id = 5)
        Dim ultimoEstado = _lstEstados.Last(Function(x) x.id = 5)
        Console.WriteLine($"Primero {primerEstado.id} {primerEstado.nombre} ultimo {ultimoEstado.id} {ultimoEstado.nombre}")
        Dim todosEstados As Boolean = _lstEstados.All(Function(x) x.id >= 5)
        Dim algunEstado As Boolean = _lstEstados.Any(Function(x) x.id >= 5)
        Console.WriteLine($"Todos los estados son mayor o igual a 5 {todosEstados}")
        Console.WriteLine($"Algún estado es mayor o igual a 5 {algunEstado}")
        Dim Edo As Estado = _lstEstados.Find(Function(x) x.id = 14)
        Console.WriteLine($"{Edo.id} {Edo.nombre} ")
        Dim lstEdo = _lstEstados.FindAll(Function(x) x.id > 14)
        Console.WriteLine("Lista de Estados Encontrados")

        For Each oEstado In lstEdo
            Console.WriteLine($"{oEstado.id} {oEstado.nombre} ")
        Next

        Dim lstedosEncontrados = _lstEstados.Where(Function(x) x.id > 4)
        Console.WriteLine("Lista de Estados Encontrados")

        For Each oEstado In lstedosEncontrados
            Console.WriteLine($"{oEstado.id} {oEstado.nombre} ")
        Next

        Dim listEdos As List(Of Estado) = lstedosEncontrados.ToList()
        Dim edoEnc As Estado = _lstEstados.Where(Function(x) x.id >= 4).FirstOrDefault()
        Console.WriteLine($"Estado Encontrado: {edoEnc.id} {edoEnc.nombre}")
        Dim pares = _lstEnteros.Where(Function(x) x Mod 2 = 0).ToList()
        Console.WriteLine("Lista de números pares")

        For Each entero As Integer In pares
            Console.WriteLine(entero)
        Next

        Dim oEmpleados = From empleado In _lstEmpleados Where empleado.idEstado = 2 Order By empleado.nombre Select empleado
        Console.WriteLine("Lista de Empleados")

        For Each oEmpleado In oEmpleados
            Console.WriteLine($"{oEmpleado.nombre} {oEmpleado.idEstado} ")
        Next

        Dim lst1 As List(Of Empleado) = oEmpleados.ToList()
        Dim emp As Empleado = New Empleado() With {
            .nombre = "David"
        }
        Dim oNombresEmpleados = From empleado In _lstEmpleados Where empleado.idEstado = 2 Select New With {
            .NombreEmpleado = empleado.nombre
        }
        Console.WriteLine("Lista de Empleados")

        For Each oEmpleado In oNombresEmpleados
            Console.WriteLine($"{oEmpleado.NombreEmpleado}")
        Next

        Console.WriteLine("Lista de Empleados")

        For Each oEmpleado In oEmpleados
            Console.WriteLine($"{oEmpleado.nombre} {oEmpleado.idEstado} ")
        Next

        Dim oEmpleados2 = From empleado In _lstEmpleados Where empleado.idEstado = 1 AndAlso empleado.nombre = "Jorge" Select empleado
        Console.WriteLine("Lista de Empleados")

        For Each oEmpleado In oEmpleados2
            Console.WriteLine($"{oEmpleado.nombre} {oEmpleado.idEstado} ")
        Next

        Dim innerEmpleadoEstado = From empleado In _lstEmpleados Join estado In _lstEstados On empleado.idEstado Equals estado.id Where estado.id = 2 OrElse estado.id = 4 Select New With {
            .nombreEmpleado = empleado.nombre,
            .nombreEstado = estado.nombre
        }
        Console.WriteLine("Lista de Alumnos - Estados")

        For Each oEmpleado In innerEmpleadoEstado
            Console.WriteLine($"{oEmpleado.nombreEmpleado} {oEmpleado.nombreEstado} ")
        Next

        Dim edosSeleccionados = From estado In _lstEstados Where estado.id >= 5 Order By estado.nombre, estado.id Select estado
        Console.WriteLine("Estados Seleccionados")

        For Each oEstado In edosSeleccionados
            Console.WriteLine($"{oEstado.id} {oEstado.nombre} ")
        Next

        Dim a As List(Of Estado) = edosSeleccionados.ToList()
        _lstEstados.ForEach(Function(x) (x.nombre, x.nombre.Substring(0, 1).ToUpper() + x.nombre.Substring(1)))

        For Each oEstado In _lstEstados
            Console.WriteLine($"{oEstado.id} {oEstado.nombre} ")
        Next
    End Sub

    Public Shared Sub Presentacion()
        Dim lstEnteros As List(Of Integer) = New List(Of Integer) From {
            8,
            4,
            3,
            6,
            5,
            7
        }
        Dim lstCadenas As List(Of String) = New List(Of String) From {
            "Aguascalientes",
            "Baja California"
        }
        Dim lstEstados As List(Of Estado) = New List(Of Estado) From {
            New Estado With {
                .id = 1,
                .nombre = "Aguascalientes"
            },
            New Estado With {
                .id = 2,
                .nombre = "Baja California"
            }
        }
        Dim lstEmpleados As List(Of Empleado) = New List(Of Empleado) From {
            New Empleado With {
                .nombre = "Jorge",
                .idEstado = 4,
                .sueldoMensual = 23000D
            },
            New Empleado With {
                .nombre = "Oscar",
                .idEstado = 3,
                .sueldoMensual = 18000D
            }
        }
        lstEnteros.Add(1)
        lstCadenas.Add("Aguascalientes")
        Dim entero1 As Integer = lstEnteros(0)
        Dim entero2 As Integer = lstEnteros.Find(Function(x) x = 2)
        Dim lstEntero2 As List(Of Integer) = lstEnteros.FindAll(Function(x) x = 2)
        Dim cadena1 As String = lstCadenas(3)
        Dim cadena2 As String = lstCadenas.Find(Function(x) x = "Baja California")
        Dim lstCadena2 As List(Of String) = lstCadenas.FindAll(Function(x) x = "Baja California")
        Dim estado1 As Estado = lstEstados(5)
        Dim estado2 As Estado = lstEstados.Find(Function(x) x.id = 3)
        Dim lstEstado2 As List(Of Estado) = lstEstados.FindAll(Function(x) x.id >= 3)
        Dim empleado1 As Empleado = lstEmpleados(5)
        Dim empleado2 As Empleado = lstEmpleados.Find(Function(x) x.nombre = "Jorge")
        Dim lstEmpleado2 As List(Of Empleado) = lstEmpleados.FindAll(Function(x) x.nombre = "Jorge")
        empleado2.nombre = "Pedro"
        empleado2.idEstado = 4
        lstEnteros.Remove(2)
        lstCadenas.Remove("Aguascalientes")
        Dim estado As Estado = lstEstados.Find(Function(x) x.nombre = "Aguascalientes")
        lstEstados.Remove(estado)
        lstEstados.RemoveAll(Function(x) x.id > 32)
        Dim empleado3 As Empleado = lstEmpleados.Find(Function(x) x.nombre = "Jorge")
        lstEmpleados.Remove(empleado3)
        lstEmpleados.RemoveAll(Function(x) x.nombre = "Jorge")
        lstEnteros.ForEach(Function(x) x = 1)
        lstEnteros.ForEach(Function(x)
                               Console.WriteLine(x)
                               Return x
                           End Function)
        lstCadenas.ForEach(Function(x)
                               Console.WriteLine(x)
                               Return x
                           End Function)
        lstEstados.ForEach(Function(x)
                               Console.WriteLine($"id: {x.id}, nombre: {x.nombre}")
                               Return x
                           End Function)
        lstEmpleados.ForEach(Function(x)
                                 Console.WriteLine($"nombre: {x.nombre}, sueldo: {x.sueldoMensual}")
                                 Return x
                             End Function)
        Dim lstMenores = lstEnteros.Where(Function(x) x > 3)
        Dim lstDiferentes = lstCadenas.Where(Function(x) x <> "Aguascalientes")
        Dim lstEstados3 = lstEstados.Where(Function(x) x.id > 3)
        Dim lstEmpleados3 = lstEmpleados.Where(Function(x) x.nombre = "Jorge" AndAlso x.idEstado <> 2)
        Dim totalEmpleados As Decimal = lstEmpleados.Count()
        Dim sumaSueldos As Decimal = lstEmpleados.Sum(Function(e) e.sueldoMensual)
        Dim promedioSueldos As Decimal = lstEmpleados.Average(Function(e) e.sueldoMensual)
        Dim sueldoMaximo As Decimal = lstEmpleados.Max(Function(e) e.sueldoMensual)
        Dim sueldoMinimo As Decimal = lstEmpleados.Min(Function(e) e.sueldoMensual)
        lstCadenas.Add("Aguascalientes")
        lstCadenas.Add("Baja California")
        Dim numeros As Integer() = New Integer(6) {0, 1, 2, 3, 4, 5, 6}
        Dim EnumQuery = From num In numeros Where (num Mod 2) = 0 Select num

        For Each num As Integer In EnumQuery
            Console.Write("{0,1} ", num)
        Next

        Dim numerosPares As List(Of Integer) = (From num In numeros Where (num Mod 2) = 0 Select num).ToList()
        Dim arrNumerosPares = (From num In numeros Where (num Mod 2) = 0 Select num).ToArray()

        Dim empleadosEstado = From empleado In lstEmpleados
                              Group By idEst = empleado.idEstado
                              Into EmpleadoEstado = Group

        For Each empleadoXEstado In empleadosEstado
            Console.WriteLine(empleadoXEstado.idEst)
            For Each empelado In empleadoXEstado.EmpleadoEstado
                Console.WriteLine("    {0}", empelado.nombre)
            Next
        Next


        Dim consultaEmpleados =
            From empleado In lstEmpleados
            Group By idEst = empleado.idEstado
            Into GruposEmpleados = Group
            Select GruposEmpleados

        Dim empleadosEstados =
        From empleado In lstEmpleados
        Join edo In lstEstados On empleado.idEstado Equals edo.id
        Where estado.id = 2 OrElse estado.id = 4
        Select New With {
            .nombreEmpleado = empleado.nombre,
            .nombreEstado = estado.nombre
        }

        For Each i As Integer In lstEnteros
            Console.WriteLine(i)
        Next

        For Each cadena As String In lstCadenas
            Console.WriteLine(cadena)
        Next

        For Each estado4 As Estado In lstEstados
            Console.WriteLine($"id: {estado4.id}, nombre: {estado4.nombre}")
        Next

        For Each empleado As Empleado In lstEmpleados
            Console.WriteLine($"nombre: {empleado.nombre}, " & $"id Estado: {empleado.idEstado}, " & $"Sueldo: {empleado.sueldoMensual}")
        Next

        Dim lstEmpleados1 As List(Of Empleado) = New List(Of Empleado) From {
            New Empleado With {
                .nombre = "Antonio",
                .idEstado = 1
            },
            New Empleado With {
                .nombre = "Eli",
                .idEstado = 2
            }
        }
        Dim lstEmpleados2 As List(Of Empleado) = New List(Of Empleado) From {
            New Empleado With {
                .nombre = "Jorge",
                .idEstado = 1
            },
            New Empleado With {
                .nombre = "Juan",
                .idEstado = 2
            }
        }
        Dim lstEmpleados4 As List(Of Empleado) = lstEmpleados1.Concat(lstEmpleados2).ToList()
        Dim lstEnterosMenorAMayor = lstEnteros.OrderBy(Function(x) x).ToList()
        Dim lstCadenasMenorAMayor = lstCadenas.OrderBy(Function(x) x).ToList()
        Dim lstEstadosMenorAMayor = lstEstados.OrderBy(Function(x) x.id).ToList()
        Dim lstEmpleadosMenorAMayor = lstEmpleados.OrderBy(Function(x) x.nombre).ToList()
        Dim lstEnterosMayorAMenos = lstEnteros.OrderByDescending(Function(x) x).ToList()
        Dim lstCadenasMayorAMenor = lstCadenas.OrderByDescending(Function(x) x).ToList()
        Dim lstEstadosMayorAMenor = lstEstados.OrderByDescending(Function(x) x.nombre).ToList()
        Dim lstEmpleadosMayorAMenor = lstEmpleados.OrderByDescending(Function(x) x.nombre).ToList()
        Dim lstEstadosOrdenado = _lstEstados.OrderByDescending(Function(x) x.nombre).OrderByDescending(Function(x) x.id).ToList()
    End Sub


End Class

