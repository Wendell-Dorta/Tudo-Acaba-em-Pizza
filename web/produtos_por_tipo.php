<?php
include 'conn/connect.php';
$Categoria = $_GET['id'];
$descricaoCategoria = $_GET['descricao'];
$listaPorTipo = $conn->query("SELECT * FROM vw_produto where categoria_id =" . $Categoria);
$rowPorTipo = $listaPorTipo->fetch_assoc();
$numLinhas = $listaPorTipo->num_rows; 
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/estilo.css">
    <title>COWABUNGA | CATEGORIAS</title>
</head>
<body class="fundofixo">
    <?php include "menu_publico.php"; ?>
    <div class="container">

<!-- Mostrar se a consulta retornar vazio   -->

<?php if($numLinhas == 0){?>
    <h2 class="breadcrumb alert-danger">
        <a href="javascript:window.history.go(-1)" class="btn btn-danger">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        Não há produtos da Categoria <?php echo $descricaoCategoria?>!
    </h2>
<?php }?>
<!-- mostrar se a consulta retornou produtos -->
<?php if($numLinhas > 0){?>
    <h2 class="breadcrumb alert-danger">
        <a href="javascript:window.history.go(-1)" class="btn btn-danger">
            <span class="glyphicon glyphicon-chevron-left"></span>
        </a>
        <strong><?php echo $descricaoCategoria; ?></strong> 
    </h2>
    <div class="row">
        <?php do{ ?>
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail ">
                <a href="produto_detalhes.php?id=<?php echo $rowPorTipo['id_do_produto']?>">
                    <img src="images/<?php echo $rowPorTipo['nome_imagem']?>" alt="" class="img-resposive img-rounded">
                </a>
                <div class="caption text-right bg-secondary">
                    <h3 class="text-danger">
                        <strong><?php echo $rowPorTipo['rotulo']?></strong>
                    </h3>
                    <p class="text-left">
                        <?php echo mb_strimwidth($rowPorTipo['descricao'],0,42,'...');?>
                    </p>
                    <p>
                        <button class="btn btn-default disabled" role="button" style="cursor: default;">
                            <?php echo "R$".number_format($rowPorTipo['valor_unit'],2,',','.') ?>
                        </button>
                        <a href="produto_detalhes.php?id=<?php echo $rowPorTipo['id_do_produto']; ?>">
                        <span class="hidden-xs">Saiba mais..</span>
                        <span class="hidden-xs glyphicon glyphicon-eye-open" aria-hidden="true"></span>
                    </a>
                    </p>
                </div>
            </div>
        </div>
        <?php }while($rowPorTipo = $listaPorTipo->fetch_assoc()); ?>
    </div>

<?php }?>

</main>
</body>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="https://code.jquery.com/jquery-2.2.0.min.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function() {
    $(".regular").slick({
        dots:true,
        infinity:true,
        slidesToShow:3,
        slidesToScroll:3
    });
});
</script>
<script type="text/javascript" src="https://cdn.jsdelivr.net/npm/slick.min.js"></script>
</html>