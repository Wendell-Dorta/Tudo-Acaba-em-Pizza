-- criando banco
DROP DATABASE IF EXISTS Tudo_Acaba_em_Pizza_DB;
CREATE DATABASE IF NOT EXISTS Tudo_Acaba_em_Pizza_DB;
USE Tudo_Acaba_em_Pizza_DB;
-- -------------------------------------------------
-- criando tabelas
-- -------------------------------------------------
-- tipos_telefone
-- -------------------------------------------------
CREATE TABLE tipos_telefone (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_tipo_telefone PRIMARY KEY(id)
);
-- -------------------------------------------------
-- telefones
-- -------------------------------------------------
CREATE TABLE telefones (
    id INT NOT NULL AUTO_INCREMENT,
    ddi VARCHAR(3) NOT NULL,
    ddd CHAR(2) NOT NULL,
    numero CHAR(9) NOT NULL,
    ativo BIT(1) NOT NULL,
    tipo_telefone_id INT NOT NULL,
    cliente_id INT NOT NULL,
    CONSTRAINT pk_telefones PRIMARY KEY(id)
);
-- -------------------------------------------------
-- tipos_endereco
-- -------------------------------------------------
CREATE TABLE tipos_endereco (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_tipo_enderecos PRIMARY KEY(id)
);
-- -------------------------------------------------
-- enderecos
-- -------------------------------------------------
CREATE TABLE enderecos (
    id INT NOT NULL AUTO_INCREMENT,
    cep CHAR(8) NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(40) NOT NULL,
    complemento VARCHAR(60) NULL,
    bairro VARCHAR(60) NOT NULL,
    cidade VARCHAR(60) NOT NULL,
    uf CHAR(2) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    cliente_id INT NOT NULL,
    tipo_endereco_id INT NOT NULL,
    CONSTRAINT pk_enderecos PRIMARY KEY(id)
);
-- -------------------------------------------------
-- niveis
-- -------------------------------------------------
CREATE TABLE niveis (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_nivel PRIMARY KEY(id)
);
-- -------------------------------------------------
-- usuarios
-- -------------------------------------------------
CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    data_cad TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ativo BIT(1) NOT NULL DEFAULT 1,
    nivel_id INT NOT NULL,
    CONSTRAINT pk_usuario PRIMARY KEY(id)
);
-- -------------------------------------------------
-- clientes
-- -------------------------------------------------
CREATE TABLE clientes (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INT NOT NULL,
    data_nasc DATETIME NOT NULL,
    cpf CHAR(11) NOT NULL,
    CONSTRAINT pk_cliente PRIMARY KEY(id)
);
-- -------------------------------------------------
-- categorias
-- -------------------------------------------------
CREATE TABLE categorias (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_categoria PRIMARY KEY(id)
);
-- -------------------------------------------------
-- produtos
-- -------------------------------------------------
CREATE TABLE produtos(
    id INT NOT NULL AUTO_INCREMENT,
    rotulo VARCHAR(45) NOT NULL,
    descricao VARCHAR(150) NOT NULL,
    valor_unit DECIMAL(10,2) NOT NULL,
    cod_barras VARCHAR(20) NULL UNIQUE,
    nome_imagem VARCHAR(200) NOT NULL,
    destaque BIT(1) NOT NULL DEFAULT 0,
    data_cad TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    ativo BIT(1) NOT NULL DEFAULT 1,
    categoria_id INT NOT NULL,
    CONSTRAINT pk_produto PRIMARY KEY(id)
);
-- -------------------------------------------------
-- avaliacoes
-- -------------------------------------------------
CREATE TABLE avaliacoes (
    id INT NOT NULL AUTO_INCREMENT,
    nota DECIMAL(3,2) NOT NULL,
    comentario VARCHAR(255) NULL,
    data_avaliacao TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    cliente_id INT NOT NULL,
    produto_id INT NOT NULL,
    CONSTRAINT pk_avaliacao PRIMARY KEY(id)
);
-- -------------------------------------------------
-- status
-- -------------------------------------------------
CREATE TABLE `status` (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_status PRIMARY KEY(id)
);
-- -------------------------------------------------
-- tamanhos_pizza
-- -------------------------------------------------
CREATE TABLE tamanhos_pizza (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_tamanho_pizza PRIMARY KEY(id)
);
-- -------------------------------------------------
-- classes_desconto
-- -------------------------------------------------
CREATE TABLE classes_desconto (
    id INT NOT NULL AUTO_INCREMENT,
    desconto DECIMAL(10,2) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_classes_desconto PRIMARY KEY(id)
);
-- -------------------------------------------------
-- caixas
-- -------------------------------------------------
CREATE TABLE caixas (
    id INT NOT NULL AUTO_INCREMENT,
    data_abertura DATETIME NOT NULL DEFAULT NOW(),
    data_fechamento DATETIME NOT NULL,
    saldo_inicial DECIMAL (10,2) NOT NULL,
    aberto BIT(1) NOT NULL DEFAULT 0,
    usuario_id INT NOT NULL,
    CONSTRAINT pk_caixa PRIMARY KEY(id)
);
-- -------------------------------------------------
-- pedidos
-- -------------------------------------------------
CREATE TABLE pedidos (
    id INT NOT NULL AUTO_INCREMENT,
    data_pedido TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    usuario_id INT NULL,
    cliente_id INT NOT NULL,
    classe_desconto_id INT NOT NULL,
    status_id INT NOT NULL,
    CONSTRAINT pk_pedido PRIMARY KEY(id)
);
-- -------------------------------------------------
-- item_pedido
-- -------------------------------------------------
CREATE TABLE item_pedido (
    id INT NOT NULL AUTO_INCREMENT,
    valor_unit DECIMAL(10,2) NOT NULL,
    quantidade DECIMAL(10,2) NOT NULL,
    pedido_id INT NOT NULL,
    produto_id INT NOT NULL,
    tamanho_pizza_id INT NOT NULL,
    pizza_meia BIT(1) NULL DEFAULT 0,
    produto_sabor_dois_id INT NOT NULL,
    CONSTRAINT pk_item_pedido PRIMARY KEY(id)
);
-- -------------------------------------------------
-- tipos_borda
-- -------------------------------------------------
CREATE TABLE tipos_borda (
    id INT NOT NULL AUTO_INCREMENT,
    preco DECIMAL(10,2) NOT NULL,
    descricao VARCHAR(100) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_tipo_borda PRIMARY KEY(id)
);
-- -------------------------------------------------
-- item_pedido_tipo_borda
-- -------------------------------------------------
CREATE TABLE item_pedido_tipo_borda (
    id INT NOT NULL AUTO_INCREMENT,
    tipo_borda_id INT NOT NULL,
    item_pedido_id INT NOT NULL,
    CONSTRAINT pk_item_pedido_tipo_borda PRIMARY KEY(id)
);
-- -------------------------------------------------
-- adicionais
-- -------------------------------------------------
CREATE TABLE adicionais (
    id INT NOT NULL AUTO_INCREMENT,
    preco DECIMAL(10,2) NOT NULL,
    descricao VARCHAR(100) NOT NULL,
    ativo BIT(1) NOT NULL DEFAULT 1,
    CONSTRAINT pk_adicional PRIMARY KEY(id)
);
-- -------------------------------------------------
-- item_pedido_adicional
-- -------------------------------------------------
CREATE TABLE item_pedido_adicional (
    id INT NOT NULL AUTO_INCREMENT,
    adicional_id INT NOT NULL,
    item_pedido_id INT NOT NULL,
    CONSTRAINT pk_item_pedido_tipo_borda PRIMARY KEY(id)
);
-- -------------------------------------------------
-- tipos_pagamento
-- -------------------------------------------------
CREATE TABLE tipos_pagamento (
    id INT NOT NULL AUTO_INCREMENT,
    sigla CHAR(3) NOT NULL,
    descricao VARCHAR(30) NOT NULL,
    CONSTRAINT pk_tamanho_pizza PRIMARY KEY(id)
);
-- -------------------------------------------------
-- pagamentos
-- -------------------------------------------------
CREATE TABLE pagamentos (
    id INT NOT NULL AUTO_INCREMENT,
    parcelas TINYINT(2) NOT NULL DEFAULT 1,
    data_pag TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
    pedido_id INT NOT NULL,
    tipo_pagamento_id INT NOT NULL,
    status_id INT NOT NULL,
    CONSTRAINT pk_pagamento PRIMARY KEY(id)
);
-- -------------------------------------------------
-- Adicionando Chaves estrangeiras
-- -------------------------------------------------
-- telefones
-- -------------------------------------------------
ALTER TABLE telefones
ADD CONSTRAINT fk_tipo_telefone_id FOREIGN KEY (tipo_telefone_id)
REFERENCES tipos_telefone(id);
ALTER TABLE telefones
ADD CONSTRAINT fk_cliente_telefones_id FOREIGN KEY (cliente_id)
REFERENCES clientes(id);
-- -------------------------------------------------
-- enderecos
-- -------------------------------------------------
ALTER TABLE enderecos
ADD CONSTRAINT fk_tipo_endereco_id FOREIGN KEY (tipo_endereco_id)
REFERENCES tipos_endereco(id);
ALTER TABLE enderecos
ADD CONSTRAINT fk_cliente_enderecos_id FOREIGN KEY (cliente_id)
REFERENCES clientes(id);
-- -------------------------------------------------
-- usuarios
-- -------------------------------------------------
ALTER TABLE usuarios
ADD CONSTRAINT fk_nivel_id FOREIGN KEY (nivel_id)
REFERENCES niveis(id);
-- -------------------------------------------------
-- clientes
-- -------------------------------------------------
ALTER TABLE clientes
ADD CONSTRAINT fk_usuario_clientes_id FOREIGN KEY (usuario_id)
REFERENCES usuarios(id);
-- -------------------------------------------------
-- produtos
-- -------------------------------------------------
ALTER TABLE produtos
ADD CONSTRAINT fk_categoria_id FOREIGN KEY (categoria_id)
REFERENCES categorias(id);
-- -------------------------------------------------
-- avaliacoes
-- -------------------------------------------------
ALTER TABLE avaliacoes
ADD CONSTRAINT fk_cliente_avaliacoes_id FOREIGN KEY (cliente_id)
REFERENCES clientes(id);
ALTER TABLE avaliacoes
ADD CONSTRAINT fk_produto_avaliacoes_id FOREIGN KEY (produto_id)
REFERENCES produtos(id);
-- -------------------------------------------------
-- caixas
-- -------------------------------------------------
ALTER TABLE caixas
ADD CONSTRAINT fk_usuario_caixas_id FOREIGN KEY (usuario_id)
REFERENCES usuarios(id);
-- -------------------------------------------------
-- pedidos
-- -------------------------------------------------
ALTER TABLE pedidos
ADD CONSTRAINT fk_usario_pedidos_id FOREIGN KEY (usuario_id)
REFERENCES usuarios(id);
ALTER TABLE pedidos
ADD CONSTRAINT fk_cliente_pedidos_id FOREIGN KEY (cliente_id)
REFERENCES clientes(id);
ALTER TABLE pedidos
ADD CONSTRAINT fk_classe_desconto_pedidos_id FOREIGN KEY (classe_desconto_id)
REFERENCES classes_desconto(id);
ALTER TABLE pedidos
ADD CONSTRAINT fk_status_pedidos_id FOREIGN KEY (status_id)
REFERENCES `status`(id);
-- -------------------------------------------------
-- item_pedidos
-- -------------------------------------------------
ALTER TABLE item_pedido
ADD CONSTRAINT fk_pedido_item_pedido_id FOREIGN KEY (pedido_id)
REFERENCES pedidos(id);
ALTER TABLE item_pedido
ADD CONSTRAINT fk_produto_item_pedido_id FOREIGN KEY (produto_id)
REFERENCES produtos(id);
ALTER TABLE item_pedido
ADD CONSTRAINT fk_tamanho_pizza_item_pedido_id FOREIGN KEY (tamanho_pizza_id)
REFERENCES tamanhos_pizza(id);
ALTER TABLE item_pedido
ADD CONSTRAINT fk_produto_sabor_dois_item_pedido_id FOREIGN KEY (produto_sabor_dois_id)
REFERENCES produtos(id);
-- -------------------------------------------------
-- item_pedido_tipo_borda
-- -------------------------------------------------
ALTER TABLE item_pedido_tipo_borda
ADD CONSTRAINT fk_tipo_borda_item_pedido_tipo_borda_id FOREIGN KEY (tipo_borda_id)
REFERENCES tipos_borda(id);
ALTER TABLE item_pedido_tipo_borda
ADD CONSTRAINT fk_item_pedido_item_pedido_tipo_borda_id FOREIGN KEY (item_pedido_id)
REFERENCES item_pedido(id);
-- -------------------------------------------------
-- item_pedido_adicional
-- -------------------------------------------------
ALTER TABLE item_pedido_adicional
ADD CONSTRAINT fk_adicional_item_pedido_adicional_id FOREIGN KEY (adicional_id)
REFERENCES adicionais(id);
ALTER TABLE item_pedido_adicional
ADD CONSTRAINT fk_item_pedido_item_pedido_adicional_id FOREIGN KEY (item_pedido_id)
REFERENCES item_pedido(id);
-- -------------------------------------------------
-- pagamento
-- -------------------------------------------------
ALTER TABLE pagamentos
ADD CONSTRAINT fk_tipo_pagamento_pagamentos_id FOREIGN KEY (tipo_pagamento_id)
REFERENCES tipos_pagamento(id);
ALTER TABLE pagamentos
ADD CONSTRAINT fk_pedido_pagamento_pedido_id FOREIGN KEY (pedido_id)
REFERENCES pedidos(id);
ALTER TABLE pagamentos
ADD CONSTRAINT fk_status_pagamento_pedido_id FOREIGN KEY (status_id)
REFERENCES `status`(id);
-- -------------------------------------------------
 
