Para que o aplicativo funcione adequadamente, será necessário criar a database e as 
tabelas no SQL Management Studio 19, lá você terá que fazer uma nova consulta que inclui
os seguintes dados:

CREATE DATABASE ProjetoTeste

USE ProjetoTeste;

CREATE TABLE Aluno (
    RA INT PRIMARY KEY,
    Nome NVARCHAR(100),
    Email NVARCHAR(100),
    Telefone NVARCHAR(20),
    DataNascimento DATE
);
GO

CREATE TABLE Livros (
    Codigo INT PRIMARY KEY,
    RA INT,
    Titulo NVARCHAR(100),
    Autor NVARCHAR(100),
    Categoria NVARCHAR(50),
    Editora NVARCHAR(50),
);
GO

CREATE TABLE EmprestimosLivros (
    Codigo INT PRIMARY KEY,
    DataRetirada DATE,
    DataEntrega DATE,
);
GO
