<?php
include "conn/connect.php";
$lista_tipo = $conn->query('select * from vw_produto order by rotulo');
$rows_tipo = $lista_tipo ->fetch_all();
?>
