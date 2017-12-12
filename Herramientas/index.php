<?php
	/*$host = 'localhost';
	$usuario = 'root';
	$contraseña = '';
	$bd = 'invitaciones';*/

	$host = 'localhost';
	$usuario = 'id3973065_root';
	$contraseña = 'Estrategas2017';
	$bd = 'id3973065_invitaciones';

	$nombreTabla = 'invitados';
	$conexion = mysqli_connect($host, $usuario, $contraseña, $bd) or die('No se puede conectar ' . mysql_error());

	$nombre = $_REQUEST['nombre'];
	$apellido = $_REQUEST['apellido'];
	$correo = $_REQUEST['correo'];

	$resultado = InsertarInvitado($conexion, $nombreTabla, $nombre, $apellido, $correo);
	echo $resultado;

	function InsertarInvitado($conexion, $nombreTabla, $nombre, $apellido, $correo)
	{
		$queryInsert = "insert into " . $nombreTabla . " (Nombre, Apellido, Correo) values ('" . $nombre . "', '" . $apellido . "', '" . $correo . "')";
		$resultadoInsert = mysqli_query($conexion, $queryInsert) or die('La consulta falló ' . mysql_error());
		return "Ingresado";
	}
?>
