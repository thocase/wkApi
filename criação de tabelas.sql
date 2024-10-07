CREATE TABLE ProdutoCategoria (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome_categoria VARCHAR(100) NOT NULL,
    descricao TEXT
);

CREATE TABLE Produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome_produto VARCHAR(100) NOT NULL,
    descricao TEXT,
    preco DECIMAL(10, 2) NOT NULL,
    quantidade_estoque INT NOT NULL,
    id_produto_categoria INT,
    FOREIGN KEY (id_produto_categoria) REFERENCES ProdutoCategoria(id)
);

