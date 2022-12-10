Imports Microsoft.VisualBasic
Imports System.Data
Public Class Alumno

    'Instancia de la conexion
    Dim c As New conexion

    Private IdAlumno As String
    Private codigoAlumno As String
    Private nombreAlumno As String
    Private apellidoAlumno As String
    Private correoAlumno As String
    Private telefonoAlumno As String
    Private pagina As Page

    'Metodos de la propiedad
    Public Property ideAlumno() As String
        Get
            Return IdAlumno

        End Get
        Set(value As String)
            IdAlumno = value
        End Set
    End Property

    Public Property codAlumno() As String
        Get
            Return codigoAlumno

        End Get
        Set(value As String)
            codigoAlumno = value
        End Set
    End Property
    Public Property nomAlumno() As String
        Get
            Return nombreAlumno

        End Get
        Set(value As String)
            nombreAlumno = value
        End Set
    End Property
    Public Property apeAlumno() As String
        Get
            Return apellidoAlumno

        End Get
        Set(value As String)
            apellidoAlumno = value
        End Set
    End Property

    Public Property mailAlumno() As String
        Get
            Return correoAlumno

        End Get
        Set(value As String)
            correoAlumno = value
        End Set
    End Property

    Public Property telAlumno() As String
        Get
            Return telefonoAlumno

        End Get
        Set(value As String)
            telefonoAlumno = value
        End Set
    End Property

    'Función para mostrar lista de estudiantes
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla estudiante
            .CommandText = "SELECT idestudiante, nombre, apellido,correo, telefono,codigo FROM estudiante"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


    'Método para guardar
    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO estudiante values ('""','" & nomAlumno & "','" & apeAlumno & "','" & mailAlumno & "','" & telAlumno & "','" & codAlumno & "')"
                c.result = c.cmd.ExecuteNonQuery
            End With
            If c.result = 0 Then
                MsgBox("No se ha podido guardar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("NO se ha podido guardar el registro", MsgBoxStyle.Critical)
        End Try
        c.strcon.Close()
    End Sub


    'Método para editar, mostrar registro por Id
    'Para utilizar con otra clase, cambie el nombre de la tabla
    'Cambie los nombres de los campos que quiere mostrar en el formulario
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT idestudiante,nombre,apellido,correo,telefono,codigo FROM estudiante where codigo = '" & codAlumno & "' "
            c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


    'Metodo para actualizr registros
    'Para utilizar con otra clase, cambie nombre de tabla y de los campos que se van actualizar
    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE estudiante SET 
                                nombre ='" & nomAlumno & "',
                                apellido = '" & apeAlumno & "',
                                correo = '" & mailAlumno & "',
                                telefono = '" & telAlumno & "',
                                codigo = '" & codAlumno & "')"

                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido actualizar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function

End Class
