<?php
    // include 'acesso_res.php';
    include '../conn/connect.php';
    if ($_POST) {
        // insert em usuarios
        $login = $_POST['login'];
        $senha = md5($_POST['senha']);
        
        $insereUsuario = "INSERT INTO usuarios (`login`,senha,ativo,nivel_id) VALUES ('$login','$senha',DEFAULT,3)";
        $resultadoUsuario = $conn->query($insereUsuario);
        
        if (mysqli_insert_id($conn)) {
            // recuperando id do usuario inserido
            $recuperaUsuario = ("SELECT * FROM usuarios WHERE login = '$login' AND senha = '$senha'");
            $executa = $conn->query($recuperaUsuario);
            $executa = $executa->fetch_assoc();
        
            // inserindo cliente
            $nome = $_POST['nome'];
            $cpf = $_POST['cpf'];
            $email = $_POST['email'];
            $idUsuario = $executa['id'];

            echo $idUsuario;

            $insereCliente = "INSERT INTO clientes (nome, cpf, email, usuario_id) VALUES ('$nome', '$cpf', '$email', $idUsuario)";
            $resultadoCliente = $conn->query($insereCliente);
            print_r($resultadoCliente);
            if (mysqli_insert_id($conn)) {
            header('location:login_reserva.php');
        }
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
    <title>CADASTRAR CLIENTE</title>
</head>

<body>
    <?php include "menu_reservas.php";?>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-danger">
                    Cadastrando Cliente
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-danger" role="alert">
                        <form action="cadastro_cliente.php" method="post" name="form_insere"
                            enctype="multipart/form-data" id="form_insere">
                            <label for="descricao">Nome:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="nome" id="nome" class="form-control"
                                    placeholder="Digite o seu nome completo*" maxlength="100" required>
                            </div>
                            <label for="descricao">CPF:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="cpf" id="cpf" class="form-control"
                                    placeholder="Digite os NUMEROS do seu CPF*" maxlength="100" required>
                            </div>
                            <label for="descricao">Email:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="email" name="email" id="email" class="form-control"
                                    placeholder="Digite o seu Email*" maxlength="100" required>
                            </div>
                            <label for="descricao">Login:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="login" id="login" class="form-control"
                                    placeholder="Digite o seu Login*" maxlength="100" required>
                            </div>
                            <label for="descricao">Senha:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="password" name="senha" id="senha" class="form-control"
                                    placeholder="Digite a sua senha*" maxlength="100" required>
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