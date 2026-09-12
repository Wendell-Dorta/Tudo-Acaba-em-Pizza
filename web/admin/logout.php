<?php 
    session_name('cowabungaaa');
    session_start();
    session_destroy();
    header('location:../index.php');
    exit;
?>