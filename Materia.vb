Public Class Materia
    'instancia de la clase conexion.
    Dim c As New conexion

    'declaracion de propiedades de la clase

    Private codigoMateria As String
    Private nombreMateria As String
    Private cicloMateria As String

    'metodos de propiedades

    Public Property codMateria() As String
        Get
            Return codigoMateria
        End Get
        Set(value As String)
            codigoMateria = value
        End Set
    End Property
End Class

