<!-- bootstrap -->
<!-- abre a barra de navegação -->
<nav class="navbar navbar-expanded-md navbar-light navbar-inverse">
    <div class="conteinar-fluid">
        <!-- agrupamento Mobile -->
        <div class="navbar-header">
            <button class="navbar-toggle collapsed" type="button" data-toggle="collapse" data-target="#menupublico"
                aria-expanded="false">
                <span class="sr-only">Toggle Navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a href="../index.php" class="navbar-brand">
                <img src="../images/logo-chuleta.png" alt="Logotipo Chuleta Quente">
            </a>
        </div>
        <!-- fecha agrupamento mobile -->
        <!-- nav direita -->
        <div class="collapse navbar-collapse" id="menupublico">
            <ul class="nav navbar-nav navbar-right">
                <li class="active">
                    <a href="../index.php">
                        <span class="glyphicon glyphicon-home"></span>
                    </a>
                </li>
                <li>
                    <a href="lista_reservas.php">LISTA DE RESERVAS</a>
                </li>
                <li>
                    <a href="faca_reserva.php">FAZER RESERVAS</a>
                </li>
                <li class="active">
                    <a href="index.php">
                        <span class="glyphicon glyphicon-user">&nbsp;USER</span>
                    </a>
                </li>
                <li>
                    <a href="logout.php">
                        <span class="glyphicon glyphicon-log-out"></span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</nav>