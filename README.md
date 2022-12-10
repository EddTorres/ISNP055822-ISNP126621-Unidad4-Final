# Pro1-Semana4-CRUD-Visual-Basic-MySQL

Proyecto de visual basic en modo web form, con almacenamiento y CRUD en base de datos MySQL, incluye clases Alumno, Docente, Materia y Usuario. NOTA: Este ejemplo solo inclye clase Alumno y su respectivo formulario con CRUD completo, las otras clases y formularios están vacíos, deben completarse.

SQL de tabla utilizada.

CREATE TABLE `estudiante` (
  `idestudiante` int(11) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `apellido` varchar(40) NOT NULL,
  `correo` varchar(40) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `codigo` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
--
-- Volcado de datos para la tabla `estudiante`
--
INSERT INTO `estudiante` (`idestudiante`, `nombre`, `apellido`, `correo`, `telefono`, `codigo`) VALUES
(1, 'Jose', 'Martínez', 'micorreo@gmail.com', '0000000', 'Jose0001');

Cambien los datos de la cadena de conexión en el caso sean diferentes.

Return New MySqlConnection("server=localhost;userid=ugb;password=ugb2022;database=academica;port=3306")

Estos parámetros deben crearse para la base de datos de MySQL.

Ingrese a http://localhost/phpmyadmin/ para administrar la base de datos.

Los archivos de ejemplo funcionales y completos son:
conexion.vb
Alumno.vb
AgregarAlumno.aspx
EditarAlumno.aspx
EliminarAlumno.aspx

