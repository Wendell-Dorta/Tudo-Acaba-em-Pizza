<?php 
 include '../conn/connect.php';
?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="refresh" content="40;URL=../index.php">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <script src="https://kit.fontawesome.com/2495680ceb.js" crossorigin="anonymous"></script>
    <!-- Link para CSS específico -->
    <link rel="stylesheet" href="../css/estilo.css" type="text/css">

    <title> Cowabunga | Security</title>
</head>

<body class=fundofixo>
    <main class="container">
        <section>
            <article>
                <div class="row">
                    <div class="col-xs-15 col-sm-15 col-sm-offset-15 col-md-15 col-md-offset-15">
                        <h1 class="breadcrumb text-danger text-center">USUÁRIO OU SENHA INCORRETOS</h1>
                        <div class="thumbnail">
                            <p class="text-danger text-center" role="alert">
                                <i class="fas fa-lock fa-10x"></i>
                            </p>
                            <br>
                            <div class="alert alert-danger text-center" role="alert">
                                <p>
                                    Por conta de erros de digitação o sistema de segurança foi executado.
                                </p>
                                
                                <p class="text-center">
                                    <small>
                                        você será redirecionado em 50 segundos automaticamente para
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