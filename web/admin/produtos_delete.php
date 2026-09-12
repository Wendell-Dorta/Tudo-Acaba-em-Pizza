<?php 
include "../conn/connect.php";
$id = $_GET['id'];
$ativo = 0;
$conn->query("call sp_produto_delete($id,$ativo)");
header("location:produtos_lista.php");

?>