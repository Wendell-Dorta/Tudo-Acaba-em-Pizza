<?php
include 'conn/connect.php';
$lista = $conn->query("select * from vw_produto where destaque = 1");
$row_produtos = $lista->fetch_assoc();
$num_linhas = $lista->num_rows;
 
?>
<!-- se consulta retornar vazio -->
<?php if($num_linhas == 0) { ?>
    <h2 class="breadcrum alert-danger">
        Não há produtos destaque !
    </h2>
<?php }?>
 
<?php if($num_linhas > 0) {  ?>
    <h2 class="breadcrumb alert-success">
        Produtos em destaque !
    </h2>
    <div class="row">
        <?php do{ ?>
            <div class="col-sm-6 col-md-4">
                <div class="thumbnail">
                    <a href="produto_detalhes.php?id=<?php echo $row_produtos['id_do_produto'];?>">
                        <img src="images/<?php echo $row_produtos['nome_imagem']; ?>" alt="" class="img-responsive img-rounded">
                    </a>
                    <div class="caption text-right bg-secondary">
                        <h3 class="text-success">
                            <strong><?php echo $row_produtos['rotulo']; ?></strong>
                        </h3>
                        <p class="text-danger">
                            <strong><?php echo $row_produtos['categoria_descricao']; ?></strong>
                        </p>
                        <p class="text-left">
                            <?php echo mb_strimwidth($row_produtos['descricao'],0,42,'...'); ?>
                        </p>
                        <p>
                           <button class="btn btn-default disabled" role="button" style=cursor: default;>
                                <?php echo "R$ " .number_format($row_produtos['valor_unit'],2,',','.') ?>
                            </button>
                            <a href="produto_detalhes.php?id=<?php echo $row_produtos['id_do_produto']; ?>">
                                <span class="hidden-xs">Saiba mais...</span>
                                <span class="hidden-xs glyphicon glyphicon-eye-open" aria-hidden="true"></span>                        
                            </a>
                        </p>
                            <a href="carrinho.php">
                                <button class="btn-block btn-success glyphicon" >
                                    <span class="glyphicon-shopping-cart" aria-hidden="true"></span>
                                    Adicionar ao Carrinho
                                </button>
                            </a>
                    </div>
                </div>
            </div>
        <?php  }while($row_produtos = $lista->fetch_assoc());?>
    </div>
 
<?php }?>
