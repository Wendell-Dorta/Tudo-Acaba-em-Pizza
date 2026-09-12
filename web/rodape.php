<div class="row panel-footer fundo-rodape">
    <!-- area de localização -->
    <div class="col-sm-6 col-md-4">
        <div class="panel-footer" style="background: none;">
            <img src="images/logo-cowa.svg" alt="logo_pequeno">
            <br>
            <br>
            <i><strong> A melhor pizzaria da Zona Leste</strong></i>
            <address>
                <i>Av. Itaquera, 6904 - Artur Alvim, São Paulo - SP, 08285-065</i>
                <br>
                <span class="glyphicon glyphicon-phone-alt"></span>
                &nbsp;(11) 9400-2892
                <br>
                <span class="glyphicon glyphicon-envelope"></span>
                &nbsp;
                <a href="mailto:contato@cowabunga.com.br?subject=Contato do Site&cc=freiresdasilvabrunoeduardo@gmail.com">
                    contato@cowabunga.com.br
                </a>
            </address>
            <div class="embed-responsive embed-responsive-4by3">
                <!-- local para iframe -->
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.5019796795027!2d-46.465021723760266!3d-23.550408261191546!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce66ec09e52445%3A0x8f1ed6139100298a!2sAv.%20Itaquera%2C%206904%20-%20Artur%20Alvim%2C%20S%C3%A3o%20Paulo%20-%20SP%2C%2008285-065!5e0!3m2!1spt-PT!2sbr!4v1724849127732!5m2!1spt-PT!2sbr" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>                </iframe>
                <!-- fim iframe -->
            </div>
        </div>
    </div>
    <!-- final area de localização -->
    <div class="col-sm-6 col-md-4">
        <div class="panel-footer">
            <h4>Links</h4>
            <ul class="nav nav-pills nav-stacked">
                <li>
                    <a href="index.php#home" class="text-success">
                        <span class="glyphicon glyphicon-home" aria-hidden="true">&nbsp;Home</span>
                    </a>
                </li>
                <li>
                    <a href="index.php#destaques" class="text-success">
                        <span class="glyphicon glyphicon-ok-sign" aria-hidden="true">&nbsp;Destaques</span>
                    </a>
                </li>
                <li>
                    <a href="index.php#produtos" class="text-success">
                        <span class="glyphicon glyphicon-cutlery" aria-hidden="true">&nbsp;Produtos</span>
                    </a>
                </li>
                <li>
                    <a href="index.php#contato" class="text-success">
                        <span class="glyphicon glyphicon-envelope" aria-hidden="true">&nbsp;Contato</span>
                    </a>
                </li>
                <li>
                    <a href="admin/index.php" class="text-success">
                        <span class="glyphicon glyphicon-user" aria-hidden="true">&nbsp;Admin</span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
    <!-- area de contatos -->
    <div class="col-sm-6 col-md-4">
        <div class="panel-footer" style="background: none;">
            <h4>Contato</h4>
            <form action="rodape_contato_envia.php" name="form_contato" id="form_contato" method="post">
                <p>
                    <span class="input-group">
                        <span class="input-group-addon" id="basic-addon1">
                            <span class="glyphicon glyphicon-user"></span>
                        </span>
                        <input type="text" name="nome_contato" placeholder="Digite seu nome"
                            aria-describedby="basic-addon1" class="form-control" required>
                    </span>
                </p>
                <p>
                    <span class="input-group">
                        <span class="input-group-addon" id="basic-addon2">
                            <span class="glyphicon glyphicon-envelope"></span>
                        </span>
                        <input type="text" name="email_contato" placeholder="Digite seu email"
                            aria-describedby="basic-addon2" class="form-control" required>
                    </span>
                </p>
                <p>
                    <span class="input-group">
                        <span class="input-group-addon" id="basic-addon2">
                            <span class="glyphicon glyphicon-tags"></span>
                        </span>
                        <input type="text" name="assunto_contato" placeholder="Digite o assunto do email"
                            aria-describedby="basic-addon2" class="form-control" required>
                    </span>
                </p>
                <p>
                    <span class="input-group">
                        <span class="input-group-addon" id="basic-addon3">
                            <span class="glyphicon glyphicon-pencil"></span>
                        </span>
                        <textarea name="comentario_contato" cols="30" rows="5" placeholder="Digite seu Comentário"
                            aria-describedby="basic-addon3" class="form-control" required>
                            </textarea>
                    </span>
                </p>
                <p>
                    <button class="btn btn-success btn-block " aria-label="enviar" role="button" onclick="return confirmarEnvio();" >
                        Enviar
                        <span class="glyphicon glyphicon-send" aria-hidden="true"></span>
                    </button>
                </p>
            </form>
        </div>
    </div>
    <div class="col-sm-12">
        <div class="panel-footer" style="background: none;">
            <h6 class="text-success text-center">
                Desenvolvido por NewTech&trade; 2024
                <br>
                <br>
                <a href="https://github.com/NewTechEmp/projeto-desktop" target="_blank">Newtech</a>
            </h6>
        </div>
    </div>
</div>
<script type="text/javascript">
function confirmarEnvio() {
    // Exibe a caixa de confirmação
    var resposta = confirm("Você está enviando uma mensagem ao nosso suporte, OK?");
    
    // Se o usuário clicar em "OK", retorna true e a navegação prossegue
    // Se o usuário clicar em "Cancelar", retorna false e a navegação é interrompida
    return resposta;
}
</script>