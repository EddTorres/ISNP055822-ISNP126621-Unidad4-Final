Public Class EditarAlumno
    Inherits System.Web.UI.Page

    'llamamos la clase Alumno, POO
    Dim alumno As New Alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        alumno.codAlumno = Request.QueryString("Alumno")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Alumno
            Dim dt As DataTable = alumno.mostrarRegistro()

            'Mostrar los datos con ayuda de un ciclo for
            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("idestudiante")
                txtNombre.Text = dt.Rows(i).Item("nombre")
                txtApellido.Text = dt.Rows(i).Item("apellido")
                txtCorreo.Text = dt.Rows(i).Item("correo")
                txtTelefono.Text = dt.Rows(i).Item("telefono")
                txtCodigo.Text = dt.Rows(i).Item("codigo")
            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Alumno")
        If testmsg = 1 Then
            'alumno.ideAlumno = TxtId.Text
            alumno.nomAlumno = txtNombre.Text
            alumno.apeAlumno = TxtApellido.Text
            alumno.mailAlumno = TxtCorreo.Text
            alumno.telAlumno = TxtTelefono.Text
            alumno.codAlumno = TxtCodigo.Text

            'llamada metodo guardar registro
            alumno.editar()

            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""

            'Redireccionamos de nuevo a la página listado estudiantes
            Response.Redirect("Alumno.aspx")
        Else
            'Dejamos los campos vacíos para un nuevo ingreso de datos
            'Puede omitirse ya que el redireccionamiento es automático
            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""
        End If
    End Sub

End Class