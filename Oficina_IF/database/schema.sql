CREATE DATABASE IF NOT EXISTS Oficina
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE Oficina;

CREATE TABLE IF NOT EXISTS Cliente (
    IdCliente INT NOT NULL AUTO_INCREMENT,
    NomeCompleto VARCHAR(150) NOT NULL,
    Situacao VARCHAR(20) NOT NULL,
    CPF VARCHAR(14) NOT NULL,
    RG VARCHAR(30) NOT NULL,
    Genero VARCHAR(30) NOT NULL,
    DataNascimento DATE NOT NULL,
    EstadoCivil VARCHAR(50) NOT NULL,
    Profissao VARCHAR(100) NOT NULL,
    Nacionalidade VARCHAR(80) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    Celular VARCHAR(20) NOT NULL,
    Whatsapp VARCHAR(20) NOT NULL,
    Email VARCHAR(254) NOT NULL,
    Endereco VARCHAR(200) NOT NULL,
    Numero VARCHAR(20) NOT NULL,
    Complemento VARCHAR(100) NOT NULL,
    Bairro VARCHAR(100) NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    UF CHAR(2) NOT NULL,
    CEP VARCHAR(9) NOT NULL,
    Observacoes TEXT NOT NULL,
    data_cadastro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (IdCliente)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Servico (
    IdServico INT NOT NULL AUTO_INCREMENT,
    descricao VARCHAR(200) NOT NULL,
    duracao_minutos INT NOT NULL,
    situacao VARCHAR(20) NOT NULL,
    valor DECIMAL(10, 2) NOT NULL,
    data_cadastro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (IdServico)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Usuario (
    IdUsuario INT NOT NULL AUTO_INCREMENT,
    NomeCompleto VARCHAR(150) NOT NULL,
    Usuario VARCHAR(80) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    Situacao VARCHAR(20) NOT NULL,
    PRIMARY KEY (IdUsuario),
    UNIQUE KEY UQ_Usuario_Usuario (Usuario)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS Vendas (
    IdVenda INT NOT NULL AUTO_INCREMENT,
    DatadeVenda DATE NOT NULL,
    IdCliente INT NOT NULL,
    IdUsuario INT NOT NULL,
    IdServico INT NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    Desconto DECIMAL(10, 2) NOT NULL,
    ValorTotal DECIMAL(10, 2) NOT NULL,
    FormaPagamento VARCHAR(50) NOT NULL,
    Situacao VARCHAR(30) NOT NULL,
    Observacoes TEXT NOT NULL,
    PRIMARY KEY (IdVenda),
    KEY IX_Vendas_IdCliente (IdCliente),
    KEY IX_Vendas_IdUsuario (IdUsuario),
    KEY IX_Vendas_IdServico (IdServico),
    CONSTRAINT FK_Vendas_Cliente FOREIGN KEY (IdCliente) REFERENCES Cliente (IdCliente),
    CONSTRAINT FK_Vendas_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario),
    CONSTRAINT FK_Vendas_Servico FOREIGN KEY (IdServico) REFERENCES Servico (IdServico)
) ENGINE=InnoDB;
