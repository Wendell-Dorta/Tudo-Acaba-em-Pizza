<?php
// arquivo de conexão
include 'conn/connect.php';
 
// consulta para trazer os dados se filtrar
$id = $_GET['id'];
$listaDestaque = $conn->query("select * from vw_produto where id_do_produto = $id");
$linhaDestaque = $listaDestaque->fetch_assoc();
$numlinhasDestaque = $listaDestaque->num_rows;
?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/estilo.css">
    <title>Detalhes Produto</title>
</head>

<body class="fundofixo">
    <?php  include 'menu_publico.php'?>
    <div class="container">
        <h2 class="breadcrumb alert-danger">
            <a href="index.php">
                <button class="btn btn-danger">
                    <span class="glyphicon glyphicon-chevron-left"></span>
                </button>
            </a>
            <strong>Detalhes do Produto</strong>
        </h2>
        <div class="row">
            <?php do{?>
            <div class="thumbnail">
                <a href="produto_detalhes.php">
                    <img src="images/<?php echo $linhaDestaque['nome_imagem'] ?>"
                        alt="images<?php echo $linhaDestaque['rotulo'] ?>" class="img-responsive img-rounded"
                        style="heigth: 20em ;">
                </a>
                <div class="caption text-center">
                    <h3 class="text-danger">
                        <strong><?php echo $linhaDestaque['rotulo']?></strong>
                    </h3>
                    <p class="text-warning">
                        <strong><?php echo $linhaDestaque['categoria_descricao']?></strong>
                    </p>

                    <p class="text-center">
                        <strong><?php echo $linhaDestaque['descricao']?></strong>
                    </p>
                    <p>
                        <a href="carrinho.php" class="btn btn-danger" role="button">
                            <span class="glyphicon glyphicon-shopping-cart" aria-hidden="true"></span>
                             &nbsp;
                            <span class="hidden-xs">Adicionar ao carrinho</span>
                        </a>
                    </p>
                </div>
            </div>?>
            <?php } while($linhaDestaque = $listaDestaque->fetch_assoc());?>
        </div>
    </div>
</body>

</html>