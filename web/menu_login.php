<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="refresh" content="30;URL=index.php">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <script src="https://kit.fontawesome.com/2495680ceb.js" crossorigin="anonymous"></script>
    <!-- Link para CSS específico -->
    <link rel="stylesheet" href="css/estilo.css" type="text/css">

    <title>Cowabunga | Acesso</title>
</head>

<body class="fundofixo">
    <main class="container">
        <section>
            <article class="d-flex flex-column justify-content-center align-items-center" style="height: 100vh;">
                <div class="col-xs-12 col-sm-8 col-md-6 text-center">
                    <h1 class="breadcrumb text-secondary mb-4">Escolha o tipo de login</h1>
                    <div class="thumbnail">
                        <p class="text-secondary text-center" role="alert">
                            <i class="fas fa-users fa-10x"></i>
                        </p>
                        <br>
                        <div class="alert alert-secondary" role="alert">
                            <!-- Divs para botões com mesmo tamanho e espaçamento -->
                            <div class="mb-3">
                                <button class="btn btn-primary btn-lg btn-block" onclick="window.location.href='admin/login.php'">Login
                                    Administrativo</button>
                            </div>
                            <br>
                            <div>
                                <button class="btn btn-primary btn-lg btn-block"
                                    onclick="window.location.href='cliente/login_cliente.php'">Login Cliente</button>
                            </div>
                            <p class="text-center mt-3">
                                <small>
                                    Caso não faça uma escolha em 30 segundos será redirecionado automaticamente para a
                                    página inicial.
                                </small>
                            </p>
                        </div><!-- fecha alert -->
                    </div><!-- fecha thumbnail -->
                </div><!-- fecha col-md-6 -->
            </article>
        </section>
    </main>

    <!-- Link arquivos Bootstrap js -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>

</html>