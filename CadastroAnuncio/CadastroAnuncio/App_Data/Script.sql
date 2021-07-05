CREATE TABLE Anuncio (
Id INT IDENTITY(1,1) PRIMARY KEY,
NomeAnuncio VARCHAR(150) NOT NULL,
Cliente VARCHAR(150) NOT NULL,
DataInicio DATE NOT NULL,
DataTermino DATE NOT NULL,
InvestimentoPorDia FLOAT NOT NULL
);
INSERT INTO Anuncio (NomeAnuncio, Cliente, DataInicio , DataTermino, InvestimentoPorDia) VALUES ('TesteAnuncio1', 'TesteCliente1', '01/01/2021', '02/02/2022', 20.8)