-- -------------------------------------------------
-- Criando views
-- -------------------------------------------------
-- Clientes
-- -------------------------------------------------
CREATE OR REPLACE VIEW vw_cliente AS
SELECT
  us.id,
  us.nome,
  us.email,
  us.senha,
  us.data_cad,
  us.ativo as 'ativo_usuario',
  us.nivel_id,
  cl.id AS 'id_do_cliente',
  cl.cpf,
  cl.data_nasc,
  en.cep,
  en.ativo AS 'endereco_ativo',
  en.tipo_endereco_id,
  en.logradouro,
  en.numero 'numero_moradia',
  en.complemento,
  en.bairro,
  en.cidade,
  en.uf,
  tl.id AS 'id_do_telefone_cliente',
  tl.ddi,
  tl.ddd,
  tl.numero as 'numero_telefone',
  tl.tipo_telefone_id,
  tl.ativo as 'ativo_telefone'
FROM
  clientes cl
  JOIN usuarios us ON cl.usuario_id = us.id
  JOIN enderecos en ON cl.id = en.cliente_id
  JOIN telefones tl ON cl.id = tl.cliente_id;
-- -------------------------------------------------
--  DROP VIEW vw_produto
-- -------------------------------------------------
CREATE OR REPLACE VIEW vw_produto AS
SELECT
  pr.id AS id_do_produto,
  pr.rotulo,
  pr.descricao,
  pr.valor_unit,
  pr.cod_barras,
  pr.nome_imagem,
  pr.destaque,
  pr.data_cad,
  pr.ativo,
  ca.descricao AS categoria_descricao,
  ca.id as categoria_id,
  ca.sigla AS categoria_sigla
