<?php 
include "../conn/connect.php";
$conn->query("delete from categorias where id = ".$_GET['id']);
header("location:categorias_lista.php");
?>