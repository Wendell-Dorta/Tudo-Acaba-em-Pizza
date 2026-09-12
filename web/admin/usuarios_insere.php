<?php 
include 'acesso_com.php';
 include '../conn/connect.php';
 if($_POST)
 {
    $nome = $_POST['nome'];
    $email = $_POST['email'];
    $senha = $_POST['senha'];
    $nivel = $_POST['nivel'];
    $insereUsuario = "insert usuarios (nome,email,senha,nivel_id)
    values
    ('$nome', '$email' ,'$senha','$nivel')";

    $resultado = $conn->query($insereUsuario);
 }

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>INSERE USUÁRIO | COWABUNGA </title>
</head>

<body>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-success">
                    <a href="usuarios_lista.php">
                        <button class="btn btn-success">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    Inserir Usuário
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-success" role="alert">
                        <form action="usuarios_insere.php" method="post">


                            <label for="text">Nome : </label>
                            <input type="text" id="nome" name="nome" required class="form-control"><br><br>

                            <label for="email">Email : </label>
                            <input type="email" id="email" name="email" required class="form-control"><br><br>

                            <label for="senha">Senha : </label>
                            <input type="password" id="senha" name="senha" required class="form-control"><br><br>

                            <p>Nivel:</p>

                            <input type="radio" id="nivel" name="nivel" value="1" required>
                            <label for="superior">Superior</label>
                            <br>
                            <input type="radio" id="nivel" name="nivel" value="2" required checked>
                            <label for="comum">Comum</label>
                            <br>
                            <br>

                            <input type="submit" value="Enviar" id="button" class="btn btn-success btn-block">
                    </div>
                </div>
            </div>
        </div>
    </main>
</body>

</html>