<?php
// Import PHPMailer classes into the global namespace
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
use PHPMailer\PHPMailer\Exception;

// Load Composer's autoloader
require 'vendor/autoload.php';

// Recebe valores por POST e faz a validação básica
$nome = htmlspecialchars($_POST['nome_contato'], ENT_QUOTES, 'UTF-8');
$email = filter_var($_POST['email_contato'], FILTER_VALIDATE_EMAIL);
$assunto = htmlspecialchars($_POST['assunto_contato'], ENT_QUOTES, 'UTF-8');
$mensagem = htmlspecialchars($_POST['comentario_contato'], ENT_QUOTES, 'UTF-8');


// Verifica se o email é válido
if (!$email) {
    die('Endereço de e-mail inválido.');
}

$mail = new PHPMailer(true);

try {
    // Configurações do servidor
    $mail->SMTPDebug = SMTP::DEBUG_SERVER;          // Enable verbose debug output
    $mail->isSMTP();                                // Send using SMTP
    $mail->Host       = 'smtp.gmail.com';           // Set the SMTP server to send through
    $mail->SMTPAuth   = true;                       // Enable SMTP authentication
    $mail->Username   = 'cowabungapizzaria05@gmail.com';      // SMTP username (substitua pelo seu email)
    $mail->Password   = 'eizp nxzv jvqm rnca';                // SMTP password (substitua pela sua senha)
    $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS; // Enable TLS encryption
    $mail->Port       = 587;                        // TCP port to connect to

    // Recipients
    $mail->setFrom($email, $nome); // Quem envia
    $mail->addAddress('cowabungapizzaria05@gmail.com', 'Cowabunga Pizzaria');                        // Quem recebe

    // Content
    $mail->isHTML(true);                              // Set email format to HTML
    $mail->Subject = $ass;
    $mail->Body    = $mensagem;

    $mail->send();
    echo 'Email enviado com sucesso!';
} catch (Exception $e) {
    echo "O e-mail não pôde ser enviado. Erro: {$mail->ErrorInfo}";
}

if($mail){
    header('location:index.php');
    }
?>