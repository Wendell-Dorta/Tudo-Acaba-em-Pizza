<?php
include 'acesso_com.php';
include '../conn/connect.php';

if($_POST){ //se o usuario clicou no botão atualizar
    if($_FILES['imagemfile']['name']){ // se o usuario escolher um imagem
        unlink("../images/".$_POST['imagem_atual']); //apaga a imagem atual
        $nome_img = $_FILES['imagemfile']['name'];
        $tmp_img = $_FILES['imagemfile']['tmp_name'];
        // $rand = rand(100001,999999); //gera um numero aleatorio da imagem para diferenciar
        $dir_img = "../images/".$nome_img;
        move_uploaded_file($tmp_img, $dir_img); // tranfere a imagem para a pasta
        $nome_img = $nome_img;
    }else{
        $nome_img = $_POST['imagem_atual'];
    }
    $id = $_POST['id'];
    $rotulo = $_POST['rotulo'];
    $descricao = $_POST['descricao'];
    $valor = $_POST['valor'];
    $nome_img = $_POST['imagem_atual'];
    $destaque = $_POST['destaque'];
    $id_categoria = $_POST['categoria_id'];
    
 
    $update = "update produtos
    set  rotulo = '$rotulo',
    descricao = '$descricao',
    valor_unit = '$valor',
    nome_imagem  = '$nome_img',
    destaque = '$destaque',
    categoria_id = '$id_categoria'
    where id = $id;";
    $resultado = $conn->query($update);
 
    if($resultado){
    header('location:produtos_lista.php');
    }
}
    if ($_GET){
        $id_form = $_GET['id'];
    }else{
    $id_form = 0;
    }
   
 
$lista = $conn->query('select * from produtos where id ='.$id_form);
$row = $lista->fetch_assoc();
 
$listaCat = $conn->query("select * from categorias order by descricao");
$rowTipo = $lista->fetch_assoc();
$numLinhas = $lista->num_rows;
 
?>
<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/estilo.css">
    <title>Produto - Atualiza</title>
</head>

<body>
    <?php include "menu_adm.php";?>
    <main class="container">

        <div class="row">
            <div class="col-xs-12 col-sm-offset-2 col-sm-6  col-md-8">
                <h2 class="breadcrumb text-c">
                    <a href="produtos_lista.php">
                        <button class="btn btn-success">
                            <span class="glyphicon glyphicon-chevron-left"></span>
                        </button>
                    </a>
                    Atualizando Produtos
                </h2>
                <div class="thumbnail">
                    <div class="alert alert-success" role="alert">
                        <form action="produtos_atualiza.php" method="post" name="form_insere"
                            enctype="multipart/form-data" id="form_insere">
                            <!-- O campo id deve permanecer oculto por isso estamos usando o hidden  -->
                            <input type="hidden" name="id" id="id" value="<?php echo $row['id'];?>">

                            <label for="categoria_id">Categoria:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-tasks" aria-hidden="true"></span>
                                </span>
                                <select name="categoria_id" id="categoria_id" class="form-control" required>
                                    <?php do {?>
                                    <option value="<?php echo $rowTipo['id'] ?>" <?php
 
                                            //$strcmp = a string comper comparação recebe duas string e devolve inteiro
                                                if (!(strcmp($rowTipo['id'],$row['categoria_id']))){
                                                     echo "selected=\"selected\"";  
                                                   
                                                }
                                            ?>>
                                        <?php echo $rowTipo['descricao'] ?>
                                    </option>
                                    <?php }while($rowTipo = $listaCat->fetch_assoc());?>
                                </select>
                            </div>
                            <label for="destaque">Destaque:</label>
                            <div class="input-group">
                                <label for="destaque_s" class="radio-inline">
                                    <input type="radio" name="destaque" id="destaque" value="1"
                                        <?php echo $row['destaque']=="1"?'checked':null; ?>>Sim
                                </label>
                                <label for="destaque_n" class="radio-inline">
                                    <input type="radio" name="destaque" id="destaque" value="0"
                                        <?php echo $row['destaque']=="0"?'checked':null; ?>>Não
                                </label>
                            </div>
                            <label for="rotulo">Rótulo:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-cutlery" aria-hidden="true"></span>
                                </span>
                                <input type="text" name="rotulo" id="rotulo" class="form-control"
                                    placeholder="Digite o nome do Produto" maxlength="100"
                                    value="<?php echo $row['rotulo']; ?>">
                            </div>

                            <label for="descricao">Descrição:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-list-alt" aria-hidden="true"></span>
                                </span>
                                <textarea name="descricao" id="descricao" cols="30" rows="8" class="form-control"
                                    placeholder="Digite os detalhes do Produto"> <?php echo $row['descricao'];?></textarea>

                            </div>
                            <label for="valor">Valor:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-tags" aria-hidden="true"></span>
                                </span>
                                <input type="number" name="valor" id="valor" class="form-control" required min="0"
                                    step="0.01" value="<?php echo $row['valor_unit'];?>">
                            </div>

                            <label for="imagem_atual">Imagem Atual:</label>
                            <img src="../images/<?php echo $row['nome_imagem']; ?>" alt="" srcset="">
                            <input type="hidden" name="imagem_atual" id="imagem_atual"
                                value="<?php echo $row['nome_imagem']; ?>">

                            <label for="imagem">Imagem Nova:</label>
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-picture" aria-hidden="true"></span>
                                </span>
                                <img src="" name="imagem" id="imagem" class="img-responsive">
                                <input type="file" name="imagemfile" id="imagemfile" class="form-control"
                                    accept="image/*">
                            </div>

                            <br>
                            <input type="submit" name="atualizar" id="atualizar" class="btn btn-success btn-block"
                                value="Atualizar">
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