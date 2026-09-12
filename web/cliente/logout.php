<?php 
    session_name('chulettaaaresss');
    session_start();
    session_destroy();
    header('location:../index.php');
    exit;
?>