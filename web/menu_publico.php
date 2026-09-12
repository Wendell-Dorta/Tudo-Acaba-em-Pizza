<?php
include "conn/connect.php";
$lista_tipo = $conn->query('select * from categorias order by descricao');
$rows_tipo = $lista_tipo ->fetch_all();

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/estilo.css">
    <title>Document</title>
</head>
<body>
<nav class="navbar navbar-expanded-md navbar-fixed-top navbar-light navbar-inverse">
    <div class="row">
        <div class="collapse navbar-collapse" id="menupublico">
            <div class="col-md-4">
                <ul class="nav navbar-nav navbar-left">
                    <li class="active nav-item">
                        <a href="index.php" class="nav-link">
                            <span class="glyphicon glyphicon-home"></span>
                        </a> 
                    </li>
                    
                </ul>
            </div>
            <div class="col-md-4">
                <ul class="nav navbar-nav">
                    <li><a href="index.php#destaques">DESTAQUES</a></li>
                    <li><a href="index.php#produtos">PRODUTOS</a></li>
                    <!-- Dropdown -->
                    <li class="dropdown">
                        <a class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true"
                            aria-expanded="false">
                            CATEGORIAS
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <?php foreach ($rows_tipo as $row) { ?>
                            <li>
                                <a href="produtos_por_tipo.php?id=<?php echo $row[0] . '&descricao=' .  $row[2]; ?>">
                                    <?php echo $row[2]; ?>
                                </a>
                            </li>
                            <?php } ?>
                        </ul>
                    </li>
                    <!-- fim do dropdown -->
                    <li><a href="index.php#contato">CONTATO</a></li>
                </ul>
            </div>
            <div class="col-md-4">
                <ul class="nav navbar-nav navbar-right">
            
                    <li class="active">
                        <a href="carrinho.php">
                            <span class="glyphicon glyphicon-shopping-cart"></span>
                        </a> 
                    </li>
                    
                    <!-- inicio formulário de buscar -->
                    <form action="produtos_busca.php" method="get" name="form-busca" id="form-busca"
                        class="navbar-form navbar-left" role="search">
                        <div class="input-group">
                            <input type="search" name="buscar" id="buscar" size="19" class="form-control"
                                aria-label="search" placeholder="Buscar produto" required>
                            <div class="input-group-btn">
                                <button class="btn btn-default" type="submit">
                                    <span class="glyphicon glyphicon-search"></span>
                                </button>
                            </div>
                        </div>
                    </form>
                    <!-- FIM formulário de busca -->
                    <li class="active">
                        <a href="menu_login.php">
                            <span class="glyphicon glyphicon-user">&nbsp;ADMIN/CLIENTE&nbsp;&nbsp;</span>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</nav>
</body>
</html>

