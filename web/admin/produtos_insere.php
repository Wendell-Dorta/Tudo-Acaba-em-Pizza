<?php
include 'acesso_com.php';
include '../conn/connect.php';

function formatString($string) {
    // Substitui todos os caracteres que não sejam letras, números ou espaços por underscores
    return preg_replace('/[^a-zA-Z0-9]/', '_', $string);
}
// implementação backend a partir daqui...
if ($_POST){
    if(isset($_POST['enviar'])){
        // pegando a imagem
        $nome_img = $_FILES['imagefile']['name'];
        $tmp_img = $_FILES['imagefile']['tmp_name'];
        // Gerar um número aleatório
        $numeroAleatorio = rand(100000, 999999);
        // Obtendo dados do usuário
        $usuarioId = $_SESSION['id_usuario'];
        $usuarioNome = formatString($_SESSION['nome_usuario']); // Nome do usuário formatado
        $usuarioEmail = formatString($_SESSION['email_usuario']); // Email do usuário formatado
        $dataAtual = new DateTime(); // Data e hora atual
        $dataFormatada = $dataAtual->format('Y_m_d_H_i_s'); // Data e hora formatadas
        $nivelUsuario = formatString($_SESSION['nivel_usuario']); // Nível do usuário formatado
        $enderecoIp = filter_input(INPUT_SERVER, REMOTE_ADDR,FILTER_VALIDADE_IP); // IP formatado
        $ipFormatado = str_replace(".","_",$enderecoIp);
        // Extraindo a extensão e o nome base do arquivo
        $extensaoArquivo = pathinfo($nome_img, PATHINFO_EXTENSION); // Extensão da imagem
        $nomeBase = pathinfo($nome_img, PATHINFO_FILENAME); // Nome base da imagem
        $nomeFormatado = formatString($nomeBase);
        // Montando o novo nome do arquivo
        $nomeFormatado = str_replace(" ","_",$nomeBase);
        $novoNomeArquivo = "$enderecoIp-$usuarioId-$usuarioNome-$usuarioEmail-$nivelUsuario-$dataFormatada-$numeroAleatorio-$nomeFormatado.$extensaoArquivo";
        // movendo a imagem para a pasta
        $dir_img = "../images/".$novoNomeArquivo;
        move_uploaded_file($tmp_img, $dir_img);
    }
    $categoria_id = $_POST['categoria_id'];
    $rotulo = $_POST['rotulo'];
    $descricao = $_POST['descricao'];
    $valor = $_POST['valor'];
    $cod_barras = $_POST['cod_barras'];
    $imagem = $rand.$nome_img;
    $destaque = $_POST['destaque']; 
    $insereProduto = "INSERT produtos (rotulo,descricao,valor_unit,cod_barras,nome_imagem,destaque,categoria_id)
    VALUES ('$rotulo','$descricao',$valor,'$cod_barras','$novoNomeArquivo','$destaque','$categoria_id')";

    $resultado = $conn->query($insereProduto);
    if (mysqli_insert_id($conn)) {
        header('location:produtos_lista.php');
}

}
// selecionar a lista de categorias para preencher <select>
$ListaCat = $conn->query("select * from categorias order by descricao"); 
$rowCat = $ListaCat->fetch_assoc();
$numLinhas = $ListaCat->num_rows;
?>
<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>PRODUTOS INSERE - COWABUNGA</title>
</head>

<body>
    <?php include "menu_adm.php";?>
    <main class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-success">
                    <a href="produtos_lista.php">
                        <button class="btn btn-success">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    Inserindo Produtos 
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-success" role="alert">
                        <form action="produtos_insere.php" method="post" name="form_insere"
                            enctype="multipart/form-data" id="form_insere">
                            <label for="categoria_id">Categoria:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-tasks" aria-hidden="true"></span>
                                </span>
                                <select name="categoria_id" id="categoria_id" class="form-control" required>
                                    <?php do{
                                        if ($rowCat !== null) {
                                        ?>


                                    <option value="<?php echo $rowCat['id'];?>">
                                        <!-- buscar tipo -->
                                        <?php echo $rowCat['descricao'];?>

                                    </option>
                                    <?php }} while($rowCat = $ListaCat->fetch_assoc());?>
                                </select>
                            </div>
                            <label for="destaque">Destaque:</label>
                            <div class="input-group">
                                <label for="destaque_s" class="radio-inline">
                                    <input type="radio" name="destaque" id="destaque" value="1">Sim
                                </label>
                                <label for="destaque_n" class="radio-inline">
                                    <input type="radio" name="destaque" id="destaque" value="0" checked>Não
                                </label>
                            </div>
                            <label for="rotulo">Rótulo:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="rotulo" id="rotulo" class="form-control"
                                    placeholder="Digite o rótulo do produto" maxlength="100" required>
                            </div>

                            <label for="descricao">Descrição:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-list-alt" aria-hidden="true"></span>
                                </span>
                                <textarea name="descricao" id="descricao" cols="30" rows="8" class="form-control"
                                    placeholder="Digite a descrição do produto" required></textarea>
                            </div>

                            <label for="valor">Valor:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-tags" aria-hidden="true"></span>
                                </span>
                                <input type="number" name="valor" id="valor" class="form-control" required min="0"
                                    step="0.01">
                            </div>
                            <label for="cod_barras">Código de barras:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="cod_barras" id="cod_barras" class="form-control"
                                    placeholder="Digite o código do produto" maxlength="20" required>
                            </div>
                            <label for="imagem">Imagem:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-picture" aria-hidden="true"></span>
                                </span>
                                <img src="" name="imagem" id="imagem" class="img-responsive">
                                <input type="file" name="imagefile" id="imagefile" class="form-control"
                                    accept="image/*">
                            </div>

                            <br>
                            <input type="submit" name="enviar" id="enviar" class="btn btn-success btn-block"
                                value="Cadastrar">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- Script para imagem -->
    <script>
    document.getElementById("imagem").onchange = function() {
        var reader = new FileReader();
        if (this.files[0].size > 512000) {
            alert("A imagem deve ter no máximo 500KB");
            $("#imagem").attr("src", "blank");
            $("#imagem").hide();
            $("#imagem").wrap('<form>').closest('form').get(0).reset();
            $("#imagem").unwrap();
            return false
        }
        if (this.files[0].type.indexOf("image") == -1) {
            alert("formato inválido, escolha uma imagem!");
            $("#imagem").attr("src", "blank");
            $("#imagem").hide();
            $("#imagem").wrap('<form>').closest('form').get(0).reset();
            $("#imagem").unwrap();
            return false
        }
        reader.onload = function(e) {
            document.getElementById("imagem").src = e.target.result
            $("#imagem").show();
        }
        reader.readAsDataURL(this.files[0])
    }
    </script>

</body>

</html>
