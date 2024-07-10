Public Structure CoordenadaStruct
    Public Sub New(ByVal x As Double, ByVal y As Double)
        x = x
        y = y
    End Sub

    Public Property X As Double
    Public Property Y As Double

    Public Function Valores() As String
        Return $"({X}, {Y})"
    End Function
End Structure
