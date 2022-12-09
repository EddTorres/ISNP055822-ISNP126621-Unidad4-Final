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
    Public Property nomMateria() As String
        Get
            Return nombreMateria
        End Get
        Set(value As String)
            nombreMateria = value
        End Set
    End Property
    Public Property cicMateria() As String
        Get
            Return cicloMateria
        End Get
        Set(value As String)
            cicloMateria = value
        End Set
    End Property

    Public Function listaRegistros() As DataTable
        'se hace referencia a la instancia de la clase Conexion
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "Select codMateria, nomMateria, cicMateria FROM Materia"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


End Class

