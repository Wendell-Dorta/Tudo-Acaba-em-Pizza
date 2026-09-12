<?php
    include 'acesso_res.php';
    include '../conn/connect.php';

    
    if ($_POST) {
        // buscando dados para inserção
        $data = $_POST['data'];
        $hora_inicio = $_POST['horaIncio'];
        $hora_fim = $_POST['horaFim'];
        $numPessoas = $_POST['numPessoas'];
        $motivo = $_POST['motivo'];
        // recuperando id do cliente
        if (isset($_SESSION['login_usuario'])) {
            $cliente_id = $_SESSION['cliente_id'];
        }

        
        // inserindo dados na tabela reserva
        $insereReserva = "INSERT INTO reservas (dia,hora_inicio,hora_fim,numero_pessoas,motivo_reserva,ativo) VALUES ('$data','$hora_inicio','$hora_fim',$numPessoas,'$motivo',DEFAULT)";
        $resultado = $conn->query($insereReserva);
        $reserva_id = mysqli_insert_id($conn);
        
        

        // buscar id do status "Andamento"
        $status = $conn->query("SELECT * FROM `status` WHERE rotulo = 'Andamento'");
        $rowStatus = $status->fetch_assoc();
        $status_id = $rowStatus['id'];

        // inserindo dados na tabela cliente_reserva
        $insereClienteReserva = "INSERT INTO cliente_reserva (cliente_id, status_id,reserva_id,data_reserva_feita) VALUES ($cliente_id,$status_id,$reserva_id,DEFAULT)";
        print_r($insereClienteReserva);
        $resultado = $conn->query($insereClienteReserva);
        if (mysqli_insert_id($conn)) {
           header('location:lista_reservas.php');
        }
    }
?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>Fazer Reservas</title>
</head>

<body>
    <?php include "menu_reservas.php";?>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-danger">
                    <a href="index.php">
                        <button class="btn btn-danger">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    FAZENDO RESERVAS
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-danger" role="alert">
                        <form action="faca_reserva.php" method="post" name="form_insere" enctype="multipart/form-data"
                            id="form_insere">
                            <label for="destaque">Data:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="date" name="data" id="data" class="form-control">
                            </div>
                            <label for="destaque">Hora de Inicio:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="time" name="horaIncio" id="data" class="form-control">
                            </div>
                            <label for="destaque">Hora do Fim:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="time" name="horaFim" id="data" class="form-control">
                            </div>
                            <label for="descricao">Numero Pessoas:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="number" name="numPessoas" id="numPessoas" class="form-control"
                                    placeholder="Digite a quantidade de pessoas*" required>
                            </div>

                            <label for="resumo">Motivo:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-list-alt" aria-hidden="true"></span>
                                </span>
                                <textarea name="motivo" id="motivo" cols="30" rows="8" class="form-control"
                                    placeholder="Digite o motivo da reserva"></textarea>
                            </div>

                            <br>
                            <input type="submit" name="enviar" id="enviar" class="btn btn-danger btn-block"
                                value="Cadastrar">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </main>
</body>

</html>