FROM
  produtos pr
  JOIN categorias ca ON pr.categoria_id = ca.id;
-- -------------------------------------------------
-- pedidos
-- -------------------------------------------------
-- View TudoAcabaEmPizzaDB.vw_pedido
CREATE OR REPLACE VIEW vw_pedido AS
SELECT
  pe.id,
  us.nome AS usuario_nome,
  us.nome AS cliente_nome,
  cl.cpf,
  cd.descricao,
  st.sigla AS status_sigla,
  pe.data_pedido,
  ip.id as id_do_item,
  ip.produto_id,
  ip.valor_unit,
  ip.quantidade,
  ip.tamanho_pizza_id,
  ip.pizza_meia,
  ip.produto_sabor_dois_id
FROM
  pedidos pe
  JOIN usuarios us ON pe.usuario_id = us.id
  JOIN clientes cl ON pe.cliente_id = cl.id
  JOIN classes_desconto cd ON pe.classe_desconto_id = cd.id
  JOIN `status` st ON pe.status_id = st.id
  JOIN item_pedido ip ON pe.id = ip.pedido_id;
-- -------------------------------------------------
-- criando procedures
-- -------------------------------------------------
-- -----------------------------------------------------
-- procedure sp_adicionais_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_adicionais_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update adicionais set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_adicionais_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_adicionais_insert` (
    spdescricao varchar(100),
    sppreco decimal(10,2)
)
BEGIN
    insert into adicionais values(0,spdescricao,sppreco,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_adicionais_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_adicionais_update` (
    spid int,
    spdescricao varchar(100),
    sppreco decimal(10,2)
)
BEGIN
    update adicionais set descricao = spdescricao, preco = sppreco where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_avaliacoes_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_avaliacoes_insert` (
    -- parametros da procedure
    spnota decimal(3,2),
    spcomentario varchar(200),
    spcliente_id int,
    spproduto_id int
)
BEGIN
    insert into avaliacoes values (0,spnota, spcomentario, default, spcliente_id, spproduto_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_avaliacoes_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_avaliacoes_update` (
    spid int,
    spnota decimal(3,2),
    spcomentario varchar(200)
)
BEGIN
    update avaliacoes set nota = spnota, comentario = spcomentario where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_caixa_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_caixa_insert` ()
BEGIN
 
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_caixa_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_caixa_update` ()
BEGIN
 
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_caixa_fechar
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_caixa_fechar` ()
BEGIN
 
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_categoria_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_categoria_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update categorias set ativo = 0 where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- drop procedure sp_categoria_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_categoria_insert` (
    spdescricao varchar(40),
    spsigla char(3)
)
BEGIN
    insert into categorias values (0,spsigla,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_categoria_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_categoria_update` (
    spid int,
    spdescricao varchar(40),
    spsigla char(3)
)
BEGIN
    update categorias set descricao = spdescricao, sigla = spsigla where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_classedesconto_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_classedesconto_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update classes_desconto set ativo = 0 where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_classedesconto_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_classedesconto_insert` (
    spdescricao varchar(45),
    spdesconto decimal(10,2)
)
BEGIN
    insert into classes_desconto values (0,spsnome,spdesconto,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_classedesconto_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_classedesconto_update` (
    spid int,
    spdescricao varchar(45),
    spdesconto decimal(10,2)
)
BEGIN
    update classes_desconto set descricao = spdescricao, desconto = spdesconto where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_enderecos_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_enderecos_delete` (    
    -- parametros da procedure
    spid int,
    spativo bit(1)
)
BEGIN
    update enderecos set ativo = 0 where spid = id;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_enderecos_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_enderecos_insert` (    
    -- parametros da procedure
    spid int,
    spcep char(8),
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2),
    spcliente_id int,
    sptipo_endereco_id int
)
BEGIN
    insert enderecos values (0,spcep,default,sp_tipoendereco_id,splogradouro,spnumero,spcomplemento,spbairro,spcidade,spuf);
    select * from enderecos where id = last_insert_id();
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_enderecos_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_enderecos_update` (
    -- parametros da procedure
    spid int,
    sptipo_endereco_id int,
    spcep char(8),
    splogradouro varchar(100),
    spnumero varchar(40),
    spcomplemento varchar(60),
    spbairro varchar(60),
    spcidade varchar(60),
    spuf char(2)
)
BEGIN
    update enderecos set
                        spid = id,
                        tipo_endereco_id = sptipo_endereco_id,
                        cep = spcep,
                        logradouro = splogradouro,
                        numero = spnumero,
                        complemento = spcomplemento,
                        bairro = spbairro,
                        cidade = spcidade,
                        uf = spuf    
    where spid = id;
    select * from enderecos where id = last_insert_id();
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_tipoborda_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_tipoborda_delete` (
    spid int
)
BEGIN
    delete from item_pedido_tipo_borda where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_tipoborda_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_tipoborda_insert` (
    sppedido_id int,
    sptipoborda_id int
)
BEGIN
    insert into item_pedido_tipo_borda values (0,sppedido_id,sptipoborda_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_delete` (
    spid int
)
BEGIN
    delete from item_pedido where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_insert` (
    spquantidade decimal(10,2),
    sppedido_id int,
    spprodutos_id int,
    sptamanho_pizza_id int,
    sppizza_meia BIT(1),
    spproduto_sabor_dois_id int
)
BEGIN
    insert into item_pedido values (0, (select valor_unit from produtos where id = spproduto_id),spquantidade, sppedido_id, spproduto_id,sptamanho_pizza_id,sppizza_meia,spproduto_sabor_dois_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_update` (
    spid int,
    spquantidade decimal(10,2)
)
BEGIN
    update item_pedido set quantidade = spquantidade where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_niveis_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_niveis_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update niveis set ativo = 0 where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- drop procedure sp_niveis_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_niveis_insert` (
    spdescricao varchar(45),
    spsigla char(3)
)
BEGIN
    insert into niveis values (0,spsigla,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_niveis_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_niveis_update` (
    spid int,
    spdescricao varchar(45),
    spsigla char(3)
)
BEGIN
    update niveis set descricao = spdescricao, sigla = spsigla where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_pagamento_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_pagamento_insert` (
    spparcelas tinyint(2),
    spdata_pag TIMESTAMP,
    sppedido_id INT,
    sptipo_pagamento_id int,
    spstatus_id int
)
BEGIN
    insert into pagamentos values (0,spparcelas,spdata_pag,sppedido_id,sptipo_pagamento_id,spstatus_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_pagamento_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_pagamento_update` (
    spid INT,
    spparcelas tinyint(2),
    spdata_pag TIMESTAMP,
    sppedido_id INT,
    sptipo_pagamento_id int,
    spstatus_id int
)
BEGIN
    UPDATE pagamentos SET parcelas = spparcelas, data_pag = current_timestamp(),tipo_pagamento_id = sptipo_pagamento_id,status_id = spstatus_id WHERE id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_pedido_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_pedido_insert` (
    spdata_pedido TIMESTAMP,
    spusuario_id int,
    spcliente_id int,
    spclasse_desconto_id int,
    spstatus_id int
)
BEGIN
    insert into pedidos values (0,default,spusuario_id,spcliente_id,spclasse_desconto_id,spstatus_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_pedido_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_pedido_delete` (
    spid int
)
BEGIN
    delete from pedidos where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_pedido_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_pedido_update` (
    spid int,
    spstatus_id int,
    spclasse_desconto_id int
)
BEGIN
    update pedidos set status_id = spstatus_id, classe_desconto_id = spclasse_desconto_id where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_adicionais_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_adicionais_delete` (
    spid int
)
BEGIN
    delete from item_pedido_adicional where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_produto_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_produto_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update produtos set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_produto_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_produto_insert` (
    sprotulo varchar(45),
    spdescricao varchar(150),
    spvalor_unit decimal(10,2),
    spcod_barras varchar(60),
    spnome_imagem varchar(200),
    spdestaque BIT(1),
    spcategorias_id int
)
BEGIN
    insert into produtos values (0,sprotulo,spdescricao,spvalor_unit,spcod_barras,spnome_imagem,spdestaque,default,default,spcategorias_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_produto_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_produto_update` (
    spid int,
    sprotulo varchar(45),
    spdescricao varchar(150),
    spvalor_unit decimal(10,2),
    spcod_barras varchar(60),
    spnome_imagem varchar(200),
    spdestaque BIT(1),
    spcategorias_id int
)
BEGIN
    update produtos set nome = sprotulo,descricao = spdescricao, valor_unit = spvalor_unit, cod_barras = spcod_barras, link_imagem = spnome_imagem, destaque = spdestaque, categorias_id = spcategorias_id where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_status_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_status_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update `status` set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_status_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_status_insert` (
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    insert into `status` values (0,spsigla,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_status_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_status_update` (
    spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    update `status` set sigla = spsigla, descricao = spdescricao where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tamanhopizza_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tamanhopizza_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update tamanhos_pizza set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_itempedido_adicionais_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_itempedido_adicionais_insert` (
    spadicional_id int,
    spitem_pedido_id int
)
BEGIN
    insert into item_pedido_adicional values (0,spadicional_id, spitem_pedido_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tamanhopizza_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tamanhopizza_update` (
    spid int,
    spsigla char(1),
    spdescricao varchar(60)
)
BEGIN
    update tamanhos_pizza set sigla = spsigla, descricao = spdescricao where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tamanhopizza_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tamanhopizza_insert` (
    spsigla char(1),
    spdescricao varchar(60)
)
BEGIN
    insert into tamanhos_pizza values (0,spsigla,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_telefone_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_telefone_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update telefones set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_telefone_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_telefone_insert` (
    spddi varchar(3),
    spddd char(2),
    spnumero char(9),
    sptipo_telefone_id int,
    spclientes_id int
)
BEGIN
    insert into telefones values (0,spddi,spddd,spnumero,default,sptipo_telefone_id,spcliente_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_telefone_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_telefone_update` (
    spid int,
    spddi varchar(3),
    spddd char(2),
    spnumero char(9),
    sptipo_telefone_id int
)
BEGIN
    update telefones set ddi = spddi, ddd = spddd, numero = spnumero,tipo_telefone_id = sptipo_telefone_id where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoborda_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoborda_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update tipos_borda set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoborda_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoborda_insert` (
    spdescricao varchar(200),
    sppreco decimal(10,2)
)
BEGIN
    insert into tipos_borda values (0,sppreco,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoborda_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoborda_update` (
    spid int,
    spdescricao varchar(200),
    sppreco decimal(10,2)
)
BEGIN
    update tipos_borda set descricao = spdescricao, preco = sppreco where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_cliente_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_cliente_insert` (
    spusuario_id int,
    spdata_nasc DATETIME,
    spcpf char(11)
)
BEGIN
        insert into clientes values (0, spusuario_id, spdata_nasc, spcpf);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoendereco_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoendereco_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update tipos_endereco set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoendereco_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoendereco_insert` (
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    insert into tipos_endereco values (0,spsigla,spdescricao,default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipoendereco_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipoendereco_update` (
    spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    update tipos_endereco set id = spid, sigla = spsigla, descricao = spdescricao where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipopagamento_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipopagamento_insert` (
    spsigla char(3),
    spdescricao varchar(10)
)
BEGIN
    insert into tipos_pagamento values (0,spsigla,spdescricao);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipotelefone_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipotelefone_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update tipos_telefone set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipotelefone_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipotelefone_insert` (
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    insert into tipos_telefone values (0, spsigla, spdescricao, default);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_tipotelefone_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_tipotelefone_update` (
    spid int,
    spsigla char(3),
    spdescricao varchar(30)
)
BEGIN
    update tipos_telefone set sigla = spsigla, descricao = spdescricao where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_usuario_delete
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_usuario_delete` (
    spid int,
    spativo bit(1)
)
BEGIN
    update usuarios set ativo = spativo where id = spid;
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_usuario_insert
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_usuario_insert` (
    spnome varchar(60),
    spemail varchar(60),
    spsenha varchar(255),
    spniveis_id int
)
BEGIN
    insert into usuarios values (0,spnome,spemail,spsenha,default,default,spniveis_id);
END$$
 
DELIMITER ;
 
-- -----------------------------------------------------
-- procedure sp_usuario_update
-- -----------------------------------------------------
 
DELIMITER $$
USE `tudo_acaba_em_pizza_db`$$
CREATE PROCEDURE `sp_usuario_update` (
    spid int,
    spnome varchar(60),
    spsenha varchar(255),
    spniveis_id int
)
BEGIN
    update usuarios set nome = spnome, senha = spsenha, niveis_id = spniveis_id where id = spid;
END$$
 
DELIMITER ;
 
 
INSERT INTO niveis (sigla, descricao, ativo)
VALUES ('ADM', 'Administração', 1);
INSERT INTO niveis (sigla, descricao, ativo)
VALUES ('COM', 'Comum', 1);
 
INSERT INTO usuarios (nome, email, senha, ativo, nivel_id)
VALUES ('admin', 'admin@gmail.com', '1234',1 ,1);