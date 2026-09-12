<?php
 include '../conn/connect.php';
 // inicia a verificação do login
 if($_POST){
        $login = $_POST['login'];
        $senha = $_POST['senha'];
        $options= [
            'options' => 10,
        ];
        password_hash($senha,PASSWORD_BCRYPT,$options);
        if (preg_match("/^\d{3}\.?\d{3}\.?\d{3}-?\d{2}$/", $login)) {
            $userRes = $conn->query("SELECT * FROM vw_cliente WHERE cpf = '$login'AND ativo = 1");
        } 
        // Verifica se o valor digitado é um e-mail
        else if (filter_var($login, FILTER_VALIDATE_EMAIL)) {
            $userRes = $conn->query("SELECT * FROM vw_cliente WHERE email = '$login' AND ativo = 1");
        } 
        else {
            echo "<script>window.open('invasor.php','_self')</script>";
            exit;
        }
        $rowUser = $userRes->fetch_assoc();
        $numRow = $userRes->num_rows;
        if (password_verify($senha, $rowUser['senha'])) {
            $nivelRes = $conn->query("select * from niveis where upper(descricao) = upper('cliente')");
            $rowNivel = $nivelRes->fetch_assoc();
            // se a sessão não existir
            if(!isset($_SESSION)){
                $sessaoAntiga = session_name('cowabungaaaCliiii');
                session_start();
                $session_name_new = session_name();
            }
            if($numRow > 0){
                // fazendo select em nivel
                $idNivel = $rowUser['nivel_id'];
                $nivelRes = $conn->query("select * from niveis where id = $idNivel");
                $nivelRow = $nivelRes->fetch_assoc();
                // adicionando valores a variavel de sessão
                $_SESSION['id_cliente'] = $rowUser['id'];
                $_SESSION['nome_cliente'] = $rowUser['nome'];
                $_SESSION['nivel_cliente'] = $nivelRow['descricao'];
                $_SESSION['cpf_cliente'] = $rowUser['cpf'];
                $_SESSION['email_cliente'] = $rowUser['email'];
                $_SESSION['nome_da_sessao'] = session_name();
                if($rowUser['nivel_id'] != $rowNivel['id']){
                    echo "<script>window.open('index.php','_self')</script>";
                }else{
                    echo "<script>window.open('../cliente/index.php?cliente=".$login."','_self')</script>";
                }
            }
            else{
                echo "<script>window.open('invasor.php','_self')</script>";
            }
        }
 }
?>
<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="refresh" content="30;URL=../index.php">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <script src="https://kit.fontawesome.com/2495680ceb.js" crossorigin="anonymous"></script>
    <!-- Link para CSS específico -->
    <link rel="stylesheet" href="../css/estilo.css" type="text/css">

    <title> Cowabunga | Login Cliente</title>
</head>

<body class="fundofixo">
    <main class="container">
        <section>
            <article>
                <div class="row">
                    <div class="col-xs-12 col-sm-6 col-sm-offset-3 col-md-4 col-md-offset-4">
                        <h1 class="breadcrumb text-secondary text-center">Faça seu login</h1>
                        <div class="thumbnail">
                            <p class="text-secondary text-center" role="alert">
                                <i class="fas fa-users fa-10x"></i>
                            </p>
                            <br>
                            <div class="alert alert-secondary" role="alert">
                                <form action="login_cliente.php" name="form_login" id="form_login" method="POST"
                                    enctype="multipart/form-data">
                                    <label for="nome_usuario">Login:</label>
                                    <p class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-user text-secondary" aria-hidden="true"></span>
                                        </span>
                                        <input type="text" name="login" id="login" class="form-control" autofocus
                                            required autocomplete="off" placeholder="Digite seu email ou cpf">
                                    </p>
                                    <label for="senha">Senha:</label>
                                    <p class="input-group">
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-qrcode text-secondary"
                                                aria-hidden="true"></span>
                                        </span>
                                        <input type="password" name="senha" id="senha" class="form-control" required
                                            autocomplete="off" placeholder="Digite sua senha">
                                    </p>
                                    <p class="text-right">
                                        <input type="submit" value="Entrar" class="btn btn-secondary">
                                    </p>
                                </form>
                                <p class="text-center">
                                    <small>
                                        <br>
                                        Caso não faça uma escolha em 30 segundos será redirecionado automaticamente para
                                        página inicial.
                                    </small>
                                </p>
                            </div><!-- fecha alert -->
                        </div><!-- fecha thumbnail -->
                    </div><!-- fecha dimensionamento -->
                </div><!-- fecha row -->
            </article>
        </section>
    </main>


    <!-- Link arquivos Bootstrap js -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
</body>

</html>