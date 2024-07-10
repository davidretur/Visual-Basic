Public MustInherit Class Persona
    Private _nombre As String
    Private _fechaNacimiento As DateTime

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento As DateTime
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As DateTime)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property apellidos As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As DateTime)
        _nombre = nombre
        Me.apellidos = apellidos
        _fechaNacimiento = fechaNacimiento
    End Sub

    Public Overridable Function edad() As Integer
        Dim hoy As DateTime = DateTime.Now
        Dim vedad As Integer = hoy.Year - _fechaNacimiento.Year
        Return vedad
    End Function

    Public MustOverride Function ClaveUnica() As String
End Class

