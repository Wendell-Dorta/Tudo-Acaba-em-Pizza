<?php 
include 'acesso_com.php';
include '../conn/connect.php';

$listaCats = $conn->query("select * from categorias");
$rowCat = $listaCats->fetch_assoc();
$rowsCat = $listaCats->num_rows; 

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>LISTA DE CATEGORIAS | COWABUNGA</title>
</head>

<body>
    <?php include 'menu_adm.php'; ?>
    <main class="container">
        <h2 class="breadcrumb alert-danger">Lista de Categorias</h2>
        <table class="table table-hover table-condensed tb-opacidade bg-warning">
            <thead>
                <th class="hidden">ID</th>
                <th>SIGLA</th>
                <th>DESCRIÇÃO</th>
                <th>
                    <a href="categorias_insere.php" target="_self" class="btn btn-primary btn-xs" role="button">
                        <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>
                        <span class="hidden-xs">ADICIONAR</span>
                    </a>
                </th>
            </thead>
            <tbody>
                <?php do{
                        if ($rowCat !== null) {
                    ?>
                <tr>
                    <td class="hidden">
                        <?php echo $rowCat['id']; ?>
                    </td>
                    <td>
                        <?php echo $rowCat['sigla'];?>
                        <span class="visible-xs"></span>
                        <span class="hidden-xs"></span>
                    </td>
                    <td>
                        <?php echo $rowCat['descricao'];?>
                        <span class="visible-xs"></span>
                        <span class="hidden-xs"></span>
                    </td>
                    <td>
                        <a href="categorias_atualiza.php?id=<?php echo $rowCat['id'] ?>" role="button"
                            class="btn btn-warning  btn-xs">
                            <span class="glyphicon glyphicon-refresh"></span>
                            <span class="hidden-xs">Alterar</span>
                        </a>
                        <?php  
                        $regra = $conn->query("select descricao from categorias where id =".$rowCat['id']);
                        $regraRow = $regra->fetch_assoc();
                        ?>
                        <a href="categorias_delete.php?id=<?php echo $rowCat['id'] ?>" role="button"
                            class="btn btn-danger  btn-xs">
                            <span class="glyphicon glyphicon-trash"></span>
                            <span class="hidden-xs">Excluir</span>
                        </a>
                        
                    </td>

                </tr>
                <?php }}while($rowCat = $listaCats->fetch_assoc());?>
            </tbody>
        </table>
    </main>
    <div class="modal fade" id="modalEdit" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4>Vamos deletar?</h4>
                    <button class="close" data-dismiss="modal" type="button">
                        &times;

                    </button>
                </div>
                <div class="modal-body">
                    Deseja mesmo excluir a categoria?
                    <h4><span class="nome text-danger"></span></h4>
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
    var tipoRotulo = $(this).data('nome'); //busca o nome com a descrição (data-nome)
    var tipoId = $(this).data('id'); // busca o id (data-id)
    //console.log(id + ' - ' + nome); //exibe no console
    $('span.nome').text(tipoRotulo); // insere o nome do item na confirmação
    $('a.delete-yes').attr('href', 'produtos_excluir.php?id=' +
    tipoId); //chama o arquivo php para excluir o produto
    $('#modalEdit').modal('show'); // chamar o modal
});
</script>
</html>