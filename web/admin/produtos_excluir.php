<?php
include "../conn/connect.php";

// Verificar se o ID do produto foi fornecido
if (isset($_GET['id']) && is_numeric($_GET['id'])) {
    $id = intval($_GET['id']); // Garantir que o ID seja um inteiro

    // Preparar a consulta para obter o nome da imagem antes de excluí-la
    $stmt = $conn->prepare("SELECT nome_imagem FROM produtos WHERE id = ?");
    $stmt->bind_param("i", $id); // "i" indica que o parâmetro é um inteiro
    $stmt->execute();
    $stmt->bind_result($imagem);
    $stmt->fetch();
    $stmt->close();

    // Verificar se uma imagem foi retornada
    if ($imagem) {
        // Caminho completo da imagem
        $caminhoImagem = "../caminho/para/imagens/" . $imagem;

        // Verificar se o arquivo da imagem existe e excluí-lo
        if (file_exists($caminhoImagem)) {
            if (!unlink($caminhoImagem)) {
                echo "Não foi possível excluir a imagem: " . $imagem;
            }
        } else {
            echo "Imagem não encontrada: " . $imagem;
        }
    }

    // Preparar e executar a consulta para excluir o produto
    $stmt = $conn->prepare("DELETE FROM produtos WHERE id = ?");
    $stmt->bind_param("i", $id); // "i" indica que o parâmetro é um inteiro
    $stmt->execute();

    // Verificar se a exclusão foi bem-sucedida
    if ($stmt->affected_rows > 0) {
        header("Location: produtos_lista.php");
        exit(); // Terminar o script após redirecionar
    } else {
        echo "Nenhum produto encontrado com o ID fornecido.";
    }

    $stmt->close();
} else {
    echo "ID inválido fornecido.";
}

$conn->close();
?>
