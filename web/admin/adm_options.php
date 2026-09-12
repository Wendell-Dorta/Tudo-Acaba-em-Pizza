<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>Document</title>
</head>
<body>
<main class="container">
<h1 class="breadcrumb">Área Administrativa</h1>
<div class="row"><!-- manter os elementos na linha -->
 
<!-- ADM PRODUTOS -->
<div class="col-sm-6 col-md-4">
    <div class="thumbnail alert-danger">
        <img src="../images/icone_produtos.png" alt="">
        <br>
        <div class="alert-danger">
 
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <button class="btn btn-default disabled" role="alert" style="cursor: default;">
                        PRODUTOS
                    </button>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <a href="produtos_lista.php">
                        <button class="btn btn-danger">
                            LISTA
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
                <div class="btn-group">
                    <a href="produtos_insere.php">
                        <button class="btn btn-danger">
                            INSERIR
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
        </div><!-- fecha alert-danger -->
    </div><!-- fecha thumbnail -->
</div><!-- fecha col -->
<!-- fecha ADM PRODUTOS -->
 
<!-- ADM CATEGORIAS -->
<div class="col-sm-6 col-md-4">
    <div class="thumbnail alert-warning">
        <img src="../imagens/icone_tipos.png" alt="">
        <br>
        <div class="alert-warning">
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <button class="btn btn-default disabled" role="alert" style="cursor: default;">
                        CATEGORIAS
                    </button>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <a href="categorias_lista.php">
                        <button class="btn btn-warning">
                            LISTAR
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
                <div class="btn-group">
                    <a href="categorias_insere.php">
                        <button class="btn btn-warning">
                            INSERIR
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
        </div><!-- fecha alert-warning -->
    </div><!-- fecha thumbnail -->
</div><!-- fecha col -->
<!-- fecha ADM categorias -->
 
<!-- ADM USUÁRIOS -->
<div class="col-sm-6 col-md-4">
    <div class="thumbnail alert-info">
        <img src="../imagens/icone_user.png" alt="">
        <br>
        <div class="alert-info">
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <button class="btn btn-default disabled" role="alert" style="cursor: default;">
                        USUÁRIOS
                    </button>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
            <div class="btn-group btn-group-justified" role="group">
                <div class="btn-group">
                    <a href="usuarios_lista.php">
                        <button class="btn btn-info">
                            LISTAR
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
                <div class="btn-group">
                    <a href="usuarios_insere.php">
                        <button class="btn btn-info">
                            INSERIR
                        </button>
                    </a>
                </div><!-- fecha btn-group -->
            </div><!-- fecha btn-group-justified -->
 
        </div><!-- fecha alert-warning -->
    </div><!-- fecha thumbnail -->
</div><!-- fecha col -->
<!-- fecha ADM USUÁRIOS -->
 

 
</div><!-- fecha row -->
 
</main>
</body>
</html>