<?php
    include 'acesso_res.php';
    include '../conn/connect.php';
    
    // recuperando id do cliente
    if (isset($_SESSION['login_usuario'])) {
        $cliente_id = $_SESSION['cliente_id'];
    }

    $lista = $conn->query("SELECT * FROM vw_reservas WHERE id_do_cliente = $cliente_id AND status_rotulo != 'Cancelado' ORDER BY dia" );
    $row = $lista->fetch_assoc();
    $num_linhas = $lista->num_rows;
?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Reservas - Lista</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
</head>

<body>
    <?php include 'menu_reservas.php'; ?>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-danger">
                    <a href="index.php">
                        <button class="btn btn-danger">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    Lista
                </h2>
                <table class="table table-hover table-condensed tb-opacidade bg-warning">
                    <thead>
                        <th class="hidden">ID</th>
                        <th>Nome do Cliente</th>
                        <th>Motivo da Reserva</th>
                        <th>Numero de Pessoas</th>
                        <th>Stauts da Reserva</th>
                        <th>Dia da Reserva</th>
                        <th>Hora de Inicio da Reserva</th>
                        <th>Hora do Fim da Reserva</th>
                        <th>Ações</th>
                    </thead>

                    <tbody>
                        <!-- início corpo da tabela -->
                        <!-- início estrutura repetição -->
                        <?php 
                do {
                    if ($num_linhas > 0) {
                ?>
                        <tr>
                            <td class="hidden"><?= $row['id'] ?></td>
                            <td><?= $row['nome']; ?></td>
                            <td><?= $row['motivo_reserva']; ?></td>
                            <td><?= $row['numero_pessoas']; ?></td>
                            <td><?= $row['status_rotulo']; ?></td>
                            <td><?= date('d/m/Y', strtotime($row['dia'])); ?></td>
                            <td><?= date('H:i', strtotime($row['hora_inicio'])); ?></td>
                            <td><?= date('H:i', strtotime($row['hora_fim'])); ?></td>
                            
                            <td>
                                <button data-nome="<?= $row['nome']; ?>" data-id="<?= $row['cliente_reserva_id']; ?>"
                                    class="delete btn btn-xs btn-block btn-danger">
                                    <span class="glyphicon glyphicon-trash"></span>
                                    <span class="hidden-xs">CANCELAR</span>
                                </button>
                            </td>
                        </tr>

                        <?php 
                    }
                } while ($row = $lista->fetch_assoc());
                ?>
                    </tbody><!-- final corpo da tabela -->
                </table>
            </div>
        </div>
    </main>
    <!-- inicio do modal para excluir... -->
    <div class="modal fade" id="modalEdit" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4>Cancelar Reserva</h4>
                    <button class="close" data-dismiss="modal" type="button">
                        &times;

                    </button>
                </div>
                <div class="modal-body">
                    Deseja mesmo cancelar a sua reserva <span class="nome text-danger"></span>?
                </div>
                <div class="modal-footer">
                    <a href="#" type="button" class="btn btn-danger delete-yes">
                        Confirmar
                    </a>
                    <button class="btn btn-success" data-dismiss="modal">
                        Cancelar
                    </button>
                </div>
            </div>
        </div>

    </div>
</body>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="../js/bootstrap.min.js"></script>
<script type="text/javascript">
$('.delete').on('click', function() {
    var nome = $(this).data('nome'); //busca o nome do cliente (data-nome)
    var id = $(this).data('id'); // busca o id da reserva (data-id)
    //console.log(id + ' - ' + nome); //exibe no console
    $('span.nome').text(nome); // insere o nome do cliente na confirmação
    $('a.delete-yes').attr('href', 'cancela_reserva.php?id=' +
        id); //chama o arquivo php para excluir a reserva
    $('#modalEdit').modal('show'); // chamar o modal
});
</script>

<?php

?>

</html>