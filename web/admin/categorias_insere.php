<?php
include 'acesso_com.php';
include '../conn/connect.php';

if($_POST)
 {
    $sigla = $_POST['sigla'];
    $rotulo = $_POST['rotulo'];
    $insereCat = "insert categorias (sigla,descricao)
    values
    ('$sigla','$rotulo')";
    $resultado = $conn->query($insereCat); 
 }

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="..//css/bootstrap.min.css">
    <link rel="stylesheet" href="..//css/estilo.css">
    <title>INSERE CATEGORIAS | COWABUNGA</title>
</head>

<body>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-success">
                    <a href="categorias_lista.php">
                        <button class="btn btn-success">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    Inserir Categoria
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-success" role="alert">
                        <form action="categorias_insere.php" method="post">
                            <label for="text">SIGLA : </label>
                            <input type="text" id="sigla" name="sigla" required class="form-control"><br><br>

                            <label for="senha">DESCRIÇÃO : </label>
                            <input type="text" id="rotulo" name="rotulo" required class="form-control"><br><br>
                            <input type="submit" value="Enviar" id="button" class="btn btn-success btn-block">


                    </div>
                </div>
            </div>
        </div>
    </main>
</body>

</html>