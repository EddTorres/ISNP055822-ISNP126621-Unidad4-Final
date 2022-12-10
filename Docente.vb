Imports Microsoft.VisualBasic
Imports System.Data


Public Class Docente
    Dim c As New conexion
    'En caso de que la tabla docente tenga más atributos agregarlos
    Private codigoDocente As String
    Private nombreDocente As String
    Private apellidoDocente As String
    Private pagina As Docente

    'Metodo de la propiedad
    Public Property codDocente() As String
        Get
            Return codigoDocente

        End Get
        Set(value As String)
            codigoDocente = value

        End Set
    End Property

    Public Property nomDocente() As String
        Get
            Return nombreDocente

        End Get
        Set(value As String)
            nombreDocente = value

        End Set
    End Property

    Public Property apeDocente() As String
        Get
            Return apellidoDocente

        End Get
        Set(value As String)
            apellidoDocente = value

        End Set
    End Property

    Public Function listRegistros() As DataTable

        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codDocente, nomDocente, apeDocente FROM docente"
        End With

        c.da.Fill(c.dt)
        Return c.dt

    End Function

    'Método para guardar
    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO Docente values ('" & nombreDocente & "','" & apeDocente & "','" & codDocente & "')"
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
    'Si los campos son diferentes o mas se sustituyen y/o agrean
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT ideDocente,nombre,apellido,codigo FROM docente where iddocente = '" & codDocente & "' "
            c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt

    End Function



    'Metodo para actualizar registros
    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE docente SET 
                                nombre ='" & nombreDocente & "',
                                apellido = '" & apeDocente & "',
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







End Class
