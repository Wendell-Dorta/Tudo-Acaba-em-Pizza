<?php 
include "../conn/connect.php";
$id = $_GET['id'];
$ativo = 0;
$conn->query("call sp_usuario_delete($id,$ativo)");
header("location:usuarios_lista.php");

?>