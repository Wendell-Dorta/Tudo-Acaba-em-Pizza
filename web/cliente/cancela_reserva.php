<?php 
    include 'acesso_res.php';
    include '../conn/connect.php';

    if ($_GET) {
        $id = $_GET['id'];
        $status = $conn->query("SELECT * FROM `status` WHERE rotulo = 'Cancelado'");
        $rowStatus = $status->fetch_assoc();
        $status_id = $rowStatus['id'];

        $delete = "UPDATE cliente_reserva SET status_id = $status_id WHERE id = $id";
        $resultado = $conn->query($delete);
        if ($resultado) {
            header('location:lista_reservas.php');
        }
    }
?>